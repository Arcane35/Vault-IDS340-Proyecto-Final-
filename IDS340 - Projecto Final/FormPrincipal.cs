using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace IDS340___Projecto_Final
{
    public partial class FormPrincipal : Form
    {

        private Database database;

        public FormPrincipal()
        {
            InitializeComponent();

            database = new Database();
            CargarData();
        }

        ///  METODOS PARA CARGAR Y REFRESCAR PRODUCTOS/CATEGORIAS/PROVEEDORES EN LOS CONTROLES "datGridView" & "ComboBox"

        private void CargarData()
        {
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        private void CargarProductos()
        {
            try
            {
                string query = "SELECT * FROM Productos";
                dataGridViewProductos.DataSource = database.ExecuteQuery(query);
                dataGridViewConsultas.DataSource = database.ExecuteQuery(query);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void CargarCategorias()
        {
            string query = "SELECT * FROM Categorias";
            dataGridViewCategoria.DataSource = database.ExecuteQuery(query);
            cmbCategoriaProducto.DataSource = database.ExecuteQuery(query);
            cmbCategoriaProducto.DisplayMember = "Nombre";
            cmbCategoriaProducto.ValueMember = "Id";
            cmbCategoriaConsulta.DataSource = database.ExecuteQuery(query);
            cmbCategoriaConsulta.DisplayMember = "Nombre";
            cmbCategoriaConsulta.ValueMember = "Id";
        }

        private void CargarProveedores()
        {
            string query = "SELECT * FROM Proveedores";
            dataGridViewProveedor.DataSource = database.ExecuteQuery(query);
            cmbProveedorProducto.DataSource = database.ExecuteQuery(query);
            cmbProveedorProducto.DisplayMember = "NombreEmpresa";
            cmbProveedorProducto.ValueMember = "Id";
            cmbProveedorConsulta.DataSource = database.ExecuteQuery(query);
            cmbProveedorConsulta.DisplayMember = "NombreEmpresa";
            cmbProveedorConsulta.ValueMember = "Id";
        }

        /// PRODUCTOS

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Productos (Nombre, CodigoProducto, Categoria, Precio, Existencia, Proveedor) " +
                "           VALUES (@Nombre, @CodigoProducto, @Categoria, @Precio, @Existencia, @Proveedor)";
            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", txtNombreProducto.Text),
                new SQLiteParameter("@CodigoProducto", txtCodigoProducto.Text),
                new SQLiteParameter("@Categoria", cmbCategoriaProducto.SelectedValue),
                new SQLiteParameter("@Precio", Convert.ToDouble(txtPrecioProducto.Text)),
                new SQLiteParameter("@Existencia", Convert.ToInt32(txtExistenciaProducto.Text)),
                new SQLiteParameter("@Proveedor", cmbProveedorProducto.SelectedValue)
            };

            try
            {
                database.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            // Validación para asegurarse de que se ha seleccionado un producto
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validacion de campos
            if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCodigoProducto.Text) ||
                cmbCategoriaProducto.SelectedValue == null ||
                cmbProveedorProducto.SelectedValue == null ||
                !double.TryParse(txtPrecioProducto.Text, out _) ||
                !int.TryParse(txtExistenciaProducto.Text, out _))
            {
                MessageBox.Show("Por favor, completa todos los campos correctamente.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = @"UPDATE Productos 
                     SET Nombre = @Nombre, 
                         CodigoProducto = @CodigoProducto, 
                         Categoria = @Categoria, 
                         Precio = @Precio, 
                         Existencia = @Existencia, 
                         Proveedor = @Proveedor 
                     WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", txtNombreProducto.Text),
                new SQLiteParameter("@CodigoProducto", txtCodigoProducto.Text),
                new SQLiteParameter("@Categoria", cmbCategoriaProducto.SelectedValue),
                new SQLiteParameter("@Precio", Convert.ToDouble(txtPrecioProducto.Text)),
                new SQLiteParameter("@Existencia", Convert.ToInt32(txtExistenciaProducto.Text)),
                new SQLiteParameter("@Proveedor", cmbProveedorProducto.SelectedValue),
                new SQLiteParameter("@Id", GetSelectedProductId()) 
            };

            try
            {
                database.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            // Validación para asegurarse de que se ha seleccionado un producto
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmResult = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmResult == DialogResult.Yes)
            {
                string query = "DELETE FROM Productos WHERE Id = @Id";
                var parameters = new SQLiteParameter[]
                {
                    new SQLiteParameter("@Id", GetSelectedProductId())
                };

                try
                {
                    database.ExecuteNonQuery(query, parameters);
                    MessageBox.Show("Producto eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarProductos(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al eliminar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private int GetSelectedProductId()
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProductos.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                throw new Exception("Por favor, selecciona un producto.");
            }
        }

        // Método para manejar el cambio de selección en el DataGridView
        private void dataGridViewProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewProductos.SelectedRows[0];

                    txtNombreProducto.Text = selectedRow.Cells["Nombre"].Value?.ToString();
                    txtCodigoProducto.Text = selectedRow.Cells["CodigoProducto"].Value?.ToString();
                    cmbCategoriaProducto.SelectedValue = selectedRow.Cells["Categoria"].Value;
                    txtPrecioProducto.Text = selectedRow.Cells["Precio"].Value?.ToString();
                    txtExistenciaProducto.Text = selectedRow.Cells["Existencia"].Value?.ToString();
                    cmbProveedorProducto.SelectedValue = selectedRow.Cells["Proveedor"].Value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de la fila seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        ///  CATEGORIAS

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Categorias (Nombre, Descripcion) " +
                           "VALUES (@Nombre, @Descripcion)";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", txtNombreCategoria.Text),
                new SQLiteParameter("@Descripcion", txtDescripcionCategoria.Text),
            };

            try
            {
                database.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Categoria agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias(); // Actualizar la tabla después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Categorias 
                     SET Nombre = @Nombre, 
                         Descripcion = @Descripcion 
                     WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Nombre", txtNombreCategoria.Text),
                new SQLiteParameter("@Descripcion", txtDescripcionCategoria.Text),
                new SQLiteParameter("@Id", GetSelectedCategoryId()) // Método para obtener el ID de la categoría seleccionada
            };

            database.ExecuteNonQuery(query, parameters);
            CargarCategorias();
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categorias WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", GetSelectedCategoryId())
            };

            database.ExecuteNonQuery(query, parameters);
            CargarCategorias();
        }

        private int GetSelectedCategoryId()
        {
            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewCategoria.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                throw new Exception("Por favor, selecciona una categoría.");
            }
        }

        // Método para manejar el cambio de selección en el DataGridView
        private void dataGridViewCategoria_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewCategoria.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewCategoria.SelectedRows[0];

                    txtNombreCategoria.Text = selectedRow.Cells["Nombre"].Value?.ToString();
                    txtDescripcionCategoria.Text = selectedRow.Cells["Descripcion"].Value?.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de la fila seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// PROVEEDORES

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Proveedores (NombreEmpresa, Contacto, Direccion, Telefono) " +
                           "VALUES (@NombreEmpresa, @Contacto, @Direccion, @Telefono)";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@NombreEmpresa", txtNombreProveedor.Text),
                new SQLiteParameter("@Contacto", txtContactoProveedor.Text),
                new SQLiteParameter("@Direccion", txtDireccionProveedor.Text),
                new SQLiteParameter("@Telefono", txtTelefonoProveedor.Text),
            };

            try
            {
                database.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Proveedor agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores(); // Actualizar la tabla después de agregar
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditarProveedor_Click(object sender, EventArgs e)
        {
            string query = @"UPDATE Proveedores 
                     SET NombreEmpresa = @NombreEmpresa, 
                         Contacto = @Contacto, 
                         Direccion = @Direccion, 
                         Telefono = @Telefono 
                     WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@NombreEmpresa", txtNombreProveedor.Text),
                new SQLiteParameter("@Contacto", txtContactoProveedor.Text),
                new SQLiteParameter("@Direccion", txtDireccionProveedor.Text),
                new SQLiteParameter("@Telefono", txtTelefonoProveedor.Text),
                new SQLiteParameter("@Id", GetSelectedSupplierId())
            };

            database.ExecuteNonQuery(query, parameters);
            CargarProveedores();
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Proveedores WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", GetSelectedSupplierId())
            };

            database.ExecuteNonQuery(query, parameters);
            CargarProveedores();
        }

        private int GetSelectedSupplierId()
        {
            if (dataGridViewProveedor.SelectedRows.Count > 0)
            {
                return Convert.ToInt32(dataGridViewProveedor.SelectedRows[0].Cells["Id"].Value);
            }
            else
            {
                throw new Exception("Por favor, selecciona un proveedor.");
            }
        }

        // Método para manejar el cambio de selección en el DataGridView
        private void dataGridViewProveedor_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProveedor.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridViewProveedor.SelectedRows[0];

                    txtNombreProveedor.Text = selectedRow.Cells["NombreEmpresa"].Value?.ToString();
                    txtContactoProveedor.Text = selectedRow.Cells["Contacto"].Value?.ToString();
                    txtDireccionProveedor.Text = selectedRow.Cells["Direccion"].Value?.ToString();
                    txtTelefonoProveedor.Text = selectedRow.Cells["Telefono"].Value?.ToString();
                    new SQLiteParameter("@Id", GetSelectedSupplierId());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de la fila seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// CONSULTAS & REPORTES

        // Metodo para filtrar productos segun categoria y proveedor elegido.
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Productos WHERE 1=1";
                var parameters = new List<SQLiteParameter>();

                // Verificar si hay una categoría seleccionada
                if (cmbCategoriaConsulta.SelectedValue != null)
                {
                    query += " AND Categoria = @Categoria";
                    parameters.Add(new SQLiteParameter("@Categoria", cmbCategoriaConsulta.SelectedValue));
                }

                // Verificar si hay un proveedor seleccionado
                if (cmbProveedorConsulta.SelectedValue != null)
                {
                    query += " AND Proveedor = @Proveedor";
                    parameters.Add(new SQLiteParameter("@Proveedor", cmbProveedorConsulta.SelectedValue));
                }

                // Ejecutar consulta y mostrar resultados
                dataGridViewConsultas.DataSource = database.ExecuteQuery(query, parameters.ToArray());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para mostrar productos con stock bajo.
        private void btnMostrarStockBajo_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Productos WHERE Existencia < 10";

                var productosConStockBajo = database.ExecuteQuery(query);

                if (productosConStockBajo.Rows.Count > 0)
                {
                    dataGridViewConsultas.DataSource = productosConStockBajo;
                }
                else
                {
                    MessageBox.Show("No hay productos con stock bajo en este momento.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar productos con stock bajo: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Método para generar reporte de productos con stock bajo en .csv
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Productos WHERE Existencia < 10";
                var productosConStockBajo = database.ExecuteQuery(query);

                if (productosConStockBajo.Rows.Count > 0)
                {
                    
                    dataGridViewConsultas.DataSource = productosConStockBajo;

                    string reportePath = "ReporteStockBajo.csv";
                    using (StreamWriter writer = new StreamWriter(reportePath))
                    {
                        writer.WriteLine("Id,Nombre,CodigoProducto,Categoria,Precio,Existencia,Proveedor");
                        foreach (DataRow row in productosConStockBajo.Rows)
                        {
                            writer.WriteLine($"{row["Id"]},{row["Nombre"]},{row["CodigoProducto"]},{row["Categoria"]},{row["Precio"]},{row["Existencia"]},{row["Proveedor"]}");
                        }
                    }

                    MessageBox.Show($"Reporte generado exitosamente en: {reportePath}", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No hay productos con stock bajo.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al generar reporte: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

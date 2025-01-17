using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Vault_IDS340_Proyecto_Final
{
    /// <summary>
    /// Clase <c>FormPrincipal</c>: Contiene todos los métodos y funcionalidades del formulario principal del proyecto.
    /// </summary>
    public partial class FormPrincipal : Form
    {
        private Database database;

        public FormPrincipal()
        {
            InitializeComponent();

            database = new Database();
            CargarData();
        }

        /// <summary>
        /// Método <c>CargarData</c>: Carga los datos iniciales de las tablas Productos, Categorías y Proveedores al inicar el programa.
        /// </summary>
        private void CargarData()
        {
            CargarProductos();
            CargarCategorias();
            CargarProveedores();
        }

        /// <summary>
        /// Método <c>CargarProductos</c>: Carga los datos de la tabla Productos y actualiza los controles correspondientes.
        /// </summary>
        private void CargarProductos()
        {
            string query = "SELECT * FROM Productos";
            dataGridViewProductos.DataSource = database.ExecuteQuery(query);
            dataGridViewConsultas.DataSource = database.ExecuteQuery(query);
        }

        /// <summary>
        /// Método <c>CargarCategorias</c>: Carga los datos de la tabla Categorías y actualiza los controles correspondientes.
        /// </summary>
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

        /// <summary>
        /// Método <c>CargarProveedores</c>: Carga los datos de la tabla Proveedores y actualiza los controles correspondientes.
        /// </summary>
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

        /// GESTION DE PRODUCTOS

        /// <summary>
        /// Método <c>btnAgregarProducto_Click</c>: Agrega un nuevo producto a la base de datos.
        /// </summary>
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Productos (Nombre, CodigoProducto, Categoria, Precio, Existencia, Proveedor) " +
                           "VALUES (@Nombre, @CodigoProducto, @Categoria, @Precio, @Existencia, @Proveedor)";

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

        /// <summary>
        /// Método <c>btnEditarProducto_Click</c>: Edita un producto existente en la base de datos.
        /// </summary>
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, selecciona un producto para editar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

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
                new SQLiteParameter("@Id", ObtenerIdProducto())
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

        /// <summary>
        /// Método <c>btnEliminarProducto_Click</c>: Elimina un producto seleccionado de la base de datos.
        /// </summary>
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
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
                    new SQLiteParameter("@Id", ObtenerIdProducto())
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

        /// <summary>
        /// Método <c>ObtenerIdProducto</c>: Obtiene el ID del producto seleccionado en el DataGridView.
        /// </summary>
        private int ObtenerIdProducto()
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

        /// <summary>
        /// Método <c>dataGridViewProductos_SelectionChanged</c>: Maneja el evento de cambio de selección en el DataGridView de productos, rellenando los controles con los datos seleccionados.
        /// </summary>
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

        ///  GESTION DE CATEGORIAS

        /// <summary>
        /// Método <c>btnAgregarCategoria_Click</c>: Agrega una nueva categoria a la base de datos.
        /// </summary>
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
                CargarCategorias();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar categoria: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método <c>btnEditarCategoria_Click</c>: Edita una categoria existente en la base de datos.
        /// </summary>
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
                new SQLiteParameter("@Id", ObtenerIdCategorias())
            };

            database.ExecuteNonQuery(query, parameters);

            CargarCategorias();
        }

        /// <summary>
        /// Método <c>btnEliminarCategoria_Click</c>: Elimina una categoria seleccionada de la base de datos.
        /// </summary>
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Categorias WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", ObtenerIdCategorias())
            };

            database.ExecuteNonQuery(query, parameters);

            CargarCategorias();
        }

        /// <summary>
        /// Método <c>ObtenerIdCategorias</c>: Obtiene el ID de la categoria seleccionada en el DataGridView.
        /// </summary>
        private int ObtenerIdCategorias()
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

        /// <summary>
        /// Método <c>dataGridViewCategoria_SelectionChanged</c>: Maneja el evento de cambio de selección en el DataGridView de categorias, rellenando los controles con los datos seleccionados.
        /// </summary>
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

        /// GESTION DE PROVEEDORES

        /// <summary>
        /// Método <c>btnAgregarProveedor_Click</c>: Agrega un nuevo proveedor a la base de datos.
        /// </summary>
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
                CargarProveedores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar proveedor: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método <c>btnEditarProveedor_Click</c>: Edita un proveedor existente en la base de datos.
        /// </summary>
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
                new SQLiteParameter("@Id", ObtenerIdProveedores())
            };

            database.ExecuteNonQuery(query, parameters);
            CargarProveedores();
        }

        /// <summary>
        /// Método <c>btnEliminarProveedor_Click</c>: Elimina un proveedor seleccionado de la base de datos.
        /// </summary>
        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Proveedores WHERE Id = @Id";

            var parameters = new SQLiteParameter[]
            {
                new SQLiteParameter("@Id", ObtenerIdProveedores())
            };

            database.ExecuteNonQuery(query, parameters);
            CargarProveedores();
        }

        /// <summary>
        /// Método <c>ObtenerIdProveedoress</c>: Obtiene el ID del proveedor seleccionado en el DataGridView.
        /// </summary>
        private int ObtenerIdProveedores()
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

        /// <summary>
        /// Método <c>dataGridViewProveedor_SelectionChanged</c>: Maneja el evento de cambio de selección en el DataGridView de proveedores, rellenando los controles con los datos seleccionados.
        /// </summary>
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
                    new SQLiteParameter("@Id", ObtenerIdProveedores());
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al cargar datos de la fila seleccionada: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// CONSULTAS Y REPORTES

        /// <summary>
        /// Método <c>btnConsultar_Click</c>: Filtra los productos en la base de datos según categoría y proveedor seleccionados.
        /// </summary>
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
                var resultados = database.ExecuteQuery(query, parameters.ToArray());

                if (resultados.Rows.Count > 0)
                {
                    dataGridViewConsultas.DataSource = resultados;
                }
                else
                {
                    MessageBox.Show("No hay resultados para la combinación seleccionada de categoría y proveedor.",
                                    "Sin Resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar productos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Método <c>btnMostrarStockBajo_Click</c>: Muestra los productos con existencias por debajo de un nivel establecido (menos de 10).
        /// </summary>
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

        /// <summary>
        /// Método <c>btnGenerarReporte_Click</c>: Genera un archivo .CSV con los productos que tienen existencias bajas.
        /// </summary>
        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Productos WHERE Existencia < 10";
                var productosConStockBajo = database.ExecuteQuery(query);

                if (productosConStockBajo.Rows.Count > 0)
                {
                    
                    dataGridViewConsultas.DataSource = productosConStockBajo;

                    string reportePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "ReporteStockBajo.csv"); // Genera el archivo .csv en la carpeta "Documents" del usuario.
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

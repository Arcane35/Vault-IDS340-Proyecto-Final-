namespace IDS340___Projecto_Final
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabPageProveedores = new TabPage();
            label11 = new Label();
            txtTelefonoProveedor = new TextBox();
            txtDireccionProveedor = new TextBox();
            txtContactoProveedor = new TextBox();
            txtNombreProveedor = new TextBox();
            label10 = new Label();
            btnEliminarProveedor = new Button();
            btnEditarProveedor = new Button();
            btnAgregarProveedor = new Button();
            dataGridViewProveedor = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label9 = new Label();
            tabPageCategorias = new TabPage();
            btnEliminarCategoria = new Button();
            btnEditarCategoria = new Button();
            btnAgregarCategoria = new Button();
            dataGridViewCategoria = new DataGridView();
            label4 = new Label();
            txtDescripcionCategoria = new TextBox();
            txtNombreCategoria = new TextBox();
            label5 = new Label();
            label8 = new Label();
            tabPageProductos = new TabPage();
            lblProveedor = new Label();
            lblCategoria = new Label();
            cmbProveedorProducto = new ComboBox();
            cmbCategoriaProducto = new ComboBox();
            btnEliminarProducto = new Button();
            btnEditarProducto = new Button();
            btnAgregarProducto = new Button();
            dataGridViewProductos = new DataGridView();
            txtExistenciaProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            txtNombreProducto = new TextBox();
            lblExistencia = new Label();
            lblPrecio = new Label();
            lblCodDeProducto = new Label();
            lblNombre = new Label();
            label1 = new Label();
            tabPageInicio = new TabPage();
            label6 = new Label();
            lblLogo = new Label();
            tabControl1 = new TabControl();
            tabPageConsultasReportes = new TabPage();
            btnMostrarStockBajo = new Button();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            dataGridViewConsultas = new DataGridView();
            btnGenerarReporte = new Button();
            btnConsultar = new Button();
            cmbProveedorConsulta = new ComboBox();
            cmbCategoriaConsulta = new ComboBox();
            label12 = new Label();
            tabPageProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedor).BeginInit();
            tabPageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).BeginInit();
            tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            tabPageInicio.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageConsultasReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).BeginInit();
            SuspendLayout();
            // 
            // tabPageProveedores
            // 
            tabPageProveedores.BackColor = Color.GhostWhite;
            tabPageProveedores.Controls.Add(label11);
            tabPageProveedores.Controls.Add(txtTelefonoProveedor);
            tabPageProveedores.Controls.Add(txtDireccionProveedor);
            tabPageProveedores.Controls.Add(txtContactoProveedor);
            tabPageProveedores.Controls.Add(txtNombreProveedor);
            tabPageProveedores.Controls.Add(label10);
            tabPageProveedores.Controls.Add(btnEliminarProveedor);
            tabPageProveedores.Controls.Add(btnEditarProveedor);
            tabPageProveedores.Controls.Add(btnAgregarProveedor);
            tabPageProveedores.Controls.Add(dataGridViewProveedor);
            tabPageProveedores.Controls.Add(label2);
            tabPageProveedores.Controls.Add(label3);
            tabPageProveedores.Controls.Add(label9);
            tabPageProveedores.Location = new Point(4, 34);
            tabPageProveedores.Name = "tabPageProveedores";
            tabPageProveedores.Padding = new Padding(3);
            tabPageProveedores.Size = new Size(1475, 756);
            tabPageProveedores.TabIndex = 4;
            tabPageProveedores.Text = "Gestion de Proveedores";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(28, 370);
            label11.Name = "label11";
            label11.Size = new Size(79, 25);
            label11.TabIndex = 37;
            label11.Text = "Telefono";
            label11.TextAlign = ContentAlignment.TopCenter;
            // 
            // txtTelefonoProveedor
            // 
            txtTelefonoProveedor.Location = new Point(22, 395);
            txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            txtTelefonoProveedor.Size = new Size(269, 31);
            txtTelefonoProveedor.TabIndex = 36;
            // 
            // txtDireccionProveedor
            // 
            txtDireccionProveedor.Location = new Point(22, 306);
            txtDireccionProveedor.Name = "txtDireccionProveedor";
            txtDireccionProveedor.Size = new Size(269, 31);
            txtDireccionProveedor.TabIndex = 34;
            // 
            // txtContactoProveedor
            // 
            txtContactoProveedor.Location = new Point(22, 221);
            txtContactoProveedor.Name = "txtContactoProveedor";
            txtContactoProveedor.Size = new Size(269, 31);
            txtContactoProveedor.TabIndex = 24;
            // 
            // txtNombreProveedor
            // 
            txtNombreProveedor.Location = new Point(22, 136);
            txtNombreProveedor.Name = "txtNombreProveedor";
            txtNombreProveedor.Size = new Size(269, 31);
            txtNombreProveedor.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(28, 281);
            label10.Name = "label10";
            label10.Size = new Size(85, 25);
            label10.TabIndex = 35;
            label10.Text = "Dirección";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnEliminarProveedor
            // 
            btnEliminarProveedor.BackColor = Color.LightSalmon;
            btnEliminarProveedor.Location = new Point(476, 669);
            btnEliminarProveedor.Name = "btnEliminarProveedor";
            btnEliminarProveedor.Size = new Size(198, 63);
            btnEliminarProveedor.TabIndex = 33;
            btnEliminarProveedor.Text = "Eliminar";
            btnEliminarProveedor.UseVisualStyleBackColor = false;
            btnEliminarProveedor.Click += btnEliminarProveedor_Click;
            // 
            // btnEditarProveedor
            // 
            btnEditarProveedor.BackColor = Color.LightSteelBlue;
            btnEditarProveedor.Location = new Point(252, 669);
            btnEditarProveedor.Name = "btnEditarProveedor";
            btnEditarProveedor.Size = new Size(198, 63);
            btnEditarProveedor.TabIndex = 32;
            btnEditarProveedor.Text = "Editar";
            btnEditarProveedor.UseVisualStyleBackColor = false;
            btnEditarProveedor.Click += btnEditarProveedor_Click;
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.LightSteelBlue;
            btnAgregarProveedor.Location = new Point(24, 669);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(198, 63);
            btnAgregarProveedor.TabIndex = 31;
            btnAgregarProveedor.Text = "Agregar";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
            // 
            // dataGridViewProveedor
            // 
            dataGridViewProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProveedor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProveedor.Location = new Point(339, 111);
            dataGridViewProveedor.Name = "dataGridViewProveedor";
            dataGridViewProveedor.RowHeadersWidth = 62;
            dataGridViewProveedor.Size = new Size(1091, 519);
            dataGridViewProveedor.TabIndex = 30;
            dataGridViewProveedor.SelectionChanged += dataGridViewProveedor_SelectionChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 196);
            label2.Name = "label2";
            label2.Size = new Size(84, 25);
            label2.TabIndex = 25;
            label2.Text = "Contacto";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 111);
            label3.Name = "label3";
            label3.Size = new Size(194, 25);
            label3.TabIndex = 23;
            label3.Text = "Nombre de la Empresa";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkSlateBlue;
            label9.Location = new Point(24, 24);
            label9.Name = "label9";
            label9.Size = new Size(394, 39);
            label9.TabIndex = 17;
            label9.Text = "Gestion de Proveedores";
            // 
            // tabPageCategorias
            // 
            tabPageCategorias.BackColor = Color.GhostWhite;
            tabPageCategorias.Controls.Add(btnEliminarCategoria);
            tabPageCategorias.Controls.Add(btnEditarCategoria);
            tabPageCategorias.Controls.Add(btnAgregarCategoria);
            tabPageCategorias.Controls.Add(dataGridViewCategoria);
            tabPageCategorias.Controls.Add(label4);
            tabPageCategorias.Controls.Add(txtDescripcionCategoria);
            tabPageCategorias.Controls.Add(txtNombreCategoria);
            tabPageCategorias.Controls.Add(label5);
            tabPageCategorias.Controls.Add(label8);
            tabPageCategorias.Location = new Point(4, 34);
            tabPageCategorias.Name = "tabPageCategorias";
            tabPageCategorias.Padding = new Padding(3);
            tabPageCategorias.Size = new Size(1475, 756);
            tabPageCategorias.TabIndex = 2;
            tabPageCategorias.Text = "Gestion de Categorias";
            // 
            // btnEliminarCategoria
            // 
            btnEliminarCategoria.BackColor = Color.LightSalmon;
            btnEliminarCategoria.Location = new Point(476, 669);
            btnEliminarCategoria.Name = "btnEliminarCategoria";
            btnEliminarCategoria.Size = new Size(198, 63);
            btnEliminarCategoria.TabIndex = 33;
            btnEliminarCategoria.Text = "Eliminar";
            btnEliminarCategoria.UseVisualStyleBackColor = false;
            btnEliminarCategoria.Click += btnEliminarCategoria_Click;
            // 
            // btnEditarCategoria
            // 
            btnEditarCategoria.BackColor = Color.LightSteelBlue;
            btnEditarCategoria.Location = new Point(252, 669);
            btnEditarCategoria.Name = "btnEditarCategoria";
            btnEditarCategoria.Size = new Size(198, 63);
            btnEditarCategoria.TabIndex = 32;
            btnEditarCategoria.Text = "Editar";
            btnEditarCategoria.UseVisualStyleBackColor = false;
            btnEditarCategoria.Click += btnEditarCategoria_Click;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.BackColor = Color.LightSteelBlue;
            btnAgregarCategoria.Location = new Point(24, 669);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(198, 63);
            btnAgregarCategoria.TabIndex = 31;
            btnAgregarCategoria.Text = "Agregar";
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
            // 
            // dataGridViewCategoria
            // 
            dataGridViewCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCategoria.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCategoria.Location = new Point(339, 111);
            dataGridViewCategoria.Name = "dataGridViewCategoria";
            dataGridViewCategoria.RowHeadersWidth = 62;
            dataGridViewCategoria.Size = new Size(1091, 519);
            dataGridViewCategoria.TabIndex = 30;
            dataGridViewCategoria.SelectionChanged += dataGridViewCategoria_SelectionChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 212);
            label4.Name = "label4";
            label4.Size = new Size(104, 25);
            label4.TabIndex = 25;
            label4.Text = "Descripcion";
            // 
            // txtDescripcionCategoria
            // 
            txtDescripcionCategoria.Location = new Point(21, 240);
            txtDescripcionCategoria.Name = "txtDescripcionCategoria";
            txtDescripcionCategoria.Size = new Size(269, 31);
            txtDescripcionCategoria.TabIndex = 24;
            // 
            // txtNombreCategoria
            // 
            txtNombreCategoria.Location = new Point(21, 139);
            txtNombreCategoria.Name = "txtNombreCategoria";
            txtNombreCategoria.Size = new Size(269, 31);
            txtNombreCategoria.TabIndex = 22;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 111);
            label5.Name = "label5";
            label5.Size = new Size(202, 25);
            label5.TabIndex = 23;
            label5.Text = "Nombre de la Categoría";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkSlateBlue;
            label8.Location = new Point(24, 25);
            label8.Name = "label8";
            label8.Size = new Size(370, 39);
            label8.TabIndex = 17;
            label8.Text = "Gestion de Categorias";
            // 
            // tabPageProductos
            // 
            tabPageProductos.BackColor = Color.GhostWhite;
            tabPageProductos.Controls.Add(lblProveedor);
            tabPageProductos.Controls.Add(lblCategoria);
            tabPageProductos.Controls.Add(cmbProveedorProducto);
            tabPageProductos.Controls.Add(cmbCategoriaProducto);
            tabPageProductos.Controls.Add(btnEliminarProducto);
            tabPageProductos.Controls.Add(btnEditarProducto);
            tabPageProductos.Controls.Add(btnAgregarProducto);
            tabPageProductos.Controls.Add(dataGridViewProductos);
            tabPageProductos.Controls.Add(txtExistenciaProducto);
            tabPageProductos.Controls.Add(txtPrecioProducto);
            tabPageProductos.Controls.Add(txtCodigoProducto);
            tabPageProductos.Controls.Add(txtNombreProducto);
            tabPageProductos.Controls.Add(lblExistencia);
            tabPageProductos.Controls.Add(lblPrecio);
            tabPageProductos.Controls.Add(lblCodDeProducto);
            tabPageProductos.Controls.Add(lblNombre);
            tabPageProductos.Controls.Add(label1);
            tabPageProductos.Location = new Point(4, 34);
            tabPageProductos.Name = "tabPageProductos";
            tabPageProductos.Padding = new Padding(3);
            tabPageProductos.Size = new Size(1475, 756);
            tabPageProductos.TabIndex = 1;
            tabPageProductos.Text = "Gestion de Productos";
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Location = new Point(24, 564);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new Size(94, 25);
            lblProveedor.TabIndex = 20;
            lblProveedor.Text = "Proveedor";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.Location = new Point(24, 465);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(88, 25);
            lblCategoria.TabIndex = 19;
            lblCategoria.Text = "Categoria";
            // 
            // cmbProveedorProducto
            // 
            cmbProveedorProducto.FormattingEnabled = true;
            cmbProveedorProducto.Location = new Point(24, 592);
            cmbProveedorProducto.Name = "cmbProveedorProducto";
            cmbProveedorProducto.Size = new Size(272, 33);
            cmbProveedorProducto.TabIndex = 18;
            // 
            // cmbCategoriaProducto
            // 
            cmbCategoriaProducto.FormattingEnabled = true;
            cmbCategoriaProducto.Location = new Point(24, 493);
            cmbCategoriaProducto.Name = "cmbCategoriaProducto";
            cmbCategoriaProducto.Size = new Size(272, 33);
            cmbCategoriaProducto.TabIndex = 17;
            // 
            // btnEliminarProducto
            // 
            btnEliminarProducto.BackColor = Color.LightSalmon;
            btnEliminarProducto.Location = new Point(473, 663);
            btnEliminarProducto.Name = "btnEliminarProducto";
            btnEliminarProducto.Size = new Size(198, 63);
            btnEliminarProducto.TabIndex = 16;
            btnEliminarProducto.Text = "Eliminar";
            btnEliminarProducto.UseVisualStyleBackColor = false;
            btnEliminarProducto.Click += btnEliminarProducto_Click;
            // 
            // btnEditarProducto
            // 
            btnEditarProducto.BackColor = Color.LightSteelBlue;
            btnEditarProducto.Location = new Point(249, 663);
            btnEditarProducto.Name = "btnEditarProducto";
            btnEditarProducto.Size = new Size(198, 63);
            btnEditarProducto.TabIndex = 15;
            btnEditarProducto.Text = "Editar";
            btnEditarProducto.UseVisualStyleBackColor = false;
            btnEditarProducto.Click += btnEditarProducto_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.LightSteelBlue;
            btnAgregarProducto.Location = new Point(21, 663);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(198, 63);
            btnAgregarProducto.TabIndex = 14;
            btnAgregarProducto.Text = "Agregar";
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(336, 105);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.Size = new Size(1091, 519);
            dataGridViewProductos.TabIndex = 13;
            dataGridViewProductos.SelectionChanged += dataGridViewProductos_SelectionChanged;
            // 
            // txtExistenciaProducto
            // 
            txtExistenciaProducto.Location = new Point(24, 399);
            txtExistenciaProducto.Name = "txtExistenciaProducto";
            txtExistenciaProducto.Size = new Size(269, 31);
            txtExistenciaProducto.TabIndex = 9;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.Location = new Point(24, 312);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(269, 31);
            txtPrecioProducto.TabIndex = 7;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(24, 133);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(269, 31);
            txtCodigoProducto.TabIndex = 2;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(24, 230);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(266, 31);
            txtNombreProducto.TabIndex = 1;
            // 
            // lblExistencia
            // 
            lblExistencia.AutoSize = true;
            lblExistencia.Location = new Point(27, 371);
            lblExistencia.Name = "lblExistencia";
            lblExistencia.Size = new Size(87, 25);
            lblExistencia.TabIndex = 10;
            lblExistencia.Text = "Existencia";
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(27, 284);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(60, 25);
            lblPrecio.TabIndex = 8;
            lblPrecio.Text = "Precio";
            // 
            // lblCodDeProducto
            // 
            lblCodDeProducto.AutoSize = true;
            lblCodDeProducto.Location = new Point(27, 105);
            lblCodDeProducto.Name = "lblCodDeProducto";
            lblCodDeProducto.Size = new Size(174, 25);
            lblCodDeProducto.TabIndex = 4;
            lblCodDeProducto.Text = "Código de Producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(24, 202);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(185, 25);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre del Producto";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(24, 22);
            label1.Name = "label1";
            label1.Size = new Size(352, 39);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Productos";
            // 
            // tabPageInicio
            // 
            tabPageInicio.BackColor = Color.GhostWhite;
            tabPageInicio.Controls.Add(label6);
            tabPageInicio.Controls.Add(lblLogo);
            tabPageInicio.Location = new Point(4, 34);
            tabPageInicio.Name = "tabPageInicio";
            tabPageInicio.Padding = new Padding(3);
            tabPageInicio.Size = new Size(1475, 756);
            tabPageInicio.TabIndex = 0;
            tabPageInicio.Text = "Inicio";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(562, 398);
            label6.Name = "label6";
            label6.Size = new Size(345, 28);
            label6.TabIndex = 2;
            label6.Text = "Administrador de Inventario";
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Century Gothic", 72F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.DarkSlateBlue;
            lblLogo.Location = new Point(512, 225);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(437, 173);
            lblLogo.TabIndex = 1;
            lblLogo.Text = "Vault";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageInicio);
            tabControl1.Controls.Add(tabPageProductos);
            tabControl1.Controls.Add(tabPageCategorias);
            tabControl1.Controls.Add(tabPageProveedores);
            tabControl1.Controls.Add(tabPageConsultasReportes);
            tabControl1.Location = new Point(0, -2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1483, 794);
            tabControl1.TabIndex = 2;
            // 
            // tabPageConsultasReportes
            // 
            tabPageConsultasReportes.BackColor = Color.GhostWhite;
            tabPageConsultasReportes.Controls.Add(btnMostrarStockBajo);
            tabPageConsultasReportes.Controls.Add(label16);
            tabPageConsultasReportes.Controls.Add(label15);
            tabPageConsultasReportes.Controls.Add(label14);
            tabPageConsultasReportes.Controls.Add(label13);
            tabPageConsultasReportes.Controls.Add(dataGridViewConsultas);
            tabPageConsultasReportes.Controls.Add(btnGenerarReporte);
            tabPageConsultasReportes.Controls.Add(btnConsultar);
            tabPageConsultasReportes.Controls.Add(cmbProveedorConsulta);
            tabPageConsultasReportes.Controls.Add(cmbCategoriaConsulta);
            tabPageConsultasReportes.Controls.Add(label12);
            tabPageConsultasReportes.Location = new Point(4, 34);
            tabPageConsultasReportes.Name = "tabPageConsultasReportes";
            tabPageConsultasReportes.Padding = new Padding(3);
            tabPageConsultasReportes.Size = new Size(1475, 756);
            tabPageConsultasReportes.TabIndex = 5;
            tabPageConsultasReportes.Text = "Consultas y Reportes";
            // 
            // btnMostrarStockBajo
            // 
            btnMostrarStockBajo.BackColor = Color.LightSteelBlue;
            btnMostrarStockBajo.Location = new Point(67, 455);
            btnMostrarStockBajo.Name = "btnMostrarStockBajo";
            btnMostrarStockBajo.Size = new Size(198, 63);
            btnMostrarStockBajo.TabIndex = 39;
            btnMostrarStockBajo.Text = "Mostrar Stock Bajo";
            btnMostrarStockBajo.UseVisualStyleBackColor = false;
            btnMostrarStockBajo.Click += btnMostrarStockBajo_Click;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label16.ForeColor = Color.DarkSlateBlue;
            label16.Location = new Point(67, 550);
            label16.Name = "label16";
            label16.Size = new Size(153, 39);
            label16.TabIndex = 38;
            label16.Text = "Reportes";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Century Gothic", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.DarkSlateBlue;
            label15.Location = new Point(63, 123);
            label15.Name = "label15";
            label15.Size = new Size(98, 39);
            label15.TabIndex = 37;
            label15.Text = "Filtrar";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(67, 272);
            label14.Name = "label14";
            label14.Size = new Size(94, 25);
            label14.TabIndex = 36;
            label14.Text = "Proveedor";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(67, 188);
            label13.Name = "label13";
            label13.Size = new Size(88, 25);
            label13.TabIndex = 35;
            label13.Text = "Categoría";
            // 
            // dataGridViewConsultas
            // 
            dataGridViewConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsultas.Location = new Point(328, 169);
            dataGridViewConsultas.Name = "dataGridViewConsultas";
            dataGridViewConsultas.RowHeadersWidth = 62;
            dataGridViewConsultas.Size = new Size(1091, 519);
            dataGridViewConsultas.TabIndex = 34;
            // 
            // btnGenerarReporte
            // 
            btnGenerarReporte.BackColor = Color.LightSteelBlue;
            btnGenerarReporte.Location = new Point(67, 625);
            btnGenerarReporte.Name = "btnGenerarReporte";
            btnGenerarReporte.Size = new Size(198, 63);
            btnGenerarReporte.TabIndex = 33;
            btnGenerarReporte.Text = "Generar CSV";
            btnGenerarReporte.UseVisualStyleBackColor = false;
            btnGenerarReporte.Click += btnGenerarReporte_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.BackColor = Color.LightSteelBlue;
            btnConsultar.Location = new Point(67, 364);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(198, 63);
            btnConsultar.TabIndex = 32;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = false;
            btnConsultar.Click += btnConsultar_Click;
            // 
            // cmbProveedorConsulta
            // 
            cmbProveedorConsulta.FormattingEnabled = true;
            cmbProveedorConsulta.Location = new Point(67, 300);
            cmbProveedorConsulta.Name = "cmbProveedorConsulta";
            cmbProveedorConsulta.Size = new Size(198, 33);
            cmbProveedorConsulta.TabIndex = 20;
            // 
            // cmbCategoriaConsulta
            // 
            cmbCategoriaConsulta.FormattingEnabled = true;
            cmbCategoriaConsulta.Location = new Point(67, 216);
            cmbCategoriaConsulta.Name = "cmbCategoriaConsulta";
            cmbCategoriaConsulta.Size = new Size(198, 33);
            cmbCategoriaConsulta.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.DarkSlateBlue;
            label12.Location = new Point(570, 41);
            label12.Name = "label12";
            label12.Size = new Size(425, 49);
            label12.TabIndex = 18;
            label12.Text = "Consultas y Reportes";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            ClientSize = new Size(1481, 786);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormPrincipal";
            Text = "Vault";
            tabPageProveedores.ResumeLayout(false);
            tabPageProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProveedor).EndInit();
            tabPageCategorias.ResumeLayout(false);
            tabPageCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCategoria).EndInit();
            tabPageProductos.ResumeLayout(false);
            tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            tabPageInicio.ResumeLayout(false);
            tabPageInicio.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageConsultasReportes.ResumeLayout(false);
            tabPageConsultasReportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabPage tabPageProveedores;
        private Label label11;
        private TextBox txtTelefonoProveedor;
        private TextBox txtDireccionProveedor;
        private TextBox txtContactoProveedor;
        private TextBox txtNombreProveedor;
        private Label label10;
        private Button btnEliminarProveedor;
        private Button btnEditarProveedor;
        private Button btnAgregarProveedor;
        private DataGridView dataGridViewProveedor;
        private Label label2;
        private Label label3;
        private Label label9;
        private TabPage tabPageCategorias;
        private Button btnEliminarCategoria;
        private Button btnEditarCategoria;
        private Button btnAgregarCategoria;
        private DataGridView dataGridViewCategoria;
        private Label label4;
        private TextBox txtDescripcionCategoria;
        private TextBox txtNombreCategoria;
        private Label label5;
        private Label label8;
        private TabPage tabPageProductos;
        private Button btnEliminarProducto;
        private Button btnEditarProducto;
        private Button btnAgregarProducto;
        private DataGridView dataGridViewProductos;
        private TextBox txtExistenciaProducto;
        private TextBox txtPrecioProducto;
        private TextBox txtCodigoProducto;
        private TextBox txtNombreProducto;
        private Label lblExistencia;
        private Label lblPrecio;
        private Label lblCodDeProducto;
        private Label lblNombre;
        private Label label1;
        private TabPage tabPageInicio;
        private TabControl tabControl1;
        private TabPage tabPageConsultasReportes;
        private Label label12;
        private ComboBox cmbProveedorProducto;
        private ComboBox cmbCategoriaProducto;
        private DataGridView dataGridViewConsultas;
        private Button btnGenerarReporte;
        private Button btnConsultar;
        private ComboBox cmbProveedorConsulta;
        private ComboBox cmbCategoriaConsulta;
        private Label lblProveedor;
        private Label lblCategoria;
        private Label label6;
        private Label lblLogo;
        private Label label14;
        private Label label13;
        private Label label15;
        private Label label16;
        private Button btnMostrarStockBajo;
    }
}

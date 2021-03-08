namespace Catalogo
{
    partial class frnInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_productoLabel;
            System.Windows.Forms.Label descripcionLabel;
            System.Windows.Forms.Label nombre_productoLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porTipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.id_productoLabel1 = new System.Windows.Forms.Label();
            this.descripcionTextBox = new System.Windows.Forms.TextBox();
            this.nombre_productoTextBox = new System.Windows.Forms.TextBox();
            this.categoriasListBox = new System.Windows.Forms.ListBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoComboBox = new System.Windows.Forms.ComboBox();
            this.categoria1ComboBox = new System.Windows.Forms.ComboBox();
            this.cmdAgregarCategoria = new System.Windows.Forms.Button();
            this.grdProductos = new System.Windows.Forms.DataGridView();
            this.idproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreproductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_productoLabel = new System.Windows.Forms.Label();
            descripcionLabel = new System.Windows.Forms.Label();
            nombre_productoLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // id_productoLabel
            // 
            id_productoLabel.AutoSize = true;
            id_productoLabel.Location = new System.Drawing.Point(12, 33);
            id_productoLabel.Name = "id_productoLabel";
            id_productoLabel.Size = new System.Drawing.Size(66, 13);
            id_productoLabel.TabIndex = 3;
            id_productoLabel.Text = "ID producto:";
            // 
            // descripcionLabel
            // 
            descripcionLabel.AutoSize = true;
            descripcionLabel.Location = new System.Drawing.Point(14, 100);
            descripcionLabel.Name = "descripcionLabel";
            descripcionLabel.Size = new System.Drawing.Size(66, 13);
            descripcionLabel.TabIndex = 4;
            descripcionLabel.Text = "Descripcion:";
            // 
            // nombre_productoLabel
            // 
            nombre_productoLabel.AutoSize = true;
            nombre_productoLabel.Location = new System.Drawing.Point(31, 67);
            nombre_productoLabel.Name = "nombre_productoLabel";
            nombre_productoLabel.Size = new System.Drawing.Size(47, 13);
            nombre_productoLabel.TabIndex = 6;
            nombre_productoLabel.Text = "Nombre:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(295, 72);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(60, 13);
            label1.TabIndex = 4;
            label1.Text = "Categorias:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(321, 39);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 4;
            label2.Text = "Tipo: ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.cerrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(536, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tiposToolStripMenuItem,
            this.categoriasToolStripMenuItem});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // tiposToolStripMenuItem
            // 
            this.tiposToolStripMenuItem.Name = "tiposToolStripMenuItem";
            this.tiposToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.tiposToolStripMenuItem.Text = "Tipos";
            this.tiposToolStripMenuItem.Click += new System.EventHandler(this.tiposToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.porTipoToolStripMenuItem,
            this.porCategoriaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // porTipoToolStripMenuItem
            // 
            this.porTipoToolStripMenuItem.Name = "porTipoToolStripMenuItem";
            this.porTipoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porTipoToolStripMenuItem.Text = "Por tipo";
            this.porTipoToolStripMenuItem.Click += new System.EventHandler(this.porTipoToolStripMenuItem_Click);
            // 
            // porCategoriaToolStripMenuItem
            // 
            this.porCategoriaToolStripMenuItem.Name = "porCategoriaToolStripMenuItem";
            this.porCategoriaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.porCategoriaToolStripMenuItem.Text = "Por Categoria";
            this.porCategoriaToolStripMenuItem.Click += new System.EventHandler(this.porCategoriaToolStripMenuItem_Click);
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // cerrarToolStripMenuItem
            // 
            this.cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            this.cerrarToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Catalogo.producto);
            this.productoBindingSource.CurrentChanged += new System.EventHandler(this.productoBindingSource_CurrentChanged);
            // 
            // id_productoLabel1
            // 
            this.id_productoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "id_producto", true));
            this.id_productoLabel1.Location = new System.Drawing.Point(81, 33);
            this.id_productoLabel1.Name = "id_productoLabel1";
            this.id_productoLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_productoLabel1.TabIndex = 4;
            this.id_productoLabel1.Text = "0";
            // 
            // descripcionTextBox
            // 
            this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "descripcion", true));
            this.descripcionTextBox.Location = new System.Drawing.Point(84, 97);
            this.descripcionTextBox.Multiline = true;
            this.descripcionTextBox.Name = "descripcionTextBox";
            this.descripcionTextBox.Size = new System.Drawing.Size(183, 82);
            this.descripcionTextBox.TabIndex = 5;
            // 
            // nombre_productoTextBox
            // 
            this.nombre_productoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productoBindingSource, "nombre_producto", true));
            this.nombre_productoTextBox.Location = new System.Drawing.Point(81, 64);
            this.nombre_productoTextBox.Name = "nombre_productoTextBox";
            this.nombre_productoTextBox.Size = new System.Drawing.Size(186, 20);
            this.nombre_productoTextBox.TabIndex = 7;
            // 
            // categoriasListBox
            // 
            this.categoriasListBox.FormattingEnabled = true;
            this.categoriasListBox.Location = new System.Drawing.Point(367, 119);
            this.categoriasListBox.Name = "categoriasListBox";
            this.categoriasListBox.Size = new System.Drawing.Size(155, 82);
            this.categoriasListBox.TabIndex = 10;
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Catalogo.categoria);
            // 
            // tipoBindingSource
            // 
            this.tipoBindingSource.DataSource = typeof(Catalogo.tipo);
            // 
            // tipoComboBox
            // 
            this.tipoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productoBindingSource, "tipo", true));
            this.tipoComboBox.DataSource = this.tipoBindingSource;
            this.tipoComboBox.DisplayMember = "nombre";
            this.tipoComboBox.FormattingEnabled = true;
            this.tipoComboBox.Location = new System.Drawing.Point(367, 34);
            this.tipoComboBox.Name = "tipoComboBox";
            this.tipoComboBox.Size = new System.Drawing.Size(155, 21);
            this.tipoComboBox.TabIndex = 10;
            this.tipoComboBox.ValueMember = "id_tipo";
            // 
            // categoria1ComboBox
            // 
            this.categoria1ComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "categoria1", true));
            this.categoria1ComboBox.DataSource = this.categoriaBindingSource;
            this.categoria1ComboBox.DisplayMember = "categoria1";
            this.categoria1ComboBox.FormattingEnabled = true;
            this.categoria1ComboBox.Location = new System.Drawing.Point(367, 67);
            this.categoria1ComboBox.Name = "categoria1ComboBox";
            this.categoria1ComboBox.Size = new System.Drawing.Size(155, 21);
            this.categoria1ComboBox.TabIndex = 13;
            this.categoria1ComboBox.ValueMember = "id_categoria";
            // 
            // cmdAgregarCategoria
            // 
            this.cmdAgregarCategoria.Location = new System.Drawing.Point(367, 90);
            this.cmdAgregarCategoria.Name = "cmdAgregarCategoria";
            this.cmdAgregarCategoria.Size = new System.Drawing.Size(155, 23);
            this.cmdAgregarCategoria.TabIndex = 14;
            this.cmdAgregarCategoria.Text = "Agregar categoria";
            this.cmdAgregarCategoria.UseVisualStyleBackColor = true;
            this.cmdAgregarCategoria.Click += new System.EventHandler(this.cmdAgregarCategoria_Click);
            // 
            // grdProductos
            // 
            this.grdProductos.AllowUserToAddRows = false;
            this.grdProductos.AllowUserToDeleteRows = false;
            this.grdProductos.AutoGenerateColumns = false;
            this.grdProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproductoDataGridViewTextBoxColumn,
            this.nombreproductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn,
            this.tipo1DataGridViewTextBoxColumn,
            this.categoriasDataGridViewTextBoxColumn});
            this.grdProductos.DataSource = this.productoBindingSource;
            this.grdProductos.Location = new System.Drawing.Point(12, 212);
            this.grdProductos.Name = "grdProductos";
            this.grdProductos.Size = new System.Drawing.Size(510, 150);
            this.grdProductos.TabIndex = 15;
            // 
            // idproductoDataGridViewTextBoxColumn
            // 
            this.idproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.HeaderText = "id_producto";
            this.idproductoDataGridViewTextBoxColumn.Name = "idproductoDataGridViewTextBoxColumn";
            // 
            // nombreproductoDataGridViewTextBoxColumn
            // 
            this.nombreproductoDataGridViewTextBoxColumn.DataPropertyName = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.HeaderText = "nombre_producto";
            this.nombreproductoDataGridViewTextBoxColumn.Name = "nombreproductoDataGridViewTextBoxColumn";
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            // 
            // tipo1DataGridViewTextBoxColumn
            // 
            this.tipo1DataGridViewTextBoxColumn.DataPropertyName = "tipo1";
            this.tipo1DataGridViewTextBoxColumn.HeaderText = "tipo1";
            this.tipo1DataGridViewTextBoxColumn.Name = "tipo1DataGridViewTextBoxColumn";
            // 
            // categoriasDataGridViewTextBoxColumn
            // 
            this.categoriasDataGridViewTextBoxColumn.DataPropertyName = "categorias";
            this.categoriasDataGridViewTextBoxColumn.HeaderText = "categorias";
            this.categoriasDataGridViewTextBoxColumn.Name = "categoriasDataGridViewTextBoxColumn";
            // 
            // frnInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 374);
            this.Controls.Add(this.grdProductos);
            this.Controls.Add(this.cmdAgregarCategoria);
            this.Controls.Add(this.categoria1ComboBox);
            this.Controls.Add(this.tipoComboBox);
            this.Controls.Add(this.categoriasListBox);
            this.Controls.Add(nombre_productoLabel);
            this.Controls.Add(this.nombre_productoTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Controls.Add(descripcionLabel);
            this.Controls.Add(this.descripcionTextBox);
            this.Controls.Add(id_productoLabel);
            this.Controls.Add(this.id_productoLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frnInicio";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.frnInicio_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.Label id_productoLabel1;
        private System.Windows.Forms.TextBox descripcionTextBox;
        private System.Windows.Forms.TextBox nombre_productoTextBox;
        private System.Windows.Forms.ListBox categoriasListBox;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.BindingSource tipoBindingSource;
        private System.Windows.Forms.ComboBox tipoComboBox;
        private System.Windows.Forms.ComboBox categoria1ComboBox;
        private System.Windows.Forms.Button cmdAgregarCategoria;
        private System.Windows.Forms.DataGridView grdProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreproductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriasDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porTipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porCategoriaToolStripMenuItem;
    }
}


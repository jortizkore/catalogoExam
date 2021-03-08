namespace Catalogo.Views
{
    partial class frmCategoriaProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label id_categoriaLabel;
            System.Windows.Forms.Label categoria1Label;
            this.id_categoriaLabel1 = new System.Windows.Forms.Label();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoria1TextBox = new System.Windows.Forms.TextBox();
            this.grdCategorias = new System.Windows.Forms.DataGridView();
            this.idcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            id_categoriaLabel = new System.Windows.Forms.Label();
            categoria1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).BeginInit();
            this.SuspendLayout();
            // 
            // id_categoriaLabel
            // 
            id_categoriaLabel.AutoSize = true;
            id_categoriaLabel.Location = new System.Drawing.Point(8, 38);
            id_categoriaLabel.Name = "id_categoriaLabel";
            id_categoriaLabel.Size = new System.Drawing.Size(71, 13);
            id_categoriaLabel.TabIndex = 1;
            id_categoriaLabel.Text = "ID categoria: ";
            // 
            // categoria1Label
            // 
            categoria1Label.AutoSize = true;
            categoria1Label.Location = new System.Drawing.Point(9, 71);
            categoria1Label.Name = "categoria1Label";
            categoria1Label.Size = new System.Drawing.Size(55, 13);
            categoria1Label.TabIndex = 3;
            categoria1Label.Text = "Categoria:";
            // 
            // id_categoriaLabel1
            // 
            this.id_categoriaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "id_categoria", true));
            this.id_categoriaLabel1.Location = new System.Drawing.Point(98, 38);
            this.id_categoriaLabel1.Name = "id_categoriaLabel1";
            this.id_categoriaLabel1.Size = new System.Drawing.Size(100, 23);
            this.id_categoriaLabel1.TabIndex = 2;
            this.id_categoriaLabel1.Text = "0";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Catalogo.categoria);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.guardarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(394, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
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
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // categoria1TextBox
            // 
            this.categoria1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriaBindingSource, "categoria1", true));
            this.categoria1TextBox.Location = new System.Drawing.Point(101, 68);
            this.categoria1TextBox.Name = "categoria1TextBox";
            this.categoria1TextBox.Size = new System.Drawing.Size(135, 20);
            this.categoria1TextBox.TabIndex = 4;
            // 
            // grdCategorias
            // 
            this.grdCategorias.AllowUserToAddRows = false;
            this.grdCategorias.AllowUserToDeleteRows = false;
            this.grdCategorias.AutoGenerateColumns = false;
            this.grdCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCategorias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcategoriaDataGridViewTextBoxColumn,
            this.categoria1DataGridViewTextBoxColumn});
            this.grdCategorias.DataSource = this.categoriaBindingSource;
            this.grdCategorias.Location = new System.Drawing.Point(12, 106);
            this.grdCategorias.Name = "grdCategorias";
            this.grdCategorias.Size = new System.Drawing.Size(355, 134);
            this.grdCategorias.TabIndex = 7;
            // 
            // idcategoriaDataGridViewTextBoxColumn
            // 
            this.idcategoriaDataGridViewTextBoxColumn.DataPropertyName = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.HeaderText = "id_categoria";
            this.idcategoriaDataGridViewTextBoxColumn.Name = "idcategoriaDataGridViewTextBoxColumn";
            // 
            // categoria1DataGridViewTextBoxColumn
            // 
            this.categoria1DataGridViewTextBoxColumn.DataPropertyName = "categoria1";
            this.categoria1DataGridViewTextBoxColumn.HeaderText = "categoria1";
            this.categoria1DataGridViewTextBoxColumn.Name = "categoria1DataGridViewTextBoxColumn";
            // 
            // frmCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 315);
            this.Controls.Add(this.grdCategorias);
            this.Controls.Add(categoria1Label);
            this.Controls.Add(this.categoria1TextBox);
            this.Controls.Add(id_categoriaLabel);
            this.Controls.Add(this.id_categoriaLabel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmCategoriaProducto";
            this.Text = "Categorias";
            this.Load += new System.EventHandler(this.frmCategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCategorias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.Label id_categoriaLabel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.TextBox categoria1TextBox;
        private System.Windows.Forms.DataGridView grdCategorias;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria1DataGridViewTextBoxColumn;
    }
}
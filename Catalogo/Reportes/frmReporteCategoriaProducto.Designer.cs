namespace Catalogo.Reportes
{
    partial class frmReporteCategoriaProducto
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.rptView = new Microsoft.Reporting.WinForms.ReportViewer();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rptView
            // 
            this.rptView.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSetCategoria";
            reportDataSource1.Value = this.productoBindingSource;
            this.rptView.LocalReport.DataSources.Add(reportDataSource1);
            this.rptView.LocalReport.ReportEmbeddedResource = "Catalogo.Reportes.rptProductoPorCategoria.rdlc";
            this.rptView.Location = new System.Drawing.Point(0, 0);
            this.rptView.Name = "rptView";
            this.rptView.ServerReport.BearerToken = null;
            this.rptView.Size = new System.Drawing.Size(531, 376);
            this.rptView.TabIndex = 0;
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(Catalogo.producto);
            // 
            // frmReporteCategoriaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 376);
            this.Controls.Add(this.rptView);
            this.Name = "frmReporteCategoriaProducto";
            this.Text = "Productos por categoria";
            this.Load += new System.EventHandler(this.frmReporteCategoriaProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptView;
        private System.Windows.Forms.BindingSource productoBindingSource;
    }
}
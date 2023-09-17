namespace Libreria_detalles.Formularios
{
    partial class frmConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultarVentas));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColBorrar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sptraerFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Libreria_detalles.Formularios.DataSet1();
            this.sp_traerFacturasTableAdapter = new Libreria_detalles.Formularios.DataSet1TableAdapters.sp_traerFacturasTableAdapter();
            this.sptraerFacturasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.nroDeFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDeProductosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptraerFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptraerFacturasBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColBorrar,
            this.nroDeFacturaDataGridViewTextBoxColumn,
            this.cantidadDeProductosDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.sptraerFacturasBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(1111, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColBorrar
            // 
            this.ColBorrar.HeaderText = "Borrar";
            this.ColBorrar.MinimumWidth = 8;
            this.ColBorrar.Name = "ColBorrar";
            this.ColBorrar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColBorrar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColBorrar.Width = 150;
            // 
            // sptraerFacturasBindingSource
            // 
            this.sptraerFacturasBindingSource.DataMember = "sp_traerFacturas";
            this.sptraerFacturasBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            this.dataSet1BindingSource.CurrentChanged += new System.EventHandler(this.dataSet1BindingSource_CurrentChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sp_traerFacturasTableAdapter
            // 
            this.sp_traerFacturasTableAdapter.ClearBeforeFill = true;
            // 
            // sptraerFacturasBindingSource1
            // 
            this.sptraerFacturasBindingSource1.DataMember = "sp_traerFacturas";
            this.sptraerFacturasBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // nroDeFacturaDataGridViewTextBoxColumn
            // 
            this.nroDeFacturaDataGridViewTextBoxColumn.DataPropertyName = "Nro de factura";
            this.nroDeFacturaDataGridViewTextBoxColumn.HeaderText = "Nro de factura";
            this.nroDeFacturaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nroDeFacturaDataGridViewTextBoxColumn.Name = "nroDeFacturaDataGridViewTextBoxColumn";
            this.nroDeFacturaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cantidadDeProductosDataGridViewTextBoxColumn
            // 
            this.cantidadDeProductosDataGridViewTextBoxColumn.DataPropertyName = "Cantidad de productos";
            this.cantidadDeProductosDataGridViewTextBoxColumn.HeaderText = "Cantidad de productos";
            this.cantidadDeProductosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.cantidadDeProductosDataGridViewTextBoxColumn.Name = "cantidadDeProductosDataGridViewTextBoxColumn";
            this.cantidadDeProductosDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadDeProductosDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 150;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "fecha";
            this.fechaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "Nombre cliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre cliente";
            this.nombreClienteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // frmConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 450);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmConsultarVentas";
            this.Text = "frmConsultarVentas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmConsultarVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptraerFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sptraerFacturasBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sptraerFacturasBindingSource;
        private DataSet1TableAdapters.sp_traerFacturasTableAdapter sp_traerFacturasTableAdapter;
        private System.Windows.Forms.DataGridViewButtonColumn ColBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroDeFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDeProductosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource sptraerFacturasBindingSource1;
    }
}
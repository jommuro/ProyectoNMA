namespace CapaPresentacion
{
    partial class V_Servicios
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataSet1 = new CapaPresentacion.DataSet1();
            this.sERVICIOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sERVICIOTableAdapter = new CapaPresentacion.DataSet1TableAdapters.SERVICIOTableAdapter();
            this.tableAdapterManager = new CapaPresentacion.DataSet1TableAdapters.TableAdapterManager();
            this.sERVICIODataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(448, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 33);
            this.label1.TabIndex = 61;
            this.label1.Text = "Servicios";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sERVICIOBindingSource
            // 
            this.sERVICIOBindingSource.DataMember = "SERVICIO";
            this.sERVICIOBindingSource.DataSource = this.dataSet1;
            // 
            // sERVICIOTableAdapter
            // 
            this.sERVICIOTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.ACT_TRABTableAdapter = null;
            this.tableAdapterManager.ACTIVIDADTableAdapter = null;
            this.tableAdapterManager.ASISTENTETableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CHECKLISTTableAdapter = null;
            this.tableAdapterManager.CLIENTE_EMPRESATableAdapter = null;
            this.tableAdapterManager.CLIENTE_RUBROTableAdapter = null;
            this.tableAdapterManager.COMUNATableAdapter = null;
            this.tableAdapterManager.CONTRATO_PLANTableAdapter = null;
            this.tableAdapterManager.CONTRATO_SERVICIOTableAdapter = null;
            this.tableAdapterManager.CONTRATOTableAdapter = null;
            this.tableAdapterManager.CREDENCIALTableAdapter = null;
            this.tableAdapterManager.DETALLE_FACTURATableAdapter = null;
            this.tableAdapterManager.ESTADO_ACTIVIDADTableAdapter = null;
            this.tableAdapterManager.ESTADO_CHECKTableAdapter = null;
            this.tableAdapterManager.ESTADO_CLIENTETableAdapter = null;
            this.tableAdapterManager.ESTADO_CREDENCIALTableAdapter = null;
            this.tableAdapterManager.ESTADO_FACTURATableAdapter = null;
            this.tableAdapterManager.FACTURATableAdapter = null;
            this.tableAdapterManager.GENEROTableAdapter = null;
            this.tableAdapterManager.INTERACCIONTableAdapter = null;
            this.tableAdapterManager.LOGIN_FAILTableAdapter = null;
            this.tableAdapterManager.MAT_ACTIVTableAdapter = null;
            this.tableAdapterManager.MATERIALTableAdapter = null;
            this.tableAdapterManager.PAISTableAdapter = null;
            this.tableAdapterManager.PLAN_SERVICIOTableAdapter = null;
            this.tableAdapterManager.PLANTableAdapter = null;
            this.tableAdapterManager.PROFESIONALTableAdapter = null;
            this.tableAdapterManager.REGIONTableAdapter = null;
            this.tableAdapterManager.REGISTRO_ERRORTableAdapter = null;
            this.tableAdapterManager.REP_CLI_EMPTableAdapter = null;
            this.tableAdapterManager.REP_PROFESIONALTableAdapter = null;
            this.tableAdapterManager.ROLTableAdapter = null;
            this.tableAdapterManager.RUBROTableAdapter = null;
            this.tableAdapterManager.SERVICIOTableAdapter = this.sERVICIOTableAdapter;
            this.tableAdapterManager.TIPO_INTERACCIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CapaPresentacion.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sERVICIODataGridView
            // 
            this.sERVICIODataGridView.AutoGenerateColumns = false;
            this.sERVICIODataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sERVICIODataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.sERVICIODataGridView.DataSource = this.sERVICIOBindingSource;
            this.sERVICIODataGridView.Location = new System.Drawing.Point(234, 128);
            this.sERVICIODataGridView.Name = "sERVICIODataGridView";
            this.sERVICIODataGridView.ReadOnly = true;
            this.sERVICIODataGridView.Size = new System.Drawing.Size(456, 210);
            this.sERVICIODataGridView.TabIndex = 62;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_SERVICIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_SERVICIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NOMBRE";
            this.dataGridViewTextBoxColumn2.HeaderText = "NOMBRE";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PRECIO";
            this.dataGridViewTextBoxColumn3.HeaderText = "PRECIO";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "REGLA";
            this.dataGridViewTextBoxColumn4.HeaderText = "REGLA";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // V_Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 600);
            this.Controls.Add(this.sERVICIODataGridView);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "V_Servicios";
            this.Text = "V_Servicios";
            this.Load += new System.EventHandler(this.V_Servicios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sERVICIODataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource sERVICIOBindingSource;
        private DataSet1TableAdapters.SERVICIOTableAdapter sERVICIOTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView sERVICIODataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}
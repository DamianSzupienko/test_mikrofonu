namespace KWZP2019
{
    partial class ProductionProcess
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProces = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productionProceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlanDataGridViewTextBoxColumn,
            this.IdProces,
            this.StartDate,
            this.EndDate});
            this.dataGridView1.DataSource = this.productionProceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // idPlanDataGridViewTextBoxColumn
            // 
            this.idPlanDataGridViewTextBoxColumn.DataPropertyName = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.HeaderText = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.Name = "idPlanDataGridViewTextBoxColumn";
            // 
            // IdProces
            // 
            this.IdProces.DataPropertyName = "IdProces";
            this.IdProces.HeaderText = "IdProces";
            this.IdProces.Name = "IdProces";
            // 
            // StartDate
            // 
            this.StartDate.DataPropertyName = "StartDate";
            this.StartDate.HeaderText = "StartDate";
            this.StartDate.Name = "StartDate";
            // 
            // EndDate
            // 
            this.EndDate.DataPropertyName = "EndDate";
            this.EndDate.HeaderText = "EndDate";
            this.EndDate.Name = "EndDate";
            // 
            // plannedProductionBindingSource
            // 
            this.plannedProductionBindingSource.DataSource = typeof(KWZP2019.PlannedProduction);
            // 
            // productionProceBindingSource
            // 
            this.productionProceBindingSource.DataSource = typeof(KWZP2019.ProductionProce);
            // 
            // ProductionProcess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProductionProcess";
            this.Text = "Aktualna produkcja";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productionProceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource plannedProductionBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProces;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndDate;
        private System.Windows.Forms.BindingSource productionProceBindingSource;
    }
}
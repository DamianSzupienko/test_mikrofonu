namespace KWZP2019
{
    partial class ProductionPlanned
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
            this.PlannedProductionGridView = new System.Windows.Forms.DataGridView();
            this.technologyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.plannedProductionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxPlanSearch = new System.Windows.Forms.TextBox();
            this.btnAddPlan = new System.Windows.Forms.Button();
            this.btnEditPlan = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnMachineDet = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.idPlanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idMachineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedStartdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedEnddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inproductionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderDetail1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productionProcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PlannedProductionGridView
            // 
            this.PlannedProductionGridView.AutoGenerateColumns = false;
            this.PlannedProductionGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlannedProductionGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlanDataGridViewTextBoxColumn,
            this.idDetailDataGridViewTextBoxColumn,
            this.idMachineDataGridViewTextBoxColumn,
            this.plannedStartdDataGridViewTextBoxColumn,
            this.plannedEnddDataGridViewTextBoxColumn,
            this.inproductionDataGridViewTextBoxColumn,
            this.orderDetailDataGridViewTextBoxColumn,
            this.orderDetail1DataGridViewTextBoxColumn,
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn,
            this.productionProcesDataGridViewTextBoxColumn});
            this.PlannedProductionGridView.DataSource = this.plannedProductionBindingSource;
            this.PlannedProductionGridView.Location = new System.Drawing.Point(9, 97);
            this.PlannedProductionGridView.Margin = new System.Windows.Forms.Padding(2);
            this.PlannedProductionGridView.Name = "PlannedProductionGridView";
            this.PlannedProductionGridView.RowTemplate.Height = 24;
            this.PlannedProductionGridView.Size = new System.Drawing.Size(782, 257);
            this.PlannedProductionGridView.TabIndex = 0;
            // 
            // technologyBindingSource
            // 
            this.technologyBindingSource.DataSource = typeof(KWZP2019.Technology);
            // 
            // plannedProductionBindingSource
            // 
            this.plannedProductionBindingSource.DataSource = typeof(KWZP2019.PlannedProduction);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Szukaj planu:";
            // 
            // txtBoxPlanSearch
            // 
            this.txtBoxPlanSearch.Location = new System.Drawing.Point(364, 57);
            this.txtBoxPlanSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtBoxPlanSearch.Name = "txtBoxPlanSearch";
            this.txtBoxPlanSearch.Size = new System.Drawing.Size(126, 20);
            this.txtBoxPlanSearch.TabIndex = 2;
            this.txtBoxPlanSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPlanSearch_KeyPress);
            // 
            // btnAddPlan
            // 
            this.btnAddPlan.Location = new System.Drawing.Point(22, 50);
            this.btnAddPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPlan.Name = "btnAddPlan";
            this.btnAddPlan.Size = new System.Drawing.Size(94, 32);
            this.btnAddPlan.TabIndex = 3;
            this.btnAddPlan.Text = "Nowy plan";
            this.btnAddPlan.UseVisualStyleBackColor = true;
            // 
            // btnEditPlan
            // 
            this.btnEditPlan.Location = new System.Drawing.Point(122, 50);
            this.btnEditPlan.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditPlan.Name = "btnEditPlan";
            this.btnEditPlan.Size = new System.Drawing.Size(94, 32);
            this.btnEditPlan.TabIndex = 4;
            this.btnEditPlan.Text = "Edytuj plan";
            this.btnEditPlan.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(697, 372);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(2);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(94, 32);
            this.btnReturn.TabIndex = 5;
            this.btnReturn.Text = "POWRÓT";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(187, 372);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(151, 32);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Pracownicy wykonujący";
            this.btnEmployee.UseVisualStyleBackColor = true;
            // 
            // btnMachineDet
            // 
            this.btnMachineDet.Location = new System.Drawing.Point(22, 372);
            this.btnMachineDet.Margin = new System.Windows.Forms.Padding(2);
            this.btnMachineDet.Name = "btnMachineDet";
            this.btnMachineDet.Size = new System.Drawing.Size(160, 32);
            this.btnMachineDet.TabIndex = 6;
            this.btnMachineDet.Text = "Szczegóły maszyny";
            this.btnMachineDet.UseVisualStyleBackColor = true;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(342, 372);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(97, 32);
            this.btnOrder.TabIndex = 8;
            this.btnOrder.Text = "Zamówienie";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // idPlanDataGridViewTextBoxColumn
            // 
            this.idPlanDataGridViewTextBoxColumn.DataPropertyName = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.HeaderText = "IdPlan";
            this.idPlanDataGridViewTextBoxColumn.Name = "idPlanDataGridViewTextBoxColumn";
            // 
            // idDetailDataGridViewTextBoxColumn
            // 
            this.idDetailDataGridViewTextBoxColumn.DataPropertyName = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.HeaderText = "IdDetail";
            this.idDetailDataGridViewTextBoxColumn.Name = "idDetailDataGridViewTextBoxColumn";
            // 
            // idMachineDataGridViewTextBoxColumn
            // 
            this.idMachineDataGridViewTextBoxColumn.DataPropertyName = "IdMachine";
            this.idMachineDataGridViewTextBoxColumn.HeaderText = "IdMachine";
            this.idMachineDataGridViewTextBoxColumn.Name = "idMachineDataGridViewTextBoxColumn";
            // 
            // plannedStartdDataGridViewTextBoxColumn
            // 
            this.plannedStartdDataGridViewTextBoxColumn.DataPropertyName = "PlannedStartd";
            this.plannedStartdDataGridViewTextBoxColumn.HeaderText = "PlannedStartd";
            this.plannedStartdDataGridViewTextBoxColumn.Name = "plannedStartdDataGridViewTextBoxColumn";
            // 
            // plannedEnddDataGridViewTextBoxColumn
            // 
            this.plannedEnddDataGridViewTextBoxColumn.DataPropertyName = "PlannedEndd";
            this.plannedEnddDataGridViewTextBoxColumn.HeaderText = "PlannedEndd";
            this.plannedEnddDataGridViewTextBoxColumn.Name = "plannedEnddDataGridViewTextBoxColumn";
            // 
            // inproductionDataGridViewTextBoxColumn
            // 
            this.inproductionDataGridViewTextBoxColumn.DataPropertyName = "Inproduction";
            this.inproductionDataGridViewTextBoxColumn.HeaderText = "Inproduction";
            this.inproductionDataGridViewTextBoxColumn.Name = "inproductionDataGridViewTextBoxColumn";
            // 
            // orderDetailDataGridViewTextBoxColumn
            // 
            this.orderDetailDataGridViewTextBoxColumn.DataPropertyName = "OrderDetail";
            this.orderDetailDataGridViewTextBoxColumn.HeaderText = "OrderDetail";
            this.orderDetailDataGridViewTextBoxColumn.Name = "orderDetailDataGridViewTextBoxColumn";
            // 
            // orderDetail1DataGridViewTextBoxColumn
            // 
            this.orderDetail1DataGridViewTextBoxColumn.DataPropertyName = "OrderDetail1";
            this.orderDetail1DataGridViewTextBoxColumn.HeaderText = "OrderDetail1";
            this.orderDetail1DataGridViewTextBoxColumn.Name = "orderDetail1DataGridViewTextBoxColumn";
            // 
            // plannedProductionEmployeeDetailsDataGridViewTextBoxColumn
            // 
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.DataPropertyName = "PlannedProductionEmployeeDetails";
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.HeaderText = "PlannedProductionEmployeeDetails";
            this.plannedProductionEmployeeDetailsDataGridViewTextBoxColumn.Name = "plannedProductionEmployeeDetailsDataGridViewTextBoxColumn";
            // 
            // productionProcesDataGridViewTextBoxColumn
            // 
            this.productionProcesDataGridViewTextBoxColumn.DataPropertyName = "ProductionProces";
            this.productionProcesDataGridViewTextBoxColumn.HeaderText = "ProductionProces";
            this.productionProcesDataGridViewTextBoxColumn.Name = "productionProcesDataGridViewTextBoxColumn";
            // 
            // ProductionPlanned
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnEmployee);
            this.Controls.Add(this.btnMachineDet);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnEditPlan);
            this.Controls.Add(this.btnAddPlan);
            this.Controls.Add(this.txtBoxPlanSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PlannedProductionGridView);
            this.Name = "ProductionPlanned";
            this.Text = "Planowana produkcja";
            this.Load += new System.EventHandler(this.ProductionPlanned_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlannedProductionGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.technologyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.plannedProductionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PlannedProductionGridView;
        private System.Windows.Forms.BindingSource plannedProductionBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxPlanSearch;
        private System.Windows.Forms.Button btnAddPlan;
        private System.Windows.Forms.Button btnEditPlan;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnMachineDet;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.BindingSource technologyBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMachineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedStartdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedEnddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inproductionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderDetail1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn plannedProductionEmployeeDetailsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productionProcesDataGridViewTextBoxColumn;
    }
}
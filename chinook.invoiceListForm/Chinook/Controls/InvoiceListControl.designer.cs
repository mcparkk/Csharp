namespace Chinook.Controls
{
    partial class InvoiceListControl
    {
        /// <summary> 
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvInvoice = new System.Windows.Forms.DataGridView();
            this.bdsInvoice = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.고객명 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주문날짜 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.주소 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.도시 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.나라 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.총액 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInvoice
            // 
            this.dgvInvoice.AutoGenerateColumns = false;
            this.dgvInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceIdDataGridViewTextBoxColumn,
            this.고객명,
            this.주문날짜,
            this.주소,
            this.도시,
            this.나라,
            this.총액});
            this.dgvInvoice.DataSource = this.bdsInvoice;
            this.dgvInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvoice.Location = new System.Drawing.Point(0, 0);
            this.dgvInvoice.Name = "dgvInvoice";
            this.dgvInvoice.RowHeadersWidth = 51;
            this.dgvInvoice.RowTemplate.Height = 27;
            this.dgvInvoice.Size = new System.Drawing.Size(1053, 270);
            this.dgvInvoice.TabIndex = 0;
            // 
            // bdsInvoice
            // 
            this.bdsInvoice.DataSource = typeof(Chinook.Data.Invoice);
            // 
            // invoiceIdDataGridViewTextBoxColumn
            // 
            this.invoiceIdDataGridViewTextBoxColumn.DataPropertyName = "InvoiceId";
            this.invoiceIdDataGridViewTextBoxColumn.HeaderText = "No.";
            this.invoiceIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.invoiceIdDataGridViewTextBoxColumn.Name = "invoiceIdDataGridViewTextBoxColumn";
            this.invoiceIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // 고객명
            // 
            this.고객명.DataPropertyName = "CustomerName";
            this.고객명.HeaderText = "고객명";
            this.고객명.MinimumWidth = 6;
            this.고객명.Name = "고객명";
            this.고객명.Width = 125;
            // 
            // 주문날짜
            // 
            this.주문날짜.DataPropertyName = "InvoiceDate";
            this.주문날짜.HeaderText = "주문일";
            this.주문날짜.MinimumWidth = 6;
            this.주문날짜.Name = "주문날짜";
            this.주문날짜.Width = 125;
            // 
            // 주소
            // 
            this.주소.DataPropertyName = "BillingAddress";
            this.주소.HeaderText = "상세주소";
            this.주소.MinimumWidth = 6;
            this.주소.Name = "주소";
            this.주소.Width = 125;
            // 
            // 도시
            // 
            this.도시.DataPropertyName = "BillingCity";
            this.도시.HeaderText = "도시";
            this.도시.MinimumWidth = 6;
            this.도시.Name = "도시";
            this.도시.Width = 125;
            // 
            // 나라
            // 
            this.나라.DataPropertyName = "BillingCountry";
            this.나라.HeaderText = "국가";
            this.나라.MinimumWidth = 6;
            this.나라.Name = "나라";
            this.나라.Width = 125;
            // 
            // 총액
            // 
            this.총액.DataPropertyName = "Total";
            this.총액.HeaderText = "총액";
            this.총액.MinimumWidth = 6;
            this.총액.Name = "총액";
            this.총액.Width = 125;
            // 
            // InvoiceListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvInvoice);
            this.Name = "InvoiceListControl";
            this.Size = new System.Drawing.Size(1053, 270);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdsInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInvoice;
        private System.Windows.Forms.BindingSource bdsInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 고객명;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주문날짜;
        private System.Windows.Forms.DataGridViewTextBoxColumn 주소;
        private System.Windows.Forms.DataGridViewTextBoxColumn 도시;
        private System.Windows.Forms.DataGridViewTextBoxColumn 나라;
        private System.Windows.Forms.DataGridViewTextBoxColumn 총액;
    }
}

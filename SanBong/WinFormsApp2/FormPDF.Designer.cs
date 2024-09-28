namespace WinFormsApp2
{
    partial class FormPDF
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
            btn_pdf = new Button();
            dgv_PDF = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgv_PDF).BeginInit();
            SuspendLayout();
            // 
            // btn_pdf
            // 
            btn_pdf.Location = new Point(12, 112);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(94, 29);
            btn_pdf.TabIndex = 1;
            btn_pdf.Text = "Xuất PDF";
            btn_pdf.UseVisualStyleBackColor = true;
            btn_pdf.Click += btn_pdf_Click;
            // 
            // dgv_PDF
            // 
            dgv_PDF.AllowUserToAddRows = false;
            dgv_PDF.AllowUserToDeleteRows = false;
            dgv_PDF.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_PDF.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_PDF.Location = new Point(12, 162);
            dgv_PDF.Name = "dgv_PDF";
            dgv_PDF.ReadOnly = true;
            dgv_PDF.RowHeadersWidth = 51;
            dgv_PDF.RowTemplate.Height = 29;
            dgv_PDF.Size = new Size(1295, 267);
            dgv_PDF.TabIndex = 3;
            // 
            // FormPDF
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 943);
            Controls.Add(dgv_PDF);
            Controls.Add(btn_pdf);
            Name = "FormPDF";
            Text = "FormPDF";
            ((System.ComponentModel.ISupportInitialize)dgv_PDF).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btn_pdf;
        private DataGridView dgv_PDF;
    }
}
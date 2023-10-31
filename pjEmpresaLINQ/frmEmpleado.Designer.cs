namespace pjEmpresaLINQ
{
    partial class frmEmpleado
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
            dgvEmpleados = new DataGridView();
            groupBox1 = new GroupBox();
            txtNameSearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvEmpleados
            // 
            dgvEmpleados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmpleados.Location = new Point(27, 158);
            dgvEmpleados.Name = "dgvEmpleados";
            dgvEmpleados.RowTemplate.Height = 25;
            dgvEmpleados.Size = new Size(740, 267);
            dgvEmpleados.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtNameSearch);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(27, 37);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 100);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Filtros de Búsqueda";
            // 
            // txtNameSearch
            // 
            txtNameSearch.Location = new Point(69, 25);
            txtNameSearch.Name = "txtNameSearch";
            txtNameSearch.Size = new Size(230, 23);
            txtNameSearch.TabIndex = 1;
            txtNameSearch.KeyDown += txtName_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // frmEmpleado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(dgvEmpleados);
            Name = "frmEmpleado";
            Text = "frmEmpleado";
            ((System.ComponentModel.ISupportInitialize)dgvEmpleados).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvEmpleados;
        private GroupBox groupBox1;
        private TextBox txtNameSearch;
        private Label label1;
    }
}
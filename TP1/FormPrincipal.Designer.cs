namespace TP1
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblIntegrantes = new Label();
            lstNombres = new ListBox();
            btnEjercicio1 = new Button();
            SuspendLayout();
            // 
            // lblIntegrantes
            // 
            lblIntegrantes.AutoSize = true;
            lblIntegrantes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblIntegrantes.Location = new Point(12, 157);
            lblIntegrantes.Name = "lblIntegrantes";
            lblIntegrantes.Size = new Size(119, 25);
            lblIntegrantes.TabIndex = 0;
            lblIntegrantes.Text = "Integrantes:";
            // 
            // lstNombres
            // 
            lstNombres.Font = new Font("Segoe UI", 12F);
            lstNombres.FormattingEnabled = true;
            lstNombres.ItemHeight = 21;
            lstNombres.Location = new Point(137, 182);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(248, 88);
            lstNombres.TabIndex = 1;
            // 
            // btnEjercicio1
            // 
            btnEjercicio1.BackColor = SystemColors.Window;
            btnEjercicio1.Font = new Font("Segoe UI", 16F);
            btnEjercicio1.Location = new Point(9, 70);
            btnEjercicio1.Name = "btnEjercicio1";
            btnEjercicio1.Size = new Size(155, 43);
            btnEjercicio1.TabIndex = 2;
            btnEjercicio1.Text = "EJERCICIO 1";
            btnEjercicio1.UseVisualStyleBackColor = false;
            btnEjercicio1.Click += btnEjercicio1_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(544, 415);
            Controls.Add(btnEjercicio1);
            Controls.Add(lstNombres);
            Controls.Add(lblIntegrantes);
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formulario Principal";
            Load += FormPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIntegrantes;
        private ListBox lstNombres;
        private Button btnEjercicio1;
    }
}

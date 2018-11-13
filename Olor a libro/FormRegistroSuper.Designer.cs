namespace Olor_a_libro
{
    partial class FormRegistroSuper
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
            this.labelContraseñaSuper = new System.Windows.Forms.Label();
            this.textBoxContraseñaSuper = new System.Windows.Forms.TextBox();
            this.buttonAceptarSuper = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelContraseñaSuper
            // 
            this.labelContraseñaSuper.AutoSize = true;
            this.labelContraseñaSuper.Location = new System.Drawing.Point(12, 24);
            this.labelContraseñaSuper.Name = "labelContraseñaSuper";
            this.labelContraseñaSuper.Size = new System.Drawing.Size(61, 13);
            this.labelContraseñaSuper.TabIndex = 0;
            this.labelContraseñaSuper.Text = "Contraseña";
            // 
            // textBoxContraseñaSuper
            // 
            this.textBoxContraseñaSuper.Location = new System.Drawing.Point(79, 21);
            this.textBoxContraseñaSuper.Name = "textBoxContraseñaSuper";
            this.textBoxContraseñaSuper.PasswordChar = '*';
            this.textBoxContraseñaSuper.Size = new System.Drawing.Size(193, 20);
            this.textBoxContraseñaSuper.TabIndex = 1;
            // 
            // buttonAceptarSuper
            // 
            this.buttonAceptarSuper.Location = new System.Drawing.Point(197, 60);
            this.buttonAceptarSuper.Name = "buttonAceptarSuper";
            this.buttonAceptarSuper.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptarSuper.TabIndex = 2;
            this.buttonAceptarSuper.Text = "Aceptar";
            this.buttonAceptarSuper.UseVisualStyleBackColor = true;
            this.buttonAceptarSuper.Click += new System.EventHandler(this.buttonAceptarSuper_Click);
            // 
            // FormRegistroSuper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(284, 97);
            this.Controls.Add(this.buttonAceptarSuper);
            this.Controls.Add(this.textBoxContraseñaSuper);
            this.Controls.Add(this.labelContraseñaSuper);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRegistroSuper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Privilegios super usuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelContraseñaSuper;
        private System.Windows.Forms.TextBox textBoxContraseñaSuper;
        private System.Windows.Forms.Button buttonAceptarSuper;
    }
}
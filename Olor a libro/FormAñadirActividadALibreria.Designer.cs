namespace Olor_a_libro
{
    partial class FormAñadirActividadALibreria
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
            this.dataGridViewActividades = new System.Windows.Forms.DataGridView();
            this.buttonAñadirActividadALibreria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewActividades
            // 
            this.dataGridViewActividades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(197)))), ((int)(((byte)(220)))));
            this.dataGridViewActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewActividades.Location = new System.Drawing.Point(9, 12);
            this.dataGridViewActividades.Name = "dataGridViewActividades";
            this.dataGridViewActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewActividades.Size = new System.Drawing.Size(378, 205);
            this.dataGridViewActividades.TabIndex = 0;
            // 
            // buttonAñadirActividadALibreria
            // 
            this.buttonAñadirActividadALibreria.Location = new System.Drawing.Point(312, 233);
            this.buttonAñadirActividadALibreria.Name = "buttonAñadirActividadALibreria";
            this.buttonAñadirActividadALibreria.Size = new System.Drawing.Size(75, 23);
            this.buttonAñadirActividadALibreria.TabIndex = 1;
            this.buttonAñadirActividadALibreria.Text = "Añadir";
            this.buttonAñadirActividadALibreria.UseVisualStyleBackColor = true;
            this.buttonAñadirActividadALibreria.Click += new System.EventHandler(this.buttonAñadirActividadALibreria_Click);
            // 
            // FormAñadirActividadALibreria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(396, 268);
            this.Controls.Add(this.buttonAñadirActividadALibreria);
            this.Controls.Add(this.dataGridViewActividades);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAñadirActividadALibreria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Olor A Libro - Añadir actividad a libreria";
            this.Load += new System.EventHandler(this.FormAñadirActividadALibreria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewActividades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewActividades;
        private System.Windows.Forms.Button buttonAñadirActividadALibreria;
    }
}
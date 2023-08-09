namespace Interfazhospital
{
    partial class Form2
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.cmbEspecialidades = new System.Windows.Forms.ComboBox();
            this.cmbDoctores = new System.Windows.Forms.ComboBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnAgendarCita = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 12);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(108, 25);
            this.btnVolver.TabIndex = 7;
            this.btnVolver.Text = "volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cmbEspecialidades
            // 
            this.cmbEspecialidades.FormattingEnabled = true;
            this.cmbEspecialidades.Location = new System.Drawing.Point(155, 174);
            this.cmbEspecialidades.Name = "cmbEspecialidades";
            this.cmbEspecialidades.Size = new System.Drawing.Size(175, 21);
            this.cmbEspecialidades.TabIndex = 8;
            this.cmbEspecialidades.SelectedIndexChanged += new System.EventHandler(this.cmbEspecialidades_SelectedIndexChanged);
            // 
            // cmbDoctores
            // 
            this.cmbDoctores.FormattingEnabled = true;
            this.cmbDoctores.Location = new System.Drawing.Point(155, 201);
            this.cmbDoctores.Name = "cmbDoctores";
            this.cmbDoctores.Size = new System.Drawing.Size(175, 21);
            this.cmbDoctores.TabIndex = 9;
            this.cmbDoctores.SelectedIndexChanged += new System.EventHandler(this.cmbDoctores_SelectedIndexChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(342, 112);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 10;
            // 
            // btnAgendarCita
            // 
            this.btnAgendarCita.Location = new System.Drawing.Point(243, 300);
            this.btnAgendarCita.Name = "btnAgendarCita";
            this.btnAgendarCita.Size = new System.Drawing.Size(216, 51);
            this.btnAgendarCita.TabIndex = 11;
            this.btnAgendarCita.Text = "Agendar cita";
            this.btnAgendarCita.UseVisualStyleBackColor = true;
            this.btnAgendarCita.Click += new System.EventHandler(this.btnAgendarCita_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAgendarCita);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.cmbDoctores);
            this.Controls.Add(this.cmbEspecialidades);
            this.Controls.Add(this.btnVolver);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cmbEspecialidades;
        private System.Windows.Forms.ComboBox cmbDoctores;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnAgendarCita;
    }
}
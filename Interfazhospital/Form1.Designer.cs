namespace Interfazhospital
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnConsulta = new System.Windows.Forms.Button();
            this.btnLaboratorio = new System.Windows.Forms.Button();
            this.btnCitasprevias = new System.Windows.Forms.Button();
            this.btnTerapia = new System.Windows.Forms.Button();
            this.btnRecetas = new System.Windows.Forms.Button();
            this.btnCitasagendadas = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(275, 123);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(171, 49);
            this.btnConsulta.TabIndex = 0;
            this.btnConsulta.Text = "Consulta Medica";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnLaboratorio
            // 
            this.btnLaboratorio.Location = new System.Drawing.Point(275, 178);
            this.btnLaboratorio.Name = "btnLaboratorio";
            this.btnLaboratorio.Size = new System.Drawing.Size(171, 49);
            this.btnLaboratorio.TabIndex = 1;
            this.btnLaboratorio.Text = "Laboratorio";
            this.btnLaboratorio.UseVisualStyleBackColor = true;
            // 
            // btnCitasprevias
            // 
            this.btnCitasprevias.Location = new System.Drawing.Point(275, 325);
            this.btnCitasprevias.Name = "btnCitasprevias";
            this.btnCitasprevias.Size = new System.Drawing.Size(171, 49);
            this.btnCitasprevias.TabIndex = 2;
            this.btnCitasprevias.Text = "Citas previas";
            this.btnCitasprevias.UseVisualStyleBackColor = true;
            // 
            // btnTerapia
            // 
            this.btnTerapia.Location = new System.Drawing.Point(452, 123);
            this.btnTerapia.Name = "btnTerapia";
            this.btnTerapia.Size = new System.Drawing.Size(171, 49);
            this.btnTerapia.TabIndex = 3;
            this.btnTerapia.Text = "Terapia Fisica";
            this.btnTerapia.UseVisualStyleBackColor = true;
            // 
            // btnRecetas
            // 
            this.btnRecetas.Location = new System.Drawing.Point(452, 178);
            this.btnRecetas.Name = "btnRecetas";
            this.btnRecetas.Size = new System.Drawing.Size(171, 49);
            this.btnRecetas.TabIndex = 4;
            this.btnRecetas.Text = "Recetas medicas";
            this.btnRecetas.UseVisualStyleBackColor = true;
            // 
            // btnCitasagendadas
            // 
            this.btnCitasagendadas.Location = new System.Drawing.Point(452, 325);
            this.btnCitasagendadas.Name = "btnCitasagendadas";
            this.btnCitasagendadas.Size = new System.Drawing.Size(171, 49);
            this.btnCitasagendadas.TabIndex = 5;
            this.btnCitasagendadas.Text = "Citas agendadas";
            this.btnCitasagendadas.UseVisualStyleBackColor = true;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(12, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(108, 25);
            this.btnCerrar.TabIndex = 6;
            this.btnCerrar.Text = "Salir";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "HOSPITAL X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(174, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "SERVICIOS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(174, 294);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "INFORMACION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnCitasagendadas);
            this.Controls.Add(this.btnRecetas);
            this.Controls.Add(this.btnTerapia);
            this.Controls.Add(this.btnCitasprevias);
            this.Controls.Add(this.btnLaboratorio);
            this.Controls.Add(this.btnConsulta);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.Button btnLaboratorio;
        private System.Windows.Forms.Button btnCitasprevias;
        private System.Windows.Forms.Button btnTerapia;
        private System.Windows.Forms.Button btnRecetas;
        private System.Windows.Forms.Button btnCitasagendadas;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


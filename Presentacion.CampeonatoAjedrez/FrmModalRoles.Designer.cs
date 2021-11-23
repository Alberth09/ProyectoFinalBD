
namespace Presentacion.CampeonatoAjedrez
{
    partial class FrmModalRoles
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPartida = new System.Windows.Forms.TextBox();
            this.txtParticipante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtJornada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbBlancas = new System.Windows.Forms.RadioButton();
            this.rbNegras = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de partida:";
            // 
            // txtPartida
            // 
            this.txtPartida.Location = new System.Drawing.Point(12, 29);
            this.txtPartida.Name = "txtPartida";
            this.txtPartida.Size = new System.Drawing.Size(100, 20);
            this.txtPartida.TabIndex = 1;
            // 
            // txtParticipante
            // 
            this.txtParticipante.Location = new System.Drawing.Point(275, 29);
            this.txtParticipante.Name = "txtParticipante";
            this.txtParticipante.Size = new System.Drawing.Size(105, 20);
            this.txtParticipante.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID de participante:";
            // 
            // txtJornada
            // 
            this.txtJornada.Location = new System.Drawing.Point(134, 29);
            this.txtJornada.Name = "txtJornada";
            this.txtJornada.Size = new System.Drawing.Size(115, 20);
            this.txtJornada.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Jornada (yyyy/mm/dd): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color: ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbBlancas);
            this.panel1.Controls.Add(this.rbNegras);
            this.panel1.Location = new System.Drawing.Point(49, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 40);
            this.panel1.TabIndex = 7;
            // 
            // rbBlancas
            // 
            this.rbBlancas.AutoSize = true;
            this.rbBlancas.Location = new System.Drawing.Point(71, 11);
            this.rbBlancas.Name = "rbBlancas";
            this.rbBlancas.Size = new System.Drawing.Size(63, 17);
            this.rbBlancas.TabIndex = 1;
            this.rbBlancas.TabStop = true;
            this.rbBlancas.Text = "Blancas";
            this.rbBlancas.UseVisualStyleBackColor = true;
            // 
            // rbNegras
            // 
            this.rbNegras.AutoSize = true;
            this.rbNegras.Location = new System.Drawing.Point(3, 11);
            this.rbNegras.Name = "rbNegras";
            this.rbNegras.Size = new System.Drawing.Size(59, 17);
            this.rbNegras.TabIndex = 0;
            this.rbNegras.TabStop = true;
            this.rbNegras.Text = "Negras";
            this.rbNegras.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(15, 126);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(102, 46);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(137, 126);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(101, 46);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // FrmModalRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 233);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtJornada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParticipante);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPartida);
            this.Controls.Add(this.label1);
            this.Name = "FrmModalRoles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Agregar roles.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPartida;
        private System.Windows.Forms.TextBox txtParticipante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtJornada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbBlancas;
        private System.Windows.Forms.RadioButton rbNegras;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
    }
}
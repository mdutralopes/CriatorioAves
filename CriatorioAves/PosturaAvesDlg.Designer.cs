
namespace CriatorioAves
{
    partial class PosturaAvesDlg
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
            this.rbnDesconhecido = new System.Windows.Forms.RadioButton();
            this.rbnFemea = new System.Windows.Forms.RadioButton();
            this.rbnMacho = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.cbCriador = new System.Windows.Forms.ComboBox();
            this.txtCorMutacao = new System.Windows.Forms.TextBox();
            this.txtIdentAve = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbnDesconhecido
            // 
            this.rbnDesconhecido.AutoSize = true;
            this.rbnDesconhecido.Location = new System.Drawing.Point(364, 74);
            this.rbnDesconhecido.Name = "rbnDesconhecido";
            this.rbnDesconhecido.Size = new System.Drawing.Size(94, 17);
            this.rbnDesconhecido.TabIndex = 67;
            this.rbnDesconhecido.TabStop = true;
            this.rbnDesconhecido.Text = "&Desconhecido";
            this.rbnDesconhecido.UseVisualStyleBackColor = true;
            // 
            // rbnFemea
            // 
            this.rbnFemea.AutoSize = true;
            this.rbnFemea.Location = new System.Drawing.Point(289, 74);
            this.rbnFemea.Name = "rbnFemea";
            this.rbnFemea.Size = new System.Drawing.Size(57, 17);
            this.rbnFemea.TabIndex = 63;
            this.rbnFemea.TabStop = true;
            this.rbnFemea.Text = "&Fêmea";
            this.rbnFemea.UseVisualStyleBackColor = true;
            // 
            // rbnMacho
            // 
            this.rbnMacho.AutoSize = true;
            this.rbnMacho.Location = new System.Drawing.Point(213, 74);
            this.rbnMacho.Name = "rbnMacho";
            this.rbnMacho.Size = new System.Drawing.Size(58, 17);
            this.rbnMacho.TabIndex = 62;
            this.rbnMacho.TabStop = true;
            this.rbnMacho.Text = "&Macho";
            this.rbnMacho.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(119, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 66;
            this.label15.Text = "Sexo*";
            // 
            // cbCriador
            // 
            this.cbCriador.FormattingEnabled = true;
            this.cbCriador.Location = new System.Drawing.Point(213, 158);
            this.cbCriador.Name = "cbCriador";
            this.cbCriador.Size = new System.Drawing.Size(200, 21);
            this.cbCriador.TabIndex = 65;
            // 
            // txtCorMutacao
            // 
            this.txtCorMutacao.Location = new System.Drawing.Point(213, 115);
            this.txtCorMutacao.Name = "txtCorMutacao";
            this.txtCorMutacao.Size = new System.Drawing.Size(179, 20);
            this.txtCorMutacao.TabIndex = 64;
            // 
            // txtIdentAve
            // 
            this.txtIdentAve.Location = new System.Drawing.Point(213, 29);
            this.txtIdentAve.Name = "txtIdentAve";
            this.txtIdentAve.Size = new System.Drawing.Size(128, 20);
            this.txtIdentAve.TabIndex = 61;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(119, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 60;
            this.label13.Text = "Criador*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 59;
            this.label10.Text = "Identificação*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Cor/Mutação*";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancBtn);
            this.panel1.Controls.Add(this.confBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(576, 39);
            this.panel1.TabIndex = 68;
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(325, 7);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 8;
            this.cancBtn.Text = "Cancelar";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // confBtn
            // 
            this.confBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confBtn.Location = new System.Drawing.Point(174, 7);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(75, 23);
            this.confBtn.TabIndex = 7;
            this.confBtn.Text = "Confirmar";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // PosturaAvesDlg
            // 
            this.AcceptButton = this.confBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.cancBtn;
            this.ClientSize = new System.Drawing.Size(576, 258);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbnDesconhecido);
            this.Controls.Add(this.rbnFemea);
            this.Controls.Add(this.rbnMacho);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbCriador);
            this.Controls.Add(this.txtCorMutacao);
            this.Controls.Add(this.txtIdentAve);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PosturaAvesDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Associar Posturas e Filhotes";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbnDesconhecido;
        private System.Windows.Forms.RadioButton rbnFemea;
        private System.Windows.Forms.RadioButton rbnMacho;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbCriador;
        private System.Windows.Forms.TextBox txtCorMutacao;
        private System.Windows.Forms.TextBox txtIdentAve;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Button confBtn;
    }
}
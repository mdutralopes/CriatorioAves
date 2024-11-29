
namespace CriatorioAves
{
    partial class FiltroAveDlg
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
            this.components = new System.ComponentModel.Container();
            this.limparBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.chkEspecie = new System.Windows.Forms.CheckBox();
            this.chkSexo = new System.Windows.Forms.CheckBox();
            this.chkStatus = new System.Windows.Forms.CheckBox();
            this.chkGaiola = new System.Windows.Forms.CheckBox();
            this.chkCriador = new System.Windows.Forms.CheckBox();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.rbnDesconhecido = new System.Windows.Forms.RadioButton();
            this.rbnFemea = new System.Windows.Forms.RadioButton();
            this.rbnMacho = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.cbGaiola = new System.Windows.Forms.ComboBox();
            this.cbCriador = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.chkAnoNasc = new System.Windows.Forms.CheckBox();
            this.nudAnoNasc = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoNasc)).BeginInit();
            this.SuspendLayout();
            // 
            // limparBtn
            // 
            this.limparBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.limparBtn.Location = new System.Drawing.Point(363, 7);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 9;
            this.limparBtn.Text = "Limpar";
            this.toolTip1.SetToolTip(this.limparBtn, "Limpa o filtro");
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(212, 7);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 8;
            this.cancBtn.Text = "Cancelar";
            this.toolTip1.SetToolTip(this.cancBtn, "Cancela a operação");
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // confBtn
            // 
            this.confBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confBtn.Location = new System.Drawing.Point(61, 7);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(75, 23);
            this.confBtn.TabIndex = 7;
            this.confBtn.Text = "Confirmar";
            this.toolTip1.SetToolTip(this.confBtn, "Confirma o filtro");
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // chkEspecie
            // 
            this.chkEspecie.AutoSize = true;
            this.chkEspecie.Location = new System.Drawing.Point(71, 21);
            this.chkEspecie.Name = "chkEspecie";
            this.chkEspecie.Size = new System.Drawing.Size(64, 17);
            this.chkEspecie.TabIndex = 10;
            this.chkEspecie.Text = "Espécie";
            this.chkEspecie.UseVisualStyleBackColor = true;
            this.chkEspecie.CheckedChanged += new System.EventHandler(this.chkEspecie_CheckedChanged);
            // 
            // chkSexo
            // 
            this.chkSexo.AutoSize = true;
            this.chkSexo.Location = new System.Drawing.Point(71, 52);
            this.chkSexo.Name = "chkSexo";
            this.chkSexo.Size = new System.Drawing.Size(50, 17);
            this.chkSexo.TabIndex = 11;
            this.chkSexo.Text = "Sexo";
            this.chkSexo.UseVisualStyleBackColor = true;
            this.chkSexo.CheckedChanged += new System.EventHandler(this.chkSexo_CheckedChanged);
            // 
            // chkStatus
            // 
            this.chkStatus.AutoSize = true;
            this.chkStatus.Location = new System.Drawing.Point(71, 83);
            this.chkStatus.Name = "chkStatus";
            this.chkStatus.Size = new System.Drawing.Size(56, 17);
            this.chkStatus.TabIndex = 12;
            this.chkStatus.Text = "Status";
            this.chkStatus.UseVisualStyleBackColor = true;
            this.chkStatus.CheckedChanged += new System.EventHandler(this.chkStatus_CheckedChanged);
            // 
            // chkGaiola
            // 
            this.chkGaiola.AutoSize = true;
            this.chkGaiola.Location = new System.Drawing.Point(71, 114);
            this.chkGaiola.Name = "chkGaiola";
            this.chkGaiola.Size = new System.Drawing.Size(56, 17);
            this.chkGaiola.TabIndex = 13;
            this.chkGaiola.Text = "Gaiola";
            this.chkGaiola.UseVisualStyleBackColor = true;
            this.chkGaiola.CheckedChanged += new System.EventHandler(this.chkGaiola_CheckedChanged);
            // 
            // chkCriador
            // 
            this.chkCriador.AutoSize = true;
            this.chkCriador.Location = new System.Drawing.Point(71, 145);
            this.chkCriador.Name = "chkCriador";
            this.chkCriador.Size = new System.Drawing.Size(59, 17);
            this.chkCriador.TabIndex = 14;
            this.chkCriador.Text = "Criador";
            this.chkCriador.UseVisualStyleBackColor = true;
            this.chkCriador.CheckedChanged += new System.EventHandler(this.chkCriador_CheckedChanged);
            // 
            // cbEspecie
            // 
            this.cbEspecie.Enabled = false;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(183, 19);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(180, 21);
            this.cbEspecie.TabIndex = 45;
            // 
            // rbnDesconhecido
            // 
            this.rbnDesconhecido.AutoSize = true;
            this.rbnDesconhecido.Enabled = false;
            this.rbnDesconhecido.Location = new System.Drawing.Point(335, 52);
            this.rbnDesconhecido.Name = "rbnDesconhecido";
            this.rbnDesconhecido.Size = new System.Drawing.Size(94, 17);
            this.rbnDesconhecido.TabIndex = 60;
            this.rbnDesconhecido.TabStop = true;
            this.rbnDesconhecido.Text = "&Desconhecido";
            this.rbnDesconhecido.UseVisualStyleBackColor = true;
            this.rbnDesconhecido.CheckedChanged += new System.EventHandler(this.rbnDesconhecido_CheckedChanged);
            // 
            // rbnFemea
            // 
            this.rbnFemea.AutoSize = true;
            this.rbnFemea.Enabled = false;
            this.rbnFemea.Location = new System.Drawing.Point(260, 52);
            this.rbnFemea.Name = "rbnFemea";
            this.rbnFemea.Size = new System.Drawing.Size(57, 17);
            this.rbnFemea.TabIndex = 59;
            this.rbnFemea.TabStop = true;
            this.rbnFemea.Text = "&Fêmea";
            this.rbnFemea.UseVisualStyleBackColor = true;
            this.rbnFemea.CheckedChanged += new System.EventHandler(this.rbnFemea_CheckedChanged);
            // 
            // rbnMacho
            // 
            this.rbnMacho.AutoSize = true;
            this.rbnMacho.Enabled = false;
            this.rbnMacho.Location = new System.Drawing.Point(184, 52);
            this.rbnMacho.Name = "rbnMacho";
            this.rbnMacho.Size = new System.Drawing.Size(58, 17);
            this.rbnMacho.TabIndex = 58;
            this.rbnMacho.TabStop = true;
            this.rbnMacho.Text = "&Macho";
            this.rbnMacho.UseVisualStyleBackColor = true;
            this.rbnMacho.CheckedChanged += new System.EventHandler(this.rbnMacho_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancBtn);
            this.panel1.Controls.Add(this.confBtn);
            this.panel1.Controls.Add(this.limparBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 39);
            this.panel1.TabIndex = 61;
            // 
            // cbStatus
            // 
            this.cbStatus.Enabled = false;
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Com os Pais",
            "Reprodução",
            "Descanso",
            "Desaparecido",
            "Falecido",
            "Vendido",
            "Reservado",
            "Plantel"});
            this.cbStatus.Location = new System.Drawing.Point(183, 81);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(180, 21);
            this.cbStatus.TabIndex = 62;
            // 
            // cbGaiola
            // 
            this.cbGaiola.Enabled = false;
            this.cbGaiola.FormattingEnabled = true;
            this.cbGaiola.Location = new System.Drawing.Point(184, 112);
            this.cbGaiola.Name = "cbGaiola";
            this.cbGaiola.Size = new System.Drawing.Size(180, 21);
            this.cbGaiola.TabIndex = 63;
            // 
            // cbCriador
            // 
            this.cbCriador.Enabled = false;
            this.cbCriador.FormattingEnabled = true;
            this.cbCriador.Location = new System.Drawing.Point(184, 143);
            this.cbCriador.Name = "cbCriador";
            this.cbCriador.Size = new System.Drawing.Size(180, 21);
            this.cbCriador.TabIndex = 64;
            // 
            // chkAnoNasc
            // 
            this.chkAnoNasc.AutoSize = true;
            this.chkAnoNasc.Location = new System.Drawing.Point(71, 176);
            this.chkAnoNasc.Name = "chkAnoNasc";
            this.chkAnoNasc.Size = new System.Drawing.Size(104, 17);
            this.chkAnoNasc.TabIndex = 65;
            this.chkAnoNasc.Text = "Ano Nascimento";
            this.chkAnoNasc.UseVisualStyleBackColor = true;
            this.chkAnoNasc.CheckedChanged += new System.EventHandler(this.chkAnoNasc_CheckedChanged);
            // 
            // nudAnoNasc
            // 
            this.nudAnoNasc.Enabled = false;
            this.nudAnoNasc.Location = new System.Drawing.Point(184, 174);
            this.nudAnoNasc.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudAnoNasc.Name = "nudAnoNasc";
            this.nudAnoNasc.Size = new System.Drawing.Size(77, 20);
            this.nudAnoNasc.TabIndex = 66;
            this.nudAnoNasc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FiltroAveDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancBtn;
            this.ClientSize = new System.Drawing.Size(501, 249);
            this.Controls.Add(this.nudAnoNasc);
            this.Controls.Add(this.chkAnoNasc);
            this.Controls.Add(this.cbCriador);
            this.Controls.Add(this.cbGaiola);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.rbnDesconhecido);
            this.Controls.Add(this.rbnFemea);
            this.Controls.Add(this.rbnMacho);
            this.Controls.Add(this.cbEspecie);
            this.Controls.Add(this.chkCriador);
            this.Controls.Add(this.chkGaiola);
            this.Controls.Add(this.chkStatus);
            this.Controls.Add(this.chkSexo);
            this.Controls.Add(this.chkEspecie);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FiltroAveDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Registros Aves";
            this.Load += new System.EventHandler(this.FiltroAveDlg_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnoNasc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.CheckBox chkEspecie;
        private System.Windows.Forms.CheckBox chkSexo;
        private System.Windows.Forms.CheckBox chkStatus;
        private System.Windows.Forms.CheckBox chkGaiola;
        private System.Windows.Forms.CheckBox chkCriador;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.RadioButton rbnDesconhecido;
        private System.Windows.Forms.RadioButton rbnFemea;
        private System.Windows.Forms.RadioButton rbnMacho;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.ComboBox cbGaiola;
        private System.Windows.Forms.ComboBox cbCriador;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox chkAnoNasc;
        private System.Windows.Forms.NumericUpDown nudAnoNasc;
    }
}
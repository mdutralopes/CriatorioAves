
namespace CriatorioAves
{
    partial class ReservasAvesDlg
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancBtn = new System.Windows.Forms.Button();
            this.confBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.excListaBtn = new System.Windows.Forms.Button();
            this.incListaBtn = new System.Windows.Forms.Button();
            this.lbAves = new System.Windows.Forms.ListBox();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAve = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancBtn);
            this.panel1.Controls.Add(this.confBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 187);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 39);
            this.panel1.TabIndex = 8;
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(359, 7);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 5;
            this.cancBtn.Text = "Cancelar";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // confBtn
            // 
            this.confBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confBtn.Location = new System.Drawing.Point(208, 7);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(75, 23);
            this.confBtn.TabIndex = 4;
            this.confBtn.Text = "Confirmar";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.excListaBtn);
            this.panel2.Controls.Add(this.incListaBtn);
            this.panel2.Controls.Add(this.lbAves);
            this.panel2.Controls.Add(this.mskValor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cbAve);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbEspecie);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(645, 187);
            this.panel2.TabIndex = 9;
            // 
            // excListaBtn
            // 
            this.excListaBtn.Location = new System.Drawing.Point(209, 139);
            this.excListaBtn.Name = "excListaBtn";
            this.excListaBtn.Size = new System.Drawing.Size(100, 23);
            this.excListaBtn.TabIndex = 66;
            this.excListaBtn.Text = "Excluir da lista";
            this.excListaBtn.UseVisualStyleBackColor = true;
            this.excListaBtn.Click += new System.EventHandler(this.excListaBtn_Click);
            // 
            // incListaBtn
            // 
            this.incListaBtn.Location = new System.Drawing.Point(68, 139);
            this.incListaBtn.Name = "incListaBtn";
            this.incListaBtn.Size = new System.Drawing.Size(100, 23);
            this.incListaBtn.TabIndex = 65;
            this.incListaBtn.Text = "Incluir na lista";
            this.incListaBtn.UseVisualStyleBackColor = true;
            this.incListaBtn.Click += new System.EventHandler(this.incListaBtn_Click);
            // 
            // lbAves
            // 
            this.lbAves.FormattingEnabled = true;
            this.lbAves.Location = new System.Drawing.Point(370, 13);
            this.lbAves.Name = "lbAves";
            this.lbAves.Size = new System.Drawing.Size(249, 160);
            this.lbAves.TabIndex = 64;
            // 
            // mskValor
            // 
            this.mskValor.Location = new System.Drawing.Point(90, 90);
            this.mskValor.Name = "mskValor";
            this.mskValor.PromptChar = ' ';
            this.mskValor.Size = new System.Drawing.Size(100, 20);
            this.mskValor.TabIndex = 63;
            this.mskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 62;
            this.label3.Text = "Valor";
            // 
            // cbAve
            // 
            this.cbAve.Enabled = false;
            this.cbAve.FormattingEnabled = true;
            this.cbAve.Location = new System.Drawing.Point(90, 55);
            this.cbAve.Name = "cbAve";
            this.cbAve.Size = new System.Drawing.Size(255, 21);
            this.cbAve.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "Ave";
            // 
            // cbEspecie
            // 
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(90, 20);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(180, 21);
            this.cbEspecie.TabIndex = 59;
            this.cbEspecie.Leave += new System.EventHandler(this.cbEspecie_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Espécie";
            // 
            // ReservasAvesDlg
            // 
            this.AcceptButton = this.confBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.cancBtn;
            this.ClientSize = new System.Drawing.Size(645, 226);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ReservasAvesDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aves Reservadas";
            this.Load += new System.EventHandler(this.ReservasAvesDlg_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListBox lbAves;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbAve;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button excListaBtn;
        private System.Windows.Forms.Button incListaBtn;
    }
}
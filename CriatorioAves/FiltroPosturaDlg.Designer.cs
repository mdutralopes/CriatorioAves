
namespace CriatorioAves
{
    partial class FiltroPosturaDlg
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
            this.chkFiltrarAtivos = new System.Windows.Forms.CheckBox();
            this.chkAtivo = new System.Windows.Forms.CheckBox();
            this.chkFiltrarCasal = new System.Windows.Forms.CheckBox();
            this.cbCasal = new System.Windows.Forms.ComboBox();
            this.confBtn = new System.Windows.Forms.Button();
            this.cancBtn = new System.Windows.Forms.Button();
            this.limparBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkFiltrarAtivos
            // 
            this.chkFiltrarAtivos.AutoSize = true;
            this.chkFiltrarAtivos.Location = new System.Drawing.Point(21, 33);
            this.chkFiltrarAtivos.Name = "chkFiltrarAtivos";
            this.chkFiltrarAtivos.Size = new System.Drawing.Size(88, 17);
            this.chkFiltrarAtivos.TabIndex = 0;
            this.chkFiltrarAtivos.Text = "Filtrar ativos?";
            this.chkFiltrarAtivos.UseVisualStyleBackColor = true;
            this.chkFiltrarAtivos.CheckedChanged += new System.EventHandler(this.chkFiltrarAtivos_CheckedChanged);
            // 
            // chkAtivo
            // 
            this.chkAtivo.AutoSize = true;
            this.chkAtivo.Enabled = false;
            this.chkAtivo.Location = new System.Drawing.Point(121, 33);
            this.chkAtivo.Name = "chkAtivo";
            this.chkAtivo.Size = new System.Drawing.Size(56, 17);
            this.chkAtivo.TabIndex = 1;
            this.chkAtivo.Text = "Ativo?";
            this.chkAtivo.UseVisualStyleBackColor = true;
            // 
            // chkFiltrarCasal
            // 
            this.chkFiltrarCasal.AutoSize = true;
            this.chkFiltrarCasal.Location = new System.Drawing.Point(21, 74);
            this.chkFiltrarCasal.Name = "chkFiltrarCasal";
            this.chkFiltrarCasal.Size = new System.Drawing.Size(85, 17);
            this.chkFiltrarCasal.TabIndex = 2;
            this.chkFiltrarCasal.Text = "Filtrar casal?";
            this.chkFiltrarCasal.UseVisualStyleBackColor = true;
            this.chkFiltrarCasal.CheckedChanged += new System.EventHandler(this.chkFiltrarCasal_CheckedChanged);
            // 
            // cbCasal
            // 
            this.cbCasal.Enabled = false;
            this.cbCasal.FormattingEnabled = true;
            this.cbCasal.Location = new System.Drawing.Point(121, 70);
            this.cbCasal.Name = "cbCasal";
            this.cbCasal.Size = new System.Drawing.Size(314, 21);
            this.cbCasal.TabIndex = 3;
            // 
            // confBtn
            // 
            this.confBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.confBtn.Location = new System.Drawing.Point(41, 7);
            this.confBtn.Name = "confBtn";
            this.confBtn.Size = new System.Drawing.Size(75, 23);
            this.confBtn.TabIndex = 4;
            this.confBtn.Text = "Confirmar";
            this.confBtn.UseVisualStyleBackColor = true;
            this.confBtn.Click += new System.EventHandler(this.confBtn_Click);
            // 
            // cancBtn
            // 
            this.cancBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancBtn.Location = new System.Drawing.Point(192, 7);
            this.cancBtn.Name = "cancBtn";
            this.cancBtn.Size = new System.Drawing.Size(75, 23);
            this.cancBtn.TabIndex = 5;
            this.cancBtn.Text = "Cancelar";
            this.cancBtn.UseVisualStyleBackColor = true;
            this.cancBtn.Click += new System.EventHandler(this.cancBtn_Click);
            // 
            // limparBtn
            // 
            this.limparBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.limparBtn.Location = new System.Drawing.Point(343, 7);
            this.limparBtn.Name = "limparBtn";
            this.limparBtn.Size = new System.Drawing.Size(75, 23);
            this.limparBtn.TabIndex = 6;
            this.limparBtn.Text = "Limpar";
            this.limparBtn.UseVisualStyleBackColor = true;
            this.limparBtn.Click += new System.EventHandler(this.limparBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cancBtn);
            this.panel1.Controls.Add(this.limparBtn);
            this.panel1.Controls.Add(this.confBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 126);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 39);
            this.panel1.TabIndex = 7;
            // 
            // FiltroPosturaDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancBtn;
            this.ClientSize = new System.Drawing.Size(457, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbCasal);
            this.Controls.Add(this.chkFiltrarCasal);
            this.Controls.Add(this.chkAtivo);
            this.Controls.Add(this.chkFiltrarAtivos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FiltroPosturaDlg";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Registros Posturas";
            this.Load += new System.EventHandler(this.FiltroPosturaDlg_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkFiltrarAtivos;
        private System.Windows.Forms.CheckBox chkAtivo;
        private System.Windows.Forms.CheckBox chkFiltrarCasal;
        private System.Windows.Forms.ComboBox cbCasal;
        private System.Windows.Forms.Button confBtn;
        private System.Windows.Forms.Button cancBtn;
        private System.Windows.Forms.Button limparBtn;
        private System.Windows.Forms.Panel panel1;
    }
}
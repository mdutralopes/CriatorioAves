
namespace CriatorioAves
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tabelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modelosDeGaiolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gaiolasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.avesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.casaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criadoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.posturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.janelasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tabelasToolStripMenuItem,
            this.cadastroToolStripMenuItem,
            this.movimentoToolStripMenuItem,
            this.janelasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MdiWindowListItem = this.janelasToolStripMenuItem;
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tabelasToolStripMenuItem
            // 
            this.tabelasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.especiesToolStripMenuItem,
            this.modelosDeGaiolasToolStripMenuItem,
            this.gaiolasToolStripMenuItem});
            this.tabelasToolStripMenuItem.Name = "tabelasToolStripMenuItem";
            this.tabelasToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.tabelasToolStripMenuItem.Text = "Tabelas";
            // 
            // especiesToolStripMenuItem
            // 
            this.especiesToolStripMenuItem.Name = "especiesToolStripMenuItem";
            this.especiesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.especiesToolStripMenuItem.Text = "Espécies";
            this.especiesToolStripMenuItem.Click += new System.EventHandler(this.especiesToolStripMenuItem_Click);
            // 
            // modelosDeGaiolasToolStripMenuItem
            // 
            this.modelosDeGaiolasToolStripMenuItem.Name = "modelosDeGaiolasToolStripMenuItem";
            this.modelosDeGaiolasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.modelosDeGaiolasToolStripMenuItem.Text = "Modelos de Gaiolas";
            this.modelosDeGaiolasToolStripMenuItem.Click += new System.EventHandler(this.modelosDeGaiolasToolStripMenuItem_Click);
            // 
            // gaiolasToolStripMenuItem
            // 
            this.gaiolasToolStripMenuItem.Name = "gaiolasToolStripMenuItem";
            this.gaiolasToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.gaiolasToolStripMenuItem.Text = "Gaiolas";
            this.gaiolasToolStripMenuItem.Click += new System.EventHandler(this.gaiolasToolStripMenuItem_Click);
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.avesToolStripMenuItem,
            this.casaisToolStripMenuItem,
            this.criadoresToolStripMenuItem1,
            this.clientesToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // avesToolStripMenuItem
            // 
            this.avesToolStripMenuItem.Name = "avesToolStripMenuItem";
            this.avesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.avesToolStripMenuItem.Text = "Aves";
            this.avesToolStripMenuItem.Click += new System.EventHandler(this.avesToolStripMenuItem_Click);
            // 
            // casaisToolStripMenuItem
            // 
            this.casaisToolStripMenuItem.Name = "casaisToolStripMenuItem";
            this.casaisToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.casaisToolStripMenuItem.Text = "Casais";
            this.casaisToolStripMenuItem.Click += new System.EventHandler(this.casaisToolStripMenuItem_Click);
            // 
            // criadoresToolStripMenuItem1
            // 
            this.criadoresToolStripMenuItem1.Name = "criadoresToolStripMenuItem1";
            this.criadoresToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.criadoresToolStripMenuItem1.Text = "Criadores";
            this.criadoresToolStripMenuItem1.Click += new System.EventHandler(this.criadoresToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // movimentoToolStripMenuItem
            // 
            this.movimentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.posturasToolStripMenuItem1,
            this.reservasToolStripMenuItem,
            this.vendasToolStripMenuItem});
            this.movimentoToolStripMenuItem.Name = "movimentoToolStripMenuItem";
            this.movimentoToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.movimentoToolStripMenuItem.Text = "Movimento";
            // 
            // posturasToolStripMenuItem1
            // 
            this.posturasToolStripMenuItem1.Name = "posturasToolStripMenuItem1";
            this.posturasToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.posturasToolStripMenuItem1.Text = "Posturas";
            this.posturasToolStripMenuItem1.Click += new System.EventHandler(this.posturasToolStripMenuItem1_Click);
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            this.reservasToolStripMenuItem.Click += new System.EventHandler(this.reservasToolStripMenuItem_Click);
            // 
            // vendasToolStripMenuItem
            // 
            this.vendasToolStripMenuItem.Name = "vendasToolStripMenuItem";
            this.vendasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vendasToolStripMenuItem.Text = "Vendas";
            // 
            // janelasToolStripMenuItem
            // 
            this.janelasToolStripMenuItem.Name = "janelasToolStripMenuItem";
            this.janelasToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.janelasToolStripMenuItem.Text = "Janelas";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(706, 314);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Criação de Aves";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tabelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gaiolasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem avesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criadoresToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem movimentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem posturasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem casaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem janelasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modelosDeGaiolasToolStripMenuItem;
    }
}



namespace CriatorioAves
{
    partial class CriadoresForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CriadoresForm));
            this.bnCriador = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCriador = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.delButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.canButton = new System.Windows.Forms.Button();
            this.incButton = new System.Windows.Forms.Button();
            this.altButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.criadorPage = new System.Windows.Forms.TabPage();
            this.txtTelefone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.avesPage = new System.Windows.Forms.TabPage();
            this.dgvAvesCriador = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnCriador)).BeginInit();
            this.bnCriador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCriador)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.criadorPage.SuspendLayout();
            this.avesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvesCriador)).BeginInit();
            this.SuspendLayout();
            // 
            // bnCriador
            // 
            this.bnCriador.AddNewItem = null;
            this.bnCriador.BindingSource = this.bsCriador;
            this.bnCriador.CountItem = this.bindingNavigatorCountItem;
            this.bnCriador.DeleteItem = null;
            this.bnCriador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnCriador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnCriador.Location = new System.Drawing.Point(0, 214);
            this.bnCriador.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCriador.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCriador.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCriador.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCriador.Name = "bnCriador";
            this.bnCriador.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCriador.Size = new System.Drawing.Size(601, 25);
            this.bnCriador.TabIndex = 0;
            this.bnCriador.Text = "bindingNavigator1";
            // 
            // bsCriador
            // 
            this.bsCriador.CurrentItemChanged += new System.EventHandler(this.bsCriador_CurrentItemChanged);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(472, 216);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 19;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Excluir registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(513, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 17;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirmar operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(554, 216);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 18;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancelar operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(431, 216);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 16;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Incluir novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(390, 216);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 15;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Alterar registro");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.criadorPage);
            this.tabControl1.Controls.Add(this.avesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(601, 214);
            this.tabControl1.TabIndex = 20;
            // 
            // criadorPage
            // 
            this.criadorPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.criadorPage.Controls.Add(this.txtTelefone);
            this.criadorPage.Controls.Add(this.txtEmail);
            this.criadorPage.Controls.Add(this.txtRegistro);
            this.criadorPage.Controls.Add(this.txtNome);
            this.criadorPage.Controls.Add(this.txtId);
            this.criadorPage.Controls.Add(this.label5);
            this.criadorPage.Controls.Add(this.label4);
            this.criadorPage.Controls.Add(this.label3);
            this.criadorPage.Controls.Add(this.label2);
            this.criadorPage.Controls.Add(this.label1);
            this.criadorPage.Location = new System.Drawing.Point(4, 22);
            this.criadorPage.Name = "criadorPage";
            this.criadorPage.Padding = new System.Windows.Forms.Padding(3);
            this.criadorPage.Size = new System.Drawing.Size(593, 188);
            this.criadorPage.TabIndex = 0;
            this.criadorPage.Text = "Criador";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Enabled = false;
            this.txtTelefone.Location = new System.Drawing.Point(257, 152);
            this.txtTelefone.MaxLength = 45;
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(100, 20);
            this.txtTelefone.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(257, 118);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(175, 20);
            this.txtEmail.TabIndex = 38;
            // 
            // txtRegistro
            // 
            this.txtRegistro.Enabled = false;
            this.txtRegistro.Location = new System.Drawing.Point(257, 84);
            this.txtRegistro.MaxLength = 45;
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(175, 20);
            this.txtRegistro.TabIndex = 37;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(257, 50);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(175, 20);
            this.txtNome.TabIndex = 36;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(257, 16);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(45, 20);
            this.txtId.TabIndex = 35;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Telefone*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(161, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "E-mail*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Registro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nome*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(161, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Id";
            // 
            // avesPage
            // 
            this.avesPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.avesPage.Controls.Add(this.dgvAvesCriador);
            this.avesPage.Location = new System.Drawing.Point(4, 22);
            this.avesPage.Name = "avesPage";
            this.avesPage.Padding = new System.Windows.Forms.Padding(3);
            this.avesPage.Size = new System.Drawing.Size(593, 188);
            this.avesPage.TabIndex = 1;
            this.avesPage.Text = "Aves";
            // 
            // dgvAvesCriador
            // 
            this.dgvAvesCriador.AllowUserToAddRows = false;
            this.dgvAvesCriador.AllowUserToDeleteRows = false;
            this.dgvAvesCriador.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvesCriador.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvesCriador.Location = new System.Drawing.Point(3, 3);
            this.dgvAvesCriador.Name = "dgvAvesCriador";
            this.dgvAvesCriador.ReadOnly = true;
            this.dgvAvesCriador.Size = new System.Drawing.Size(587, 182);
            this.dgvAvesCriador.TabIndex = 0;
            // 
            // CriadoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(601, 239);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.bnCriador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CriadoresForm";
            this.Text = "Cadastro de Criadores";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CriadoresForm_FormClosed);
            this.Load += new System.EventHandler(this.CriadoresForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnCriador)).EndInit();
            this.bnCriador.ResumeLayout(false);
            this.bnCriador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCriador)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.criadorPage.ResumeLayout(false);
            this.criadorPage.PerformLayout();
            this.avesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvesCriador)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnCriador;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bsCriador;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button altButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage criadorPage;
        private System.Windows.Forms.TextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage avesPage;
        private System.Windows.Forms.DataGridView dgvAvesCriador;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
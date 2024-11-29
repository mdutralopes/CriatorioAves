
namespace CriatorioAves
{
    partial class GaiolasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GaiolasForm));
            this.bnGaiola = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsGaiola = new System.Windows.Forms.BindingSource(this.components);
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
            this.gaiolaPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLargura = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblComp = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbModeloGaiola = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdGaiola = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumGaiola = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.avesPage = new System.Windows.Forms.TabPage();
            this.dgvAves = new System.Windows.Forms.DataGridView();
            this.schButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnGaiola)).BeginInit();
            this.bnGaiola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGaiola)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.gaiolaPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.avesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAves)).BeginInit();
            this.SuspendLayout();
            // 
            // bnGaiola
            // 
            this.bnGaiola.AddNewItem = null;
            this.bnGaiola.BindingSource = this.bsGaiola;
            this.bnGaiola.CountItem = this.bindingNavigatorCountItem;
            this.bnGaiola.DeleteItem = null;
            this.bnGaiola.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnGaiola.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnGaiola.Location = new System.Drawing.Point(0, 237);
            this.bnGaiola.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnGaiola.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnGaiola.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnGaiola.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnGaiola.Name = "bnGaiola";
            this.bnGaiola.PositionItem = this.bindingNavigatorPositionItem;
            this.bnGaiola.Size = new System.Drawing.Size(473, 25);
            this.bnGaiola.TabIndex = 2;
            this.bnGaiola.Text = "bindingNavigator1";
            // 
            // bsGaiola
            // 
            this.bsGaiola.CurrentItemChanged += new System.EventHandler(this.bsGaiola_CurrentItemChanged);
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
            this.delButton.Location = new System.Drawing.Point(298, 239);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 24;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Excluir o registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(340, 239);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 22;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirmar operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(382, 239);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 23;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancelar operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(256, 239);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 21;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Incluir novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(214, 239);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 20;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Alterar registro atual");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.gaiolaPage);
            this.tabControl1.Controls.Add(this.avesPage);
            this.tabControl1.Location = new System.Drawing.Point(0, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 231);
            this.tabControl1.TabIndex = 25;
            // 
            // gaiolaPage
            // 
            this.gaiolaPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.gaiolaPage.Controls.Add(this.groupBox1);
            this.gaiolaPage.Controls.Add(this.cbModeloGaiola);
            this.gaiolaPage.Controls.Add(this.label2);
            this.gaiolaPage.Controls.Add(this.txtIdGaiola);
            this.gaiolaPage.Controls.Add(this.label4);
            this.gaiolaPage.Controls.Add(this.txtNumGaiola);
            this.gaiolaPage.Controls.Add(this.label1);
            this.gaiolaPage.Location = new System.Drawing.Point(4, 22);
            this.gaiolaPage.Name = "gaiolaPage";
            this.gaiolaPage.Padding = new System.Windows.Forms.Padding(3);
            this.gaiolaPage.Size = new System.Drawing.Size(465, 205);
            this.gaiolaPage.TabIndex = 0;
            this.gaiolaPage.Text = "Gaiolas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLargura);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblAltura);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(96, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 90);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Especificações";
            // 
            // lblLargura
            // 
            this.lblLargura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLargura.Location = new System.Drawing.Point(135, 64);
            this.lblLargura.Name = "lblLargura";
            this.lblLargura.Size = new System.Drawing.Size(79, 15);
            this.lblLargura.TabIndex = 11;
            this.lblLargura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(59, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Largura";
            // 
            // lblAltura
            // 
            this.lblAltura.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAltura.Location = new System.Drawing.Point(135, 15);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(79, 15);
            this.lblAltura.TabIndex = 9;
            this.lblAltura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Altura";
            // 
            // lblComp
            // 
            this.lblComp.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComp.Location = new System.Drawing.Point(135, 40);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(79, 15);
            this.lblComp.TabIndex = 7;
            this.lblComp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Comprimento";
            // 
            // cbModeloGaiola
            // 
            this.cbModeloGaiola.Enabled = false;
            this.cbModeloGaiola.FormattingEnabled = true;
            this.cbModeloGaiola.Location = new System.Drawing.Point(186, 73);
            this.cbModeloGaiola.Name = "cbModeloGaiola";
            this.cbModeloGaiola.Size = new System.Drawing.Size(186, 21);
            this.cbModeloGaiola.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Modelo Gaiola*";
            // 
            // txtIdGaiola
            // 
            this.txtIdGaiola.Enabled = false;
            this.txtIdGaiola.Location = new System.Drawing.Point(186, 9);
            this.txtIdGaiola.Name = "txtIdGaiola";
            this.txtIdGaiola.Size = new System.Drawing.Size(59, 20);
            this.txtIdGaiola.TabIndex = 16;
            this.txtIdGaiola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Id Gaiola";
            // 
            // txtNumGaiola
            // 
            this.txtNumGaiola.Enabled = false;
            this.txtNumGaiola.Location = new System.Drawing.Point(186, 40);
            this.txtNumGaiola.Name = "txtNumGaiola";
            this.txtNumGaiola.Size = new System.Drawing.Size(59, 20);
            this.txtNumGaiola.TabIndex = 11;
            this.txtNumGaiola.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Número Gaiola*";
            // 
            // avesPage
            // 
            this.avesPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.avesPage.Controls.Add(this.dgvAves);
            this.avesPage.Location = new System.Drawing.Point(4, 22);
            this.avesPage.Name = "avesPage";
            this.avesPage.Padding = new System.Windows.Forms.Padding(3);
            this.avesPage.Size = new System.Drawing.Size(465, 205);
            this.avesPage.TabIndex = 1;
            this.avesPage.Text = "Aves";
            // 
            // dgvAves
            // 
            this.dgvAves.AllowUserToAddRows = false;
            this.dgvAves.AllowUserToDeleteRows = false;
            this.dgvAves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAves.Location = new System.Drawing.Point(3, 3);
            this.dgvAves.Name = "dgvAves";
            this.dgvAves.ReadOnly = true;
            this.dgvAves.Size = new System.Drawing.Size(459, 199);
            this.dgvAves.TabIndex = 0;
            // 
            // schButton
            // 
            this.schButton.Location = new System.Drawing.Point(424, 239);
            this.schButton.Name = "schButton";
            this.schButton.Size = new System.Drawing.Size(35, 23);
            this.schButton.TabIndex = 20;
            this.schButton.Text = "Sch";
            this.toolTip1.SetToolTip(this.schButton, "Procurar um registro");
            this.schButton.UseVisualStyleBackColor = true;
            this.schButton.Click += new System.EventHandler(this.schButton_Click);
            // 
            // GaiolasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(473, 262);
            this.Controls.Add(this.schButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.bnGaiola);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GaiolasForm";
            this.Text = "Cadastro de Gaiolas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GaiolasForm_FormClosed);
            this.Load += new System.EventHandler(this.GaiolasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnGaiola)).EndInit();
            this.bnGaiola.ResumeLayout(false);
            this.bnGaiola.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsGaiola)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.gaiolaPage.ResumeLayout(false);
            this.gaiolaPage.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.avesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bnGaiola;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bsGaiola;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button altButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage gaiolaPage;
        private System.Windows.Forms.TextBox txtIdGaiola;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumGaiola;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage avesPage;
        private System.Windows.Forms.DataGridView dgvAves;
        private System.Windows.Forms.ComboBox cbModeloGaiola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLargura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button schButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
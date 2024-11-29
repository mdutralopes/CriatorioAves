
namespace CriatorioAves
{
    partial class EspeciesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EspeciesForm));
            this.bnNavegador = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsEspecie = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNomeCientifico = new System.Windows.Forms.TextBox();
            this.altButton = new System.Windows.Forms.Button();
            this.incButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.canButton = new System.Windows.Forms.Button();
            this.delButton = new System.Windows.Forms.Button();
            this.schButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnNavegador)).BeginInit();
            this.bnNavegador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEspecie)).BeginInit();
            this.SuspendLayout();
            // 
            // bnNavegador
            // 
            this.bnNavegador.AddNewItem = null;
            this.bnNavegador.BindingSource = this.bsEspecie;
            this.bnNavegador.CountItem = this.bindingNavigatorCountItem;
            this.bnNavegador.DeleteItem = null;
            this.bnNavegador.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnNavegador.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnNavegador.Location = new System.Drawing.Point(0, 165);
            this.bnNavegador.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnNavegador.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnNavegador.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnNavegador.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnNavegador.Name = "bnNavegador";
            this.bnNavegador.PositionItem = this.bindingNavigatorPositionItem;
            this.bnNavegador.Size = new System.Drawing.Size(481, 25);
            this.bnNavegador.TabIndex = 2;
            this.bnNavegador.Text = "bnNavegador";
            // 
            // bsEspecie
            // 
            this.bsEspecie.CurrentChanged += new System.EventHandler(this.bsEspecie_CurrentChanged);
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
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(182, 78);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(171, 20);
            this.txtNome.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nome Espécie*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nome Científico*";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(182, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(65, 20);
            this.txtId.TabIndex = 8;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtNomeCientifico
            // 
            this.txtNomeCientifico.Enabled = false;
            this.txtNomeCientifico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeCientifico.Location = new System.Drawing.Point(182, 117);
            this.txtNomeCientifico.MaxLength = 100;
            this.txtNomeCientifico.Name = "txtNomeCientifico";
            this.txtNomeCientifico.Size = new System.Drawing.Size(171, 20);
            this.txtNomeCientifico.TabIndex = 9;
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(230, 167);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 10;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Alterar registro atual");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(271, 167);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 11;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Incluir novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(353, 167);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 12;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirmar operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(394, 167);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 13;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancelar operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(312, 167);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 14;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Excluir registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // schButton
            // 
            this.schButton.Location = new System.Drawing.Point(435, 167);
            this.schButton.Name = "schButton";
            this.schButton.Size = new System.Drawing.Size(35, 23);
            this.schButton.TabIndex = 15;
            this.schButton.Text = "Sch";
            this.toolTip1.SetToolTip(this.schButton, "Procurar registro");
            this.schButton.UseVisualStyleBackColor = true;
            this.schButton.Click += new System.EventHandler(this.schButton_Click);
            // 
            // EspeciesForm
            // 
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(481, 190);
            this.Controls.Add(this.schButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.txtNomeCientifico);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.bnNavegador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EspeciesForm";
            this.Text = "Cadastro de Espécies";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EspeciesForm_FormClosed);
            this.Load += new System.EventHandler(this.EspeciesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnNavegador)).EndInit();
            this.bnNavegador.ResumeLayout(false);
            this.bnNavegador.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsEspecie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingNavigator bnNavegador;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.BindingSource bsEspecie;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNomeCientifico;
        private System.Windows.Forms.Button altButton;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button schButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
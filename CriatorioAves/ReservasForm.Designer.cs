
namespace CriatorioAves
{
    partial class ReservasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservasForm));
            this.bnReservas = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsReservas = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvAvesReserva = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.editAvesBtn = new System.Windows.Forms.Button();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpDataReserva = new System.Windows.Forms.DateTimePicker();
            this.cbCliente = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdReserva = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.delButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.canButton = new System.Windows.Forms.Button();
            this.incButton = new System.Windows.Forms.Button();
            this.altButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bnReservas)).BeginInit();
            this.bnReservas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvesReserva)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnReservas
            // 
            this.bnReservas.AddNewItem = null;
            this.bnReservas.BindingSource = this.bsReservas;
            this.bnReservas.CountItem = this.bindingNavigatorCountItem;
            this.bnReservas.DeleteItem = null;
            this.bnReservas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnReservas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnReservas.Location = new System.Drawing.Point(0, 337);
            this.bnReservas.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnReservas.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnReservas.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnReservas.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnReservas.Name = "bnReservas";
            this.bnReservas.PositionItem = this.bindingNavigatorPositionItem;
            this.bnReservas.Size = new System.Drawing.Size(535, 25);
            this.bnReservas.TabIndex = 0;
            this.bnReservas.Text = "bindingNavigator1";
            // 
            // bsReservas
            // 
            this.bsReservas.CurrentItemChanged += new System.EventHandler(this.bsReservas_CurrentItemChanged);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 337);
            this.panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvAvesReserva);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(535, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aves Reservadas";
            // 
            // dgvAvesReserva
            // 
            this.dgvAvesReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvesReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAvesReserva.Location = new System.Drawing.Point(3, 16);
            this.dgvAvesReserva.Name = "dgvAvesReserva";
            this.dgvAvesReserva.Size = new System.Drawing.Size(529, 159);
            this.dgvAvesReserva.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.editAvesBtn);
            this.panel2.Controls.Add(this.mskValor);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpDataReserva);
            this.panel2.Controls.Add(this.cbCliente);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtIdReserva);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 159);
            this.panel2.TabIndex = 0;
            // 
            // editAvesBtn
            // 
            this.editAvesBtn.Enabled = false;
            this.editAvesBtn.Location = new System.Drawing.Point(378, 118);
            this.editAvesBtn.Name = "editAvesBtn";
            this.editAvesBtn.Size = new System.Drawing.Size(115, 23);
            this.editAvesBtn.TabIndex = 54;
            this.editAvesBtn.Text = "Editar aves reserva";
            this.toolTip1.SetToolTip(this.editAvesBtn, "Incluir/excluir aves reservadas");
            this.editAvesBtn.UseVisualStyleBackColor = true;
            this.editAvesBtn.Click += new System.EventHandler(this.editAvesBtn_Click);
            // 
            // mskValor
            // 
            this.mskValor.Enabled = false;
            this.mskValor.Location = new System.Drawing.Point(183, 118);
            this.mskValor.Name = "mskValor";
            this.mskValor.PromptChar = ' ';
            this.mskValor.Size = new System.Drawing.Size(100, 20);
            this.mskValor.TabIndex = 53;
            this.mskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 122);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Valor*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Data Reserva*";
            // 
            // dtpDataReserva
            // 
            this.dtpDataReserva.Enabled = false;
            this.dtpDataReserva.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataReserva.Location = new System.Drawing.Point(183, 84);
            this.dtpDataReserva.Name = "dtpDataReserva";
            this.dtpDataReserva.Size = new System.Drawing.Size(129, 20);
            this.dtpDataReserva.TabIndex = 49;
            // 
            // cbCliente
            // 
            this.cbCliente.Enabled = false;
            this.cbCliente.FormattingEnabled = true;
            this.cbCliente.Location = new System.Drawing.Point(183, 50);
            this.cbCliente.Name = "cbCliente";
            this.cbCliente.Size = new System.Drawing.Size(187, 21);
            this.cbCliente.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 47;
            this.label2.Text = "Cliente*";
            // 
            // txtIdReserva
            // 
            this.txtIdReserva.Enabled = false;
            this.txtIdReserva.Location = new System.Drawing.Point(183, 16);
            this.txtIdReserva.Name = "txtIdReserva";
            this.txtIdReserva.Size = new System.Drawing.Size(65, 20);
            this.txtIdReserva.TabIndex = 46;
            this.txtIdReserva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Id Reserva";
            // 
            // delButton
            // 
            this.delButton.Location = new System.Drawing.Point(400, 339);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 43;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Excluir registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(442, 339);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 41;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirmar a operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(484, 339);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 42;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancelar a operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(358, 339);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 40;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Incluir novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(316, 339);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 39;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Alterar registro atual");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // ReservasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(535, 362);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bnReservas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservasForm";
            this.Text = "Reservas de Aves";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReservasForm_FormClosed);
            this.Load += new System.EventHandler(this.ReservasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bnReservas)).EndInit();
            this.bnReservas.ResumeLayout(false);
            this.bnReservas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsReservas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvesReserva)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingNavigator bnReservas;
        private System.Windows.Forms.BindingSource bsReservas;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button altButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvAvesReserva;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtIdReserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDataReserva;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button editAvesBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
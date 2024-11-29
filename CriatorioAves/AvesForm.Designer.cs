
namespace CriatorioAves
{
    partial class AvesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AvesForm));
            this.bsAve = new System.Windows.Forms.BindingSource(this.components);
            this.bnAve = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.avesPage = new System.Windows.Forms.TabPage();
            this.lblAcasalado = new System.Windows.Forms.Label();
            this.rbnDesconhecido = new System.Windows.Forms.RadioButton();
            this.rbnFemea = new System.Windows.Forms.RadioButton();
            this.rbnMacho = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.mskValor = new System.Windows.Forms.MaskedTextBox();
            this.txtObs = new System.Windows.Forms.TextBox();
            this.cbMae = new System.Windows.Forms.ComboBox();
            this.cbPai = new System.Windows.Forms.ComboBox();
            this.cbGaiola = new System.Windows.Forms.ComboBox();
            this.dtpDataCompra = new System.Windows.Forms.DateTimePicker();
            this.cbCriador = new System.Windows.Forms.ComboBox();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.dtpNascimento = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCorMutacao = new System.Windows.Forms.TextBox();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.txtIdentAve = new System.Windows.Forms.TextBox();
            this.txtIdAve = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.filhotesPage = new System.Windows.Forms.TabPage();
            this.dgvFilhotes = new System.Windows.Forms.DataGridView();
            this.pedigreePage = new System.Windows.Forms.TabPage();
            this.txtMae_7 = new System.Windows.Forms.Label();
            this.txtPai_7 = new System.Windows.Forms.Label();
            this.txtMae_6 = new System.Windows.Forms.Label();
            this.txtPai_6 = new System.Windows.Forms.Label();
            this.txtMae_5 = new System.Windows.Forms.Label();
            this.txtPai_5 = new System.Windows.Forms.Label();
            this.txtMae_4 = new System.Windows.Forms.Label();
            this.txtPai_4 = new System.Windows.Forms.Label();
            this.txtMae_3 = new System.Windows.Forms.Label();
            this.txtPai_3 = new System.Windows.Forms.Label();
            this.txtMae_2 = new System.Windows.Forms.Label();
            this.txtPai_2 = new System.Windows.Forms.Label();
            this.txtMae_1 = new System.Windows.Forms.Label();
            this.txtPai_1 = new System.Windows.Forms.Label();
            this.txtAve = new System.Windows.Forms.Label();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsAve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAve)).BeginInit();
            this.bnAve.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.avesPage.SuspendLayout();
            this.filhotesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhotes)).BeginInit();
            this.pedigreePage.SuspendLayout();
            this.SuspendLayout();
            // 
            // bsAve
            // 
            this.bsAve.CurrentItemChanged += new System.EventHandler(this.bsAve_CurrentItemChanged);
            // 
            // bnAve
            // 
            this.bnAve.AddNewItem = null;
            this.bnAve.BindingSource = this.bsAve;
            this.bnAve.CountItem = this.bindingNavigatorCountItem;
            this.bnAve.DeleteItem = null;
            this.bnAve.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnAve.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnAve.Location = new System.Drawing.Point(0, 454);
            this.bnAve.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnAve.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnAve.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnAve.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnAve.Name = "bnAve";
            this.bnAve.PositionItem = this.bindingNavigatorPositionItem;
            this.bnAve.Size = new System.Drawing.Size(620, 25);
            this.bnAve.TabIndex = 28;
            this.bnAve.Text = "bindingNavigator1";
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
            this.delButton.Location = new System.Drawing.Point(440, 454);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 33;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Excui o registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(484, 454);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 31;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirma a operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(528, 454);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 32;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancela a operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(396, 454);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 30;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Inclui novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(352, 454);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 29;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Altera o registro");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.avesPage);
            this.tabControl1.Controls.Add(this.filhotesPage);
            this.tabControl1.Controls.Add(this.pedigreePage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(620, 448);
            this.tabControl1.TabIndex = 34;
            // 
            // avesPage
            // 
            this.avesPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.avesPage.Controls.Add(this.lblAcasalado);
            this.avesPage.Controls.Add(this.rbnDesconhecido);
            this.avesPage.Controls.Add(this.rbnFemea);
            this.avesPage.Controls.Add(this.rbnMacho);
            this.avesPage.Controls.Add(this.label15);
            this.avesPage.Controls.Add(this.mskValor);
            this.avesPage.Controls.Add(this.txtObs);
            this.avesPage.Controls.Add(this.cbMae);
            this.avesPage.Controls.Add(this.cbPai);
            this.avesPage.Controls.Add(this.cbGaiola);
            this.avesPage.Controls.Add(this.dtpDataCompra);
            this.avesPage.Controls.Add(this.cbCriador);
            this.avesPage.Controls.Add(this.cbStatus);
            this.avesPage.Controls.Add(this.dtpNascimento);
            this.avesPage.Controls.Add(this.txtNome);
            this.avesPage.Controls.Add(this.txtCorMutacao);
            this.avesPage.Controls.Add(this.cbEspecie);
            this.avesPage.Controls.Add(this.txtIdentAve);
            this.avesPage.Controls.Add(this.txtIdAve);
            this.avesPage.Controls.Add(this.label14);
            this.avesPage.Controls.Add(this.label13);
            this.avesPage.Controls.Add(this.label12);
            this.avesPage.Controls.Add(this.label11);
            this.avesPage.Controls.Add(this.label10);
            this.avesPage.Controls.Add(this.label9);
            this.avesPage.Controls.Add(this.label8);
            this.avesPage.Controls.Add(this.label7);
            this.avesPage.Controls.Add(this.label6);
            this.avesPage.Controls.Add(this.label5);
            this.avesPage.Controls.Add(this.label4);
            this.avesPage.Controls.Add(this.label3);
            this.avesPage.Controls.Add(this.label2);
            this.avesPage.Controls.Add(this.label1);
            this.avesPage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.avesPage.Location = new System.Drawing.Point(4, 22);
            this.avesPage.Name = "avesPage";
            this.avesPage.Padding = new System.Windows.Forms.Padding(3);
            this.avesPage.Size = new System.Drawing.Size(612, 422);
            this.avesPage.TabIndex = 0;
            this.avesPage.Text = "Dados de Aves";
            // 
            // lblAcasalado
            // 
            this.lblAcasalado.AutoSize = true;
            this.lblAcasalado.ForeColor = System.Drawing.Color.Blue;
            this.lblAcasalado.Location = new System.Drawing.Point(317, 34);
            this.lblAcasalado.Name = "lblAcasalado";
            this.lblAcasalado.Size = new System.Drawing.Size(0, 13);
            this.lblAcasalado.TabIndex = 58;
            // 
            // rbnDesconhecido
            // 
            this.rbnDesconhecido.AutoSize = true;
            this.rbnDesconhecido.Enabled = false;
            this.rbnDesconhecido.Location = new System.Drawing.Point(334, 58);
            this.rbnDesconhecido.Name = "rbnDesconhecido";
            this.rbnDesconhecido.Size = new System.Drawing.Size(94, 17);
            this.rbnDesconhecido.TabIndex = 57;
            this.rbnDesconhecido.TabStop = true;
            this.rbnDesconhecido.Text = "&Desconhecido";
            this.rbnDesconhecido.UseVisualStyleBackColor = true;
            // 
            // rbnFemea
            // 
            this.rbnFemea.AutoSize = true;
            this.rbnFemea.Enabled = false;
            this.rbnFemea.Location = new System.Drawing.Point(259, 58);
            this.rbnFemea.Name = "rbnFemea";
            this.rbnFemea.Size = new System.Drawing.Size(57, 17);
            this.rbnFemea.TabIndex = 45;
            this.rbnFemea.TabStop = true;
            this.rbnFemea.Text = "&Fêmea";
            this.rbnFemea.UseVisualStyleBackColor = true;
            // 
            // rbnMacho
            // 
            this.rbnMacho.AutoSize = true;
            this.rbnMacho.Enabled = false;
            this.rbnMacho.Location = new System.Drawing.Point(183, 58);
            this.rbnMacho.Name = "rbnMacho";
            this.rbnMacho.Size = new System.Drawing.Size(58, 17);
            this.rbnMacho.TabIndex = 44;
            this.rbnMacho.TabStop = true;
            this.rbnMacho.Text = "&Macho";
            this.rbnMacho.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(89, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "Sexo*";
            // 
            // mskValor
            // 
            this.mskValor.Enabled = false;
            this.mskValor.Location = new System.Drawing.Point(183, 264);
            this.mskValor.Name = "mskValor";
            this.mskValor.PromptChar = ' ';
            this.mskValor.Size = new System.Drawing.Size(100, 20);
            this.mskValor.TabIndex = 51;
            this.mskValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.mskValor.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtObs
            // 
            this.txtObs.Enabled = false;
            this.txtObs.Location = new System.Drawing.Point(183, 372);
            this.txtObs.Multiline = true;
            this.txtObs.Name = "txtObs";
            this.txtObs.Size = new System.Drawing.Size(340, 46);
            this.txtObs.TabIndex = 55;
            // 
            // cbMae
            // 
            this.cbMae.Enabled = false;
            this.cbMae.FormattingEnabled = true;
            this.cbMae.Location = new System.Drawing.Point(183, 342);
            this.cbMae.Name = "cbMae";
            this.cbMae.Size = new System.Drawing.Size(255, 21);
            this.cbMae.TabIndex = 54;
            // 
            // cbPai
            // 
            this.cbPai.Enabled = false;
            this.cbPai.FormattingEnabled = true;
            this.cbPai.Location = new System.Drawing.Point(183, 316);
            this.cbPai.Name = "cbPai";
            this.cbPai.Size = new System.Drawing.Size(255, 21);
            this.cbPai.TabIndex = 53;
            // 
            // cbGaiola
            // 
            this.cbGaiola.Enabled = false;
            this.cbGaiola.FormattingEnabled = true;
            this.cbGaiola.Location = new System.Drawing.Point(183, 290);
            this.cbGaiola.Name = "cbGaiola";
            this.cbGaiola.Size = new System.Drawing.Size(128, 21);
            this.cbGaiola.TabIndex = 52;
            // 
            // dtpDataCompra
            // 
            this.dtpDataCompra.Enabled = false;
            this.dtpDataCompra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCompra.Location = new System.Drawing.Point(183, 238);
            this.dtpDataCompra.Name = "dtpDataCompra";
            this.dtpDataCompra.Size = new System.Drawing.Size(128, 20);
            this.dtpDataCompra.TabIndex = 50;
            // 
            // cbCriador
            // 
            this.cbCriador.Enabled = false;
            this.cbCriador.FormattingEnabled = true;
            this.cbCriador.Location = new System.Drawing.Point(183, 212);
            this.cbCriador.Name = "cbCriador";
            this.cbCriador.Size = new System.Drawing.Size(200, 21);
            this.cbCriador.TabIndex = 49;
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
            this.cbStatus.Location = new System.Drawing.Point(183, 186);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 48;
            // 
            // dtpNascimento
            // 
            this.dtpNascimento.Enabled = false;
            this.dtpNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNascimento.Location = new System.Drawing.Point(183, 160);
            this.dtpNascimento.Name = "dtpNascimento";
            this.dtpNascimento.Size = new System.Drawing.Size(128, 20);
            this.dtpNascimento.TabIndex = 47;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Location = new System.Drawing.Point(183, 134);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(128, 20);
            this.txtNome.TabIndex = 46;
            // 
            // txtCorMutacao
            // 
            this.txtCorMutacao.Enabled = false;
            this.txtCorMutacao.Location = new System.Drawing.Point(183, 108);
            this.txtCorMutacao.Name = "txtCorMutacao";
            this.txtCorMutacao.Size = new System.Drawing.Size(179, 20);
            this.txtCorMutacao.TabIndex = 45;
            // 
            // cbEspecie
            // 
            this.cbEspecie.Enabled = false;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(183, 82);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(180, 21);
            this.cbEspecie.TabIndex = 44;
            this.cbEspecie.Leave += new System.EventHandler(this.cbEspecie_Leave);
            // 
            // txtIdentAve
            // 
            this.txtIdentAve.Enabled = false;
            this.txtIdentAve.Location = new System.Drawing.Point(183, 30);
            this.txtIdentAve.Name = "txtIdentAve";
            this.txtIdentAve.Size = new System.Drawing.Size(128, 20);
            this.txtIdentAve.TabIndex = 43;
            // 
            // txtIdAve
            // 
            this.txtIdAve.Enabled = false;
            this.txtIdAve.Location = new System.Drawing.Point(183, 4);
            this.txtIdAve.Name = "txtIdAve";
            this.txtIdAve.Size = new System.Drawing.Size(65, 20);
            this.txtIdAve.TabIndex = 42;
            this.txtIdAve.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(89, 268);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 41;
            this.label14.Text = "Valor*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(89, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "Criador*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(89, 164);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Nascimento*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 86);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 38;
            this.label11.Text = "Espécie*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(89, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Identificação*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(89, 372);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = "Observações";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Mãe";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Pai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Gaiola*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Data Compra*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "Status*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "Nome";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Cor/Mutação*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Id ave";
            // 
            // filhotesPage
            // 
            this.filhotesPage.BackColor = System.Drawing.SystemColors.Control;
            this.filhotesPage.Controls.Add(this.dgvFilhotes);
            this.filhotesPage.Location = new System.Drawing.Point(4, 22);
            this.filhotesPage.Name = "filhotesPage";
            this.filhotesPage.Padding = new System.Windows.Forms.Padding(3);
            this.filhotesPage.Size = new System.Drawing.Size(612, 422);
            this.filhotesPage.TabIndex = 1;
            this.filhotesPage.Text = "Filhotes";
            // 
            // dgvFilhotes
            // 
            this.dgvFilhotes.AllowUserToAddRows = false;
            this.dgvFilhotes.AllowUserToDeleteRows = false;
            this.dgvFilhotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilhotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilhotes.Location = new System.Drawing.Point(3, 3);
            this.dgvFilhotes.Name = "dgvFilhotes";
            this.dgvFilhotes.ReadOnly = true;
            this.dgvFilhotes.Size = new System.Drawing.Size(606, 416);
            this.dgvFilhotes.TabIndex = 0;
            // 
            // pedigreePage
            // 
            this.pedigreePage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pedigreePage.Controls.Add(this.txtMae_7);
            this.pedigreePage.Controls.Add(this.txtPai_7);
            this.pedigreePage.Controls.Add(this.txtMae_6);
            this.pedigreePage.Controls.Add(this.txtPai_6);
            this.pedigreePage.Controls.Add(this.txtMae_5);
            this.pedigreePage.Controls.Add(this.txtPai_5);
            this.pedigreePage.Controls.Add(this.txtMae_4);
            this.pedigreePage.Controls.Add(this.txtPai_4);
            this.pedigreePage.Controls.Add(this.txtMae_3);
            this.pedigreePage.Controls.Add(this.txtPai_3);
            this.pedigreePage.Controls.Add(this.txtMae_2);
            this.pedigreePage.Controls.Add(this.txtPai_2);
            this.pedigreePage.Controls.Add(this.txtMae_1);
            this.pedigreePage.Controls.Add(this.txtPai_1);
            this.pedigreePage.Controls.Add(this.txtAve);
            this.pedigreePage.Location = new System.Drawing.Point(4, 22);
            this.pedigreePage.Name = "pedigreePage";
            this.pedigreePage.Size = new System.Drawing.Size(612, 422);
            this.pedigreePage.TabIndex = 2;
            this.pedigreePage.Text = "Pedigree";
            // 
            // txtMae_7
            // 
            this.txtMae_7.AutoSize = true;
            this.txtMae_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_7.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_7.Location = new System.Drawing.Point(308, 369);
            this.txtMae_7.Name = "txtMae_7";
            this.txtMae_7.Size = new System.Drawing.Size(104, 18);
            this.txtMae_7.TabIndex = 14;
            this.txtMae_7.Text = "Bisavó materna";
            // 
            // txtPai_7
            // 
            this.txtPai_7.AutoSize = true;
            this.txtPai_7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_7.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_7.Location = new System.Drawing.Point(308, 317);
            this.txtPai_7.Name = "txtPai_7";
            this.txtPai_7.Size = new System.Drawing.Size(104, 18);
            this.txtPai_7.TabIndex = 13;
            this.txtPai_7.Text = "Bisavô materno";
            // 
            // txtMae_6
            // 
            this.txtMae_6.AutoSize = true;
            this.txtMae_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_6.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_6.Location = new System.Drawing.Point(308, 269);
            this.txtMae_6.Name = "txtMae_6";
            this.txtMae_6.Size = new System.Drawing.Size(104, 18);
            this.txtMae_6.TabIndex = 12;
            this.txtMae_6.Text = "Bisavó materna";
            // 
            // txtPai_6
            // 
            this.txtPai_6.AutoSize = true;
            this.txtPai_6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_6.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_6.Location = new System.Drawing.Point(308, 221);
            this.txtPai_6.Name = "txtPai_6";
            this.txtPai_6.Size = new System.Drawing.Size(104, 18);
            this.txtPai_6.TabIndex = 11;
            this.txtPai_6.Text = "Bisavô materno";
            // 
            // txtMae_5
            // 
            this.txtMae_5.AutoSize = true;
            this.txtMae_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_5.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_5.Location = new System.Drawing.Point(308, 184);
            this.txtMae_5.Name = "txtMae_5";
            this.txtMae_5.Size = new System.Drawing.Size(101, 18);
            this.txtMae_5.TabIndex = 10;
            this.txtMae_5.Text = "Bisavó paterna";
            // 
            // txtPai_5
            // 
            this.txtPai_5.AutoSize = true;
            this.txtPai_5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_5.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_5.Location = new System.Drawing.Point(308, 133);
            this.txtPai_5.Name = "txtPai_5";
            this.txtPai_5.Size = new System.Drawing.Size(101, 18);
            this.txtPai_5.TabIndex = 9;
            this.txtPai_5.Text = "Bisavô paterno";
            // 
            // txtMae_4
            // 
            this.txtMae_4.AutoSize = true;
            this.txtMae_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_4.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_4.Location = new System.Drawing.Point(308, 89);
            this.txtMae_4.Name = "txtMae_4";
            this.txtMae_4.Size = new System.Drawing.Size(101, 18);
            this.txtMae_4.TabIndex = 8;
            this.txtMae_4.Text = "Bisavó paterna";
            // 
            // txtPai_4
            // 
            this.txtPai_4.AutoSize = true;
            this.txtPai_4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_4.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_4.Location = new System.Drawing.Point(308, 38);
            this.txtPai_4.Name = "txtPai_4";
            this.txtPai_4.Size = new System.Drawing.Size(101, 18);
            this.txtPai_4.TabIndex = 7;
            this.txtPai_4.Text = "Bisavô paterno";
            // 
            // txtMae_3
            // 
            this.txtMae_3.AutoSize = true;
            this.txtMae_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_3.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_3.Location = new System.Drawing.Point(192, 341);
            this.txtMae_3.Name = "txtMae_3";
            this.txtMae_3.Size = new System.Drawing.Size(86, 18);
            this.txtMae_3.TabIndex = 6;
            this.txtMae_3.Text = "Avó materna";
            // 
            // txtPai_3
            // 
            this.txtPai_3.AutoSize = true;
            this.txtPai_3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_3.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_3.Location = new System.Drawing.Point(192, 245);
            this.txtPai_3.Name = "txtPai_3";
            this.txtPai_3.Size = new System.Drawing.Size(86, 18);
            this.txtPai_3.TabIndex = 5;
            this.txtPai_3.Text = "Avô materno";
            // 
            // txtMae_2
            // 
            this.txtMae_2.AutoSize = true;
            this.txtMae_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_2.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_2.Location = new System.Drawing.Point(192, 156);
            this.txtMae_2.Name = "txtMae_2";
            this.txtMae_2.Size = new System.Drawing.Size(83, 18);
            this.txtMae_2.TabIndex = 4;
            this.txtMae_2.Text = "Avó paterna";
            // 
            // txtPai_2
            // 
            this.txtPai_2.AutoSize = true;
            this.txtPai_2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_2.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_2.Location = new System.Drawing.Point(192, 60);
            this.txtPai_2.Name = "txtPai_2";
            this.txtPai_2.Size = new System.Drawing.Size(83, 18);
            this.txtPai_2.TabIndex = 3;
            this.txtPai_2.Text = "Avô paterno";
            // 
            // txtMae_1
            // 
            this.txtMae_1.AutoSize = true;
            this.txtMae_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txtMae_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtMae_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMae_1.ForeColor = System.Drawing.Color.Moccasin;
            this.txtMae_1.Location = new System.Drawing.Point(126, 290);
            this.txtMae_1.Name = "txtMae_1";
            this.txtMae_1.Size = new System.Drawing.Size(37, 18);
            this.txtMae_1.TabIndex = 2;
            this.txtMae_1.Text = "Mãe";
            // 
            // txtPai_1
            // 
            this.txtPai_1.AutoSize = true;
            this.txtPai_1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.txtPai_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtPai_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPai_1.ForeColor = System.Drawing.Color.Moccasin;
            this.txtPai_1.Location = new System.Drawing.Point(126, 108);
            this.txtPai_1.Name = "txtPai_1";
            this.txtPai_1.Size = new System.Drawing.Size(30, 18);
            this.txtPai_1.TabIndex = 1;
            this.txtPai_1.Text = "Pai";
            // 
            // txtAve
            // 
            this.txtAve.AutoSize = true;
            this.txtAve.BackColor = System.Drawing.Color.Green;
            this.txtAve.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txtAve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAve.ForeColor = System.Drawing.Color.Moccasin;
            this.txtAve.Location = new System.Drawing.Point(45, 197);
            this.txtAve.Name = "txtAve";
            this.txtAve.Size = new System.Drawing.Size(2, 18);
            this.txtAve.TabIndex = 0;
            // 
            // btnFiltro
            // 
            this.btnFiltro.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnFiltro.Location = new System.Drawing.Point(572, 454);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(35, 23);
            this.btnFiltro.TabIndex = 94;
            this.btnFiltro.Text = "Flt";
            this.toolTip1.SetToolTip(this.btnFiltro, "Abre a janela de filtros");
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // AvesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(620, 479);
            this.Controls.Add(this.btnFiltro);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.bnAve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AvesForm";
            this.Text = "Cadastro de Aves";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AvesForm_FormClosed);
            this.Load += new System.EventHandler(this.AvesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsAve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnAve)).EndInit();
            this.bnAve.ResumeLayout(false);
            this.bnAve.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.avesPage.ResumeLayout(false);
            this.avesPage.PerformLayout();
            this.filhotesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhotes)).EndInit();
            this.pedigreePage.ResumeLayout(false);
            this.pedigreePage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bsAve;
        private System.Windows.Forms.BindingNavigator bnAve;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button delButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button canButton;
        private System.Windows.Forms.Button incButton;
        private System.Windows.Forms.Button altButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage avesPage;
        private System.Windows.Forms.MaskedTextBox mskValor;
        private System.Windows.Forms.TextBox txtObs;
        private System.Windows.Forms.ComboBox cbMae;
        private System.Windows.Forms.ComboBox cbPai;
        private System.Windows.Forms.ComboBox cbGaiola;
        private System.Windows.Forms.DateTimePicker dtpDataCompra;
        private System.Windows.Forms.ComboBox cbCriador;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpNascimento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCorMutacao;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.TextBox txtIdentAve;
        private System.Windows.Forms.TextBox txtIdAve;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage filhotesPage;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RadioButton rbnFemea;
        private System.Windows.Forms.RadioButton rbnMacho;
        private System.Windows.Forms.RadioButton rbnDesconhecido;
        private System.Windows.Forms.DataGridView dgvFilhotes;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage pedigreePage;
        private System.Windows.Forms.Label txtMae_1;
        private System.Windows.Forms.Label txtPai_1;
        private System.Windows.Forms.Label txtAve;
        private System.Windows.Forms.Label txtMae_3;
        private System.Windows.Forms.Label txtPai_3;
        private System.Windows.Forms.Label txtMae_2;
        private System.Windows.Forms.Label txtPai_2;
        private System.Windows.Forms.Label txtMae_7;
        private System.Windows.Forms.Label txtPai_7;
        private System.Windows.Forms.Label txtMae_6;
        private System.Windows.Forms.Label txtPai_6;
        private System.Windows.Forms.Label txtMae_5;
        private System.Windows.Forms.Label txtPai_5;
        private System.Windows.Forms.Label txtMae_4;
        private System.Windows.Forms.Label txtPai_4;
        private System.Windows.Forms.Label lblAcasalado;
    }
}
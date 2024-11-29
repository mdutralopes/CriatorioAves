
namespace CriatorioAves
{
    partial class CasalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CasalForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.casaisPage = new System.Windows.Forms.TabPage();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbGaiola = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpSeparacao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpJuncao = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cbMae = new System.Windows.Forms.ComboBox();
            this.cbPai = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIdCasal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.posturasPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCriados = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblNascidos = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblBrancos = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGalados = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblOvos = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPosturas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPosturas = new System.Windows.Forms.DataGridView();
            this.filhosPage = new System.Windows.Forms.TabPage();
            this.dgvFilhotes = new System.Windows.Forms.DataGridView();
            this.bnCasais = new System.Windows.Forms.BindingNavigator(this.components);
            this.bsCasais = new System.Windows.Forms.BindingSource(this.components);
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
            this.schButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.casaisPage.SuspendLayout();
            this.posturasPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosturas)).BeginInit();
            this.filhosPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCasais)).BeginInit();
            this.bnCasais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCasais)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.casaisPage);
            this.tabControl1.Controls.Add(this.posturasPage);
            this.tabControl1.Controls.Add(this.filhosPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(608, 269);
            this.tabControl1.TabIndex = 0;
            // 
            // casaisPage
            // 
            this.casaisPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.casaisPage.Controls.Add(this.cbEspecie);
            this.casaisPage.Controls.Add(this.label11);
            this.casaisPage.Controls.Add(this.cbGaiola);
            this.casaisPage.Controls.Add(this.label6);
            this.casaisPage.Controls.Add(this.dtpSeparacao);
            this.casaisPage.Controls.Add(this.label2);
            this.casaisPage.Controls.Add(this.dtpJuncao);
            this.casaisPage.Controls.Add(this.label12);
            this.casaisPage.Controls.Add(this.cbMae);
            this.casaisPage.Controls.Add(this.cbPai);
            this.casaisPage.Controls.Add(this.label8);
            this.casaisPage.Controls.Add(this.label7);
            this.casaisPage.Controls.Add(this.txtIdCasal);
            this.casaisPage.Controls.Add(this.label1);
            this.casaisPage.Location = new System.Drawing.Point(4, 22);
            this.casaisPage.Name = "casaisPage";
            this.casaisPage.Padding = new System.Windows.Forms.Padding(3);
            this.casaisPage.Size = new System.Drawing.Size(600, 243);
            this.casaisPage.TabIndex = 0;
            this.casaisPage.Text = "Casais";
            // 
            // cbEspecie
            // 
            this.cbEspecie.Enabled = false;
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(220, 51);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(180, 21);
            this.cbEspecie.TabIndex = 66;
            this.cbEspecie.Leave += new System.EventHandler(this.cbEspecie_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(126, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "Espécie*";
            // 
            // cbGaiola
            // 
            this.cbGaiola.Enabled = false;
            this.cbGaiola.FormattingEnabled = true;
            this.cbGaiola.Location = new System.Drawing.Point(220, 186);
            this.cbGaiola.Name = "cbGaiola";
            this.cbGaiola.Size = new System.Drawing.Size(128, 21);
            this.cbGaiola.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(126, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Gaiola*";
            // 
            // dtpSeparacao
            // 
            this.dtpSeparacao.Enabled = false;
            this.dtpSeparacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSeparacao.Location = new System.Drawing.Point(220, 159);
            this.dtpSeparacao.Name = "dtpSeparacao";
            this.dtpSeparacao.Size = new System.Drawing.Size(128, 20);
            this.dtpSeparacao.TabIndex = 62;
            this.dtpSeparacao.Value = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 61;
            this.label2.Text = "Data Separação";
            // 
            // dtpJuncao
            // 
            this.dtpJuncao.Enabled = false;
            this.dtpJuncao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpJuncao.Location = new System.Drawing.Point(220, 132);
            this.dtpJuncao.Name = "dtpJuncao";
            this.dtpJuncao.Size = new System.Drawing.Size(128, 20);
            this.dtpJuncao.TabIndex = 60;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Data Junção*";
            // 
            // cbMae
            // 
            this.cbMae.Enabled = false;
            this.cbMae.FormattingEnabled = true;
            this.cbMae.Location = new System.Drawing.Point(220, 105);
            this.cbMae.Name = "cbMae";
            this.cbMae.Size = new System.Drawing.Size(255, 21);
            this.cbMae.TabIndex = 58;
            // 
            // cbPai
            // 
            this.cbPai.Enabled = false;
            this.cbPai.FormattingEnabled = true;
            this.cbPai.Location = new System.Drawing.Point(220, 78);
            this.cbPai.Name = "cbPai";
            this.cbPai.Size = new System.Drawing.Size(255, 21);
            this.cbPai.TabIndex = 57;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 56;
            this.label8.Text = "Fêmea*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(126, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Macho*";
            // 
            // txtIdCasal
            // 
            this.txtIdCasal.Enabled = false;
            this.txtIdCasal.Location = new System.Drawing.Point(220, 24);
            this.txtIdCasal.Name = "txtIdCasal";
            this.txtIdCasal.Size = new System.Drawing.Size(65, 20);
            this.txtIdCasal.TabIndex = 44;
            this.txtIdCasal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Id Casal";
            // 
            // posturasPage
            // 
            this.posturasPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.posturasPage.Controls.Add(this.groupBox1);
            this.posturasPage.Controls.Add(this.dgvPosturas);
            this.posturasPage.Location = new System.Drawing.Point(4, 22);
            this.posturasPage.Name = "posturasPage";
            this.posturasPage.Padding = new System.Windows.Forms.Padding(3);
            this.posturasPage.Size = new System.Drawing.Size(600, 243);
            this.posturasPage.TabIndex = 1;
            this.posturasPage.Text = "Posturas";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCriados);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.lblNascidos);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.lblBrancos);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lblGalados);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.lblOvos);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblPosturas);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 83);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo Posturas";
            // 
            // lblCriados
            // 
            this.lblCriados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCriados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriados.Location = new System.Drawing.Point(475, 53);
            this.lblCriados.Name = "lblCriados";
            this.lblCriados.Size = new System.Drawing.Size(54, 17);
            this.lblCriados.TabIndex = 11;
            this.lblCriados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(400, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Criados";
            // 
            // lblNascidos
            // 
            this.lblNascidos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblNascidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNascidos.Location = new System.Drawing.Point(301, 53);
            this.lblNascidos.Name = "lblNascidos";
            this.lblNascidos.Size = new System.Drawing.Size(54, 17);
            this.lblNascidos.TabIndex = 9;
            this.lblNascidos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(239, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nascidos";
            // 
            // lblBrancos
            // 
            this.lblBrancos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBrancos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrancos.Location = new System.Drawing.Point(124, 53);
            this.lblBrancos.Name = "lblBrancos";
            this.lblBrancos.Size = new System.Drawing.Size(54, 17);
            this.lblBrancos.TabIndex = 7;
            this.lblBrancos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(65, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Brancos";
            // 
            // lblGalados
            // 
            this.lblGalados.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblGalados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGalados.Location = new System.Drawing.Point(475, 21);
            this.lblGalados.Name = "lblGalados";
            this.lblGalados.Size = new System.Drawing.Size(54, 17);
            this.lblGalados.TabIndex = 5;
            this.lblGalados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(400, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Galados";
            // 
            // lblOvos
            // 
            this.lblOvos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOvos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOvos.Location = new System.Drawing.Point(301, 21);
            this.lblOvos.Name = "lblOvos";
            this.lblOvos.Size = new System.Drawing.Size(54, 17);
            this.lblOvos.TabIndex = 3;
            this.lblOvos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(239, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ovos";
            // 
            // lblPosturas
            // 
            this.lblPosturas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPosturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosturas.Location = new System.Drawing.Point(124, 23);
            this.lblPosturas.Name = "lblPosturas";
            this.lblPosturas.Size = new System.Drawing.Size(54, 17);
            this.lblPosturas.TabIndex = 1;
            this.lblPosturas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Posturas";
            // 
            // dgvPosturas
            // 
            this.dgvPosturas.AllowUserToAddRows = false;
            this.dgvPosturas.AllowUserToDeleteRows = false;
            this.dgvPosturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosturas.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvPosturas.Location = new System.Drawing.Point(3, 3);
            this.dgvPosturas.Name = "dgvPosturas";
            this.dgvPosturas.ReadOnly = true;
            this.dgvPosturas.Size = new System.Drawing.Size(594, 154);
            this.dgvPosturas.TabIndex = 0;
            // 
            // filhosPage
            // 
            this.filhosPage.BackColor = System.Drawing.SystemColors.ControlDark;
            this.filhosPage.Controls.Add(this.dgvFilhotes);
            this.filhosPage.Location = new System.Drawing.Point(4, 22);
            this.filhosPage.Name = "filhosPage";
            this.filhosPage.Size = new System.Drawing.Size(600, 243);
            this.filhosPage.TabIndex = 2;
            this.filhosPage.Text = "Filhos";
            // 
            // dgvFilhotes
            // 
            this.dgvFilhotes.AllowUserToAddRows = false;
            this.dgvFilhotes.AllowUserToDeleteRows = false;
            this.dgvFilhotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFilhotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFilhotes.Location = new System.Drawing.Point(0, 0);
            this.dgvFilhotes.Name = "dgvFilhotes";
            this.dgvFilhotes.ReadOnly = true;
            this.dgvFilhotes.Size = new System.Drawing.Size(600, 243);
            this.dgvFilhotes.TabIndex = 0;
            // 
            // bnCasais
            // 
            this.bnCasais.AddNewItem = null;
            this.bnCasais.BindingSource = this.bsCasais;
            this.bnCasais.CountItem = this.bindingNavigatorCountItem;
            this.bnCasais.DeleteItem = null;
            this.bnCasais.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnCasais.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.bnCasais.Location = new System.Drawing.Point(0, 269);
            this.bnCasais.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bnCasais.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bnCasais.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bnCasais.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bnCasais.Name = "bnCasais";
            this.bnCasais.PositionItem = this.bindingNavigatorPositionItem;
            this.bnCasais.Size = new System.Drawing.Size(608, 25);
            this.bnCasais.TabIndex = 1;
            this.bnCasais.Text = "bindingNavigator1";
            // 
            // bsCasais
            // 
            this.bsCasais.CurrentItemChanged += new System.EventHandler(this.bsCasais_CurrentItemChanged);
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
            this.delButton.Location = new System.Drawing.Point(419, 269);
            this.delButton.Name = "delButton";
            this.delButton.Size = new System.Drawing.Size(35, 23);
            this.delButton.TabIndex = 38;
            this.delButton.Text = "Del";
            this.toolTip1.SetToolTip(this.delButton, "Exclui o registro atual");
            this.delButton.UseVisualStyleBackColor = true;
            this.delButton.Click += new System.EventHandler(this.delButton_Click);
            // 
            // okButton
            // 
            this.okButton.Enabled = false;
            this.okButton.Location = new System.Drawing.Point(461, 269);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(35, 23);
            this.okButton.TabIndex = 36;
            this.okButton.Text = "OK";
            this.toolTip1.SetToolTip(this.okButton, "Confirma a operação");
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // canButton
            // 
            this.canButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.canButton.Enabled = false;
            this.canButton.Location = new System.Drawing.Point(503, 269);
            this.canButton.Name = "canButton";
            this.canButton.Size = new System.Drawing.Size(35, 23);
            this.canButton.TabIndex = 37;
            this.canButton.Text = "Can";
            this.toolTip1.SetToolTip(this.canButton, "Cancela a operação");
            this.canButton.UseVisualStyleBackColor = true;
            this.canButton.Click += new System.EventHandler(this.canButton_Click);
            // 
            // incButton
            // 
            this.incButton.Location = new System.Drawing.Point(377, 269);
            this.incButton.Name = "incButton";
            this.incButton.Size = new System.Drawing.Size(35, 23);
            this.incButton.TabIndex = 35;
            this.incButton.Text = "Add";
            this.toolTip1.SetToolTip(this.incButton, "Inclui um novo registro");
            this.incButton.UseVisualStyleBackColor = true;
            this.incButton.Click += new System.EventHandler(this.incButton_Click);
            // 
            // altButton
            // 
            this.altButton.Location = new System.Drawing.Point(335, 269);
            this.altButton.Name = "altButton";
            this.altButton.Size = new System.Drawing.Size(35, 23);
            this.altButton.TabIndex = 34;
            this.altButton.Text = "Upd";
            this.toolTip1.SetToolTip(this.altButton, "Altera o registro");
            this.altButton.UseVisualStyleBackColor = true;
            this.altButton.Click += new System.EventHandler(this.altButton_Click);
            // 
            // schButton
            // 
            this.schButton.Location = new System.Drawing.Point(545, 269);
            this.schButton.Name = "schButton";
            this.schButton.Size = new System.Drawing.Size(35, 23);
            this.schButton.TabIndex = 67;
            this.schButton.Text = "Sch";
            this.toolTip1.SetToolTip(this.schButton, "Procura por um registro");
            this.schButton.UseVisualStyleBackColor = true;
            this.schButton.Click += new System.EventHandler(this.schButton_Click);
            // 
            // CasalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CancelButton = this.canButton;
            this.ClientSize = new System.Drawing.Size(608, 294);
            this.Controls.Add(this.schButton);
            this.Controls.Add(this.delButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.canButton);
            this.Controls.Add(this.incButton);
            this.Controls.Add(this.altButton);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bnCasais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CasalForm";
            this.Text = "Cadastro de Casais";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CasalForm_FormClosed);
            this.Load += new System.EventHandler(this.CasalForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.casaisPage.ResumeLayout(false);
            this.casaisPage.PerformLayout();
            this.posturasPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosturas)).EndInit();
            this.filhosPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFilhotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bnCasais)).EndInit();
            this.bnCasais.ResumeLayout(false);
            this.bnCasais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bsCasais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage casaisPage;
        private System.Windows.Forms.TabPage posturasPage;
        private System.Windows.Forms.BindingNavigator bnCasais;
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
        private System.Windows.Forms.DataGridView dgvPosturas;
        private System.Windows.Forms.TabPage filhosPage;
        private System.Windows.Forms.DataGridView dgvFilhotes;
        private System.Windows.Forms.BindingSource bsCasais;
        private System.Windows.Forms.TextBox txtIdCasal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbMae;
        private System.Windows.Forms.ComboBox cbPai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpJuncao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpSeparacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbGaiola;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbEspecie;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblPosturas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCriados;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblNascidos;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblBrancos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGalados;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblOvos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button schButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
﻿namespace a7D.PDV.Integracao.Servico.UI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Caixa"}, "CaixaIcon.png", System.Drawing.Color.DarkRed, System.Drawing.SystemColors.ActiveBorder, null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Impressora", "ImpressoraIcon.png");
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pbServer = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbERP = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pbIFood = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbEasyChopp = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pbImpressao = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pbPagamentoIntegrado = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPOS = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatusPOS = new System.Windows.Forms.TextBox();
            this.tabServicos = new System.Windows.Forms.TabControl();
            this.tabServidor = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStatusServer = new System.Windows.Forms.TextBox();
            this.tabImpressao = new System.Windows.Forms.TabPage();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStatusImpressao = new System.Windows.Forms.TextBox();
            this.tabIFood = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIFood = new System.Windows.Forms.TextBox();
            this.tabERP = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.txtStatusERP = new System.Windows.Forms.TextBox();
            this.tabEasyChopp = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStatusEasyChopp = new System.Windows.Forms.TextBox();
            this.ntf = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.st = new System.Windows.Forms.StatusStrip();
            this.stCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.stStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.imgs = new System.Windows.Forms.ImageList(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbERP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasyChopp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpressao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagamentoIntegrado)).BeginInit();
            this.tabPOS.SuspendLayout();
            this.tabServicos.SuspendLayout();
            this.tabServidor.SuspendLayout();
            this.tabImpressao.SuspendLayout();
            this.tabIFood.SuspendLayout();
            this.tabERP.SuspendLayout();
            this.tabEasyChopp.SuspendLayout();
            this.mnu.SuspendLayout();
            this.st.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pbServer);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pbERP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.pbIFood);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.pbEasyChopp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.pbImpressao);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.pbPagamentoIntegrado);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(356, 292);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Serviços";
            // 
            // pbServer
            // 
            this.pbServer.BackColor = System.Drawing.Color.Silver;
            this.pbServer.Location = new System.Drawing.Point(14, 42);
            this.pbServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbServer.Name = "pbServer";
            this.pbServer.Size = new System.Drawing.Size(34, 31);
            this.pbServer.TabIndex = 15;
            this.pbServer.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Servidor PDV7";
            // 
            // pbERP
            // 
            this.pbERP.BackColor = System.Drawing.Color.Silver;
            this.pbERP.Location = new System.Drawing.Point(14, 200);
            this.pbERP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbERP.Name = "pbERP";
            this.pbERP.Size = new System.Drawing.Size(34, 31);
            this.pbERP.TabIndex = 13;
            this.pbERP.TabStop = false;
            this.pbERP.Click += new System.EventHandler(this.Status_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 200);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "ERP";
            // 
            // pbIFood
            // 
            this.pbIFood.BackColor = System.Drawing.Color.Silver;
            this.pbIFood.Location = new System.Drawing.Point(14, 160);
            this.pbIFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbIFood.Name = "pbIFood";
            this.pbIFood.Size = new System.Drawing.Size(34, 31);
            this.pbIFood.TabIndex = 11;
            this.pbIFood.TabStop = false;
            this.pbIFood.Click += new System.EventHandler(this.Status_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 160);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 25);
            this.label9.TabIndex = 10;
            this.label9.Text = "iFood";
            // 
            // pbEasyChopp
            // 
            this.pbEasyChopp.BackColor = System.Drawing.Color.Silver;
            this.pbEasyChopp.Location = new System.Drawing.Point(14, 240);
            this.pbEasyChopp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbEasyChopp.Name = "pbEasyChopp";
            this.pbEasyChopp.Size = new System.Drawing.Size(34, 31);
            this.pbEasyChopp.TabIndex = 9;
            this.pbEasyChopp.TabStop = false;
            this.pbEasyChopp.Click += new System.EventHandler(this.Status_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 245);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "EasyChopp";
            // 
            // pbImpressao
            // 
            this.pbImpressao.BackColor = System.Drawing.Color.Silver;
            this.pbImpressao.Location = new System.Drawing.Point(14, 80);
            this.pbImpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImpressao.Name = "pbImpressao";
            this.pbImpressao.Size = new System.Drawing.Size(34, 31);
            this.pbImpressao.TabIndex = 7;
            this.pbImpressao.TabStop = false;
            this.pbImpressao.Click += new System.EventHandler(this.Status_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 80);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ordem de Impressão";
            // 
            // pbPagamentoIntegrado
            // 
            this.pbPagamentoIntegrado.BackColor = System.Drawing.Color.Silver;
            this.pbPagamentoIntegrado.Location = new System.Drawing.Point(14, 120);
            this.pbPagamentoIntegrado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbPagamentoIntegrado.Name = "pbPagamentoIntegrado";
            this.pbPagamentoIntegrado.Size = new System.Drawing.Size(34, 31);
            this.pbPagamentoIntegrado.TabIndex = 5;
            this.pbPagamentoIntegrado.TabStop = false;
            this.pbPagamentoIntegrado.Click += new System.EventHandler(this.Status_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Pagamento Integrado";
            // 
            // tabPOS
            // 
            this.tabPOS.Controls.Add(this.label6);
            this.tabPOS.Controls.Add(this.txtStatusPOS);
            this.tabPOS.Location = new System.Drawing.Point(4, 54);
            this.tabPOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPOS.Name = "tabPOS";
            this.tabPOS.Size = new System.Drawing.Size(691, 434);
            this.tabPOS.TabIndex = 2;
            this.tabPOS.Text = "Pagamento Integrado";
            this.tabPOS.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 14);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Log:";
            // 
            // txtStatusPOS
            // 
            this.txtStatusPOS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusPOS.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtStatusPOS.Location = new System.Drawing.Point(15, 42);
            this.txtStatusPOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatusPOS.Multiline = true;
            this.txtStatusPOS.Name = "txtStatusPOS";
            this.txtStatusPOS.ReadOnly = true;
            this.txtStatusPOS.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusPOS.Size = new System.Drawing.Size(655, 393);
            this.txtStatusPOS.TabIndex = 4;
            // 
            // tabServicos
            // 
            this.tabServicos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabServicos.Controls.Add(this.tabServidor);
            this.tabServicos.Controls.Add(this.tabImpressao);
            this.tabServicos.Controls.Add(this.tabPOS);
            this.tabServicos.Controls.Add(this.tabIFood);
            this.tabServicos.Controls.Add(this.tabERP);
            this.tabServicos.Controls.Add(this.tabEasyChopp);
            this.tabServicos.Location = new System.Drawing.Point(384, 18);
            this.tabServicos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServicos.Multiline = true;
            this.tabServicos.Name = "tabServicos";
            this.tabServicos.SelectedIndex = 0;
            this.tabServicos.Size = new System.Drawing.Size(699, 492);
            this.tabServicos.TabIndex = 2;
            // 
            // tabServidor
            // 
            this.tabServidor.Controls.Add(this.label2);
            this.tabServidor.Controls.Add(this.txtStatusServer);
            this.tabServidor.Location = new System.Drawing.Point(4, 29);
            this.tabServidor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServidor.Name = "tabServidor";
            this.tabServidor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabServidor.Size = new System.Drawing.Size(691, 459);
            this.tabServidor.TabIndex = 7;
            this.tabServidor.Text = "Servidor PDV7";
            this.tabServidor.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Log:";
            // 
            // txtStatusServer
            // 
            this.txtStatusServer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusServer.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtStatusServer.Location = new System.Drawing.Point(15, 42);
            this.txtStatusServer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatusServer.Multiline = true;
            this.txtStatusServer.Name = "txtStatusServer";
            this.txtStatusServer.ReadOnly = true;
            this.txtStatusServer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusServer.Size = new System.Drawing.Size(655, 418);
            this.txtStatusServer.TabIndex = 6;
            // 
            // tabImpressao
            // 
            this.tabImpressao.Controls.Add(this.label5);
            this.tabImpressao.Controls.Add(this.txtStatusImpressao);
            this.tabImpressao.Location = new System.Drawing.Point(4, 54);
            this.tabImpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabImpressao.Name = "tabImpressao";
            this.tabImpressao.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabImpressao.Size = new System.Drawing.Size(691, 434);
            this.tabImpressao.TabIndex = 3;
            this.tabImpressao.Text = "Ordem de Impressão";
            this.tabImpressao.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Log:";
            // 
            // txtStatusImpressao
            // 
            this.txtStatusImpressao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusImpressao.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtStatusImpressao.Location = new System.Drawing.Point(15, 42);
            this.txtStatusImpressao.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatusImpressao.Multiline = true;
            this.txtStatusImpressao.Name = "txtStatusImpressao";
            this.txtStatusImpressao.ReadOnly = true;
            this.txtStatusImpressao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusImpressao.Size = new System.Drawing.Size(655, 393);
            this.txtStatusImpressao.TabIndex = 4;
            // 
            // tabIFood
            // 
            this.tabIFood.Controls.Add(this.label10);
            this.tabIFood.Controls.Add(this.txtIFood);
            this.tabIFood.Location = new System.Drawing.Point(4, 54);
            this.tabIFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIFood.Name = "tabIFood";
            this.tabIFood.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabIFood.Size = new System.Drawing.Size(691, 434);
            this.tabIFood.TabIndex = 5;
            this.tabIFood.Text = "iFood";
            this.tabIFood.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(10, 14);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 20);
            this.label10.TabIndex = 9;
            this.label10.Text = "Log:";
            // 
            // txtIFood
            // 
            this.txtIFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIFood.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtIFood.Location = new System.Drawing.Point(15, 42);
            this.txtIFood.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtIFood.Multiline = true;
            this.txtIFood.Name = "txtIFood";
            this.txtIFood.ReadOnly = true;
            this.txtIFood.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIFood.Size = new System.Drawing.Size(655, 393);
            this.txtIFood.TabIndex = 8;
            // 
            // tabERP
            // 
            this.tabERP.Controls.Add(this.label12);
            this.tabERP.Controls.Add(this.txtStatusERP);
            this.tabERP.Location = new System.Drawing.Point(4, 54);
            this.tabERP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabERP.Name = "tabERP";
            this.tabERP.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabERP.Size = new System.Drawing.Size(691, 434);
            this.tabERP.TabIndex = 6;
            this.tabERP.Text = "ERP";
            this.tabERP.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Log:";
            // 
            // txtStatusERP
            // 
            this.txtStatusERP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusERP.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatusERP.Location = new System.Drawing.Point(15, 42);
            this.txtStatusERP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatusERP.Multiline = true;
            this.txtStatusERP.Name = "txtStatusERP";
            this.txtStatusERP.ReadOnly = true;
            this.txtStatusERP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusERP.Size = new System.Drawing.Size(655, 393);
            this.txtStatusERP.TabIndex = 8;
            // 
            // tabEasyChopp
            // 
            this.tabEasyChopp.Controls.Add(this.label8);
            this.tabEasyChopp.Controls.Add(this.txtStatusEasyChopp);
            this.tabEasyChopp.Location = new System.Drawing.Point(4, 54);
            this.tabEasyChopp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEasyChopp.Name = "tabEasyChopp";
            this.tabEasyChopp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabEasyChopp.Size = new System.Drawing.Size(691, 434);
            this.tabEasyChopp.TabIndex = 4;
            this.tabEasyChopp.Text = "EasyChopp";
            this.tabEasyChopp.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 14);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Log:";
            // 
            // txtStatusEasyChopp
            // 
            this.txtStatusEasyChopp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStatusEasyChopp.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.txtStatusEasyChopp.Location = new System.Drawing.Point(15, 42);
            this.txtStatusEasyChopp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStatusEasyChopp.Multiline = true;
            this.txtStatusEasyChopp.Name = "txtStatusEasyChopp";
            this.txtStatusEasyChopp.ReadOnly = true;
            this.txtStatusEasyChopp.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStatusEasyChopp.Size = new System.Drawing.Size(655, 393);
            this.txtStatusEasyChopp.TabIndex = 6;
            // 
            // ntf
            // 
            this.ntf.ContextMenuStrip = this.mnu;
            this.ntf.Icon = ((System.Drawing.Icon)(resources.GetObject("ntf.Icon")));
            this.ntf.Text = "Integrador";
            this.ntf.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ntf_MouseDoubleClick);
            // 
            // mnu
            // 
            this.mnu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuConfig,
            this.mnuSair});
            this.mnu.Name = "mnu";
            this.mnu.Size = new System.Drawing.Size(199, 68);
            // 
            // mnuConfig
            // 
            this.mnuConfig.Name = "mnuConfig";
            this.mnuConfig.Size = new System.Drawing.Size(198, 32);
            this.mnuConfig.Text = "Configurações";
            this.mnuConfig.Click += new System.EventHandler(this.mnuConfig_Click);
            // 
            // mnuSair
            // 
            this.mnuSair.Name = "mnuSair";
            this.mnuSair.Size = new System.Drawing.Size(198, 32);
            this.mnuSair.Text = "Sair";
            this.mnuSair.Click += new System.EventHandler(this.mnuSair_Click);
            // 
            // tmr
            // 
            this.tmr.Interval = 2000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // st
            // 
            this.st.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.st.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stCount,
            this.stStatus});
            this.st.Location = new System.Drawing.Point(0, 523);
            this.st.Name = "st";
            this.st.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.st.Size = new System.Drawing.Size(1101, 32);
            this.st.TabIndex = 8;
            this.st.Text = "st";
            // 
            // stCount
            // 
            this.stCount.Margin = new System.Windows.Forms.Padding(5, 3, 5, 2);
            this.stCount.Name = "stCount";
            this.stCount.Size = new System.Drawing.Size(22, 27);
            this.stCount.Text = "0";
            // 
            // stStatus
            // 
            this.stStatus.Name = "stStatus";
            this.stStatus.Size = new System.Drawing.Size(117, 25);
            this.stStatus.Text = "Carregando...";
            // 
            // lvStatus
            // 
            this.lvStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lvStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lvStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.HideSelection = false;
            listViewItem1.StateImageIndex = 0;
            listViewItem2.StateImageIndex = 0;
            this.lvStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
            this.lvStatus.LabelWrap = false;
            this.lvStatus.Location = new System.Drawing.Point(9, 34);
            this.lvStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvStatus.MultiSelect = false;
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.ShowItemToolTips = true;
            this.lvStatus.Size = new System.Drawing.Size(338, 148);
            this.lvStatus.SmallImageList = this.imgs;
            this.lvStatus.TabIndex = 16;
            this.lvStatus.TileSize = new System.Drawing.Size(168, 30);
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.List;
            // 
            // imgs
            // 
            this.imgs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgs.ImageStream")));
            this.imgs.TransparentColor = System.Drawing.Color.Transparent;
            this.imgs.Images.SetKeyName(0, "ImpressoraIcon.png");
            this.imgs.Images.SetKeyName(1, "CaixaIcon.png");
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.lvStatus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(18, 320);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(356, 191);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Áreas de Impressão";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 555);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.st);
            this.Controls.Add(this.tabServicos);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1114, 585);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDVSeven Integrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal2_FormClosing);
            this.Load += new System.EventHandler(this.frmPrincipal2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbServer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbERP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbEasyChopp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImpressao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPagamentoIntegrado)).EndInit();
            this.tabPOS.ResumeLayout(false);
            this.tabPOS.PerformLayout();
            this.tabServicos.ResumeLayout(false);
            this.tabServidor.ResumeLayout(false);
            this.tabServidor.PerformLayout();
            this.tabImpressao.ResumeLayout(false);
            this.tabImpressao.PerformLayout();
            this.tabIFood.ResumeLayout(false);
            this.tabIFood.PerformLayout();
            this.tabERP.ResumeLayout(false);
            this.tabERP.PerformLayout();
            this.tabEasyChopp.ResumeLayout(false);
            this.tabEasyChopp.PerformLayout();
            this.mnu.ResumeLayout(false);
            this.st.ResumeLayout(false);
            this.st.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbPagamentoIntegrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage tabPOS;
        private System.Windows.Forms.TabControl tabServicos;
        private System.Windows.Forms.NotifyIcon ntf;
        private System.Windows.Forms.PictureBox pbImpressao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabImpressao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatusPOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStatusImpressao;
        private System.Windows.Forms.PictureBox pbEasyChopp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabEasyChopp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStatusEasyChopp;
        private System.Windows.Forms.PictureBox pbIFood;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabIFood;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIFood;
        private System.Windows.Forms.PictureBox pbERP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TabPage tabERP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtStatusERP;
        private System.Windows.Forms.ContextMenuStrip mnu;
        private System.Windows.Forms.ToolStripMenuItem mnuConfig;
        private System.Windows.Forms.ToolStripMenuItem mnuSair;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.StatusStrip st;
        private System.Windows.Forms.ToolStripStatusLabel stCount;
        private System.Windows.Forms.ToolStripStatusLabel stStatus;
        private System.Windows.Forms.PictureBox pbServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabServidor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtStatusServer;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ImageList imgs;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
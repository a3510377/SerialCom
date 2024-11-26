namespace SerialCom
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timerRefreshSerial = new System.Windows.Forms.Timer(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReceiveClear = new System.Windows.Forms.Button();
            this.textBoxReceive = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWithLR = new System.Windows.Forms.CheckBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.key7 = new System.Windows.Forms.Button();
            this.key8 = new System.Windows.Forms.Button();
            this.key9 = new System.Windows.Forms.Button();
            this.keyClear = new System.Windows.Forms.Button();
            this.key4 = new System.Windows.Forms.Button();
            this.key5 = new System.Windows.Forms.Button();
            this.key6 = new System.Windows.Forms.Button();
            this.keyRet = new System.Windows.Forms.Button();
            this.key1 = new System.Windows.Forms.Button();
            this.key2 = new System.Windows.Forms.Button();
            this.key3 = new System.Windows.Forms.Button();
            this.keySend = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.key0 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.btnToggleConnect = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxStopBit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxCheckBit = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDataBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxBaundRate = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerRefreshSerial
            // 
            this.timerRefreshSerial.Enabled = true;
            this.timerRefreshSerial.Interval = 500;
            this.timerRefreshSerial.Tick += new System.EventHandler(this.TimerRefreshSerial_Tick);
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.btnReceiveClear);
            this.groupBox2.Controls.Add(this.textBoxReceive);
            this.groupBox2.Location = new System.Drawing.Point(38, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 255);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "接收";
            // 
            // btnReceiveClear
            // 
            this.btnReceiveClear.Location = new System.Drawing.Point(186, 211);
            this.btnReceiveClear.Name = "btnReceiveClear";
            this.btnReceiveClear.Size = new System.Drawing.Size(75, 23);
            this.btnReceiveClear.TabIndex = 6;
            this.btnReceiveClear.Text = "清除";
            this.btnReceiveClear.UseVisualStyleBackColor = true;
            this.btnReceiveClear.Click += new System.EventHandler(this.BtnReceiveClear_Click);
            // 
            // textBoxReceive
            // 
            this.textBoxReceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxReceive.Location = new System.Drawing.Point(16, 26);
            this.textBoxReceive.Multiline = true;
            this.textBoxReceive.Name = "textBoxReceive";
            this.textBoxReceive.Size = new System.Drawing.Size(245, 179);
            this.textBoxReceive.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.btnWithLR);
            this.groupBox1.Controls.Add(this.btnSend);
            this.groupBox1.Controls.Add(this.textBoxSend);
            this.groupBox1.Location = new System.Drawing.Point(38, 345);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(274, 94);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "發送";
            // 
            // btnWithLR
            // 
            this.btnWithLR.AutoSize = true;
            this.btnWithLR.Checked = true;
            this.btnWithLR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.btnWithLR.Location = new System.Drawing.Point(7, 56);
            this.btnWithLR.Name = "btnWithLR";
            this.btnWithLR.Size = new System.Drawing.Size(72, 16);
            this.btnWithLR.TabIndex = 8;
            this.btnWithLR.Text = "發送換行";
            this.btnWithLR.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(189, 50);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "發送";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(6, 22);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(258, 22);
            this.textBoxSend.TabIndex = 4;
            // 
            // key7
            // 
            this.key7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key7.Location = new System.Drawing.Point(0, 0);
            this.key7.Margin = new System.Windows.Forms.Padding(0);
            this.key7.Name = "key7";
            this.key7.Size = new System.Drawing.Size(95, 73);
            this.key7.TabIndex = 0;
            this.key7.Text = "7";
            this.key7.UseMnemonic = false;
            this.key7.UseVisualStyleBackColor = true;
            this.key7.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key8
            // 
            this.key8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key8.Location = new System.Drawing.Point(115, 0);
            this.key8.Margin = new System.Windows.Forms.Padding(0);
            this.key8.Name = "key8";
            this.key8.Size = new System.Drawing.Size(95, 73);
            this.key8.TabIndex = 1;
            this.key8.Text = "8";
            this.key8.UseMnemonic = false;
            this.key8.UseVisualStyleBackColor = true;
            this.key8.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key9
            // 
            this.key9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key9.Location = new System.Drawing.Point(230, 0);
            this.key9.Margin = new System.Windows.Forms.Padding(0);
            this.key9.Name = "key9";
            this.key9.Size = new System.Drawing.Size(95, 73);
            this.key9.TabIndex = 2;
            this.key9.Text = "9";
            this.key9.UseMnemonic = false;
            this.key9.UseVisualStyleBackColor = true;
            this.key9.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // keyClear
            // 
            this.keyClear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyClear.Location = new System.Drawing.Point(345, 0);
            this.keyClear.Margin = new System.Windows.Forms.Padding(0);
            this.keyClear.Name = "keyClear";
            this.keyClear.Size = new System.Drawing.Size(95, 73);
            this.keyClear.TabIndex = 3;
            this.keyClear.Text = "清除";
            this.keyClear.UseMnemonic = false;
            this.keyClear.UseVisualStyleBackColor = true;
            this.keyClear.Click += new System.EventHandler(this.KeyClear_Click);
            // 
            // key4
            // 
            this.key4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key4.Location = new System.Drawing.Point(0, 93);
            this.key4.Margin = new System.Windows.Forms.Padding(0);
            this.key4.Name = "key4";
            this.key4.Size = new System.Drawing.Size(95, 73);
            this.key4.TabIndex = 4;
            this.key4.Text = "4";
            this.key4.UseMnemonic = false;
            this.key4.UseVisualStyleBackColor = true;
            this.key4.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key5
            // 
            this.key5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key5.Location = new System.Drawing.Point(115, 93);
            this.key5.Margin = new System.Windows.Forms.Padding(0);
            this.key5.Name = "key5";
            this.key5.Size = new System.Drawing.Size(95, 73);
            this.key5.TabIndex = 5;
            this.key5.Text = "5";
            this.key5.UseMnemonic = false;
            this.key5.UseVisualStyleBackColor = true;
            this.key5.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key6
            // 
            this.key6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key6.Location = new System.Drawing.Point(230, 93);
            this.key6.Margin = new System.Windows.Forms.Padding(0);
            this.key6.Name = "key6";
            this.key6.Size = new System.Drawing.Size(95, 73);
            this.key6.TabIndex = 6;
            this.key6.Text = "6";
            this.key6.UseMnemonic = false;
            this.key6.UseVisualStyleBackColor = true;
            this.key6.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // keyRet
            // 
            this.keyRet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyRet.Location = new System.Drawing.Point(345, 93);
            this.keyRet.Margin = new System.Windows.Forms.Padding(0);
            this.keyRet.Name = "keyRet";
            this.keyRet.Size = new System.Drawing.Size(95, 73);
            this.keyRet.TabIndex = 7;
            this.keyRet.UseMnemonic = false;
            this.keyRet.UseVisualStyleBackColor = true;
            // 
            // key1
            // 
            this.key1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key1.Location = new System.Drawing.Point(0, 186);
            this.key1.Margin = new System.Windows.Forms.Padding(0);
            this.key1.Name = "key1";
            this.key1.Size = new System.Drawing.Size(95, 73);
            this.key1.TabIndex = 8;
            this.key1.Text = "1";
            this.key1.UseMnemonic = false;
            this.key1.UseVisualStyleBackColor = true;
            this.key1.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key2
            // 
            this.key2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key2.Location = new System.Drawing.Point(115, 186);
            this.key2.Margin = new System.Windows.Forms.Padding(0);
            this.key2.Name = "key2";
            this.key2.Size = new System.Drawing.Size(95, 73);
            this.key2.TabIndex = 9;
            this.key2.Text = "2";
            this.key2.UseMnemonic = false;
            this.key2.UseVisualStyleBackColor = true;
            this.key2.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // key3
            // 
            this.key3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key3.Location = new System.Drawing.Point(230, 186);
            this.key3.Margin = new System.Windows.Forms.Padding(0);
            this.key3.Name = "key3";
            this.key3.Size = new System.Drawing.Size(95, 73);
            this.key3.TabIndex = 10;
            this.key3.Text = "3";
            this.key3.UseMnemonic = false;
            this.key3.UseVisualStyleBackColor = true;
            this.key3.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // keySend
            // 
            this.keySend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keySend.Location = new System.Drawing.Point(345, 186);
            this.keySend.Margin = new System.Windows.Forms.Padding(0);
            this.keySend.Name = "keySend";
            this.keySend.Size = new System.Drawing.Size(95, 73);
            this.keySend.TabIndex = 11;
            this.keySend.Text = "送出";
            this.keySend.UseMnemonic = false;
            this.keySend.UseVisualStyleBackColor = true;
            this.keySend.Click += new System.EventHandler(this.KeySend_Click);
            // 
            // btn1
            // 
            this.btn1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn1.Location = new System.Drawing.Point(0, 279);
            this.btn1.Margin = new System.Windows.Forms.Padding(0);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 73);
            this.btn1.TabIndex = 12;
            this.btn1.Text = " ";
            this.btn1.UseMnemonic = false;
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // key0
            // 
            this.key0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.key0.Location = new System.Drawing.Point(115, 279);
            this.key0.Margin = new System.Windows.Forms.Padding(0);
            this.key0.Name = "key0";
            this.key0.Size = new System.Drawing.Size(95, 73);
            this.key0.TabIndex = 13;
            this.key0.Text = "0";
            this.key0.UseMnemonic = false;
            this.key0.UseVisualStyleBackColor = true;
            this.key0.Click += new System.EventHandler(this.KeyNum_Click);
            // 
            // btn2
            // 
            this.btn2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn2.Location = new System.Drawing.Point(230, 279);
            this.btn2.Margin = new System.Windows.Forms.Padding(0);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 73);
            this.btn2.TabIndex = 14;
            this.btn2.Text = " ";
            this.btn2.UseMnemonic = false;
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn3.Location = new System.Drawing.Point(345, 279);
            this.btn3.Margin = new System.Windows.Forms.Padding(0);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 73);
            this.btn3.TabIndex = 15;
            this.btn3.Text = " ";
            this.btn3.UseMnemonic = false;
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 7;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn3, 6, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn2, 4, 6);
            this.tableLayoutPanel1.Controls.Add(this.key0, 2, 6);
            this.tableLayoutPanel1.Controls.Add(this.btn1, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.keySend, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.key3, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.key2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.key1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.keyRet, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.key6, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.key5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.key4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.keyClear, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.key9, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.key8, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.key7, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(332, 87);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(440, 352);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(532, 24);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(104, 20);
            this.comboBoxPorts.Sorted = true;
            this.comboBoxPorts.TabIndex = 17;
            // 
            // btnToggleConnect
            // 
            this.btnToggleConnect.Location = new System.Drawing.Point(703, 26);
            this.btnToggleConnect.Name = "btnToggleConnect";
            this.btnToggleConnect.Size = new System.Drawing.Size(69, 39);
            this.btnToggleConnect.TabIndex = 18;
            this.btnToggleConnect.Text = "連線";
            this.btnToggleConnect.UseVisualStyleBackColor = true;
            this.btnToggleConnect.Click += new System.EventHandler(this.BtnToggleConnect_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxStopBit);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.comboBoxCheckBit);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxDataBit);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBoxBaundRate);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxPorts);
            this.groupBox3.Location = new System.Drawing.Point(38, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(647, 59);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "串口設定";
            // 
            // comboBoxStopBit
            // 
            this.comboBoxStopBit.FormattingEnabled = true;
            this.comboBoxStopBit.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.comboBoxStopBit.Location = new System.Drawing.Point(293, 23);
            this.comboBoxStopBit.Name = "comboBoxStopBit";
            this.comboBoxStopBit.Size = new System.Drawing.Size(45, 20);
            this.comboBoxStopBit.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 27;
            this.label6.Text = "停止位";
            // 
            // comboBoxCheckBit
            // 
            this.comboBoxCheckBit.FormattingEnabled = true;
            this.comboBoxCheckBit.Items.AddRange(new object[] {
            "None",
            "Even",
            "Mark",
            "Odd"});
            this.comboBoxCheckBit.Location = new System.Drawing.Point(182, 23);
            this.comboBoxCheckBit.Name = "comboBoxCheckBit";
            this.comboBoxCheckBit.Size = new System.Drawing.Size(58, 20);
            this.comboBoxCheckBit.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 23;
            this.label4.Text = "偵錯位元";
            // 
            // comboBoxDataBit
            // 
            this.comboBoxDataBit.FormattingEnabled = true;
            this.comboBoxDataBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.comboBoxDataBit.Location = new System.Drawing.Point(69, 23);
            this.comboBoxDataBit.Name = "comboBoxDataBit";
            this.comboBoxDataBit.Size = new System.Drawing.Size(45, 20);
            this.comboBoxDataBit.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "資料長度";
            // 
            // comboBoxBaundRate
            // 
            this.comboBoxBaundRate.FormattingEnabled = true;
            this.comboBoxBaundRate.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "57600",
            "115200",
            "128000",
            "256000",
            "460800",
            "512000",
            "750000",
            "821600",
            "1500000"});
            this.comboBoxBaundRate.Location = new System.Drawing.Point(404, 24);
            this.comboBoxBaundRate.Name = "comboBoxBaundRate";
            this.comboBoxBaundRate.Size = new System.Drawing.Size(87, 20);
            this.comboBoxBaundRate.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "鮑率";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "端口";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 466);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnToggleConnect);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerRefreshSerial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReceiveClear;
        private System.Windows.Forms.TextBox textBoxReceive;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox btnWithLR;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button key7;
        private System.Windows.Forms.Button key8;
        private System.Windows.Forms.Button key9;
        private System.Windows.Forms.Button keyClear;
        private System.Windows.Forms.Button key4;
        private System.Windows.Forms.Button key5;
        private System.Windows.Forms.Button key6;
        private System.Windows.Forms.Button keyRet;
        private System.Windows.Forms.Button key1;
        private System.Windows.Forms.Button key2;
        private System.Windows.Forms.Button key3;
        private System.Windows.Forms.Button keySend;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button key0;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.Button btnToggleConnect;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxBaundRate;
        private System.Windows.Forms.ComboBox comboBoxDataBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxCheckBit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxStopBit;
        private System.Windows.Forms.Label label6;
    }
}


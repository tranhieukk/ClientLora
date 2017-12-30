namespace ClientLoRa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPortName = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbparity = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbhandshake = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txbBaudRate = new System.Windows.Forms.TextBox();
            this.txbdataBits = new System.Windows.Forms.TextBox();
            this.cbbStopBits = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbClientName = new System.Windows.Forms.TextBox();
            this.rtxbgui = new System.Windows.Forms.RichTextBox();
            this.btncreate = new System.Windows.Forms.Button();
            this.btnEXit = new System.Windows.Forms.Button();
            this.btnsend = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbNgNhan = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.noidung = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PortName";
            // 
            // cbxPortName
            // 
            this.cbxPortName.FormattingEnabled = true;
            this.cbxPortName.Location = new System.Drawing.Point(103, 3);
            this.cbxPortName.Name = "cbxPortName";
            this.cbxPortName.Size = new System.Drawing.Size(94, 21);
            this.cbxPortName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PortBaudRate";
            // 
            // cbbparity
            // 
            this.cbbparity.FormattingEnabled = true;
            this.cbbparity.Location = new System.Drawing.Point(103, 67);
            this.cbbparity.Name = "cbbparity";
            this.cbbparity.Size = new System.Drawing.Size(94, 21);
            this.cbbparity.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PortParity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "PortDataBits";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "PortStopBits";
            // 
            // cbbhandshake
            // 
            this.cbbhandshake.FormattingEnabled = true;
            this.cbbhandshake.Location = new System.Drawing.Point(103, 185);
            this.cbbhandshake.Name = "cbbhandshake";
            this.cbbhandshake.Size = new System.Drawing.Size(94, 21);
            this.cbbhandshake.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "PortHandshake";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txbBaudRate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbxPortName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.cbbhandshake, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbparity, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txbdataBits, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbbStopBits, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(200, 220);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // txbBaudRate
            // 
            this.txbBaudRate.Location = new System.Drawing.Point(103, 35);
            this.txbBaudRate.Name = "txbBaudRate";
            this.txbBaudRate.Size = new System.Drawing.Size(94, 20);
            this.txbBaudRate.TabIndex = 13;
            // 
            // txbdataBits
            // 
            this.txbdataBits.Location = new System.Drawing.Point(103, 105);
            this.txbdataBits.Name = "txbdataBits";
            this.txbdataBits.Size = new System.Drawing.Size(94, 20);
            this.txbdataBits.TabIndex = 14;
            // 
            // cbbStopBits
            // 
            this.cbbStopBits.FormattingEnabled = true;
            this.cbbStopBits.Location = new System.Drawing.Point(103, 144);
            this.cbbStopBits.Name = "cbbStopBits";
            this.cbbStopBits.Size = new System.Drawing.Size(94, 21);
            this.cbbStopBits.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Client name";
            // 
            // txbClientName
            // 
            this.txbClientName.Location = new System.Drawing.Point(80, 248);
            this.txbClientName.Name = "txbClientName";
            this.txbClientName.Size = new System.Drawing.Size(139, 20);
            this.txbClientName.TabIndex = 14;
            // 
            // rtxbgui
            // 
            this.rtxbgui.BackColor = System.Drawing.Color.SandyBrown;
            this.rtxbgui.Location = new System.Drawing.Point(286, 314);
            this.rtxbgui.Name = "rtxbgui";
            this.rtxbgui.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rtxbgui.Size = new System.Drawing.Size(611, 54);
            this.rtxbgui.TabIndex = 16;
            this.rtxbgui.Text = "";
            // 
            // btncreate
            // 
            this.btncreate.Location = new System.Drawing.Point(15, 274);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(75, 23);
            this.btncreate.TabIndex = 17;
            this.btncreate.Text = "Kết nối";
            this.btncreate.UseVisualStyleBackColor = true;
            this.btncreate.Click += new System.EventHandler(this.btncreate_Click);
            // 
            // btnEXit
            // 
            this.btnEXit.Location = new System.Drawing.Point(105, 274);
            this.btnEXit.Name = "btnEXit";
            this.btnEXit.Size = new System.Drawing.Size(75, 23);
            this.btnEXit.TabIndex = 18;
            this.btnEXit.Text = "Thoát";
            this.btnEXit.UseVisualStyleBackColor = true;
            this.btnEXit.Click += new System.EventHandler(this.btnEXit_Click);
            // 
            // btnsend
            // 
            this.btnsend.Location = new System.Drawing.Point(822, 374);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(75, 23);
            this.btnsend.TabIndex = 19;
            this.btnsend.Text = "Gửi";
            this.btnsend.UseVisualStyleBackColor = true;
            this.btnsend.Click += new System.EventHandler(this.btnsend_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Người nhận";
            // 
            // txbNgNhan
            // 
            this.txbNgNhan.Location = new System.Drawing.Point(73, 310);
            this.txbNgNhan.Name = "txbNgNhan";
            this.txbNgNhan.Size = new System.Drawing.Size(146, 20);
            this.txbNgNhan.TabIndex = 23;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(186, 274);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 24;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // noidung
            // 
            this.noidung.AutoScroll = true;
            this.noidung.Location = new System.Drawing.Point(286, 12);
            this.noidung.Name = "noidung";
            this.noidung.Size = new System.Drawing.Size(630, 300);
            this.noidung.TabIndex = 25;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 414);
            this.Controls.Add(this.noidung);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.txbNgNhan);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.btnEXit);
            this.Controls.Add(this.btncreate);
            this.Controls.Add(this.rtxbgui);
            this.Controls.Add(this.txbClientName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Client";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPortName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbparity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbhandshake;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txbBaudRate;
        private System.Windows.Forms.TextBox txbdataBits;
        private System.Windows.Forms.ComboBox cbbStopBits;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbClientName;
        private System.Windows.Forms.RichTextBox rtxbgui;
        private System.Windows.Forms.Button btncreate;
        private System.Windows.Forms.Button btnEXit;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txbNgNhan;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.FlowLayoutPanel noidung;
    }
}



namespace SmsAPP
{
    partial class FrmSMS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSMS));
            this.cmboSelect = new System.Windows.Forms.ComboBox();
            this.messageViewBox = new System.Windows.Forms.DataGridView();
            this.btnHelp = new System.Windows.Forms.Button();
            this.bthNewmessage = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxHelp = new System.Windows.Forms.PictureBox();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnSelectSender = new System.Windows.Forms.Button();
            this.lblSender = new System.Windows.Forms.Label();
            this.PnlHelp = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTmr = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.messageViewBox)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).BeginInit();
            this.PnlHelp.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmboSelect
            // 
            this.cmboSelect.FormattingEnabled = true;
            this.cmboSelect.Location = new System.Drawing.Point(13, 55);
            this.cmboSelect.Name = "cmboSelect";
            this.cmboSelect.Size = new System.Drawing.Size(121, 21);
            this.cmboSelect.TabIndex = 0;
            this.cmboSelect.SelectedValueChanged += new System.EventHandler(this.cmboSelect_SelectedValueChanged);
            // 
            // messageViewBox
            // 
            this.messageViewBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.messageViewBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.messageViewBox.Location = new System.Drawing.Point(315, 0);
            this.messageViewBox.Name = "messageViewBox";
            this.messageViewBox.Size = new System.Drawing.Size(428, 350);
            this.messageViewBox.TabIndex = 1;
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.White;
            this.btnHelp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHelp.BackgroundImage")));
            this.btnHelp.Location = new System.Drawing.Point(398, 22);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(56, 58);
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "Help ";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // bthNewmessage
            // 
            this.bthNewmessage.Location = new System.Drawing.Point(197, 3);
            this.bthNewmessage.Name = "bthNewmessage";
            this.bthNewmessage.Size = new System.Drawing.Size(97, 58);
            this.bthNewmessage.TabIndex = 4;
            this.bthNewmessage.Text = "New Message";
            this.bthNewmessage.UseVisualStyleBackColor = true;
            this.bthNewmessage.Click += new System.EventHandler(this.SndMsgBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBoxHelp);
            this.panel1.Controls.Add(this.bthNewmessage);
            this.panel1.Controls.Add(this.btnHelp);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 350);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 80);
            this.panel1.TabIndex = 5;
            // 
            // pictureBoxHelp
            // 
            this.pictureBoxHelp.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelp.Image")));
            this.pictureBoxHelp.Location = new System.Drawing.Point(129, 3);
            this.pictureBoxHelp.Name = "pictureBoxHelp";
            this.pictureBoxHelp.Size = new System.Drawing.Size(62, 58);
            this.pictureBoxHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHelp.TabIndex = 5;
            this.pictureBoxHelp.TabStop = false;
            this.pictureBoxHelp.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(13, 158);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(100, 20);
            this.txtBox.TabIndex = 6;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnSelectSender
            // 
            this.btnSelectSender.Location = new System.Drawing.Point(59, 82);
            this.btnSelectSender.Name = "btnSelectSender";
            this.btnSelectSender.Size = new System.Drawing.Size(75, 23);
            this.btnSelectSender.TabIndex = 7;
            this.btnSelectSender.Text = "Ok";
            this.btnSelectSender.UseVisualStyleBackColor = true;
            this.btnSelectSender.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Location = new System.Drawing.Point(13, 36);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(41, 13);
            this.lblSender.TabIndex = 8;
            this.lblSender.Text = "Sender";
            // 
            // PnlHelp
            // 
            this.PnlHelp.Controls.Add(this.textBox1);
            this.PnlHelp.Controls.Add(this.btnOK);
            this.PnlHelp.Location = new System.Drawing.Point(543, 12);
            this.PnlHelp.Name = "PnlHelp";
            this.PnlHelp.Size = new System.Drawing.Size(200, 297);
            this.PnlHelp.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 262);
            this.textBox1.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(122, 271);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "All Good";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTmr
            // 
            this.lblTmr.AutoSize = true;
            this.lblTmr.Location = new System.Drawing.Point(16, 302);
            this.lblTmr.Name = "lblTmr";
            this.lblTmr.Size = new System.Drawing.Size(0, 13);
            this.lblTmr.TabIndex = 10;
            // 
            // FrmSMS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 430);
            this.Controls.Add(this.lblTmr);
            this.Controls.Add(this.PnlHelp);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.btnSelectSender);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.messageViewBox);
            this.Controls.Add(this.cmboSelect);
            this.Controls.Add(this.panel1);
            this.Name = "FrmSMS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SMS";
            this.Load += new System.EventHandler(this.FrmSMS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.messageViewBox)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelp)).EndInit();
            this.PnlHelp.ResumeLayout(false);
            this.PnlHelp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmboSelect;
        private System.Windows.Forms.DataGridView messageViewBox;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button bthNewmessage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnSelectSender;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.PictureBox pictureBoxHelp;
        private System.Windows.Forms.Panel PnlHelp;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTmr;
    }
}


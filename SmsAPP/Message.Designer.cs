
namespace SmsAPP
{
    partial class Message
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
            this.btnSndMsg = new System.Windows.Forms.Button();
            this.TextMessage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnAddAudio = new System.Windows.Forms.Button();
            this.btnAddVideo = new System.Windows.Forms.Button();
            this.btnAddPhoto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.brnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSndMsg
            // 
            this.btnSndMsg.Location = new System.Drawing.Point(147, 362);
            this.btnSndMsg.Name = "btnSndMsg";
            this.btnSndMsg.Size = new System.Drawing.Size(75, 23);
            this.btnSndMsg.TabIndex = 0;
            this.btnSndMsg.Text = "Send";
            this.btnSndMsg.UseVisualStyleBackColor = true;
            this.btnSndMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // TextMessage
            // 
            this.TextMessage.Location = new System.Drawing.Point(12, 167);
            this.TextMessage.Multiline = true;
            this.TextMessage.Name = "TextMessage";
            this.TextMessage.Size = new System.Drawing.Size(210, 145);
            this.TextMessage.TabIndex = 1;
            this.TextMessage.TextChanged += new System.EventHandler(this.TxtBoxMessageBox_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(210, 138);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnAddAudio
            // 
            this.btnAddAudio.Location = new System.Drawing.Point(79, 318);
            this.btnAddAudio.Name = "btnAddAudio";
            this.btnAddAudio.Size = new System.Drawing.Size(75, 23);
            this.btnAddAudio.TabIndex = 3;
            this.btnAddAudio.Text = "Add Audio";
            this.btnAddAudio.UseVisualStyleBackColor = true;
            this.btnAddAudio.Click += new System.EventHandler(this.btnAddAudio_Click);
            // 
            // btnAddVideo
            // 
            this.btnAddVideo.Location = new System.Drawing.Point(12, 318);
            this.btnAddVideo.Name = "btnAddVideo";
            this.btnAddVideo.Size = new System.Drawing.Size(71, 23);
            this.btnAddVideo.TabIndex = 4;
            this.btnAddVideo.Text = "Add Video";
            this.btnAddVideo.UseVisualStyleBackColor = true;
            this.btnAddVideo.Click += new System.EventHandler(this.btnAddVideo_Click);
            // 
            // btnAddPhoto
            // 
            this.btnAddPhoto.Location = new System.Drawing.Point(147, 318);
            this.btnAddPhoto.Name = "btnAddPhoto";
            this.btnAddPhoto.Size = new System.Drawing.Size(75, 23);
            this.btnAddPhoto.TabIndex = 5;
            this.btnAddPhoto.Text = "Add Photo";
            this.btnAddPhoto.UseVisualStyleBackColor = true;
            this.btnAddPhoto.Click += new System.EventHandler(this.btnAddPhoto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Receipient";
            // 
            // brnReturn
            // 
            this.brnReturn.Location = new System.Drawing.Point(12, 362);
            this.brnReturn.Name = "brnReturn";
            this.brnReturn.Size = new System.Drawing.Size(75, 23);
            this.brnReturn.TabIndex = 7;
            this.brnReturn.Text = "Return";
            this.brnReturn.UseVisualStyleBackColor = true;
            this.brnReturn.Click += new System.EventHandler(this.brnReturn_Click);
            // 
            // Message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 485);
            this.Controls.Add(this.brnReturn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPhoto);
            this.Controls.Add(this.btnAddVideo);
            this.Controls.Add(this.btnAddAudio);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TextMessage);
            this.Controls.Add(this.btnSndMsg);
            this.MaximizeBox = false;
            this.Name = "Message";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Message";
            this.Load += new System.EventHandler(this.Message_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSndMsg;
        private System.Windows.Forms.TextBox TextMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAddAudio;
        private System.Windows.Forms.Button btnAddVideo;
        private System.Windows.Forms.Button btnAddPhoto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button brnReturn;
    }
}
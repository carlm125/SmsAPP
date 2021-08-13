 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SmsAPP
{
   
    public partial class Message : Form
    {
        public Message()
        {
            InitializeComponent();
        }

        public string recipientnameguid;
        public mmsclass mymessageob = new mmsclass();
        private void btnSendMsg_Click(object sender, EventArgs e)
        {
            if( TextMessage.Text == "")
            {
                MessageBox.Show("Cannot send blank message");
                return;
            }
            else
            {

            }
          
        }

        private void TxtBoxMessageBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Message_Load(object sender, EventArgs e)
        {
             TextMessage.Text = mymessageob.recipientnameguid;
            TextMessage.Focus();
            
        }

        private void brnReturn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnAddAudio_Click(object sender, EventArgs e)
        {

        }

        private void btnAddPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}

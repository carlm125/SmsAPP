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
    public partial class FrmSMS : Form
    {
        public FrmSMS()
        {
            InitializeComponent();
        }
        private void testifopen()
        {
            if (dbconn.State != ConnectionState.Open)
            {
                dbconn.Open();
            }
        }


        public SQLiteConnection dbconn = new SQLiteConnection(@"data source = C:\\Data\\SMS.db");
        // DataTable myDataTable = new DataTable();
        DataTable mymessageViewBox = new DataTable();

        public mmsclass mySendMessage = new mmsclass();

        private void FrmSMS_Load(object sender, EventArgs e)
        {
            dbconn.Open();
            FetchRecipientData();



            /// fill the DT with the Data 

            // Set the Datasource to our "recieved" data

            timer1.Enabled = true;
        }

        private void FetchRecipientData()
        {
         SQLiteConnection dbconn = new SQLiteConnection(@"data source = C:\\Data\\SMS.db"); //Establish a connection with our created DB
        dbconn.Open();



            string CommandText = "SELECT * FROM Recipient";  // SQL command to pass to DataAdaptor
        SQLiteDataAdapter sqlda = new SQLiteDataAdapter(CommandText, dbconn); // Run the DA

        DataTable myDataTable = new DataTable();  // Create a placeholder object to recieve the incoming data

        sqlda.Fill(myDataTable);
           
            cmboSelect.ValueMember = "guid";    // set the combox to use this field as it value
            cmboSelect.DisplayMember = "recipientname"; // set this as the field from the DT to show the user
            cmboSelect.DataSource = myDataTable;

        }

    private void cmboSelect_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
               
                txtBox.Text = cmboSelect.SelectedValue.ToString();

                string CommandText = "SELECT text FROM sms LEFT JOIN Recipient on Recipient.guid = recipientnameguid WHERE recipientnameguid = ' " + txtBox.Text + "'";
                SQLiteDataAdapter sqlda2 = new SQLiteDataAdapter(CommandText, dbconn);

                DataTable mymessageViewBox = new DataTable();
                sqlda2.Fill(mymessageViewBox);
                messageViewBox.DataSource = mymessageViewBox;
            }


            catch
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            messageViewBox.Visible = true;
          //  messageViewBox.
        }

        private void SndMsgBtn_Click(object sender, EventArgs e)
        {
            if (cmboSelect.SelectedValue.ToString() == "")
            {
            }
            else
            {

           
                mySendMessage.recipientnameguid = cmboSelect.SelectedValue.ToString();
                
                Message myNewMessage = new Message();
                myNewMessage.mymessageob = mySendMessage;
                myNewMessage.ShowDialog();

                
                Guid myguid = Guid.NewGuid();
                SQLiteCommand sqliteCommand2Execute;
                sqliteCommand2Execute = dbconn.CreateCommand();
                sqliteCommand2Execute.CommandText = "INSERT INTO sms  (guid, recipientnameguid, text ) VALUES('" + myguid.ToString() + "' , '" + myNewMessage.receipientnameguid + "); '";
                sqliteCommand2Execute.ExecuteNonQuery();


                //dbconn.Close();
                myNewMessage.Dispose();
                FetchRecipientData();




            }
           






    //        CREATE TABLE "sms"(
    //"uid"   INTEGER,
    //"guid"  TEXT,
    //"recipientnameguid" TEXT,
    //"text"  TEXT,
    //"audio" BLOB,
    //"video" BLOB,
    //"picture"   BLOB,
    //"Sent"  INTEGER DEFAULT 0,
    //"sendernameguid"    INTEGER,
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PnlHelp.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            PnlHelp.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTmr.Text = lblTmr.Text + " ";
            FetchRecipientData();
        }
    }
}
           










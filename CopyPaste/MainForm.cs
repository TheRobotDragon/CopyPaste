using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyPaste
{
    public partial class MainForm : Form
    {
        // Get a new address from myjson.com
        private const string API_ADDRESS = "https://api.myjson.com/bins/eg34t";

        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                data data = new data();
                tbText.Text = Clipboard.GetText();
                data.text = tbText.Text;
                wc.Headers.Add("Content-Type", "application/json");
                wc.UploadString(API_ADDRESS, "PUT", JsonConvert.SerializeObject(data));

            }
        }

        private void BtnRetrieve_Click(object sender, EventArgs e)
        {
            using (WebClient wc = new WebClient())
            {
                var json = wc.DownloadString(API_ADDRESS);

                var data = JsonConvert.DeserializeObject<data>(json);

                tbText.Text = data.text;
                Clipboard.SetText(data.text);
            }
        }
    }
}

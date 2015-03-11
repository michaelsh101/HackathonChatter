using System;
using System.Windows.Forms;
using ClientWPF.Utiity;
using FrameWork;

namespace videochatsample
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            listBox1.Items.AddRange(new[]{Globals.USER_1, Globals.USER_2, Globals.USER_3});
            //RealSenseHandler.Instace.WaveFired += data => btnConnect.Text = "Wave!";
            RealSenseHandler.Instace.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChatForm frm = new ChatForm();
            
            Hide();
            frm.textUserID.Text = listBox1.SelectedItem.ToString();
            frm.Show();
        }
    }
}

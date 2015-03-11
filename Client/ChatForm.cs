using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using Client;
using ClientWPF.Utiity;
using FrameWork;

namespace videochatsample
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class ChatForm : System.Windows.Forms.Form
    {
        #region Windows Form Designer generated code

        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbovideodevice;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboaudiodevice;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox chksendvideo;
        private System.Windows.Forms.CheckBox chksendaudio;
        private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label15;
        public System.Windows.Forms.TextBox textUserID;
		private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox chkreceiveaudio;
        private System.Windows.Forms.CheckBox chkreceivevideo;
        private AxVideoChatReceiverLib.AxVideoChatReceiver axVideoChatReceiver1;
        private System.ComponentModel.Container components = null;
        private AxVideoChatSenderLib.AxVideoChatSender sndrMeScreen;
        private Button button2;
        private Label lblTest;
        public bool bClickChangeVideoFormat;

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.label1 = new System.Windows.Forms.Label();
            this.cbovideodevice = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboaudiodevice = new System.Windows.Forms.ComboBox();
            this.chksendvideo = new System.Windows.Forms.CheckBox();
            this.chksendaudio = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textUserID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sndrMeScreen = new AxVideoChatSenderLib.AxVideoChatSender();
            this.axVideoChatReceiver1 = new AxVideoChatReceiverLib.AxVideoChatReceiver();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.chkreceiveaudio = new System.Windows.Forms.CheckBox();
            this.chkreceivevideo = new System.Windows.Forms.CheckBox();
            this.lblTest = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sndrMeScreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Video Device";
            // 
            // cbovideodevice
            // 
            this.cbovideodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbovideodevice.Location = new System.Drawing.Point(71, 17);
            this.cbovideodevice.Name = "cbovideodevice";
            this.cbovideodevice.Size = new System.Drawing.Size(134, 20);
            this.cbovideodevice.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Audio Device";
            // 
            // cboaudiodevice
            // 
            this.cboaudiodevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboaudiodevice.Location = new System.Drawing.Point(71, 42);
            this.cboaudiodevice.Name = "cboaudiodevice";
            this.cboaudiodevice.Size = new System.Drawing.Size(134, 20);
            this.cboaudiodevice.TabIndex = 4;
            // 
            // chksendvideo
            // 
            this.chksendvideo.Checked = true;
            this.chksendvideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendvideo.Location = new System.Drawing.Point(20, 78);
            this.chksendvideo.Name = "chksendvideo";
            this.chksendvideo.Size = new System.Drawing.Size(128, 16);
            this.chksendvideo.TabIndex = 12;
            this.chksendvideo.Text = "Send Video Stream";
            // 
            // chksendaudio
            // 
            this.chksendaudio.Checked = true;
            this.chksendaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chksendaudio.Location = new System.Drawing.Point(20, 100);
            this.chksendaudio.Name = "chksendaudio";
            this.chksendaudio.Size = new System.Drawing.Size(128, 26);
            this.chksendaudio.TabIndex = 13;
            this.chksendaudio.Text = "Send Audio Stream";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 132);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 40);
            this.button1.TabIndex = 28;
            this.button1.Text = "Connect";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textUserID);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbovideodevice);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboaudiodevice);
            this.groupBox1.Controls.Add(this.chksendaudio);
            this.groupBox1.Controls.Add(this.chksendvideo);
            this.groupBox1.Location = new System.Drawing.Point(12, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 270);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connect";
            // 
            // textUserID
            // 
            this.textUserID.Location = new System.Drawing.Point(89, 224);
            this.textUserID.Name = "textUserID";
            this.textUserID.Size = new System.Drawing.Size(102, 18);
            this.textUserID.TabIndex = 4;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(23, 224);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 16);
            this.label15.TabIndex = 3;
            this.label15.Text = "User ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(117, 132);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 40);
            this.button2.TabIndex = 29;
            this.button2.Text = "Disconnect";
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTest);
            this.groupBox2.Controls.Add(this.sndrMeScreen);
            this.groupBox2.Controls.Add(this.axVideoChatReceiver1);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.chkreceiveaudio);
            this.groupBox2.Controls.Add(this.chkreceivevideo);
            this.groupBox2.Location = new System.Drawing.Point(18, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(547, 358);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Listen";
            // 
            // sndrMeScreen
            // 
            this.sndrMeScreen.Enabled = true;
            this.sndrMeScreen.Location = new System.Drawing.Point(421, 175);
            this.sndrMeScreen.Name = "sndrMeScreen";
            this.sndrMeScreen.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("sndrMeScreen.OcxState")));
            this.sndrMeScreen.Size = new System.Drawing.Size(100, 86);
            this.sndrMeScreen.TabIndex = 11;
            // 
            // axVideoChatReceiver1
            // 
            this.axVideoChatReceiver1.Enabled = true;
            this.axVideoChatReceiver1.Location = new System.Drawing.Point(6, 17);
            this.axVideoChatReceiver1.Name = "axVideoChatReceiver1";
            this.axVideoChatReceiver1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axVideoChatReceiver1.OcxState")));
            this.axVideoChatReceiver1.Size = new System.Drawing.Size(407, 324);
            this.axVideoChatReceiver1.TabIndex = 10;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(437, 108);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 32);
            this.button4.TabIndex = 8;
            this.button4.Text = "Disconnect";
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(445, 69);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 32);
            this.button3.TabIndex = 7;
            this.button3.Text = "Start Listening";
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chkreceiveaudio
            // 
            this.chkreceiveaudio.Checked = true;
            this.chkreceiveaudio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceiveaudio.Location = new System.Drawing.Point(419, 40);
            this.chkreceiveaudio.Name = "chkreceiveaudio";
            this.chkreceiveaudio.Size = new System.Drawing.Size(128, 16);
            this.chkreceiveaudio.TabIndex = 6;
            this.chkreceiveaudio.Text = "Received Audio Stream";
            // 
            // chkreceivevideo
            // 
            this.chkreceivevideo.Checked = true;
            this.chkreceivevideo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkreceivevideo.Location = new System.Drawing.Point(421, 17);
            this.chkreceivevideo.Name = "chkreceivevideo";
            this.chkreceivevideo.Size = new System.Drawing.Size(120, 16);
            this.chkreceivevideo.TabIndex = 5;
            this.chkreceivevideo.Text = "Receive Video Stream";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(443, 296);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(31, 12);
            this.lblTest.TabIndex = 12;
            this.lblTest.Text = "lblTest";
            // 
            // ChatForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(4, 11);
            this.ClientSize = new System.Drawing.Size(568, 378);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Arial", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.Name = "ChatForm";
            this.Text = "Video Chat  ActiveX Control ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChatForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sndrMeScreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axVideoChatReceiver1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

	    private VolumeControler vc;
	    private long lngMuteTime;

        public ChatForm()
		{
			InitializeComponent();
            vc = new VolumeControler();
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new LoginForm());
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
		    RealSenseHandler.Instace.WaveFired += (data) =>
		    {
		        this.lblTest.Text = "hello!";
		    };

            RealSenseHandler.Instace.ThumbUpFired += (data) =>
            {
                vc.IncreaseVol();
                this.lblTest.Text = "ThumbsUp!";
            };

            RealSenseHandler.Instace.ThumbDownFired += (data) =>
            {
                vc.DecreaseVol();
                this.lblTest.Text = "ThumbsDown!";
            };

		    RealSenseHandler.Instace.SpreadFingersFired += (data) =>
		    {

		        var dateTime = DateTime.Now.Ticks/TimeSpan.TicksPerMillisecond;
		        if (dateTime - lngMuteTime > 5*1000)
		        {
		            vc.Mute();
		            this.lblTest.Text = "No sound";
		            lngMuteTime = dateTime;
		        }
		    };

            RealSenseHandler.Instace.FistFired += (data) =>
            {
                sndrMeScreen.Disconnect();
            };

            this.groupBox1.Hide();

			int ivideodevicecount;
			int iaudiodevicecount;

			int i;

            // Get video devices
            ivideodevicecount = sndrMeScreen.GetVideoDeviceCount();
			for(i=0; i<ivideodevicecount; i++)
                cbovideodevice.Items.Add(sndrMeScreen.GetVideoDeviceName((short)i));
			if(cbovideodevice.Items.Count >0)
				cbovideodevice.SelectedIndex=0;
            
            // Get audio devices
            iaudiodevicecount = sndrMeScreen.GetAudioDeviceCount();
			for(i=0; i< iaudiodevicecount;i++)
                cboaudiodevice.Items.Add(sndrMeScreen.GetAudioDeviceName((short)i));
			if(cboaudiodevice.Items.Count >0)
				cboaudiodevice.SelectedIndex=0;

            ConnectUser();
    	}

        private void ConnectUser()
        {
            sndrMeScreen.VideoDevice = (short)cbovideodevice.SelectedIndex;
            sndrMeScreen.AudioDevice = (short)cboaudiodevice.SelectedIndex;

            sndrMeScreen.VideoFormat = (short)2;
            sndrMeScreen.FrameRate = 25;
            sndrMeScreen.VideoBitrate = 128000;
            sndrMeScreen.AudioComplexity = (short)0;
            sndrMeScreen.AudioQuality = (short)0;
            sndrMeScreen.SendAudioStream = chksendaudio.Checked;
            sndrMeScreen.SendVideoStream = chksendvideo.Checked;

            sndrMeScreen.ConferenceNumber = Convert.ToInt32(Globals.CONF_NO);
            sndrMeScreen.ConferenceUserID = Convert.ToInt32(textUserID.Text);

            int iResult = sndrMeScreen.Connect(Globals.SERVER_IP, Globals.SERVER_PORT);
        }

        // Connect user
		private void button1_Click(object sender, System.EventArgs e)
		{
            ConnectUser();
		}

        // Start listening
		private void button3_Click(object sender, System.EventArgs e)
		{
            axVideoChatReceiver1.VideoWindowAutoMax = true;
            axVideoChatReceiver1.ReceiveAudioStream = chkreceivevideo.Checked;
            axVideoChatReceiver1.ReceiveVideoStream = chkreceivevideo.Checked;
            axVideoChatReceiver1.ConferenceNumber = Convert.ToInt32(Globals.CONF_NO);
            axVideoChatReceiver1.ConferenceUserID = Convert.ToInt32(textUserID.Text);

            bool bResult = axVideoChatReceiver1.Listen(Globals.SERVER_IP, Globals.SERVER_PORT);

            button3.Enabled = false;
            button4.Enabled = true;
		}

        // Disconnect user
		private void button2_Click(object sender, System.EventArgs e)
		{
            sndrMeScreen.Disconnect();
		}

        // Stop listening
		private void button4_Click(object sender, System.EventArgs e)
		{
            axVideoChatReceiver1.Disconnect();

            button3.Enabled = true;
            button4.Enabled = false;
		}

        private void ChatForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            sndrMeScreen.Disconnect();
            RealSenseHandler.Instace.Dispose();
            Application.Exit();
        }       
	}
}

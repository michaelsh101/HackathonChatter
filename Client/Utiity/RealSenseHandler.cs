using System;
using System.Drawing;
using System.Threading;
using Client;
using videochatsample;

namespace ClientWPF.Utiity
{
    public class RealSenseHandler : IDisposable
    {
        #region Singleton

        private static RealSenseHandler _instance;

        public static RealSenseHandler Instace
        {
            get { return _instance ?? (_instance = new RealSenseHandler()); }
        }

        #endregion

        #region Events

        public event Action<PXCMHandData> WaveFired = data => { };
        public event Action<PXCMHandData> TapFired = data => { };
        public event Action<PXCMHandData> ThumbUpFired = data => { };
        public event Action<PXCMHandData> ThumbDownFired = data => { };
        public event Action<PXCMHandData> ZoomInFired = data => { };
        public event Action<PXCMHandData> SpreadFingersFired = data => { };
        public event Action<PXCMHandData> FistFired = data => { };

 
        #endregion

        private RealSenseHandler()
	    {
            // Instantiate and initialize the SenseManager
            senseManager = PXCMSenseManager.CreateInstance();
            //_senseManager.EnableStream(PXCMCapture.StreamType.STREAM_TYPE_COLOR, 640, 480, 30);
            senseManager.EnableHand();
            senseManager.Init();

            // Configure the Hand Module
            hand = senseManager.QueryHand();
            handConfig = hand.CreateActiveConfiguration();
            //handConfig.EnableGesture("wave");
            handConfig.EnableAllGestures();
            handConfig.EnableAllAlerts();
            handConfig.ApplyChanges();

            // Start the worker thread
            processingThread = new Thread(new ThreadStart(ProcessFrame));
	    }

        #region Data Members

        private long lngMuteTime;
        private Thread processingThread;
        private PXCMSenseManager senseManager;
        private PXCMHandModule hand;
        private PXCMHandConfiguration handConfig;
        private PXCMHandData handData;
        private PXCMHandData.GestureData gestureData;
        private bool handWaving;
        private bool handFist;
        private bool handTap;
        private bool thumbUp;
        private bool thumbDown;
        private bool handSpread;
        private bool zoomIn;
        private bool handSwipe;
        private bool handTrigger;
        private int msgTimer;

        #endregion

        public void Start()
        {
            processingThread.Start();
        }

        private void ProcessFrame()
        {
            // Start AcquireFrame/ReleaseFrame loop
            while (senseManager.AcquireFrame(true) >= pxcmStatus.PXCM_STATUS_NO_ERROR)
            {
                /*    PXCMCapture.Sample sample = senseManager.QuerySample();

                // Retrieve gesture data
                hand = senseManager.QueryHand();

                if (hand != null)
                {
                    // Retrieve the most recent processed data
                    handData = hand.CreateOutput();
                    handData.Update();
                    if (handData.IsGestureFired("wave", out gestureData))
                        WaveFired(handData);
                }

                // Release the frame
                if (handData != null) handData.Dispose();
                    senseManager.ReleaseFrame();
            }*/

                PXCMCapture.Sample sample = senseManager.QuerySample();
                Bitmap colorBitmap;
                PXCMImage.ImageData colorData;

                // Get color image data
                /*sample.color.AcquireAccess(PXCMImage.Access.ACCESS_READ, PXCMImage.PixelFormat.PIXEL_FORMAT_RGB24,
                    out colorData);
                colorBitmap = colorData.ToBitmap(0, sample.color.info.width, sample.color.info.height);*/

                // Retrieve gesture data
                hand = senseManager.QueryHand();

                if (hand != null)
                {
                    // Retrieve the most recent processed data
                    handData = hand.CreateOutput();
                    handData.Update();
                    if (handData.IsGestureFired("wave", out gestureData))
                        WaveFired(handData);
                    if (handData.IsGestureFired("tap", out gestureData))
                        TapFired(handData);
                    if (handData.IsGestureFired("thumb_up", out gestureData))
                        ThumbUpFired(handData);
                    if (handData.IsGestureFired("zoom_in", out gestureData))
                        ZoomInFired(handData);
                    if (handData.IsGestureFired("thumb_down", out gestureData))
                        ThumbDownFired(handData);
                    if (handData.IsGestureFired("spreadfingers", out gestureData))
                        SpreadFingersFired(handData);
                    if (handData.IsGestureFired("fist", out gestureData))
                        FistFired(handData);
                }

                // Update the user interface
                //UpdateUI(colorBitmap);

                // Release the frame
                if (handData != null) handData.Dispose();
                //colorBitmap.Dispose();
                //sample.color.ReleaseAccess(colorData);
                senseManager.ReleaseFrame();
            }
        }

        public void Dispose()
        {
            if (handData != null) handData.Dispose();
                handConfig.Dispose();
            //senseManager.Dispose();
        }

        private void UpdateUI(Bitmap bitmap)
        {
            /*this.Dispatcher.Invoke(System.Windows.Threading.DispatcherPriority.Normal, new Action(delegate()
            {
                if (bitmap != null)
                {
                    // Mirror the color stream Image control
                    imgColorStream.RenderTransformOrigin = new System.Windows.Point(0.5, 0.5);
                    ScaleTransform mainTransform = new ScaleTransform();
                    mainTransform.ScaleX = -1;
                    mainTransform.ScaleY = 1;
                    imgColorStream.RenderTransform = mainTransform;
                    VolumeControlerForm vc = new VolumeControlerForm;


                    // Display the color stream
                    imgColorStream.Source = ConvertBitmap.BitmapToBitmapSource(bitmap);

                    // Update the screen message
                    if (thumbUp)
                    {
                        vc.IncreaseVol();
                        lblMessage.Content = "thumb up";
                        handTrigger = true;

                    }
                    if (handSpread)
                    {
                        var dateTime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
                        if (dateTime - lngMuteTime > 5 * 1000)
                        {
                            vc.Mute();
                            lblMessage.Content = "Leonid";
                            handTrigger = true;
                            lngMuteTime = dateTime;
                        }

                    }
                    if (thumbDown)
                    {
                        vc.DecreaseVol();
                        lblMessage.Content = "zooooom";
                        handTrigger = true;
                    }
                    if (zoomIn)
                    {
                        lblMessage.Content = "asfsasd";
                        handTrigger = true;
                    }

                    // Reset the screen message after ~50 frames
                    if (handTrigger)
                    {
                        msgTimer++;

                        if (msgTimer >= 50)
                        {
                            lblMessage.Content = "(Wave Your Hand)";
                            msgTimer = 0;
                            handTrigger = false;
                        }
                    }
                }
            }));*/
        }
    }
}

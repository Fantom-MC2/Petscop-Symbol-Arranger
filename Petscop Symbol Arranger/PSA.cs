using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

#region NOTES
/// Background matches Form size
/// Symbol Rotation
/// Limit Symbol Movement to Within The Window
/// Image Capture Fucntionality
/// Custom Curser
/// Sounds
/// Music
/// Playback Settings; Mute, Startover, etc. Maybe add more than one track.
/// ORGANIZE CONTROLS; Expanding Panels?
/// Truly Transparent Form (Application Background)
/// 
#endregion

namespace Petscop_Symbol_Arranger
{
    public partial class PSA : Form
    {
        private bool mouseInS1B;
        private bool mouseInS2B;
        private bool mouseInS3B;
        private bool mouseInS4B;
        private bool mouseInS5B;
        private bool mouseInS6B;
        private bool mouseInS7B;
        private bool mouseInS8B;

        private Timer hideTimer;

        public PSA()
        {
            InitializeComponent();
            KeyPreview = true;


            hideTimer = new Timer { Interval = 1 };

            #region Symbol 1 Border
            S1_1.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_2.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_3.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_4.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_5.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_6.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_7.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_8.MouseEnter += new EventHandler(S1_MouseEnter);
            S1_9.MouseEnter += new EventHandler(S1_MouseEnter);

            S1_1.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_2.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_3.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_4.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_5.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_6.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_7.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_8.MouseLeave += new EventHandler(S1_MouseLeave);
            S1_9.MouseLeave += new EventHandler(S1_MouseLeave);

            S1B.MouseEnter += new EventHandler(S1B_MouseEnter);
            S1B.MouseLeave += new EventHandler(S1B_MouseLeave);

            hideTimer.Tick += hideS1B;
            #endregion

            #region Symbol 2 Border
            S2_1.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_2.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_3.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_4.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_5.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_6.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_7.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_8.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_9.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_10.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_11.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_12.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_13.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_14.MouseEnter += new EventHandler(S2_MouseEnter);
            S2_15.MouseEnter += new EventHandler(S2_MouseEnter);

            S2_1.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_2.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_3.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_4.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_5.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_6.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_7.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_8.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_9.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_10.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_11.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_12.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_13.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_14.MouseLeave += new EventHandler(S2_MouseLeave);
            S2_15.MouseLeave += new EventHandler(S2_MouseLeave);

            S2B.MouseEnter += new EventHandler(S2B_MouseEnter);
            S2B.MouseLeave += new EventHandler(S2B_MouseLeave);

            hideTimer.Tick += hideS2B;
            #endregion

            #region Symbol 3 Border
            S3_1.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_2.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_3.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_4.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_5.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_6.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_7.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_8.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_9.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_10.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_11.MouseEnter += new EventHandler(S3_MouseEnter);
            S3_12.MouseEnter += new EventHandler(S3_MouseEnter);

            S3_1.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_2.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_3.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_4.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_5.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_6.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_7.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_8.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_9.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_10.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_11.MouseLeave += new EventHandler(S3_MouseLeave);
            S3_12.MouseLeave += new EventHandler(S3_MouseLeave);

            S3B.MouseEnter += new EventHandler(S3B_MouseEnter);
            S3B.MouseLeave += new EventHandler(S3B_MouseLeave);

            hideTimer.Tick += hideS3B;
            #endregion

            #region Symbol 4 Border
            S4_1.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_2.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_3.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_4.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_5.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_6.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_7.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_8.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_9.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_10.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_11.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_12.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_13.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_14.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_15.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_16.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_17.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_18.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_19.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_20.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_21.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_22.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_23.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_24.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_25.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_26.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_27.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_28.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_29.MouseEnter += new EventHandler(S4_MouseEnter);
            S4_30.MouseEnter += new EventHandler(S4_MouseEnter);

            S4_1.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_2.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_3.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_4.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_5.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_6.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_7.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_8.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_9.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_10.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_11.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_12.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_13.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_14.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_15.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_16.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_17.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_18.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_19.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_20.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_21.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_22.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_23.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_24.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_25.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_26.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_27.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_28.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_29.MouseLeave += new EventHandler(S4_MouseLeave);
            S4_30.MouseLeave += new EventHandler(S4_MouseLeave);

            S4B.MouseEnter += new EventHandler(S4B_MouseEnter);
            S4B.MouseLeave += new EventHandler(S4B_MouseLeave);

            hideTimer.Tick += hideS4B;
            #endregion

            #region Symbol 5 Border
            S5_1.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_2.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_3.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_4.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_5.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_6.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_7.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_8.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_9.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_10.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_11.MouseEnter += new EventHandler(S5_MouseEnter);
            S5_12.MouseEnter += new EventHandler(S5_MouseEnter);

            S5_1.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_2.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_3.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_4.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_5.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_6.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_7.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_8.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_9.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_10.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_11.MouseLeave += new EventHandler(S5_MouseLeave);
            S5_12.MouseLeave += new EventHandler(S5_MouseLeave);

            S5B.MouseEnter += new EventHandler(S5B_MouseEnter);
            S5B.MouseLeave += new EventHandler(S5B_MouseLeave);

            hideTimer.Tick += hideS5B;
            #endregion

            #region Symbol 6 Border
            S6_1.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_2.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_3.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_4.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_5.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_6.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_7.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_8.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_9.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_10.MouseEnter += new EventHandler(S6_MouseEnter);
            S6_11.MouseEnter += new EventHandler(S6_MouseEnter);

            S6_1.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_2.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_3.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_4.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_5.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_6.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_7.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_8.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_9.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_10.MouseLeave += new EventHandler(S6_MouseLeave);
            S6_11.MouseLeave += new EventHandler(S6_MouseLeave);

            S6B.MouseEnter += new EventHandler(S6B_MouseEnter);
            S6B.MouseLeave += new EventHandler(S6B_MouseLeave);

            hideTimer.Tick += hideS6B;
            #endregion

            #region Symbol 7 Border
            S7_1.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_2.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_3.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_4.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_5.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_6.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_7.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_8.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_9.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_10.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_11.MouseEnter += new EventHandler(S7_MouseEnter);
            S7_12.MouseEnter += new EventHandler(S7_MouseEnter);

            S7_1.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_2.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_3.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_4.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_5.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_6.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_7.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_8.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_9.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_10.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_11.MouseLeave += new EventHandler(S7_MouseLeave);
            S7_12.MouseLeave += new EventHandler(S7_MouseLeave);

            S7B.MouseEnter += new EventHandler(S7B_MouseEnter);
            S7B.MouseLeave += new EventHandler(S7B_MouseLeave);

            hideTimer.Tick += hideS7B;
            #endregion

            #region Symbol 8 Border
            S8_1.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_2.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_3.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_4.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_5.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_6.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_7.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_8.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_9.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_10.MouseEnter += new EventHandler(S8_MouseEnter);
            S8_11.MouseEnter += new EventHandler(S8_MouseEnter);

            S8_1.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_2.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_3.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_4.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_5.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_6.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_7.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_8.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_9.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_10.MouseLeave += new EventHandler(S8_MouseLeave);
            S8_11.MouseLeave += new EventHandler(S8_MouseLeave);

            S8B.MouseEnter += new EventHandler(S8B_MouseEnter);
            S8B.MouseLeave += new EventHandler(S8B_MouseLeave);

            hideTimer.Tick += hideS8B;
            #endregion
        }

        #region Symbol 1 Border
        private void S1_MouseEnter(object sender, EventArgs e)
        {
            mouseInS1B = true;
            S1B.Visible = true;
        }

        private void S1_MouseLeave(object sender, EventArgs e)
        {
            mouseInS1B = false;
            S1B.Visible = false;
            hideTimer.Start();
        }

        private void S1B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS1B = true;
            S1B.Visible = true;
        }

        private void S1B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS1B = false;
            S1B.Visible = false;
            hideTimer.Start();
        }

        private void hideS1B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS1B) S1B.Visible = false;
        }
        #endregion

        #region Symbol 2 Border
        private void S2_MouseEnter(object sender, EventArgs e)
        {
            mouseInS2B = true;
            S2B.Visible = true;
        }

        private void S2_MouseLeave(object sender, EventArgs e)
        {
            mouseInS2B = false;
            S2B.Visible = false;
            hideTimer.Start();
        }

        private void S2B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS2B = true;
            S2B.Visible = true;
        }

        private void S2B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS2B = false;
            S2B.Visible = false;
            hideTimer.Start();
        }

        private void hideS2B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS2B) S2B.Visible = false;
        }
        #endregion

        #region Symbol 3 Border
        private void S3_MouseEnter(object sender, EventArgs e)
        {
            mouseInS3B = true;
            S3B.Visible = true;
        }

        private void S3_MouseLeave(object sender, EventArgs e)
        {
            mouseInS3B = false;
            S3B.Visible = false;
            hideTimer.Start();
        }

        private void S3B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS3B = true;
            S3B.Visible = true;
        }

        private void S3B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS3B = false;
            S3B.Visible = false;
            hideTimer.Start();
        }

        private void hideS3B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS3B) S3B.Visible = false;
        }
        #endregion

        #region Symbol 4 Border
        private void S4_MouseEnter(object sender, EventArgs e)
        {
            mouseInS4B = true;
            S4B.Visible = true;
        }

        private void S4_MouseLeave(object sender, EventArgs e)
        {
            mouseInS4B = false;
            S4B.Visible = false;
            hideTimer.Start();
        }

        private void S4B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS4B = true;
            S4B.Visible = true;
        }

        private void S4B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS4B = false;
            S4B.Visible = false;
            hideTimer.Start();
        }

        private void hideS4B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS4B) S4B.Visible = false;
        }
        #endregion

        #region Symbol 5 Border
        private void S5_MouseEnter(object sender, EventArgs e)
        {
            mouseInS5B = true;
            S5B.Visible = true;
        }

        private void S5_MouseLeave(object sender, EventArgs e)
        {
            mouseInS5B = false;
            S5B.Visible = false;
            hideTimer.Start();
        }

        private void S5B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS5B = true;
            S5B.Visible = true;
        }

        private void S5B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS5B = false;
            S5B.Visible = false;
            hideTimer.Start();
        }

        private void hideS5B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS5B) S5B.Visible = false;
        }
        #endregion

        #region Symbol 6 Border
        private void S6_MouseEnter(object sender, EventArgs e)
        {
            mouseInS6B = true;
            S6B.Visible = true;
        }

        private void S6_MouseLeave(object sender, EventArgs e)
        {
            mouseInS6B = false;
            S6B.Visible = false;
            hideTimer.Start();
        }

        private void S6B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS6B = true;
            S6B.Visible = true;
        }

        private void S6B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS6B = false;
            S6B.Visible = false;
            hideTimer.Start();
        }

        private void hideS6B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS6B) S6B.Visible = false;
        }
        #endregion

        #region Symbol 7 Border
        private void S7_MouseEnter(object sender, EventArgs e)
        {
            mouseInS7B = true;
            S7B.Visible = true;
        }

        private void S7_MouseLeave(object sender, EventArgs e)
        {
            mouseInS7B = false;
            S7B.Visible = false;
            hideTimer.Start();
        }

        private void S7B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS7B = true;
            S7B.Visible = true;
        }

        private void S7B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS7B = false;
            S7B.Visible = false;
            hideTimer.Start();
        }

        private void hideS7B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS7B) S7B.Visible = false;
        }
        #endregion

        #region Symbol 8 Border
        private void S8_MouseEnter(object sender, EventArgs e)
        {
            mouseInS8B = true;
            S8B.Visible = true;
        }

        private void S8_MouseLeave(object sender, EventArgs e)
        {
            mouseInS8B = false;
            S8B.Visible = false;
            hideTimer.Start();
        }

        private void S8B_MouseEnter(object sender, EventArgs e)
        {
            mouseInS8B = true;
            S8B.Visible = true;
        }

        private void S8B_MouseLeave(object sender, EventArgs e)
        {
            mouseInS8B = false;
            S8B.Visible = false;
            hideTimer.Start();
        }

        private void hideS8B(object sender, EventArgs e)
        {
            hideTimer.Stop();
            if (!mouseInS8B) S8B.Visible = false;
        }
        #endregion

        private void PSA_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 64, 128); //Metallic Blue
            PSAPanel.BackColor = Color.FromArgb(0, 64, 128); //Mettalic Blue
            PSAMenu.BackColor = Color.FromArgb(255, 218, 255); //Light Pink

            // Disable
            S1B.Visible = false;
            S2B.Visible = false;
            S3B.Visible = false;
            S4B.Visible = false;
            S5B.Visible = false;
            S6B.Visible = false;
            S7B.Visible = false;
            S8B.Visible = false;
        }

        private void SaSi_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveAs = new SaveFileDialog();
            saveAs.Title = "Save PSA Image As...";
            saveAs.FileName = "PSA Arrangement 1";
            saveAs.Filter = "bmp (*.bmp) | *.bmp | png (*.png) | *.png | jpeg (*.jpeg) | *.jpeg";

            if (saveAs.ShowDialog() == DialogResult.OK)
            {
                string path = saveAs.FileName;

                Bitmap bitmap = new Bitmap(PSAPanel.Width, PSAPanel.Height);
                PSAPanel.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
                bitmap.Save(saveAs.FileName);
            }
        }

        private void PSAPanel_CLick(object sender, EventArgs e)
        {
            #region Enable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            //Disable
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        #region Symbol 1 | S1
        private void S1_1_Click(object sender, EventArgs e)
        {
            // Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_2_Click(object sender, EventArgs e)
        {
            // Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_3_Click(object sender, EventArgs e)
        {
            // Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_4_Click(object sender, EventArgs e)
        {
            // Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_5_Click(object sender, EventArgs e)
        {
            //Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_6_Click(object sender, EventArgs e)
        {
            //Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_7_Click(object sender, EventArgs e)
        {
            //Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_8_Click(object sender, EventArgs e)
        {
            //Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S1_9_Click(object sender, EventArgs e)
        {
            //Enable
            S1B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol1_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = false;
            S1_2.Enabled = false;
            S1_3.Enabled = false;
            S1_4.Enabled = false;
            S1_5.Enabled = false;
            S1_6.Enabled = false;
            S1_7.Enabled = false;
            S1_8.Enabled = false;
            S1_9.Enabled = false;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        // Symbol1 KeyDown | WHERE THINGS ARE HAPPENING!
        void Symbol1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S1B.Visible = false;
            #region Movement
            //Integers
            int a = S1B.Location.X;
            int b = S1B.Location.Y;
            int c = S1_1.Location.X;
            int d = S1_1.Location.Y;
            int f = S1_2.Location.X;
            int g = S1_2.Location.Y;
            int h = S1_3.Location.X;
            int i = S1_3.Location.Y;
            int j = S1_4.Location.X;
            int k = S1_4.Location.Y;
            int l = S1_5.Location.X;
            int m = S1_5.Location.Y;
            int n = S1_6.Location.X;
            int o = S1_6.Location.Y;
            int p = S1_7.Location.X;
            int q = S1_7.Location.Y;
            int r = S1_8.Location.X;
            int s = S1_8.Location.Y;
            int t = S1_9.Location.X;
            int u = S1_9.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (S1B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S1B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                }

                //Right
                if (S1B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                }

                //Top
                if (S1B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                }

                //Bottom
                if (S1B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                }
            }

            //Relocation
            S1B.Location = new Point(a, b);
            S1_1.Location = new Point(c, d);
            S1_2.Location = new Point(f, g);
            S1_3.Location = new Point(h, i);
            S1_4.Location = new Point(j, k);
            S1_5.Location = new Point(l, m);
            S1_6.Location = new Point(n, o);
            S1_7.Location = new Point(p, q);
            S1_8.Location = new Point(r, s);
            S1_9.Location = new Point(t, u);
            #endregion
        }
        #endregion

        #region Symbol 2 | S2
        private void S2_1_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_2_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_3_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_4_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_5_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_6_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_7_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_8_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_9_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_10_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_11_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_12_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_13_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_14_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S2_15_Click(object sender, EventArgs e)
        {
            //Enable
            S2B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol2_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = false;
            S2_2.Enabled = false;
            S2_3.Enabled = false;
            S2_4.Enabled = false;
            S2_5.Enabled = false;
            S2_6.Enabled = false;
            S2_7.Enabled = false;
            S2_8.Enabled = false;
            S2_9.Enabled = false;
            S2_10.Enabled = false;
            S2_11.Enabled = false;
            S2_12.Enabled = false;
            S2_13.Enabled = false;
            S2_14.Enabled = false;
            S2_15.Enabled = false;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        //Symbol2 KeyDown
        void Symbol2_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S2B.Visible = false;

            #region Movement
            //Integers
            int a = S2B.Location.X;
            int b = S2B.Location.Y;
            int c = S2_1.Location.X;
            int d = S2_1.Location.Y;
            int f = S2_2.Location.X;
            int g = S2_2.Location.Y;
            int h = S2_3.Location.X;
            int i = S2_3.Location.Y;
            int j = S2_4.Location.X;
            int k = S2_4.Location.Y;
            int l = S2_5.Location.X;
            int m = S2_5.Location.Y;
            int n = S2_6.Location.X;
            int o = S2_6.Location.Y;
            int p = S2_7.Location.X;
            int q = S2_7.Location.Y;
            int r = S2_8.Location.X;
            int s = S2_8.Location.Y;
            int t = S2_9.Location.X;
            int u = S2_9.Location.Y;
            int v = S2_10.Location.X;
            int w = S2_10.Location.Y;
            int x = S2_11.Location.X;
            int y = S2_11.Location.Y;
            int z = S2_12.Location.X;
            int aa = S2_12.Location.Y;
            int ab = S2_13.Location.X;
            int ac = S2_13.Location.Y;
            int ad = S2_14.Location.X;
            int ae = S2_14.Location.Y;
            int af = S2_15.Location.X;
            int ag = S2_15.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (e.KeyCode == Keys.Left) z -= 30;
            else if (e.KeyCode == Keys.Right) z += 30;
            else if (e.KeyCode == Keys.Up) aa -= 30;
            else if (e.KeyCode == Keys.Down) aa += 30;

            if (e.KeyCode == Keys.Left) ab -= 30;
            else if (e.KeyCode == Keys.Right) ab += 30;
            else if (e.KeyCode == Keys.Up) ac -= 30;
            else if (e.KeyCode == Keys.Down) ac += 30;

            if (e.KeyCode == Keys.Left) ad -= 30;
            else if (e.KeyCode == Keys.Right) ad += 30;
            else if (e.KeyCode == Keys.Up) ae -= 30;
            else if (e.KeyCode == Keys.Down) ae += 30;

            if (e.KeyCode == Keys.Left) af -= 30;
            else if (e.KeyCode == Keys.Right) af += 30;
            else if (e.KeyCode == Keys.Up) ag -= 30;
            else if (e.KeyCode == Keys.Down) ag += 30;

            if (S2B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S2B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                    if (e.KeyCode == Keys.Left) z += 30;
                    if (e.KeyCode == Keys.Left) ab += 30;
                    if (e.KeyCode == Keys.Left) ad += 30;
                    if (e.KeyCode == Keys.Left) af += 30;
                }

                //Right
                if (S2B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                    if (e.KeyCode == Keys.Right) z -= 30;
                    if (e.KeyCode == Keys.Right) ab -= 30;
                    if (e.KeyCode == Keys.Right) ad -= 30;
                    if (e.KeyCode == Keys.Right) af -= 30;
                }

                //Top
                if (S2B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                    if (e.KeyCode == Keys.Up) aa += 30;
                    if (e.KeyCode == Keys.Up) ac += 30;
                    if (e.KeyCode == Keys.Up) ae += 30;
                    if (e.KeyCode == Keys.Up) ag += 30;
                }

                //Bottom
                if (S2B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                    if (e.KeyCode == Keys.Down) aa -= 30;
                    if (e.KeyCode == Keys.Down) ac -= 30;
                    if (e.KeyCode == Keys.Down) ae -= 30;
                    if (e.KeyCode == Keys.Down) ag -= 30;
                }
            }

            //Relocation
            S2B.Location = new Point(a, b);
            S2_1.Location = new Point(c, d);
            S2_2.Location = new Point(f, g);
            S2_3.Location = new Point(h, i);
            S2_4.Location = new Point(j, k);
            S2_5.Location = new Point(l, m);
            S2_6.Location = new Point(n, o);
            S2_7.Location = new Point(p, q);
            S2_8.Location = new Point(r, s);
            S2_9.Location = new Point(t, u);
            S2_10.Location = new Point(v, w);
            S2_11.Location = new Point(x, y);
            S2_12.Location = new Point(z, aa);
            S2_13.Location = new Point(ab, ac);
            S2_14.Location = new Point(ad, ae);
            S2_15.Location = new Point(af, ag);
            #endregion
        }
        #endregion

        #region Symbol 3 | S3
        private void S3_1_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_2_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_3_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_4_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_5_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_6_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_7_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_8_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_9_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_10_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_11_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S3_12_Click(object sender, EventArgs e)
        {
            //Enable
            S3B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol3_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = false;
            S3_2.Enabled = false;
            S3_3.Enabled = false;
            S3_4.Enabled = false;
            S3_5.Enabled = false;
            S3_6.Enabled = false;
            S3_7.Enabled = false;
            S3_8.Enabled = false;
            S3_9.Enabled = false;
            S3_10.Enabled = false;
            S3_11.Enabled = false;
            S3_12.Enabled = false;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        //Symbol3 KeyDown
        void Symbol3_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S3B.Visible = false;

            #region Movement
            //Integers
            int a = S3B.Location.X;
            int b = S3B.Location.Y;
            int c = S3_1.Location.X;
            int d = S3_1.Location.Y;
            int f = S3_2.Location.X;
            int g = S3_2.Location.Y;
            int h = S3_3.Location.X;
            int i = S3_3.Location.Y;
            int j = S3_4.Location.X;
            int k = S3_4.Location.Y;
            int l = S3_5.Location.X;
            int m = S3_5.Location.Y;
            int n = S3_6.Location.X;
            int o = S3_6.Location.Y;
            int p = S3_7.Location.X;
            int q = S3_7.Location.Y;
            int r = S3_8.Location.X;
            int s = S3_8.Location.Y;
            int t = S3_9.Location.X;
            int u = S3_9.Location.Y;
            int v = S3_10.Location.X;
            int w = S3_10.Location.Y;
            int x = S3_11.Location.X;
            int y = S3_11.Location.Y;
            int z = S3_12.Location.X;
            int aa = S3_12.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (e.KeyCode == Keys.Left) z -= 30;
            else if (e.KeyCode == Keys.Right) z += 30;
            else if (e.KeyCode == Keys.Up) aa -= 30;
            else if (e.KeyCode == Keys.Down) aa += 30;

            if (S3B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S3B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                    if (e.KeyCode == Keys.Left) z += 30;
                }

                //Right
                if (S3B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                    if (e.KeyCode == Keys.Right) z -= 30;
                }

                //Top
                if (S3B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                    if (e.KeyCode == Keys.Up) aa += 30;
                }

                //Bottom
                if (S3B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                    if (e.KeyCode == Keys.Down) aa -= 30;
                }
            }

            //Relocation
            S3B.Location = new Point(a, b);
            S3_1.Location = new Point(c, d);
            S3_2.Location = new Point(f, g);
            S3_3.Location = new Point(h, i);
            S3_4.Location = new Point(j, k);
            S3_5.Location = new Point(l, m);
            S3_6.Location = new Point(n, o);
            S3_7.Location = new Point(p, q);
            S3_8.Location = new Point(r, s);
            S3_9.Location = new Point(t, u);
            S3_10.Location = new Point(v, w);
            S3_11.Location = new Point(x, y);
            S3_12.Location = new Point(z, aa);
            #endregion
        }


        #endregion

        #region Symbol 4 | S4
        private void S4_1_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_2_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_3_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_4_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_5_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_6_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_7_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_8_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_9_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_10_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_11_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_12_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_13_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_14_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_15_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_16_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_17_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_18_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_19_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_20_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_21_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_22_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_23_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_24_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_25_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_26_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_27_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_28_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_29_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S4_30_Click(object sender, EventArgs e)
        {
            //Enable
            S4B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol4_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = false;
            S4_2.Enabled = false;
            S4_3.Enabled = false;
            S4_4.Enabled = false;
            S4_5.Enabled = false;
            S4_6.Enabled = false;
            S4_7.Enabled = false;
            S4_8.Enabled = false;
            S4_9.Enabled = false;
            S4_10.Enabled = false;
            S4_11.Enabled = false;
            S4_12.Enabled = false;
            S4_13.Enabled = false;
            S4_14.Enabled = false;
            S4_15.Enabled = false;
            S4_16.Enabled = false;
            S4_17.Enabled = false;
            S4_18.Enabled = false;
            S4_19.Enabled = false;
            S4_20.Enabled = false;
            S4_21.Enabled = false;
            S4_22.Enabled = false;
            S4_23.Enabled = false;
            S4_15.Enabled = false;
            S4_25.Enabled = false;
            S4_26.Enabled = false;
            S4_27.Enabled = false;
            S4_28.Enabled = false;
            S4_29.Enabled = false;
            S4_30.Enabled = false;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }


        //Symbol4 KeyDown
        void Symbol4_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S4B.Visible = false;

            #region Movement
            //Integers
            int a = S4B.Location.X;
            int b = S4B.Location.Y;
            int c = S4_1.Location.X;
            int d = S4_1.Location.Y;
            int f = S4_2.Location.X;
            int g = S4_2.Location.Y;
            int h = S4_3.Location.X;
            int i = S4_3.Location.Y;
            int j = S4_4.Location.X;
            int k = S4_4.Location.Y;
            int l = S4_5.Location.X;
            int m = S4_5.Location.Y;
            int n = S4_6.Location.X;
            int o = S4_6.Location.Y;
            int p = S4_7.Location.X;
            int q = S4_7.Location.Y;
            int r = S4_8.Location.X;
            int s = S4_8.Location.Y;
            int t = S4_9.Location.X;
            int u = S4_9.Location.Y;
            int v = S4_10.Location.X;
            int w = S4_10.Location.Y;
            int x = S4_11.Location.X;
            int y = S4_11.Location.Y;
            int z = S4_12.Location.X;
            int aa = S4_12.Location.Y;
            int ab = S4_13.Location.X;
            int ac = S4_13.Location.Y;
            int ad = S4_14.Location.X;
            int ae = S4_14.Location.Y;
            int af = S4_15.Location.X;
            int ag = S4_15.Location.Y;
            int ah = S4_16.Location.X;
            int ai = S4_16.Location.Y;
            int aj = S4_17.Location.X;
            int ak = S4_17.Location.Y;
            int al = S4_18.Location.X;
            int am = S4_18.Location.Y;
            int an = S4_19.Location.X;
            int ao = S4_19.Location.Y;
            int ap = S4_20.Location.X;
            int aq = S4_20.Location.Y;
            int ar = S4_21.Location.X;
            int at = S4_21.Location.Y;
            int au = S4_22.Location.X;
            int av = S4_22.Location.Y;
            int aw = S4_23.Location.X;
            int ax = S4_23.Location.Y;
            int ay = S4_24.Location.X;
            int az = S4_24.Location.Y;
            int ba = S4_25.Location.X;
            int bb = S4_25.Location.Y;
            int bc = S4_26.Location.X;
            int bd = S4_26.Location.Y;
            int be = S4_27.Location.X;
            int bf = S4_27.Location.Y;
            int bg = S4_28.Location.X;
            int bh = S4_28.Location.Y;
            int bi = S4_29.Location.X;
            int bj = S4_29.Location.Y;
            int bk = S4_30.Location.X;
            int bl = S4_30.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (e.KeyCode == Keys.Left) z -= 30;
            else if (e.KeyCode == Keys.Right) z += 30;
            else if (e.KeyCode == Keys.Up) aa -= 30;
            else if (e.KeyCode == Keys.Down) aa += 30;

            if (e.KeyCode == Keys.Left) ab -= 30;
            else if (e.KeyCode == Keys.Right) ab += 30;
            else if (e.KeyCode == Keys.Up) ac -= 30;
            else if (e.KeyCode == Keys.Down) ac += 30;

            if (e.KeyCode == Keys.Left) ad -= 30;
            else if (e.KeyCode == Keys.Right) ad += 30;
            else if (e.KeyCode == Keys.Up) ae -= 30;
            else if (e.KeyCode == Keys.Down) ae += 30;

            if (e.KeyCode == Keys.Left) af -= 30;
            else if (e.KeyCode == Keys.Right) af += 30;
            else if (e.KeyCode == Keys.Up) ag -= 30;
            else if (e.KeyCode == Keys.Down) ag += 30;

            if (e.KeyCode == Keys.Left) ah -= 30;
            else if (e.KeyCode == Keys.Right) ah += 30;
            else if (e.KeyCode == Keys.Up) ai -= 30;
            else if (e.KeyCode == Keys.Down) ai += 30;

            if (e.KeyCode == Keys.Left) aj -= 30;
            else if (e.KeyCode == Keys.Right) aj += 30;
            else if (e.KeyCode == Keys.Up) ak -= 30;
            else if (e.KeyCode == Keys.Down) ak += 30;

            if (e.KeyCode == Keys.Left) al -= 30;
            else if (e.KeyCode == Keys.Right) al += 30;
            else if (e.KeyCode == Keys.Up) am -= 30;
            else if (e.KeyCode == Keys.Down) am += 30;

            if (e.KeyCode == Keys.Left) an -= 30;
            else if (e.KeyCode == Keys.Right) an += 30;
            else if (e.KeyCode == Keys.Up) ao -= 30;
            else if (e.KeyCode == Keys.Down) ao += 30;

            if (e.KeyCode == Keys.Left) ap -= 30;
            else if (e.KeyCode == Keys.Right) ap += 30;
            else if (e.KeyCode == Keys.Up) aq -= 30;
            else if (e.KeyCode == Keys.Down) aq += 30;

            if (e.KeyCode == Keys.Left) ar -= 30;
            else if (e.KeyCode == Keys.Right) ar += 30;
            else if (e.KeyCode == Keys.Up) at -= 30;
            else if (e.KeyCode == Keys.Down) at += 30;

            if (e.KeyCode == Keys.Left) au -= 30;
            else if (e.KeyCode == Keys.Right) au += 30;
            else if (e.KeyCode == Keys.Up) av -= 30;
            else if (e.KeyCode == Keys.Down) av += 30;

            if (e.KeyCode == Keys.Left) aw -= 30;
            else if (e.KeyCode == Keys.Right) aw += 30;
            else if (e.KeyCode == Keys.Up) ax -= 30;
            else if (e.KeyCode == Keys.Down) ax += 30;

            if (e.KeyCode == Keys.Left) ay -= 30;
            else if (e.KeyCode == Keys.Right) ay += 30;
            else if (e.KeyCode == Keys.Up) az -= 30;
            else if (e.KeyCode == Keys.Down) az += 30;

            if (e.KeyCode == Keys.Left) ba -= 30;
            else if (e.KeyCode == Keys.Right) ba += 30;
            else if (e.KeyCode == Keys.Up) bb -= 30;
            else if (e.KeyCode == Keys.Down) bb += 30;

            if (e.KeyCode == Keys.Left) bc -= 30;
            else if (e.KeyCode == Keys.Right) bc += 30;
            else if (e.KeyCode == Keys.Up) bd -= 30;
            else if (e.KeyCode == Keys.Down) bd += 30;

            if (e.KeyCode == Keys.Left) be -= 30;
            else if (e.KeyCode == Keys.Right) be += 30;
            else if (e.KeyCode == Keys.Up) bf -= 30;
            else if (e.KeyCode == Keys.Down) bf += 30;

            if (e.KeyCode == Keys.Left) bg -= 30;
            else if (e.KeyCode == Keys.Right) bg += 30;
            else if (e.KeyCode == Keys.Up) bh -= 30;
            else if (e.KeyCode == Keys.Down) bh += 30;

            if (e.KeyCode == Keys.Left) bi -= 30;
            else if (e.KeyCode == Keys.Right) bi += 30;
            else if (e.KeyCode == Keys.Up) bj -= 30;
            else if (e.KeyCode == Keys.Down) bj += 30;

            if (e.KeyCode == Keys.Left) bk -= 30;
            else if (e.KeyCode == Keys.Right) bk += 30;
            else if (e.KeyCode == Keys.Up) bl -= 30;
            else if (e.KeyCode == Keys.Down) bl += 30;

            if (S4B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S4B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                    if (e.KeyCode == Keys.Left) z += 30;
                    if (e.KeyCode == Keys.Left) ab += 30;
                    if (e.KeyCode == Keys.Left) ad += 30;
                    if (e.KeyCode == Keys.Left) af += 30;
                    if (e.KeyCode == Keys.Left) ah += 30;
                    if (e.KeyCode == Keys.Left) aj += 30;
                    if (e.KeyCode == Keys.Left) al += 30;
                    if (e.KeyCode == Keys.Left) an += 30;
                    if (e.KeyCode == Keys.Left) ap += 30;
                    if (e.KeyCode == Keys.Left) ar += 30;
                    if (e.KeyCode == Keys.Left) au += 30;
                    if (e.KeyCode == Keys.Left) aw += 30;
                    if (e.KeyCode == Keys.Left) ay += 30;
                    if (e.KeyCode == Keys.Left) ba += 30;
                    if (e.KeyCode == Keys.Left) bc += 30;
                    if (e.KeyCode == Keys.Left) be += 30;
                    if (e.KeyCode == Keys.Left) bg += 30;
                    if (e.KeyCode == Keys.Left) bi += 30;
                    if (e.KeyCode == Keys.Left) bk += 30;
                }

                //Right
                if (S4B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                    if (e.KeyCode == Keys.Right) z -= 30;
                    if (e.KeyCode == Keys.Right) ab -= 30;
                    if (e.KeyCode == Keys.Right) ad -= 30;
                    if (e.KeyCode == Keys.Right) af -= 30;
                    if (e.KeyCode == Keys.Right) ah += 30;
                    if (e.KeyCode == Keys.Right) aj += 30;
                    if (e.KeyCode == Keys.Right) al += 30;
                    if (e.KeyCode == Keys.Right) an += 30;
                    if (e.KeyCode == Keys.Right) ap += 30;
                    if (e.KeyCode == Keys.Right) ar += 30;
                    if (e.KeyCode == Keys.Right) au += 30;
                    if (e.KeyCode == Keys.Right) aw += 30;
                    if (e.KeyCode == Keys.Right) ay += 30;
                    if (e.KeyCode == Keys.Right) ba += 30;
                    if (e.KeyCode == Keys.Right) bc += 30;
                    if (e.KeyCode == Keys.Right) be += 30;
                    if (e.KeyCode == Keys.Right) bg += 30;
                    if (e.KeyCode == Keys.Right) bi += 30;
                    if (e.KeyCode == Keys.Right) bk += 30;
                }

                //Top
                if (S4B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                    if (e.KeyCode == Keys.Up) aa += 30;
                    if (e.KeyCode == Keys.Up) ac += 30;
                    if (e.KeyCode == Keys.Up) ae += 30;
                    if (e.KeyCode == Keys.Up) ag += 30;
                    if (e.KeyCode == Keys.Up) ai += 30;
                    if (e.KeyCode == Keys.Up) ak += 30;
                    if (e.KeyCode == Keys.Up) am += 30;
                    if (e.KeyCode == Keys.Up) ao += 30;
                    if (e.KeyCode == Keys.Up) aq += 30;
                    if (e.KeyCode == Keys.Up) at += 30;
                    if (e.KeyCode == Keys.Up) av += 30;
                    if (e.KeyCode == Keys.Up) ax += 30;
                    if (e.KeyCode == Keys.Up) az += 30;
                    if (e.KeyCode == Keys.Up) bb += 30;
                    if (e.KeyCode == Keys.Up) bd += 30;
                    if (e.KeyCode == Keys.Up) bf += 30;
                    if (e.KeyCode == Keys.Up) bh += 30;
                    if (e.KeyCode == Keys.Up) bj += 30;
                    if (e.KeyCode == Keys.Up) bl += 30;
                }

                //Bottom
                if (S4B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                    if (e.KeyCode == Keys.Down) aa -= 30;
                    if (e.KeyCode == Keys.Down) ac -= 30;
                    if (e.KeyCode == Keys.Down) ae -= 30;
                    if (e.KeyCode == Keys.Down) ag -= 30;
                    if (e.KeyCode == Keys.Down) ai += 30;
                    if (e.KeyCode == Keys.Down) ak += 30;
                    if (e.KeyCode == Keys.Down) am += 30;
                    if (e.KeyCode == Keys.Down) ao += 30;
                    if (e.KeyCode == Keys.Down) aq += 30;
                    if (e.KeyCode == Keys.Down) at += 30;
                    if (e.KeyCode == Keys.Down) av += 30;
                    if (e.KeyCode == Keys.Down) ax += 30;
                    if (e.KeyCode == Keys.Down) az += 30;
                    if (e.KeyCode == Keys.Down) bb += 30;
                    if (e.KeyCode == Keys.Down) bd += 30;
                    if (e.KeyCode == Keys.Down) bf += 30;
                    if (e.KeyCode == Keys.Down) bh += 30;
                    if (e.KeyCode == Keys.Down) bj += 30;
                    if (e.KeyCode == Keys.Down) bl += 30;
                }
            }

            //Relocation
            S4B.Location = new Point(a, b);
            S4_1.Location = new Point(c, d);
            S4_2.Location = new Point(f, g);
            S4_3.Location = new Point(h, i);
            S4_4.Location = new Point(j, k);
            S4_5.Location = new Point(l, m);
            S4_6.Location = new Point(n, o);
            S4_7.Location = new Point(p, q);
            S4_8.Location = new Point(r, s);
            S4_9.Location = new Point(t, u);
            S4_10.Location = new Point(v, w);
            S4_11.Location = new Point(x, y);
            S4_12.Location = new Point(z, aa);
            S4_13.Location = new Point(ab, ac);
            S4_14.Location = new Point(ad, ae);
            S4_15.Location = new Point(af, ag);
            S4_16.Location = new Point(ah, ai);
            S4_17.Location = new Point(aj, ak);
            S4_18.Location = new Point(al, am);
            S4_19.Location = new Point(an, ao);
            S4_20.Location = new Point(ap, aq);
            S4_21.Location = new Point(ar, at);
            S4_22.Location = new Point(au, av);
            S4_23.Location = new Point(aw, ax);
            S4_24.Location = new Point(ay, az);
            S4_25.Location = new Point(ba, bb);
            S4_26.Location = new Point(bc, bd);
            S4_27.Location = new Point(be, bf);
            S4_28.Location = new Point(bg, bh);
            S4_29.Location = new Point(bi, bj);
            S4_30.Location = new Point(bk, bl);
            #endregion
        }
        #endregion

        #region Symbol 5 | S5
        private void S5_1_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_2_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_3_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_4_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_5_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_6_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_7_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_8_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_9_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_10_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_11_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S5_12_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol5_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = false;
            S5_2.Enabled = false;
            S5_3.Enabled = false;
            S5_4.Enabled = false;
            S5_5.Enabled = false;
            S5_6.Enabled = false;
            S5_7.Enabled = false;
            S5_8.Enabled = false;
            S5_9.Enabled = false;
            S5_10.Enabled = false;
            S5_11.Enabled = false;
            S5_12.Enabled = false;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        //Symbol5 KeyDown
        void Symbol5_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S5B.Visible = false;

            #region Movement
            //Integers
            int a = S5B.Location.X;
            int b = S5B.Location.Y;
            int c = S5_1.Location.X;
            int d = S5_1.Location.Y;
            int f = S5_2.Location.X;
            int g = S5_2.Location.Y;
            int h = S5_3.Location.X;
            int i = S5_3.Location.Y;
            int j = S5_4.Location.X;
            int k = S5_4.Location.Y;
            int l = S5_5.Location.X;
            int m = S5_5.Location.Y;
            int n = S5_6.Location.X;
            int o = S5_6.Location.Y;
            int p = S5_7.Location.X;
            int q = S5_7.Location.Y;
            int r = S5_8.Location.X;
            int s = S5_8.Location.Y;
            int t = S5_9.Location.X;
            int u = S5_9.Location.Y;
            int v = S5_10.Location.X;
            int w = S5_10.Location.Y;
            int x = S5_11.Location.X;
            int y = S5_11.Location.Y;
            int z = S5_12.Location.X;
            int aa = S5_12.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (e.KeyCode == Keys.Left) z -= 30;
            else if (e.KeyCode == Keys.Right) z += 30;
            else if (e.KeyCode == Keys.Up) aa -= 30;
            else if (e.KeyCode == Keys.Down) aa += 30;

            if (S5B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S5B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                    if (e.KeyCode == Keys.Left) z += 30;
                }

                //Right
                if (S5B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                    if (e.KeyCode == Keys.Right) z -= 30;
                }

                //Top
                if (S5B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                    if (e.KeyCode == Keys.Up) aa += 30;
                }

                //Bottom
                if (S5B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                    if (e.KeyCode == Keys.Down) aa -= 30;
                }
            }

            //Relocation
            S5B.Location = new Point(a, b);
            S5_1.Location = new Point(c, d);
            S5_2.Location = new Point(f, g);
            S5_3.Location = new Point(h, i);
            S5_4.Location = new Point(j, k);
            S5_5.Location = new Point(l, m);
            S5_6.Location = new Point(n, o);
            S5_7.Location = new Point(p, q);
            S5_8.Location = new Point(r, s);
            S5_9.Location = new Point(t, u);
            S5_10.Location = new Point(v, w);
            S5_11.Location = new Point(x, y);
            S5_12.Location = new Point(z, aa);
            #endregion
        }
        #endregion

        #region Symbol 6 | S6
        private void S6_1_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_2_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_3_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_4_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_5_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_6_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_7_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_8_Click(object sender, EventArgs e)
        {
            //Enable
            S5B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_9_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_10_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S6_11_Click(object sender, EventArgs e)
        {
            //Enable
            S6B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol6_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = false;
            S6_2.Enabled = false;
            S6_3.Enabled = false;
            S6_4.Enabled = false;
            S6_5.Enabled = false;
            S6_6.Enabled = false;
            S6_7.Enabled = false;
            S6_8.Enabled = false;
            S6_9.Enabled = false;
            S6_10.Enabled = false;
            S6_11.Enabled = false;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        //Symbol6 KeyDown
        void Symbol6_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S6B.Visible = false;

            #region Movement
            //Integers
            int a = S6B.Location.X;
            int b = S6B.Location.Y;
            int c = S6_1.Location.X;
            int d = S6_1.Location.Y;
            int f = S6_2.Location.X;
            int g = S6_2.Location.Y;
            int h = S6_3.Location.X;
            int i = S6_3.Location.Y;
            int j = S6_4.Location.X;
            int k = S6_4.Location.Y;
            int l = S6_5.Location.X;
            int m = S6_5.Location.Y;
            int n = S6_6.Location.X;
            int o = S6_6.Location.Y;
            int p = S6_7.Location.X;
            int q = S6_7.Location.Y;
            int r = S6_8.Location.X;
            int s = S6_8.Location.Y;
            int t = S6_9.Location.X;
            int u = S6_9.Location.Y;
            int v = S6_10.Location.X;
            int w = S6_10.Location.Y;
            int x = S6_11.Location.X;
            int y = S6_11.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (S6B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S6B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                }

                //Right
                if (S6B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                }

                //Top
                if (S6B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                }

                //Bottom
                if (S6B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                }
            }

            //Relocation
            S6B.Location = new Point(a, b);
            S6_1.Location = new Point(c, d);
            S6_2.Location = new Point(f, g);
            S6_3.Location = new Point(h, i);
            S6_4.Location = new Point(j, k);
            S6_5.Location = new Point(l, m);
            S6_6.Location = new Point(n, o);
            S6_7.Location = new Point(p, q);
            S6_8.Location = new Point(r, s);
            S6_9.Location = new Point(t, u);
            S6_10.Location = new Point(v, w);
            S6_11.Location = new Point(x, y);
            #endregion
        }
        #endregion

        #region Symbol 7 | S7
        private void S7_1_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_2_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_3_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_4_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_5_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_6_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_7_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_8_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_9_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_10_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_11_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        private void S7_12_Click(object sender, EventArgs e)
        {
            //Enable
            S7B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol7_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = false;
            S7_2.Enabled = false;
            S7_3.Enabled = false;
            S7_4.Enabled = false;
            S7_5.Enabled = false;
            S7_6.Enabled = false;
            S7_7.Enabled = false;
            S7_8.Enabled = false;
            S7_9.Enabled = false;
            S7_10.Enabled = false;
            S7_11.Enabled = false;
            S7_12.Enabled = false;

            //Symbol 8
            S8_1.Enabled = true;
            S8_2.Enabled = true;
            S8_3.Enabled = true;
            S8_4.Enabled = true;
            S8_5.Enabled = true;
            S8_6.Enabled = true;
            S8_7.Enabled = true;
            S8_8.Enabled = true;
            S8_9.Enabled = true;
            S8_10.Enabled = true;
            S8_11.Enabled = true;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);
        }

        //Symbol7 KeyDown
        void Symbol7_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol8_KeyDown);

            S7B.Visible = false;

            #region Movement
            //Integers
            int a = S7B.Location.X;
            int b = S7B.Location.Y;
            int c = S7_1.Location.X;
            int d = S7_1.Location.Y;
            int f = S7_2.Location.X;
            int g = S7_2.Location.Y;
            int h = S7_3.Location.X;
            int i = S7_3.Location.Y;
            int j = S7_4.Location.X;
            int k = S7_4.Location.Y;
            int l = S7_5.Location.X;
            int m = S7_5.Location.Y;
            int n = S7_6.Location.X;
            int o = S7_6.Location.Y;
            int p = S7_7.Location.X;
            int q = S7_7.Location.Y;
            int r = S7_8.Location.X;
            int s = S7_8.Location.Y;
            int t = S7_9.Location.X;
            int u = S7_9.Location.Y;
            int v = S7_10.Location.X;
            int w = S7_10.Location.Y;
            int x = S7_11.Location.X;
            int y = S7_11.Location.Y;
            int z = S7_12.Location.X;
            int aa = S7_12.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (e.KeyCode == Keys.Left) z -= 30;
            else if (e.KeyCode == Keys.Right) z += 30;
            else if (e.KeyCode == Keys.Up) aa -= 30;
            else if (e.KeyCode == Keys.Down) aa += 30;

            if (S7B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S7B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                    if (e.KeyCode == Keys.Left) z += 30;
                }

                //Right
                if (S7B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                    if (e.KeyCode == Keys.Right) z -= 30;
                }

                //Top
                if (S7B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                    if (e.KeyCode == Keys.Up) aa += 30;
                }

                //Bottom
                if (S7B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                    if (e.KeyCode == Keys.Down) aa -= 30;
                }
            }

            //Relocation
            S7B.Location = new Point(a, b);
            S7_1.Location = new Point(c, d);
            S7_2.Location = new Point(f, g);
            S7_3.Location = new Point(h, i);
            S7_4.Location = new Point(j, k);
            S7_5.Location = new Point(l, m);
            S7_6.Location = new Point(n, o);
            S7_7.Location = new Point(p, q);
            S7_8.Location = new Point(r, s);
            S7_9.Location = new Point(t, u);
            S7_10.Location = new Point(v, w);
            S7_11.Location = new Point(x, y);
            S7_12.Location = new Point(z, aa);
            #endregion
        }
        #endregion

        #region Symbol 8 | S8
        private void S8_1_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_2_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_3_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_4_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_5_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_6_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_7_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_8_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_9_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_10_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        private void S8_11_Click(object sender, EventArgs e)
        {
            //Enable
            S8B.Visible = true;
            KeyDown += new KeyEventHandler(Symbol8_KeyDown);

            #region Disable
            //Symbol 1
            S1_1.Enabled = true;
            S1_2.Enabled = true;
            S1_3.Enabled = true;
            S1_4.Enabled = true;
            S1_5.Enabled = true;
            S1_6.Enabled = true;
            S1_7.Enabled = true;
            S1_8.Enabled = true;
            S1_9.Enabled = true;

            //Symbol 2
            S2_1.Enabled = true;
            S2_2.Enabled = true;
            S2_3.Enabled = true;
            S2_4.Enabled = true;
            S2_5.Enabled = true;
            S2_6.Enabled = true;
            S2_7.Enabled = true;
            S2_8.Enabled = true;
            S2_9.Enabled = true;
            S2_10.Enabled = true;
            S2_11.Enabled = true;
            S2_12.Enabled = true;
            S2_13.Enabled = true;
            S2_14.Enabled = true;
            S2_15.Enabled = true;

            //Symbol 3
            S3_1.Enabled = true;
            S3_2.Enabled = true;
            S3_3.Enabled = true;
            S3_4.Enabled = true;
            S3_5.Enabled = true;
            S3_6.Enabled = true;
            S3_7.Enabled = true;
            S3_8.Enabled = true;
            S3_9.Enabled = true;
            S3_10.Enabled = true;
            S3_11.Enabled = true;
            S3_12.Enabled = true;

            //Symbol 4
            S4_1.Enabled = true;
            S4_2.Enabled = true;
            S4_3.Enabled = true;
            S4_4.Enabled = true;
            S4_5.Enabled = true;
            S4_6.Enabled = true;
            S4_7.Enabled = true;
            S4_8.Enabled = true;
            S4_9.Enabled = true;
            S4_10.Enabled = true;
            S4_11.Enabled = true;
            S4_12.Enabled = true;
            S4_13.Enabled = true;
            S4_14.Enabled = true;
            S4_15.Enabled = true;
            S4_16.Enabled = true;
            S4_17.Enabled = true;
            S4_18.Enabled = true;
            S4_19.Enabled = true;
            S4_20.Enabled = true;
            S4_21.Enabled = true;
            S4_22.Enabled = true;
            S4_23.Enabled = true;
            S4_15.Enabled = true;
            S4_25.Enabled = true;
            S4_26.Enabled = true;
            S4_27.Enabled = true;
            S4_28.Enabled = true;
            S4_29.Enabled = true;
            S4_30.Enabled = true;

            //Symbol 5
            S5_1.Enabled = true;
            S5_2.Enabled = true;
            S5_3.Enabled = true;
            S5_4.Enabled = true;
            S5_5.Enabled = true;
            S5_6.Enabled = true;
            S5_7.Enabled = true;
            S5_8.Enabled = true;
            S5_9.Enabled = true;
            S5_10.Enabled = true;
            S5_11.Enabled = true;
            S5_12.Enabled = true;

            //Symbol 6
            S6_1.Enabled = true;
            S6_2.Enabled = true;
            S6_3.Enabled = true;
            S6_4.Enabled = true;
            S6_5.Enabled = true;
            S6_6.Enabled = true;
            S6_7.Enabled = true;
            S6_8.Enabled = true;
            S6_9.Enabled = true;
            S6_10.Enabled = true;
            S6_11.Enabled = true;

            //Symbol 7
            S7_1.Enabled = true;
            S7_2.Enabled = true;
            S7_3.Enabled = true;
            S7_4.Enabled = true;
            S7_5.Enabled = true;
            S7_6.Enabled = true;
            S7_7.Enabled = true;
            S7_8.Enabled = true;
            S7_9.Enabled = true;
            S7_10.Enabled = true;
            S7_11.Enabled = true;
            S7_12.Enabled = true;

            //Symbol 8
            S8_1.Enabled = false;
            S8_2.Enabled = false;
            S8_3.Enabled = false;
            S8_4.Enabled = false;
            S8_5.Enabled = false;
            S8_6.Enabled = false;
            S8_7.Enabled = false;
            S8_8.Enabled = false;
            S8_9.Enabled = false;
            S8_10.Enabled = false;
            S8_11.Enabled = false;
            #endregion

            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);
        }

        //Symbol8 KeyDown
        void Symbol8_KeyDown(object sender, KeyEventArgs e)
        {
            KeyDown -= new KeyEventHandler(Symbol1_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol2_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol3_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol4_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol5_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol6_KeyDown);
            KeyDown -= new KeyEventHandler(Symbol7_KeyDown);

            S8B.Visible = false;

            #region Movement
            //Integers
            int a = S8B.Location.X;
            int b = S8B.Location.Y;
            int c = S8_1.Location.X;
            int d = S8_1.Location.Y;
            int f = S8_2.Location.X;
            int g = S8_2.Location.Y;
            int h = S8_3.Location.X;
            int i = S8_3.Location.Y;
            int j = S8_4.Location.X;
            int k = S8_4.Location.Y;
            int l = S8_5.Location.X;
            int m = S8_5.Location.Y;
            int n = S8_6.Location.X;
            int o = S8_6.Location.Y;
            int p = S8_7.Location.X;
            int q = S8_7.Location.Y;
            int r = S8_8.Location.X;
            int s = S8_8.Location.Y;
            int t = S8_9.Location.X;
            int u = S8_9.Location.Y;
            int v = S8_10.Location.X;
            int w = S8_10.Location.Y;
            int x = S8_11.Location.X;
            int y = S8_11.Location.Y;

            if (e.KeyCode == Keys.Left) a -= 30;
            else if (e.KeyCode == Keys.Right) a += 30;
            else if (e.KeyCode == Keys.Up) b -= 30;
            else if (e.KeyCode == Keys.Down) b += 30;

            if (e.KeyCode == Keys.Left) c -= 30;
            else if (e.KeyCode == Keys.Right) c += 30;
            else if (e.KeyCode == Keys.Up) d -= 30;
            else if (e.KeyCode == Keys.Down) d += 30;

            if (e.KeyCode == Keys.Left) f -= 30;
            else if (e.KeyCode == Keys.Right) f += 30;
            else if (e.KeyCode == Keys.Up) g -= 30;
            else if (e.KeyCode == Keys.Down) g += 30;

            if (e.KeyCode == Keys.Left) h -= 30;
            else if (e.KeyCode == Keys.Right) h += 30;
            else if (e.KeyCode == Keys.Up) i -= 30;
            else if (e.KeyCode == Keys.Down) i += 30;

            if (e.KeyCode == Keys.Left) j -= 30;
            else if (e.KeyCode == Keys.Right) j += 30;
            else if (e.KeyCode == Keys.Up) k -= 30;
            else if (e.KeyCode == Keys.Down) k += 30;

            if (e.KeyCode == Keys.Left) l -= 30;
            else if (e.KeyCode == Keys.Right) l += 30;
            else if (e.KeyCode == Keys.Up) m -= 30;
            else if (e.KeyCode == Keys.Down) m += 30;

            if (e.KeyCode == Keys.Left) n -= 30;
            else if (e.KeyCode == Keys.Right) n += 30;
            else if (e.KeyCode == Keys.Up) o -= 30;
            else if (e.KeyCode == Keys.Down) o += 30;

            if (e.KeyCode == Keys.Left) p -= 30;
            else if (e.KeyCode == Keys.Right) p += 30;
            else if (e.KeyCode == Keys.Up) q -= 30;
            else if (e.KeyCode == Keys.Down) q += 30;

            if (e.KeyCode == Keys.Left) r -= 30;
            else if (e.KeyCode == Keys.Right) r += 30;
            else if (e.KeyCode == Keys.Up) s -= 30;
            else if (e.KeyCode == Keys.Down) s += 30;

            if (e.KeyCode == Keys.Left) t -= 30;
            else if (e.KeyCode == Keys.Right) t += 30;
            else if (e.KeyCode == Keys.Up) u -= 30;
            else if (e.KeyCode == Keys.Down) u += 30;

            if (e.KeyCode == Keys.Left) v -= 30;
            else if (e.KeyCode == Keys.Right) v += 30;
            else if (e.KeyCode == Keys.Up) w -= 30;
            else if (e.KeyCode == Keys.Down) w += 30;

            if (e.KeyCode == Keys.Left) x -= 30;
            else if (e.KeyCode == Keys.Right) x += 30;
            else if (e.KeyCode == Keys.Up) y -= 30;
            else if (e.KeyCode == Keys.Down) y += 30;

            if (S8B.Bounds.IntersectsWith(ClientRectangle))
            {
                //Left
                if (S8B.Left <= 0)
                {
                    if (e.KeyCode == Keys.Left) a += 30;
                    if (e.KeyCode == Keys.Left) c += 30;
                    if (e.KeyCode == Keys.Left) f += 30;
                    if (e.KeyCode == Keys.Left) h += 30;
                    if (e.KeyCode == Keys.Left) j += 30;
                    if (e.KeyCode == Keys.Left) l += 30;
                    if (e.KeyCode == Keys.Left) n += 30;
                    if (e.KeyCode == Keys.Left) p += 30;
                    if (e.KeyCode == Keys.Left) r += 30;
                    if (e.KeyCode == Keys.Left) t += 30;
                    if (e.KeyCode == Keys.Left) v += 30;
                    if (e.KeyCode == Keys.Left) x += 30;
                }

                //Right
                if (S8B.Right >= ClientRectangle.Width)
                {
                    if (e.KeyCode == Keys.Right) a -= 30;
                    if (e.KeyCode == Keys.Right) c -= 30;
                    if (e.KeyCode == Keys.Right) f -= 30;
                    if (e.KeyCode == Keys.Right) h -= 30;
                    if (e.KeyCode == Keys.Right) j -= 30;
                    if (e.KeyCode == Keys.Right) l -= 30;
                    if (e.KeyCode == Keys.Right) n -= 30;
                    if (e.KeyCode == Keys.Right) p -= 30;
                    if (e.KeyCode == Keys.Right) r -= 30;
                    if (e.KeyCode == Keys.Right) t -= 30;
                    if (e.KeyCode == Keys.Right) v -= 30;
                    if (e.KeyCode == Keys.Right) x -= 30;
                }

                //Top
                if (S8B.Top <= 30)
                {
                    if (e.KeyCode == Keys.Up) b += 30;
                    if (e.KeyCode == Keys.Up) d += 30;
                    if (e.KeyCode == Keys.Up) g += 30;
                    if (e.KeyCode == Keys.Up) i += 30;
                    if (e.KeyCode == Keys.Up) k += 30;
                    if (e.KeyCode == Keys.Up) m += 30;
                    if (e.KeyCode == Keys.Up) o += 30;
                    if (e.KeyCode == Keys.Up) q += 30;
                    if (e.KeyCode == Keys.Up) s += 30;
                    if (e.KeyCode == Keys.Up) u += 30;
                    if (e.KeyCode == Keys.Up) w += 30;
                    if (e.KeyCode == Keys.Up) y += 30;
                }

                //Bottom
                if (S8B.Bottom >= ClientRectangle.Height)
                {
                    if (e.KeyCode == Keys.Down) b -= 30;
                    if (e.KeyCode == Keys.Down) d -= 30;
                    if (e.KeyCode == Keys.Down) g -= 30;
                    if (e.KeyCode == Keys.Down) i -= 30;
                    if (e.KeyCode == Keys.Down) k -= 30;
                    if (e.KeyCode == Keys.Down) m -= 30;
                    if (e.KeyCode == Keys.Down) o -= 30;
                    if (e.KeyCode == Keys.Down) q -= 30;
                    if (e.KeyCode == Keys.Down) s -= 30;
                    if (e.KeyCode == Keys.Down) u -= 30;
                    if (e.KeyCode == Keys.Down) w -= 30;
                    if (e.KeyCode == Keys.Down) y -= 30;
                }
            }

            //Relocation
            S8B.Location = new Point(a, b);
            S8_1.Location = new Point(c, d);
            S8_2.Location = new Point(f, g);
            S8_3.Location = new Point(h, i);
            S8_4.Location = new Point(j, k);
            S8_5.Location = new Point(l, m);
            S8_6.Location = new Point(n, o);
            S8_7.Location = new Point(p, q);
            S8_8.Location = new Point(r, s);
            S8_9.Location = new Point(t, u);
            S8_10.Location = new Point(v, w);
            S8_11.Location = new Point(x, y);
            #endregion
        }
        #endregion
    }
}

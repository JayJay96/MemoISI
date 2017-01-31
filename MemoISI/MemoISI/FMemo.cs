using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MemoISI
{
    public partial class FMemo : Form
    {
        private List<PictureBoxId> pbs;
        private List<short> randomID;
        private Boolean lastCardReturned = false;
        private PictureBoxId firstCardReturned;
        private PictureBoxId returnedPb;
        private Int16 score;
        private Int16 cardPair;

        private Dictionary<short, Bitmap> images = new Dictionary<short, Bitmap>();

        public FMemo()
        {
            InitializeComponent();
            InitCards();
            this.Width = (100 * 4) + 150;
            this.Height = (145 * 4) + 150;
            BW_Timer.DoWork += new DoWorkEventHandler(bw_DoWork);
            BW_Timer.ProgressChanged += new ProgressChangedEventHandler(bw_Progress);
            images.Add(1, MemoISI.Properties.Resources.Card1);
            images.Add(2, MemoISI.Properties.Resources.Card2);
            images.Add(3, MemoISI.Properties.Resources.Card3);
            images.Add(4, MemoISI.Properties.Resources.Card4);
            images.Add(5, MemoISI.Properties.Resources.Card5);
            images.Add(6, MemoISI.Properties.Resources.Card6);
            images.Add(7, MemoISI.Properties.Resources.Card7);
            images.Add(8, MemoISI.Properties.Resources.Card8);
            startGame();
        }

        private void startGame()
        {
            if(BW_Timer.IsBusy)
                BW_Timer.CancelAsync();
            score = 0;
            cardPair = 0;
            LB_Score.Text = "0";
            LB_Timer.Text = "60 secondes";
            RandomiseArray.Shuffle(randomID);
            PictureBoxId pb;
            for (int i = 0; i < pbs.Count; ++i)
            {
                pb = (PictureBoxId)this.Controls.Find("PB_" + (i+1), true)[0];
                pb.returned = false;
                pb.Image = MemoISI.Properties.Resources.BackCard;
                pb.Id = randomID[i];
            }
            BW_Timer.RunWorkerAsync();
        }

        private void cardPressed(object sender, EventArgs e)
        {
            returnedPb = (PictureBoxId)sender;
            if (!returnedPb.returned)
            {
                if (!lastCardReturned)
                {
                    returnedPb.returned = true;
                    firstCardReturned = returnedPb;
                    returnedPb.Image = images[returnedPb.Id];
                    lastCardReturned = true;
                }
                else
                {
                    Timer tmr = new Timer();
                    tmr.Interval = 1000;
                    tmr.Tick += new EventHandler(timer_tick_card);
                    returnedPb.Image = images[returnedPb.Id];
                    returnedPb.returned = true;
                    tmr.Start();
                    lastCardReturned = false;

                }
            }
        }

        private void timer_tick_card(object sender, EventArgs e)
        {
            if (returnedPb.Id != firstCardReturned.Id)
            {
                returnedPb.Image = MemoISI.Properties.Resources.BackCard;
                firstCardReturned.Image = MemoISI.Properties.Resources.BackCard;
                returnedPb.returned = false;
                firstCardReturned.returned = false;
                if (score > 1) score -= 2;
            }
            else
            {
                score += 10;
                cardPair += 1;
            }
            LB_Score.Text = score.ToString();
            ((Timer)sender).Stop();
            if (cardPair * 2 == pbs.Count)
            {
                BW_Timer.CancelAsync();
                MessageBox.Show("Bravo! Tu as gagné en " + (60 - Int16.Parse(LB_Timer.Text.Substring(0,2))) + " secondes avec "+ score +" point!");
            }
        }

        private void InitCards()
        {
            this.pbs = new List<PictureBoxId>();
            this.randomID = new List<short>();
            Size initSize = new Size(100, 145);
            PictureBoxId pb;

            //PB_1
            pb = new PictureBoxId();
            pb.Id = 1;
            pb.Size = initSize;
            pb.Name = "PB_1";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(50, 90);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(1);

            //PB_2
            pb = new PictureBoxId();
            pb.Id = 2;
            pb.Size = initSize;
            pb.Name = "PB_2";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(150, 90);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(2);

            //PB_3
            pb = new PictureBoxId();
            pb.Id = 3;
            pb.Size = initSize;
            pb.Name = "PB_3";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(250, 90);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(3);

            //PB_4
            pb = new PictureBoxId();
            pb.Id = 4;
            pb.Size = initSize;
            pb.Name = "PB_4";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(350, 90);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(4);

            //PB_5
            pb = new PictureBoxId();
            pb.Id = 5;
            pb.Size = initSize;
            pb.Name = "PB_5";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(50, 235);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(5);

            //PB_6
            pb = new PictureBoxId();
            pb.Id = 6;
            pb.Size = initSize;
            pb.Name = "PB_6";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(150, 235);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(6);

            //PB_7
            pb = new PictureBoxId();
            pb.Id = 7;
            pb.Size = initSize;
            pb.Name = "PB_7";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(250, 235);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(7);

            //PB_8
            pb = new PictureBoxId();
            pb.Id = 8;
            pb.Size = initSize;
            pb.Name = "PB_8";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(350, 235);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(8);

            //PB_9
            pb = new PictureBoxId();
            pb.Id = 8;
            pb.Size = initSize;
            pb.Name = "PB_9";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(50, 380);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(8);

            //PB_10
            pb = new PictureBoxId();
            pb.Id = 7;
            pb.Size = initSize;
            pb.Name = "PB_10";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(150, 380);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(7);

            //PB_11
            pb = new PictureBoxId();
            pb.Id = 6;
            pb.Size = initSize;
            pb.Name = "PB_11";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(250, 380);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(6);

            //PB_12
            pb = new PictureBoxId();
            pb.Id = 5;
            pb.Size = initSize;
            pb.Name = "PB_12";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(350, 380);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(5);

            //PB_13
            pb = new PictureBoxId();
            pb.Id = 4;
            pb.Size = initSize;
            pb.Name = "PB_13";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(50, 525);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(4);

            //PB_14
            pb = new PictureBoxId();
            pb.Id = 3;
            pb.Size = initSize;
            pb.Name = "PB_14";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(150, 525);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(3);

            //PB_15
            pb = new PictureBoxId();
            pb.Id = 2;
            pb.Size = initSize;
            pb.Name = "PB_15";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(250, 525);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(2);

            //PB_16
            pb = new PictureBoxId();
            pb.Id = 1;
            pb.Size = initSize;
            pb.Name = "PB_16";
            pb.Image = MemoISI.Properties.Resources.BackCard;
            pb.Location = new Point(350, 525);
            pb.Click += new EventHandler(cardPressed);
            this.pbs.Add(pb);
            this.randomID.Add(1);

            PictureBoxId[] pictureControls = new PictureBoxId[pbs.Count];
            this.pbs.CopyTo(pictureControls);
            this.Controls.AddRange(pictureControls);
        }

        private void nouveauJeuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            startGame();
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = (BackgroundWorker)sender;
            int time = 60;
            while (true)
            {
                if(bw.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                System.Threading.Thread.Sleep(1000);
                bw.ReportProgress(time--);
                if (time < 0) break;
            }
            if(e.Cancel != true)
            {
                MessageBox.Show("Fin du temps imparti! Score final : " + score);
            }
        }

        private void bw_Progress(object sender, ProgressChangedEventArgs e)
        {
            LB_Timer.Text = (e.ProgressPercentage + " secondes").ToString();
        }
    }
}

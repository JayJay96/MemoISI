using System;
using System.Drawing;
using System.Windows.Forms;

namespace MemoISI
{
    public partial class FMemo : Form
    {
        public FMemo()
        {
            InitializeComponent();
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            Bitmap[] test = {
                MemoISI.Properties.Resources.Card1,
                MemoISI.Properties.Resources.Card2,
                MemoISI.Properties.Resources.Card3,
                MemoISI.Properties.Resources.Card4,
                MemoISI.Properties.Resources.Card5,
                MemoISI.Properties.Resources.Card6,
                MemoISI.Properties.Resources.Card7,
                MemoISI.Properties.Resources.Card8
            };
            RandomiseArray.RandomPermutation(test);
            PB_ToFind.Image = test[new Random().Next(0, test.Length)];
            PictureBox pb;
            for (int i = 0; i < test.Length; ++i)
            {
                pb = (PictureBox)this.Controls.Find("PB_" + (i+1), true)[0];
                pb.Image = test[i];
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoISI
{
    class PictureBoxId : PictureBox
    {
        public Int16 Id;
        public Boolean returned;

        public PictureBoxId()
        {
            this.returned = false;
        }
    }
}

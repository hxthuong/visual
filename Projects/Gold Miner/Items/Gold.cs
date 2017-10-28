using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Items
{
   public class Gold
    {
        public void DisplayGold()
        {
            OpenFileDialog im = new OpenFileDialog();
            Image image1 = Image.FromFile(@"D:\Downloads\Simple_Gold_Mine_Icons\1.png");
            Image image2 = Image.FromFile(@"D:\Downloads\Simple_Gold_Mine_Icons\2.png");
            Image image3 = Image.FromFile(@"D:\Downloads\Simple_Gold_Mine_Icons\3.png");

        }
        
    }
}

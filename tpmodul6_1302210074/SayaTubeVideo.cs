using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul6_1302210074
{
    internal class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            var a = this.title.Substring(0, Math.Min(100, this.title.Length));
            Contract.Requires(this.title != null);

            String Digit = "";

            Random random= new Random();
            id= random.Next(1, 99999);
            Digit += id.ToString("Digit 5");

            playCount = 0;
        }

        public void PrintVideoDetails()
        {

        }

        public void IncreasePlayCount(int x)
        {

        }
    }
}

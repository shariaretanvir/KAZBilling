using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace KAZBilling
{
    public partial class Entry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Buttonshow_Click(object sender, EventArgs e)
        {
            DateTime datetime = Convert.ToDateTime(datetimeTextBox.Text);
            var hour = (datetime.Hour)* 60;
            var min = datetime.Minute;
            var totralMinute = hour + min;
            var duration = Convert.ToInt32(durationTextBox.Text);
            int a = GetBill(totralMinute,duration);
            costLabel.Text = a.ToString() +"Taka";
        }

        private int GetBill(int date, int duration)
        {
            int count = 0;
            int limit = date + duration;
            for (int i = date; i < limit; i++)
            {
                if ((0<=i && i <180)  || (0 <= i%720 && i%720 < 180))
                {
                    count = count + 2;
                    continue;
                }

                else if ((180 <= i && i < 360) || (180 <= i%720 && i%720 < 360))
                {
                    count = count + 3;
                    continue;
                }
                else if((360 <= i && i < 540) || (360 <= i%720 && i%720 < 540))
                {
                    count = count + 6;
                    continue;
                }

                else if((540 <= i && i < 720) || (540 <= i%720 && i%720 < 720))
                {
                    count = count + 8;
                    continue;
                }
            }
            return count;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeDaysBetweenDates
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton_Click(object sender, EventArgs e)
        {
            DateTime TopCalDate = topCalendar.SelectedDate;
            DateTime BottomCalDate = bottomCalendar.SelectedDate;
            TimeSpan daysBetweenDates;

            if (TopCalDate > BottomCalDate)
            {
                daysBetweenDates = TopCalDate - BottomCalDate;
                
            } else
            {
                daysBetweenDates = BottomCalDate - TopCalDate;
            }
            resutlLabel.Text = daysBetweenDates.Days.ToString();
        }
    }
}
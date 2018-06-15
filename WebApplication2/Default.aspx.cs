using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 20; i++)
                PlaceHolder1.Controls.Add(new Label {Text = i + "<br>"});
        }
    }
}
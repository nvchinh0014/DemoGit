using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyProject
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int a;
            int b;
            a = 45;
            b = 90;


        Sum(a,b);
        }

        private int Sum(int x,int y)
        {
            return(x+y);
        }


        private int Sub(int x, int y)
        {
            return x - y;
        }

    }
}
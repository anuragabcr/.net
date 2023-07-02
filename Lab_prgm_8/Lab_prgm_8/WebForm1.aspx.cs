using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_prgm_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string str = args.Value;
            args.IsValid = false;

            if (str.Length < 8) { return; }
            bool capital = true;
            foreach (char c in str)
            {
                if(Char.IsUpper(c))
                {
                    capital = false;
                    break;
                }
            }
            if (capital) { return; }
            bool digit = true;
            foreach (char c in str) {
                if (c >= '0' || c <= '9')
                {
                    digit = false;
                    break;
                }
            }
            if (digit) { return; }
            Label9.Text = "All valid";
            args.IsValid = true;
        }
    }
}
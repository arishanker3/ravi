using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page

{
    ServiceReference1.WebServiceSoapClient c = new ServiceReference1.WebServiceSoapClient();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        
        string a = txtOperand1.Text;

        string b = txtOperand2.Text;

        txtResult.Text = c.Add(a, b);
        txtOperand1.Text = "";
        txtOperand2.Text = "";
    }
    protected void btnSub_Click(object sender, EventArgs e)
    {
        string a = txtOperand1.Text;
        string b = txtOperand2.Text;
        txtResult.Text = c.Sub(a, b);
        txtOperand1.Text = "";
        txtOperand2.Text = "";
    }
    protected void btnMultiply_Click(object sender, EventArgs e)
    {
        string a = txtOperand1.Text;
        string b = txtOperand2.Text;
        txtResult.Text = c.Multiply(a, b);
        txtOperand1.Text = "";
        txtOperand2.Text = "";
    }
    protected void btnDiv_Click(object sender, EventArgs e)
    {
        string a = txtOperand1.Text;
        string b = txtOperand2.Text;
        int x = Int32.Parse(b);
        if (x == 0)
        {
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = "Denominator cannot be zero";
        }
        else
        {
            txtResult.Text = c.Divide(a, b);
            txtOperand1.Text = "";
            txtOperand2.Text = "";
        }
        
    }
}

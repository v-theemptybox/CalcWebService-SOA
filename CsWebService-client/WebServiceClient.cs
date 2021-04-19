using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsWebService_client
{
    public partial class WebServiceClient : Form
    {
        public WebServiceClient()
        {
            InitializeComponent();
        }

        private void WebServiceClient_Load(object sender, EventArgs e)
        {

        }
        //private int getData(double a, double b)
        //{
        //    double
        //    return a;
        //}

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CsWebService_client.CalcRef.CalculatorWebServiceSoapClient calc = new CalcRef.CalculatorWebServiceSoapClient();
            double a = double.Parse(txtNumA.Text);
            double b = double.Parse(txtNumB.Text);
            double result = calc.add(a, b);
            txtRes.Text = "" + result;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            CsWebService_client.CalcRef.CalculatorWebServiceSoapClient calc = new CalcRef.CalculatorWebServiceSoapClient();
            double a = double.Parse(txtNumA.Text);
            double b = double.Parse(txtNumB.Text);
            double result = calc.subtract(a, b);
            txtRes.Text = "" + result;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            CsWebService_client.CalcRef.CalculatorWebServiceSoapClient calc = new CalcRef.CalculatorWebServiceSoapClient();
            double a = double.Parse(txtNumA.Text);
            double b = double.Parse(txtNumB.Text);
            double result = calc.multiply(a, b);
            txtRes.Text = "" + result;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            CsWebService_client.CalcRef.CalculatorWebServiceSoapClient calc = new CalcRef.CalculatorWebServiceSoapClient();
            double a = double.Parse(txtNumA.Text);
            double b = double.Parse(txtNumB.Text);
            if (b == 0) MessageBox.Show("Divide by zero");
            else
            {
                double result = calc.divide(a, b);
                txtRes.Text = "" + result;
            }
            
        }
    }
}

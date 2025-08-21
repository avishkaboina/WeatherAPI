using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherAPI
{
    public partial class frmWeatherAPI : Form
    {
        public frmWeatherAPI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmWeatherAPI_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.SetControls();
        }

        private void SetControls()
        {
            //Form
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            //TextBox Settings
            this.txtzipcode.MaxLength = 5;
            this.txtzipcode.Text = "78758";
            this.txtcity.Text = "";
            this.txtclouds.Text = "";
            this.txtfeelslike.Text = "";
            this.txthigh.Text = "";
            this.txtlatitude.Text = "";
            this.txtlongitude.Text = "";
            this.txtlow.Text = "";
            this.txttemperature.Text = "";
            this.txtwind.Text = "";
            this.txtcity.Enabled = false;
            this.txtclouds.Enabled = false;
            this.txtfeelslike.Enabled = false;
            this.txthigh.Enabled = false;
            this.txtlatitude.Enabled = false;
            this.txtlongitude.Enabled = false;
            this.txtlow.Enabled = false;
            this.txttemperature.Enabled = false;
            this.txtwind.Enabled = false;
        }

    }
}

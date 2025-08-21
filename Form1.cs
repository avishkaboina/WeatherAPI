using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeatherAPI.Models;
using WeatherAPI.Services;

namespace WeatherAPI
{
    public partial class frmWeatherAPI : Form
    {
        List<Weather> weather;

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

        private void btnxml_Click(object sender, EventArgs e)
        {
            this.GetWeather(true);
        }

        private void btnjson_Click(object sender, EventArgs e)
        {
            this.GetWeather(false);
        }

        private void GetWeather(bool isXML)
        {
            string sZip = this.txtzipcode.Text.Trim();

            int iZip = Validation(sZip);

            if (iZip == 0)
                return;

            try
            {
                weather = WeatherService.GetWeather(iZip, isXML);

                this.PopulateWeatherData(weather);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.SetControls();
            }
        }

        private int Validation(string sZip)
        {
            int iZip = 0;

            bool result = int.TryParse(sZip, out iZip);

            if (!result)
            {
                MessageBox.Show("A numeric value must be entered for zip code!");
                return iZip;
            }
            else if (sZip.Length != 5)
            {
                MessageBox.Show("Zip code must be 5 numbers!");
                iZip = 0;
                return iZip;
            }

            return iZip;
        }

        private void PopulateWeatherData(List<Weather> weather)
        {
            this.txtcity.Text = weather[0].City;
            this.txtclouds.Text = weather[0].Clouds;
            this.txtfeelslike.Text = weather[0].FeelsLike;
            this.txthigh.Text = weather[0].HighTemp;
            this.txtlatitude.Text = weather[0].Latitude;
            this.txtlongitude.Text = weather[0].Longitude;
            this.txtlow.Text = weather[0].LowTemp;
            this.txttemperature.Text = weather[0].CurrentTemp;
            this.txtwind.Text = weather[0].Wind;
        }

    }
    }

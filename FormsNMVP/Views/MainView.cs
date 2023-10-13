using System;
using System.Windows.Forms;
// lat: 40.3776700
// lon: 49.8920100
namespace FormsNMVP.Views
{
    public partial class MainView : Form, IMainView
    {
        private double _temperature;
        private double _feelsLike;
        private double _windSpeed;
        private string _weather;
        private string _description;
        private string _city;
        private string _country;

        public MainView()
        {
            InitializeComponent();

            _byCityNameRadioButton.Enabled = true;
        }

        public event Action<WeatherBy> RadioButtonToggled;
        public event Action<WeatherBy> WeatherRequested;

        public void ToggleByCityPanel()
        {
            _byCityNamePanel.Visible = !_byCityNamePanel.Visible;
        }

        public void ToggleByCoordsPanel()
        {
            _byCoordsPanel.Visible = !_byCoordsPanel.Visible;
        }

        public string CityName => _cityNameTextBox.Text;

        public double Latitude
        {
            get
            {
                if (double.TryParse(_latTextBox.Text, out var result))
                {
                    return result;
                }

                _latTextBox.Text = string.Empty;

                throw new ArgumentException($"Incorrect input for {nameof(Latitude)}");
            }
        }

        public double Longitude
        {
            get
            {
                if (double.TryParse(_lonTextBox.Text, out var result))
                {
                    return result;
                }

                _lonTextBox.Text = string.Empty;

                throw new ArgumentException($"Incorrect input for {nameof(Longitude)}");
            }
        }

        public void ShowErrorBox(string message)
        {
            MessageBox.Show(message, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public double Temperature
        {
            get => _temperature;
            set
            {
                _temperature = value;
                _tempLabelInfo.Text = value.ToString();
            }
        }

        public double FeelsLike
        {
            get => _feelsLike;
            set
            {
                _feelsLike = value;
                _feelsLikeLabelInfo.Text = value.ToString();
            }
        }

        public double WindSpeed
        {
            get => _windSpeed;
            set
            {
                _windSpeed = value;
                _windSpeedLabelInfo.Text = value.ToString();
            }
        }

        public string Weather
        {
            get => _weather;
            set => _weather = _weatherLabelInfo.Text = value;
        }

        public string Description
        {
            get => _description;
            set => _description = _descriptionLabelInfo.Text = value;
        }

        public string City
        {
            get => _city;
            set => _city = _cityLabelInfo.Text = value;
        }

        public string Country
        {
            get => _country;
            set => _country = _countryLabelInfo.Text = value;
        }

        public void ShowLabels()
        {
            _dataPanel.Visible = true;
        }

        public void HideLabels()
        {
            _dataPanel.Visible = false;
        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton)
            {
                if (radioButton == _byCityNameRadioButton)
                {
                    RadioButtonToggled?.Invoke(WeatherBy.City);
                }

                if (radioButton == _byCoordinatesRadioButton)
                {
                    RadioButtonToggled?.Invoke(WeatherBy.Coordinates);
                }
            }
        }

        private void _getWeatherButton_Click(object sender, EventArgs e)
        {
            if (_byCityNameRadioButton.Checked)
            {
                WeatherRequested?.Invoke(WeatherBy.City);
            }
            else if (_byCoordinatesRadioButton.Checked)
            {
                WeatherRequested?.Invoke(WeatherBy.Coordinates);
            }
        }
    }
}
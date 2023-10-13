using System;
using System.Configuration;
using System.Net;
using FormsNMVP.Models;
using FormsNMVP.Views;
using Newtonsoft.Json;

namespace FormsNMVP.Presenters
{
    public class MainPresenter : IMainPresenter
    {
        private readonly IMainView _view;

        public MainPresenter(IMainView view)
        {
            _view = view;

            _view.WeatherRequested += GetWeather;

            _view.RadioButtonToggled += type =>
            {
                switch (type)
                {
                    case WeatherBy.City:
                    {
                        _view.ToggleByCoordsPanel();
                        break;
                    }
                    case WeatherBy.Coordinates:
                    {
                        _view.ToggleByCityPanel();
                        break;
                    }
                    default:
                        throw new ArgumentOutOfRangeException(nameof(type), type, null);
                }
            };
        }

        public void GetWeather(WeatherBy by)
        {
            //ConfigurationManager.AppSettings[]
            using (var client = new WebClient())
            {
                try
                {
                    string json = null;

                    switch (by)
                    {
                        case WeatherBy.City:
                            json = client.DownloadString(
                                $"https://api.openweathermap.org/data/2.5/weather?q={_view.CityName}&appid=426bebdd5af171d27e20b2aabf617c78");
                            break;
                        case WeatherBy.Coordinates:
                            json = client.DownloadString(
                                $"https://api.openweathermap.org/data/2.5/weather?q=lat={_view.Latitude}&lon={_view.Longitude}&appid=426bebdd5af171d27e20b2aabf617c78");
                            break;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(by), by, null);
                    }

                    var result = JsonConvert.DeserializeObject<WeatherData>(json);

                    if (result != null)
                    {
                        _view.ShowLabels();
                        _view.Temperature = result.Main.Temp;
                        _view.FeelsLike = result.Main.FeelsLike;
                        _view.WindSpeed = result.Wind.Speed;
                        _view.Weather = result.Weather[0].Main;
                        _view.Description = result.Weather[0].Description;
                        _view.City = result.Name;
                        _view.Country = result.Sys.Country;
                    }
                    else
                    {
                        throw new Exception("JSON Deserialize failed.");
                    }
                }
                catch (ArgumentException ex)
                {
                    _view.HideLabels();
                    _view.ShowErrorBox(ex.Message);
                }
                catch (WebException ex)
                {
                    _view.HideLabels();
                    _view.ShowErrorBox("Invalid input info");
                }
                catch (Exception ex)
                {
                    _view.HideLabels();
                    _view.ShowErrorBox(ex.Message);
                }
            }
        }
    }
}
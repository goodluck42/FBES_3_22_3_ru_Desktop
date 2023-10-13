using System;

namespace FormsNMVP.Views
{
    public interface IMainView
    {
        event Action<WeatherBy> RadioButtonToggled;
        event Action<WeatherBy> WeatherRequested;
        
        string CityName { get; }
        double Latitude { get; }
        double Longitude { get; }
        void ShowErrorBox(string message);
        
        double Temperature { get; set; }
        double FeelsLike { get; set; }
        double WindSpeed { get; set; }
        string Weather { get; set; }
        string Description { get; set; }
        string City { get; set; }
        string Country { get; set; }

        void ShowLabels();
        void HideLabels();

        void ToggleByCityPanel();
        void ToggleByCoordsPanel();
    }
}
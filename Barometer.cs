/// <summary>
///  Simple barometer, measuring pressure in hPa (hectopascal)
/// </summary>
public class Barometer
{
    #region Properties
    public double Pressure { get; set; }

    public string WeatherDescription
    {
        get { 

            if (Pressure < 980)
            {
                return "Stormy";
            }
            else // Pressure >= 980
            if (Pressure <= 1000)
            {
                return "Rainy";
            }
            else // Pressure > 1000
            if (Pressure <= 1020)
            {
                return "Changing";
            }
            else // Pressure > 1020
            if (Pressure <= 1040)
            {
                return "Fair";
            }
            else
            //            if (Pressure > 1040)
            {
                return "Very Dry";
            }
        }
    }
    #endregion

    #region Constructor
    public Barometer()
    {
        Pressure = 1000.0;
    }
    #endregion
}

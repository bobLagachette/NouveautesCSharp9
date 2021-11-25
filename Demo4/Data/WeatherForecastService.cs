using System;
using System.Linq;
using System.Threading.Tasks;

namespace Demo4.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();

            //Mettons les infos dans un tableau
            var resultats = Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55)
            }).ToArray();

            //Utilisation du patterh mathing
            //Pattern relational >, <, >=, <=
            //Pattern logique: and, or ou not

            foreach (var res in resultats)
            {
                //trop long, pas une bonne idée
                //switch(res.TemperatureC)
                //{
                //    case 0:
                //        res.Summary = "En dessous du point de congélation";
                //        break;
                //    default:
                //        break;
                //}
               
                res.Summary = res.TemperatureC switch
                {
                    < -15 => "Il fait FRÈT",
                    >= -15 and < 0 => "Froid",
                    0 or 40 => "Exactement froid ou canicule",
                    > 0 and < 17 => "Frais",
                    >= 17 and < 30 => "Chaud",
                    >= 30 => "Canicule"
                };
            }

            return Task.FromResult(resultats); //Retour asynchrone....
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic30._09._2024
{


    internal class Program
    {
        static void HandlerProprtyChanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine($"Свойство {e.PropertyName} было изменено");
        }

 
        public event EventHandler ev;
        static void Main(string[] args)
        {
            /*Figure figure = new Figure();
            figure.AddFigure(new Rectangle('*', "red"));
            figure.AddFigure(new Triangle('*', "red"));
            figure.AddFigure(new Trapezoid('*', "red"));
            figure.ShowAll();

            Rectangle rectangle = new Rectangle('*', "red");*/
            /*string text = "Вот дом, Который построил Джек. А это пшеница," +
                " Которая в темном чулане хранится В доме, Который построил" +
                "Джек. А это веселая птица-синица, Которая часто ворует пшеницу," +
                "Которая в темном чулане хранится В доме, Который построил Джек";

            Jack jack = new Jack();
            jack.Add(text);
            Console.WriteLine(jack.ShowDict());*/

            /*PropertyObject propertyObject = new PropertyObject();
            propertyObject.PropertyChanged += HandlerProprtyChanged;

            propertyObject.MyProperty = "ertyyrg";*/

        }
    }
}

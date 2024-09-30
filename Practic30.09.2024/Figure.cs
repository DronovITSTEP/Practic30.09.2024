using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic30._09._2024
{
    /*
 Задание 1. Приложение «Фигуры»
Написать приложение, которое будет отображать в консоли
выбранные пользователем простейшие геометрические
фигуры: «прямоугольник», «ромб», «треугольник», «трапеция», 
«многоугольник». В меню пользователь выбирает
фигуры и выбирает цвета для каждой фигуры. Фигуры
рисуются звездочками или другими символами. Для реализации 
программы необходимо разработать иерархию
классов (продумать возможность абстрагирования). Все
заданные пользователем фигуры хранятся в объекте
«Обобщённая фигура», который имеет метод «отобразить
все выбранные фигуры».
 */
    interface IFigure
    {
        string Color {  get; }
        char Symbol {  get; }
        void Show();
    }
    class Figure
    {
        private List<IFigure> _figures;   
        public Figure()
        {
            _figures = new List<IFigure>();
        }
        public void AddFigure(IFigure figure)
        {
            _figures.Add(figure);
        }

        public void ShowAll()
        {
            if (_figures.Count != 0)
            {
                foreach (IFigure figure in _figures)
                {
                    figure.Show();
                }
            }
            else
            {
                Console.WriteLine("Нет фигур");
            }
        } 
    }
    class Rectangle : IFigure
    {
        public char Symbol { get; }
        public string Color {  get; }
        public Rectangle(char symbol, string color) { 
            Symbol = symbol;
            Color = color;
        }

        public void Show()
        {
            Console.WriteLine(nameof(Rectangle));
        }    
    }
    class Rhomb : IFigure
    {
        public char Symbol { get; }
        public string Color { get; }
        public Rhomb(char symbol, string color)
        {
            Symbol = symbol;
            Color = color;
        }
        public void Show()
        {
            Console.WriteLine(nameof(Rhomb));
        }
    }
    class Triangle : IFigure
    {
        public char Symbol { get; }
        public string Color { get; }
        public Triangle(char symbol, string color)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Show()
        {
            Console.WriteLine(nameof(Triangle));
        }
    }
    class Trapezoid : IFigure
    {
        public char Symbol { get; }
        public string Color { get; }
        public Trapezoid(char symbol, string color)
        {
            Symbol = symbol;
            Color = color;
        }

        public void Show()
        {
            Console.WriteLine(nameof(Trapezoid));
        }
    }
}

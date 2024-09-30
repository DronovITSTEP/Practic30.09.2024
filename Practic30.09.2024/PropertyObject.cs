using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practic30._09._2024
{
    /*
 Задание 1. Изменение свойств объекта класса
Создать интерфейс, который уведомляет пользователя
программы об изменении значений свойства в классе
(в котором реализуется данный интерфейс). Сигнатура
интерфейса:
interface IPropertyChanged
{
 event PropertyEventHandler PropertyChanged;
}
Делегат имеет следующий вид:
public delegate void PropertyEventHandler
 (object sender, PropertyEventArgs e);
где, в качестве дополнительного параметра (PropertyEventArgs) 
выступает имя изменённого свойства.
В методе Main() проверить работоспособность созданного
интерфейса.
 */
    public delegate void PropertyEventHandler 
        (object sender, PropertyEventArgs e);

    public class PropertyEventArgs : EventArgs
    {
        public string PropertyName {  get; set; } 
        public PropertyEventArgs(string prop)
        {
            PropertyName = prop;
        }
    }
    interface IPropertyChanged
    {
        event PropertyEventHandler PropertyChanged;
    }
    internal class PropertyObject : IPropertyChanged
    {
        public event PropertyEventHandler PropertyChanged;
        private string _myProperty;
        public string MyProperty { 
            get { return _myProperty; }
            set {
                _myProperty = value;
                PropertyChanged(this, new PropertyEventArgs(nameof(MyProperty)));
            }
        }
    }
}

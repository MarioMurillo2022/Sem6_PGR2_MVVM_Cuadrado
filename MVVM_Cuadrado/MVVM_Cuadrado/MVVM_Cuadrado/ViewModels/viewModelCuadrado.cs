using MVVM_Cuadrado.Models;
using System.ComponentModel;
using Xamarin.Forms;

namespace MVVM_Cuadrado.ViewModels
{
    public class viewModelCuadrado : INotifyPropertyChanged
    {

        public viewModelCuadrado()
        {

            crear = new Command(() => {

                Cuadrado c = new Cuadrado(lado1, lado2);
                Resultado = c.ToString();

            });

        }


        double lado1;

        public double Lado1
        {

            get => lado1;
            set
            {
                lado1 = value;
                var args = new PropertyChangedEventArgs(nameof(Lado1));
                PropertyChanged?.Invoke(this, args);
            }
        }

        double lado2;

        public double Lado2
        {

            get => lado2;
            set
            {
                lado2 = value;
                var args = new PropertyChangedEventArgs(nameof(Lado2));
                PropertyChanged?.Invoke(this, args);
            }
        }

        string resultado;

        public string Resultado
        {

            get => resultado;
            set
            {

                resultado = value;
                var args = new PropertyChangedEventArgs(nameof(Resultado));
                PropertyChanged?.Invoke(this, args);

            }

        }


        public Command crear { get; }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

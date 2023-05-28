using System;
using System.Collections.Generic;
using System.Text;

namespace MVVM_Cuadrado.Models
{
    public class Cuadrado
    {
        public double lado1 { get; set;}
        public double lado2 { get; set;}
        public double area { get; set;}
        public double perimetro { get; set;}

        public Cuadrado(double l1, double l2)
        {
            lado1 = l1;
            lado2 = l2;
            calcularArea();
            calcularPerimetro();
        }

        public void calcularArea()
        {
            area = (lado1 * lado2);
        }

        public void calcularPerimetro()
        {
            perimetro = (lado1 * 2) + (lado2 * 2);
        }

        public override string ToString()
        {
            return $" Area: {area} - Perimetro: {perimetro}";
        }

    }
}

using System;

namespace GeoApp.Models
{
    public static class Calculadora
    {
       public double CalcularAreaCirculo(double radio)
{
    return Math.PI * Math.Pow(radio, 2);
}
    }
}
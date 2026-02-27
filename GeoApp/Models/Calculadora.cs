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

    public double CalcularPerimetroCirculo(double radio)
{
    return 2 * Math.PI * radio;
}
}
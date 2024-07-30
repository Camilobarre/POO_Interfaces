using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models;
public class Animal
{
    public string Nombre { get; set; }
    public double PesoKG { get; set; }

    public Animal(string nombre, double peso)
    {
        this.Nombre = nombre;
        this.PesoKG = peso;
    }
}
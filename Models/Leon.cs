using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models;
public class Leon : Animal
{
    public bool Melena { get; set; }

    public Leon(string nombre, double pesoKG, bool melena) : base(nombre, pesoKG)
    {
        this.Melena = Melena;
    }

    //Clase abstracta que viene del padre, se usa la palabra clave Override
    public override void Respirar()
    {
        Console.WriteLine($"{Nombre} está respirando lentamente.");
    }
}
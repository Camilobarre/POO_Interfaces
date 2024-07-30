using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models;
public class Oso: Animal
{
    public bool Hibernar { get; set; }

    public Oso(bool hibernar, string nombre, double pesoKG) : base(nombre, pesoKG)
    {
        this.Hibernar = hibernar;
    }
}
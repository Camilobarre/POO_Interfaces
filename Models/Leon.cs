using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POO_Interfaces.Models;
public class Leon : Animal
{
    public bool Melena { get; set; }

    public Leon(bool melena, string nombre, double pesoKG) : base(nombre, pesoKG)
    {
        this.Melena = Melena;
    }
}
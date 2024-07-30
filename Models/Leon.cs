using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using POO_Interfaces.Interfaces;

namespace POO_Interfaces.Models;

//Se puede heredar tanto de una clase como de una interfaz
public class Leon : Animal, IAnimal
{
    public bool Melena { get; set; }

    public Leon(string nombre, double pesoKG, bool melena) : base(nombre, pesoKG)
    {
        this.Melena = Melena;
    }

    //Primero se implementan los métodos de la interfaz y después los métodos que queramos
    public void Comer()
    {
    }

    public void Dormir()
    {
    }

    public void Desplazar()
    {
    }

    //Método abstracto que viene de la clase animal (Se usa override para utilizarlo)
    public override void Respirar()
    {
    }


    //Clase abstracta que viene del padre, se usa la palabra clave Override
    // public override void Respirar()
    // {
    //     Console.WriteLine($"{Nombre} está respirando lentamente.");
    // }
}
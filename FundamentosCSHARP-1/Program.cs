// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// datos simples

// bool siOno = true; boolean
// byte numero = 255;
// sbyte numero = -128;
// sbyte numero = 122;
// int numero = +-255*4;
// uint numero = +255+4;
// long numero = +-...;
// ulong numero = +...;
// float numero = 189.1f; 4 bytes
// double numero = 189.1d; 8 bytes
// decimal numero = 189.1m; 16 bytes
// char carecter = 'A'; 2 bytes (una sola letra y comillas simples)

// datos compuestos

// string caracteres = "A"; múltiples letras y con comillas dobles
// DateSTime date = DateTime.Now; clases

// int numero; daría un error por no inicializarce
// int numero = new int(); este method permite inicializar, ya que no se puede dejar sin inicializar
// Console.WriteLine(numero.ToString()); ----> Se inicializa con 0

// int numero = null; da un error
// int? numero = null; permite inicializar con null cualquier tipo nativo como float, char.

// Palabra reservada ----> var
// Lo que hace es asignar un valor a la variable y a su vez, asignar su tipo
// Var no puede ser un atributo, pero si es permitido utilizarce en un method local
// var nombre = "Alessandro";

// Every elementos heredan del tipo de dato Object en C#
// object persona = new { nombre = "Alessandro", apellido = "Rivas" };
// Console.WriteLine(persona.nombre, persona.apellido); no funciona porque al asignarle un objeto ANÓNIMO pierde sus cualidades

// var persona = new { nombre = "Alessandro", apellido = "Rivas" };
// Console.WriteLine(persona.nombre, persona.apellido); por el contrario, var si permite acceder a sus propiedades

using System;

namespace FundamentosCSHARP_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = new int();
            Console.WriteLine(numero.ToString());
        }
    }
}

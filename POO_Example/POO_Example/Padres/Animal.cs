using System;
using System.Collections.Generic;
using System.Text;

namespace POO_Example.Padres
{
    public class Animal
    {
        private string? _nombre;
        private int _edad=0;
        private char _sexo;
        protected string _formaReproduccion;
        protected double _tamanio;
        protected string _especie;
        protected int _periodoIncubacion;
        public Animal(string nombre,int edad,char sexo)
        {
            _nombre = nombre;
            _edad = edad;
            _sexo = sexo;

        }
        public void SetNombre(string nombre)
        {
            _nombre = nombre;
        }
        public void SetEdad()
        {
            _edad++;
        }
        public string GetNombre()
        {
            return _nombre;
        }
        public int GetEdad()
        {
            return _edad;
        }
        public char GetSexo()
        {
            return _sexo;
        }
        public  void DiTuNombre()
        {
            Console.WriteLine($"Mi nombre es: {this.GetNombre().ToString()}");

        }

        public void DiTuEdad()
        {
            Console.WriteLine($"Mi edad es: {this.GetEdad()}");
        }

        public void DiTuGenero()
        {
            switch (this.GetSexo())
            {
                case 'm':
                case 'M':
                    Console.WriteLine("Mi genero es: Masculino");
                    break;
                case 'F':
                case 'f':
                    Console.WriteLine("Mi genero es: Fememnino");
                    break;

            }
        }


        public virtual void DiTutamanio()
        {
            
        }

        public virtual void DiTuTiempoDeIncubacion()
        {

        }

        public virtual void DiTuEspecie()
        {
           
        }





    }
}

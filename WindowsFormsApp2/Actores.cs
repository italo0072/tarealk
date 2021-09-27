using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Actores
    {
        private string _Nombre;
        private string _Nacionalidad;
        private string _edad;
        private string _Genero;
        private string _Premios;


        public Actores()
        { }


        public Actores(string nombre, string nacionalidad, string edad, string genero, string premios)
        {
            _Nombre = nombre;
            _Nacionalidad = nacionalidad;
            _edad = edad;
            _Genero = genero;
            _Premios = premios;
        }
        public void setNombre(string nombre)
        {
            _Nombre = nombre;
        }
        public string getNombre()
        {
            return _Nombre;
        } public void setNacionalidad(string nacionalidad)
        {
            _Nacionalidad = nacionalidad;
        }
        public string getNacionalidad()
        {
            return _Nacionalidad;
        }
        public void setedad(string edad)
        {
            _edad = edad;
        }
        public string getedad()
        {
            return _edad;
        }
        public void setGenero(string genero)
        {
            _Genero = genero;
        }
        public string getGenero()
        {
            return _Genero;
        }
        public void setpremios(string premios)
        {
            _Premios = premios;
        }
        public string getpremios()
        {
            return _Premios; 
        }



        public string get1()
        {
            return "Nombre : " + _Nombre;

        } 
        public string get2()
        {
            return "Nacionalidad : " + _Nacionalidad;

        }public string get3()
        {
            return "Edad : " + _edad;

        }public string get4()
        {
            return "Genero : " + _Genero;

        }public string get5()
        {
            return "Cantidad de premios : " + _Premios;

        }
    }
}

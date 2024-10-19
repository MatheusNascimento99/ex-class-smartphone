using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_Celular.Models
{
    public abstract class Smartphone(string numero, string modelo, string imei, int memoria)
    {
        public string Numero { get; set; } = numero;
        private string Modelo { get; set; } = modelo;
        private string IMEI { get; set; } = imei;
        private int Memoria { get; set; } = memoria;

        #region MÉTODOS
        public void Ligar()
        {
            Console.WriteLine("Ligando Celular...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
        #endregion
    }
}
/*
public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private string Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, string memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }
*/
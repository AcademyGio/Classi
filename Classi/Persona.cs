using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi
{
    class Persona
    {
        private static int _ID; // un unico membro per tutta la classe

        // costruttore, non ha tipo di ritorno e ha il nome della Classe
        // può avere parametri
        public Persona(string nome, string cognome, DateTime dataNascita)
        {
            ID = ++_ID;
            Nome = nome;    // nel costruttore sono inizializzazioni
            Cognome = cognome;  // e si possono fare anche su property non settabili
            DataNascita = dataNascita;
//            campo = dataNascita.Year;
        }

        // const è valorizzato a compile time
        // readonly è valorizzao a run time
//        readonly int campo;

        public int ID { get; }
        public string Nome { get; }
        public string Cognome { get; }
        public DateTime DataNascita { get; }

        // TODO
        public int Eta
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public string DatiAnagrafici
        {
            get
            {
                return ID + " " + Nome + " " + Cognome + " " + DataNascita.ToShortDateString();
            }
        }
    }
}

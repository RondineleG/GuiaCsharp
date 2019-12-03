using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes {
    // Modificadores de acesso publico
    public class CriandoClasse {
        //propriedade
        public string campo = string.Empty;

        //Contrutor
        public CriandoClasse () {

        }
        //metodo
        public void MeuMetodo (int primeiroParametro, string segundoParametro) {
            Console.WriteLine ("Primeiro Parametro {0}, Segundo Parametro {1}",
                primeiroParametro, segundoParametro);
        }

        //propriedade automatica
        public int PropriedadeAutomatica { get; set; }

        //propriedade encapsulada
        private int _minhaPropriedade;

        public int MinhaPropriedade {
            get { return _minhaPropriedade; }
            set { _minhaPropriedade = value; }
        }

        private int _aplicandoLogica;

        public int Logica {
            get {
                return _aplicandoLogica / 2;
            }

            set {
                if (value > 100)
                    _aplicandoLogica = 100;
                else
                    _aplicandoLogica = value;;
            }
        }
    }
}
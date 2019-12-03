using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    public class CriandoClasse
    {
        public string  campo = string.Empty;    

    public void MeuMetodo(int primeiroParametro, string segundoParametro)
    {
        Console.WriteLine("Primeiro Parametro {0}, Segundo Parametro {1}",
                                                    primeiroParametro, segundoParametro);
    }

    public int PropriedadeAutomatica { get; set; }


    private int _minhaPropriedade;

    public int MinhaPropriedade
    {
        get { return _minhaPropriedade; }
        set { _minhaPropriedade = value; }
    } 
    }

}

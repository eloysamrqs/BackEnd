using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicio2
{
public class Contrato : IImprimivel
{
    public string Contratante = "";
    public string PrestadorServico = "";
    public string TextoClausulas = "";

    public Contrato(string contratante, string contratada, string txtClausulas)
        {
            Contratante = contratada;
            TextoClausulas = txtClausulas;
            PrestadorServico = contratada;
        }
        
    public void Imprimir()
    {
        Console.WriteLine($@"
        Partes: 
            Constratante: {Contratante}
            Contratada: {PrestadorServico}
            Cláusulas do contrato:
            
            {TextoClausulas}
            
            -------------------------------");

    }
}
}
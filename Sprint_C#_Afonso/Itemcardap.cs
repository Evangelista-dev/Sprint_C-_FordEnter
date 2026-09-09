using System;
using System.Collections.Generic;
using System.Text;

public abstract class ItemCardapio
{
    public int Codigo { get; set; }
    public string Descricao { get; set; }
    public double PrecoBase { get; set; }


    public virtual double CalcularPreco()
    {
        return PrecoBase;
    }
}
using System;
using System.Collections.Generic;
using System.Text;

public class Lanche : ItemCardapio
{
    public List<string> IngredientesExtras { get; set; } = new List<string>();

    public override double CalcularPreco()
    {

        double valorExtras = IngredientesExtras.Count * 3.0;
        return PrecoBase + valorExtras;
    }
}

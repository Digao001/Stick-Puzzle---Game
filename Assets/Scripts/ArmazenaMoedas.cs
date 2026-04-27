using UnityEngine;

public static class ArmazenaMoedas
{
    public static MoedasController total;

    public static int PegarTotal()
    {
        if (total != null)
        {
            return total.quantidadeMoedas;
        }
        else
        {
            return 0;
        }
    }
        
}

using UnityEngine;

public static class ArmazenaMoedas2
{
    public static MoedasController2 total2;

    public static int PegarTotal2()
    {
        if (total2 != null)
        {
            return total2.quantidadeMoedas;
        }
        else
        {
            return 0;
        }
    }
        
}

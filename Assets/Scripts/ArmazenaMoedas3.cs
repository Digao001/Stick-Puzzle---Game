using UnityEngine;

public class ArmazenaMoedas3 : MonoBehaviour
{
  
    public static MoedasController3 total3;

    public static int PegarTotal2()
    {
        if (total3 != null)
        {
            return total3.quantidadeMoedas;
        }
        else
        {
            return 0;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;
public class Fases : MonoBehaviour
{
    public GameObject fase2;

    void Update()
    {
        if (DadosJogo.fase1Concluida)
        {      
            fase2.SetActive(true);
        }
    }
}

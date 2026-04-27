using UnityEngine;

public class Teste : MonoBehaviour
{
   
    void Start()
    {
        Debug.Log("Total moedas: " + PlayerPrefs.GetInt("MoedasFase1"));
    }

}

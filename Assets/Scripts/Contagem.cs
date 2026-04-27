using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class Contagem : MonoBehaviour
{
    public TextMeshProUGUI contagem;
    public GameObject kill;
    public GameObject salvarEstrelas;
    public GameObject Porta;
    public int controlerContador = 45;
    void Start()
    {
        InvokeRepeating("Contador", 0.1f, 1f);
    }

    public void Contador()
    {
        controlerContador--;
        contagem.SetText($"{controlerContador}");
        if (controlerContador <= 15) contagem.color = Color.red;
        if(controlerContador == 0)
        {
            CancelInvoke("Contador");
            Porta.SetActive(true);
            salvarEstrelas.SetActive(true);
        }

    }


}

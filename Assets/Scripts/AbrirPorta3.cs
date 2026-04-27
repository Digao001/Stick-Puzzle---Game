using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirPorta3 : MonoBehaviour
{
    
      public MoedasController3 moedasFase3;
    void OnTriggerEnter2D(Collider2D other)
    {
       if(other.gameObject.CompareTag("Player")) StartCoroutine(esperarProximaFase());    
        
    }

    IEnumerator esperarProximaFase()
    {
        PlayerPrefs.SetInt("MoedasFase3", moedasFase3.quantidadeMoedas);
        Debug.Log("Moedas fase3 " + moedasFase3.quantidadeMoedas);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Fases");
    }
}

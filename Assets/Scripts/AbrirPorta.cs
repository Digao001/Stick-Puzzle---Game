using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirPorta : MonoBehaviour
{
    public Sprite novoSprite;
    public PegarChave chave;
    public SpriteRenderer portaSprite;
    public MoedasController moedasFase1;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && chave.possuiChave)
        {
            portaSprite.sprite = novoSprite;
            DadosJogo.fase1Concluida = true;
            StartCoroutine(esperarProximaFase());    
        }
    }

    IEnumerator esperarProximaFase()
    {
        PlayerPrefs.SetInt("MoedasFase1", moedasFase1.quantidadeMoedas);
        Debug.Log("Moedas fase1 " + moedasFase1.quantidadeMoedas);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Fases");
    }
}


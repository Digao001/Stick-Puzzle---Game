using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
public class AbrirPorta2 : MonoBehaviour
{
    public Sprite novoSprite2;
    public PegarChave chave;
    public SpriteRenderer portaSprite;
    public MoedasController2 moedasFase2;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && chave.possuiChave)
        {
            portaSprite.sprite = novoSprite2;
            DadosJogo.fase1Concluida = true;
            StartCoroutine(esperarProximaFase());    
        }
    }

    IEnumerator esperarProximaFase()
    {
        PlayerPrefs.SetInt("MoedasFase2", moedasFase2.quantidadeMoedas);
        Debug.Log("Moedas fase2 " + moedasFase2.quantidadeMoedas);
        PlayerPrefs.Save();
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene("Fases");
    }
}

using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class PegarChave : MonoBehaviour
{

    public TextMeshProUGUI textoChave;
    public bool possuiChave = false;
    public Image chave;
    public Sprite imgChave;
    
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            possuiChave = true;
            Debug.Log("Colidiu com chave");
            Destroy(gameObject);
            chave.sprite = imgChave;
            chave.color = Color.white;
        }
    }
}

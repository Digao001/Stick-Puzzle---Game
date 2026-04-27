using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PedraDie : MonoBehaviour
{
    public Image TelaKill;
    public Sprite TelaMorte;
    public Sprite vazio;
    void Start()
    {
        if (TelaKill != null) TelaKill.sprite = vazio;
    }

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            Debug.Log("Colidiu com pedra");
            TelaKill.sprite = TelaMorte;
            
        }
    }
}

using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Unity.VisualScripting;
using System.Collections;

public class JogadorDie : MonoBehaviour
{
    public GameObject kill;


    void Start()
    {
        if (kill == null)
        {
            kill = GameObject.Find("Kill");
            Debug.Log("Kill encontrado: " + kill);
        }

        if (kill != null)
        {
            kill.SetActive(false);
        }


    }


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (kill != null)
            {
                kill.SetActive(true);

            }
            StartCoroutine(recarregarCena());
        }
    }

    IEnumerator recarregarCena()
    {
        yield return new WaitForSeconds(0.5f);
        Scene cenaAtual = SceneManager.GetActiveScene();
        SceneManager.LoadScene(cenaAtual.name);

    }
}

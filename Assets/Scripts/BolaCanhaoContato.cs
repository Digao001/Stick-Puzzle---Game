using UnityEngine;
using UnityEngine.SceneManagement;
public class BolaCanhaoContato : MonoBehaviour
{
  void OnTriggerEnter2D(Collider2D other)
  {
    if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("Acertou");
            SceneManager.LoadScene("Fase2");
        }
  }
}

using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Menu : MonoBehaviour
{
    public void Jogar()
    {
        SceneManager.LoadScene("Fases");
    }
    
    public void Sair()
    {
        Application.Quit();
        Debug.Log("Saiu");
    }
}

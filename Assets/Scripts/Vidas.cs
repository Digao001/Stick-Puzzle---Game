using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Vidas : MonoBehaviour
{
    public GameObject kill;
    public int vidasTotal = 4;
    public Sprite coracao3;
    public Sprite coracao2;
    public Sprite coracao1;
    public Image coracoes;

    public void TirarVida()
    {
        vidasTotal--;
        switch (vidasTotal)
        {
            case 3:
                coracoes.sprite = coracao3;
                break;
            case 2:
                coracoes.sprite = coracao2;
                break;
            case 1:
                coracoes.sprite = coracao1;
                break;
            case 0:
                Scene cenaAtual = SceneManager.GetActiveScene();
                kill.SetActive(true);
                SceneManager.LoadScene(cenaAtual.name);
                break;

        }
    }
}

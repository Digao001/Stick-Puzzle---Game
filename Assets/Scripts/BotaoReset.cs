using UnityEngine;
using UnityEngine.SceneManagement;
public class BotaoReset : MonoBehaviour
{
   public void resetar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}

using UnityEngine;

public class TextoGo : MonoBehaviour
{
    void Start()
    {

        Invoke("Comecar", 2.5f);
    }


    public void Comecar()
    {
        this.gameObject.SetActive(false);
    }
}

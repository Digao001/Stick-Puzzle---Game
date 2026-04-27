using UnityEngine;

public class Vai : MonoBehaviour
{
    void Start()
    {

            Invoke("Comecar", 1.5f);
        }
    

    public void Comecar()
    {
        //this.gameObject.SetActive(false);
    }
}

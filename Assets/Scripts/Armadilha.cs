using UnityEngine;

public class Armadilha : MonoBehaviour
{

    public Rigidbody2D pedra;
   
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            pedra.gravityScale = 6;
            Debug.Log("Pisou na armadilha");
        }
    }
}

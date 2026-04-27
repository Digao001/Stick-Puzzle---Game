using UnityEngine;

public class BlocoQuebravel : MonoBehaviour
{
    public Animator bloco;
    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Bomba"))
        {
            bloco.SetBool("blocoQuebrando", true);
            Debug.Log("Quebrou");
        }
    }

    public void destruirBloco()
    {
        Destroy(gameObject);
    }
}

using UnityEngine;

public class Canhao : MonoBehaviour
{
    public GameObject bolaCanhao;
    public Rigidbody2D canhaoPosicao;
    
    public GameObject ObjetoAtirar;

    public Rigidbody2D rb;
    public float velocidade = 10f;
    public Animator canhao;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ObjetoAtirar.SetActive(false);
            InvokeRepeating("atirando", 1f, 5f);

        }
    }


    public void atirando()
    {


            GameObject novaBala = Instantiate(bolaCanhao, canhaoPosicao.position, Quaternion.identity);
            novaBala.SetActive(true);
            rb = novaBala.GetComponent<Rigidbody2D>();
            rb.AddForce(Vector2.left * velocidade, ForceMode2D.Impulse);
            Destroy(novaBala, 3f);
     
       
    }
}

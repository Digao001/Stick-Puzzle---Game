using UnityEngine;

public class PuloJogador : MonoBehaviour
{
    public Rigidbody2D body2d;
    public float velocidade = 15;
    public bool solo = false;

    public Animator anim;
    void Start()
    {

    }


    void Update()
    {

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space) && solo)
        {
            anim.SetBool("jump", true);
            body2d.linearVelocity = Vector2.up * velocidade;
        }
    }
    
     void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("solo"))
        {
            solo = true;
            anim.SetBool("jump", false);
        }
    }
    
    void OnCollisionExit2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("solo"))
        {
            solo = false;    
        }
    }
}

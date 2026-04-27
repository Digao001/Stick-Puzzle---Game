using UnityEngine;

public class AnimaMola : MonoBehaviour
{
    [SerializeField] private Animator animatorMola;
    [SerializeField] private Animator animatorPlayer;
    [SerializeField] private Rigidbody2D body2d;
    public float forcaPulo = 23f;
    public bool pulo = true;
    void Start()
    {
        if (animatorMola == null) animatorMola = GetComponent<Animator>();
    }

    void OnCollisionEnter2D(Collision2D colide)
    {
        if (colide.gameObject.CompareTag("Player"))
        {
            pulo = true;
            if (pulo)
            {
                animatorMola.SetBool("Mola", true);
                animatorPlayer.SetBool("jump", true);
                body2d.linearVelocity = Vector2.up * forcaPulo;
            }
        }
    }
    
    void OnCollisionExit2D(Collision2D colide)
    {
         if (colide.gameObject.CompareTag("Player"))
        {
            pulo = false;
            animatorMola.SetBool("Mola", false);
        }
    }
}

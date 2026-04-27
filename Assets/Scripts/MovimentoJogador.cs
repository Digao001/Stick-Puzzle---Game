using UnityEngine;

public class MovimentoJogador : MonoBehaviour
{
    [SerializeField] Rigidbody2D body2d;
    [SerializeField] float velocidade = 8f;

    public Animator anima;
    private float horizontal;

    public bool caixa = false;
    void Start()
    {
        if (body2d == null) body2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        horizontal = Input.GetAxisRaw("Horizontal");

    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.A) && !caixa)
        {
            body2d.transform.localScale = new Vector2(-2, 2);
            anima.SetBool("run", true);
            
        }
        else if (Input.GetKey(KeyCode.D) && !caixa)
        {
            body2d.transform.localScale = new Vector2(2, 2);
            anima.SetBool("run", true);
           
        }
        else
        {
            anima.SetBool("run", false);
            
        }
        
        body2d.linearVelocity = new Vector2(horizontal * velocidade, body2d.linearVelocity.y);
    }

 
}

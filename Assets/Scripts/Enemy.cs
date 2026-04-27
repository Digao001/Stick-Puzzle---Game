using System.Collections;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    [SerializeField] private float velocidade;
    [SerializeField] private Rigidbody2D body2d;
    [SerializeField] private bool flag;
    [SerializeField] private Animator enemy;
    [SerializeField] private Vidas vidasTotal;
    public float forca = 50f;
    public SpriteRenderer background;
    public Transform backgroundPos;

    public RectTransform CoracaoPulsa;
    void Start()
    {
        executarInfinitamente();
    }

    public void executarInfinitamente()
    {

        InvokeRepeating("Andar", 1f, 3f);
    }

    public void Andar()
    {
        enemy.SetBool("andar", false);
        velocidade = Random.Range(7f, 10);
        flag = !flag;
        if (flag)
        {
            transform.localScale = new Vector3(-5, 5, 5);
            Debug.Log("Velocidade" + velocidade);
            Debug.Log("Flag = " + flag);
            enemy.SetBool("andar", true);
            body2d.linearVelocity = Vector2.right * velocidade;
            
        }
        if (!flag)
        {
            transform.localScale = new Vector3(5, 5, 5);
            Debug.Log("Velocidade" + velocidade);
            Debug.Log("Flag = " + flag);
            enemy.SetBool("andar", true);
            body2d.linearVelocity = Vector2.left * velocidade;
        }

        
    }

    void OnCollisionEnter2D(Collision2D colidiu)
    {
        if (colidiu.gameObject.CompareTag("Player"))
        {
            background.color = Color.red;
            vidasTotal.TirarVida();
            CoracaoPulsa.localScale = new Vector2(1.5f, 1.5f);
            StartCoroutine(VoltarCor());
        }
    }
    
    IEnumerator VoltarCor()
    {
        yield return new WaitForSeconds(0.5f);
        background.color = Color.white;
        CoracaoPulsa.localScale = new Vector2(1, 1);
    }
}

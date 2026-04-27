using UnityEngine;
using UnityEngine.SceneManagement;
public class Bomba : MonoBehaviour
{
    public Animator bombaAnim;

    public CircleCollider2D areaExplosao;
    public Transform tamanhoExplosao;
    [SerializeField] private Rigidbody2D bombaBody2d;
    [SerializeField] private float forca = 10f;
    public bool jogadorNaArea = false;
    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            bombaAnim.SetBool("bombaAtiva", true);
            Invoke("explodir", 3f);
            Debug.Log("Ativou bomba");
        }
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player") && jogadorNaArea)
        {
            Debug.Log("Area de explosao");
            SceneManager.LoadScene("Fase2");
        }

        if (other.gameObject.CompareTag("bloco"))
        {
            Debug.Log("Acertou o bloco");
        }
    }

    public void explodir()
    {
        jogadorNaArea = true;
        areaExplosao.isTrigger = true;
        areaExplosao.radius = 0.5f;
        bombaBody2d.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
        bombaAnim.SetBool("bombaBoom", true);
        tamanhoExplosao.localScale = new Vector3(8f, 8f, 4);
        Invoke("apagarBomba", 0.3f);
    }
    
    public void apagarBomba()
    {
        Destroy(gameObject, 0.3f);
    }

}

using UnityEngine;

public class EnemyCabeca : MonoBehaviour
{
    [SerializeField] private Animator enemy;
    [SerializeField] private GameObject enemyDeath;
    [SerializeField] private Rigidbody2D jogadorPulo;
    [SerializeField] private Collider2D inimigoTrigger;
    public float forcaPulo = 12f;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            jogadorPulo.linearVelocity = Vector2.up * forcaPulo;
            Debug.Log("Colidiu cabeça");
            enemy.SetBool("dead", true);
            inimigoTrigger.isTrigger = true;
            Destroy(enemyDeath, 1f);
            

        }
    }
}

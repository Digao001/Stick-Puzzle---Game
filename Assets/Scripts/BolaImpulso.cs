using UnityEngine;

public class BolaImpulso : MonoBehaviour
{
    public Rigidbody2D jogador;
    public Animator animPlayer;

    public float forcaPulo = 27f;

    void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if (collisionInfo.gameObject.CompareTag("Player"))
        {
            jogador.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
            animPlayer.SetBool("jump", true);
        }
    }
}

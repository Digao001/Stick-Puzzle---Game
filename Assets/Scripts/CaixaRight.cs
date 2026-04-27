using UnityEngine;

public class CaixaRight : MonoBehaviour
{
    public Animator animPlayer;
    public Rigidbody2D body2d;

    public Transform jogador;
    public float velo = 8f;
    public MovimentoJogador player;

    void OnTriggerEnter2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            player.caixa = true;
            body2d.linearVelocity = Vector2.left * velo;
            animPlayer.SetBool("chutar", true);
            body2d.transform.localScale = new Vector2(2, 2);
            Debug.Log("Colidiu, com lado direito");
        }
    }
    
    void OnTriggerExit2D(Collider2D colisao)
    {
        if (colisao.gameObject.CompareTag("Player"))
        {
            player.caixa = false;
            animPlayer.SetBool("chutar", false);
            Debug.Log("Saiu");
        }
    }
}

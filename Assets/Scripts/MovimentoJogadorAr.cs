using UnityEngine;

public class MovimentoJogadorAr : MonoBehaviour
{
    public Rigidbody2D jogador;
    public Transform jogadorDirection;
    public float velocidade = 10f;
    public float vertical;
    public float horizontal;
    void Start()
    {
        jogadorDirection.rotation = Quaternion.Euler(0, 0, -90f);
    }
    void Update()
    {
        vertical = Input.GetAxisRaw("Vertical");
        horizontal = Input.GetAxisRaw("Horizontal");
    }

    void FixedUpdate()
    {
        jogador.linearVelocity = new Vector2(jogador.linearVelocity.x, vertical * velocidade);
        jogador.linearVelocity = new Vector2(horizontal * velocidade,jogador.linearVelocity.y);
    }
}

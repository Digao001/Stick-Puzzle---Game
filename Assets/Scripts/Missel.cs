using UnityEngine;

public class Missel : MonoBehaviour
{
    [SerializeField] private Rigidbody2D Rocket;
    [SerializeField] private GameObject gerarRocket;
    [SerializeField] private GameObject ObjetoPai;
    public RandomController nivelDificuldade;
    public float velocidade;
    public int min = 15;
    public int max = 40;
    public bool condicaoParaGerar = false;
    void Start()
    {
        InvokeRepeating("GerarMissel", 1f, 4f);
    }

    public void GerarMissel()
    {
        if (nivelDificuldade.dificuldade >= 10) min = 30;
        if (nivelDificuldade.dificuldade >= 20) min = 50;
        if (nivelDificuldade.dificuldade >= 30) min = 70;
        condicaoParaGerar = !condicaoParaGerar;
        if (condicaoParaGerar)
        {
            max++;
            Debug.Log("Flag = " + condicaoParaGerar);
            Debug.Log("Min = " + min);
            Debug.Log("Max = " + max);
            Debug.Log("Dificuldade = " + nivelDificuldade.dificuldade);
            Instantiate(gerarRocket, ObjetoPai.transform);
            velocidade = Random.Range(min, max);
            Rocket.linearVelocity = Vector2.left * velocidade;
            Destroy(gameObject, 4f);
            CancelInvoke("GerarMissel");
        }

    }
}

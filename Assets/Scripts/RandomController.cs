using UnityEngine;

public class RandomController : MonoBehaviour
{
    [SerializeField] private GameObject random;
    private int posicaoRandom;
    public int dificuldade = 0;
    void Start()
    {
        InvokeRepeating("PosicaoRocket", 1f, 5f);
    }

    public void PosicaoRocket()
    {
        dificuldade += 3;
        posicaoRandom = Random.Range(-5, 9);
        random.transform.position = new Vector2(random.transform.position.x, posicaoRandom);
        CancelInvoke("´PosicaoRocket");
    }
}

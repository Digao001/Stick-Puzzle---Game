using UnityEngine;

public class LoopBackground : MonoBehaviour
{
    public float velocidade = 2f;
    public float max = 50f;
    void Update()
    {
        this.transform.Translate(Vector2.left * velocidade * Time.deltaTime);
        if (transform.position.x <= 0) transform.position = new Vector2(max, transform.position.y);
    }
}

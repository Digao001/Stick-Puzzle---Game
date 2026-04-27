using UnityEngine;

public class CameraMov : MonoBehaviour
{
    public Transform jogador;
    public float posYCam = -2.2f;
    void Start()
    {
        if (jogador == null) jogador = GameObject.FindGameObjectWithTag("Player").transform;
    }


    void Update()
    {
        this.transform.position = new Vector3(jogador.position.x, jogador.position.y - posYCam, transform.position.z);
    }
}

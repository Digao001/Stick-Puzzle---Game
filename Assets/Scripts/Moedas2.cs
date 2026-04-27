using UnityEngine;

public class Moedas2 : MonoBehaviour
{
   [SerializeField] private MoedasController2 MoedasControl;
    private bool coletada = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (coletada) return;

        if (other.gameObject.CompareTag("Player"))
        {
            coletada = true;
            MoedasControl.quantidadeMoedas++;
            Destroy(gameObject);
        }
    }
}

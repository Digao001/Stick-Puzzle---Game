using UnityEngine;
public class Moedas : MonoBehaviour
{
    [SerializeField] private MoedasController MoedasControl;
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

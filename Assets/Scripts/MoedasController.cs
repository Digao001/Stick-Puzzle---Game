using UnityEngine;
using TMPro;
public class MoedasController : MonoBehaviour
{
    public int quantidadeMoedas;
    [SerializeField] private TextMeshProUGUI totalMoedas;

    void Awake()
    {
        
        ArmazenaMoedas.total = this;
    }

    void FixedUpdate()
    {
        totalMoedas.SetText($"{quantidadeMoedas}");
    }
}

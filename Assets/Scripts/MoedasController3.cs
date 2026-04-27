using UnityEngine;
using TMPro;
public class MoedasController3 : MonoBehaviour
{
    public int quantidadeMoedas;
    [SerializeField] private TextMeshProUGUI totalMoedas;

    void Awake()
    {
        
        ArmazenaMoedas3.total3 = this;
    }

    void FixedUpdate()
    {
        totalMoedas.SetText($"{quantidadeMoedas}");
    }
}

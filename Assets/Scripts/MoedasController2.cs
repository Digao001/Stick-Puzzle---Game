using UnityEngine;
using TMPro;
public class MoedasController2 : MonoBehaviour
{
    public int quantidadeMoedas;
    [SerializeField] private TextMeshProUGUI totalMoedas;

    void Awake()
    {
        
        ArmazenaMoedas2.total2 = this;
    }

    void FixedUpdate()
    {
        totalMoedas.SetText($"{quantidadeMoedas}");
    }
}

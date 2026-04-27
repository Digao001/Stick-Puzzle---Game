using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class RandomMoedas : MonoBehaviour
{
    [SerializeField] private GameObject PosicaoMoedaPai;
    [SerializeField] private GameObject moedaInstanciada;
    public int Posicaox, posicaoy;

    void Start()
    {
        InvokeRepeating("RandomMoeda", 0.1f, 4f);
    }

    public void RandomMoeda()
    {
        Posicaox = Random.Range(-20, 16);
        posicaoy = Random.Range(-6, 7);
        PosicaoMoedaPai.transform.position = new Vector2(Posicaox, posicaoy);
        GameObject novaMoeda = Instantiate(moedaInstanciada, PosicaoMoedaPai.transform.position, Quaternion.identity);

        StartCoroutine(DeleteMoeda());

        IEnumerator DeleteMoeda()
        {
            yield return new WaitForSeconds(3f);
            Destroy(novaMoeda);
        }
    }

}

using System.Collections;
using UnityEngine;

public class ColisorPedra : MonoBehaviour
{
    public GameObject GerarPedra;
    public GameObject Colisor;
    public Transform PedraPai;
    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.CompareTag("Player") && GerarPedra != null) StartCoroutine(InstanciarPedra());
        else Debug.Log("Objeto já existe");

    }
    IEnumerator InstanciarPedra()
    {
        yield return new WaitForSeconds(0.5f);
        GameObject NovaPedra = Instantiate(GerarPedra, PedraPai);
        Colisor.SetActive(false);
        Destroy(NovaPedra, 1f);
        Invoke("AtivarScript", 1f);
    }
    public void AtivarScript()
    {
        CancelInvoke("AtivarScript");
        Colisor.SetActive(true);
    }

}

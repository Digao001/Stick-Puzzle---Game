using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;
public class ControladorEstrelas3 : MonoBehaviour
{
    public List<Image> imagens = new List<Image>();
    public List<Sprite> stars = new List<Sprite>();

    void Start()
    {
        if (PlayerPrefs.GetInt("MoedasFase3") >= 3) imagens[0].sprite = stars[0];
        if (PlayerPrefs.GetInt("MoedasFase3") >= 6) imagens[1].sprite = stars[1];
        if (PlayerPrefs.GetInt("MoedasFase3") >= 10) imagens[2].sprite = stars[2];
    }
}

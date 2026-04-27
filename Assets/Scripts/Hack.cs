using UnityEngine;

public class Hack : MonoBehaviour
{
   
    void Start()
    {
            PlayerPrefs.DeleteAll();
            PlayerPrefs.Save();
            
        }
    
}

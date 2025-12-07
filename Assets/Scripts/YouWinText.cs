using UnityEngine;
using UnityEngine.UI;
public class YouWinText : MonoBehaviour
{
    public GameObject winScreen;
    
    void Start()
    {
        winScreen.SetActive(false);
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            winScreen.SetActive(true);
        }
    }
}

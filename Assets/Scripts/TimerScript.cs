using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class TimerScript : MonoBehaviour
{
    [SerializeField] private float timer = 0f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        timer = timer + 1f;
    }
}

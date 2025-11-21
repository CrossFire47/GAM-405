using UnityEngine;

public class KeyShit : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private KeyTrigger keyTriggerImInRangeOf;


    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<KeyTrigger>() != null)
        {
            keyTriggerImInRangeOf = other.GetComponent<KeyTrigger>();
        }
    }

    void OnTriggerExit(Collider other)
    {
        
        if (other.GetComponent<KeyTrigger>() != null)
        {
            keyTriggerImInRangeOf = null;
        }
    }
}

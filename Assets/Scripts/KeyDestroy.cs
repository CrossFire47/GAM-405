using UnityEngine;

public class KeyDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnCollisionEnter(Collision collision)
    {
       if (collision.gameObject.CompareTag("Key"))
       {
           Destroy(collision.gameObject);
           Debug.Log("Key Destroyed");
       }
    }

    
}

using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        Debug.Log("Collision Detected with " + other.gameObject.name);  
        if (other.gameObject.CompareTag("Key"))
        {
            OpenDoor();
            
        }
    }


    public void OpenDoor()
    {
        this.gameObject.SetActive(false);
        
        Debug.Log("Door Opened");
    }
    
    
}

using UnityEngine;

public class GoobyWallTragicDeath : MonoBehaviour
{
    public GameObject goobyWall;
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            goobyWall.SetActive(false);
        }

    }
    
}

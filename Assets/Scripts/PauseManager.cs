using UnityEngine;

public class PauseManager : MonoBehaviour
{
    public bool paused;
    
    public void TogglePause()
    {
        paused = !paused;
        EventManager.InvokeTogglePause(paused);
    }

    
    
}

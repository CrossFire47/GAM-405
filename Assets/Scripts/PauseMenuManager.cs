using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;


    private void OnEnable()
    {
        EventManager.TogglePause += TogglePauseMenu;
    }


    private void OnDisable()
    {
        EventManager.TogglePause -= TogglePauseMenu;
    }
    
    private void TogglePauseMenu(bool paused)
    {
        pauseMenu.SetActive(paused);
    }
    
    
}

using UnityEngine;

public class PauseMenuManager : MonoBehaviour
{
    [SerializeField] GameObject pauseMenu;

    void Start()
    {
        pauseMenu.SetActive(false);
    }


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

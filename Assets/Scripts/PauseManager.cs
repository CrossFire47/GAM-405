using UnityEngine;
using UnityEngine.UI;
public class PauseManager : MonoBehaviour
{
    public bool paused;
    public GameObject pauseMenuUI;
    
    public void TogglePause()
    {
        paused = !paused;
        EventManager.InvokeTogglePause(paused);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenuUI.SetActive(!pauseMenuUI.activeSelf);
            Cursor.visible = pauseMenuUI.activeSelf;
            Cursor.lockState = pauseMenuUI.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }
    
    public void ResumeGame()
    {
        
        pauseMenuUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting Game");
    }
}

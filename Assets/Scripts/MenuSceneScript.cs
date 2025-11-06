using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
public class MenuSceneScript : MonoBehaviour
{

  
    private void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    public void PressedStartButton(InputAction.CallbackContext inputData)
    {
        LoadMainScene();
        Debug.Log("InputRecieved");
    }

    public void LoadMainScene()
    {
        SceneManager.LoadScene("FelonRooms");
        Debug.Log("AttemptingLoad");
    }

    private void Update()
    {
        if (Input.anyKeyDown)
        {
            LoadMainScene();

            return;
        }
    }
   
}


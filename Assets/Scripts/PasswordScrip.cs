using UnityEngine;
using UnityEngine.UI;
public class PasswordScrip : MonoBehaviour
{
    [Header("Password Settings")]
    public string correctPassword = "8329561";
    public string input;
    public Text displayText;

    public GameObject passwordScreen;
    [SerializeField] private float btnClicked = 0;
    private float numOfGuesses;
    


    void Start()
    {
        btnClicked = 0;
        numOfGuesses = correctPassword.Length;
        passwordScreen.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passwordScreen.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passwordScreen.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            
        }
    }
    void OnTriggerStay(Collider other)
    {
        Cursor.visible = passwordScreen.activeSelf;
        Cursor.lockState = passwordScreen.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
    }

    
    void Update()
    {
        if(input == correctPassword)
        {
            gameObject.SetActive(false);
        }
        
    }

    public void One()
    {
        btnClicked = btnClicked + 1;
    }
}

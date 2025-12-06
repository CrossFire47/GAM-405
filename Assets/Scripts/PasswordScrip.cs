using UnityEngine;
using UnityEngine.UI;
public class PasswordScrip : MonoBehaviour
{
    
    [Header("Objects to Hide/Show")]
    public GameObject objectToDisable;
    public GameObject objectToDisable2;
    
    public GameObject objectToEnable;

    [Header("Password Settings")]
    public string correctPassword = "8329561";
    public string input;
    public Text displayText;

    private bool passwordScreen;
    private float btnClicked = 0;
    private float numOfGuesses;
    


    void Start()
    {
        btnClicked = 0;
        numOfGuesses = correctPassword.Length;
        displayText.SetActive(false);
    }

    
    void Update()
    {
        if(btnClicked == numOfGuesses)
        {
            if (input == correctPassword)
            {
                Debug.Log("Correct Password!");
                input = "";
                btnClicked = 0;
            }
            else
            {
                input = "";
                displayText.text = input.ToString();
                btnClicked = 0;
            }
        }  
            
    }

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.CompareTag("Player"))
        {
            passwordScreen = true;

            if (passwordScreen)
            {
                objectToDisable.SetActive(false);
                objectToDisable2.SetActive(false);
                objectToEnable.SetActive(true);
            }
        }
    }

    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": //QUIT
                objectToDisable.SetActive(true);
                objectToDisable2.SetActive(true);
                objectToEnable.SetActive(false);
                btnClicked = 0;
                passwordScreen = false;
                input = "";
                displayText.text = input.ToString();
                break;

            case "C": //CLEAR
                input = "";
                btnClicked = 0; //Clear Guess Count
                displayText.text = input.ToString();
                break;

            default: // Button clicked add a variable
                btnClicked++;
                input += valueEntered;
                displayText.text = input.ToString();
                break;    

        }
    }
}

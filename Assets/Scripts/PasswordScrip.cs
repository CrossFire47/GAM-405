using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PasswordScrip : MonoBehaviour
{
    

    [Header("Password Settings")]
    public string correctPassword = "8329561";
    public string input;
    public TMP_Text displayText;

    private bool passwordScreen;
    private float btnClicked = 0;
    private float numOfGuesses;
    
    public GameObject passInputUI;

    void Start()
    {
        btnClicked = 0;
        numOfGuesses = correctPassword.Length;
        
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

    public void One()
    {
        btnClicked = btnClicked + 1;
        input.ToString();
        
    }

    
   
   
   
    public void ValueEntered(string valueEntered)
    {
        switch (valueEntered)
        {
            case "Q": //QUIT
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

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
    }

    
    void Update()
    {
        if(input == correctPassword)
        {
            
        }
    }
}

using UnityEngine;


public class MovementScript : MonoBehaviour
{
    enum PlayerState {Idle, Moving, Jumping}
    [Header("States")]
    [SerializeField] PlayerState currentState = PlayerState.Idle;
    [Header("Speeds")]
    [SerializeField] float movementSpeed = 5f;

    Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
     
    void Update()
    {
        switch (currentState)
        {
            case PlayerState.Idle:
                //Idle crap
                if (Input.GetKeyDown(KeyCode.W))
                    currentState = PlayerState.Moving;               
                break;
            case PlayerState.Moving:
                //Moving innit
                transform.Translate(Vector3.forward * movementSpeed * Time.deltaTime);
                if (!Input.GetKeyDown(KeyCode.W))
                    currentState = PlayerState.Idle;
                
                break;
        }
        
    }

 
}

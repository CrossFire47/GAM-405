using UnityEngine;
using UnityEngine.UI;
public class PasswordActivation : MonoBehaviour
{
    public GameObject passInputUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passInputUI.SetActive(true);
            Cursor.lockState = passInputUI.activeSelf ? CursorLockMode.None : CursorLockMode.Locked;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            passInputUI.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}

using UnityEngine;
using Unity.Cinemachine;
using Unity.IO.LowLevel.Unsafe;
using System.Collections;
public class CinemachineScrip : MonoBehaviour
{
    [SerializeField] CameraControl cc;
    [SerializeField] PlayerRotate pr;

    private void Start()
    {
        gameObject.GetComponent<CinemachineCamera>().Priority = 5;

        StartCoroutine(EnablePlayer());
    }

    private IEnumerator EnablePlayer()
    {
        yield return new WaitForSeconds(3f);
        cc.isActive = true;
        pr.isActive = true;
    }
   
}

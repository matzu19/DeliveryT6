using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition : MonoBehaviour
{

    [SerializeField] SwitchLever SwitchLever1, SwitchLever2;
    [SerializeField] GameObject S3, canvaWin;


    private void Awake()
    {
        canvaWin.SetActive(false);
    }
    private void Update()
    {
        if (SwitchLever1.win && SwitchLever2.win && S3.activeInHierarchy)
        {
            canvaWin.SetActive(true);
            Debug.Log("---Ganaste---");
        }
    }
}

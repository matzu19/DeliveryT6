using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{

    [SerializeField] SwitchLever SwitchLever1, SwitchLever2, switchLever3;
    [SerializeField] GameObject  canvaWin;


    private void Awake()
    {
        canvaWin.SetActive(false);
    }
    private void Update()
    {
        try
        {
            if (SwitchLever1.win && SwitchLever2.win && switchLever3.win)
            {
                SceneManager.LoadScene("cinematic Win");
                //canvaWin.SetActive(true);
                Time.timeScale = 0;
            }
        }
        catch (NullReferenceException)
        {

        }
    }
}

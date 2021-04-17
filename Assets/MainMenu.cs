using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    private bool menuactivo;
    [SerializeField] private UnityStandardAssets.Characters.FirstPerson.FirstPersonController mouseLocking;
    private void Awake()
    {
        menuactivo = false;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && menuactivo == false)
        {
            Debug.Log("pauso");
            menuactivo = true;
            panel.SetActive(true);
            Time.timeScale = 0f;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && menuactivo == true)
        {
            Debug.Log("jugue");
            menuactivo = false;
            panel.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void Continue()
    {
        Debug.Log("jugue");
        menuactivo = false;
        panel.SetActive(false);
        Time.timeScale = 1f;
    }
}

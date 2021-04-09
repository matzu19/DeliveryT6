using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    private string input;
    [SerializeField]private GameObject canvasField;
    private void Start()
    {
        input = "britishman";
    }

    public void ReadPassword(string s)
    {
        s=s.ToLower();
        if (s == input)
        {
            canvasField.SetActive(false);
            Debug.Log("contraseña correcta");
        }
        else
        {
            Debug.Log("contraseña incorrecta");
        }


        
    }
}

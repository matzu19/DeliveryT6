using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
   
    public void CargaNivel(string Namenivel) //envia a escena por nombre de la misma
    {
        
        SceneManager.LoadScene(Namenivel);
    }

    public void Salir()
    {
        Application.Quit();
        Debug.Log("Exit Game");
    }
}

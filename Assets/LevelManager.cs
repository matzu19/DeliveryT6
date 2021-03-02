using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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

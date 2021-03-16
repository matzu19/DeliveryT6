using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TimeCounter : MonoBehaviour
{
    public float tiempo;
    public string nameLevel;
    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }
    private void Start()
    {
        StartCoroutine(waitLevel(tiempo));
    }

/*
    public void CargaNivel(string Namenivel) //envia a escena por nombre de la misma
    {

        SceneManager.LoadScene(Namenivel);
    }*/

    IEnumerator waitLevel(float n)
    {
        yield return new WaitForSeconds(n);
        //CargaNivel(nameLevel);
        SceneManager.LoadScene(nameLevel);
    }
}

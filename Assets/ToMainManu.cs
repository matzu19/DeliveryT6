using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ToMainManu : MonoBehaviour
{
    [SerializeField]
    GameObject text;
    // Start is called before the first frame update
    private void OnEnable()
    {
        StartCoroutine("wait");
       
    }
    
    IEnumerator wait()
    {
        text.SetActive(true);
        yield return new WaitForSeconds(2f);
        Application.Quit();
    }
}

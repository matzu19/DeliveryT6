using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Password : MonoBehaviour
{
    private string input;
    [SerializeField]private GameObject canvasField;
    AudioSource feedback;
    public AudioClip error;
    public AudioClip discover;
    private void Start()
    {
        feedback = gameObject.GetComponent<AudioSource>();
        input = "970515";
    }

    public void ReadPassword(string s)
    {
        s=s.ToLower();
        if (s == input)
        {
            feedback.clip = discover;
            feedback.Play();
            StartCoroutine(waitTime());
            //canvasField.SetActive(false);
            Debug.Log("contraseña correcta");
        }
        else
        {
            feedback.clip = error;
            feedback.Play();
            Debug.Log("contraseña incorrecta");
        }
        
    }
    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(2f);
        canvasField.SetActive(false);

    }
}

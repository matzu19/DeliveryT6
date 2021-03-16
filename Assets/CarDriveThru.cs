using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriveThru : MonoBehaviour
{
    [SerializeField] private AudioSource carAudio;
    [SerializeField] private float min, max;
   // private float time = 0;
    float n;
    private void Start()
    {
        n = 5f;    
        StartCoroutine(waitTime(n));

    }
    
    void Update()
    {/*
        time++;
        if(time >= n)
        {
            SoundPlay();
        }*/

    }
    void SoundPlay()
    {
       // time = 0f;
        carAudio.Play();  
        RandomGenerator();
    }
    private float RandomGenerator()
    {   
        float r = Random.Range(min, max);
        Debug.Log("el numeor aleatorio es " + r);
        return r;
       
    }
    IEnumerator waitTime(float n)
    {
        while (true)
        {
            yield return new WaitForSeconds(n);
            SoundPlay();         
            n=RandomGenerator();
        }
    }

}

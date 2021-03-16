using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarDriveThru : MonoBehaviour
{
    [SerializeField] private AudioSource carAudio;
    [SerializeField] private float min, max;
    private float time;

    void Update()
    {
        time += Time.deltaTime;
        if(time >= RandomGenerator())
        {
            carAudio.Play();
            time = 0f;
            RandomGenerator();
        }
    }
    private float RandomGenerator()
    {
        return Random.Range(min, max);
    }

}

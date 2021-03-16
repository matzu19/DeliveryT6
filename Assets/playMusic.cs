using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playMusic : MonoBehaviour
{
    [SerializeField]
    AudioManager myManager;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("fire1"))
        {
           // myManager.changeMusic(myManager.sounds[0],myManager.sounds[1]);
        }
    }
}

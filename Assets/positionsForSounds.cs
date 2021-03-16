using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionsForSounds : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    public GameObject[] arrayLight;
    public GameObject originalSoundObject;
    void Start()
    {          
        CreateSound(arrayLight.Length);
       // this.gameObject.transform.position = new Vector3(light.transform.position.x, light.transform.position.y, light.transform.position.z);
    }

    void CreateSound(int soundNum)
    {       
        for (int i = 0; i < soundNum; i++)
        {
            GameObject soundClone = Instantiate(originalSoundObject, arrayLight[i].transform.position, arrayLight[i].transform.rotation);        

        }
    }

  
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activation : MonoBehaviour
{
    [SerializeField] GameObject Light;
    // Start is called before the first frame update
    void Start()
    {
        Light.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        Light.SetActive(true);
    }
    private void OnTriggerExit(Collider other)
    {
        Light.SetActive(false);
    }
}

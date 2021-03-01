using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableManager : MonoBehaviour
{
    [SerializeField] private bool pickable;

    private void Update()
    {
        
    }
    public void IsPickable()
    {
        if (pickable == true)
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpener : MonoBehaviour
{
    [SerializeField] private InventoryScroll inventoryPos;
    [SerializeField] private InventoryManager inventoryMgr;

    public void VerifyKey(GameObject gameObject)
    {
        /*if (gameObject.name == inventoryMgr.Item(inventoryPos.SelectorPosition())) 
        {
            Debug.Log("Puerta abierta");
            Destroy(gameObject);
        }*/
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockOpener : MonoBehaviour
{
    private string lockNameIs;
    [SerializeField] private GameObject PressClick;
    [SerializeField] private InventoryScroll inventoryPos;
    [SerializeField] private InventoryManager inventoryMgr;
    private void Update()
    {
        Debug.Log(inventoryMgr.Item(inventoryPos.SelectorPosition()));
        if(lockNameIs == inventoryMgr.Item(inventoryPos.SelectorPosition()))
        {
            PressClick.SetActive(true);
            if (Input.GetMouseButtonDown(0))//Aqui hiria la mecanica
            {
                Destroy(this.gameObject);
            }
        }
    }
    public string VerifyKey(GameObject gameObject)
    {
        return lockNameIs = gameObject.name;
    }

    public void DeactivateFeedback()
    {
        PressClick.SetActive(false);
    }
}

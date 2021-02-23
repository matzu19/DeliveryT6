using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScroll : MonoBehaviour
{
    [SerializeField] private GameObject imgSelector;
    private Vector3 scale;

    void Awake()
    {
        scale = new Vector3(0f, 139f, 0f);
    }

    void Update()
    {
        Vector3 pos = imgSelector.transform.position;
        pos += Mathf.Clamp(Input.mouseScrollDelta.y, -1f, 1f) * scale;
        if (pos.y > 819) { pos.y = 124; }
        if (pos.y < 124) { pos.y = 819; }
        imgSelector.transform.position = pos;
    }
}

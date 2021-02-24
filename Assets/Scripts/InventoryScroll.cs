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
        scale = new Vector3(225f, 0f, 0f);
    }

    void Update()
    {
        Vector3 pos = imgSelector.transform.localPosition;
        pos += Mathf.Clamp(Input.mouseScrollDelta.y, -1f, 1f) * scale;
        if (pos.x > 225) { pos.x = -225; }
        if (pos.x < -225) { pos.x = 225; }
        imgSelector.transform.localPosition = pos;
    }
}

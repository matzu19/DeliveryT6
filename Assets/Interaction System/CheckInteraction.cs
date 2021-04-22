using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckInteraction : MonoBehaviour
{   
    [SerializeField]
    private GameObject rayOrigin;
    [SerializeField] public Material highlightMaterial, defaultMaterial;
    [SerializeField] GameObject PressE;
    public Transform selection;

    [SerializeField] private Image pickImg;
    private float timeHeld;

    private bool canInteract;

    private InteractionReceiver currentReceiver;


    private void Start()
    {

    }

    void Update()
    {
        if (currentReceiver != null)
        {
            var selectionMaterial = selection.GetComponent<Renderer>();
            selectionMaterial.material = defaultMaterial;
            canInteract = false;
            PressE.SetActive(false);
        }

        currentReceiver = null;

        var ray = new Ray(rayOrigin.transform.position, rayOrigin.transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 1.5f))
        {
            selection = hit.transform;
            currentReceiver = selection.gameObject.GetComponent<InteractionReceiver>();
            defaultMaterial = selection.GetComponent<Renderer>().material;
        }

        if (currentReceiver != null)
        {
            var selectionMaterial = selection.GetComponent<Renderer>();
            selectionMaterial.material = highlightMaterial;
            canInteract = true;
        }

        if (canInteract)
        {
            PressE.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                timeHeld += Time.deltaTime;
                pickImg.color = new Color(0f, timeHeld, 0f, 1f);
            }
            else if (Input.GetMouseButtonUp(0))
            {
                this.timeHeld = 0;
                pickImg.color = new Color(0f, timeHeld, 0f, 0f);
            }

            if (timeHeld > 1f)
            {
                currentReceiver.Activate();
                CleanImg();
            }
            
        }
        else
        {
            timeHeld = 0;
            pickImg.color = new Color(0f, timeHeld, 0f, 0f);
        }

    }
    public void CleanImg()
    {
        timeHeld = 0;
        pickImg.color = new Color(0f, timeHeld, 0f, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class final : MonoBehaviour
{
    [SerializeField] private int rayLength = 2;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    [SerializeField] private Image crosshair = null;

    [SerializeField] private KeyCode enterKey = KeyCode.Mouse0;

    private const string finalTag = "FinalTag";

    public GameObject finalText;

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(finalTag))
            {
                finalText.SetActive(true);
                if (Input.GetKeyDown(enterKey))
                {
                   SceneManager.LoadScene(0);     
                }
            }
        } 

        else
        {
            finalText.SetActive(false);
        }
    }
}
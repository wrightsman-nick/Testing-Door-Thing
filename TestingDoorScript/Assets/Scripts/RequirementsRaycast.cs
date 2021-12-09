using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RequirementsRaycast : MonoBehaviour
{
    [SerializeField] private int rayLength = 2;
    [SerializeField] private LayerMask layerMaskInteract;
    [SerializeField] private string excludeLayerName = null;

    [SerializeField] private Image crosshair = null;

    [SerializeField] private KeyCode enterKey = KeyCode.Mouse0;

    public GameObject lockedText;
    public GameObject lockedText1;
    public GameObject lockedText2;
    public GameObject lockedText3;
    public GameObject unlockedText;
    public GameObject fragmentText;


    private const string requirementTag = "RequirementTag";
    private const string requirementTag1 = "RequirementTag1";
    private const string requirementTag2 = "RequirementTag2";
    private const string requirementTag3 = "RequirementTag3";
    private const string unlockedTag = "UnlockedTag";
    private const string fragmentTag = "FragmentTag";

    private void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);

        int mask = 1 << LayerMask.NameToLayer(excludeLayerName) | layerMaskInteract.value;

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(requirementTag))
            {
                lockedText.SetActive(true);
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(requirementTag1))
            {
                lockedText1.SetActive(true);
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(requirementTag2))
            {
                lockedText2.SetActive(true);
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(requirementTag3))
            {
                lockedText3.SetActive(true);
            }
        }

        if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(unlockedTag))
            {
                unlockedText.SetActive(true);
                if (Input.GetKeyDown(enterKey))
                {
                   SceneManager.LoadScene(6);     
                }
            }
        }

         if(Physics.Raycast(transform.position, fwd, out hit, rayLength, mask))
        {
            if(hit.collider.CompareTag(fragmentTag))
            {
                fragmentText.SetActive(true);
            }
        }

        else
        {
            lockedText.SetActive(false);
            lockedText1.SetActive(false);
            lockedText2.SetActive(false);
            lockedText3.SetActive(false);
            unlockedText.SetActive(false);
            fragmentText.SetActive(false);
        }


    }
}


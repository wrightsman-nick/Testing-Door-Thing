using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ENDING : MonoBehaviour
{
    // Start is called before the first frame update
    void OnEnable()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button m_Menu;

    void Start()
    {
        m_Menu.onClick.AddListener(MenuClick);
    }

    
    void MenuClick()
    {
        SceneManager.LoadScene (0);
    }
}

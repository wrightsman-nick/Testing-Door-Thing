using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        m_NewGame.onClick.AddListener(TaskOnClick);
        m_Quit.onClick.AddListener(QuitTask);
    }

    void QuitTask()
    {
        application.quit;
    }
}

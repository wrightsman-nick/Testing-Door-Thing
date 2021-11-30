using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Button m_NewGame, m_Quit;

    // Start is called before the first frame update
    void Start()
    {
        m_NewGame.onClick.AddListener(TaskOnClick);
        m_Quit.onClick.AddListener(QuitTask);
    }

    void TaskOnClick()
    {
        return;
    }

    void QuitTask()
    {
        application.quit;
    }
}

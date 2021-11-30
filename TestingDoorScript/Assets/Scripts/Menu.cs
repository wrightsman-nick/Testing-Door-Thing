using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
        SceneManager.LoadScene (1);
    }

    void QuitTask()
    {
        Application.Quit();
        Debug.Log("QUIT");
    }
}

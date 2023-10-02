using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager_code : MonoBehaviour
{
    public void startButton()
    {
        SceneManager.LoadScene("before_start");    
    }

    public void yesbutton()
    {
        SceneManager.LoadScene("colortest");

    }

    public void detailbutton()
    {
        SceneManager.LoadScene("detail");

    }
    public void nobutton()
    {
        SceneManager.LoadScene("Opening");

    }
    public void analysis_button()
    {
        SceneManager.LoadScene("analysis_start");

    }
}

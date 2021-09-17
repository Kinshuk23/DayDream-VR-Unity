using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoadingScript : MonoBehaviour
{
    public void EXScene()
    {
        SceneManager.LoadScene("1800 ES", LoadSceneMode.Single);
        //SceneManager.LoadScene(1);
    }

    public void TMCHScene()
    {
        SceneManager.LoadScene("TMCH_Scene", LoadSceneMode.Single);
    }

    public void UiScene()
    {
        SceneManager.LoadScene("DayDream_UI", LoadSceneMode.Single);
    }

    public void QuitFunction()
    {
        Application.Quit();
    }

}

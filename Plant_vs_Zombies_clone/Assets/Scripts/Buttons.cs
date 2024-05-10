using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    /// <summary>
    /// used to switch to a spesific scene
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }
}

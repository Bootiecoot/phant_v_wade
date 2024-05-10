using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject firstText;
    public GameObject firstButton;
    public GameObject secondText;
    public GameObject secondButton;
    public GameObject thirdText;
    public GameObject thirdButton;
    public GameObject fourthText;
    public GameObject fourthButton;
    public GameObject fifthText;
    public GameObject fifthButton;
    public void QuitGame()
    {
        Application.Quit();
        print("Quit Game");
    }

    /// <summary>
    /// used to switch to a spesific scene
    /// </summary>
    /// <param name="sceneIndex"></param>
    public void SwitchScene(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);
    }

    public void OnButtonClickFirst()
    {
        firstText.SetActive(false);
        firstButton.SetActive(false);

        secondButton.SetActive(true);
        secondText.SetActive(true);
    }

    public void OnButtonClickSecond()
    {
        secondText.SetActive(false);
        secondButton.SetActive(false);

        thirdButton.SetActive(true);
        thirdText.SetActive(true);
    }
    public void OnButtonClickThird()
    {
        thirdText.SetActive(false);
        thirdButton.SetActive(false);

        fourthButton.SetActive(true);
        fourthText.SetActive(true);
    }

    public void OnButtonClickFourth()
    {
        fourthText.SetActive(false);
        fourthButton.SetActive(false);

        fifthText.SetActive(true);
        fifthButton.SetActive(true);
    }

    public void OnButtonClickFifth()
    {
        SceneManager.LoadScene(2);
    }

    
}

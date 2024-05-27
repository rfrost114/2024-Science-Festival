using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resetManagerScript : MonoBehaviour
{

    // false = 1.47 , true = 3
    public bool speedToggle = true;

    public void ToggleSpeed()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (speedToggle)
        {
            speedToggle = false;
        }
        else
        {
            speedToggle = true;
        }
    }


    public void resetGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}

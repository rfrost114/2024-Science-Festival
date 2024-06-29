using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public void ChangeToSweep()
    {
        SceneManager.LoadScene("1comSweep");
    }

    public void QuitOut()
    {
        Application.Quit();
    }

    public void ChangeToCAP()
    {
        SceneManager.LoadScene("CAP");
    }

    public void ChangeToExploreSweep()
    {
        SceneManager.LoadScene("ExploringSweep");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAY : MonoBehaviour
{

    public void play()
    {
        SceneManager.LoadScene("Flappy Bird");
    }
    public void Quit()
    {
        Application.Quit();
    }
}

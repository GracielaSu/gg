using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoader : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Start Menu");
    }
}

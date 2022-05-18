using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LaunchGame : MonoBehaviour
{
    public Button startButton;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
    }
}

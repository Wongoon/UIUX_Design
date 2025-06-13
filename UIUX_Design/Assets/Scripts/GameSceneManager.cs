using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameSceneManager : MonoBehaviour
{
    public static void GoToScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}

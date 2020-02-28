using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLoader : MonoBehaviour
{
    public const int GAME_SCENE = 1;

    public void ChangeScene()
    {
        SceneManager.LoadScene(GAME_SCENE);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void changeToScene(int sceneToChangeTo)
    {
        SceneManager.LoadScene(sceneToChangeTo);
    }
}

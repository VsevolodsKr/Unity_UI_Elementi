﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AinuParsledzejs : MonoBehaviour {
    public void UzSakumu() {
        SceneManager.LoadScene("JaunaAina", LoadSceneMode.Single);
    }
    public void UzUI() {
        SceneManager.LoadScene(1, LoadSceneMode.Single);
    }
    public void Apturet() {
        Application.Quit();
    }
}

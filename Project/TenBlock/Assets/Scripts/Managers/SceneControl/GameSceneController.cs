// System
using System;
using System.Collections;
using System.Collections.Generic;

// Unity
using UnityEngine;
using UnityEngine.UI;

// Project
// Alias

public class GameSceneController : MonoBehaviour
{
    public static Action OnGameSceneLoaded = null;

    private void Awake()
    {
        OnGameSceneLoaded?.Invoke();
        OnGameSceneLoaded = null;
    }
}
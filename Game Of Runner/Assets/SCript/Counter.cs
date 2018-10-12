using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public static int Score;
    public static int HighScore;
    // Use this for initialization
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }
}
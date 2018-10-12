using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoCam : MonoBehaviour {

    public static float CamSpeed=1;
    public static bool CamOn;
    private float CamTime;
   
    void Update ()
    {
        if (CamOn) { transform.Translate(CamSpeed * Time.deltaTime, 0f, 0f); CamTime+=Time.deltaTime; }

        if (CamTime > 1){
            if (CamSpeed > 3) { CamSpeed += CamTime/100; } else { CamSpeed += CamTime/50; } CamTime = 0;}

        if (!Death.Alive) { CamSpeed = 1; CamTime = 0; } 
    }
}

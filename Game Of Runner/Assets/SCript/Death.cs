using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {
    Vector3 cam;
    public static bool Alive;
   

    void Update () {
        cam = Camera.main.gameObject.transform.position;

        if (transform.position.y < cam.y - 20 || transform.position.x < cam.x - 20)
        { Alive = false;  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); AutoCam.CamOn = false; PlayerMovement.movement = new Vector2(0,0); Skill.PowerUp = 5;  }
        else { Alive = true; }
    }
}
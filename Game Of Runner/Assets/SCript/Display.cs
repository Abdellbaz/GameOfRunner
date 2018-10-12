using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Display : MonoBehaviour {
 
    public Text displayScore;
    public Text displayHighScore;
    public Text displayCamSpeed;
    public Text displayPowerUp;
    void Update () {

        displayScore.text = "Score: " + Counter.Score.ToString();
        displayHighScore.text = "HighScore: " + Counter.HighScore.ToString();
        displayCamSpeed.text = "CamSpeed: " + AutoCam.CamSpeed.ToString();
        displayPowerUp.text = "PowerUp: " + Skill.PowerUp.ToString();

        if (!Death.Alive) {
        if (Counter.Score > Counter.HighScore) { Counter.HighScore = Counter.Score; } Counter.Score = 0; }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill : MonoBehaviour {
    public static int PowerUp = 5;
    public static bool PowerOn;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Destroyable")&&PowerOn&&PowerUp>0)
        { Destroy(col.gameObject); PowerUp--; PlayerMovement.SR.color = Color.red; PowerOn = false; }
    }
}

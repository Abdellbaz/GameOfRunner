using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public static bool IsGround;
  
    private void OnCollisionEnter2D(Collision2D col)
    {if (col.gameObject.CompareTag("ground")) { IsGround = true; }}
    private void OnCollisionExit2D(Collision2D col)
    {if (col.gameObject.CompareTag("ground")) { IsGround = false; }}
}

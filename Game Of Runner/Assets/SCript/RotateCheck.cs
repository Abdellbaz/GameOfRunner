using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCheck : MonoBehaviour
{
   
    public static bool IsRotate=true;

    private void OnCollisionEnter2D(Collision2D col)
    {if (col.gameObject.CompareTag("NoRotate")) { IsRotate = false; }}
    private void OnCollisionExit2D(Collision2D col)
    {if (col.gameObject.CompareTag("NoRotate")) { IsRotate = true; }}
}

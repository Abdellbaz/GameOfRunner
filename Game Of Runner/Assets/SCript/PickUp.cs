using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Coin"))
        {
            Counter.Score++;
            Destroy(col.gameObject);
        }
        if (col.gameObject.CompareTag("Power"))
        {
            Skill.PowerUp++;
            Destroy(col.gameObject);
        }
    }
  
}

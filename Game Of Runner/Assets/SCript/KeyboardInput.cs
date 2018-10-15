using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardInput : MonoBehaviour
{




    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) && GroundCheck.IsGround) { AutoCam.CamOn = true; PlayerMovement.rb2d.AddForce(Vector2.up * PlayerMovement.jumpForce); }
        if (Input.GetKeyDown(KeyCode.Space)&&RotateCheck.IsRotate)
        {
            if (transform.localRotation == Quaternion.Euler(0, 0, 90))
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.25f, transform.position.z);
                transform.localRotation = Quaternion.Euler(0, 0, 0);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.25f, transform.position.z);
                transform.localRotation = Quaternion.Euler(0, 0, 90);
            }
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            if (PlayerMovement.SR.color == Color.red && Skill.PowerUp > 0) { PlayerMovement.SR.color = Color.cyan; Skill.PowerOn = true; }
            else { PlayerMovement.SR.color = Color.red; Skill.PowerOn = false; }
        }
    }
}

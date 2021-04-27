using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public void UpARoow()
    {
        //this.gameObject.transform.Translate(-XMovement, 0, -ZMovement);

        float HorizontalMovement = Input.GetAxis("Horizontal") + 1;
        HorizontalMovement *= Time.deltaTime;
    }

    public void LeftARoow()
    {
        //this.gameObject.transform.Translate(ZMovement, 0, -XMovement);

        float HorizontalMovement = Input.GetAxis("Vertical") - 1;
        HorizontalMovement *= Time.deltaTime;
    }

    public void RightARoow()
    {
        //this.gameObject.transform.Translate(-ZMovement, 0, XMovement);

        float HorizontalMovement = Input.GetAxis("Vertical") + 1;
        HorizontalMovement *= Time.deltaTime;
    }

    public void DownARoow()
    {
        //this.gameObject.transform.Translate(XMovement, 0, ZMovement);

        float HorizontalMovement = Input.GetAxis("Horizontal") - 1;
        HorizontalMovement *= Time.deltaTime;
    }
}

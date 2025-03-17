using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRevers : MonoBehaviour
{
    public void ReversRight()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y = 0;
        transform.rotation = Quaternion.Euler(rotate);
    }

    public void ReversLeft()
    {
        Vector3 rotate = transform.eulerAngles;
        rotate.y = 180;
        transform.rotation = Quaternion.Euler(rotate);
    }
}
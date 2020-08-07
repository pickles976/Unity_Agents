using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class steering
{
    public float angular; //rotation 0->360
    public Vector3 linear; //instantaneous velocity
    public steering()
    {
        angular = 0.0f;
        linear = new Vector3();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shapes
{
    private void Awake()
    {
        _ShapeColor = Color.black;
        _ShapeName = "CapsuleObj";
    }

    public override void Debugging()
    {
        Debug.Log("This is Capsule");
    }
}

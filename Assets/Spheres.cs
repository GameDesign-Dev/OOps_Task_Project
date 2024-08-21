using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spheres : Shapes
{
    private void Awake()
    {
        _ShapeColor = Color.red;
        _ShapeName = "SphereObj";
    }

    public override void Debugging()
    {
        Debug.Log("This is Sphere");
    }
}

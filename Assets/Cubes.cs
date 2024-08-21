using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : Shapes
{
    public void Awake()
    {
        _ShapeColor = Color.green;
        _ShapeName = "CubesObj";
    }

    public override void Debugging()
    {
        Debug.Log("This is Cubes");
    }
}

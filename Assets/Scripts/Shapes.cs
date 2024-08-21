using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Shapes : MonoBehaviour
{
    protected Color ShapeColor;
    protected string ShapeName { get; set; }
    // Start is called before the first frame update
   public Color _ShapeColor
    {
        get { return ShapeColor; }
        set
        {
            ShapeColor = value;
            Renderer renderer = GetComponent<Renderer>();
            if (renderer != null)
            {
         renderer.material.color = ShapeColor;
            }
        }
    }
    
    public string _ShapeName
    {
        get { return ShapeName; }
        set { ShapeName = value; }
    }

    public abstract void Debugging();
   
 }

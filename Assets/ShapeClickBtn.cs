using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShapeClickBtn : MonoBehaviour
{
    public Shapes shapes;
    public void Start()
    {
        if(shapes != null)
        {
            Button btn = GetComponent<Button>();
            btn.onClick.AddListener(() => shapes.Debugging());
        }
    }
}

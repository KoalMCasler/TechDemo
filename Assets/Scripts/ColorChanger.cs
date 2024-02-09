using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color color6;
    public int colorIndex;

    public Material thisMat;
    // Start is called before the first frame update
    void Start()
    {
        //thisMat = this.GetComponent<Material>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {  
        Invoke("SetMatColor", 3);
    }
    void SetMatColor()
    {
        colorIndex += 1;
        if(colorIndex <= 0 || colorIndex > 6)
        {
            colorIndex = 1;
        }
        if(colorIndex == 1)
        {
            thisMat.SetColor("_Color", color1);
        }
        if(colorIndex == 2)
        {
            thisMat.SetColor("_Color", color2);
        }
        if(colorIndex == 3)
        {
            thisMat.SetColor("_Color", color3);
        }
        if(colorIndex == 4)
        {
            thisMat.SetColor("_Color", color4);
        }
        if(colorIndex == 5)
        {
            thisMat.SetColor("_Color", color5);
        }
        if(colorIndex == 6)
        {
            thisMat.SetColor("_Color", color6);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    public Color color1;
    public Color color2;
    public Color color3;
    public Color color4;
    public Color color5;
    public Color color6;
    public int i;

    public Material thisMat;
    // Start is called before the first frame update
    void Start()
    {
        //thisMat = this.GetComponent<Material>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        for(i = 0; i < 70; i++)
        {
            if(i < 10)
            {
                thisMat.SetColor("_Color", color1);
            }
            if(i > 10 && i < 20)
            {
                thisMat.SetColor("_Color", color2);
            }
            if(i > 20 && i < 30)
            {
                thisMat.SetColor("_Color", color3);
            }
            if(i > 30 && i < 40)
            {
                thisMat.SetColor("_Color", color4);
            }
            if(i > 40 && i < 50)
            {
                thisMat.SetColor("_Color", color5);
            }
            if(i > 50 && i < 60)
            {
                thisMat.SetColor("_Color", color6);
            }
            if(i < 60)
            {
                i = 0;
            }
        }
    }
}

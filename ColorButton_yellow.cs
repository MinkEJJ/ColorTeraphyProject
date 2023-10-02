using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton_yellow : MonoBehaviour
{
    public Color ButtonColor = new Color(1, 0, 0);

    public void colorsend()
    {
        ColorManager.SetColor(ButtonColor);
    }
}

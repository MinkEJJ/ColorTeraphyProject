using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorButton_blue : MonoBehaviour
{
    public Color ButtonColor = new Color(0, 0, 1);

    public void colorsend()
    {
        ColorManager.SetColor(ButtonColor);
    }
}

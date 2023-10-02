using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    public static Color CurrentColor { get; private set; }

    public static void SetColor(Color color)
    {
        CurrentColor = color;
        Debug.Log(CurrentColor);
    }
}

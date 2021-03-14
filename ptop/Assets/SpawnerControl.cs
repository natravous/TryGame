using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl
{
    
    private static int length = 0;
    internal static void setColor(SpriteRenderer sr, Color clr)
    {
        sr.color = clr;
    }
    internal static void setWidth(GameObject go, float width)
    {
        go.transform.localScale = new Vector2(width, 10);
    }
    internal static void setPosition(GameObject go, Vector2 pos)
    {
        go.transform.position = pos;
    }
    internal static int getId()
    {
        return length;
    }
    internal static void setId(int val)
    {
        length = val;
    }
}

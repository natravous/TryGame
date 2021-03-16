using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerControl
{
    
    private static int length = 0;
    private static float range = 4;
    internal static void setColor(SpriteRenderer sr, Color clr)
    {
        sr.color = clr;
    }
    internal static void setSize(GameObject go, float width, float height)
    {
        go.transform.localScale = new Vector2(width, height);
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
    internal static float getRange()
    {
        return range;
    }
    internal static void setRange(int val)
    {
        range = val;
    }
}

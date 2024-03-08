using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyToolbox
{
    public static Vector2 GetRandomVector2(float x1, float x2, float y1, float y2) 
    {
        // x -150 180
        // y -150 150
        Vector2 value = new Vector2();
        value.x = Random.Range(x1, x2);
        value.y = Random.Range(y1, y2);
        return value;
    }
}

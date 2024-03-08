using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MyToolbox
{
    public static Vector2 GetRandomVector2(float _x1, float _x2, float _y1, float _y2) 
    {
        // x -150 180
        // y -150 150
        Vector2 value = new Vector2();
        value.x = Random.Range(_x1, _x2);
        value.y = Random.Range(_y1, _y2);
        return value;
    }
}

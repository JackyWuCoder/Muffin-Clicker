using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cake : Pastry
{
    public string _topping;
    protected override void Start()
    {
        Debug.Log("Baking " + name + " with " + _topping);
    }
}

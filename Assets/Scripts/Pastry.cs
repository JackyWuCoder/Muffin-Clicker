using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pastry : MonoBehaviour
{
    public string _name;
    protected virtual void Start()
    {
        Debug.Log("Baking " + _name);
    }

}

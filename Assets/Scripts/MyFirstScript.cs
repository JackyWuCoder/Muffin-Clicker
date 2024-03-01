using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
    // int float string bool
    int _wholeNumber = -5;
    float _decimalNumber = 0.5f;
    string _text = "$U#)U$O@J$O#@JsaD";
    bool _isTrue = true;
    */

    private int _counter = 0;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World");
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    public void OnMuffinClicked() 
    {
        _counter = _counter + 1;
        Debug.Log(_counter);
    }

}

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

    Camera _camera;

    [SerializeField]
    private int _counter = 0;
    [SerializeField] private int _counterPerClick = 1;

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
        _counter = _counter + _counterPerClick;
        Debug.Log(_counter);
    }

}

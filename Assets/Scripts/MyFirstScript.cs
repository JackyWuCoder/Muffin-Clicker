using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using TMPro;

public class MyFirstScript : MonoBehaviour
{
    /*
    // int float string bool
    int _wholeNumber = -5;
    float _decimalNumber = 0.5f;
    string _text = "$U#)U$O@J$O#@JsaD";
    bool _isTrue = true;
    */

    [SerializeField]
    private TextMeshProUGUI _totalMuffinsText;
    [SerializeField]
    private int _counter = 0;
    [SerializeField] private int _muffinsPerClick = 1;
    [SerializeField] private float _critChance = 0.01f;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World");
        UpdateTotalMuffins();
    }

    // Update is called once per frame
    private void Update()
    {
       
    }

    public void OnMuffinClicked() 
    {
        int _addedMuffins;
        if (Random.Range(0.0f, 100.0f) <= _critChance*100)
        {
            _addedMuffins = _muffinsPerClick * 10;
        }
        else
        {
            _addedMuffins = _muffinsPerClick;
        }
        _counter = _counter + _addedMuffins;
        UpdateTotalMuffins();
        Debug.Log(_counter);
    }

    private void UpdateTotalMuffins() 
    {
        if (_counter == 1)
        {
            _totalMuffinsText.text = _counter.ToString() + " muffin";
        } 
        else 
        {
            _totalMuffinsText.text = _counter.ToString() + " muffins";
        }
    }
}

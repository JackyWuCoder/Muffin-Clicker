using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;
using TMPro;

public class MyFirstScript : MonoBehaviour
{
    [SerializeField]
    private float _spinSpeed = 360;
    [SerializeField]
    private int _counter = 0;
    [SerializeField] 
    private float _critChance = 0.01f;

    [SerializeField] private GameObject _textRewardPrefab;

    [SerializeField] private Transform[] _spinLights;
    [SerializeField] private float[] _spinSpeeds;

    [SerializeField] private float _waveSpeed;
    [SerializeField] private float _waveAmplitude;
    [SerializeField] private float _waveOffset;

    [SerializeField] private TextMeshProUGUI _totalMuffinsText;
    [SerializeField] private int _muffinsPerClick = 1;

    // Start is called before the first frame update
    private void Start()
    {
        Debug.Log("Hello World");
        UpdateTotalMuffins();
        for (int i = 0; i < _spinSpeeds.Length; i++)
        {
            _spinSpeeds[i] = _spinSpeed * Random.Range(1, 100);
        }
       
    }

    // Update is called once per frame
    private void Update()
    {
        for (int i = 0; i < _spinLights.Length; i++)
        {
            // Rotate
            Vector3 rotation = new Vector3();
            rotation.z = _spinSpeeds[i] * Time.deltaTime;
            _spinLights[i].Rotate(rotation);

            // Wave
            float wave = Mathf.Sin(Time.time * _waveSpeed) * _waveAmplitude + _waveOffset;
            Vector3 waveScale = new Vector3(wave, wave, wave);
            _spinLights[i].localScale = waveScale;
        }
    }

    public void OnMuffinClicked() 
    {
        //_counter = _counter + _muffinsPerClick;
        if (Random.value <= _critChance)
        {
            // Crit
            _counter = _counter + _muffinsPerClick * 10;
        }
        else
        {
            // Normal
            _counter = _counter + _muffinsPerClick;
        }
        UpdateTotalMuffins();
        Debug.Log(_counter);
        GameObject textRewardClone = Instantiate(_textRewardPrefab, transform);
        Vector2 randomVector = MyToolbox.GetRandomVector2();
        textRewardClone.transform.localPosition = randomVector;
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

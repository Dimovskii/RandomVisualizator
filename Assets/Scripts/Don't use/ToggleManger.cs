using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleManger : MonoBehaviour
{
    [SerializeField] private Toggle _circle;
    [SerializeField] private Toggle _square;
    [SerializeField] private Toggle _triagle;

    private void Awake()
    {
        _circle = GetComponent<Toggle>();
        _square = GetComponent<Toggle>();
        _triagle = GetComponent<Toggle>();
    }


    void Update()
    {
        Debug.Log("Current Toggle State : " + _circle.isOn);
    }
}

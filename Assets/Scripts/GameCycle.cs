using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum SpriteType
{
    circle,
    square,
    triagle
}

public class GameCycle : MonoBehaviour
{
    [SerializeField] private InputField _minCooldown;
    [SerializeField] private InputField _maxCooldown;
    [SerializeField] private InputField _minLifeTime;
    [SerializeField] private InputField _maxLifeTime;
    [SerializeField] private Toggle _circle;
    [SerializeField] private Toggle _square;
    [SerializeField] private Toggle _triagle;

    private Shape _shape;

    private Timer _timer;

    private float _minValue;
    private float _maxValue;
    private float _cooldown = 3f;
    private float _lifeTime = 5f;

    public void Init(Shape shape)
    {
        _shape = shape;
    }

    private void Awake()
    {
        _timer = new Timer(_cooldown);
    }

    private void GetList()
    {
        List<SpriteType> currentList = new List<SpriteType>();

        if (_circle.isOn)
        {
            currentList.Add(SpriteType.circle);
        }
        
        if (_square.isOn)
        {
            currentList.Add(SpriteType.square);
        }
        
        if (_triagle.isOn)
        {
            currentList.Add(SpriteType.triagle);
        }
    }

    private void Update()
    {
        _timer.SetTimer(_cooldown);
    }

    public float GetCooldown()
    {
        Conversion(_minCooldown.text, _maxCooldown.text);
        return _cooldown = Random.Range(_minValue, _maxValue);
    }

    public float GetLifetime()
    {
        Conversion(_minLifeTime.text, _maxLifeTime.text);
        return _lifeTime = Random.Range(_minValue, _maxValue);
    }

    private void Conversion(string firstValue, string secondValue)
    {
        _minValue = float.Parse(_minCooldown.text);
        _maxValue = float.Parse(_maxCooldown.text);
    }
}
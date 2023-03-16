using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    [SerializeField] private List <Sprite> _sprites;
    [SerializeField] private Transform _playField;

    private Timer _timer;

    public event Action<Sprite> OnShapeChanged;

    private GameObject _shapePrefab;
    private GameObject _newShape;

    private Vector3 _spawnPosition;

    private float _valueX = 216f;
    private float _valueY = 130f;

    public void Init(Timer timer)
    {
        _timer = timer;
    }
    
    private void Create()
    {
        _newShape = Instantiate(_shapePrefab, _spawnPosition, Quaternion.identity);
        _newShape.transform.SetParent(_playField);
        _newShape.transform.localPosition = _spawnPosition;
    }

    private void SetPosition()
    {
        float randomX = UnityEngine.Random.Range(-_valueX, _valueX);
        float randomY = UnityEngine.Random.Range(-_valueY, _valueY);
        _spawnPosition = new Vector3(randomX, randomY, 0f);
    }

    private void SetSprite()
    {
        int index = UnityEngine.Random.Range(0, _sprites.Count);
        var sprite = _sprites[index];
        OnShapeChanged?.Invoke(sprite);
    }

    private void OnEnable()
    {
        _timer.OnTimeSpawn += SetPosition;
        _timer.OnTimeSpawn += SetSprite;
        _timer.OnTimeSpawn += Create;
    }

    private void OnDisable()
    {
        _timer.OnTimeSpawn -= SetPosition;
        _timer.OnTimeSpawn -= SetSprite;
        _timer.OnTimeSpawn -= Create;
    }
}
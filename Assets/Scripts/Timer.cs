using System;
using UnityEngine;

public class Timer
{ 
    private float _currentTime;
    public event Action OnTimeSpawn;

    public Timer(float time)
    {
        _currentTime = time;
        SetTimer(_currentTime);
    }

    public void SetTimer(float value)
    {
        if (_currentTime > 0)
        {
            _currentTime -= Time.deltaTime;
        }
        else
        {
            OnTimeSpawn?.Invoke();
            _currentTime = value;
        }
    }
}
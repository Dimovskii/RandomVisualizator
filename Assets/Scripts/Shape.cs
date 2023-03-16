using System;
using UnityEngine;
using UnityEngine.UI;

public class Shape : MonoBehaviour
{
    private Text _outputTimer;
    private float _lifeTime;
    private Spawner _spawner; // ������ ���������� ����� �������� ������
    private Sprite _sprite;

    public void Init(float lifeTime, Spawner spawner)
    {
        _spawner = spawner; // �������� ������
        _spawner.OnShapeChanged += SetSprite;

        _lifeTime = lifeTime;
        Timer(_lifeTime);
    }

    private void SetSprite(Sprite sprite)
    {
        _spawner.GetComponent<Image>().sprite = sprite;//установить спрайт
    }

    private void Awake()
    {
        _outputTimer = GetComponentInChildren<Text>();//added  component text us children
    }

    private void Update()
    {
        Timer(_lifeTime);
    }

    private void Timer(float _lifeTime)
    {
        if (_lifeTime >= 0)
        {
            _lifeTime -= Time.deltaTime;
        }

        Remove(_lifeTime == 0);

        _outputTimer.text = Math.Round(_lifeTime, 1).ToString();
    }

    private void Remove(bool value)
    {
        if(value) Destroy(gameObject);
    }

    private void OnDestroy()
    {
        _spawner.OnShapeChanged -= SetSprite;
    }
}

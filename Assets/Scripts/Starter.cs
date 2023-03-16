using UnityEngine;

public class Starter : MonoBehaviour
{
    [SerializeField] private Spawner _spawner;
    [SerializeField] private GameCycle _gameCycle;

    private Shape _shape;

    private Timer _timer;

    private float _cooldownTime = 2f;
    private float _lifeTime = 3f;

    private void Awake()
    {
        _timer = new Timer(_cooldownTime);
        _spawner.Init(_timer);
        _cooldownTime = _gameCycle.GetCooldown();
        _lifeTime = _gameCycle.GetLifetime();
        _shape.Init(_lifeTime, _spawner);
    }
}
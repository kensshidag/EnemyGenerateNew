using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemyPrefab;
    [SerializeField] private Spawnpoint[] _spawnpoints;
    [SerializeField] private float _spawnRate = 2f;

    private Enemy _enemy;
    private Target _target;
    private Vector3 _rotation;
    private Vector3 _position;
    private Color _color;
    private int spawnpointNumber;

    private void Start()
    {
        StartCoroutine(TwoSecondTimer());
    }

    private void CreateEnemy()
    {
        spawnpointNumber = Random.Range(0, _spawnpoints.Length);
        _rotation = _spawnpoints[spawnpointNumber].GetRotation();
        _position = _spawnpoints[spawnpointNumber].GetPosition();
        _color = _spawnpoints[spawnpointNumber].GetColor();
        _target = _spawnpoints[spawnpointNumber].GetTarget();

        _enemy = Instantiate(_enemyPrefab);
        _enemy.Initialize(_rotation, _position, _color, _target);
    }

    private IEnumerator TwoSecondTimer()
    {
        var delay = new WaitForSeconds(_spawnRate);

        while (true)
        {
            yield return delay;
            CreateEnemy();
        }
    }   
}
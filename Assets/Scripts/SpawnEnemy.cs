using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private const string MethodName = nameof(SpawnEnemies);

    [SerializeField] private float _spawnInterval;
    [SerializeField] private Enemy[] _enemies;
    [SerializeField] private GameObject[] _spawnPositions;
    [SerializeField] private GameObject[] _moveTargets;

    private float _startSpawn = 0f;

    private void Start()
    {
        InvokeRepeating(MethodName, _startSpawn, _spawnInterval);
    }

    private void SpawnEnemies()
    {
        for (int i = 0, j = 0, k = 0; i < _enemies.Length && j < _spawnPositions.Length && k < _moveTargets.Length; i++, j++, k++)
        {
            Vector3 spawnPosition = _spawnPositions[j].transform.position;
            Quaternion spawnRotation = _spawnPositions[j].transform.rotation;
            Instantiate(_enemies[i], spawnPosition, spawnRotation);
            _enemies[i].Initialize(_moveTargets[k]);
        }
    }
}

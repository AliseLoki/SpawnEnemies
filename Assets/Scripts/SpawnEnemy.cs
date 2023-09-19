using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    private const string MethodName = nameof(SpawnEnemies);

    [SerializeField] private Enemy[] _enemy;
    [SerializeField] private GameObject[] _spawnPosition;

    private float _startSpawn = 1f;
    private float _spawnInterval = 2f;

    private void Start()
    {
        InvokeRepeating(MethodName, _startSpawn, _spawnInterval);
    }

    private void SpawnEnemies()
    {
        int positionIndex = Random.Range(0, _spawnPosition.Length);
        int enemyIndex = Random.Range(0, _enemy.Length);

        Vector3 spawnPosition = _spawnPosition[positionIndex].transform.position;
        Quaternion spawnRotation = _spawnPosition[positionIndex].transform.rotation;

        Instantiate(_enemy[enemyIndex], spawnPosition, spawnRotation);
    }
}

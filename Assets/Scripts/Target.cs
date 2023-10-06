using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform[] _points;

    private int _currentPointIndex;

    private void Update()
    {
        Transform target = _points[_currentPointIndex];
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);

        if (transform.position == target.position)
        {
            _currentPointIndex++;

            if (_currentPointIndex >= _points.Length)
            {
                _currentPointIndex = 0;
            }
        }
    }
}

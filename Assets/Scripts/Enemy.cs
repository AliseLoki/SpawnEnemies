using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _target;

    private void Update()
    {
        if (_target != null)
            transform.position = Vector3.MoveTowards(transform.position, _target.transform.position, _speed * Time.deltaTime);
    }

    public void Initialize(GameObject target)
    {
        _target = target;
    }
}

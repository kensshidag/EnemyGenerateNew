using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private int _curentPoint = 0;

    public void Chase(Transform target)
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, _speed * Time.deltaTime);
        transform.LookAt(target.position, Vector3.up);
    }

    public void MoveToPoints(Transform[] points)
    {
        if (transform.position == points[_curentPoint].position)
        {
            _curentPoint++;

            if (_curentPoint >= points.Length)
            {
                _curentPoint = 0;
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, points[_curentPoint].position, _speed * Time.deltaTime);      
        transform.LookAt(points[_curentPoint].position);
    }
}
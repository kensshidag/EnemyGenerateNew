using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] private Transform[] _points;
    [SerializeField] private Mover _mover;

    private void Update()
    {
        _mover.MoveToPoints(_points);
    }
}

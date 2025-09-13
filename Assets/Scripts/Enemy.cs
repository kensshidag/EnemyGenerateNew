using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Mover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;
    [SerializeField] private Renderer _renderer;

    private Target _target;

    private void Update()
    {
        _mover.Chase(_target.transform);
    }

    public void Initialize(Vector3 rotation, Vector3 position, Color color, Target target)
    {
        transform.rotation = Quaternion.Euler(rotation);
        transform.position = position;
        _renderer.material.color = color;
        _target = target;
    }
}
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof(Mover))]
public class Enemy : MonoBehaviour
{
    [SerializeField] private Mover _mover;

    private void Update()
    {
        _mover.Move();
    }

    public void Initialize(Vector3 rotation, Vector3 position)
    {
        transform.rotation = Quaternion.Euler(rotation);
        transform.position = position;
    }
}
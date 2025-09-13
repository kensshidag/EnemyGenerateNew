using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] private Target _target;
    [SerializeField] private Vector3 _rotation;

    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public Vector3 GetRotation()
    {
        return _rotation;
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }

    public Color GetColor()
    {
        return _renderer.material.color;
    }

    public Target GetTarget()
    {
        return _target;
    }
}
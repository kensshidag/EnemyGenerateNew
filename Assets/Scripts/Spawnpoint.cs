using UnityEngine;

public class Spawnpoint : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;

    public Vector3 GetRotation()
    {
        return _rotation;
    }

    public Vector3 GetPosition()
    {
        return transform.position;
    }
}
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] private float _speed = 5f;

    public float Speed => _speed;
}
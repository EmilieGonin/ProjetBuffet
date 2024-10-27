using UnityEngine;

[RequireComponent(typeof(Entity), typeof(Rigidbody))]
public class EntityMove : MonoBehaviour
{
    private Entity _entity;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _entity = GetComponent<Entity>();
        _rigidbody = GetComponent<Rigidbody>();
    }

    public void Move(Vector2 direction)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        float distance = _entity.Speed * Time.deltaTime;

        Vector3 movement = (forward * direction.y + right * direction.x) * distance;
        Vector3 newPosition = _rigidbody.position + movement;

        _rigidbody.MovePosition(newPosition);
    }
}
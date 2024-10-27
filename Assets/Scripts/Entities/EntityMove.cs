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
        float distance = _entity.Speed * Time.deltaTime;

        Vector3 movement = (transform.forward * direction.y + transform.right * direction.x) * distance;
        Vector3 newPosition = _rigidbody.position + movement;
        _rigidbody.MovePosition(newPosition);
    }

    public void Rotate(Vector2 inputs)
    {
        float yaw = inputs.x * 10f * Time.deltaTime;
        float pitch = inputs.y * 10f * Time.deltaTime;

        transform.Rotate(Vector3.up, yaw, Space.World);
        transform.Rotate(Vector3.right, -pitch, Space.Self);
    }
}
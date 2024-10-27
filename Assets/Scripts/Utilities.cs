using UnityEngine;

public static class Utilities
{
    public static Vector3 GetRandomPointInBounds(Transform transform)
    {
        Bounds bounds = transform.GetComponent<Renderer>().bounds;

        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        return new Vector3(x, y, z);
    }
}
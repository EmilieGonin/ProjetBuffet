using NaughtyAttributes;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private Renderer _renderer;
    [SerializeField] private GameObject _boxPrefab;

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private void Spawn()
    {
        Bounds bounds = _renderer.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);
        float z = Random.Range(bounds.min.z, bounds.max.z);

        Instantiate(_boxPrefab, new Vector3(x, y, z), Quaternion.identity);
    }
}
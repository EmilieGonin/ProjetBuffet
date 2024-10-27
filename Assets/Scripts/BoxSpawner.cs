using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : MonoBehaviour
{
    [SerializeField] private GameObject _boxPrefab;

    private Coroutine _spawner;
    private Queue<IngredientSO> _queue = new();

    private void Awake()
    {
        //
    }

    private void OnDestroy()
    {
        //
    }

    private void AddToQueue(IngredientSO ingredient)
    {
        _queue.Enqueue(ingredient);
        _spawner ??= StartCoroutine(SpawnQueue());
    }

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private void Spawn()
    {
        Instantiate(_boxPrefab, Utilities.GetRandomPointInBounds(transform), Quaternion.identity);
    }

    private IEnumerator SpawnQueue()
    {
        while (_queue.Count > 0)
        {
            Spawn();
            _queue.Dequeue();
            yield return new WaitForSeconds(1);
        }

        yield return null;
    }
}
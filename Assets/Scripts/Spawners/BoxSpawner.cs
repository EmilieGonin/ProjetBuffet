using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSpawner : Spawner
{
    [Header("Dependencies")]
    [HorizontalLine(color: EColor.Red)]
    [SerializeField] private GameObject _boxPrefab;

    [Header("Settings")]
    [HorizontalLine(color: EColor.Blue)]
    [SerializeField] private float _cooldown = 0.5f;

    private Coroutine _spawner;
    private Queue<IngredientSO> _queue = new();

    protected override void Awake()
    {
        base.Awake();
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
            yield return new WaitForSeconds(_cooldown);
        }

        yield return null;
    }
}
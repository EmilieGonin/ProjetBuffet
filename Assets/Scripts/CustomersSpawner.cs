using NaughtyAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomersSpawner : MonoBehaviour
{
    [Header("Dependencies")]
    [HorizontalLine(color: EColor.Red)]
    [SerializeField] private List<GameObject> _customersPrefabs;

    [Header("Settings")]
    [HorizontalLine(color: EColor.Blue)]
    [SerializeField] private int _minTime = 5;
    [SerializeField] private int _maxTime = 10;
    [SerializeField] private int _maxCustomers = 10;

    private int _customersCount;

    private void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private void Spawn()
    {
        _customersCount++;

        int random = UnityEngine.Random.Range(0, _customersPrefabs.Count);
        Instantiate(_customersPrefabs[random], transform.position, Quaternion.identity);
    }

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private IEnumerator StartSpawn()
    {
        while (_customersCount < _maxCustomers)
        {
            Spawn();
            int random = UnityEngine.Random.Range(_minTime, _maxTime);
            yield return new WaitForSeconds(random);
        }

        yield return null;
    }
}
using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

public class CustomersSpawner : MonoBehaviour
{
    [SerializeField] private List<GameObject> _customersPrefabs;

    private void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    private void Spawn()
    {
        int random = Random.Range(0, _customersPrefabs.Count);

        Instantiate(_customersPrefabs[random], transform.position, Quaternion.identity);
    }
}
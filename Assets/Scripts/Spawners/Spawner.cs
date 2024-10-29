using UnityEngine;

public abstract class Spawner : MonoBehaviour
{
    protected virtual void Awake()
    {
        GetComponent<Renderer>().enabled = false;
    }
}
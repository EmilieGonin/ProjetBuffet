using UnityEngine;

[CreateAssetMenu(fileName = "FurnitureSO", menuName = "Scriptable Objects/FurnitureSO")]
public class FurnitureSO : ScriptableObject
{
    public string Name;
    public int Price;
    public GameObject Prefab;
}
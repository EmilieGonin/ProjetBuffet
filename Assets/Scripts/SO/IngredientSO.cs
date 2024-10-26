using UnityEngine;

public enum IngredientCategory
{
    //
}

public enum IngredientStorageType
{
    Dry,
    Fresh,
    Frozen
}

[CreateAssetMenu(fileName = "IngredientSO", menuName = "Scriptable Objects/IngredientSO")]
public class IngredientSO : BuyableElementSO
{
    public IngredientCategory Category;
    public IngredientStorageType StorageType;
}
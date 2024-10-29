using NaughtyAttributes;
using System.Collections.Generic;
using UnityEngine;

public enum RecipeDisplay
{
    Tray, Portion
}

[CreateAssetMenu(fileName = "RecipeSO", menuName = "Scriptable Objects/RecipeSO")]
public class RecipeSO : BuyableElementSO
{
    public RecipeDisplay Display;
    public bool IsPortionned => Display is RecipeDisplay.Portion;
    [ShowIf("IsPortionned")] public GameObject PortionFBX;
    public List<IngredientSO> Ingredients;
}
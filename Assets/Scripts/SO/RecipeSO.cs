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
    // Asset portion 3D
}
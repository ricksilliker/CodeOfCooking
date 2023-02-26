using UnityEngine;

[CreateAssetMenu(fileName = "RecipeData", menuName = "Cooking", order = 0)]
public class RecipeData : ScriptableObject
{
    [SerializeField] private string displayName;
    [SerializeField] private GameObject model;
    [SerializeField] private IngredientData[] ingredients;
        
}
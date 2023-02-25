using UnityEngine;

namespace Code
{
    [CreateAssetMenu(fileName = "RecipeData", menuName = "Cooking", order = 0)]
    public class RecipeData : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private GameObject model;
        [SerializeField] private IngredientData[] ingredients;
        
    }
}
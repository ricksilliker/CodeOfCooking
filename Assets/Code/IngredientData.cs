using UnityEngine;

namespace Code
{
    [CreateAssetMenu(fileName = "IngredientData", menuName = "Cooking", order = 0)]
    public class IngredientData : ScriptableObject
    {
        [SerializeField] private string name;
        [SerializeField] private GameObject model;
        [SerializeField] private float power;
        [SerializeField] private float defense;
        [SerializeField] private float health;
        [SerializeField] private float quickness;
    }
}
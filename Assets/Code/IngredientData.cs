using UnityEngine;

[CreateAssetMenu(fileName = "IngredientData", menuName = "Cooking", order = 0)]
public class IngredientData : ScriptableObject
{
    [SerializeField] private string displayName;
    [SerializeField] private float power;
    [SerializeField] private float defense;
    [SerializeField] private float health;
    [SerializeField] private float quickness;
    [SerializeField] private float sight;
}
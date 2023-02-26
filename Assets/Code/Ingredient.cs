using System;
using UnityEngine;

namespace Code
{
    public class Ingredient : MonoBehaviour
    {
        [Serializable]
        public enum IngredientState
        {
            Raw,
            UnderCooked,
            Cooked,
            OverCooked,
            Frozen
        }
        
        [SerializeField] private IngredientData data;
        [SerializeField] private IngredientState state;
    }
}
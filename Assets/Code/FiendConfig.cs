using UnityEngine;

[CreateAssetMenu(fileName = "FiendConfig", menuName = "FiendConfig", order = 0)]
public class FiendConfig : ScriptableObject
{
    public GameObject fiendPrefab;
    public float maxHunger;
    public float hungerRate;
}
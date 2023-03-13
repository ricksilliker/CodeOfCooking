using UnityEngine;

public class FiendSpawner : MonoBehaviour
{
    [SerializeField] private FiendConfig config;
    
    private void Start()
    {
        GameObject.Instantiate(config.fiendPrefab, transform);
        FiendData data = new FiendData();
        data.config = config;
        FiendManager.Instance.AddFiend(data);
    }
}
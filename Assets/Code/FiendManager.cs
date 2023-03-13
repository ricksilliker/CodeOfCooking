using UnityEngine;

public class FiendManager : MonoBehaviour
{
    private int _fiendCount;
    private const int _maxFiends = 100;
    private FiendData[] _fiends = new FiendData[_maxFiends];

    private static FiendManager _instance;

    public static FiendManager Instance
    {
        get {             
            if(_instance == null)
            {
                _instance = GameObject.FindObjectOfType<FiendManager>();
            }

            return _instance;
        }
    }

    public void AddFiend(FiendData data)
    {
        _fiends[_fiendCount] = data;
        _fiendCount++;
    }
    
    private void Awake()
    {
        _instance = this;
    }
    
    private void Update()
    {
        for (int i = 0; i < _maxFiends; i++)
        {
            _fiends[i].Update();
        }
    }
}
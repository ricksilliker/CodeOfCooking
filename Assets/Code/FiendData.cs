using System;
using UnityEngine;

public delegate void HungerEventHandler();

public struct FiendData
{
    public float hunger;
    public FiendConfig config;
    public event HungerEventHandler NotHungry;

    public void Update()
    {
        if (hunger > 0)
        {
            hunger += config.hungerRate;
            hunger = Mathf.Min(hunger, config.maxHunger);
        }
        else
        {
            NotHungry?.Invoke();
        }
    }
}
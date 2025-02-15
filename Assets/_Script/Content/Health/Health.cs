using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public event Action OnDamaged;
    public event Action OnDead;

    [SerializeField] private float value = 100;
    public float Value => value;

    public bool TryTakeDamage(float damage)
    {
        bool condition = false;
        if (condition) return false;

        OnDamaged?.Invoke();
        OnDead?.Invoke();
        return true;
    }
}

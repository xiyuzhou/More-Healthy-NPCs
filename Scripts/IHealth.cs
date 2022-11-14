using System;
using System.Collections;
using UnityEngine;

public interface IHealth
{
    event System.Action<float> OnHPPctChanged;
    event System.Action OnDied;
    void TakeDamage(int amount);
    void TakePoisonDamage(int amount, int afterDamage, int hits, float delay);
    void TakeHeavyDamage(int amount);
}

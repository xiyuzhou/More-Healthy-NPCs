using System;
using System.Collections;
using UnityEngine;

public class NPC : MonoBehaviour
{
    internal void TakeDamage(int amount)
    {
        GetComponent<IHealth>().TakeDamage(amount);
    }

    internal void TakePoisonDamage(int amount, int afterDamage, int hits, float delay)
    {
        GetComponent<IHealth>().TakePoisonDamage(amount,afterDamage,hits,delay);
    }
    internal void TakeHeavyDamage(int amount)
    {
        GetComponent<IHealth>().TakeHeavyDamage(amount);
    }
}

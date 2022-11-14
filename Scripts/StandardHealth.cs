using System;
using System.Collections;
using UnityEngine;

public class StandardHealth : MonoBehaviour, IHealth
{
    [SerializeField] private int startingHealth = 100;
    private int currentHealth;
    private bool canTakeDamage = true;
    public event Action<float> OnHPPctChanged = delegate { };
    public event Action OnDied = delegate { };
    private void Start()
    {
        currentHealth = startingHealth;
    }

    public float CurrentHpPct
    {
        get { return (float)currentHealth / (float)startingHealth; }
    }

    public void TakeDamage(int amount)
    {
        if (canTakeDamage)
        {
            StartCoroutine(InvulnerabilityTimer(1f));
            currentHealth -= amount;
            OnHPPctChanged(CurrentHpPct);

            if (CurrentHpPct <= 0)
            {
                OnDied();
            }
        }
    }
    public void TakePoisonDamage(int amount, int afterDamage,int hits, float delay)
    {
        if (amount <= 0)
        {
            //throw new ArgumentOutOfRangeException("Invalid Damage amount specified: " + amount);
        }

        currentHealth -= amount;

        OnHPPctChanged(CurrentHpPct);

        if (CurrentHpPct <= 0)
        {
            Die();
        }
        StartCoroutine(AfterDamage(delay,afterDamage,hits));
    }

    public void TakeHeavyDamage(int amount)
    {
        if (canTakeDamage)
        {
            StartCoroutine(InvulnerabilityTimer(3f));
            currentHealth -= amount;
            OnHPPctChanged(CurrentHpPct);

            if (CurrentHpPct <= 0)
            {
                OnDied();
            }
        }
    }

    private IEnumerator AfterDamage(float delay, int afterDamage, int hits)
    {
        int currentHits = 0;
        while (currentHits < hits)
        {
            TakeDamage(afterDamage);
            yield return new WaitForSeconds(delay);
            currentHits++;
        }
    }
    private IEnumerator InvulnerabilityTimer(float time)
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(time);
        canTakeDamage = true;
    }
    private void Die()
    {
        OnDied();
    }
}

﻿using System.Collections;
using System;
using UnityEngine;
/*
public class NumberOfHitsHealth : MonoBehaviour, IHealth
{
    [SerializeField]
    private int healthInHits = 5;

    [SerializeField]
    private float invulnerabilityTimeAfterEachHit = 5f;

    private int hitsRemaining;
    private bool canTakeDamage = true;

    public event Action<float> OnHPPctChanged = delegate(float f) { };
    public event Action OnDied = delegate { };

    public float CurrentHpPct
    {
        get { return (float)hitsRemaining / (float)healthInHits; }
    }

    private void Start()
    {
        hitsRemaining = healthInHits;
    }

    public void TakeDamage(int amount)
    {
        if (canTakeDamage)
        {
            StartCoroutine(InvulnerabilityTimer());

            Debug.Log(CurrentHpPct);
            hitsRemaining--;

            OnHPPctChanged(CurrentHpPct);

            if (hitsRemaining <= 0)
            {
                OnDied();
            }
        }
    }

    public void TakePoisionDamage(int amount,int afterDamage)
    {
        if (canTakeDamage)
        {
            StartCoroutine(InvulnerabilityTimer());

            hitsRemaining--;

            OnHPPctChanged(CurrentHpPct);

            if (hitsRemaining <= 0)
            {
                OnDied();
            }
        }
    }


    private IEnumerator InvulnerabilityTimer()
    {
        canTakeDamage = false;
        yield return new WaitForSeconds(invulnerabilityTimeAfterEachHit);
        canTakeDamage = true;
    }
}
*/
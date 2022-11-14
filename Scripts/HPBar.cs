using System;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class HPBar : MonoBehaviour
{
    private Slider _slider;
    [SerializeField] private Material material;
    private void Start()
    {
        _slider = GetComponentInChildren<Slider>();
        GetComponentInParent<IHealth>().OnHPPctChanged += HandleHPPctChanged;
    }

    private void HandleHPPctChanged(float pct)
    {
        _slider.value = pct;
        StartCoroutine(InvulnerabilityTimer(0.15f));
    }

    IEnumerator InvulnerabilityTimer(float time)
    {
        material.color = Color.red;
        yield return new WaitForSeconds(time);
        material.color = Color.white;
    }
}

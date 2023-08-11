using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FillsBars : MonoBehaviour
{
    public Image HealthFill;
    public Image ManaFill;
    public Image StaminaFill;
    public PlayerStats Stats;

    void Update()
    {
        float healthPercent = (float)Stats.Life / Stats.LifeMax;
        float manaPercent = (float)Stats.Mana / Stats.ManaMax;
        float staminaPercent = (float)Stats.Stamina / Stats.StaminaMax;
        HealthFill.fillAmount = healthPercent;
        ManaFill.fillAmount = manaPercent;
        StaminaFill.fillAmount = staminaPercent;
    }
}

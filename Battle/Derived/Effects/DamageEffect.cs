﻿using Fralle;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Abilities/Effects/Damage")]
public class DamageEffect : AbilityEffect
{
  public int minAmount = 1;
  public int maxAmount = 1;

  public override void Affect(Ability ability, GameObject target)
  {
    base.Affect(ability, target);
    DamageController damageController = target.GetComponent<DamageController>();
    if (damageController)
    {
      System.Random rnd = new System.Random();
      int amount = rnd.Next(minAmount, maxAmount);
      damageController.TakeDamage(amount, ability.caster, ability.name);
    }
    else Debug.LogWarning("Target is missing DamageController: " + target.name);

  }
}

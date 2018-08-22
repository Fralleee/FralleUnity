using UnityEngine;
using System;
using System.Linq;

[CreateAssetMenu(menuName = "Skills/Target")]
public class TargetSkill : AISkill
{
  public override void Setup(GameObject casterGo, int targetLayerParam) { base.Setup(casterGo, targetLayerParam); }
  public override void Cast(GameObject target)
  {
    base.Cast(target);
    TargetCast();
  }
  void TargetCast() { }
}
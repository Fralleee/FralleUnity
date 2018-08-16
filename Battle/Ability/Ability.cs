using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
  [SerializeField] Blocker windupBlocker;
  [SerializeField] Blocker recoveryBlocker;

  [Header("Settings")]
  public string abilityName = "Ability name";
  public int abilityRange = 2;
  public float cooldown = 2;
  public float windupTime = 1;
  public float recoveryTime = 0.5f;
  public List<AbilityEffect> effects = new List<AbilityEffect>();
  [Space(10)]

  [Header("Visuals")]
  public CastAnimations castAnimation = CastAnimations.DirectTrigger;
  public ParticleSystem windupEffect;
  public ParticleSystem castingEffect;


  [HideInInspector] protected float lastAction = 0;
  public GameObject caster { get; set; }
  public bool isReady { get { return Time.time > lastAction; } }

  public virtual void Setup(GameObject casterGo)
  {
    caster = casterGo;
    lastAction = 0;
  }

  public virtual void Cast() { lastAction = Time.time + cooldown; }

}

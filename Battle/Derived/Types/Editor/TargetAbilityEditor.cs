using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(TargetAbility))]
public class TargetAbilityEditor : Editor
{

  override public void OnInspectorGUI()
  {
    DrawDefaultInspector();
    TargetAbility targetAbility = (TargetAbility)target;

    using (var group = new EditorGUILayout.FadeGroupScope(System.Convert.ToSingle(targetAbility.targetReceiver == TargetReceiver.LOCATION)))
    {
      if (group.visible)
      {
        targetAbility.aoeRadius = EditorGUILayout.FloatField("AOE Radius", targetAbility.aoeRadius);
        targetAbility.locationEffect = (ParticleSystem)EditorGUILayout.ObjectField("Location Effect", targetAbility.locationEffect, typeof(ParticleSystem), true);
      }
    }

  }
}

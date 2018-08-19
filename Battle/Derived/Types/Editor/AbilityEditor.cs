using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Ability), true)]
public class AbilityEditor : Editor
{
  override public void OnInspectorGUI()
  {
    DrawDefaultInspector();
    Ability ability = (Ability)target;
    using (var group = new EditorGUILayout.FadeGroupScope(System.Convert.ToSingle(ability.windupAnimation == WindupAnimation.Spell)))
    {
      if (group.visible)
      {
        EditorGUILayout.Space();
        EditorGUILayout.LabelField("Spell Specific", EditorStyles.boldLabel);
        ability.castAnimation = (CastAnimation)EditorGUILayout.EnumFlagsField("Cast Animation", ability.castAnimation);
        ability.castingEffect = (ParticleSystem)EditorGUILayout.ObjectField("Casting Effect", ability.castingEffect, typeof(ParticleSystem), true);
      }
    }
  }
}

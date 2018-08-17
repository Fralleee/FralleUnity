using UnityEditor;
using UnityEngine;

namespace Fralle
{
  [CustomEditor(typeof(GameEvent))]
  public class GameEventEditor : Editor
  {
    public override void OnInspectorGUI()
    {
      base.OnInspectorGUI();
      GUI.enabled = Application.isPlaying;
      GameEvent e = (GameEvent)target;
      if (GUILayout.Button("Raise")) e.Raise();
    }
  }
}
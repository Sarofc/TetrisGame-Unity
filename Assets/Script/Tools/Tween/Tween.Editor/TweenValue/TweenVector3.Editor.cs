#if UNITY_EDITOR

using UnityEditor;
using UnityEngine;

namespace Saro {
    public abstract partial class TweenVector3 : TweenFormTo<Vector3> {
        protected new class Editor<T> : TweenFormTo<Vector3>.Editor<T> where T : TweenVector3 {
            private SerializedProperty m_FromXProp;
            private SerializedProperty m_FromYProp;
            private SerializedProperty m_FromZProp;

            private SerializedProperty m_ToXProp;
            private SerializedProperty m_ToYProp;
            private SerializedProperty m_ToZProp;

            protected override void OnEnable () {
                base.OnEnable ();

                m_FromXProp = fromProp.FindPropertyRelative ("x");
                m_ToXProp = toProp.FindPropertyRelative ("x");

                m_FromYProp = fromProp.FindPropertyRelative ("y");
                m_ToYProp = toProp.FindPropertyRelative ("y");

                m_FromZProp = fromProp.FindPropertyRelative ("z");
                m_ToZProp = toProp.FindPropertyRelative ("z");
            }

            protected override void OnPropertiesGUI (Tween tween) {
                EditorGUILayout.Space ();

                FromToFieldLayout ("X", m_FromXProp, m_ToXProp);
                FromToFieldLayout ("Y", m_FromYProp, m_ToYProp);
                FromToFieldLayout ("Z", m_FromZProp, m_ToZProp);
            }
        }
    }
}
#endif
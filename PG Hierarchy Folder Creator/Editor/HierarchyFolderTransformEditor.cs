using UnityEditor;
using UnityEngine;

namespace PG.HierarchyFolder
{
    [CustomEditor(typeof(HierarchyFolderTransform))]
    public class HierarchyFolderTransformEditor : Editor
    {
        private HierarchyFolderTransform targetTransform;

        void OnEnable()
        {
            targetTransform = (HierarchyFolderTransform)target;
            LockTargetTransform();
        }

        public override void OnInspectorGUI()
        {
            EditorGUILayout.HelpBox("Трансформации этого объекта заблокированы.", MessageType.Info);
            //targetTransform.folderColor = EditorGUILayout.ColorField(targetTransform.folderColor);
        }

        private void LockTargetTransform()
        {
            targetTransform.transform.hideFlags = HideFlags.NotEditable; // Делает трансформ не редактируемым в инспекторе
        }

        void OnSceneGUI()
        {
            LockTargetTransform();
            if (targetTransform.transform.localPosition != Vector3.zero)
            {
                targetTransform.transform.localPosition = Vector3.zero;
            }

            if (targetTransform.transform.localScale != Vector3.one)
            {
                targetTransform.transform.localScale = Vector3.one;
            }

            if (targetTransform.transform.localRotation != Quaternion.identity)
            {
                targetTransform.transform.localRotation = Quaternion.identity;
            }
        }
    }
}
using UnityEditor;
using UnityEngine;

namespace PG.HierarchyFolder
{
    [InitializeOnLoad]
    public static class CustomIconFolder
    {
        private static Texture2D folderIcon;

        static CustomIconFolder()
        {
            // Загрузка иконки папки
            folderIcon = EditorGUIUtility.FindTexture("Folder Icon");

            // Регистрация метода обратного вызова
            EditorApplication.hierarchyWindowItemOnGUI += HierarchyItemCallback;
        }

        private static void HierarchyItemCallback(int instanceID, Rect selectionRect)
        {
            GameObject obj = EditorUtility.InstanceIDToObject(instanceID) as GameObject;

            if (obj != null && obj.TryGetComponent(out HierarchyFolderTransform folderTransform))
            {

                // Отрисовка иконки папки
                Rect iconRect = new Rect(selectionRect.x, selectionRect.y, 16, 16);
                iconRect.x += selectionRect.width - 16; // Сдвиг иконки вправо
                GUI.DrawTexture(iconRect, folderIcon);
            }
        }
    }
}

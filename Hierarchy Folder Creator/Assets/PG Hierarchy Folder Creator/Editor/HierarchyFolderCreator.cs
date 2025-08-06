using UnityEngine;
using UnityEditor;

namespace PG.HierarchyFolder
{
    public class HierarchyFolderCreator : MonoBehaviour
    {
        [MenuItem("GameObject/PG/Sort/Folder",priority =0)]
        static void Create()
        {
            GameObject folder = Resources.Load("PG Hierarchy Folder Creator/Folder") as GameObject;
            GameObject folderInstance = Instantiate(folder, Selection.activeTransform);
            folderInstance.name = folder.name;
            Selection.activeObject = folderInstance;
        }
        [MenuItem("GameObject/PG/Sort/Separator", priority = 0)]
        static void CreateSeparator()
        {
            GameObject separator = Resources.Load("PG Hierarchy Folder Creator/Separator") as GameObject;
            GameObject separatorInstance = Instantiate(separator, Selection.activeTransform);
            separatorInstance.TryGetComponent(out SeparatorNameChanger changer);
            separatorInstance.name = changer.fullName;
            Selection.activeObject = separatorInstance;
        }
    }
}

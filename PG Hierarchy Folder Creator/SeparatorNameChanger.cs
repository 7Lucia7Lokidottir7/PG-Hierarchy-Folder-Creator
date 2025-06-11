using UnityEngine;

public class SeparatorNameChanger : MonoBehaviour
{
    private const string preName = "-----------";
    private const string afterName = " --------------------------";
    [SerializeField] private new string name = "Name";
    public string fullName => preName + name + afterName;
    private void OnValidate()
    {
        base.name = fullName;
    }
    [ContextMenu("Remove Component")]
    void DestroySeparator()
    {
        DestroyImmediate(gameObject);
    }
}

using UnityEngine;
using UnityEditor;

[CustomPropertyDrawer(typeof(InjectAssetAttribute))]
public class InjectAssetDrawer : PropertyDrawer
{
    public override void OnGUI(Rect position, SerializedProperty prop, GUIContent label)
    {
        var attr = attribute as InjectAssetAttribute;
        if (prop.objectReferenceValue == null)
        {
            var allAssets = AssetDatabase.FindAssets("t:" + attr.assetType.Name);
            if (allAssets.Length != 0)
            {
                Object t = AssetDatabase.LoadAssetAtPath<Object>(
                    AssetDatabase.GUIDToAssetPath(allAssets[0])
                    );
                prop.objectReferenceValue = t;
            }
        }
        prop.objectReferenceValue = EditorGUI.ObjectField(position,
            label,
            prop.objectReferenceValue,
            attr.assetType,
            false);
    }
}

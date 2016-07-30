using UnityEngine;

public class InjectAssetAttribute : PropertyAttribute
{
    public System.Type assetType;

    public string assetName;

    public InjectAssetAttribute(System.Type type, string name = "")
    {
        assetType = type;
        assetName = name;
    }
}

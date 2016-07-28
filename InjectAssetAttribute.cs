using UnityEngine;

public class InjectAssetAttribute : PropertyAttribute
{
    public System.Type assetType;

    public InjectAssetAttribute(System.Type type)
    {
        assetType = type;
    }
}

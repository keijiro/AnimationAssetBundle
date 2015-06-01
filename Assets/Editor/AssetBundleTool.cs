using UnityEngine;
using UnityEditor;

public class AssetBundleTool
{
    [MenuItem("Cutom/Build AssetBundles")]
    static void BuildAssetBundles()
    {
        BuildPipeline.BuildAssetBundles("Assets/StreamingAssets/AssetBundles");
    }
}

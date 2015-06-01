using UnityEngine;
using System.Collections;

public class Loader : MonoBehaviour
{
    IEnumerator Start()
    {
        var www = new WWW("file:" + Application.streamingAssetsPath + "/AssetBundles/animation");

        yield return www;

        var controller = www.assetBundle.LoadAsset<RuntimeAnimatorController>("Idle");
        Debug.Log("Controller: " + controller);

        var animator = GetComponent<Animator>();
        animator.runtimeAnimatorController = controller;
    }
}

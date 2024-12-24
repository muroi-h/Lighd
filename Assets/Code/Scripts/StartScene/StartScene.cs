using Assets.Code.Scripts.Commons;
using UnityEngine;

/// <summary>
/// スタート画面
/// </summary>
public class StartScene : MonoBehaviour
{
    void Start()
    {
        DefaultOrientation defaultOrientation = new();

        defaultOrientation.LandscapeOrientation();
    }
}

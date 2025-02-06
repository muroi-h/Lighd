using NUnit.Framework;
using UnityEngine;
using System;
using System.Reflection;

public class StartSceneTest
{
    [SetUp]
    public void セットアップ()
    {
        object startScene = Activator.CreateInstance(typeof(StartScene));
        MethodInfo start = typeof(StartScene).GetMethod(
            "Start",
            BindingFlags.Instance | BindingFlags.NonPublic
        );
        start.Invoke(startScene, null);
    }

    [Test]
    public void 右向きへの画面回転が有効である()
    {
        Assert.True(Screen.autorotateToLandscapeRight);
    }

    [Test]
    public void 左向きへの画面回転が有効である()
    {
        Assert.True(Screen.autorotateToLandscapeLeft);
    }

    [Test]
    public void 上向きへの画面回転が有効である()
    {
        Assert.False(Screen.autorotateToPortrait);
    }

    [Test]
    public void 下向きへの画面回転が有効である()
    {
        Assert.False(Screen.autorotateToPortraitUpsideDown);
    }
}

using NUnit.Framework;
using Assets.Code.Scripts.Commons;
using UnityEngine;

public class DefaultOrientationTest
{
    [SetUp]
    public void セットアップ()
    {
        DefaultOrientation defaultOrientation = new();
        defaultOrientation.LandscapeOrientation();
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
    public void 上向きへの画面回転が無効である()
    {
        Assert.False(Screen.autorotateToPortrait);
    }

    [Test]
    public void 下向きへの画面回転が無効である()
    {
        Assert.False(Screen.autorotateToPortraitUpsideDown);
    }
}

using UnityEngine;

namespace Assets.Code.Scripts.Commons
{
    /// <summary>
    /// 画面回転を固定
    /// </summary>
    public class DefaultOrientation
    {
        /// <summary>
        /// 画面の向きを横に固定
        /// </summary>
        public void LandscapeOrientation()
        {
            Screen.autorotateToPortrait = false;
            Screen.autorotateToPortraitUpsideDown = false;
            Screen.autorotateToLandscapeLeft = true;
            Screen.autorotateToLandscapeRight = true;

            Screen.orientation = ScreenOrientation.AutoRotation;
        }
    }
}

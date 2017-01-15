using SteamVRInputObservables;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservablesSample
{
    public class InputTest : MonoBehaviour
    {
        void Start()
        {
            #region Right
            #region Trigger
            this.OnRightTriggerPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger PressDown"));
            this.OnRightTriggerPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger PressUp"));
            this.RightTriggerPress()
                .Subscribe(x => Debug.Log("Right Trigger Press:" + x));

            this.OnRightTriggerTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right Trigger TouchDown"));
            this.OnRightTriggerTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Trigger TouchUp"));

            this.RightTriggerValue()
                .Subscribe(x => Debug.Log("Right Trigger Value:" + x));
            #endregion

            #region TopuchPad
            this.OnRightTouchPadPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad PressDown"));
            this.OnRightTouchPadPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad PressUp"));
            this.RightTouchPadPress()
                .Subscribe(x => Debug.Log("Right TouchPad Press:" + x));

            this.OnRightTouchPadTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right TouchPad TouchDown"));
            this.OnRightTouchPadTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Right TouchPad TouchUp"));

            this.RightTouchPosition()
                .Subscribe(x => Debug.Log("Right TouchPad Position:" + x));
            #endregion

            #region Application Menu
            this.OnRightApplicationMenuPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressDown"));
            this.OnRightApplicationMenuPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressUp"));
            this.RightApplicationMenuPress()
                .Subscribe(x => Debug.Log("RightApplicationMenu:" + x));
            #endregion

            #region Grip
            this.OnRightGripPressDownAsObservable()
                 .Subscribe(_ => Debug.Log("Right Application PressDown"));
            this.OnRightGripPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Right Application PressUp"));
            this.RightGripPress()
                .Subscribe(x => Debug.Log("RightGrip:" + x));

            #endregion
            #endregion

            #region Left
            #region Trigger
            this.OnLeftTriggerPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Left Trigger PressDown"));
            this.OnLeftTriggerPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Left Trigger PressUp"));
            this.LeftTriggerPress()
                .Subscribe(x => Debug.Log("Left Trigger Press:" + x));

            this.OnLeftTriggerTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Left Trigger TouchDown"));
            this.OnLeftTriggerTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Left Trigger TouchUp"));

            this.LeftTriggerValue()
                .Subscribe(x => Debug.Log("Left Trigger Value:" + x));
            #endregion

            #region TopuchPad
            this.OnLeftTouchPadPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Left TouchPad PressDown"));
            this.OnLeftTouchPadPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Left TouchPad PressUp"));
            this.LeftTouchPadPress()
                .Subscribe(x => Debug.Log("Left TouchPad Press:" + x));

            this.OnLeftTouchPadTouchDownAsObservable()
                 .Subscribe(_ => Debug.Log("Left TouchPad TouchDown"));
            this.OnLeftTouchPadTouchUpAsObservable()
                .Subscribe(_ => Debug.Log("Left TouchPad TouchUp"));

            this.LeftTouchPosition()
                .Subscribe(x => Debug.Log("Left TouchPad Position:" + x));
            #endregion

            #region Application Menu
            this.OnLeftApplicationMenuPressDownAsObservable()
                .Subscribe(_ => Debug.Log("Left Application PressDown"));
            this.OnLeftApplicationMenuPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Left Application PressUp"));
            this.LeftApplicationMenuPress()
                .Subscribe(x => Debug.Log("LeftApplicationMenu:" + x));
            #endregion

            #region Grip
            this.OnLeftGripPressDownAsObservable()
                 .Subscribe(_ => Debug.Log("Left Application PressDown"));
            this.OnLeftGripPressUpAsObservable()
                .Subscribe(_ => Debug.Log("Left Application PressUp"));
            this.LeftGripPress()
                .Subscribe(x => Debug.Log("LeftGrip:" + x));

            #endregion
            #endregion
        }

    }
}

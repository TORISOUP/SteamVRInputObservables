using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservables
{
    public static class SteamVREventTriggerExtensions
    {

        private static readonly string PrefabPath = "SteamVREventTrigger";

        private static SteamVREventTrigger _trigger;

        private static SteamVREventTrigger EventTrigger
        {
            get
            {
                if (_trigger != null) return _trigger;
                if (SteamVREventTrigger.Instance != null)
                {
                    _trigger = SteamVREventTrigger.Instance;
                    return _trigger;
                }
                var resource = Resources.Load<GameObject>(PrefabPath);
                var o = Object.Instantiate(resource);
                _trigger = o.GetComponent<SteamVREventTrigger>();
                return _trigger;
            }
        }


        #region Right
        #region Trigger
        #region Touch
        public static IObservable<Unit> OnRightTriggerTouchDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnTouchDown;
        }
        public static IObservable<Unit> OnRightTriggerTouchUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<float> RightTriggerValue(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).AxisX;
        } 

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTriggerPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightTriggerPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightTriggerPress(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnRightTouchPadTouchDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnTouchDown;
        }
        public static IObservable<Unit> OnRightTouchPadTouchUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<Vector2> RightTouchPosition(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).Axis;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTouchPadPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightTouchPadPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightTouchPadPress(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnRightGripPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightGripPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightGripPress(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnRightApplicationMenuPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightApplicationMenuPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightApplicationMenuPress(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnRightSystemPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightSystemPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightSystemPress(this Component component)
        {
            if (component == null || EventTrigger.RightController == null) return null;
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #endregion
        #region Left
        #region Trigger
        #region Touch
        public static IObservable<Unit> OnLeftTriggerTouchDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnTouchDown;
        }
        public static IObservable<Unit> OnLeftTriggerTouchUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<float> LeftTriggerValue(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).AxisX;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTriggerPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftTriggerPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftTriggerPress(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnLeftTouchPadTouchDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnTouchDown;
        }
        public static IObservable<Unit> OnLeftTouchPadTouchUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<Vector2> LeftTouchPosition(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).Axis;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTouchPadPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftTouchPadPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftTouchPadPress(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnLeftGripPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftGripPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftGripPress(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnLeftApplicationMenuPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftApplicationMenuPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftApplicationMenuPress(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnLeftSystemPressDownAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftSystemPressUpAsObservable(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftSystemPress(this Component component)
        {
            if (component == null || EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion

        #endregion
        #endregion

        private static T GetOrAddComponent<T>(GameObject gameObject) where T : Component
        {
            var component = gameObject.GetComponent<T>();
            if (component == null)
            {
                component = gameObject.AddComponent<T>();
            }

            return component;
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservables
{
    public static class ObservableSteamInput
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
        public static IObservable<Unit> OnRightTriggerTouchDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnTouchDown;
        }
        public static IObservable<Unit> OnRightTriggerTouchUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<float> RightTriggerValue()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).AxisX;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTriggerPressDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightTriggerPressUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightTriggerPress()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnRightTouchPadTouchDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnTouchDown;
        }
        public static IObservable<Unit> OnRightTouchPadTouchUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<Vector2> RightTouchPosition()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).Axis;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTouchPadPressDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightTouchPadPressUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightTouchPadPress()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnRightGripPressDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightGripPressUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightGripPress()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnRightApplicationMenuPressDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightApplicationMenuPressUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightApplicationMenuPress()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnRightSystemPressDown()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPressDown;
        }
        public static IObservable<Unit> OnRightSystemPressUp()
        {
            if (EventTrigger.RightController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> RightSystemPress()
        {
            if (EventTrigger.RightController == null) return null;
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.RightController).OnPress;
        }

        #endregion

        #endregion
        #endregion
        #region Left
        #region Trigger
        #region Touch
        public static IObservable<Unit> OnLeftTriggerTouchDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnTouchDown;
        }
        public static IObservable<Unit> OnLeftTriggerTouchUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<float> LeftTriggerValue()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).AxisX;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTriggerPressDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftTriggerPressUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftTriggerPress()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TriggerInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnLeftTouchPadTouchDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnTouchDown;
        }
        public static IObservable<Unit> OnLeftTouchPadTouchUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnTouchUp;
        }

        public static IReadOnlyReactiveProperty<Vector2> LeftTouchPosition()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).Axis;
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTouchPadPressDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftTouchPadPressUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftTouchPadPress()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<TouchpadInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnLeftGripPressDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftGripPressUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftGripPress()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<GripInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnLeftApplicationMenuPressDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftApplicationMenuPressUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftApplicationMenuPress()
        {
            if (EventTrigger.LeftController == null) return null;
            return GetOrAddComponent<ApplicationMenuInputEventTrigger>(EventTrigger.LeftController).OnPress;
        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnLeftSystemPressDown()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.LeftController).OnPressDown;
        }
        public static IObservable<Unit> OnLeftSystemPressUp()
        {
            if (EventTrigger.LeftController == null) return Observable.Empty<Unit>();
            return GetOrAddComponent<SystemInputEventTrigger>(EventTrigger.LeftController).OnPressUp;
        }

        public static IReadOnlyReactiveProperty<bool> LeftSystemPress()
        {
            if (EventTrigger.LeftController == null) return null;
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
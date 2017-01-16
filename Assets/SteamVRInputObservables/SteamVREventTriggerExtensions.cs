using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;

namespace SteamVRInputObservables
{
    public static class SteamVREventTriggerExtensions
    {
        #region Right
        #region Trigger
        #region Touch
        public static IObservable<Unit> OnRightTriggerTouchDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTriggerTouchDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightTriggerTouchUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTriggerTouchUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<float> RightTriggerValue(this Component component)
        {
            return ObservableSteamInput.RightTriggerValue();
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTriggerPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTriggerPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightTriggerPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTriggerPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> RightTriggerPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightTriggerPress();
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnRightTouchPadTouchDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTouchPadTouchDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightTouchPadTouchUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTouchPadTouchUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<Vector2> RightTouchPosition(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightTouchPosition();
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnRightTouchPadPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTouchPadPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightTouchPadPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightTouchPadPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> RightTouchPadPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightTouchPadPress();
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnRightGripPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightGripPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightGripPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightGripPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> RightGripPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightGripPress();
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnRightApplicationMenuPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightApplicationMenuPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightApplicationMenuPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightApplicationMenuPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> RightApplicationMenuPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightApplicationMenuPress();

        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnRightSystemPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightSystemPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnRightSystemPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnRightSystemPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> RightSystemPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.RightSystemPress();
        }

        #endregion

        #endregion
        #endregion

        #region Left
        #region Trigger
        #region Touch
        public static IObservable<Unit> OnLeftTriggerTouchDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTriggerTouchDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftTriggerTouchUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTriggerTouchUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<float> LeftTriggerValue(this Component component)
        {
            return ObservableSteamInput.LeftTriggerValue();
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTriggerPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTriggerPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftTriggerPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTriggerPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> LeftTriggerPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftTriggerPress();
        }

        #endregion
        #endregion
        #region TouchPad
        #region Touch
        public static IObservable<Unit> OnLeftTouchPadTouchDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTouchPadTouchDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftTouchPadTouchUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTouchPadTouchUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<Vector2> LeftTouchPosition(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftTouchPosition();
        }

        #endregion
        #region Press
        public static IObservable<Unit> OnLeftTouchPadPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTouchPadPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftTouchPadPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftTouchPadPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> LeftTouchPadPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftTouchPadPress();
        }

        #endregion
        #endregion TouchPad
        #region Grip
        #region Press
        public static IObservable<Unit> OnLeftGripPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftGripPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftGripPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftGripPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> LeftGripPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftGripPress();
        }

        #endregion

        #endregion
        #region ApplicationMenu
        #region Press
        public static IObservable<Unit> OnLeftApplicationMenuPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftApplicationMenuPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftApplicationMenuPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftApplicationMenuPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> LeftApplicationMenuPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftApplicationMenuPress();

        }

        #endregion

        #endregion
        #region SystemMenu
        #region Press
        public static IObservable<Unit> OnLeftSystemPressDownAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftSystemPressDown().TakeUntilDestroy(component);
        }
        public static IObservable<Unit> OnLeftSystemPressUpAsObservable(this Component component)
        {
            if (component == null) return Observable.Empty<Unit>();
            return ObservableSteamInput.OnLeftSystemPressUp().TakeUntilDestroy(component);
        }

        public static IReadOnlyReactiveProperty<bool> LeftSystemPress(this Component component)
        {
            if (component == null) return null;
            return ObservableSteamInput.LeftSystemPress();
        }

        #endregion

        #endregion
        #endregion

    }
}
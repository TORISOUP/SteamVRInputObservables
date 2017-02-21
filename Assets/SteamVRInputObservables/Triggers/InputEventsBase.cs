using UniRx;
using UniRx.Triggers;

namespace SteamVRInputObservables
{
    public abstract class InputEventsBase : ObservableTriggerBase
    {
        protected SteamVR_Controller.Device Device;

        protected abstract ulong ButtonMask { get; }

        private Subject<Unit> _onTouchDown;
        private Subject<Unit> _onTouchUp;
        private Subject<Unit> _onPressDown;
        private Subject<Unit> _onPressUp;
        private ReactiveProperty<bool> _onPress;
        private ReactiveProperty<bool> _onTouch;

        public IObservable<Unit> OnTouchDown
        {
            get { return _onTouchDown ?? (_onTouchDown = new Subject<Unit>()); }
        }

        public IObservable<Unit> OnTouchUp
        {
            get { return _onTouchUp ?? (_onTouchUp = new Subject<Unit>()); }
        }

        public IObservable<Unit> OnPressDown
        {
            get { return _onPressDown ?? (_onPressDown = new Subject<Unit>()); }
        }

        public IObservable<Unit> OnPressUp
        {
            get { return _onPressUp ?? (_onPressUp = new Subject<Unit>()); }
        }

        public IReadOnlyReactiveProperty<bool> OnPress
        {
            get { return _onPress ?? (_onPress = new BoolReactiveProperty(false)); }
        }

        public IReadOnlyReactiveProperty<bool> OnTouch
        {
            get { return _onTouch ?? (_onTouch = new BoolReactiveProperty(false)); }
        }

        void Start()
        {
            var trackedObject = GetComponent<SteamVR_TrackedObject>();
            Device = SteamVR_Controller.Input((int)trackedObject.index);
        }

        protected void Update()
        {
            if (_onPress != null)
            {
                _onPress.Value = Device.GetPress(ButtonMask);
            }
            if (_onTouch != null && Device.GetTouch(ButtonMask))
            {
                _onTouch.Value = Device.GetTouch(ButtonMask);
            }


            if (_onTouchDown != null && Device.GetTouchDown(ButtonMask))
            {
                _onTouchDown.OnNext(Unit.Default);
            }

            if (_onTouchUp != null && Device.GetTouchDown(ButtonMask))
            {
                _onTouchUp.OnNext(Unit.Default);
            }

            if (_onPressDown != null && Device.GetPressDown(ButtonMask))
            {
                _onPressDown.OnNext(Unit.Default);
            }

            if (_onPressUp != null && Device.GetPressUp(ButtonMask))
            {
                _onPressUp.OnNext(Unit.Default);
            }

        }

        protected override void RaiseOnCompletedOnDestroy()
        {
            if (_onTouchDown != null) _onTouchDown.OnCompleted();
            if (_onTouchUp != null) _onTouchUp.OnCompleted();
            if (_onPressUp != null) _onPressUp.OnCompleted();
            if (_onPressDown != null) _onPressDown.OnCompleted();
            if (_onPress != null) _onPress.Dispose();
            if (_onTouch != null) _onTouch.Dispose();
        }


    }
}

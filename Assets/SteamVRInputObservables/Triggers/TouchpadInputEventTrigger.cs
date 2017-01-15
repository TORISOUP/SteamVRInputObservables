using UniRx;
using UnityEngine;

namespace SteamVRInputObservables
{
    public class TouchpadInputEventTrigger : InputEventsBase
    {
        protected override ulong ButtonMask
        {
            get { return SteamVR_Controller.ButtonMask.Touchpad; }
        }

        private ReactiveProperty<Vector2> _axis;

        public IReactiveProperty<Vector2> Axis
        {
            get
            {
                if (_axis != null) return _axis;
                var defaultValue = Device != null ? Device.GetAxis() : Vector2.zero;
                return _axis = new ReactiveProperty<Vector2>(defaultValue);
            }
        }


        new void Update()
        {
            base.Update();
            if (Device != null)
            {
                _axis.Value = Device.GetAxis();
            }
        }
    }
}

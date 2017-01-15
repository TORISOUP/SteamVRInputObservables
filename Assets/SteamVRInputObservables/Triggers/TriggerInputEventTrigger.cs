using UniRx;

namespace SteamVRInputObservables
{
    public class TriggerInputEventTrigger : InputEventsBase
    {

        protected override ulong ButtonMask
        {
            get { return SteamVR_Controller.ButtonMask.Trigger; }
        }

        private ReactiveProperty<float> _axisX;

        public IReactiveProperty<float> AxisX
        {
            get
            {
                if (_axisX != null) return _axisX;
                var defaultValue = Device != null ? Device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x : 0;
                return _axisX = new FloatReactiveProperty(defaultValue);
            }
        }

        new void Update()
        {
            base.Update();
            if (_axisX != null)
            {
                _axisX.Value = Device.GetAxis(Valve.VR.EVRButtonId.k_EButton_SteamVR_Trigger).x;
            }
        }
    }
}

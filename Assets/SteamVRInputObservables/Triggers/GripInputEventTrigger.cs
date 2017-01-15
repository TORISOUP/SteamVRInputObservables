namespace SteamVRInputObservables
{
    public class GripInputEventTrigger : InputEventsBase
    {
        protected override ulong ButtonMask
        {
            get { return SteamVR_Controller.ButtonMask.Grip; }
        }
    }
}


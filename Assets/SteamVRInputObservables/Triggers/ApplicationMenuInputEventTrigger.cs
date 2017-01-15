namespace SteamVRInputObservables
{
    public class ApplicationMenuInputEventTrigger : InputEventsBase
    {
        protected override ulong ButtonMask
        {
            get { return SteamVR_Controller.ButtonMask.ApplicationMenu; }
        }
    }
}

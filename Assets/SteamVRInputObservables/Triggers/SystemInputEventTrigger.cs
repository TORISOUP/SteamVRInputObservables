namespace SteamVRInputObservables
{
    public class SystemInputEventTrigger : InputEventsBase
    {
        protected override ulong ButtonMask
        {
            get { return SteamVR_Controller.ButtonMask.System; }
        }
    }
}

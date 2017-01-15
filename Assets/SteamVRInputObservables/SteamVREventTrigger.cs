using UniRx;
using UnityEngine;

namespace SteamVRInputObservables
{
    public class SteamVREventTrigger : MonoBehaviour
    {
        public static SteamVREventTrigger Instance;

        private void Awake()
        {
            if (Instance == null)
            {
                Instance = this;
                return;
            }
            else if (Instance == this)
            {
                return;
            }

            Destroy(this);
        }

        [SerializeField]
        private GameObject _leftController;
        [SerializeField]
        private GameObject _rightController;

        public GameObject LeftController
        {
            get { return _leftController ?? (_leftController = GameObject.Find("Controller (left)")); }
        }

        public GameObject RightController
        {
            get { return _rightController ?? (_rightController = GameObject.Find("Controller (right)")); }
        }
    }
}

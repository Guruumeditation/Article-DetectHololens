using Windows.System.Profile;
using Windows.UI.Xaml;

namespace DetectHololens
{
    public class HololensStateTrigger : StateTriggerBase
    {
        private bool _needHololens;

        public bool NeedHololens
        {
            get { return _needHololens; }
            set
            {
                _needHololens = value;

                if (AnalyticsInfo.VersionInfo.DeviceFamily == "Windows.Holographic")
                {
                    SetActive(value);
                }
                else
                {
                    SetActive(!value);
                }
            }
        }
    }
}

using System.Collections.Generic;
using UnityEngine;

namespace Kaynir.Localization.Localizers
{
    public abstract class Localizer : MonoBehaviour
    {
        public void SetLanguage(SystemLanguage language)
        {
            LocalizationSystem.SetLanguage(this, language);
        }

        public abstract Dictionary<string, string> GetLocalization(string language);
    }
}
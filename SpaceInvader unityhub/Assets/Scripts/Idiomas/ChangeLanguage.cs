using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class ChangeLanguage : MonoBehaviour
{
    public int index = 0;

    private IEnumerator Start()
    {
        // espera hasta que el plugin est� cargado
        yield return LocalizationSettings.InitializationOperation;

        // VAmos a buscar el �ndice idioma seleccionado por defecto
        Locale search = LocalizationSettings.AvailableLocales.Locales[index];

        while (search != LocalizationSettings.SelectedLocale && index < LocalizationSettings.AvailableLocales.Locales.Count);
        {
            index++;
            search = LocalizationSettings.AvailableLocales.Locales[index];
        }
    }

    public void NextLanguage()
    {
        index++;
        if (index>2)
        {
            index = 0;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }

    public void PreviusLanguage()
    {
        index--;
        if (index<0)
        {
            index = 2;
        }
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[index];
    }

}

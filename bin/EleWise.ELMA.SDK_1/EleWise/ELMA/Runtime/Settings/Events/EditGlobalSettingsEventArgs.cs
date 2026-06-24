// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.Events.EditGlobalSettingsEventArgs
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System.Reflection;

namespace EleWise.ELMA.Runtime.Settings.Events
{
  /// <summary>
  /// Событие аудита, возникающее при изменении глобальной настройки
  /// </summary>
  public class EditGlobalSettingsEventArgs : GlobalSettingsEventArgs
  {
    protected string newValue;
    private IStoreValuesObject store;
    internal static EditGlobalSettingsEventArgs rA3VK3WGp91bxPG1WI80;

    public EditGlobalSettingsEventArgs(
      PropertyInfo property,
      IStoreValuesObject store,
      string newValue)
    {
      EditGlobalSettingsEventArgs.MkawV7WGtVnyatYW37jI();
      // ISSUE: explicit constructor call
      base.\u002Ector(property);
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.store = store;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            this.newValue = newValue;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    public string NewValue => this.newValue;

    public IStoreValuesObject Store => this.store;

    internal static void MkawV7WGtVnyatYW37jI() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rvYimYWGaIloF2T96Vjb() => EditGlobalSettingsEventArgs.rA3VK3WGp91bxPG1WI80 == null;

    internal static EditGlobalSettingsEventArgs tRflJWWGD0DIueMrAxH8() => EditGlobalSettingsEventArgs.rA3VK3WGp91bxPG1WI80;
  }
}

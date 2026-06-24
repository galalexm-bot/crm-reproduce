// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Settings.ExternalMembershipSettingsHolder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security.Settings
{
  /// <summary>
  /// Класс для хранения списка сериализованных настроек экземпляров точек работы с учетными записями пользователей
  /// </summary>
  [Serializable]
  public class ExternalMembershipSettingsHolder : List<ExternalMembershipSettingsHolderItem>
  {
    private static ExternalMembershipSettingsHolder PdOaJMBYdJuddtFDAKU2;

    /// <summary>Преобразование словаря настроек в список настроек</summary>
    public static ExternalMembershipSettingsHolder DictionaryToHolder(
      IDictionary<string, string> dict)
    {
      ExternalMembershipSettingsHolder holder = new ExternalMembershipSettingsHolder();
      dict.ForEach<KeyValuePair<string, string>>((Action<KeyValuePair<string, string>>) (p => holder.Add(new ExternalMembershipSettingsHolderItem()
      {
        Key = p.Key,
        Value = p.Value
      })));
      return holder;
    }

    /// <summary>Преобразование списка настроек в словарь настроек</summary>
    public static IDictionary<string, string> HolderToDictionary(
      ExternalMembershipSettingsHolder holder)
    {
      Dictionary<string, string> dict = new Dictionary<string, string>();
      holder.ForEach((Action<ExternalMembershipSettingsHolderItem>) (p =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              if (dict.ContainsKey(p.Key))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              dict.Add((string) ExternalMembershipSettingsHolder.\u003C\u003Ec__DisplayClass1_0.AQoWmFQPPLFIlmbk1E7m((object) p), (string) ExternalMembershipSettingsHolder.\u003C\u003Ec__DisplayClass1_0.qKuwClQP1XJBJgRnFBJg((object) p));
              num = 3;
              continue;
            case 3:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_4:
        return;
label_2:
        return;
label_7:;
      }));
      return (IDictionary<string, string>) dict;
    }

    public ExternalMembershipSettingsHolder()
    {
      ExternalMembershipSettingsHolder.JE2G1YBYgXe8iePMaUba();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void JE2G1YBYgXe8iePMaUba() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool FlmHyMBYlPjtsEjWfQ34() => ExternalMembershipSettingsHolder.PdOaJMBYdJuddtFDAKU2 == null;

    internal static ExternalMembershipSettingsHolder Y4Y4c4BYrg3dS2QxwEmL() => ExternalMembershipSettingsHolder.PdOaJMBYdJuddtFDAKU2;
  }
}

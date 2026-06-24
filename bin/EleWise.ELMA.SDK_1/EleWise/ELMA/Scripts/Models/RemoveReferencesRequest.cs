// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.RemoveReferencesRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>Запрос удаления ссылок</summary>
  public sealed class RemoveReferencesRequest
  {
    internal static RemoveReferencesRequest setwQjWBN0mpDs2oB0vx;

    /// <summary>Имя файла с кодом</summary>
    public string FileName
    {
      get => this.\u003CFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Имя проекта</summary>
    public string ProjectFileName
    {
      get => this.\u003CProjectFileName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CProjectFileName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Имена глобальных сборок</summary>
    public string[] AssemblyNames
    {
      get => this.\u003CAssemblyNames\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CAssemblyNames\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Идентификаторы глобальных модулей</summary>
    public Guid[] GlobalModulesUids
    {
      get => this.\u003CGlobalModulesUids\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CGlobalModulesUids\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Имена ссылок на веб-сервисы</summary>
    public string[] WebReferencesNames
    {
      get => this.\u003CWebReferencesNames\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CWebReferencesNames\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public RemoveReferencesRequest()
    {
      RemoveReferencesRequest.IKMXfdWBagRexlHghf1M();
      // ISSUE: reference to a compiler-generated field
      this.\u003CAssemblyNames\u003Ek__BackingField = new string[0];
      // ISSUE: reference to a compiler-generated field
      this.\u003CGlobalModulesUids\u003Ek__BackingField = new Guid[0];
      // ISSUE: reference to a compiler-generated field
      this.\u003CWebReferencesNames\u003Ek__BackingField = new string[0];
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qAxWoPWB3vF1n8eiI9Un() => RemoveReferencesRequest.setwQjWBN0mpDs2oB0vx == null;

    internal static RemoveReferencesRequest NNJw8TWBpHVB4AjgBXab() => RemoveReferencesRequest.setwQjWBN0mpDs2oB0vx;

    internal static void IKMXfdWBagRexlHghf1M() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

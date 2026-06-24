// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scripts.Models.AddReferencesRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Scripts.Models
{
  /// <summary>Запрос добавления ссылок</summary>
  public sealed class AddReferencesRequest
  {
    internal static AddReferencesRequest pqq0mJWBxOP58SMyBgh1;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 0 : 0;
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

    /// <summary>
    /// Информация о веб-сервисах (Имя ссылки на веб-сервис, путь до файла с кодом сервиса)
    /// </summary>
    public WebReferenceInfo[] WebReferences
    {
      get => this.\u003CWebReferences\u003Ek__BackingField;
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
              this.\u003CWebReferences\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    public AddReferencesRequest()
    {
      AddReferencesRequest.Ve0ScVWBy4YUWVeeAZTQ();
      // ISSUE: reference to a compiler-generated field
      this.\u003CAssemblyNames\u003Ek__BackingField = new string[0];
      // ISSUE: reference to a compiler-generated field
      this.\u003CGlobalModulesUids\u003Ek__BackingField = new Guid[0];
      // ISSUE: reference to a compiler-generated field
      this.\u003CWebReferences\u003Ek__BackingField = new WebReferenceInfo[0];
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool r0tIFVWB0OUSLMv2ySOw() => AddReferencesRequest.pqq0mJWBxOP58SMyBgh1 == null;

    internal static AddReferencesRequest AxLFpmWBml1cnhoLTcQj() => AddReferencesRequest.pqq0mJWBxOP58SMyBgh1;

    internal static void Ve0ScVWBy4YUWVeeAZTQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

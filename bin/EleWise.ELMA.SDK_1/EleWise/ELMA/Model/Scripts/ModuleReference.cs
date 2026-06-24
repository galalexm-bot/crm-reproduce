// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ModuleReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Ссылка метаданных на модуль</summary>
  [ClassMap(typeof (ModuleReferenceNHMap))]
  internal class ModuleReference
  {
    internal static ModuleReference sxgngibVpxdpJoGw0bJs;

    /// <summary>Уникальный идентификатор метаданных</summary>
    public virtual Guid MetadataUid
    {
      get => this.\u003CMetadataUid\u003Ek__BackingField;
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
              this.\u003CMetadataUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    /// <summary>Ссылка на модуль</summary>
    public virtual Guid ModuleUid
    {
      get => this.\u003CModuleUid\u003Ek__BackingField;
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
              this.\u003CModuleUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
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

    public ModuleReference()
    {
      ModuleReference.DLX2UIbVtI6ofExIv4Ys();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QeipPFbVa1kUS3Doilmf() => ModuleReference.sxgngibVpxdpJoGw0bJs == null;

    internal static ModuleReference hxWdTkbVDBWHAHQ84r7k() => ModuleReference.sxgngibVpxdpJoGw0bJs;

    internal static void DLX2UIbVtI6ofExIv4Ys() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Статичный класс для формирования таблицы</summary>
    public static class Tables
    {
      /// <summary>Имя таблицы</summary>
      public const string TableName = "ModuleReference";

      /// <summary>Колонки</summary>
      public static class Columns
      {
        /// <summary>Имя колонки "Уникальный идентификатор метаданных"</summary>
        public const string MetadataUid = "MetadataUid";
        /// <summary>Имя колонки "Ссылка на модуль"</summary>
        public const string ModuleUid = "ModuleUid";
      }
    }
  }
}

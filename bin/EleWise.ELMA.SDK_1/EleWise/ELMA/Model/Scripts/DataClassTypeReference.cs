// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DataClassTypeReference
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Ссылка типа DTO на метаданные</summary>
  [ClassMap(typeof (DataClassTypeReferenceNHMap))]
  internal class DataClassTypeReference
  {
    internal static DataClassTypeReference cKKgrCbI8q1Ler7igc1K;

    /// <summary>Уникальный идентификатор записи</summary>
    public virtual long Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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
    /// Уникальный идентификатор сущности, в которой находится тип DTO
    /// </summary>
    public virtual Guid ItemUid
    {
      get => this.\u003CItemUid\u003Ek__BackingField;
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
              this.\u003CItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    public DataClassTypeReference()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Cxo0lFbIZ36x2khYURL3() => DataClassTypeReference.cKKgrCbI8q1Ler7igc1K == null;

    internal static DataClassTypeReference BNyES1bIuyVVdijsTHbg() => DataClassTypeReference.cKKgrCbI8q1Ler7igc1K;

    /// <summary>Статичный класс для формирования таблицы</summary>
    public static class Tables
    {
      /// <summary>Имя таблицы</summary>
      public const string TableName = "DataClassTypeReference";

      /// <summary>Колонки</summary>
      public static class Columns
      {
        /// <summary>Имя колонки "Уникальный идентификатор записи"</summary>
        public const string Id = "Id";
        /// <summary>Имя колонки "Уникальный идентификатор метаданных"</summary>
        public const string MetadataUid = "MetadataUid";
        /// <summary>
        /// Имя колонки "Уникальный идентификатор сущности, в которой находится тип DTO"
        /// </summary>
        public const string ItemUid = "ItemUid";
      }
    }
  }
}

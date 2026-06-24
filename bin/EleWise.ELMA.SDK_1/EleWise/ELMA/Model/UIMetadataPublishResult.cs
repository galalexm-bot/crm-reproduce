// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.UIMetadataPublishResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Model
{
  /// <summary>Результат публикации метаданных</summary>
  [Serializable]
  public sealed class UIMetadataPublishResult
  {
    internal static UIMetadataPublishResult hYpqgkW5QYUQbONOvltA;

    /// <summary>Ctor</summary>
    public UIMetadataPublishResult()
    {
      UIMetadataPublishResult.DrBWgTW58l4DsOVZf7yA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Errors = new List<ValidationError>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Список ошибок</summary>
    public List<ValidationError> Errors { get; }

    /// <summary>Уникальный идентификатор опубликованного элемента</summary>
    public Guid ItemUid
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
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

    internal static void DrBWgTW58l4DsOVZf7yA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GZe1M3W5CglvS8wW1WG2() => UIMetadataPublishResult.hYpqgkW5QYUQbONOvltA == null;

    internal static UIMetadataPublishResult McEMQPW5v74A6r0DQgCT() => UIMetadataPublishResult.hYpqgkW5QYUQbONOvltA;
  }
}

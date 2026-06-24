// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Publication.PublishDataResult
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities.EntityReferences;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.Publication
{
  /// <summary>Результат публикации группы данных</summary>
  public sealed class PublishDataResult
  {
    internal static PublishDataResult UDJX17oVXC8yhpQEv0eb;

    /// <summary>Список опубликованных данных</summary>
    public IList<ReferenceOnEntity> PublishedData { get; }

    /// <summary>Сообщения с ошибками</summary>
    public IList<string> ErrorMessages { get; }

    /// <summary>Успешно</summary>
    public bool IsSuccess
    {
      get => this.\u003CIsSuccess\u003Ek__BackingField;
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
              this.\u003CIsSuccess\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>Нужен перезапуск сервера после публикации</summary>
    public bool NeedRestart
    {
      get => this.\u003CNeedRestart\u003Ek__BackingField;
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
              this.\u003CNeedRestart\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    /// <param name="publishData">Список данных для публикации</param>
    /// <param name="errorMessages">Список сообщений с ошибками</param>
    public PublishDataResult(IList<ReferenceOnEntity> publishData = null, IList<string> errorMessages = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.PublishedData = publishData != null ? publishData : (IList<ReferenceOnEntity>) new List<ReferenceOnEntity>();
      this.ErrorMessages = errorMessages != null ? errorMessages : (IList<string>) new List<string>();
    }

    internal static bool GHkeBKoVT85TrGqX1593() => PublishDataResult.UDJX17oVXC8yhpQEv0eb == null;

    internal static PublishDataResult vqKav6oVk6eIof3uk5uZ() => PublishDataResult.UDJX17oVXC8yhpQEv0eb;
  }
}

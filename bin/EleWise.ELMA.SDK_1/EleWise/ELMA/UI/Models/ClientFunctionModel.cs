// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ClientFunctionModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Клиентская модель функции</summary>
  [DataContract]
  public sealed class ClientFunctionModel : ICloneable
  {
    private static ClientFunctionModel Atu4evBWZn6ayny0cbv2;

    /// <summary>
    /// Уникальный идентификатор заголовка элемента метаданных
    /// </summary>
    [DataMember]
    public Guid HeaderUid
    {
      get => this.\u003CHeaderUid\u003Ek__BackingField;
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
              this.\u003CHeaderUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента метаданных</summary>
    [DataMember]
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор модуля</summary>
    [DataMember]
    public Guid ModuleItemUid
    {
      get => this.\u003CModuleItemUid\u003Ek__BackingField;
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
              this.\u003CModuleItemUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор метаданных модуля компонента</summary>
    [DataMember]
    public Guid ModuleUid
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

    /// <inheritdoc />
    public object Clone()
    {
      ClientFunctionModel clientFunctionModel = new ClientFunctionModel();
      ClientFunctionModel.ydwOkrBWVsRWut2FYXjM((object) clientFunctionModel, this.HeaderUid);
      ClientFunctionModel.NCRWpQBWSsRN87MUey48((object) clientFunctionModel, this.ItemUid);
      ClientFunctionModel.P77SZTBWiU1txBBMZ0B5((object) clientFunctionModel, this.ModuleItemUid);
      ClientFunctionModel.bOiOlYBWRAOuwVIH3xja((object) clientFunctionModel, this.ModuleUid);
      return (object) clientFunctionModel;
    }

    public ClientFunctionModel()
    {
      ClientFunctionModel.ToFc8lBWq6NSBNfDUQNu();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool xCHg7UBWucx5mpThpZeD() => ClientFunctionModel.Atu4evBWZn6ayny0cbv2 == null;

    internal static ClientFunctionModel XFOGLTBWIUHud01cMCFh() => ClientFunctionModel.Atu4evBWZn6ayny0cbv2;

    internal static void ydwOkrBWVsRWut2FYXjM([In] object obj0, Guid value) => ((ClientFunctionModel) obj0).HeaderUid = value;

    internal static void NCRWpQBWSsRN87MUey48([In] object obj0, Guid value) => ((ClientFunctionModel) obj0).ItemUid = value;

    internal static void P77SZTBWiU1txBBMZ0B5([In] object obj0, Guid value) => ((ClientFunctionModel) obj0).ModuleItemUid = value;

    internal static void bOiOlYBWRAOuwVIH3xja([In] object obj0, Guid value) => ((ClientFunctionModel) obj0).ModuleUid = value;

    internal static void ToFc8lBWq6NSBNfDUQNu() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

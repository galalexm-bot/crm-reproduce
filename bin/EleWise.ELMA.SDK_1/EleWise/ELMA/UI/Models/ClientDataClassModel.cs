// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ClientDataClassModel
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
  /// <summary>Клиентская модель структуры обмена данными</summary>
  [DataContract]
  public sealed class ClientDataClassModel : ICloneable
  {
    internal static ClientDataClassModel UucY2lBWG92G7Eg98wg2;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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
      ClientDataClassModel clientDataClassModel = new ClientDataClassModel();
      ClientDataClassModel.BDP8HiBWQHLTH1H42eNv((object) clientDataClassModel, this.HeaderUid);
      ClientDataClassModel.pCJBnJBWCNw6AMdYrPeK((object) clientDataClassModel, this.ItemUid);
      ClientDataClassModel.dwP972BWvIROS0UhNdp6((object) clientDataClassModel, this.ModuleItemUid);
      return (object) clientDataClassModel;
    }

    public ClientDataClassModel()
    {
      ClientDataClassModel.d02XJaBW8HStBwrn9Ku8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool iMm41sBWE34fGgKMnDfv() => ClientDataClassModel.UucY2lBWG92G7Eg98wg2 == null;

    internal static ClientDataClassModel hmKZNmBWfeP2ipcOC1kf() => ClientDataClassModel.UucY2lBWG92G7Eg98wg2;

    internal static void BDP8HiBWQHLTH1H42eNv([In] object obj0, Guid value) => ((ClientDataClassModel) obj0).HeaderUid = value;

    internal static void pCJBnJBWCNw6AMdYrPeK([In] object obj0, Guid value) => ((ClientDataClassModel) obj0).ItemUid = value;

    internal static void dwP972BWvIROS0UhNdp6([In] object obj0, Guid value) => ((ClientDataClassModel) obj0).ModuleItemUid = value;

    internal static void d02XJaBW8HStBwrn9Ku8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

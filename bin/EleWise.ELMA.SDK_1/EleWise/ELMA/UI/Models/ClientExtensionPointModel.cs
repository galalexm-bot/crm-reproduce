// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ClientExtensionPointModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Модель точки расширения</summary>
  [DataContract]
  public sealed class ClientExtensionPointModel : ICloneable
  {
    internal static ClientExtensionPointModel P52H5WBBt1oM4T1IDHN2;

    /// <summary>Ctor</summary>
    public ClientExtensionPointModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Implementations = new List<ClientImplementationModel>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Идентификатор зоны расширений</summary>
    [DataMember]
    public string PointId
    {
      get => this.\u003CPointId\u003Ek__BackingField;
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
              this.\u003CPointId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
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

    /// <summary>Тип контракта</summary>
    [DataMember]
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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

    /// <summary>Список компонентов</summary>
    [DataMember]
    public List<ClientImplementationModel> Implementations { get; set; }

    /// <inheritdoc />
    public object Clone()
    {
      ClientExtensionPointModel extensionPointModel = new ClientExtensionPointModel();
      ClientExtensionPointModel.LADHRuBB6Z1ZGYf7Lh2p((object) extensionPointModel, (object) this.PointId);
      ClientExtensionPointModel.DiNY4oBBHwKm2fIRvNSp((object) extensionPointModel, this.TypeUid);
      // ISSUE: reference to a compiler-generated method
      extensionPointModel.Implementations.AddRange(this.Implementations.Select<ClientImplementationModel, ClientImplementationModel>((Func<ClientImplementationModel, ClientImplementationModel>) (i => (ClientImplementationModel) ClientExtensionPointModel.\u003C\u003Ec.eicn2qQW63nZeDlcigtd((object) i))));
      return (object) extensionPointModel;
    }

    internal static bool p6HPoyBBwx5elGneXrOM() => ClientExtensionPointModel.P52H5WBBt1oM4T1IDHN2 == null;

    internal static ClientExtensionPointModel scXsESBB4pSqu8T6jjjH() => ClientExtensionPointModel.P52H5WBBt1oM4T1IDHN2;

    internal static void LADHRuBB6Z1ZGYf7Lh2p([In] object obj0, [In] object obj1) => ((ClientExtensionPointModel) obj0).PointId = (string) obj1;

    internal static void DiNY4oBBHwKm2fIRvNSp([In] object obj0, Guid value) => ((ClientExtensionPointModel) obj0).TypeUid = value;
  }
}

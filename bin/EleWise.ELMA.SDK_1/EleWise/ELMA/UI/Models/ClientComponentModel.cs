// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ClientComponentModel
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
  /// <summary>Клиентская модель компонента</summary>
  [DataContract]
  public sealed class ClientComponentModel : ICloneable
  {
    internal static ClientComponentModel WbUDGsBWF4VrFD1lD3Xq;

    /// <summary>Ctor</summary>
    public ClientComponentModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.RenderUidList = new HashSet<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
            continue;
          case 3:
            this.Owners = new HashSet<Guid>();
            num = 2;
            continue;
          case 4:
            this.DataClasses = new List<ClientDataClassModel>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
            continue;
          default:
            this.Functions = new List<ClientFunctionModel>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 1 : 4;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор элемента компонента</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор элемента модуля</summary>
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

    /// <summary>Является асинхронным</summary>
    [DataMember]
    public bool Async
    {
      get => this.\u003CAsync\u003Ek__BackingField;
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
              this.\u003CAsync\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
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

    /// <summary>Список уидов обладателей</summary>
    [DataMember]
    public HashSet<Guid> Owners { get; set; }

    /// <summary>Список уидов для рендера</summary>
    /// <remarks>Заполняется только в конфигурации</remarks>
    [DataMember]
    public HashSet<string> RenderUidList { get; set; }

    /// <summary>Функции</summary>
    [DataMember]
    public List<ClientFunctionModel> Functions { get; set; }

    /// <summary>Структуры обмена данными</summary>
    [DataMember]
    public List<ClientDataClassModel> DataClasses { get; set; }

    /// <inheritdoc />
    public object Clone()
    {
      ClientComponentModel clientComponentModel = new ClientComponentModel();
      clientComponentModel.Async = this.Async;
      ClientComponentModel.JN5pFwBWojh2BbFM2pwj((object) clientComponentModel, this.ItemUid);
      ClientComponentModel.S5H7kEBWbHGAODHbWao5((object) clientComponentModel, this.ModuleUid);
      ClientComponentModel.msZersBWhpptaVGdG0kK((object) clientComponentModel, this.ModuleItemUid);
      // ISSUE: reference to a compiler-generated method
      clientComponentModel.Functions.AddRange(this.Functions.Select<ClientFunctionModel, ClientFunctionModel>((Func<ClientFunctionModel, ClientFunctionModel>) (f => (ClientFunctionModel) ClientComponentModel.\u003C\u003Ec.TgZdsdQW0KvhpSZ26hc0((object) f))));
      // ISSUE: reference to a compiler-generated method
      clientComponentModel.DataClasses.AddRange(this.DataClasses.Select<ClientDataClassModel, ClientDataClassModel>((Func<ClientDataClassModel, ClientDataClassModel>) (d => (ClientDataClassModel) ClientComponentModel.\u003C\u003Ec.Oxa8yxQWmcoFxC1aXg6b((object) d))));
      clientComponentModel.Owners.AddRange<Guid>((IEnumerable<Guid>) this.Owners);
      clientComponentModel.RenderUidList.AddRange<string>((IEnumerable<string>) this.RenderUidList);
      return (object) clientComponentModel;
    }

    internal static bool GAZFDtBWBSUZedo0kXB7() => ClientComponentModel.WbUDGsBWF4VrFD1lD3Xq == null;

    internal static ClientComponentModel qQLGTRBWWepYmik3sSPN() => ClientComponentModel.WbUDGsBWF4VrFD1lD3Xq;

    internal static void JN5pFwBWojh2BbFM2pwj([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ItemUid = value;

    internal static void S5H7kEBWbHGAODHbWao5([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ModuleUid = value;

    internal static void msZersBWhpptaVGdG0kK([In] object obj0, Guid value) => ((ClientComponentModel) obj0).ModuleItemUid = value;
  }
}

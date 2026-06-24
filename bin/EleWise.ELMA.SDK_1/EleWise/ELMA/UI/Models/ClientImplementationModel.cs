// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.ClientImplementationModel
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
  /// <summary>
  /// Модель заголовка компонента, имплементирующего расширение
  /// Компонент может быть или в конфигурации или в модуле
  /// </summary>
  [DataContract]
  public sealed class ClientImplementationModel : ICloneable
  {
    private static ClientImplementationModel ghR9w3BBAB9lvWmOE1cS;

    /// <summary>Идентификатор заголовка компонента</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор версии компонента из конфигурации</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
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

    /// <summary>Идентификатор версии модуля</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор модуля</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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
      ClientImplementationModel implementationModel = new ClientImplementationModel();
      ClientImplementationModel.zRtb4nBB08a3xh0k6JCR((object) implementationModel, this.HeaderUid);
      ClientImplementationModel.uSVJL9BBmIw9YVp816NC((object) implementationModel, this.ItemUid);
      ClientImplementationModel.wx2aRyBByqiNPY1vwCfF((object) implementationModel, this.ModuleUid);
      ClientImplementationModel.gN2bMwBBMYjyN7qu7QQl((object) implementationModel, this.ModuleItemUid);
      return (object) implementationModel;
    }

    public ClientImplementationModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool pffppPBB76aClWjJ4RHj() => ClientImplementationModel.ghR9w3BBAB9lvWmOE1cS == null;

    internal static ClientImplementationModel sLcpZcBBxqWrlhHyIQE9() => ClientImplementationModel.ghR9w3BBAB9lvWmOE1cS;

    internal static void zRtb4nBB08a3xh0k6JCR([In] object obj0, Guid value) => ((ClientImplementationModel) obj0).HeaderUid = value;

    internal static void uSVJL9BBmIw9YVp816NC([In] object obj0, Guid value) => ((ClientImplementationModel) obj0).ItemUid = value;

    internal static void wx2aRyBByqiNPY1vwCfF([In] object obj0, Guid value) => ((ClientImplementationModel) obj0).ModuleUid = value;

    internal static void gN2bMwBBMYjyN7qu7QQl([In] object obj0, Guid value) => ((ClientImplementationModel) obj0).ModuleItemUid = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.CustomTypeModel
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
  /// <summary>Модель пользовательского компонента типа</summary>
  [DataContract]
  public sealed class CustomTypeModel : ICloneable
  {
    internal static CustomTypeModel yZ8uVJBBruAil7IJqgiG;

    /// <summary>Идентификатор типа</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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

    /// <summary>Идентифкатор подтипа</summary>
    [DataMember]
    public Guid SubTypeUid
    {
      get => this.\u003CSubTypeUid\u003Ek__BackingField;
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
              this.\u003CSubTypeUid\u003Ek__BackingField = value;
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

    /// <summary>Является ли реализацией списка</summary>
    [DataMember]
    public bool IsCollection
    {
      get => this.\u003CIsCollection\u003Ek__BackingField;
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
              this.\u003CIsCollection\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
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
      CustomTypeModel customTypeModel = new CustomTypeModel();
      CustomTypeModel.KWa7iLBBjS5V9lDknPND((object) customTypeModel, this.HeaderUid);
      CustomTypeModel.zQsh6EBBY5CrtjOjU6xB((object) customTypeModel, this.IsCollection);
      CustomTypeModel.mDnTTgBBLeHt2qeFofsZ((object) customTypeModel, this.ItemUid);
      CustomTypeModel.Tg9OLLBBUnVpmihVToGD((object) customTypeModel, this.ItemUid);
      CustomTypeModel.BuJHCnBBsFZtgeDIyCcB((object) customTypeModel, this.TypeUid);
      CustomTypeModel.SHRFf0BBcnKBm7siqWLF((object) customTypeModel, this.ModuleItemUid);
      CustomTypeModel.ilMr9oBBz4yQCFfigYEx((object) customTypeModel, this.SubTypeUid);
      return (object) customTypeModel;
    }

    public CustomTypeModel()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool cX4ZBcBBgJIAWXGrIaJL() => CustomTypeModel.yZ8uVJBBruAil7IJqgiG == null;

    internal static CustomTypeModel qRaol0BB5HBjA2imAsfI() => CustomTypeModel.yZ8uVJBBruAil7IJqgiG;

    internal static void KWa7iLBBjS5V9lDknPND([In] object obj0, Guid value) => ((CustomTypeModel) obj0).HeaderUid = value;

    internal static void zQsh6EBBY5CrtjOjU6xB([In] object obj0, bool value) => ((CustomTypeModel) obj0).IsCollection = value;

    internal static void mDnTTgBBLeHt2qeFofsZ([In] object obj0, Guid value) => ((CustomTypeModel) obj0).ItemUid = value;

    internal static void Tg9OLLBBUnVpmihVToGD([In] object obj0, Guid value) => ((CustomTypeModel) obj0).ModuleUid = value;

    internal static void BuJHCnBBsFZtgeDIyCcB([In] object obj0, Guid value) => ((CustomTypeModel) obj0).TypeUid = value;

    internal static void SHRFf0BBcnKBm7siqWLF([In] object obj0, Guid value) => ((CustomTypeModel) obj0).ModuleItemUid = value;

    internal static void ilMr9oBBz4yQCFfigYEx([In] object obj0, Guid value) => ((CustomTypeModel) obj0).SubTypeUid = value;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Audit.EntityAuditAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Drawing;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events.Audit
{
  /// <summary>Действие с сущностью</summary>
  [Serializable]
  public class EntityAuditAction : IAuditAction
  {
    [NonSerialized]
    private Func<EntityAuditAction, EnumValueMetadata> localizedValueFunc;
    private MetadataImage image;
    internal static EntityAuditAction AZKNCCoB5NjReS0uMgNN;

    /// <summary>Ctor</summary>
    /// <param name="uid">Uid действия</param>
    /// <param name="name">Название действия</param>
    /// <param name="localizedValueFunc">Функция вычисления метаданных действия для текущей культуры</param>
    /// <param name="image">Изображение действия (16x16)</param>
    public EntityAuditAction(
      Guid uid,
      string name,
      Func<EntityAuditAction, EnumValueMetadata> localizedValueFunc,
      MetadataImage image = null)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Uid = uid;
      this.Name = name;
      this.localizedValueFunc = localizedValueFunc;
      this.image = image;
    }

    /// <summary>Uid действия</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
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

    /// <summary>Название действия</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
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
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
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

    /// <summary>Отображаемое название действия</summary>
    public string DisplayName
    {
      get
      {
        int num = 1;
        EnumValueMetadata enumValueMetadata1;
        while (true)
        {
          EnumValueMetadata enumValueMetadata2;
          switch (num)
          {
            case 1:
              if (this.localizedValueFunc == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
                continue;
              }
              enumValueMetadata2 = this.localizedValueFunc(this);
              break;
            case 2:
              goto label_2;
            case 3:
              if (enumValueMetadata1 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
                continue;
              }
              goto label_3;
            default:
              enumValueMetadata2 = (EnumValueMetadata) null;
              break;
          }
          enumValueMetadata1 = enumValueMetadata2;
          num = 3;
        }
label_2:
        return this.Name;
label_3:
        return enumValueMetadata1.DisplayName;
      }
    }

    /// <summary>Описание действия</summary>
    public string Description
    {
      get
      {
        int num = 5;
        EnumValueMetadata enumValueMetadata1;
        while (true)
        {
          EnumValueMetadata enumValueMetadata2;
          switch (num)
          {
            case 1:
              if (enumValueMetadata1 != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 1 : 2;
                continue;
              }
              goto label_7;
            case 2:
              goto label_8;
            case 3:
              goto label_7;
            case 4:
              enumValueMetadata2 = this.localizedValueFunc(this);
              break;
            case 5:
              if (this.localizedValueFunc != null)
              {
                num = 4;
                continue;
              }
              goto default;
            default:
              enumValueMetadata2 = (EnumValueMetadata) null;
              break;
          }
          enumValueMetadata1 = enumValueMetadata2;
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
        }
label_7:
        return (string) null;
label_8:
        return (string) EntityAuditAction.MZ7FtBoBLDCfLFcT5iFX((object) enumValueMetadata1);
      }
    }

    /// <summary>Изображение действия (16x16)</summary>
    public Image Image
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.image != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return (Image) null;
label_3:
        return (Image) EntityAuditAction.Rcrw97oBUafcstlWexOH((object) this.image);
      }
    }

    /// <summary>Метаданные изображение действия</summary>
    public MetadataImage MetadataImage => this.image;

    internal static bool ic2EbnoBjMFBwLEWsPcB() => EntityAuditAction.AZKNCCoB5NjReS0uMgNN == null;

    internal static EntityAuditAction S1Nm2foBYioHCuTYaqGO() => EntityAuditAction.AZKNCCoB5NjReS0uMgNN;

    internal static object MZ7FtBoBLDCfLFcT5iFX([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static object Rcrw97oBUafcstlWexOH([In] object obj0) => (object) ((MetadataImage) obj0).CreateImage();
  }
}

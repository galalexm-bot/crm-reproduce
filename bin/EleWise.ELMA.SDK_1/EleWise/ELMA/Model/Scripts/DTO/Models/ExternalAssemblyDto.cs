// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Models.ExternalAssemblyDto
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.DTO.Models
{
  [Serializable]
  public class ExternalAssemblyDto : EntityDTO<long>, IMetadata, IXsiType
  {
    internal static ExternalAssemblyDto MHKo1EbqleIAekQIeXPB;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
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

    public void InitNew()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Uid = ExternalAssemblyDto.KPqR8Ubq5XbBhK6mOrTw();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public void AfterLoad()
    {
    }

    /// <summary>
    /// Идентификатор модуля, к которому принадлежат метаданные
    /// </summary>
    public virtual Guid ModuleUid
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
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

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeModuleUid() => ExternalAssemblyDto.jyUpNEbqY8Cmtr1iY7KU(ExternalAssemblyDto.nKRCwdbqjLCnNED1s3wb((object) this), Guid.Empty);

    /// <summary>Внутренние метаданные модуля</summary>
    [DefaultValue(false)]
    public virtual bool Internal
    {
      get => this.\u003CInternal\u003Ek__BackingField;
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
              this.\u003CInternal\u003Ek__BackingField = value;
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

    /// <summary>Имя сборки</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>Содержимое сборки</summary>
    public byte[] Raw
    {
      get => this.\u003CRaw\u003Ek__BackingField;
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
              this.\u003CRaw\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
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

    /// <summary>Хэш код</summary>
    public string HashCode
    {
      get => this.\u003CHashCode\u003Ek__BackingField;
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
              this.\u003CHashCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
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

    /// <summary>Создать новую внешнюю сборку</summary>
    /// <returns>Новая внешняя ссылка</returns>
    public static ExternalAssemblyDto New()
    {
      ExternalAssemblyDto externalAssemblyDto = new ExternalAssemblyDto();
      externalAssemblyDto.InitNew();
      return externalAssemblyDto;
    }

    public ExternalAssemblyDto()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool mVBVUFbqr99g94xwGLVI() => ExternalAssemblyDto.MHKo1EbqleIAekQIeXPB == null;

    internal static ExternalAssemblyDto sS28tSbqgBj9tXERUhLV() => ExternalAssemblyDto.MHKo1EbqleIAekQIeXPB;

    internal static Guid KPqR8Ubq5XbBhK6mOrTw() => Guid.NewGuid();

    internal static Guid nKRCwdbqjLCnNED1s3wb([In] object obj0) => ((ExternalAssemblyDto) obj0).ModuleUid;

    internal static bool jyUpNEbqY8Cmtr1iY7KU([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;
  }
}

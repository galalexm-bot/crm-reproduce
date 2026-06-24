// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DTO.Models.GlobalScriptModuleDto
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
  public class GlobalScriptModuleDto : EntityDTO<long>, IMetadata, IXsiType
  {
    internal static GlobalScriptModuleDto d2YC8gbqLShx0E1KIGWV;

    public GlobalScriptModuleDto()
    {
      GlobalScriptModuleDto.do2rPJbqcrjFX5O6Y4lv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Header = new GlobalScriptModuleHeaderDto();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор типа сообщения</summary>
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
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
    public bool ShouldSerializeModuleUid() => GlobalScriptModuleDto.nnDkUDbqzrLQhAh85aJ8((object) this) != Guid.Empty;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Модуль сценариев</summary>
    public ScriptModuleDTO ScriptModule
    {
      get => this.\u003CScriptModule\u003Ek__BackingField;
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
              this.\u003CScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    /// <summary>Информация о проекте глобального модуля сценариев</summary>
    public ProjectInfo Project
    {
      get => this.\u003CProject\u003Ek__BackingField;
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
              this.\u003CProject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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

    /// <summary>Заголовок</summary>
    public GlobalScriptModuleHeaderDto Header
    {
      get => this.\u003CHeader\u003Ek__BackingField;
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
              this.\u003CHeader\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
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
          case 1:
            this.Uid = Guid.NewGuid();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ScriptModuleDTO scriptModuleDto = new ScriptModuleDTO();
            GlobalScriptModuleDto.N6EbZubKBTlfOKAss9sd((object) scriptModuleDto, GlobalScriptModuleDto.PTjxd0bKF01dfcdNwopY());
            GlobalScriptModuleDto.pi1EpdbKWQgvVq0h9wQJ((object) scriptModuleDto, GlobalScriptModuleType.UID);
            this.ScriptModule = scriptModuleDto;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    public void AfterLoad()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.InitScriptModule();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
            continue;
          case 2:
            if (this.ScriptModule == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    /// <summary>Обнулить идентификаторы для публикации</summary>
    public void ResetIdsForPublish()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ScriptModule.Id = 0L;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.Uid = GlobalScriptModuleDto.PTjxd0bKF01dfcdNwopY();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
            continue;
          case 4:
            this.Id = 0L;
            num = 3;
            continue;
          default:
            GlobalScriptModuleDto.N6EbZubKBTlfOKAss9sd((object) this.ScriptModule, Guid.NewGuid());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    private void InitScriptModule()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptModuleDTO scriptModuleDto = new ScriptModuleDTO();
            GlobalScriptModuleDto.N6EbZubKBTlfOKAss9sd((object) scriptModuleDto, GlobalScriptModuleDto.PTjxd0bKF01dfcdNwopY());
            scriptModuleDto.ModuleTypeUid = GlobalScriptModuleType.UID;
            scriptModuleDto.ObjectUid = this.Uid;
            this.ScriptModule = scriptModuleDto;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void CopyChanges(EntityDTO<long> saved)
    {
      if (saved is GlobalScriptModuleDto globalScriptModuleDto)
        this.Project.CompiledFolderPath = globalScriptModuleDto.Project.CompiledFolderPath;
      base.CopyChanges(saved);
    }

    /// <summary>Создать новый глобальный модуль</summary>
    /// <returns>Новый глобальный модуль</returns>
    public static GlobalScriptModuleDto New()
    {
      GlobalScriptModuleDto globalScriptModuleDto = new GlobalScriptModuleDto();
      globalScriptModuleDto.InitNew();
      return globalScriptModuleDto;
    }

    internal static void do2rPJbqcrjFX5O6Y4lv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool v9hPufbqUEnq3DnTLi01() => GlobalScriptModuleDto.d2YC8gbqLShx0E1KIGWV == null;

    internal static GlobalScriptModuleDto joWxvZbqsv40gbonpqAM() => GlobalScriptModuleDto.d2YC8gbqLShx0E1KIGWV;

    internal static Guid nnDkUDbqzrLQhAh85aJ8([In] object obj0) => ((GlobalScriptModuleDto) obj0).ModuleUid;

    internal static Guid PTjxd0bKF01dfcdNwopY() => Guid.NewGuid();

    internal static void N6EbZubKBTlfOKAss9sd([In] object obj0, Guid value) => ((ScriptModuleDTO) obj0).Uid = value;

    internal static void pi1EpdbKWQgvVq0h9wQJ([In] object obj0, Guid value) => ((ScriptModuleDTO) obj0).ModuleTypeUid = value;
  }
}

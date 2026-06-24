// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.ComponentMetadataItemHeaderDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>Менеджер для DTO заголовка метаданных компонентов</summary>
  internal class ComponentMetadataItemHeaderDTOManager : 
    DTOManager,
    IComponentMetadataItemHeaderDTOManager,
    IConfigurationService
  {
    private static ComponentMetadataItemHeaderDTOManager oKJ4O5bgAocKqS24TVxM;

    /// <summary>Менеджер заголовка метаданных компонентов</summary>
    public IComponentMetadataItemHeaderManager ComponentMetadataItemHeaderManager
    {
      get => this.\u003CComponentMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CComponentMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    /// <summary>Сервис проверки привилегий пользователя</summary>
    public ISecurityService SecurityService
    {
      get => this.\u003CSecurityService\u003Ek__BackingField;
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
              this.\u003CSecurityService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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
    public virtual ComponentMetadataItemHeaderDTO Load(long id) => Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(this.ComponentMetadataItemHeaderManager.Load(id), new ComponentMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual ComponentMetadataItemHeaderDTO LoadOrNull(long id) => Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(this.ComponentMetadataItemHeaderManager.LoadOrNull(id), new ComponentMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual ComponentMetadataItemHeaderDTO LoadOrNull(Guid uid)
    {
      int num1 = 2;
      ComponentMetadataItemHeaderDTO result;
      ComponentMetadataItemHeaderDTOManager headerDtoManager;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            headerDtoManager = this;
            num1 = 6;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
          case 3:
            ComponentMetadataItemHeaderDTOManager.TiHF2Sbg0RfN2ay005dq((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    result = Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(headerDtoManager.ComponentMetadataItemHeaderManager.LoadOrNull(uid1), new ComponentMetadataItemHeaderDTO());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 4:
            Locator.GetService<ISecurityService>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 3 : 0;
            continue;
          case 5:
            result = (ComponentMetadataItemHeaderDTO) null;
            num1 = 4;
            continue;
          case 6:
            uid1 = uid;
            num1 = 5;
            continue;
          default:
            goto label_7;
        }
      }
label_7:
      return result;
    }

    /// <inheritdoc />
    public virtual IEnumerable<ComponentMetadataItemHeaderDTO> FindAll()
    {
      List<ComponentMetadataItemHeaderDTO> result = new List<ComponentMetadataItemHeaderDTO>();
      this.SecurityService.RunWithElevatedPrivilegies((System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_4;
            case 1:
              List<ComponentMetadataItemHeaderDTO> metadataItemHeaderDtoList = result;
              ICollection<ComponentMetadataItemHeader> all = this.ComponentMetadataItemHeaderManager.FindAll();
              // ISSUE: reference to a compiler-generated field
              Func<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO> func = ComponentMetadataItemHeaderDTOManager.\u003C\u003Ec.\u003C\u003E9__11_1;
              Func<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ComponentMetadataItemHeaderDTOManager.\u003C\u003Ec.\u003C\u003E9__11_1 = selector = (Func<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>) (h => Mapper.Map<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(h, new ComponentMetadataItemHeaderDTO()));
              }
              else
                goto label_7;
label_6:
              List<ComponentMetadataItemHeaderDTO> list = all.Select<ComponentMetadataItemHeader, ComponentMetadataItemHeaderDTO>(selector).ToList<ComponentMetadataItemHeaderDTO>();
              metadataItemHeaderDtoList.AddRange((IEnumerable<ComponentMetadataItemHeaderDTO>) list);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
              continue;
label_7:
              selector = func;
              goto label_6;
            default:
              goto label_2;
          }
        }
label_4:
        return;
label_2:;
      }));
      return (IEnumerable<ComponentMetadataItemHeaderDTO>) result;
    }

    public ComponentMetadataItemHeaderDTOManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lBSkCgbg76DUFVObCRqh() => ComponentMetadataItemHeaderDTOManager.oKJ4O5bgAocKqS24TVxM == null;

    internal static ComponentMetadataItemHeaderDTOManager O1499ebgx0XF2uleoF9U() => ComponentMetadataItemHeaderDTOManager.oKJ4O5bgAocKqS24TVxM;

    internal static void TiHF2Sbg0RfN2ay005dq([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);
  }
}

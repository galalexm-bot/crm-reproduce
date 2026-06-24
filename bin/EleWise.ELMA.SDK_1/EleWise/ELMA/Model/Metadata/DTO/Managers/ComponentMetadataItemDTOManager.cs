// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.ComponentMetadataItemDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>Менеджер для DTO элемента метаданных компонентов</summary>
  internal class ComponentMetadataItemDTOManager : 
    DTOManager,
    IComponentMetadataItemDTOManager,
    IConfigurationService
  {
    private static ComponentMetadataItemDTOManager TYRDHkbgOoM2vn5qvVZI;

    /// <summary>Менеджер заголовка метаданных компонентов</summary>
    public IComponentMetadataItemManager ComponentMetadataItemManager
    {
      get => this.\u003CComponentMetadataItemManager\u003Ek__BackingField;
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
              this.\u003CComponentMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
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
    public virtual ComponentMetadataItemDTO Load(long id) => Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(this.ComponentMetadataItemManager.Load(id), new ComponentMetadataItemDTO());

    /// <inheritdoc />
    public virtual ComponentMetadataItemDTO LoadOrNull(long id) => Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(this.ComponentMetadataItemManager.LoadOrNull(id), new ComponentMetadataItemDTO());

    /// <inheritdoc />
    public virtual ComponentMetadataItemDTO LoadOrNull(Guid uid)
    {
      int num1 = 4;
      ComponentMetadataItemDTO result;
      ComponentMetadataItemDTOManager metadataItemDtoManager;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ComponentMetadataItemDTOManager.GU9COUbgPoC3mvZDP3YX((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    result = Mapper.Map<ComponentMetadataItem, ComponentMetadataItemDTO>(metadataItemDtoManager.ComponentMetadataItemManager.LoadOrNull(uid1), new ComponentMetadataItemDTO());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 2;
            continue;
          case 2:
            goto label_3;
          case 3:
            metadataItemDtoManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 5;
            continue;
          case 4:
            num1 = 3;
            continue;
          case 5:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
            continue;
          default:
            result = (ComponentMetadataItemDTO) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:
      return result;
    }

    public ComponentMetadataItemDTOManager()
    {
      ComponentMetadataItemDTOManager.nxNfnQbg1BRURSIHx8Gs();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool DgFGORbg21pgFSeKvwVn() => ComponentMetadataItemDTOManager.TYRDHkbgOoM2vn5qvVZI == null;

    internal static ComponentMetadataItemDTOManager HcoXtqbge6JuxvJxX3Ut() => ComponentMetadataItemDTOManager.TYRDHkbgOoM2vn5qvVZI;

    internal static void GU9COUbgPoC3mvZDP3YX([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void nxNfnQbg1BRURSIHx8Gs() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

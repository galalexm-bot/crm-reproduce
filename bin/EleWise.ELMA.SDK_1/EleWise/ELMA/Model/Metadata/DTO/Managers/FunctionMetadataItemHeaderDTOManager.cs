// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.FunctionMetadataItemHeaderDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>Менеджер для DTO заголовка метаданных функций</summary>
  internal class FunctionMetadataItemHeaderDTOManager : 
    DTOManager,
    IFunctionMetadataItemHeaderDTOManager,
    IConfigurationService
  {
    private static FunctionMetadataItemHeaderDTOManager ztNt2rb5BZsnc9Uy1H9W;

    /// <summary>Менеджер заголовка метаданных функций</summary>
    public IFunctionMetadataItemHeaderManager FunctionMetadataItemHeaderManager
    {
      get => this.\u003CFunctionMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CFunctionMetadataItemHeaderManager\u003Ek__BackingField = value;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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
    public virtual FunctionMetadataItemHeaderDTO Load(long id) => Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(this.FunctionMetadataItemHeaderManager.Load(id), new FunctionMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual FunctionMetadataItemHeaderDTO LoadOrNull(long id) => Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(this.FunctionMetadataItemHeaderManager.LoadOrNull(id), new FunctionMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual FunctionMetadataItemHeaderDTO LoadOrNull(Guid uid)
    {
      int num1 = 2;
      FunctionMetadataItemHeaderDTO result;
      FunctionMetadataItemHeaderDTOManager headerDtoManager;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            headerDtoManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 0;
            continue;
          case 3:
            result = (FunctionMetadataItemHeaderDTO) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 4 : 2;
            continue;
          case 4:
            Locator.GetService<ISecurityService>();
            num1 = 6;
            continue;
          case 5:
            goto label_6;
          case 6:
            FunctionMetadataItemHeaderDTOManager.bKi9wRb5b2pHBYSpCQvR((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    result = Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(headerDtoManager.FunctionMetadataItemHeaderManager.LoadOrNull(uid1), new FunctionMetadataItemHeaderDTO());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 5;
            continue;
          default:
            uid1 = uid;
            num1 = 3;
            continue;
        }
      }
label_6:
      return result;
    }

    /// <inheritdoc />
    public virtual IEnumerable<FunctionMetadataItemHeaderDTO> FindAll()
    {
      List<FunctionMetadataItemHeaderDTO> result = new List<FunctionMetadataItemHeaderDTO>();
      this.SecurityService.RunWithElevatedPrivilegies((System.Action) (() =>
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              result.AddRange((IEnumerable<FunctionMetadataItemHeaderDTO>) this.FunctionMetadataItemHeaderManager.FindAll().Select<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>((Func<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>) (h => Mapper.Map<FunctionMetadataItemHeader, FunctionMetadataItemHeaderDTO>(h, new FunctionMetadataItemHeaderDTO()))).ToList<FunctionMetadataItemHeaderDTO>());
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }));
      return (IEnumerable<FunctionMetadataItemHeaderDTO>) result;
    }

    public FunctionMetadataItemHeaderDTOManager()
    {
      FunctionMetadataItemHeaderDTOManager.DfiPM7b5hgU00E2dLPlH();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool RQZ9fGb5W1S2xZZEWlGq() => FunctionMetadataItemHeaderDTOManager.ztNt2rb5BZsnc9Uy1H9W == null;

    internal static FunctionMetadataItemHeaderDTOManager WTJc6ub5oLXJV47eYEN8() => FunctionMetadataItemHeaderDTOManager.ztNt2rb5BZsnc9Uy1H9W;

    internal static void bKi9wRb5b2pHBYSpCQvR([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void DfiPM7b5hgU00E2dLPlH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

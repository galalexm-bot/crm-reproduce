// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.FunctionMetadataItemDTOManager
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
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>Менеджер для DTO элемента метаданных функций</summary>
  internal class FunctionMetadataItemDTOManager : 
    DTOManager,
    IFunctionMetadataItemDTOManager,
    IConfigurationService
  {
    private static FunctionMetadataItemDTOManager Xsl6UfbgNCvpoH19YEsJ;

    /// <summary>Менеджер заголовка метаданных функций</summary>
    public IFunctionMetadataItemManager FunctionMetadataItemManager
    {
      get => this.\u003CFunctionMetadataItemManager\u003Ek__BackingField;
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
              this.\u003CFunctionMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
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
    public virtual FunctionMetadataItemDTO Load(long id) => Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(this.FunctionMetadataItemManager.Load(id), new FunctionMetadataItemDTO());

    /// <inheritdoc />
    public virtual FunctionMetadataItemDTO LoadOrNull(long id) => Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(this.FunctionMetadataItemManager.LoadOrNull(id), new FunctionMetadataItemDTO());

    /// <inheritdoc />
    public virtual FunctionMetadataItemDTO LoadOrNull(Guid uid)
    {
      int num1 = 1;
      FunctionMetadataItemDTO result;
      FunctionMetadataItemDTOManager metadataItemDtoManager;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_5;
          case 3:
            result = (FunctionMetadataItemDTO) null;
            num1 = 4;
            continue;
          case 4:
            FunctionMetadataItemDTOManager.Dk45L3bgaWRybDh6IdSO((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    result = Mapper.Map<FunctionMetadataItem, FunctionMetadataItemDTO>(metadataItemDtoManager.FunctionMetadataItemManager.LoadOrNull(uid1), new FunctionMetadataItemDTO());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 2 : 2;
            continue;
          case 5:
            uid1 = uid;
            num1 = 3;
            continue;
          default:
            metadataItemDtoManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 5 : 0;
            continue;
        }
      }
label_5:
      return result;
    }

    public FunctionMetadataItemDTOManager()
    {
      FunctionMetadataItemDTOManager.s6yvQbbgDEToAgb7mbBg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool nOw3Pabg3U3hpD3pT089() => FunctionMetadataItemDTOManager.Xsl6UfbgNCvpoH19YEsJ == null;

    internal static FunctionMetadataItemDTOManager v3xuSLbgpBRqqd8itLp1() => FunctionMetadataItemDTOManager.Xsl6UfbgNCvpoH19YEsJ;

    internal static void Dk45L3bgaWRybDh6IdSO([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void s6yvQbbgDEToAgb7mbBg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

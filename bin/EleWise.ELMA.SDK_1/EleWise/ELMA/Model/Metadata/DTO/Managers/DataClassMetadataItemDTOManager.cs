// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.DataClassMetadataItemDTOManager
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
  /// <summary>Менеджер для DTO элемента метаданных датаклассов</summary>
  internal class DataClassMetadataItemDTOManager : 
    DTOManager,
    IDataClassMetadataItemDTOManager,
    IConfigurationService
  {
    internal static DataClassMetadataItemDTOManager G5Ek3FbgKWlPS6uLyq6S;

    /// <summary>Менеджер заголовка метаданных функций</summary>
    public IDataClassMetadataItemManager DataClassMetadataItemManager
    {
      get => this.\u003CDataClassMetadataItemManager\u003Ek__BackingField;
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
              this.\u003CDataClassMetadataItemManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
    public virtual DataClassMetadataItemDTO Load(long id) => Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(this.DataClassMetadataItemManager.Load(id), new DataClassMetadataItemDTO());

    /// <inheritdoc />
    public virtual DataClassMetadataItemDTO LoadOrNull(long id) => Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(this.DataClassMetadataItemManager.LoadOrNull(id), new DataClassMetadataItemDTO());

    /// <inheritdoc />
    public virtual DataClassMetadataItemDTO LoadOrNull(Guid uid)
    {
      int num1 = 1;
      DataClassMetadataItemDTO result;
      DataClassMetadataItemDTOManager metadataItemDtoManager;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            result = (DataClassMetadataItemDTO) null;
            num1 = 5;
            continue;
          case 3:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 2 : 0;
            continue;
          case 4:
            goto label_3;
          case 5:
            DataClassMetadataItemDTOManager.DjVycNbgk7On5DOaxm1Q((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    result = Mapper.Map<DataClassMetadataItem, DataClassMetadataItemDTO>(metadataItemDtoManager.DataClassMetadataItemManager.LoadOrNull(uid1), new DataClassMetadataItemDTO());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 4 : 1;
            continue;
          default:
            metadataItemDtoManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 3 : 3;
            continue;
        }
      }
label_3:
      return result;
    }

    public DataClassMetadataItemDTOManager()
    {
      DataClassMetadataItemDTOManager.sDaS4FbgnuC1gYrlZ1Y9();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ICoHQfbgXjQaIhauSAjq() => DataClassMetadataItemDTOManager.G5Ek3FbgKWlPS6uLyq6S == null;

    internal static DataClassMetadataItemDTOManager ejigTabgTlHtru3jsAPi() => DataClassMetadataItemDTOManager.G5Ek3FbgKWlPS6uLyq6S;

    internal static void DjVycNbgk7On5DOaxm1Q([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void sDaS4FbgnuC1gYrlZ1Y9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

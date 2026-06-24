// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.DataClassMetadataItemHeaderDTOManager
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
  /// <summary>Менеджер для DTO заголовка метаданных датаклассов</summary>
  internal class DataClassMetadataItemHeaderDTOManager : 
    DTOManager,
    IDataClassMetadataItemHeaderDTOManager,
    IConfigurationService
  {
    internal static DataClassMetadataItemHeaderDTOManager cEgeDWbgtKUIZPG6Nmuj;

    /// <summary>Менеджер заголовка метаданных функций</summary>
    public DataClassMetadataItemHeaderManager DataClassMetadataItemHeaderManager
    {
      get => this.\u003CDataClassMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CDataClassMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
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
    public virtual DataClassMetadataItemHeaderDTO Load(long id) => Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(this.DataClassMetadataItemHeaderManager.Load(id), new DataClassMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual DataClassMetadataItemHeaderDTO LoadOrNull(long id) => Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(this.DataClassMetadataItemHeaderManager.LoadOrNull(id), new DataClassMetadataItemHeaderDTO());

    /// <inheritdoc />
    public virtual DataClassMetadataItemHeaderDTO LoadOrNull(Guid uid)
    {
      int num1 = 3;
      DataClassMetadataItemHeaderDTO result;
      while (true)
      {
        int num2 = num1;
        DataClassMetadataItemHeaderDTOManager headerDtoManager;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              Locator.GetService<ISecurityService>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            case 2:
              headerDtoManager = this;
              num2 = 4;
              continue;
            case 3:
              goto label_8;
            case 4:
              uid1 = uid;
              num2 = 6;
              continue;
            case 5:
              goto label_5;
            case 6:
              result = (DataClassMetadataItemHeaderDTO) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
              continue;
            default:
              DataClassMetadataItemHeaderDTOManager.AvTbEybg69XqFClFMLAh((object) this.SecurityService, (object) (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      result = Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(headerDtoManager.DataClassMetadataItemHeaderManager.LoadOrNull(uid1), new DataClassMetadataItemHeaderDTO());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = 5;
              continue;
          }
        }
label_8:
        num1 = 2;
      }
label_5:
      return result;
    }

    /// <inheritdoc />
    public virtual IEnumerable<DataClassMetadataItemHeaderDTO> FindAll()
    {
      List<DataClassMetadataItemHeaderDTO> result = new List<DataClassMetadataItemHeaderDTO>();
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
              List<DataClassMetadataItemHeaderDTO> metadataItemHeaderDtoList = result;
              ICollection<DataClassMetadataItemHeader> all = this.DataClassMetadataItemHeaderManager.FindAll();
              // ISSUE: reference to a compiler-generated field
              Func<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO> func = DataClassMetadataItemHeaderDTOManager.\u003C\u003Ec.\u003C\u003E9__11_1;
              Func<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                DataClassMetadataItemHeaderDTOManager.\u003C\u003Ec.\u003C\u003E9__11_1 = selector = (Func<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>) (h => Mapper.Map<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(h, new DataClassMetadataItemHeaderDTO()));
              }
              else
                goto label_7;
label_6:
              List<DataClassMetadataItemHeaderDTO> list = all.Select<DataClassMetadataItemHeader, DataClassMetadataItemHeaderDTO>(selector).ToList<DataClassMetadataItemHeaderDTO>();
              metadataItemHeaderDtoList.AddRange((IEnumerable<DataClassMetadataItemHeaderDTO>) list);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
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
      return (IEnumerable<DataClassMetadataItemHeaderDTO>) result;
    }

    public DataClassMetadataItemHeaderDTOManager()
    {
      DataClassMetadataItemHeaderDTOManager.EgBFVKbgHlP1XZaOIO7a();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool R7f5PebgwfO1Mrx9jqlL() => DataClassMetadataItemHeaderDTOManager.cEgeDWbgtKUIZPG6Nmuj == null;

    internal static DataClassMetadataItemHeaderDTOManager bS10Subg478HAYoX3Tcj() => DataClassMetadataItemHeaderDTOManager.cEgeDWbgtKUIZPG6Nmuj;

    internal static void AvTbEybg69XqFClFMLAh([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void EgBFVKbgHlP1XZaOIO7a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

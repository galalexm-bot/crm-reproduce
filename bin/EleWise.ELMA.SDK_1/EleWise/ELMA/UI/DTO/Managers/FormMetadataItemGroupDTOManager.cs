// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.FormMetadataItemGroupDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public class FormMetadataItemGroupDTOManager : 
    DTOManager,
    IFormMetadataItemGroupDTOManager,
    IConfigurationService
  {
    private static FormMetadataItemGroupDTOManager Bt06qQ9KfrF3DkwRtRT;

    public FormMetadataItemGroupManager FormMetadataItemGroupManager
    {
      get => this.\u003CFormMetadataItemGroupManager\u003Ek__BackingField;
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
              this.\u003CFormMetadataItemGroupManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    public FormMetadataItemHeaderManager FormMetadataItemHeaderManager
    {
      get => this.\u003CFormMetadataItemHeaderManager\u003Ek__BackingField;
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
              this.\u003CFormMetadataItemHeaderManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
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

    /// <summary>Загрузить корневую группу</summary>
    /// <param name="metadataType">Тип метаданных форм (страница или портлет)</param>
    /// <returns>Корневая группа форм указанного типа</returns>
    public virtual FormMetadataItemGroupDTO LoadRootGroup(Guid metadataType)
    {
      int num1 = 1;
      IEnumerator<FormMetadataItemGroupDTO> enumerator1;
      Dictionary<long, FormMetadataItemGroupDTO> dictionary1;
      FormMetadataItemGroupDTO metadataItemGroupDto1;
      IEnumerable<FormMetadataItemGroupDTO> metadataItemGroupDtos;
      long? nullable;
      IEnumerator<FormMetadataItemHeaderDTO> enumerator2;
      IEnumerable<FormMetadataItemHeaderDTO> metadataItemHeaderDtos;
      while (true)
      {
        switch (num1)
        {
          case 1:
            FormMetadataItemGroupDTO metadataItemGroupDto2 = new FormMetadataItemGroupDTO();
            FormMetadataItemGroupDTOManager.s1AneE9kLWDVlq5Cl94((object) metadataItemGroupDto2, metadataType);
            metadataItemGroupDto1 = metadataItemGroupDto2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            enumerator1 = metadataItemGroupDtos.GetEnumerator();
            num1 = 7;
            continue;
          case 3:
            goto label_64;
          case 4:
label_63:
            enumerator2 = metadataItemHeaderDtos.GetEnumerator();
            num1 = 8;
            continue;
          case 5:
            dictionary1 = new Dictionary<long, FormMetadataItemGroupDTO>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 2 : 2;
            continue;
          case 6:
            metadataItemHeaderDtos = this.FormMetadataItemHeaderManager.LoadHeaderDTOList(metadataType);
            num1 = 5;
            continue;
          case 7:
            try
            {
label_6:
              if (FormMetadataItemGroupDTOManager.zupr4Y9nIql4F9C1wvo((object) enumerator1))
                goto label_4;
              else
                goto label_7;
label_3:
              FormMetadataItemGroupDTO current;
              int num2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    dictionary1[current.Id] = current;
                    num2 = 2;
                    continue;
                  case 2:
                    goto label_6;
                  case 3:
                    goto label_4;
                  default:
                    goto label_61;
                }
              }
label_4:
              current = enumerator1.Current;
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
              {
                num2 = 0;
                goto label_3;
              }
              else
                goto label_3;
label_7:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              goto label_3;
            }
            finally
            {
              int num3;
              if (enumerator1 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 2 : 1;
              else
                goto label_12;
label_11:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_12:
              enumerator1.Dispose();
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
              {
                num3 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
          case 8:
            goto label_17;
          case 9:
label_61:
            enumerator1 = metadataItemGroupDtos.GetEnumerator();
            num1 = 10;
            continue;
          case 10:
            try
            {
label_53:
              if (FormMetadataItemGroupDTOManager.zupr4Y9nIql4F9C1wvo((object) enumerator1))
                goto label_51;
              else
                goto label_54;
label_39:
              FormMetadataItemGroupDTO metadataItemGroupDto3;
              FormMetadataItemGroupDTO current;
              int num4;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    metadataItemGroupDto3 = (FormMetadataItemGroupDTO) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_51;
                  case 3:
                  case 8:
                    if (metadataItemGroupDto3 == null)
                    {
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 2 : 6;
                      continue;
                    }
                    goto case 5;
                  case 4:
                    if (!nullable.HasValue)
                    {
                      num4 = 8;
                      continue;
                    }
                    goto case 9;
                  case 5:
                    metadataItemGroupDto3.Groups.Add(current);
                    num4 = 7;
                    continue;
                  case 6:
                    metadataItemGroupDto3 = metadataItemGroupDto1;
                    num4 = 5;
                    continue;
                  case 7:
                    goto label_53;
                  case 9:
                    Dictionary<long, FormMetadataItemGroupDTO> dictionary2 = dictionary1;
                    nullable = current.ParentId;
                    long key = nullable.Value;
                    ref FormMetadataItemGroupDTO local = ref metadataItemGroupDto3;
                    if (!dictionary2.TryGetValue(key, out local))
                    {
                      num4 = 10;
                      continue;
                    }
                    goto case 3;
                  case 10:
                    metadataItemGroupDto3 = (FormMetadataItemGroupDTO) null;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 3;
                    continue;
                  case 11:
                    goto label_63;
                  default:
                    nullable = current.ParentId;
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 1 : 4;
                    continue;
                }
              }
label_51:
              current = enumerator1.Current;
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              {
                num4 = 1;
                goto label_39;
              }
              else
                goto label_39;
label_54:
              num4 = 11;
              goto label_39;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = 2;
              else
                goto label_58;
label_57:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_58:
              FormMetadataItemGroupDTOManager.Ticvv19OybpNsCu8dMg((object) enumerator1);
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
              {
                num5 = 0;
                goto label_57;
              }
              else
                goto label_57;
            }
          default:
            FormMetadataItemGroupManager itemGroupManager = this.FormMetadataItemGroupManager;
            Guid metadataType1 = metadataType;
            nullable = new long?();
            long? parentId = nullable;
            metadataItemGroupDtos = itemGroupManager.LoadGroupDTOList(metadataType1, parentId);
            num1 = 6;
            continue;
        }
      }
label_17:
      try
      {
label_28:
        if (FormMetadataItemGroupDTOManager.zupr4Y9nIql4F9C1wvo((object) enumerator2))
          goto label_24;
        else
          goto label_29;
label_18:
        FormMetadataItemGroupDTO metadataItemGroupDto4;
        FormMetadataItemHeaderDTO current;
        int num6;
        while (true)
        {
          switch (num6)
          {
            case 1:
              goto label_64;
            case 2:
              metadataItemGroupDto4 = (FormMetadataItemGroupDTO) null;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 10 : 3;
              continue;
            case 3:
              nullable = current.GroupId;
              num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
              continue;
            case 4:
            case 6:
              metadataItemGroupDto4.Headers.Add(current);
              num6 = 5;
              continue;
            case 5:
              goto label_28;
            case 7:
            case 10:
              if (metadataItemGroupDto4 != null)
              {
                num6 = 4;
                continue;
              }
              goto case 9;
            case 8:
              metadataItemGroupDto4 = (FormMetadataItemGroupDTO) null;
              num6 = 3;
              continue;
            case 9:
              metadataItemGroupDto4 = metadataItemGroupDto1;
              num6 = 6;
              continue;
            case 11:
              Dictionary<long, FormMetadataItemGroupDTO> dictionary3 = dictionary1;
              nullable = current.GroupId;
              long key = nullable.Value;
              ref FormMetadataItemGroupDTO local = ref metadataItemGroupDto4;
              if (!dictionary3.TryGetValue(key, out local))
              {
                num6 = 2;
                continue;
              }
              goto case 7;
            case 12:
              goto label_24;
            default:
              if (!nullable.HasValue)
              {
                num6 = 7;
                continue;
              }
              goto case 11;
          }
        }
label_24:
        current = enumerator2.Current;
        num6 = 8;
        goto label_18;
label_29:
        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
        goto label_18;
      }
      finally
      {
        int num7;
        if (enumerator2 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
        else
          goto label_36;
label_35:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_36:
        FormMetadataItemGroupDTOManager.Ticvv19OybpNsCu8dMg((object) enumerator2);
        num7 = 2;
        goto label_35;
      }
label_64:
      return metadataItemGroupDto1;
    }

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    public virtual IEnumerable<FormMetadataItemGroupDTO> GetChildGroups(
      Guid metadataType,
      long? parentGroupId)
    {
      return this.FormMetadataItemGroupManager.LoadGroupDTOList(metadataType, parentGroupId);
    }

    /// <summary>Получить рекурсивный список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    public virtual IEnumerable<FormMetadataItemGroupDTO> GetNestedChildGroups(
      Guid metadataType,
      long? parentGroupId)
    {
      IEnumerable<FormMetadataItemGroupDTO> allGroups = this.FormMetadataItemGroupManager.LoadGroupDTOList(metadataType, new long?());
      List<FormMetadataItemGroupDTO> result = new List<FormMetadataItemGroupDTO>();
      this.GetChilds(parentGroupId, allGroups, result);
      return (IEnumerable<FormMetadataItemGroupDTO>) result;
    }

    /// <summary>Сохранить группу</summary>
    /// <param name="group">Группа</param>
    /// <returns>Измененная группа</returns>
    public virtual FormMetadataItemGroupDTO Save(FormMetadataItemGroupDTO group)
    {
      int num = 3;
      IFormMetadataItemGroup source;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 5:
            goto label_3;
          case 2:
            FormMetadataItemGroupDTOManager.a4Xq5o92rPAligtoRax((object) source);
            num = 4;
            continue;
          case 3:
            source = Mapper.Map<FormMetadataItemGroupDTO, IFormMetadataItemGroup>(group);
            num = 2;
            continue;
          case 4:
            if (source.Parent == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 1 : 0;
              continue;
            }
            break;
        }
        FormMetadataItemGroupDTOManager.hQXHCw9PfvmN7WX28ab(FormMetadataItemGroupDTOManager.Tl84Sy9e9Obvw9GQMUg((object) source));
        num = 5;
      }
label_3:
      return Mapper.Map<IFormMetadataItemGroup, FormMetadataItemGroupDTO>(source, group);
    }

    /// <summary>Удалить группу</summary>
    /// <param name="groupId">Идентификатор группы</param>
    public virtual void Delete(long groupId)
    {
      int num1 = 1;
      FormMetadataItemGroupDTOManager itemGroupDtoManager;
      long groupId1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            FormMetadataItemGroupDTOManager.HecnYs917UHvwO50Hia((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    itemGroupDtoManager.FormMetadataItemGroupManager.Delete(groupId1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 4;
            continue;
          case 3:
            groupId1 = groupId;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 0;
            continue;
          case 4:
            goto label_2;
          default:
            itemGroupDtoManager = this;
            num1 = 3;
            continue;
        }
      }
label_2:;
    }

    private void GetChilds(
      long? parentGroupId,
      IEnumerable<FormMetadataItemGroupDTO> allGroups,
      List<FormMetadataItemGroupDTO> result)
    {
      foreach (FormMetadataItemGroupDTO metadataItemGroupDto in allGroups.Where<FormMetadataItemGroupDTO>((Func<FormMetadataItemGroupDTO, bool>) (g =>
      {
        int num = 2;
        long? nullable;
        long? parentId;
        while (true)
        {
          switch (num)
          {
            case 1:
              parentId = g.ParentId;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            case 2:
              nullable = parentGroupId;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        return nullable.GetValueOrDefault() == parentId.GetValueOrDefault() & nullable.HasValue == parentId.HasValue;
      })))
      {
        if (!result.Contains(metadataItemGroupDto))
        {
          result.Add(metadataItemGroupDto);
          this.GetChilds(new long?(metadataItemGroupDto.Id), allGroups, result);
        }
      }
    }

    public FormMetadataItemGroupDTOManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool HbSauD9X0fgoJmxv75g() => FormMetadataItemGroupDTOManager.Bt06qQ9KfrF3DkwRtRT == null;

    internal static FormMetadataItemGroupDTOManager XE5cIq9T7nnXFOtCrch() => FormMetadataItemGroupDTOManager.Bt06qQ9KfrF3DkwRtRT;

    internal static void s1AneE9kLWDVlq5Cl94([In] object obj0, Guid value) => ((FormMetadataItemGroupDTO) obj0).MetadataType = value;

    internal static bool zupr4Y9nIql4F9C1wvo([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Ticvv19OybpNsCu8dMg([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void a4Xq5o92rPAligtoRax([In] object obj0) => ((IEntity) obj0).Save();

    internal static object Tl84Sy9e9Obvw9GQMUg([In] object obj0) => (object) ((IFormMetadataItemGroup) obj0).Parent;

    internal static void hQXHCw9PfvmN7WX28ab([In] object obj0) => ((IEntity) obj0).Refresh();

    internal static void HecnYs917UHvwO50Hia([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);
  }
}

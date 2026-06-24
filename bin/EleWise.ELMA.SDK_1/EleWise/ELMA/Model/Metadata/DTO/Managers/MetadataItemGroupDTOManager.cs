// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.DTO.Managers.MetadataItemGroupDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata.DTO.Models;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;

namespace EleWise.ELMA.Model.Metadata.DTO.Managers
{
  /// <summary>
  /// Менеджер групп элементов метаданных для работы через Remoting
  /// </summary>
  public class MetadataItemGroupDTOManager : 
    DTOManager,
    IMetadataItemGroupDTOManager,
    IConfigurationService
  {
    internal static MetadataItemGroupDTOManager FeQ7ZWb5I9G3wOVxRB6j;

    public MetadataItemGroupManager MetadataItemGroupManager => Locator.GetServiceNotNull<MetadataItemGroupManager>();

    /// <summary>
    /// Загрузить корневую группу с загруженным списком подгрупп
    /// </summary>
    /// <returns>Корневая группа процессов</returns>
    public virtual MetadataItemGroupDTO LoadRootGroup()
    {
      int num1 = 2;
      MetadataItemGroupDTO metadataItemGroupDto1;
      IEnumerator<IMetadataItemGroup> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            MetadataItemGroupManager itemGroupManager = this.MetadataItemGroupManager;
            // ISSUE: type reference
            ParameterExpression parameterExpression = (ParameterExpression) MetadataItemGroupDTOManager.IxNFJab5qH4FeOKxOedn(MetadataItemGroupDTOManager.TnYek9b5ifQBBS59a6M7(__typeref (IMetadataItemGroup)), MetadataItemGroupDTOManager.dwPbJ9b5RljwmRyvELcE(-2106517564 ^ -2106466236));
            // ISSUE: method reference
            // ISSUE: type reference
            Expression<Func<IMetadataItemGroup, bool>> condition = Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression) Expression.Equal((Expression) MetadataItemGroupDTOManager.v6I5yRb5XCc1CCLrfJvH((object) parameterExpression, (object) (MethodInfo) MetadataItemGroupDTOManager.LtRKieb5K59fRoSQ56oY(__methodref (IMetadataItemGroup.get_Parent))), (Expression) MetadataItemGroupDTOManager.d59fVFb5TtJd65lY2FTG((object) null, MetadataItemGroupDTOManager.TnYek9b5ifQBBS59a6M7(__typeref (object)))), parameterExpression);
            ICollection<IMetadataItemGroup> metadataItemGroups = itemGroupManager.Find(condition);
            metadataItemGroupDto1 = new MetadataItemGroupDTO()
            {
              Name = EleWise.ELMA.SR.M(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218805708)),
              DisplayName = EleWise.ELMA.SR.M((string) MetadataItemGroupDTOManager.dwPbJ9b5RljwmRyvELcE(--1360331293 ^ 1360502427))
            };
            enumerator = metadataItemGroups.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return metadataItemGroupDto1;
label_4:
      try
      {
label_9:
        if (MetadataItemGroupDTOManager.ECsMi6b5k6wpm4sLWhOy((object) enumerator))
          goto label_6;
        else
          goto label_10;
label_5:
        MetadataItemGroupDTO metadataItemGroupDto2;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              metadataItemGroupDto1.SubGroups.Add(metadataItemGroupDto2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_6;
            case 3:
              goto label_3;
            default:
              goto label_9;
          }
        }
label_6:
        metadataItemGroupDto2 = Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(enumerator.Current, new MetadataItemGroupDTO());
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        {
          num2 = 1;
          goto label_5;
        }
        else
          goto label_5;
label_10:
        num2 = 3;
        goto label_5;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 2;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        MetadataItemGroupDTOManager.q6o3iwb5nujFhx8Vq06p((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
        {
          num3 = 0;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    /// <summary>Получить список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    public virtual IEnumerable<MetadataItemGroupDTO> GetChildGroups(long parentGroupId)
    {
      IMetadataItemGroup parentGroup = parentGroupId > 0L ? this.MetadataItemGroupManager.Load(parentGroupId) : (IMetadataItemGroup) null;
      return (IEnumerable<MetadataItemGroupDTO>) this.MetadataItemGroupManager.Find((Expression<Func<IMetadataItemGroup, bool>>) (metadataItemGroup => metadataItemGroup.Parent == parentGroup)).Select<IMetadataItemGroup, MetadataItemGroupDTO>((Func<IMetadataItemGroup, MetadataItemGroupDTO>) (g => Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(g))).ToList<MetadataItemGroupDTO>();
    }

    private void GetChilds(long parentGroupId, List<MetadataItemGroupDTO> childs)
    {
      if (childs == null)
        childs = new List<MetadataItemGroupDTO>();
      if (!childs.All<MetadataItemGroupDTO>((Func<MetadataItemGroupDTO, bool>) (r => r.Id != parentGroupId)))
        return;
      IMetadataItemGroup parentGroup = parentGroupId > 0L ? this.MetadataItemGroupManager.Load(parentGroupId) : (IMetadataItemGroup) null;
      if (parentGroup == null)
        return;
      List<MetadataItemGroupDTO> list = this.MetadataItemGroupManager.Find((Expression<Func<IMetadataItemGroup, bool>>) (metadataItemGroup => metadataItemGroup.Parent == parentGroup)).Select<IMetadataItemGroup, MetadataItemGroupDTO>((Func<IMetadataItemGroup, MetadataItemGroupDTO>) (g => Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(g))).ToList<MetadataItemGroupDTO>();
      if (!list.Any<MetadataItemGroupDTO>())
        return;
      list.ForEach((Action<MetadataItemGroupDTO>) (g =>
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          MetadataItemGroupDTO g1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_3;
              case 2:
                this.GetChilds(g1.Id, childs);
                num2 = 6;
                continue;
              case 3:
                g1 = g;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                continue;
              case 4:
                goto label_4;
              case 5:
                childs.ForEach((Action<MetadataItemGroupDTO>) (c =>
                {
                  int num3 = 1;
                  MetadataItemGroupDTO c2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_2;
                      case 3:
                        if (childs.All<MetadataItemGroupDTO>((Func<MetadataItemGroupDTO, bool>) (r => r.Id != c2.Id)))
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 4 : 3;
                          continue;
                        }
                        goto label_8;
                      case 4:
                        childs.Add(c2);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 2;
                        continue;
                      default:
                        c2 = c;
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 3 : 0;
                        continue;
                    }
                  }
label_2:
                  return;
label_8:;
                }));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 1 : 0;
                continue;
              case 6:
                childs.Add(g1);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 4;
                continue;
              default:
                if (childs.All<MetadataItemGroupDTO>((Func<MetadataItemGroupDTO, bool>) (r => r.Id != g1.Id)))
                {
                  num2 = 2;
                  continue;
                }
                goto label_11;
            }
          }
label_4:
          num1 = 3;
        }
label_3:
        return;
label_11:;
      }));
    }

    /// <summary>Получить рекурсивный список подчиненных групп</summary>
    /// <param name="parentGroupId">Id родительской группы (или 0 - если корень)</param>
    /// <returns>Список подчиненных групп</returns>
    public virtual IEnumerable<MetadataItemGroupDTO> GetNestedChildGroups(long parentGroupId)
    {
      if ((parentGroupId > 0L ? this.MetadataItemGroupManager.Load(parentGroupId) : (IMetadataItemGroup) null) == null)
        return (IEnumerable<MetadataItemGroupDTO>) new List<MetadataItemGroupDTO>();
      List<MetadataItemGroupDTO> childs = new List<MetadataItemGroupDTO>();
      this.GetChilds(parentGroupId, childs);
      return (IEnumerable<MetadataItemGroupDTO>) childs;
    }

    /// <summary>Сохранить группу</summary>
    /// <param name="group">Группа</param>
    /// <returns>Измененная группа</returns>
    public virtual MetadataItemGroupDTO Save(MetadataItemGroupDTO group)
    {
      int num = 3;
      IMetadataItemGroup source;
      while (true)
      {
        switch (num)
        {
          case 1:
            source.Parent.Refresh();
            num = 5;
            continue;
          case 2:
            MetadataItemGroupDTOManager.zyBtIhb5OLwmdcCNSPjl((object) source);
            num = 6;
            continue;
          case 3:
            source = Mapper.Map<MetadataItemGroupDTO, IMetadataItemGroup>(group);
            num = 2;
            continue;
          case 4:
            if (MetadataItemGroupDTOManager.YHZDpjb52hg9xQibJ37q((object) source) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 5:
            MetadataItemGroupDTOManager.uaVYZmb5eGNiHGKuxLXV((object) Locator.GetService<IContextBoundVariableService>(), MetadataItemGroupDTOManager.dwPbJ9b5RljwmRyvELcE(-398663332 ^ -398584054));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 6:
            source.Refresh();
            num = 4;
            continue;
          case 7:
            goto label_5;
          default:
            MetadataItemGroupDTOManager.bZU6ZQb5PpJD7HOLblAt(MetadataItemGroupDTOManager.dwPbJ9b5RljwmRyvELcE(1994213607 >> 4 ^ 124723928));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 7 : 7;
            continue;
        }
      }
label_5:
      return Mapper.Map<IMetadataItemGroup, MetadataItemGroupDTO>(source, group);
    }

    /// <summary>Удалить группу</summary>
    /// <param name="groupId">Идентификатор группы</param>
    public virtual void Delete(long groupId)
    {
      int num = 1;
      IMetadataItemGroup metadataItemGroup;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataItemGroup = this.MetadataItemGroupManager.LoadOrNull(groupId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            this.MetadataItemGroupManager.Delete(metadataItemGroup);
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            if (metadataItemGroup != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
              continue;
            }
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    public MetadataItemGroupDTOManager()
    {
      MetadataItemGroupDTOManager.TNBQPqb51BaVH45fnWgE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type TnYek9b5ifQBBS59a6M7([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object dwPbJ9b5RljwmRyvELcE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object IxNFJab5qH4FeOKxOedn([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object LtRKieb5K59fRoSQ56oY([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object v6I5yRb5XCc1CCLrfJvH([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object d59fVFb5TtJd65lY2FTG([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static bool ECsMi6b5k6wpm4sLWhOy([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void q6o3iwb5nujFhx8Vq06p([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool mdc97Rb5Vx0HwFD93Mfq() => MetadataItemGroupDTOManager.FeQ7ZWb5I9G3wOVxRB6j == null;

    internal static MetadataItemGroupDTOManager UP1DjJb5SY0OyA5NlQ2O() => MetadataItemGroupDTOManager.FeQ7ZWb5I9G3wOVxRB6j;

    internal static void zyBtIhb5OLwmdcCNSPjl([In] object obj0) => ((IEntity) obj0).Save();

    internal static object YHZDpjb52hg9xQibJ37q([In] object obj0) => (object) ((IMetadataItemGroup) obj0).Parent;

    internal static void uaVYZmb5eGNiHGKuxLXV([In] object obj0, [In] object obj1) => ((IAbstractBoundVariableService) obj0).Remove((string) obj1);

    internal static void bZU6ZQb5PpJD7HOLblAt([In] object obj0) => CallContext.FreeNamedDataSlot((string) obj0);

    internal static void TNBQPqb51BaVH45fnWgE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

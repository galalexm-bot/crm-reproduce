// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.ComponentMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Model.Views.Toolbar;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Managers
{
  /// <summary>Менеджер заголовков метаданных компонента</summary>
  internal class ComponentMetadataItemHeaderManager : 
    EntityManager<ComponentMetadataItemHeader, long>,
    IComponentMetadataItemHeaderManager,
    IEntityManager<ComponentMetadataItemHeader, long>,
    IEntityManager<ComponentMetadataItemHeader>,
    IEntityManager
  {
    private static readonly Dictionary<Guid, ComponentMetadataItemHeader> SystemComponents;
    private static ComponentMetadataItemHeaderManager EYHJlfBflFZgVwpHWPbw;

    /// <summary>Экземпляр менеджера</summary>
    public static ComponentMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<ComponentMetadataItemHeaderManager>();

    /// <inheritdoc />
    public override ComponentMetadataItemHeader Load(Guid uid)
    {
      int num = 2;
      ComponentMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (ComponentMetadataItemHeaderManager.SystemComponents.TryGetValue(uid, out metadataItemHeader))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return base.Load(uid);
label_3:
      return metadataItemHeader;
    }

    /// <inheritdoc />
    public override ComponentMetadataItemHeader LoadOrNull(Guid uid)
    {
      int num = 1;
      ComponentMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ComponentMetadataItemHeaderManager.SystemComponents.TryGetValue(uid, out metadataItemHeader))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return base.LoadOrNull(uid);
label_5:
      return metadataItemHeader;
    }

    /// <inheritdoc />
    public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 1;
      while (true)
      {
        ComponentMetadataItemHeaderFilter itemHeaderFilter;
        bool? isPublished;
        int num2;
        switch (num1)
        {
          case 1:
            ComponentMetadataItemHeaderManager.b5XHKWBf5bWdvipJGD00((object) this, (object) criteria, (object) filter);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_13;
          case 4:
            criteria.Add((ICriterion) Restrictions.IsNull(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Published));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 2 : 2;
            continue;
          case 5:
            if (!isPublished.Value)
            {
              num1 = 4;
              continue;
            }
            goto case 8;
          case 6:
            goto label_12;
          case 7:
            isPublished = itemHeaderFilter.IsPublished;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 5;
            continue;
          case 8:
            ComponentMetadataItemHeaderManager.USvYVLBfYINXdeyh25s7((object) criteria, ComponentMetadataItemHeaderManager.yXLoUoBfjv0xkkPYDP90((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Published));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 4;
            continue;
          case 9:
            if (itemHeaderFilter == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 3 : 10;
              continue;
            }
            isPublished = itemHeaderFilter.IsPublished;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 10 : 11;
            continue;
          case 10:
            num2 = 1;
            break;
          case 11:
            num2 = !isPublished.HasValue ? 1 : 0;
            break;
          default:
            itemHeaderFilter = filter as ComponentMetadataItemHeaderFilter;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 9 : 9;
            continue;
        }
        if (num2 == 0)
          num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 7 : 7;
        else
          goto label_7;
      }
label_2:
      return;
label_13:
      return;
label_12:
      return;
label_7:;
    }

    /// <inheritdoc />
    public override void Delete(ComponentMetadataItemHeader obj)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            if (ComponentMetadataItemHeaderManager.CuNCKDBfL7oOjRHBB79p((object) obj) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 1 : 1;
              continue;
            }
            base.Delete(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_5:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(-951514650 ^ -951453250)));
    }

    /// <inheritdoc />
    public virtual long GetPublishingVersionNumber(long headerId)
    {
      int num1 = 3;
      object obj;
      while (true)
      {
        int num2 = num1;
        string str;
        ITransformationProvider service;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj is DBNull)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              service = Locator.GetService<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 5;
              continue;
            case 3:
              if (headerId > 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 2;
                continue;
              }
              goto label_8;
            case 4:
              obj = ComponentMetadataItemHeaderManager.QHU0SuBQFP7xEyiT19pU((object) ((IQuery) ComponentMetadataItemHeaderManager.q5EX2EBfzf19DWbOHvBX((object) this.Session, (object) str)).CleanUpCache(false));
              num2 = 6;
              continue;
            case 5:
              goto label_14;
            case 6:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            case 7:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_14:
        str = (string) ComponentMetadataItemHeaderManager.tmO7GvBfc8EE1935DZHR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199918251), service != null ? (object) ((Dialect) ComponentMetadataItemHeaderManager.zGNhc3Bfsqn7MNRQxpD9((object) service)).QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876084195)) : ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(1251470110 >> 2 ^ 312822901), (object) headerId);
        num1 = 4;
      }
label_3:
      return 1;
label_4:
      return Convert.ToInt64(obj) + 1L;
label_8:
      return 1;
    }

    /// <inheritdoc />
    public IEnumerable<ComponentMetadataItemHeader> GetAllPublished() => (IEnumerable<ComponentMetadataItemHeader>) this.CreateCriteria(FetchOptions.All, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Published)).List<ComponentMetadataItemHeader>();

    /// <inheritdoc />
    public IEnumerable<ComponentMetadataItemHeader> GetAllDrafts() => (IEnumerable<ComponentMetadataItemHeader>) this.CreateCriteria(FetchOptions.All, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Draft)).List<ComponentMetadataItemHeader>();

    /// <inheritdoc />
    [Transaction]
    public virtual void Delete(long headerId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentMetadataItemHeaderManager.qIesnQBQBvmie0b048ii((object) this.Load(headerId));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <inheritdoc />
    public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage) => this.ValidateName((ICriterion) Restrictions.Eq(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), name, out errorMessage);

    /// <inheritdoc />
    public virtual bool ValidateDisplayName(
      Guid headerUid,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) ComponentMetadataItemHeaderManager.bZdle1BQW4MVox9OQvyy((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), displayName, out errorMessage);
    }

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор</param>
    /// <param name="groupUid">Идентификатор группы</param>
    /// <returns>Заголовок метаданных</returns>
    public ComponentMetadataItemHeader Edit(Guid uid, Guid groupUid)
    {
      int num = 1;
      ComponentMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataItemHeader = this.Load(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            this.Save(metadataItemHeader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 3;
            continue;
          case 3:
            goto label_3;
          default:
            ComponentMetadataItemHeaderManager.zwBUvNBQbT9n7qEbKq4i((object) metadataItemHeader, (object) ((AbstractNHEntityManager<MetadataItemGroupUI, long>) ComponentMetadataItemHeaderManager.yF0ngIBQoPNsLgCWZfrC()).LoadOrNull(groupUid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return metadataItemHeader;
    }

    /// <inheritdoc />
    public IEnumerable<ComponentMetadataItemHeader> SortByDependencies(
      IEnumerable<ComponentMetadataItemHeader> headers)
    {
      List<Guid> guidList = new List<Guid>();
      HashSet<Guid> visited = new HashSet<Guid>();
      // ISSUE: reference to a compiler-generated method
      List<Guid> list1 = headers.Select<ComponentMetadataItemHeader, Guid>((Func<ComponentMetadataItemHeader, Guid>) (h => ComponentMetadataItemHeaderManager.\u003C\u003Ec.nFngrFQb5ikDGSWbTtEb((object) h))).ToList<Guid>();
      Dictionary<Guid, ISet<Guid>> dependencies = new Dictionary<Guid, ISet<Guid>>();
      // ISSUE: reference to a compiler-generated method
      List<ComponentMetadataItem> list2 = headers.Select<ComponentMetadataItemHeader, ComponentMetadataItem>((Func<ComponentMetadataItemHeader, ComponentMetadataItem>) (header => (ComponentMetadataItem) ComponentMetadataItemHeaderManager.\u003C\u003Ec.Oq1f6gQbjS3u16h9sI5h((object) header))).ToList<ComponentMetadataItem>();
      foreach (ComponentMetadataItem componentMetadataItem in list2)
      {
        Guid uid = componentMetadataItem.Header.Uid;
        if (componentMetadataItem.Metadata is ComponentMetadata metadata && metadata.Content?.View != null)
        {
          // ISSUE: reference to a compiler-generated method
          HashSet<Guid> hashSet = metadata.Content.View.GetAllItems(false).OfType<ComponentViewItem>().Select<ComponentViewItem, Guid>((Func<ComponentViewItem, Guid>) (c => ComponentMetadataItemHeaderManager.\u003C\u003Ec.xS5ItbQbYylJYoKOeYfZ((object) c))).ToHashSet<Guid>();
          hashSet.IntersectWith((IEnumerable<Guid>) list1);
          if (hashSet.Count > 0)
          {
            dependencies.Add(uid, (ISet<Guid>) hashSet);
            continue;
          }
        }
        visited.Add(uid);
        guidList.Add(uid);
      }
      foreach (KeyValuePair<Guid, ISet<Guid>> keyValuePair in dependencies)
        this.SortByDependenciesVisit(keyValuePair.Key, (IDictionary<Guid, ISet<Guid>>) dependencies, (ISet<Guid>) visited, (ICollection<Guid>) guidList);
      // ISSUE: reference to a compiler-generated method
      Dictionary<Guid, ComponentMetadataItem> dic = list2.ToDictionary<ComponentMetadataItem, Guid, ComponentMetadataItem>((Func<ComponentMetadataItem, Guid>) (i => ((ComponentMetadataItemHeader) ComponentMetadataItemHeaderManager.\u003C\u003Ec.jyRkMdQbL0MsXkQA5AV7((object) i)).Uid), (Func<ComponentMetadataItem, ComponentMetadataItem>) (i => i));
      // ISSUE: reference to a compiler-generated method
      return guidList.Select<Guid, ComponentMetadataItemHeader>((Func<Guid, ComponentMetadataItemHeader>) (uid => (ComponentMetadataItemHeader) ComponentMetadataItemHeaderManager.\u003C\u003Ec__DisplayClass14_0.w3wDf7Qb9FNMQh785im7((object) dic[uid])));
    }

    /// <inheritdoc />
    public static void UpdateCalculateScriptDynamicProperties(ComponentMetadata metadata)
    {
      int num1 = 8;
      List<ComputedValue>.Enumerator enumerator1;
      IEnumerator<ToolbarItem> enumerator2;
      while (true)
      {
        int num2 = num1;
        List<PropertyMetadata>.Enumerator enumerator3;
        while (true)
        {
          FormViewItem second;
          IEnumerator<ViewItem> enumerator4;
          switch (num2)
          {
            case 1:
              goto label_54;
            case 2:
              enumerator4 = second.GetAllItems(false).Concat<ViewItem>((ViewItem) second).GetEnumerator();
              num2 = 5;
              continue;
            case 3:
              goto label_75;
            case 4:
label_79:
              second = (FormViewItem) ComponentMetadataItemHeaderManager.tCh4y4BQC3k4ky5SFmS1(ComponentMetadataItemHeaderManager.WRdEAFBQhdSdO2T46cOZ((object) metadata));
              num2 = 2;
              continue;
            case 5:
              try
              {
label_46:
                if (ComponentMetadataItemHeaderManager.s2o74fBQvkQoQSUtg8yN((object) enumerator4))
                  goto label_44;
                else
                  goto label_47;
label_32:
                int num3;
                switch (num3)
                {
                  case 1:
                    goto label_27;
                  case 2:
                    break;
                  case 3:
                    goto label_46;
                  default:
                    try
                    {
label_38:
                      if (enumerator1.MoveNext())
                        goto label_36;
                      else
                        goto label_39;
label_35:
                      int num4;
                      switch (num4)
                      {
                        case 1:
                          goto label_38;
                        case 2:
                          goto label_46;
                      }
label_36:
                      ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue) enumerator1.Current, ComponentMetadataItemHeaderManager.P3HFOqBQfD44gnK4rjCl((object) metadata));
                      num4 = 1;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                      {
                        num4 = 1;
                        goto label_35;
                      }
                      else
                        goto label_35;
label_39:
                      num4 = 2;
                      goto label_35;
                    }
                    finally
                    {
                      enumerator1.Dispose();
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
                        num5 = 0;
                      switch (num5)
                      {
                        default:
                      }
                    }
                }
label_44:
                enumerator1 = enumerator4.Current.DynamicProperties.GetEnumerator();
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
                {
                  num3 = 0;
                  goto label_32;
                }
                else
                  goto label_32;
label_47:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 1;
                goto label_32;
              }
              finally
              {
                int num6;
                if (enumerator4 == null)
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                else
                  goto label_51;
label_50:
                switch (num6)
                {
                  case 2:
                    break;
                  default:
                }
label_51:
                ComponentMetadataItemHeaderManager.DP9WxIBQ8HCG7t1qAAdn((object) enumerator4);
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
                {
                  num6 = 0;
                  goto label_50;
                }
                else
                  goto label_50;
              }
            case 6:
              enumerator2 = second.Toolbar.GetAllItems(false).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 1;
              continue;
            case 7:
              try
              {
label_16:
                if (enumerator3.MoveNext())
                  goto label_21;
                else
                  goto label_17;
label_4:
                IViewModelPropertyMetadata current;
                int num7;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_5;
                    case 2:
                      enumerator1 = current.ComputedValues.GetEnumerator();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
                      continue;
                    case 3:
                      ComponentMetadataItemHeaderManager.mrdgj6BQQQTcqS5UlckS(ComponentMetadataItemHeaderManager.tTO58kBQEVZiBsI9qDhS((object) current), ComponentMetadataItemHeaderManager.P3HFOqBQfD44gnK4rjCl((object) metadata));
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 2 : 0;
                      continue;
                    case 4:
                      goto label_16;
                    case 5:
                      goto label_79;
                    case 6:
                      goto label_21;
                    default:
                      if (current != null)
                      {
                        num7 = 3;
                        continue;
                      }
                      goto label_16;
                  }
                }
label_5:
                try
                {
label_7:
                  if (enumerator1.MoveNext())
                    goto label_9;
                  else
                    goto label_8;
label_6:
                  int num8;
                  switch (num8)
                  {
                    case 1:
                      goto label_16;
                    case 2:
                      goto label_9;
                    default:
                      goto label_7;
                  }
label_8:
                  num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
                  goto label_6;
label_9:
                  ComponentMetadataItemHeaderManager.mrdgj6BQQQTcqS5UlckS((object) enumerator1.Current, ComponentMetadataItemHeaderManager.P3HFOqBQfD44gnK4rjCl((object) metadata));
                  num8 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                  {
                    num8 = 0;
                    goto label_6;
                  }
                  else
                    goto label_6;
                }
                finally
                {
                  enumerator1.Dispose();
                  int num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
                    num9 = 0;
                  switch (num9)
                  {
                    default:
                  }
                }
label_17:
                num7 = 5;
                goto label_4;
label_21:
                current = enumerator3.Current as IViewModelPropertyMetadata;
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                {
                  num7 = 0;
                  goto label_4;
                }
                else
                  goto label_4;
              }
              finally
              {
                enumerator3.Dispose();
                int num10 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                  num10 = 0;
                switch (num10)
                {
                  default:
                }
              }
            case 8:
              goto label_29;
          }
label_27:
          if (ComponentMetadataItemHeaderManager.dUxdyVBQZqrsQTDB57h6((object) second) != null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 6;
          else
            goto label_70;
        }
label_29:
        enumerator3 = ((ClassMetadata) ComponentMetadataItemHeaderManager.LJYprBBQGPyyZJKbRCjC(ComponentMetadataItemHeaderManager.WRdEAFBQhdSdO2T46cOZ((object) metadata))).Properties.GetEnumerator();
        num1 = 7;
      }
label_75:
      return;
label_70:
      return;
label_54:
      try
      {
label_67:
        if (ComponentMetadataItemHeaderManager.s2o74fBQvkQoQSUtg8yN((object) enumerator2))
          goto label_69;
        else
          goto label_68;
label_55:
        int num11;
        switch (num11)
        {
          case 1:
            goto label_69;
          case 2:
            try
            {
label_60:
              if (enumerator1.MoveNext())
                goto label_58;
              else
                goto label_61;
label_57:
              int num12;
              switch (num12)
              {
                case 1:
                  break;
                case 2:
                  goto label_67;
                default:
                  goto label_60;
              }
label_58:
              ComponentMetadataItemHeaderManager.mrdgj6BQQQTcqS5UlckS((object) enumerator1.Current, metadata.Uid);
              num12 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
              {
                num12 = 0;
                goto label_57;
              }
              else
                goto label_57;
label_61:
              num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 1 : 2;
              goto label_57;
            }
            finally
            {
              enumerator1.Dispose();
              int num13 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
                num13 = 0;
              switch (num13)
              {
                default:
              }
            }
          case 3:
            return;
          default:
            goto label_67;
        }
label_68:
        num11 = 3;
        goto label_55;
label_69:
        enumerator1 = enumerator2.Current.DynamicProperties.GetEnumerator();
        num11 = 2;
        goto label_55;
      }
      finally
      {
        if (enumerator2 != null)
        {
          int num14 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
            num14 = 1;
          while (true)
          {
            switch (num14)
            {
              case 1:
                ComponentMetadataItemHeaderManager.DP9WxIBQ8HCG7t1qAAdn((object) enumerator2);
                num14 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                continue;
              default:
                goto label_77;
            }
          }
        }
label_77:;
      }
    }

    /// <summary>Добавить системный компонент</summary>
    /// <param name="header">Системный компонент</param>
    internal void AddSystemComponent(ComponentMetadataItemHeader header)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentMetadataItemHeaderManager.SystemComponents.Add(header.Uid, header);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Критерия валидации наименования</summary>
    /// <param name="name">Наименование</param>
    /// <returns>Критерия</returns>
    internal virtual ICriteria ValidateNameCriteria(string name) => (ICriteria) ComponentMetadataItemHeaderManager.DpG3dOBQiV6WR1pvDCHX((object) ((ICriteria) ComponentMetadataItemHeaderManager.f0UvQQBQum4PonP5fCZY((object) this, (object) null)).Add((ICriterion) ComponentMetadataItemHeaderManager.vSgSMpBQVQuA9FeBpBkt(ComponentMetadataItemHeaderManager.KPD0nMBQIa3WOeRtiIdL((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name), (object) name)), (object) new IProjection[1]
    {
      (IProjection) ComponentMetadataItemHeaderManager.Jqk1sTBQSyDBVoHhKZ5w((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Id)
    });

    private bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              goto label_19;
            case 3:
              errorMessage = (string) null;
              num2 = 4;
              continue;
            case 4:
              goto label_3;
            case 5:
              goto label_5;
            case 6:
              goto label_7;
            case 7:
              errorMessage = (string) ComponentMetadataItemHeaderManager.Qg10hGBQqvErDI81ibAE(ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(372753449 ^ 372716915));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 6 : 1;
              continue;
            case 8:
              if (Convert.ToInt64(ComponentMetadataItemHeaderManager.LR00leBQTRP5dmXX40LZ(ComponentMetadataItemHeaderManager.USvYVLBfYINXdeyh25s7(ComponentMetadataItemHeaderManager.mqtUmMBQXH4G10I5Fbeu((object) this, (object) name), (object) Restrictions.Not(compareCriterion)))) > 0L)
              {
                num2 = 10;
                continue;
              }
              goto label_14;
            case 9:
              goto label_16;
            case 10:
              errorMessage = EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(-1380439818 << 3 ^ 1841411580), (object) name);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 1 : 1;
              continue;
            case 11:
              if (!string.IsNullOrEmpty(name))
              {
                if (ComponentMetadataItemHeaderManager.WviwDhBQKKSBJxaC2h4C((object) name))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 8 : 3;
                  continue;
                }
                break;
              }
              num2 = 7;
              continue;
            case 12:
              ComponentMetadataItemHeaderManager.ULp13lBQRdEe6g7JfUFh((object) compareCriterion, ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(1669371371 ^ 1669358813));
              num2 = 11;
              continue;
          }
          errorMessage = EleWise.ELMA.SR.T((string) ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(-710283084 ^ -537863435 ^ 173661131), (object) name);
          num2 = 2;
        }
label_14:
        if (ComponentMetadataItemHeaderManager.oLxHvnBQnmFnWwF2y6ts(ComponentMetadataItemHeaderManager.LR00leBQTRP5dmXX40LZ(ComponentMetadataItemHeaderManager.cMQoRhBQkPNbgQTiciP5((object) Locator.GetServiceNotNull<FormMetadataItemHeaderManager>(), (object) name))) <= 0L)
        {
          num1 = 3;
          continue;
        }
label_16:
        errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874032153), (object) name);
        num1 = 5;
      }
label_3:
      return true;
label_5:
      return false;
label_7:
      return false;
label_13:
      return false;
label_19:
      return false;
    }

    private bool ValidateDisplayName(
      ICriterion compareCriterion,
      string displayName,
      out string errorMessage)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) compareCriterion, (string) ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(-688192331 - 435440695 ^ -1123661496));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            errorMessage = (string) null;
            num = 5;
            continue;
          case 4:
            if (ComponentMetadataItemHeaderManager.oLxHvnBQnmFnWwF2y6ts(((ICriteria) ComponentMetadataItemHeaderManager.DpG3dOBQiV6WR1pvDCHX(ComponentMetadataItemHeaderManager.USvYVLBfYINXdeyh25s7(ComponentMetadataItemHeaderManager.USvYVLBfYINXdeyh25s7(ComponentMetadataItemHeaderManager.f0UvQQBQum4PonP5fCZY((object) this, (object) null), ComponentMetadataItemHeaderManager.oEYFaiBQ2MM3rJC56Opv((object) compareCriterion)), ComponentMetadataItemHeaderManager.vSgSMpBQVQuA9FeBpBkt(ComponentMetadataItemHeaderManager.KPD0nMBQIa3WOeRtiIdL((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.DisplayName), (object) displayName)), (object) new IProjection[1]
            {
              (IProjection) ComponentMetadataItemHeaderManager.Jqk1sTBQSyDBVoHhKZ5w((object) ComponentMetadataItemHeaderManager._Resources_PropertyNames.Id)
            })).UniqueResult()) > 0L)
            {
              errorMessage = (string) ComponentMetadataItemHeaderManager.Qg10hGBQqvErDI81ibAE((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654260635));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 2;
              continue;
            }
            num = 3;
            continue;
          case 5:
            goto label_3;
          case 6:
            goto label_10;
          case 7:
            errorMessage = (string) ComponentMetadataItemHeaderManager.Qg10hGBQqvErDI81ibAE(ComponentMetadataItemHeaderManager.dmwtb8BfU3qZn7oh2BkQ(322893104 - -1992822529 ^ -1979189611));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 6 : 5;
            continue;
          default:
            if (!ComponentMetadataItemHeaderManager.bYuMSqBQOVI87ml74Wrw((object) displayName))
            {
              num = 4;
              continue;
            }
            goto case 7;
        }
      }
label_3:
      return true;
label_7:
      return false;
label_10:
      return false;
    }

    /// <summary>Рекурсивное вычисление порядка зависимостей</summary>
    private void SortByDependenciesVisit(
      Guid node,
      IDictionary<Guid, ISet<Guid>> dependencies,
      ISet<Guid> visited,
      ICollection<Guid> result)
    {
      if (visited.Contains(node))
        return;
      visited.Add(node);
      foreach (Guid node1 in (IEnumerable<Guid>) dependencies[node])
        this.SortByDependenciesVisit(node1, dependencies, visited, result);
      result.Add(node);
    }

    public ComponentMetadataItemHeaderManager()
    {
      ComponentMetadataItemHeaderManager.fjYoqfBQevcvd5f6BqCG();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ComponentMetadataItemHeaderManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataItemHeaderManager.SystemComponents = new Dictionary<Guid, ComponentMetadataItemHeader>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool ReKQUOBfrysg5WV5qriM() => ComponentMetadataItemHeaderManager.EYHJlfBflFZgVwpHWPbw == null;

    internal static ComponentMetadataItemHeaderManager F2HpjfBfg6ZQgiKOUl4P() => ComponentMetadataItemHeaderManager.EYHJlfBflFZgVwpHWPbw;

    internal static void b5XHKWBf5bWdvipJGD00([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((EntityManager<ComponentMetadataItemHeader, long>) obj0).SetupFilter((ICriteria) obj1, (IEntityFilter) obj2));

    internal static object yXLoUoBfjv0xkkPYDP90([In] object obj0) => (object) Restrictions.IsNotNull((string) obj0);

    internal static object USvYVLBfYINXdeyh25s7([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object CuNCKDBfL7oOjRHBB79p([In] object obj0) => (object) ((ComponentMetadataItemHeader) obj0).Published;

    internal static object dmwtb8BfU3qZn7oh2BkQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object zGNhc3Bfsqn7MNRQxpD9([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object tmO7GvBfc8EE1935DZHR([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object q5EX2EBfzf19DWbOHvBX([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object QHU0SuBQFP7xEyiT19pU([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static void qIesnQBQBvmie0b048ii([In] object obj0) => ((Entity<long>) obj0).Delete();

    internal static object bZdle1BQW4MVox9OQvyy([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object yF0ngIBQoPNsLgCWZfrC() => (object) MetadataItemGroupUIManager.Instance;

    internal static void zwBUvNBQbT9n7qEbKq4i([In] object obj0, [In] object obj1) => ((ComponentMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static object WRdEAFBQhdSdO2T46cOZ([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object LJYprBBQGPyyZJKbRCjC([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object tTO58kBQEVZiBsI9qDhS([In] object obj0) => (object) ((IViewModelPropertyMetadata) obj0).ComputedValue;

    internal static Guid P3HFOqBQfD44gnK4rjCl([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void mrdgj6BQQQTcqS5UlckS([In] object obj0, Guid metadataUid) => ComputedValueHelper.SetCalculateScriptMethodName((IComputedValue) obj0, metadataUid);

    internal static object tCh4y4BQC3k4ky5SFmS1([In] object obj0) => (object) ((ComponentContentMetadata) obj0).View;

    internal static bool s2o74fBQvkQoQSUtg8yN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void DP9WxIBQ8HCG7t1qAAdn([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object dUxdyVBQZqrsQTDB57h6([In] object obj0) => (object) ((FormViewItem) obj0).Toolbar;

    internal static object f0UvQQBQum4PonP5fCZY([In] object obj0, [In] object obj1) => (object) ((EntityManager<ComponentMetadataItemHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object KPD0nMBQIa3WOeRtiIdL([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object vSgSMpBQVQuA9FeBpBkt([In] object obj0, [In] object obj1) => (object) ElmaRestrictions.InsensitiveLike((IProjection) obj0, obj1);

    internal static object Jqk1sTBQSyDBVoHhKZ5w([In] object obj0) => (object) Projections.Count((string) obj0);

    internal static object DpG3dOBQiV6WR1pvDCHX([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static void ULp13lBQRdEe6g7JfUFh([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object Qg10hGBQqvErDI81ibAE([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool WviwDhBQKKSBJxaC2h4C([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object mqtUmMBQXH4G10I5Fbeu([In] object obj0, [In] object obj1) => (object) ((ComponentMetadataItemHeaderManager) obj0).ValidateNameCriteria((string) obj1);

    internal static object LR00leBQTRP5dmXX40LZ([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static object cMQoRhBQkPNbgQTiciP5([In] object obj0, [In] object obj1) => (object) ((FormMetadataItemHeaderManager) obj0).ValidateNameCriteria((string) obj1);

    internal static long oLxHvnBQnmFnWwF2y6ts([In] object obj0) => Convert.ToInt64(obj0);

    internal static bool bYuMSqBQOVI87ml74Wrw([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object oEYFaiBQ2MM3rJC56Opv([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static void fjYoqfBQevcvd5f6BqCG() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class _Resources_PropertyNames
    {
      public static readonly string Id;
      public static readonly string Uid;
      public static readonly string Name;
      public static readonly string DisplayName;
      public static readonly string MetadataTypeUid;
      public static readonly string Published;
      public static readonly string Draft;
      internal static ComponentMetadataItemHeaderManager._Resources_PropertyNames OIAytpQbAwsauIKAFyKk;

      static _Resources_PropertyNames()
      {
        int num = 6;
        while (true)
        {
          switch (num)
          {
            case 1:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.Published = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(-70007027 ^ -70141545);
              num = 4;
              continue;
            case 2:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.MetadataTypeUid = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(1021410165 ^ 1021579415);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_2;
            case 4:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.Draft = z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669347351);
              num = 3;
              continue;
            case 5:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.Id = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(589593376 ^ -1977315327 ^ -1459590529);
              num = 7;
              continue;
            case 6:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.QisjySQb05Tf3rTyoPBg();
              num = 5;
              continue;
            case 7:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(1470440286 ^ 1470450892);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            case 8:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.DisplayName = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(993438473 ^ 993287613);
              num = 2;
              continue;
            default:
              ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name = (string) ComponentMetadataItemHeaderManager._Resources_PropertyNames.LILyqdQbm0br1TuAWLLZ(1033719030 - 2012070891 ^ -978322741);
              num = 8;
              continue;
          }
        }
label_2:;
      }

      internal static void QisjySQb05Tf3rTyoPBg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object LILyqdQbm0br1TuAWLLZ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool F5xlOJQb7bVceR48HoZH() => ComponentMetadataItemHeaderManager._Resources_PropertyNames.OIAytpQbAwsauIKAFyKk == null;

      internal static ComponentMetadataItemHeaderManager._Resources_PropertyNames bCPH0ZQbxP0odnC6NTc3() => ComponentMetadataItemHeaderManager._Resources_PropertyNames.OIAytpQbAwsauIKAFyKk;
    }
  }
}

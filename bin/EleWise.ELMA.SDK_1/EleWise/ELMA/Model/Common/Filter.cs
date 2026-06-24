// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.Filter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Common
{
  /// <summary>Фильтр (базовый класс)</summary>
  public class Filter : IEntityFilter
  {
    private QueryParameters queryParameters;
    private static Filter Xev1eehTmpXcaC7oJODq;

    /// <summary>Строка поиска</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public string SearchString
    {
      get => this.\u003CSearchString\u003Ek__BackingField;
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
              this.\u003CSearchString\u003Ek__BackingField = value;
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
    }

    /// <summary>Фильтрация по подтипу</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public Type Subtype
    {
      get => this.\u003CSubtype\u003Ek__BackingField;
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
              this.\u003CSubtype\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    /// <summary>Привилегия для фильтрации</summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public Guid? PermissionId { get; set; }

    /// <summary>Пользователь для которого проверяется привилегия</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public IUser PermissionUser
    {
      get => this.\u003CPermissionUser\u003Ek__BackingField;
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
              this.\u003CPermissionUser\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
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

    /// <summary>Отключить проверку безопасности для выборки</summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public bool DisableSecurity
    {
      get => this.\u003CDisableSecurity\u003Ek__BackingField;
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
              this.\u003CDisableSecurity\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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
    /// Показать все, даже удаленные (работает в  случае если сущность ISoftDeletable)
    /// </summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public bool DisableSoftDeletable
    {
      get => this.\u003CDisableSoftDeletable\u003Ek__BackingField;
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
              this.\u003CDisableSoftDeletable\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
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
    /// Пропустить проверку на админовскую привилегию IInstanceSettingsPermission.AdminPermission
    /// </summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public bool SkipAdminPermission
    {
      get => this.\u003CSkipAdminPermission\u003Ek__BackingField;
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
              this.\u003CSkipAdminPermission\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
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

    /// <summary>Идентификатор объекта</summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public object Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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

    /// <summary>Родительский объект для иерархических справочников</summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public object HierarchyParent
    {
      get => this.\u003CHierarchyParent\u003Ek__BackingField;
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
              this.\u003CHierarchyParent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
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
    /// Нужно ли фильтровать по родительскому объекту для иерархических справочников
    /// </summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public bool FilterByHierarchyParent
    {
      get => this.\u003CFilterByHierarchyParent\u003Ek__BackingField;
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
              this.\u003CFilterByHierarchyParent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
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
    /// Отключить автоматическое формирование критериев по фильтру
    /// </summary>
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    public bool DisableAutoFilter
    {
      get => this.\u003CDisableAutoFilter\u003Ek__BackingField;
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
              this.\u003CDisableAutoFilter\u003Ek__BackingField = value;
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
    }

    /// <summary>Показывать при выборе только группы</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public bool ShowOnlyGroups
    {
      get => this.\u003CShowOnlyGroups\u003Ek__BackingField;
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
              this.\u003CShowOnlyGroups\u003Ek__BackingField = value;
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

    /// <summary>
    /// Искать во вложениях при полнотекстовом поиске в индексе
    /// </summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    [DisplayName(typeof (__Resources_Filter), "P_FullTextInAttachments_DisplayName")]
    public bool FullTextInAttachments
    {
      get => this.\u003CFullTextInAttachments\u003Ek__BackingField;
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
              this.\u003CFullTextInAttachments\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    /// <summary>Условие выборки на языке EQL</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public string Query
    {
      get => this.\u003CQuery\u003Ek__BackingField;
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
              this.\u003CQuery\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Параметры в EQL фильтре</summary>
    [View(ViewType = ViewType.List, Visibility = Visibility.ForceHidden)]
    [View(ViewType = ViewType.All, Visibility = Visibility.Hidden)]
    public QueryParameters QueryParameters => this.queryParameters;

    /// <summary>Фильтр пуст или нет</summary>
    /// <returns></returns>
    public virtual bool IsEmpty()
    {
      int num1 = 4;
      // ISSUE: variable of a compiler-generated type
      Filter.\u003C\u003Ec__DisplayClass58_0 cDisplayClass580;
      List<ISkipFilterEmptyProperty> list;
      bool flag;
      List<PropertyMetadata>.Enumerator enumerator;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_34;
            case 2:
              goto label_4;
            case 3:
              if (string.IsNullOrWhiteSpace(this.Query))
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 4:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass580 = new Filter.\u003C\u003Ec__DisplayClass58_0();
              num2 = 3;
              continue;
            case 5:
              goto label_5;
            default:
              goto label_3;
          }
        }
label_4:
        List<PropertyMetadata> propertyMetadataList = new List<PropertyMetadata>();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass580.metadata = (ClassMetadata) MetadataLoader.LoadMetadata(Filter.JVCSaHhTJD0d4fljedYb((object) this));
        // ISSUE: reference to a compiler-generated field
        propertyMetadataList.AddRange((IEnumerable<PropertyMetadata>) cDisplayClass580.metadata.Properties);
        list = ((ComponentManager) Filter.cKMUnfhT9Ji1cqYk2Ae5()).GetExtensionPoints<ISkipFilterEmptyProperty>().ToList<ISkipFilterEmptyProperty>();
        flag = true;
        enumerator = propertyMetadataList.GetEnumerator();
        num1 = 5;
      }
label_3:
      return false;
label_5:
      try
      {
label_10:
        if (enumerator.MoveNext())
          goto label_17;
        else
          goto label_11;
label_6:
        int num3;
        int num4 = num3;
label_7:
        // ISSUE: variable of a compiler-generated type
        Filter.\u003C\u003Ec__DisplayClass58_1 cDisplayClass581;
        PropertyInfo reflectionProperty;
        object obj;
        PropertyMetadata current;
        ITypeDescriptor typeDescriptor;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (!(reflectionProperty == (PropertyInfo) null))
              {
                num4 = 16;
                continue;
              }
              goto label_10;
            case 2:
              // ISSUE: reference to a compiler-generated field
              reflectionProperty = this.GetType().GetReflectionProperty((string) Filter.DfLrxVhTgG3wQpWpmFpB((object) cDisplayClass581.pm));
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
              continue;
            case 3:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass581 = new Filter.\u003C\u003Ec__DisplayClass58_1();
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 11 : 14;
              continue;
            case 4:
              if (typeDescriptor == null)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 5:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              typeDescriptor = (ITypeDescriptor) Filter.HEP29ZhTrV2Tm6aqyImp(Filter.HMo5PkhTdyZkP1ocTPMs(), Filter.DY8DUxhTl2mHUP2SApmu((object) cDisplayClass581.pm), cDisplayClass581.pm.SubTypeUid);
              num4 = 4;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated method
              if (list.FirstOrDefault<ISkipFilterEmptyProperty>(new Func<ISkipFilterEmptyProperty, bool>(cDisplayClass581.\u003CIsEmpty\u003Eb__0)) == null)
              {
                num4 = 5;
                continue;
              }
              goto label_10;
            case 7:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass581.pm = current;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 6 : 5;
              continue;
            case 9:
              goto label_8;
            case 10:
            case 15:
              goto label_34;
            case 12:
              // ISSUE: reference to a compiler-generated field
              if (Filter.yZWg8fhTjptg6FSAN674((object) typeDescriptor, (object) cDisplayClass581.pm, obj))
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 2 : 11;
                continue;
              }
              goto label_8;
            case 13:
              goto label_17;
            case 14:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass581.CS\u0024\u003C\u003E8__locals1 = cDisplayClass580;
              num4 = 7;
              continue;
            case 16:
              obj = Filter.dQoSAWhT5XBl9QtCA6i4((object) reflectionProperty, (object) this, (object) null);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 4 : 12;
              continue;
            default:
              goto label_10;
          }
        }
label_8:
        flag = false;
        num3 = 15;
        goto label_6;
label_11:
        num3 = 10;
        goto label_6;
label_17:
        current = enumerator.Current;
        num4 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num4 = 0;
          goto label_7;
        }
        else
          goto label_7;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
label_34:
      return flag;
    }

    public Filter()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.queryParameters = new QueryParameters();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool CZt1k5hTyuB735hoyaPd() => Filter.Xev1eehTmpXcaC7oJODq == null;

    internal static Filter YIBI8XhTMr1GxZZFYvYI() => Filter.Xev1eehTmpXcaC7oJODq;

    internal static Type JVCSaHhTJD0d4fljedYb([In] object obj0) => obj0.GetType();

    internal static object cKMUnfhT9Ji1cqYk2Ae5() => (object) ComponentManager.Current;

    internal static object HMo5PkhTdyZkP1ocTPMs() => (object) MetadataServiceContext.Service;

    internal static Guid DY8DUxhTl2mHUP2SApmu([In] object obj0) => ((PropertyMetadata) obj0).TypeUid;

    internal static object HEP29ZhTrV2Tm6aqyImp([In] object obj0, Guid typeUid, Guid subTypeUid) => (object) ((IMetadataService) obj0).GetTypeDescriptor(typeUid, subTypeUid);

    internal static object DfLrxVhTgG3wQpWpmFpB([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object dQoSAWhT5XBl9QtCA6i4([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static bool yZWg8fhTjptg6FSAN674([In] object obj0, [In] object obj1, [In] object obj2) => ((ITypeDescriptor) obj0).IsEmptyOrDefault((PropertyMetadata) obj1, obj2);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.ComponentDynamicFormProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Dependencies.Analyzers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Провайдер для формы страниц 2-го рантайма</summary>
  [Component]
  internal class ComponentDynamicFormProvider : IDynamicFormsProvider
  {
    private readonly IEnumerable<IObjectFormProvider> objectFormProviders;
    /// <summary>Идентификатор провайдера</summary>
    public static readonly Guid UID;
    internal static ComponentDynamicFormProvider kFP1hRUNMLFgtbr42nL;

    /// <summary>Ctor</summary>
    /// <param name="objectFormProviders">Провайдеры форм</param>
    public ComponentDynamicFormProvider(
      IEnumerable<IObjectFormProvider> objectFormProviders)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.objectFormProviders = objectFormProviders;
    }

    /// <inheritdoc />
    public Guid Uid => ComponentDynamicFormProvider.UID;

    /// <inheritdoc />
    public void ExecuteScript(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string scriptName,
      DynamicFormResultData resultData)
    {
    }

    /// <inheritdoc />
    public Type GetEntityType(DynamicFormSettings settings)
    {
      int num1 = 4;
      object obj;
      while (true)
      {
        int num2 = num1;
        (Guid, Guid) data;
        IObjectFormProvider objectFormProvider;
        ClassMetadata classMetadata;
        Guid typeUid;
        Guid subTypeUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 2;
                continue;
              }
              goto label_15;
            case 2:
              goto label_10;
            case 3:
              data = this.ParseData((string) ComponentDynamicFormProvider.XhOpOZUa8kDiAuLL6Bn((object) settings));
              num2 = 6;
              continue;
            case 4:
              num2 = 3;
              continue;
            case 5:
              goto label_16;
            case 6:
              goto label_3;
            case 7:
              subTypeUid = data.Item2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 8;
              continue;
            case 8:
              // ISSUE: reference to a compiler-generated method
              objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (p => ComponentDynamicFormProvider.\u003C\u003Ec__DisplayClass6_0.NoxnTafUtStMAELShi3d((object) p, typeUid, subTypeUid)));
              num2 = 9;
              continue;
            case 9:
              if (objectFormProvider != null)
              {
                (obj, classMetadata) = objectFormProvider.GetObjectInfo(typeUid, subTypeUid, string.Empty);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            case 10:
              goto label_15;
            default:
              goto label_4;
          }
        }
label_3:
        typeUid = data.Item1;
        num1 = 7;
        continue;
label_10:
        if (classMetadata != null)
          num1 = 5;
        else
          goto label_15;
      }
label_4:
      return (Type) null;
label_15:
      return (Type) null;
label_16:
      return obj.GetType();
    }

    /// <inheritdoc />
    public string GetPropertyValueChangeScriptName(
      IEntity entity,
      RootViewItem view,
      DynamicFormSettings settings,
      string propertyName)
    {
      return string.Empty;
    }

    /// <summary>Получить объект в свойстве</summary>
    /// <param name="settings">Настройки</param>
    /// <param name="obj">Корневой объект</param>
    /// <param name="propertyUid">Идентификатор выбранного свойства</param>
    /// <param name="propertyParents">Идентификаторы родительских свойств</param>
    /// <returns>Объект</returns>
    public object GetProperty(
      DynamicFormSettings settings,
      object obj,
      Guid propertyUid,
      Guid[] propertyParents)
    {
      int num = 3;
      IPropertyMetadata propertyMetadata;
      (Guid, Guid) data;
      IObjectFormProvider objectFormProvider;
      Guid typeUid;
      Guid subTypeUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            data = this.ParseData((string) ComponentDynamicFormProvider.XhOpOZUa8kDiAuLL6Bn((object) settings));
            num = 7;
            continue;
          case 3:
            num = 2;
            continue;
          case 4:
            objectFormProvider = this.objectFormProviders.FirstOrDefault<IObjectFormProvider>((Func<IObjectFormProvider, bool>) (p => p.Check(typeUid, subTypeUid)));
            num = 5;
            continue;
          case 5:
            if (objectFormProvider == null)
            {
              num = 8;
              continue;
            }
            if (objectFormProvider.GetObjectInfo(typeUid, subTypeUid, string.Empty).Item2 is ComponentContextMetadata rootMetadata)
            {
              propertyMetadata = ComponentDynamicFormProvider.FindPropertyMetadata(propertyUid, (object) propertyParents, (object) rootMetadata).Item2;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 6 : 1;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
          case 6:
            goto label_8;
          case 7:
            typeUid = data.Item1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
            continue;
          case 8:
            goto label_12;
          default:
            subTypeUid = data.Item2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 4;
            continue;
        }
      }
label_2:
      return (object) null;
label_8:
      return ComponentDynamicFormProvider.ID8dY5UDsbXg8yAm8hS(obj, (object) propertyMetadata.Name, (object) null);
label_12:
      return (object) null;
    }

    private (Guid, Guid) ParseData(string data)
    {
      string[] strArray = data.Split(';');
      return (new Guid(strArray[0]), new Guid(strArray[1]));
    }

    private static (ClassMetadata, IPropertyMetadata) FindPropertyMetadata(
      Guid propertyUid,
      object propertyParents,
      object rootMetadata)
    {
      switch (propertyParents.Length)
      {
        case 0:
          return ViewItemsAnalyzerHelper.CaseZeroPropertyParents(propertyUid, (ClassMetadata) rootMetadata, (DependencyServiceOptions) null, (Dictionary<Guid, EnumDependency>) null, (Dictionary<Guid, EntityDependency>) null, (Dictionary<Guid, DataClassDependency>) null);
        case 1:
          return ViewItemsAnalyzerHelper.CaseOnePropertyParents(propertyUid, ((IEnumerable<Guid>) propertyParents).ToArray<Guid>(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) null, (Dictionary<Guid, EnumDependency>) null, (Dictionary<Guid, EntityDependency>) null, (Dictionary<Guid, DataClassDependency>) null);
        default:
          return ViewItemsAnalyzerHelper.CaseDefaultPropertyParents(propertyUid, ((IEnumerable<Guid>) propertyParents).ToArray<Guid>(), (ClassMetadata) rootMetadata, (DependencyServiceOptions) null, (Dictionary<Guid, EnumDependency>) null, (Dictionary<Guid, EntityDependency>) null, (Dictionary<Guid, DataClassDependency>) null);
      }
    }

    static ComponentDynamicFormProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ComponentDynamicFormProvider.UID = new Guid((string) ComponentDynamicFormProvider.iLkmZkUtFjjnOQegpNW(~538519529 ^ -538571768));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object XhOpOZUa8kDiAuLL6Bn([In] object obj0) => (object) ((DynamicFormSettings) obj0).DynamicFormsProviderData;

    internal static bool XyOeVdU3cIfuGbsGGw5() => ComponentDynamicFormProvider.kFP1hRUNMLFgtbr42nL == null;

    internal static ComponentDynamicFormProvider bbMff3UpCjF3Tjh1g7a() => ComponentDynamicFormProvider.kFP1hRUNMLFgtbr42nL;

    internal static object ID8dY5UDsbXg8yAm8hS([In] object obj0, [In] object obj1, [In] object obj2) => obj0.GetPropertyValue((string) obj1, obj2);

    internal static object iLkmZkUtFjjnOQegpNW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

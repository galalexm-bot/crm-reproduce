// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.Services.EqlPropertiesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.UI.Scripts.Services
{
  /// <inheritdoc />
  [Service]
  internal class EqlPropertiesService : IEqlPropertiesService
  {
    private readonly IMetadataRuntimeService metadataRuntimeService;
    private static EqlPropertiesService CkI37AUu2xf1R04879R;

    /// <summary>Ctor</summary>
    /// <param name="metadataRuntimeService">Служба управления метаданными в режиме Runtime</param>
    public EqlPropertiesService(IMetadataRuntimeService metadataRuntimeService)
    {
      EqlPropertiesService.eDChmjUSfRtyE1G54Q3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.metadataRuntimeService = metadataRuntimeService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public void SetEqlComputedProperties(
      object source,
      Type sourceType,
      IEnumerable<PropertyMetadata> properties,
      List<SerializedModel> additionalModels)
    {
      this.SetEqlComputedProperties(properties, new Func<PropertyMetadata, object>(GetPropertyValue), new Action<PropertyMetadata, object>(SetPropertyValue), additionalModels);

      object GetPropertyValue(PropertyMetadata property)
      {
        int num = 1;
        System.Reflection.PropertyInfo reflectionProperty;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              reflectionProperty = sourceType.GetReflectionProperty((string) EqlPropertiesService.\u003C\u003Ec__DisplayClass3_0.oCJ6wxfUh2fHU5HJQe5v((object) property));
              if ((object) reflectionProperty == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            default:
              goto label_4;
          }
        }
label_4:
        return (object) null;
label_5:
        // ISSUE: reference to a compiler-generated method
        return EqlPropertiesService.\u003C\u003Ec__DisplayClass3_0.uPVFOLfUGuEGg3VuDPN7((object) reflectionProperty, source, (object) null);
      }

      void SetPropertyValue(PropertyMetadata property, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              object obj = EqlPropertiesService.\u003C\u003Ec__DisplayClass3_0.H6LfgffUEs8EIk353D9D(sourceType, EqlPropertiesService.\u003C\u003Ec__DisplayClass3_0.oCJ6wxfUh2fHU5HJQe5v((object) property));
              if (obj == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
                continue;
              }
              ((System.Reflection.PropertyInfo) obj).SetValue(source, value, (object[]) null);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 2;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_7;
          }
        }
label_5:
        return;
label_2:
        return;
label_7:;
      }
    }

    /// <inheritdoc />
    public void SetEqlComputedProperties(
      DataClass source,
      DataClassMetadata viewModelMetadata,
      List<SerializedModel> additionalModels)
    {
      this.SetEqlComputedProperties((IEnumerable<PropertyMetadata>) viewModelMetadata.Properties, new Func<PropertyMetadata, object>(GetPropertyValue), new Action<PropertyMetadata, object>(SetPropertyValue), additionalModels);

      object GetPropertyValue(PropertyMetadata property) => EqlPropertiesService.\u003C\u003Ec__DisplayClass4_0.MeCrHHfU8yBZ1NuNROX1((object) source, EqlPropertiesService.\u003C\u003Ec__DisplayClass4_0.o1EvKhfUvoqCQAlHucgw((object) viewModelMetadata), EqlPropertiesService.\u003C\u003Ec__DisplayClass4_0.o1EvKhfUvoqCQAlHucgw((object) property));

      void SetPropertyValue(PropertyMetadata property, object value)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              // ISSUE: reference to a compiler-generated method
              EqlPropertiesService.\u003C\u003Ec__DisplayClass4_0.qF7LpwfUZ9DNUGJrFBHC((object) source, viewModelMetadata.Uid, property.Uid, value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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

    private void SetEqlComputedProperties(
      IEnumerable<PropertyMetadata> properties,
      Func<PropertyMetadata, object> getPropertyValue,
      Action<PropertyMetadata, object> setPropertyValue,
      List<SerializedModel> additionalModels)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      SerializedModel serializedModel1 = additionalModels.Find((Predicate<SerializedModel>) (model => EqlPropertiesService.\u003C\u003Ec.ixtKQcfUnKv6FPIe8Pq9(EqlPropertiesService.\u003C\u003Ec.ADpykxfUTgMjkJCMbXkF((object) model), EqlPropertiesService.\u003C\u003Ec.pOlviIfUk7SFYi5K44VK(-2138160520 ^ -2138362896))));
      if (serializedModel1 == null)
        return;
      SerializedModel[] source1 = new JsonSerializer().Deserialize<SerializedModel[]>(serializedModel1.Model);
      if (source1.Length == 0)
        return;
      foreach (PropertyMetadata property in properties)
      {
        if (property.Settings is EntitySettings settings && settings.IsComputedEqlValue)
        {
          string propertyUid = property.Uid.ToString();
          // ISSUE: reference to a compiler-generated method
          SerializedModel serializedModel2 = ((IEnumerable<SerializedModel>) source1).FirstOrDefault<SerializedModel>((Func<SerializedModel, bool>) (m => EqlPropertiesService.\u003C\u003Ec__DisplayClass5_0.BW2bemfUihTmKVPACHZl((object) m.Name, (object) propertyUid)));
          if (serializedModel2 != null)
          {
            Type typeByUid = this.metadataRuntimeService.GetTypeByUid(property.SubTypeUid);
            int num = settings.RelationType == RelationType.OneToOne ? 1 : 0;
            int limit = num != 0 ? 1 : 0;
            IEnumerable<IEntity> source2 = EntityQueryHelper.QueryAllEntitiesWithFilter(typeByUid, serializedModel2.Model, (string) null, limit, 0);
            if (num != 0)
            {
              setPropertyValue(property, (object) source2.FirstOrDefault<IEntity>());
            }
            else
            {
              UntypedISetProxy untypedIsetProxy = getPropertyValue(property).AsUntypedISet();
              if (untypedIsetProxy != null)
              {
                untypedIsetProxy.Clear();
                foreach (IEntity o in source2)
                  untypedIsetProxy.Add((object) o);
              }
            }
          }
        }
      }
    }

    internal static void eDChmjUSfRtyE1G54Q3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool tE35UaUI2fORiuWclIk() => EqlPropertiesService.CkI37AUu2xf1R04879R == null;

    internal static EqlPropertiesService VOnZVPUVtRhqrj9FCv7() => EqlPropertiesService.CkI37AUu2xf1R04879R;
  }
}

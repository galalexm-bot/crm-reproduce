// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ListOfSimpleTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Collections;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Список из простых типов</summary>
  public class ListOfSimpleTypeDescriptor : 
    CLRTypeDescriptor<object, ListOfSimpleTypeSettings>,
    IMappingTypeDescriptor
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{5C281E64-DDC8-4BC9-991A-84D9DC4E7649}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static ListOfSimpleTypeDescriptor cxAu21oxIVfEp2BOreyp;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ListOfSimpleTypeDescriptor.tqVhFLoxi2A2WfFAr2lB((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            mapper.Type<XmlObjectSerializableType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Uid типа</summary>
    public override Guid Uid => ListOfSimpleTypeDescriptor.UID;

    /// <summary>Имя</summary>
    public override string Name => (string) ListOfSimpleTypeDescriptor.OmRr8FoxRtZJTKUp4qly((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740433930));

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <inheritdoc />
    public override Type RuntimeType => typeof (IList);

    public override bool IsVisibleForMetadata(ClassMetadata classMetadata)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (classMetadata is EntityFilterMetadata)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (MetadataAccessInfo.EnvironmentType != MetadataEnvironmentType.VisualStudio)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 2;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return MetadataAccessInfo.EnvironmentType == MetadataEnvironmentType.DevServer;
label_3:
      return true;
    }

    /// <summary>Пустое значение или нет</summary>
    /// <param name="propertyMetadata"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public override bool IsEmpty(PropertyMetadata propertyMetadata, object val)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        ICollection source;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (source == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
                continue;
              }
              goto label_15;
            case 2:
              goto label_13;
            case 3:
              source = val as ICollection;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_10;
            case 5:
              goto label_12;
            case 6:
              goto label_7;
            case 7:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 6 : 6;
                continue;
              }
              if ((ListOfSimpleTypeSettings) propertyMetadata.Settings != null)
              {
                num2 = 3;
                continue;
              }
              goto label_10;
            default:
              goto label_14;
          }
        }
label_15:
        if (!source.Cast<object>().All<object>((System.Func<object, bool>) (v => v == null)))
          num1 = 2;
        else
          goto label_12;
      }
label_7:
      return true;
label_10:
      return true;
label_12:
      return true;
label_13:
      return false;
label_14:
      return true;
    }

    /// <summary>Получить ссылку на тип данных для свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Ссылка на тип данных</returns>
    public override ISyntaxNode GetPropertyTypeReference(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 2;
      Type itemSimpleType;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ListOfSimpleTypeDescriptor.PLWIcCoxqJHhYJ6dDaTy(itemSimpleType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            itemSimpleType = this.GetItemSimpleType((IPropertyMetadata) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 1 : 1;
            continue;
          case 3:
            goto label_5;
          default:
            goto label_6;
        }
      }
label_5:
      return (ISyntaxNode) ListOfSimpleTypeDescriptor.lqqh7loxKRgiKQsKYxrw(TypeOf<List<object>>.Raw);
label_6:
      return ListOfSimpleTypeDescriptor.plDcAboxXwvRaKR00MNv((object) TypeOf.List).CreateTypeSyntax((ISyntaxNode) ListOfSimpleTypeDescriptor.lqqh7loxKRgiKQsKYxrw(itemSimpleType));
    }

    /// <inheritdoc />
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      int num1 = 2;
      Type itemSimpleType;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              itemSimpleType = this.GetItemSimpleType((IPropertyMetadata) propertyMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 1;
              continue;
            case 3:
              goto label_7;
            default:
              goto label_6;
          }
        }
label_3:
        if (ListOfSimpleTypeDescriptor.PLWIcCoxqJHhYJ6dDaTy(itemSimpleType, (Type) null))
          num1 = 3;
        else
          break;
      }
label_6:
      return (IPropertyDefaultValueContainer) new PropertyListValueContainer(TypeOf<object>.Raw);
label_7:
      return (IPropertyDefaultValueContainer) new PropertyListValueContainer(itemSimpleType);
    }

    /// <inheritdoc />
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return ((ISyntaxNode) ListOfSimpleTypeDescriptor.TC4iNXoxTHOPKC3WkhPu((object) this, (object) classMetadata, (object) propertyMetadata, forFilter)).ObjectCreationExpression();
    }

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num1 = 2;
      ListOfSimpleTypeSettings settings;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
              goto label_8;
            case 2:
              if (propertyMetadata == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
                continue;
              }
              break;
            case 3:
              goto label_5;
          }
          if (propertyMetadata.Settings == null)
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 2 : 4;
          else
            break;
        }
        settings = (ListOfSimpleTypeSettings) propertyMetadata.Settings;
        num1 = 3;
      }
label_5:
      ListOfSimpleTypeSettings forFilterProperty = new ListOfSimpleTypeSettings();
      ListOfSimpleTypeDescriptor.M2FfVmoxn8H47u7teFMp((object) forFilterProperty, ListOfSimpleTypeDescriptor.nNduOVoxk3FV6p1hblBh((object) settings));
      ListOfSimpleTypeDescriptor.IRn50Mox2yB3d6awhQt3((object) forFilterProperty, ListOfSimpleTypeDescriptor.RjjQBeoxOrp6oeVs2Qyx((object) settings));
      return (TypeSettings) forFilterProperty;
label_8:
      return (TypeSettings) null;
    }

    public override void ApplyFilterValue(
      ICriteria criteria,
      EntityMetadata metadata,
      EntityPropertyMetadata propertyMetadata,
      object value,
      string alias)
    {
      int num = 2;
      ICollection values;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_13;
          case 1:
            values = value as ICollection;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 2 : 3;
            continue;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 1;
              continue;
            }
            goto label_15;
          case 3:
            if (values == null)
            {
              num = 6;
              continue;
            }
            goto case 4;
          case 4:
            if (ListOfSimpleTypeDescriptor.cgsHvxoxedEFPrT2t8UE((object) values) > 0)
            {
              num = 7;
              continue;
            }
            goto label_12;
          case 5:
            goto label_4;
          case 6:
            goto label_2;
          case 7:
            ListOfSimpleTypeDescriptor.gGRo76oxPe7aVxDm9lNp((object) criteria, (object) Restrictions.In(propertyMetadata.Name, values));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            goto label_14;
        }
      }
label_13:
      return;
label_4:
      return;
label_2:
      return;
label_14:
      return;
label_15:
      return;
label_12:;
    }

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461643943));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712498917));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      if (obj1 is IEnumerable source1)
      {
        IEnumerable<object> source = source1.Cast<object>();
        SerializableList<object> serializableList = new SerializableList<object>();
        if (source.Any<object>())
        {
          Type type = this.CheckPropertyType(property.PropertyType);
          if (type != (Type) null && type != typeof (object) && (type == typeof (string) || type.IsPrimitive || type.IsValueType))
          {
            IMetadataRuntimeService service = Locator.GetService<IMetadataRuntimeService>();
            if (service != null && service.GetTypeDescriptor(type) is TypeDescriptor typeDescriptor)
            {
              foreach (object obj2 in source)
              {
                object obj3 = typeDescriptor.SerializeSimple(obj2, type, settings);
                serializableList.Add(obj3);
              }
              serializableDictionary[propertyMetadata.Name] = (object) serializableList;
            }
          }
        }
        serializableDictionary[propertyMetadata.Name] = (object) serializableList;
      }
      return (IDictionary<string, object>) serializableDictionary;
    }

    /// <summary>
    /// Восстановить значение свойства из сериализуемых значений
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="values">Словарь сериализуемых значений</param>
    public override void Deserialize(
      object obj,
      [NotNull] ClassMetadata metadata,
      [NotNull] PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97953432));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293703094));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanWrite)
        return;
      Type propertyType = property.PropertyType;
      string name = propertyMetadata.Name;
      Type type = this.CheckPropertyType(propertyType);
      if (!(type != (Type) null) || !(type != typeof (object)) || !(type == typeof (string)) && !type.IsPrimitive && !type.IsValueType && !(type == typeof (FormViewItem)))
        return;
      object obj1;
      if (!values.TryGetValue(name, out obj1))
        return;
      try
      {
        if (!(obj1 is ICollection collection))
          return;
        List<object> objectList = new List<object>();
        foreach (object obj2 in (IEnumerable) collection)
        {
          object obj3 = this.DeserializeSimple(obj2, type);
          objectList.Add(obj3);
        }
        if (this.IsIEnumerableTOrArray(propertyType))
        {
          Array instance = Array.CreateInstance(type, objectList.Count);
          for (int index = 0; index < objectList.Count; ++index)
            ((IList) instance)[index] = objectList[index];
          property.SetValue(obj, (object) instance, (object[]) null);
        }
        else
        {
          IEnumerable instance = (IEnumerable) property.GetValue(obj, (object[]) null);
          if (instance == null)
          {
            if (propertyType.IsInterface)
            {
              Type genericTypeDefinition = propertyType.GetGenericTypeDefinition();
              if (genericTypeDefinition == typeof (ICollection<>) || genericTypeDefinition == typeof (IList<>))
                instance = (IEnumerable) Activator.CreateInstance(typeof (List<>).MakeGenericType(propertyType.GetGenericArguments()));
              if (genericTypeDefinition == typeof (System.Collections.Generic.ISet<>))
                instance = (IEnumerable) Activator.CreateInstance(typeof (System.Collections.Generic.HashSet<>).MakeGenericType(propertyType.GetGenericArguments()));
              if (genericTypeDefinition == typeof (Iesi.Collections.Generic.ISet<>))
                instance = (IEnumerable) Activator.CreateInstance(typeof (HashedSet<>).MakeGenericType(propertyType.GetGenericArguments()));
            }
            else
              instance = (IEnumerable) Activator.CreateInstance(propertyType.GetGenericTypeDefinition().MakeGenericType(type));
            property.SetValue(obj, (object) instance, (object[]) null);
          }
          UntypedICollectionProxy icollectionProxy = instance.AsUntypedICollection();
          icollectionProxy.Clear();
          foreach (object o in objectList)
            icollectionProxy.Add(o);
          property.SetValue(obj, (object) instance, (object[]) null);
        }
      }
      catch
      {
      }
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 5;
      TypeDescriptor typeDescriptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          IMetadataRuntimeService service;
          switch (num2)
          {
            case 1:
              // ISSUE: type reference
              if (ListOfSimpleTypeDescriptor.aYAUuIox3tKb0A8679xj(deserializeToType, ListOfSimpleTypeDescriptor.kZnn0FoxNabgmibLYvio(__typeref (FormViewItem))))
              {
                num2 = 9;
                continue;
              }
              goto label_19;
            case 2:
              if (deserializeToType.IsPrimitive)
                break;
              goto label_17;
            case 3:
            case 6:
              goto label_19;
            case 4:
              goto label_22;
            case 5:
              if (value != null)
              {
                if (!(deserializeToType == (Type) null))
                {
                  // ISSUE: type reference
                  if (!ListOfSimpleTypeDescriptor.PLWIcCoxqJHhYJ6dDaTy(deserializeToType, ListOfSimpleTypeDescriptor.kZnn0FoxNabgmibLYvio(__typeref (object))))
                  {
                    num2 = 3;
                    continue;
                  }
                  goto case 14;
                }
                else
                {
                  num2 = 8;
                  continue;
                }
              }
              else
                goto label_5;
            case 7:
              if (!deserializeToType.IsValueType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                continue;
              }
              break;
            case 8:
              goto label_7;
            case 10:
              goto label_18;
            case 11:
              typeDescriptor = ListOfSimpleTypeDescriptor.pQwJeIoxpttgZa9aqL6x((object) service, deserializeToType) as TypeDescriptor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 11 : 12;
              continue;
            case 12:
              if (typeDescriptor != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 10 : 9;
                continue;
              }
              goto label_19;
            case 13:
              if (service == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 3 : 6;
                continue;
              }
              goto case 11;
            case 14:
              // ISSUE: type reference
              if (deserializeToType == ListOfSimpleTypeDescriptor.kZnn0FoxNabgmibLYvio(__typeref (string)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
          }
          service = Locator.GetService<IMetadataRuntimeService>();
          num2 = 13;
        }
label_5:
        num1 = 4;
        continue;
label_17:
        num1 = 7;
      }
label_7:
      throw new ArgumentNullException((string) ListOfSimpleTypeDescriptor.A760MWox1ivxFHj2CX77(-105199646 ^ -105214362));
label_18:
      return ListOfSimpleTypeDescriptor.kLhfCuoxai2Ttw4cmrWB((object) typeDescriptor, value, deserializeToType);
label_19:
      return (object) null;
label_22:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333754724));
    }

    /// <summary>Получить тип элементов списка из метаданных</summary>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <returns>Тип элементов списка</returns>
    internal Type GetItemSimpleType(IPropertyMetadata propertyMetadata)
    {
      int num = 4;
      Type firstGenericType;
      while (true)
      {
        ITypeDescriptor typeDescriptor;
        object obj;
        switch (num)
        {
          case 1:
            typeDescriptor = ((IMetadataService) ListOfSimpleTypeDescriptor.BXlUahoxtSG8ZusIutsL()).GetTypeDescriptor(ListOfSimpleTypeDescriptor.RjjQBeoxOrp6oeVs2Qyx((object) simpleTypeSettings), Guid.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          case 2:
            firstGenericType = this.GetFirstGenericType(typeDescriptor.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 6 : 6;
            continue;
          case 3:
            obj = (object) null;
            break;
          case 4:
            if (propertyMetadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 3;
              continue;
            }
            obj = ListOfSimpleTypeDescriptor.EGPI7EoxD3ovhXsL5flV((object) propertyMetadata);
            break;
          case 5:
            goto label_12;
          case 6:
            if (!ListOfSimpleTypeDescriptor.PLWIcCoxqJHhYJ6dDaTy(firstGenericType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 7 : 4;
              continue;
            }
            goto label_12;
          case 7:
          case 8:
            goto label_13;
          case 9:
            if (simpleTypeSettings.SimpleTypeUid != Guid.Empty)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
              continue;
            }
            goto label_13;
          default:
            if (typeDescriptor == null)
            {
              num = 8;
              continue;
            }
            goto case 2;
        }
        if (obj is ListOfSimpleTypeSettings simpleTypeSettings)
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 1 : 9;
        else
          goto label_13;
      }
label_12:
      return firstGenericType.GetGenericArguments()[0];
label_13:
      return (Type) null;
    }

    private bool IsIEnumerableTOrArray(Type propertyType)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_5;
          case 3:
            if (!this.IsIEnumerableT(propertyType))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 4:
            if (!propertyType.IsArray)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 3 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_6;
        }
      }
label_2:
      return true;
label_5:
      return true;
label_6:
      return false;
    }

    private bool IsIEnumerableT(Type propertyType)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!propertyType.IsGenericType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      // ISSUE: type reference
      return propertyType.GetGenericTypeDefinition() == ListOfSimpleTypeDescriptor.kZnn0FoxNabgmibLYvio(__typeref (IEnumerable<>));
label_5:
      return false;
    }

    private Type CheckPropertyType(Type propertyType)
    {
      int num1 = 4;
      Type[] genericArguments1;
      Type[] genericArguments2;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          Type type;
          switch (num2)
          {
            case 1:
              if (((IEnumerable<Type>) genericArguments2).Any<Type>())
              {
                num2 = 7;
                continue;
              }
              break;
            case 2:
              if (((IEnumerable<Type>) genericArguments1).Any<Type>())
              {
                num2 = 5;
                continue;
              }
              goto label_16;
            case 3:
              genericArguments2 = propertyType.GetGenericArguments();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 1;
              continue;
            case 4:
              if (this.IsIEnumerableT(propertyType))
              {
                num2 = 3;
                continue;
              }
              break;
            case 5:
              goto label_15;
            case 6:
              goto label_16;
            case 7:
              goto label_6;
            case 8:
              if (!propertyType.IsArray)
              {
                num2 = 6;
                continue;
              }
              goto default;
            case 9:
              if (type != (Type) null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 10 : 8;
                continue;
              }
              goto label_16;
            case 10:
              genericArguments1 = type.GetGenericArguments();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 2 : 2;
              continue;
            default:
label_11:
              // ISSUE: type reference
              type = propertyType.GetInterface(ListOfSimpleTypeDescriptor.kZnn0FoxNabgmibLYvio(__typeref (IEnumerable<>)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 9;
              continue;
          }
          if (propertyType.IsGenericType)
            goto label_11;
          else
            break;
        }
        num1 = 8;
      }
label_6:
      return genericArguments2[0];
label_15:
      return genericArguments1[0];
label_16:
      return (Type) null;
    }

    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    public Type GetFirstGenericType(Type type)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!type.IsGenericType)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              if (ListOfSimpleTypeDescriptor.aYAUuIox3tKb0A8679xj(type.GetGenericTypeDefinition(), typeof (TypeDescriptor<>)))
              {
                num2 = 4;
                continue;
              }
              goto label_4;
            case 3:
              goto label_6;
            case 4:
              goto label_3;
            default:
              goto label_4;
          }
        }
label_4:
        if (ListOfSimpleTypeDescriptor.PLWIcCoxqJHhYJ6dDaTy(type.BaseType, (Type) null))
          num1 = 3;
        else
          goto label_7;
      }
label_3:
      return type;
label_6:
      return this.GetFirstGenericType(type.BaseType);
label_7:
      return (Type) null;
    }

    public ListOfSimpleTypeDescriptor()
    {
      ListOfSimpleTypeDescriptor.q7DWDNoxwyj7QgLbmDU6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ListOfSimpleTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ListOfSimpleTypeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669112783));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          case 2:
            ListOfSimpleTypeDescriptor.q7DWDNoxwyj7QgLbmDU6();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void tqVhFLoxi2A2WfFAr2lB([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<object>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool fsQOIZoxVbHPJ1L1ey1F() => ListOfSimpleTypeDescriptor.cxAu21oxIVfEp2BOreyp == null;

    internal static ListOfSimpleTypeDescriptor En1qlqoxSGJ3jkCUjaVT() => ListOfSimpleTypeDescriptor.cxAu21oxIVfEp2BOreyp;

    internal static object OmRr8FoxRtZJTKUp4qly([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool PLWIcCoxqJHhYJ6dDaTy([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static object lqqh7loxKRgiKQsKYxrw(Type type) => (object) type.CreateTypeSyntax();

    internal static Type plDcAboxXwvRaKR00MNv([In] object obj0) => ((RipeType) obj0).Raw;

    internal static object TC4iNXoxTHOPKC3WkhPu(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      bool forFilter)
    {
      return (object) ((TypeDescriptor) obj0).GetPropertyTypeReference((ClassMetadata) obj1, (PropertyMetadata) obj2, forFilter);
    }

    internal static object nNduOVoxk3FV6p1hblBh([In] object obj0) => (object) ((SimpleTypeSettings) obj0).FieldName;

    internal static void M2FfVmoxn8H47u7teFMp([In] object obj0, [In] object obj1) => ((SimpleTypeSettings) obj0).FieldName = (string) obj1;

    internal static Guid RjjQBeoxOrp6oeVs2Qyx([In] object obj0) => ((ListOfSimpleTypeSettings) obj0).SimpleTypeUid;

    internal static void IRn50Mox2yB3d6awhQt3([In] object obj0, Guid value) => ((ListOfSimpleTypeSettings) obj0).SimpleTypeUid = value;

    internal static int cgsHvxoxedEFPrT2t8UE([In] object obj0) => ((ICollection) obj0).Count;

    internal static object gGRo76oxPe7aVxDm9lNp([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object A760MWox1ivxFHj2CX77(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type kZnn0FoxNabgmibLYvio([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool aYAUuIox3tKb0A8679xj([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object pQwJeIoxpttgZa9aqL6x([In] object obj0, Type runtimeType) => (object) ((IMetadataService) obj0).GetTypeDescriptor(runtimeType);

    internal static object kLhfCuoxai2Ttw4cmrWB([In] object obj0, [In] object obj1, Type deserializeToType) => ((TypeDescriptor) obj0).DeserializeSimple(obj1, deserializeToType);

    internal static object EGPI7EoxD3ovhXsL5flV([In] object obj0) => (object) ((IPropertyMetadata) obj0).Settings;

    internal static object BXlUahoxtSG8ZusIutsL() => (object) MetadataServiceContext.Service;

    internal static void q7DWDNoxwyj7QgLbmDU6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DataClassDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.MetadataInternalContainer.Containers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Дескриптор для типа "Структура обмена данными"</summary>
  [Component(Order = 650)]
  public class DataClassDescriptor : RefTypeDescriptor<IDataClass, DataClassSettings>
  {
    /// <summary>Свойство, обозначающее ссылку на тип</summary>
    public const string typeRef = "$t";
    /// <summary>Uid типа</summary>
    public const string UID_S = "{44AB0155-A95C-4962-9504-8C6B26DD7652}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static readonly ConcurrentDictionary<string, (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid)> DtoTypes;
    private static readonly (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) EmptyType;
    private static string loadFromMetadataItemHeaderQuery;
    private static string loadFromModuleReferenceQuery;
    private static readonly XmlObjectSerializableType xmlObjSerType;
    internal static DataClassDescriptor zOwu5po6qZjM4am1qQuq;

    /// <summary>Описание типа "Объект"</summary>
    [XmlIgnore]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public EntityDescriptor EntityDescriptor
    {
      get => this.\u003CEntityDescriptor\u003Ek__BackingField;
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
              this.\u003CEntityDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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
    public override Guid Uid => DataClassDescriptor.UID;

    /// <inheritdoc />
    public override string Name => EleWise.ELMA.SR.T((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1819636893 << 3 ^ 1672075442));

    /// <inheritdoc />
    public override Guid ParentUid => Guid.Empty;

    /// <inheritdoc />
    public override IEnumerable<ITypeDescriptor> GetSubTypes(ClassMetadata classMetadata) => Enumerable.Empty<ITypeDescriptor>();

    /// <inheritdoc />
    public override IPropertyDefaultValueContainer GetDefaultContainer(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return (IPropertyDefaultValueContainer) new EleWise.ELMA.Model.MetadataInternalContainer.Containers.PropertyValueContainer<object>();
    }

    /// <summary>
    /// Получить сериализуемые значения для значения свойства данного типа
    /// </summary>
    /// <param name="obj">Объект, содержащий свойство данного типа</param>
    /// <param name="metadata">Метаданные объекта</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="serializationSettings">Настройки сериализации</param>
    /// <returns>Словарь сериализуемых значений</returns>
    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings serializationSettings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675491711));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413548365));
      Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978618756));
      obj = obj.CastAsRealType();
      System.Reflection.PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (System.Reflection.PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      using (ReferenceResolverSerializer.CreateResolver(ReferenceResolverSerializer.CurrentResolver != null | (serializationSettings != null && serializationSettings.WriteReferences)))
      {
        object obj1 = property.GetValue(obj, (object[]) null);
        SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
        if (obj1 != null)
        {
          switch (((DataClassSettings) propertyMetadata.Settings).RelationType)
          {
            case RelationType.OneToOne:
              serializableDictionary[propertyMetadata.Name] = this.SerializeSimple(obj1, obj1.GetType(), serializationSettings);
              break;
            case RelationType.OneToMany:
            case RelationType.ManyToMany:
            case RelationType.ManyToManyInverse:
              if (obj1 is IEnumerable enumerable)
              {
                SerializableList<object> serializableList = new SerializableList<object>();
                try
                {
                  foreach (object obj2 in enumerable)
                    serializableList.Add(obj2 == null ? (object) null : this.SerializeSimple(obj2, obj2.GetType(), serializationSettings));
                  serializableDictionary[propertyMetadata.Name] = (object) serializableList;
                  break;
                }
                catch (Exception ex)
                {
                  this.Logger.Log(EleWise.ELMA.Logging.LogLevel.Error, ex, ex.Message);
                  break;
                }
              }
              else
                break;
          }
        }
        else
          serializableDictionary[propertyMetadata.Name] = (object) null;
        return (IDictionary<string, object>) serializableDictionary;
      }
    }

    /// <summary>Сериализовать данные в объект</summary>
    /// <param name="value">Данные</param>
    /// <param name="valueType">Тип данных</param>
    /// <param name="settings">Настройки сериализации</param>
    /// <returns>Сериализованное представление данных</returns>
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 4;
      IDisposable disposable;
      while (true)
      {
        bool flag;
        int num2;
        switch (num1)
        {
          case 1:
            num2 = settings.WriteReferences ? 1 : 0;
            break;
          case 2:
            if (settings != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
              continue;
            }
            num2 = 0;
            break;
          case 3:
            if (value is DataClass dataClass)
            {
              num1 = 2;
              continue;
            }
            goto label_55;
          case 4:
            if (value != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 3;
              continue;
            }
            goto label_2;
          case 5:
            goto label_6;
          case 6:
            goto label_53;
          case 7:
            goto label_2;
          case 8:
            goto label_55;
          default:
            disposable = (IDisposable) DataClassDescriptor.RFxlNDo6n5QlX9P3QVPp(DataClassDescriptor.yHwM9Jo6kJNPvqmt1wFA() != null | flag);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 5 : 2;
            continue;
        }
        flag = num2 != 0;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
      }
label_2:
      return (object) null;
label_6:
      object obj;
      try
      {
        object name = DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1839087379 - 334718690 ^ 2121172163);
        // ISSUE: reference to a compiler-generated field
        Func<HashSet<Guid>> func = DataClassDescriptor.\u003C\u003Ec.\u003C\u003E9__16_0;
        Func<HashSet<Guid>> val;
        if (func == null)
        {
          // ISSUE: reference to a compiler-generated field
          DataClassDescriptor.\u003C\u003Ec.\u003C\u003E9__16_0 = val = (Func<HashSet<Guid>>) (() => new HashSet<Guid>());
        }
        else
          goto label_62;
label_8:
        HashSet<Guid> orAdd = ContextVars.GetOrAdd<HashSet<Guid>>((string) name, val);
        int num3 = 4;
        IEnumerator<DataClassMetadata> enumerator1;
        SerializableDictionary<string, object> serializableDictionary1;
        while (true)
        {
          switch (num3)
          {
            case 1:
label_46:
              obj = (object) serializableDictionary1;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 2 : 1;
              continue;
            case 2:
              goto label_53;
            case 3:
              enumerator1 = dataClass.GetIncludes(true).GetEnumerator();
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            case 4:
              SerializableDictionary<string, object> serializableDictionary2 = new SerializableDictionary<string, object>();
              serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542849677), DataClassDescriptor.oEXoDIo6ObLmu3vYAwMm((object) (DataClass) value));
              serializableDictionary1 = serializableDictionary2;
              num3 = 3;
              continue;
            default:
              try
              {
label_17:
                if (DataClassDescriptor.RnSriio63Z3R8nInpuiY((object) enumerator1))
                  goto label_14;
                else
                  goto label_18;
label_12:
                DataClassMetadata current1;
                IEnumerator<KeyValuePair<string, object>> enumerator2;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_46;
                    case 2:
                      goto label_14;
                    case 3:
                    case 7:
                      goto label_17;
                    case 4:
                      orAdd.Add(DataClassDescriptor.uNt6Lko62Woh6Ojggfjo((object) current1));
                      num4 = 6;
                      continue;
                    case 5:
                      goto label_19;
                    case 6:
                      if (!(new EntityJsonSerializer().ConvertToSerializable((object) dataClass, (ClassMetadata) current1, settings) is IDictionary<string, object> serializable))
                      {
                        num4 = 3;
                        continue;
                      }
                      break;
                  }
                  enumerator2 = serializable.GetEnumerator();
                  num4 = 5;
                }
label_19:
                try
                {
label_26:
                  if (enumerator2.MoveNext())
                    goto label_25;
                  else
                    goto label_27;
label_20:
                  KeyValuePair<string, object> current2;
                  int num5;
                  while (true)
                  {
                    string key;
                    switch (num5)
                    {
                      case 1:
                        goto label_17;
                      case 2:
                        SerializableDictionary<string, object> serializableDictionary3 = new SerializableDictionary<string, object>();
                        serializableDictionary3.Add((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(--1867379187 ^ 1867286433), current2.Value);
                        obj = (object) serializableDictionary3;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 3 : 3;
                        continue;
                      case 3:
                        goto label_53;
                      case 4:
                        if (key == (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-812025778 ^ -812118512))
                        {
                          num5 = 7;
                          continue;
                        }
                        break;
                      case 5:
                        if (DataClassDescriptor.Unx6Iao6e3ICR970CKAd((object) key, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751229006)))
                        {
                          num5 = 2;
                          continue;
                        }
                        goto case 4;
                      case 6:
                      case 10:
                        goto label_26;
                      case 7:
                        serializableDictionary1[key] = current2.Value;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 6 : 2;
                        continue;
                      case 8:
                        key = current2.Key;
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 5;
                        continue;
                      case 9:
                        goto label_25;
                    }
                    serializableDictionary1[(string) DataClassDescriptor.fTTPMvo61fGJFAhNab7d(DataClassDescriptor.RvBNNZo6P3NCSaRhc0GC((object) current1), DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1350312861 << 3 ^ 2082387962), (object) key)] = current2.Value;
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 3 : 10;
                  }
label_25:
                  current2 = enumerator2.Current;
                  num5 = 8;
                  goto label_20;
label_27:
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                  goto label_20;
                }
                finally
                {
                  if (enumerator2 != null)
                  {
                    int num6 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
                      num6 = 0;
                    while (true)
                    {
                      switch (num6)
                      {
                        case 1:
                          DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) enumerator2);
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_37;
                      }
                    }
                  }
label_37:;
                }
label_14:
                current1 = enumerator1.Current;
                num4 = 4;
                goto label_12;
label_18:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
                goto label_12;
              }
              finally
              {
                int num7;
                if (enumerator1 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 1 : 1;
                else
                  goto label_42;
label_41:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_42:
                DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) enumerator1);
                num7 = 2;
                goto label_41;
              }
          }
        }
label_62:
        val = func;
        goto label_8;
      }
      finally
      {
        if (disposable != null)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_52;
              default:
                DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) disposable);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_52:;
      }
label_53:
      return obj;
label_55:
      return (object) null;
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
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      IDictionary<string, object> values)
    {
      if (obj == null || values == null)
        return;
      Contract.ArgumentNotNull((object) metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672211926));
      Contract.ArgumentNotNull((object) propertyMetadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867807970));
      Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740480678));
      obj = obj.CastAsRealType();
      System.Reflection.PropertyInfo propInfo = obj.GetProperty(metadata, propertyMetadata);
      object obj1;
      if (propInfo == (System.Reflection.PropertyInfo) null || !propInfo.CanWrite || !values.TryGetValue(propertyMetadata.Name, out obj1))
        return;
      using (ReferenceResolverSerializer.CreateResolver(true))
      {
        object serializerMarker = new object();
        EntityJsonSerializer.AddSerializerMarker(serializerMarker);
        switch (((DataClassSettings) propertyMetadata.Settings).RelationType)
        {
          case RelationType.OneToOne:
            Type dataClassType1 = propInfo.PropertyType;
            object obj2 = this.DeserializeSimple(obj1, dataClassType1);
            Func<object> func1;
            if ((func1 = obj2 as Func<object>) != null)
            {
              EntityJsonSerializer.AddAction((System.Action) (() =>
              {
                int num = 2;
                object obj3;
                while (true)
                {
                  switch (num)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      DataClassDescriptor.\u003C\u003Ec__DisplayClass17_1.lGLqSaCuVi4j43ahi4fl((object) propInfo, obj, DataClassDescriptor.\u003C\u003Ec__DisplayClass17_1.CGCclTCuIohIr0KTrlyR((object) (DataClass) obj3, dataClassType1) ?? obj3, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (object) null, (object) null, (object) null);
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                      continue;
                    case 2:
                      obj3 = func1();
                      num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              }));
              break;
            }
            if (obj2 != null)
            {
              propInfo.SetValue(obj, obj2, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, (Binder) null, (object[]) null, (CultureInfo) null);
              break;
            }
            break;
          case RelationType.OneToMany:
          case RelationType.ManyToMany:
          case RelationType.ManyToManyInverse:
            if (obj1 is IEnumerable source)
            {
              IEnumerable<object> objects = source.Cast<object>();
              int length = objects.Count<object>();
              if (propInfo.PropertyType.IsArray)
              {
                Type elementType = EleWise.ELMA.Extensions.EnumerableExtensions.GetElementType(propInfo.PropertyType);
                IList array = (IList) Array.CreateInstance(elementType, length);
                objects.ForEach<object>((Action<object, int>) ((item, index) =>
                {
                  int num1 = 7;
                  object obj5;
                  Func<object> func;
                  Func<object> func2;
                  int index1;
                  // ISSUE: variable of a compiler-generated type
                  DataClassDescriptor.\u003C\u003Ec__DisplayClass17_2 cDisplayClass172;
                  while (true)
                  {
                    switch (num1)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        DataClassDescriptor.\u003C\u003Ec__DisplayClass17_2.yJcV36CuKmHSvnQgJUZt((object) (System.Action) (() =>
                        {
                          int num2 = 2;
                          object obj6;
                          while (true)
                          {
                            switch (num2)
                            {
                              case 0:
                                goto label_2;
                              case 1:
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated field
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                DataClassDescriptor.\u003C\u003Ec__DisplayClass17_3.q0CvhJCu2UfHs2Qdj5uM((object) cDisplayClass172.array, index1, DataClassDescriptor.\u003C\u003Ec__DisplayClass17_3.v05pD5CuOQ3CQjsxtEl4((object) (DataClass) obj6, cDisplayClass172.elementType) ?? obj6);
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
                                continue;
                              case 2:
                                obj6 = func2();
                                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 1;
                                continue;
                              default:
                                goto label_5;
                            }
                          }
label_2:
                          return;
label_5:;
                        }));
                        num1 = 3;
                        continue;
                      case 2:
                        if (func == null)
                        {
                          // ISSUE: reference to a compiler-generated method
                          DataClassDescriptor.\u003C\u003Ec__DisplayClass17_2.LJlwbgCuXqHhk2qhlVwc((object) array, index1, obj5);
                          num1 = 4;
                          continue;
                        }
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                        continue;
                      case 3:
                        goto label_2;
                      case 4:
                        goto label_5;
                      case 5:
                        obj5 = this.DeserializeSimple(item, elementType);
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
                        continue;
                      case 6:
                        cDisplayClass172 = this;
                        num1 = 8;
                        continue;
                      case 7:
                        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 6 : 0;
                        continue;
                      case 8:
                        index1 = index;
                        num1 = 5;
                        continue;
                      default:
                        func2 = func = obj5 as Func<object>;
                        num1 = 2;
                        continue;
                    }
                  }
label_2:
                  return;
label_5:;
                }));
                propInfo.SetValue(obj, (object) array, (object[]) null);
                break;
              }
              IList propValue = (IList) propInfo.GetValue(obj, (object[]) null);
              propValue.Clear();
              Type dataClassType2 = propInfo.PropertyType.GetGenericArguments()[0];
              using (IEnumerator<object> enumerator = objects.GetEnumerator())
              {
                while (enumerator.MoveNext())
                {
                  object obj7 = this.DeserializeSimple(enumerator.Current, dataClassType);
                  Func<object> func3;
                  if ((func3 = obj7 as Func<object>) != null)
                  {
                    int index = propValue.Count;
                    EntityJsonSerializer.AddAction((System.Action) (() =>
                    {
                      int num3 = 1;
                      object obj8;
                      while (true)
                      {
                        switch (num3)
                        {
                          case 1:
                            // ISSUE: reference to a compiler-generated method
                            DataClassDescriptor.\u003C\u003Ec__DisplayClass17_6.GEW09RCuHxZ1VBFtGxkc((object) propValue, index);
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
                            continue;
                          case 2:
                            goto label_5;
                          case 3:
                            IList list = propValue;
                            int num4 = index;
                            // ISSUE: reference to a compiler-generated method
                            object obj9 = DataClassDescriptor.\u003C\u003Ec__DisplayClass17_6.NFfhXCCuAggx395kqXN5((object) (DataClass) obj8, dataClassType);
                            object obj10 = obj9 == null ? obj8 : obj9;
                            // ISSUE: reference to a compiler-generated method
                            DataClassDescriptor.\u003C\u003Ec__DisplayClass17_6.jn9NCWCu7lkfCjjUeiXN((object) list, num4, obj10);
                            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 0;
                            continue;
                          default:
                            obj8 = func();
                            num3 = 3;
                            continue;
                        }
                      }
label_5:;
                    }));
                    propValue.Add((object) null);
                  }
                  else
                    propValue.Add(obj7);
                }
                break;
              }
            }
            else
              break;
        }
        EntityJsonSerializer.InvokeActions(serializerMarker);
      }
    }

    /// <summary>Десериализация упрощенная</summary>
    /// <param name="value">Значение объекта, которое нужно десериализовать</param>
    /// <param name="deserializeToType">Тип, в который необходимо десериализовать</param>
    /// <returns>Десериализованный объект</returns>
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 5;
      IDisposable disposable;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            goto label_4;
          case 3:
            disposable = (IDisposable) DataClassDescriptor.RFxlNDo6n5QlX9P3QVPp(true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 1 : 1;
            continue;
          case 4:
            if (value is IDictionary<string, object> serObj1)
            {
              num1 = 3;
              continue;
            }
            goto label_2;
          case 5:
            DataClassDescriptor.qIORXYo6pVqlOJ8HkgXK((object) deserializeToType, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-35995181 ^ -36009897));
            num1 = 4;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_4:
      object obj1;
      return obj1;
label_8:
      try
      {
        object obj2 = new object();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
          num2 = 2;
        while (true)
        {
          int num3;
          object obj3;
          DataClass dataClass;
          IEnumerator<DataClassMetadata> enumerator1;
          DataClass.ValueContainer valueContainer;
          string str;
          Dictionary<string, Dictionary<string, object>> dictionary1;
          IEnumerator<KeyValuePair<string, object>> enumerator2;
          object obj4;
          object obj5;
          object obj6;
          switch (num2)
          {
            case 1:
              try
              {
label_56:
                if (DataClassDescriptor.RnSriio63Z3R8nInpuiY((object) enumerator2))
                  goto label_58;
                else
                  goto label_57;
label_47:
                string[] strArray;
                string key1;
                Dictionary<string, object> dictionary2;
                KeyValuePair<string, object> current;
                string key2;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                    case 7:
                      goto label_56;
                    case 2:
                    case 15:
                      dictionary2[key2] = current.Value;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 7 : 7;
                      continue;
                    case 3:
                      strArray = current.Key.Split('$');
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 5;
                      continue;
                    case 4:
                      key2 = strArray[1];
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 10 : 11;
                      continue;
                    case 5:
                      if (strArray.Length == 2)
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_62;
                    case 6:
                      str = current.Value.ToString();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 1;
                      continue;
                    case 8:
                      goto label_62;
                    case 9:
                      goto label_21;
                    case 10:
                      if (!DataClassDescriptor.Unx6Iao6e3ICR970CKAd((object) current.Key, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-488881205 ^ -488751323)))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 12 : 12;
                        continue;
                      }
                      goto label_56;
                    case 11:
                      if (dictionary1.TryGetValue(key1, out dictionary2))
                      {
                        num4 = 15;
                        continue;
                      }
                      goto case 14;
                    case 12:
                      if (DataClassDescriptor.Unx6Iao6e3ICR970CKAd((object) current.Key, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1876063057 ^ -1876100367)))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 6;
                        continue;
                      }
                      goto case 3;
                    case 13:
                      goto label_58;
                    case 14:
                      dictionary1[key1] = dictionary2 = new Dictionary<string, object>();
                      num4 = 2;
                      continue;
                    default:
                      key1 = strArray[0];
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 4;
                      continue;
                  }
                }
label_62:
                throw new Exception((string) DataClassDescriptor.aamLuio64TfHDKEK2oiB(DataClassDescriptor.eSprIwo6TamAeViS3ORw(-2112703338 ^ -2112829344)));
label_57:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 9 : 9;
                goto label_47;
label_58:
                current = enumerator2.Current;
                num4 = 10;
                goto label_47;
              }
              finally
              {
                if (enumerator2 != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_71;
                      default:
                        DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) enumerator2);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_71:;
              }
            case 2:
              DataClassDescriptor.aO8NYro6a2VBaBDb9Z2n(obj2);
              num2 = 3;
              continue;
            case 3:
              if (serObj1.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675418131)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 18 : 19;
                continue;
              }
              goto case 5;
            case 4:
              dictionary1 = new Dictionary<string, Dictionary<string, object>>();
              num2 = 10;
              continue;
            case 5:
              valueContainer = (DataClass.ValueContainer) null;
              num2 = 22;
              continue;
            case 6:
            case 11:
              obj5 = DataClassDescriptor.YHsLC3o6DZurQ8J3y6Tk((object) (DataClass) obj4, deserializeToType);
              if (obj5 == null)
              {
                num3 = 25;
                break;
              }
              goto label_87;
            case 7:
              try
              {
label_30:
                if (enumerator1.MoveNext())
                  goto label_26;
                else
                  goto label_31;
label_25:
                DataClassMetadata current;
                int num6;
                while (true)
                {
                  Dictionary<string, object> dictionary3;
                  switch (num6)
                  {
                    case 1:
                      goto label_26;
                    case 2:
                    case 7:
                      goto label_30;
                    case 3:
                      dictionary3[(string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-643786247 ^ -643698777)] = (object) str;
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                      continue;
                    case 4:
                      if (!DataClassDescriptor.MY1vipo6603cpu1dcuhV((object) str))
                      {
                        num6 = 3;
                        continue;
                      }
                      break;
                    case 5:
                      if (!dictionary1.TryGetValue((string) DataClassDescriptor.RvBNNZo6P3NCSaRhc0GC((object) current), out dictionary3))
                      {
                        num6 = 7;
                        continue;
                      }
                      goto case 4;
                    case 6:
                      goto label_20;
                  }
                  EntityJsonSerializer entityJsonSerializer = new EntityJsonSerializer();
                  object obj7 = DataClassDescriptor.YHsLC3o6DZurQ8J3y6Tk((object) dataClass, deserializeToType);
                  object obj8 = obj7 == null ? (object) dataClass : obj7;
                  DataClassMetadata metadata = current;
                  Dictionary<string, object> serObj2 = dictionary3;
                  entityJsonSerializer.ConvertFromSerializable(obj8, (ClassMetadata) metadata, (IDictionary<string, object>) serObj2, false);
                  num6 = 2;
                }
label_26:
                current = enumerator1.Current;
                num6 = 5;
                goto label_25;
label_31:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 3 : 6;
                goto label_25;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_40;
                      default:
                        DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) enumerator1);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_40:;
              }
            case 8:
            case 12:
            case 20:
            case 28:
              goto label_4;
            case 9:
            case 27:
              if (valueContainer == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              }
              goto case 32;
            case 10:
              str = (string) null;
              num2 = 15;
              continue;
            case 13:
              if (!(obj4 is Func<object> func))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 6 : 1;
                continue;
              }
              goto case 30;
            case 14:
              if (obj3 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 26 : 2;
                continue;
              }
              goto case 29;
            case 15:
              enumerator2 = serObj1.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
              continue;
            case 16:
              if (TypeOf<IDataClass>.Raw.IsAssignableFrom(deserializeToType))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 23 : 5;
                continue;
              }
              goto case 9;
            case 17:
              obj6 = (object) dataClass;
              goto label_89;
            case 18:
label_20:
              DataClassDescriptor.JR0gglo6HyS6MUDp9RUY(obj2);
              num2 = 31;
              continue;
            case 19:
              obj4 = new EntityJsonSerializer().ConvertFromSerializable(new object(), (ClassMetadata) null, serObj1, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 12 : 13;
              continue;
            case 21:
label_21:
              enumerator1 = dataClass.GetIncludes(false).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 7 : 3;
              continue;
            case 22:
              if (serObj1.TryGetValue((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1255365154 ^ 596875508 ^ -1765981756), out obj3))
              {
                num2 = 14;
                continue;
              }
              goto case 24;
            case 23:
              valueContainer = (DataClass.ValueContainer) DataClassDescriptor.iW4aELo6wA15LSXnWu8Q(deserializeToType);
              num2 = 27;
              continue;
            case 24:
            case 26:
              if (valueContainer != null)
              {
                num3 = 9;
                break;
              }
              goto case 16;
            case 25:
              obj5 = obj4;
              goto label_87;
            case 29:
              valueContainer = (DataClass.ValueContainer) DataClassDescriptor.e3Cwh2o6tPS44J5ZfkX3((object) this, (object) obj3.ToString());
              num3 = 24;
              break;
            case 30:
              obj1 = (object) func;
              num2 = 20;
              continue;
            case 31:
              object obj9 = DataClassDescriptor.YHsLC3o6DZurQ8J3y6Tk((object) dataClass, deserializeToType);
              if (obj9 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 6 : 17;
                continue;
              }
              obj6 = obj9;
              goto label_89;
            case 32:
              dataClass = new DataClass(valueContainer);
              num3 = 4;
              break;
            default:
              obj1 = (object) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 3 : 28;
              continue;
          }
label_10:
          num2 = num3;
          continue;
label_87:
          obj1 = obj5;
          num3 = 12;
          goto label_10;
label_89:
          obj1 = obj6;
          num2 = 8;
        }
      }
      finally
      {
        int num8;
        if (disposable == null)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
        else
          goto label_93;
label_92:
        switch (num8)
        {
          case 1:
            break;
          default:
        }
label_93:
        DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) disposable);
        num8 = 2;
        goto label_92;
      }
    }

    private static (Guid moduleUid, Guid moduleItemUid, Guid componentUid, Guid metadataUid) GetDtoUids(
      object typeRef)
    {
      return DataClassDescriptor.DtoTypes.GetOrAdd((string) typeRef, (System.Func<string, (Guid, Guid, Guid, Guid)>) (key =>
      {
        DataClassTypeReference reference = Locator.GetServiceNotNull<IDataClassTypeReferenceManager>().LoadOrNull(key);
        if (reference == null)
          return DataClassDescriptor.EmptyType;
        ModuleReference moduleReference = Locator.GetServiceNotNull<IModuleReferenceManager>().LoadOrNull(reference.MetadataUid);
        if (moduleReference == null)
          return DataClassDescriptor.EmptyType;
        if (moduleReference.ModuleUid == Guid.Empty)
          return ComponentMetadataItemManager.Instance.LoadOrNull(reference.ItemUid) == null ? (Guid.Empty, Guid.Empty, Guid.Empty, reference.MetadataUid) : (Guid.Empty, Guid.Empty, reference.ItemUid, reference.MetadataUid);
        ModuleVersion specificModuleVersion = Locator.GetServiceNotNull<IModuleMetadataLoader>().GetSpecificModuleVersion(moduleReference.ModuleUid, reference.ItemUid);
        ModuleInfoMetadata moduleInfoMetadata = specificModuleVersion != null ? specificModuleVersion.Metadata : throw new NullReferenceException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1573964690), (object) reference.ItemUid, (object) key));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (moduleInfoMetadata.DataClasses.Find((Predicate<DataClassMetadata>) (a => DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.e8T2SQCu9Tb0FEsxRI2F(DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.USYSZNCuM4eTqj6eyPUE((object) a), DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.y0q1LoCuJqDF1n3BJZmo((object) reference)))) != null)
          return (specificModuleVersion.Header.HeaderUid, reference.ItemUid, Guid.Empty, reference.MetadataUid);
        foreach (ComponentMetadata component in moduleInfoMetadata.Components)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (component.DataClasses.Find((Predicate<DataClassMetadata>) (a => DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.e8T2SQCu9Tb0FEsxRI2F(DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.USYSZNCuM4eTqj6eyPUE((object) a), DataClassDescriptor.\u003C\u003Ec__DisplayClass21_0.y0q1LoCuJqDF1n3BJZmo((object) reference)))) != null)
            return (specificModuleVersion.Header.HeaderUid, reference.ItemUid, component.Uid, reference.MetadataUid);
        }
        return DataClassDescriptor.EmptyType;
      }));
    }

    /// <summary>Получить контейнер значений DataClass</summary>
    /// <param name="typeRef">Ссылка на тип</param>
    /// <returns>Контейнер значений</returns>
    internal virtual DataClass.ValueContainer GetValueContainer(string typeRef)
    {
      int num = 3;
      Guid metadataUid;
      Guid componentUid;
      Guid moduleUid;
      Guid moduleItemUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (!DataClassDescriptor.e91vZVo6AYoAkPU6LEVm(metadataUid, Guid.Empty))
            {
              if (moduleUid != Guid.Empty)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 5 : 5;
                continue;
              }
              goto case 4;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
              continue;
            }
          case 3:
            (moduleUid, moduleItemUid, componentUid, metadataUid) = DataClassDescriptor.GetDtoUids((object) typeRef);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 2 : 2;
            continue;
          case 4:
            if (!DataClassDescriptor.oXvNXTo6711HMygSBoIj(componentUid, Guid.Empty))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 5:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_2:
      return DataClass.ValueContainer.Create(metadataUid);
label_3:
      return (DataClass.ValueContainer) DataClassDescriptor.lq81quo6xbfW094BMLe7(componentUid, metadataUid);
label_4:
      return DataClass.ValueContainer.Create(moduleUid, moduleItemUid, componentUid, metadataUid);
label_5:
      return (DataClass.ValueContainer) null;
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
      return this.GetPropertyTypeReferenceInnerLogic(classMetadata, propertyMetadata, forFilter);
    }

    /// <summary>Получить выражение инициализации свойства</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">Для фильтра</param>
    /// <returns>Выражение</returns>
    public override ISyntaxNode GetPropertyInitExpression(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter = false)
    {
      return this.GetPropertyInitExpressionInnerLogic(classMetadata, propertyMetadata, forFilter);
    }

    /// <inheritdoc />
    public override string GetTypeDisplayName(Guid subTypeUid)
    {
      int num = 1;
      DataClassMetadata metadataByUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataByUid = this.GetMetadataByUid(subTypeUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) DataClassDescriptor.IQEco7o6yxxD9sbn9Qu0((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870790397), DataClassDescriptor.aamLuio64TfHDKEK2oiB(DataClassDescriptor.jqdQ9uo60rJeCDVkQnML((object) metadataByUid)), DataClassDescriptor.lMNmTuo6m1MkcbH9IcgU((object) metadataByUid));
    }

    /// <summary>Получить имя типа данных CLR</summary>
    /// <param name="classMetadata">Метаданные класса</param>
    /// <param name="propertyMetadata">Метаданные свойства</param>
    /// <param name="forFilter">True, если свойство генерируется для фильтра</param>
    /// <returns>Имя типа</returns>
    protected override string GetTypeName(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 3;
      DataClassMetadata metadataByUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (metadataByUid != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          case 3:
            metadataByUid = this.GetMetadataByUid(DataClassDescriptor.CUg7FMo6MALecOqpI86w((object) propertyMetadata));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      // ISSUE: type reference
      throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398550016), (object) DataClassDescriptor.XP4tsio6Ji8bXqbtYinZ(__typeref (DataClassMetadata))));
label_4:
      return (string) DataClassDescriptor.V4CxDZo69U7VMMAgFUJ9((object) metadataByUid);
    }

    /// <summary>Получить Guid подтипа DataClass из типа</summary>
    /// <param name="type">Тип DataClass</param>
    /// <returns>Guid подтипа DataClass из типа</returns>
    internal static Guid GetSubtypeUid(Type type)
    {
      int num = 1;
      UidAttribute attribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            attribute = AttributeHelper<UidAttribute>.GetAttribute(type, true);
            if (attribute == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 2:
            goto label_6;
          default:
            if (DataClassDescriptor.MY1vipo6603cpu1dcuhV((object) type.FullName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return Guid.Empty;
label_7:
      return DataClassDescriptor.O0TajRo6dUNm4WmmPkIJ((object) type.FullName);
label_8:
      return attribute.Uid;
    }

    /// <summary>Получить метаданные по уникальному идентификатору</summary>
    /// <param name="typeUid">Уникальный идентификатор метаданных</param>
    /// <returns>Метаданные</returns>
    /// <exception cref="T:System.Exception">Возникает, если тип метаданных не найден</exception>
    internal DataClassMetadata GetMetadataByUid(Guid typeUid)
    {
      int num1 = 1;
      IDataReader dataReader1;
      DataClassMetadata metadataByUid1;
      DataClassMetadata metadataByUid2;
      Guid typeUid1;
      while (true)
      {
        int num2 = num1;
        IDataReader dataReader2;
        string str1;
        string str2;
        string str3;
        string str4;
        string str5;
        string str6;
        string str7;
        string str8;
        string str9;
        string str10;
        string str11;
        string str12;
        string str13;
        string str14;
        string str15;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_40;
            case 3:
              object obj1 = DataClassDescriptor.YMkIZAo6rdlJlKByKdxN(DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication));
              str10 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2139066780));
              str11 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, DataClassDescriptor.eSprIwo6TamAeViS3ORw(--1333735954 ^ 1333612484));
              str12 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, DataClassDescriptor.eSprIwo6TamAeViS3ORw(87862435 ^ 87818591));
              str13 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501461531));
              str14 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-2107978722 ^ -2108011200));
              str15 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236101389));
              num2 = 12;
              continue;
            case 4:
              goto label_10;
            case 5:
              goto label_38;
            case 6:
              if (metadataByUid1 != null)
              {
                num2 = 4;
                continue;
              }
              if (DataClassDescriptor.loadFromMetadataItemHeaderQuery != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 5 : 13;
                continue;
              }
              goto case 3;
            case 7:
            case 13:
              dataReader2 = ((ITransformationProvider) DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication)).ExecuteQuery(DataClassDescriptor.loadFromMetadataItemHeaderQuery, new Dictionary<string, object>()
              {
                [z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574373712)] = (object) typeUid1
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 10 : 10;
              continue;
            case 8:
label_35:
              if (DataClassDescriptor.loadFromModuleReferenceQuery != null)
              {
                num2 = 16;
                continue;
              }
              goto label_38;
            case 9:
              goto label_25;
            case 10:
              try
              {
                int num3;
                if (!dataReader2.Read())
                  num3 = 3;
                else
                  goto label_16;
label_15:
                switch (num3)
                {
                  case 1:
                    goto label_41;
                  case 2:
                    break;
                  default:
                    goto label_35;
                }
label_16:
                metadataByUid2 = DataClassDescriptor.zXflKto6YrTGjlOWtLI2((object) DataClassDescriptor.xmlObjSerType, (object) (DbDataReader) dataReader2, (object) new string[1]
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218925960)
                }, (object) null, (object) null) as DataClassMetadata;
                num3 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
                {
                  num3 = 1;
                  goto label_15;
                }
                else
                  goto label_15;
              }
              finally
              {
                int num4;
                if (dataReader2 == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
                else
                  goto label_21;
label_20:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_21:
                DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) dataReader2);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                {
                  num4 = 0;
                  goto label_20;
                }
                else
                  goto label_20;
              }
            case 11:
              DataClassDescriptor.loadFromModuleReferenceQuery = (string) DataClassDescriptor.LARSpUo6jci4MIEfiJZl((object) new string[21]
              {
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-138018305 ^ -138117125),
                str1,
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(694673736 ^ -23604109 ^ -672035709),
                str2,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1426456882 ^ 2009939514 ^ -583614908),
                str3,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1669371371 ^ 1669524281),
                str4,
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870787375),
                str5,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1917998801 >> 2 ^ 479538302),
                str6,
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712370571),
                str7,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1867198571 ^ -1867075131),
                str8,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1461625753 ^ 1461509481),
                str9,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(964881585 - -1459193222 ^ -1870889411),
                (string) DataClassDescriptor.qlQg8no65FUBh2VPDM7C(DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication)),
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1304605005 ^ 1304488013)
              });
              num2 = 15;
              continue;
            case 12:
              DataClassDescriptor.loadFromMetadataItemHeaderQuery = (string) DataClassDescriptor.LARSpUo6jci4MIEfiJZl((object) new string[15]
              {
                z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824492135),
                str15,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1858887263 ^ -1858988007),
                str10,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-105199646 ^ -105334280),
                str11,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1380439818 << 3 ^ 1841510796),
                str14,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1334993905 ^ -1334844833),
                str12,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1242972401 >> 4 ^ 77797973),
                str13,
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-643786247 ^ -643787277),
                (string) DataClassDescriptor.qlQg8no65FUBh2VPDM7C(DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication)),
                (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1088304168 ^ -1088187688)
              });
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 1 : 7;
              continue;
            case 14:
              metadataByUid1 = this.LoadFromRuntime(typeUid1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 6 : 6;
              continue;
            case 15:
            case 16:
              dataReader1 = ((ITransformationProvider) DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication)).ExecuteQuery(DataClassDescriptor.loadFromModuleReferenceQuery, new Dictionary<string, object>()
              {
                [z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97826474)] = (object) typeUid1
              });
              num2 = 9;
              continue;
            default:
              typeUid1 = typeUid;
              num2 = 14;
              continue;
          }
        }
label_38:
        object obj2 = DataClassDescriptor.YMkIZAo6rdlJlKByKdxN(DataClassDescriptor.NnUBxMo6lRtRYFPjwSvO((object) this.RuntimeApplication));
        str2 = (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(--1360331293 ^ 1360479735);
        str3 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj2, DataClassDescriptor.eSprIwo6TamAeViS3ORw(1021410165 ^ 1021522121));
        str6 = ((Dialect) obj2).QuoteIfNeeded((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1978478350 ^ -1978618240));
        str9 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112815974));
        str5 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372720933));
        str4 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj2, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1978478350 ^ -1978482848));
        str8 = ((Dialect) obj2).QuoteIfNeeded((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1012087039 ^ 1011959397));
        str7 = ((Dialect) obj2).QuoteIfNeeded((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-244066886 - -48452443 ^ -195581877));
        str1 = (string) DataClassDescriptor.eHMQMFo6gtnQQg0bawi7(obj2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106482426));
        num1 = 11;
      }
label_10:
      return metadataByUid1;
label_25:
      try
      {
        int num5;
        if (!DataClassDescriptor.omS3Qco6LhXrDIP11OkC((object) dataReader1))
          num5 = 2;
        else
          goto label_28;
label_27:
        switch (num5)
        {
          case 1:
            goto label_41;
          case 2:
          case 3:
            goto label_40;
        }
label_28:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        metadataByUid2 = (DataClassDescriptor.zXflKto6YrTGjlOWtLI2((object) DataClassDescriptor.xmlObjSerType, (object) (DbDataReader) dataReader1, (object) new string[1]
        {
          (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(1051276242 - 990076387 ^ 61170477)
        }, (object) null, (object) null) as ModuleInfoMetadata).DataClasses.Find((Predicate<DataClassMetadata>) (a => DataClassDescriptor.\u003C\u003Ec__DisplayClass28_0.gR9JxwCuj6nlES2GaeHV(DataClassDescriptor.\u003C\u003Ec__DisplayClass28_0.NBweAqCu5P5iJ1jEPVbT((object) a), typeUid1)));
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        {
          num5 = 1;
          goto label_27;
        }
        else
          goto label_27;
      }
      finally
      {
        int num6;
        if (dataReader1 == null)
          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
        else
          goto label_33;
label_32:
        switch (num6)
        {
          case 1:
            break;
          default:
        }
label_33:
        DataClassDescriptor.h1rS5Do6NjXJMcQLaALk((object) dataReader1);
        num6 = 2;
        goto label_32;
      }
label_40:
      throw new Exception(EleWise.ELMA.SR.T((string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(-2138958856 ^ -2139067152), (object) typeUid1));
label_41:
      return metadataByUid2;
    }

    private ISyntaxNode GetPropertyTypeReferenceInnerLogic(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num1 = 4;
      ISyntaxNode referenceInnerLogic;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_5;
          case 2:
            int num2 = (int) DataClassDescriptor.tUgChRo6c2MITFprWP0B((object) (DataClassSettings) DataClassDescriptor.JJ48YKo6soAN5G2vqksH((object) propertyMetadata));
            referenceInnerLogic = (ISyntaxNode) DataClassDescriptor.yQTURsoHFg7449LjgXuQ(DataClassDescriptor.vdOclno6zmcafVQlhx7m((object) this, (object) classMetadata, (object) propertyMetadata, forFilter));
            if (num2 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          case 3:
            DataClassDescriptor.qIORXYo6pVqlOJ8HkgXK((object) propertyMetadata.Settings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461617423));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          case 4:
            DataClassDescriptor.qIORXYo6pVqlOJ8HkgXK((object) propertyMetadata, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-630932142 - 1120244082 ^ -1751162190));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 2 : 3;
            continue;
          default:
            DataClassDescriptor.aVDoEWo6UCI8jaify4UX(propertyMetadata.Settings is DataClassSettings, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306602952));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 2;
            continue;
        }
      }
label_5:
      return TypeOf.ICollection.Raw.CreateTypeSyntax(referenceInnerLogic);
label_6:
      return referenceInnerLogic;
    }

    private ISyntaxNode GetPropertyInitExpressionInnerLogic(
      ClassMetadata classMetadata,
      PropertyMetadata propertyMetadata,
      bool forFilter)
    {
      int num = 2;
      ISyntaxNode typeSyntax;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassDescriptor.qIORXYo6pVqlOJ8HkgXK(DataClassDescriptor.JJ48YKo6soAN5G2vqksH((object) propertyMetadata), DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1445902765 ^ -1980277732 ^ 539376345));
            num = 3;
            continue;
          case 2:
            DataClassDescriptor.qIORXYo6pVqlOJ8HkgXK((object) propertyMetadata, DataClassDescriptor.eSprIwo6TamAeViS3ORw(-1146510045 ^ -1146491791));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 1;
            continue;
          case 3:
            Contract.CheckArgument(propertyMetadata.Settings is DataClassSettings, (string) DataClassDescriptor.eSprIwo6TamAeViS3ORw(874012245 ^ 874127673));
            num = 5;
            continue;
          case 4:
            goto label_5;
          case 5:
            if (DataClassDescriptor.tUgChRo6c2MITFprWP0B((object) (DataClassSettings) propertyMetadata.Settings) != RelationType.OneToOne)
            {
              typeSyntax = ((string) DataClassDescriptor.vdOclno6zmcafVQlhx7m((object) this, (object) classMetadata, (object) propertyMetadata, forFilter)).CreateTypeSyntax();
              num = 4;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_5:
      return TypeOf.List.Raw.CreateTypeSyntax(typeSyntax).ObjectCreationExpression();
label_6:
      return (ISyntaxNode) null;
    }

    private DataClassMetadata LoadFromRuntime(Guid typeUid)
    {
      DataClassMetadata dataClassMetadata;
      switch (1)
      {
        case 1:
          try
          {
            dataClassMetadata = ((IMetadataService) DataClassDescriptor.ADFnaLoHBWWhfED46DkR()).GetMetadata(typeUid) as DataClassMetadata;
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
              num = 0;
            switch (num)
            {
            }
          }
          catch
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_8;
                default:
                  dataClassMetadata = (DataClassMetadata) null;
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                  continue;
              }
            }
          }
          break;
      }
label_8:
      return dataClassMetadata;
    }

    public DataClassDescriptor()
    {
      DataClassDescriptor.g8Ax4eoHW9IV5RoIitVr();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DataClassDescriptor()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            DataClassDescriptor.xmlObjSerType = new XmlObjectSerializableType();
            num = 5;
            continue;
          case 2:
            DataClassDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195733805));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 3:
            DataClassDescriptor.g8Ax4eoHW9IV5RoIitVr();
            num = 2;
            continue;
          case 4:
            DataClassDescriptor.EmptyType = (Guid.Empty, Guid.Empty, Guid.Empty, Guid.Empty);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 1 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            DataClassDescriptor.DtoTypes = new ConcurrentDictionary<string, (Guid, Guid, Guid, Guid)>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool kpvIPVo6Kf3lb7FVdbgR() => DataClassDescriptor.zOwu5po6qZjM4am1qQuq == null;

    internal static DataClassDescriptor S41pTgo6XoQuv4OYumvc() => DataClassDescriptor.zOwu5po6qZjM4am1qQuq;

    internal static object eSprIwo6TamAeViS3ORw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yHwM9Jo6kJNPvqmt1wFA() => (object) ReferenceResolverSerializer.CurrentResolver;

    internal static object RFxlNDo6n5QlX9P3QVPp(bool needResolver) => (object) ReferenceResolverSerializer.CreateResolver(needResolver);

    internal static object oEXoDIo6ObLmu3vYAwMm([In] object obj0) => (object) ((DataClass) obj0).TypeRef;

    internal static Guid uNt6Lko62Woh6Ojggfjo([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static bool Unx6Iao6e3ICR970CKAd([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object RvBNNZo6P3NCSaRhc0GC([In] object obj0) => (object) ((DataClassMetadata) obj0).TypeRef;

    internal static object fTTPMvo61fGJFAhNab7d([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static void h1rS5Do6NjXJMcQLaALk([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool RnSriio63Z3R8nInpuiY([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qIORXYo6pVqlOJ8HkgXK([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void aO8NYro6a2VBaBDb9Z2n([In] object obj0) => EntityJsonSerializer.AddSerializerMarker(obj0);

    internal static object YHsLC3o6DZurQ8J3y6Tk([In] object obj0, Type type) => ((DataClass) obj0).As(type);

    internal static object e3Cwh2o6tPS44J5ZfkX3([In] object obj0, [In] object obj1) => (object) ((DataClassDescriptor) obj0).GetValueContainer((string) obj1);

    internal static object iW4aELo6wA15LSXnWu8Q(Type type) => (object) DataClass.ValueContainer.Create(type);

    internal static object aamLuio64TfHDKEK2oiB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool MY1vipo6603cpu1dcuhV([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static void JR0gglo6HyS6MUDp9RUY([In] object obj0) => EntityJsonSerializer.InvokeActions(obj0);

    internal static bool e91vZVo6AYoAkPU6LEVm([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool oXvNXTo6711HMygSBoIj([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object lq81quo6xbfW094BMLe7(Guid componentUid, Guid metadataUid) => (object) DataClass.ValueContainer.Create(componentUid, metadataUid);

    internal static object jqdQ9uo60rJeCDVkQnML([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object lMNmTuo6m1MkcbH9IcgU([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object IQEco7o6yxxD9sbn9Qu0([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static Guid CUg7FMo6MALecOqpI86w([In] object obj0) => ((PropertyMetadata) obj0).SubTypeUid;

    internal static Type XP4tsio6Ji8bXqbtYinZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object V4CxDZo69U7VMMAgFUJ9([In] object obj0) => (object) ((ClassMetadata) obj0).FullTypeName;

    internal static Guid O0TajRo6dUNm4WmmPkIJ([In] object obj0) => ((string) obj0).GetDeterministicGuid();

    internal static object NnUBxMo6lRtRYFPjwSvO([In] object obj0) => (object) ((IRuntimeApplication) obj0).TransformationProvider;

    internal static object YMkIZAo6rdlJlKByKdxN([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object eHMQMFo6gtnQQg0bawi7([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object qlQg8no65FUBh2VPDM7C([In] object obj0) => (object) ((ITransformationProvider) obj0).ParameterSeparator;

    internal static object LARSpUo6jci4MIEfiJZl([In] object obj0) => (object) string.Concat((string[]) obj0);

    internal static object zXflKto6YrTGjlOWtLI2(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return ((XmlSerializableType<object>) obj0).NullSafeGet((DbDataReader) obj1, (string[]) obj2, (ISessionImplementor) obj3, obj4);
    }

    internal static bool omS3Qco6LhXrDIP11OkC([In] object obj0) => ((IDataReader) obj0).Read();

    internal static void aVDoEWo6UCI8jaify4UX(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object JJ48YKo6soAN5G2vqksH([In] object obj0) => (object) ((PropertyMetadata) obj0).Settings;

    internal static RelationType tUgChRo6c2MITFprWP0B([In] object obj0) => ((DataClassSettings) obj0).RelationType;

    internal static object vdOclno6zmcafVQlhx7m([In] object obj0, [In] object obj1, [In] object obj2, [In] bool obj3) => (object) ((RefTypeDescriptor<IDataClass, DataClassSettings>) obj0).GetTypeName((ClassMetadata) obj1, (PropertyMetadata) obj2, obj3);

    internal static object yQTURsoHFg7449LjgXuQ([In] object obj0) => (object) ((string) obj0).CreateTypeSyntax();

    internal static object ADFnaLoHBWWhfED46DkR() => (object) MetadataServiceContext.Service;

    internal static void g8Ax4eoHW9IV5RoIitVr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

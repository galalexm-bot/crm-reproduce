// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ExceptionScriptDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH.CustomTypes;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Описание ошибки выполнения сценария"</summary>
  [Component(Order = 1100)]
  public class ExceptionScriptDescriptor : 
    CLRTypeDescriptor<ExceptionData, ExceptionDataSettings>,
    IMappingTypeDescriptor
  {
    private static readonly FieldInfo StackTraceProp;
    /// <summary>Uid типа</summary>
    public const string UID_S = "{CF7F2032-8E10-4639-883A-1E247B021948}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static ExceptionScriptDescriptor enNR8ao7DAd4wB8aS54n;

    /// <inheritdoc />
    protected override void ExtendSimplePropertyMapping(
      INHibernatePropertyTypeMapper mapper,
      EntityPropertyMetadata propertyMetadata)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            mapper.Type<ExceptionScriptNHType>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
            continue;
          case 2:
            ExceptionScriptDescriptor.nRjIVxo74DEl0o9XTa96((object) this, (object) mapper, (object) propertyMetadata);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Описание для типа "Строка"</summary>
    [XmlIgnore]
    public StringDescriptor StringDescriptor
    {
      get => this.\u003CStringDescriptor\u003Ek__BackingField;
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
              this.\u003CStringDescriptor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    /// <summary>Описание для типа "Int32"</summary>
    [XmlIgnore]
    public Int32Descriptor Int32Descriptor
    {
      get => this.\u003CInt32Descriptor\u003Ek__BackingField;
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
              this.\u003CInt32Descriptor\u003Ek__BackingField = value;
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

    /// <summary>Uid типа</summary>
    public override Guid Uid => ExceptionScriptDescriptor.UID;

    /// <summary>Имя "Ошибка выполнения сценария"</summary>
    public override string Name => (string) ExceptionScriptDescriptor.qHh5wno7HIQQgGhQ8Gu6(ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(-2106517564 ^ -2106355706));

    public override TypeSettings CreateSettingsForFilterProperty(PropertyMetadata propertyMetadata)
    {
      int num1 = 3;
      ExceptionDataSettings forFilterProperty;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              forFilterProperty.DefaultValue = new long?();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
              continue;
            case 2:
              if (forFilterProperty != null)
                goto case 1;
              else
                goto label_6;
            case 3:
              forFilterProperty = (ExceptionDataSettings) base.CreateSettingsForFilterProperty(propertyMetadata);
              num2 = 2;
              continue;
            default:
              goto label_3;
          }
        }
label_6:
        num1 = 4;
      }
label_3:
      return (TypeSettings) forFilterProperty;
    }

    /// <inheritdoc />
    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 3;
      SerializableDictionary<string, object> serializableDictionary1;
      while (true)
      {
        int num2 = num1;
        SerializableDictionary<string, object> serializableDictionary2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              serializableDictionary2 = this.SerializeException(exceptionData.OriginalException);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 4 : 5;
              continue;
            case 2:
              SerializableDictionary<string, object> serializableDictionary3 = new SerializableDictionary<string, object>();
              serializableDictionary3.Add((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(-1088304168 ^ -1088205790), this.Int32Descriptor.SerializeSimple(ExceptionScriptDescriptor.MBlu4ro7A5n8yyEO5gXt((object) exceptionData)));
              serializableDictionary3.Add((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(1051276242 - 990076387 ^ 61300215), this.StringDescriptor.SerializeSimple((string) ExceptionScriptDescriptor.Y26oBQo77sKdMtplYaOh((object) exceptionData)));
              serializableDictionary1 = serializableDictionary3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            case 3:
              if (value is ExceptionData exceptionData)
              {
                num2 = 2;
                continue;
              }
              goto label_9;
            case 4:
            case 6:
              goto label_8;
            case 5:
              serializableDictionary1.Add((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(-1872275253 >> 6 ^ -29158071), (object) serializableDictionary2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 4 : 0;
              continue;
            case 7:
              goto label_14;
            case 8:
              goto label_13;
            default:
              if (ExceptionScriptDescriptor.eae9L7o7xAWmBLDeDgpn((object) exceptionData) == null)
              {
                num2 = 6;
                continue;
              }
              goto case 1;
          }
        }
label_9:
        if (value != null)
          num1 = 7;
        else
          goto label_13;
      }
label_8:
      return (object) serializableDictionary1;
label_13:
      return (object) null;
label_14:
      return base.SerializeSimple(value, valueType, settings);
    }

    /// <inheritdoc />
    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 2;
      string text;
      Exception exception;
      int Id;
      while (true)
      {
        int num2 = num1;
        IDictionary<string, object> dictionary1;
        object obj1;
        object obj2;
        object obj3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (TypeOf<ExceptionData>.Raw.IsAssignableFrom(deserializeToType))
              {
                num2 = 9;
                continue;
              }
              goto label_27;
            case 2:
              ExceptionScriptDescriptor.j83AoZo70qlk80s386Zs((object) deserializeToType, ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(-70007027 ^ -70021495));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 1 : 1;
              continue;
            case 3:
              dictionary1 = value as IDictionary<string, object>;
              num2 = 8;
              continue;
            case 4:
              exception = (Exception) null;
              num2 = 15;
              continue;
            case 5:
              Id = this.Int32Descriptor.DeserializeSimple(obj1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 17 : 1;
              continue;
            case 6:
            case 18:
              goto label_26;
            case 7:
              goto label_13;
            case 8:
              if (dictionary1 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 4 : 7;
                continue;
              }
              goto label_14;
            case 9:
              if (value != null)
              {
                num2 = 3;
                continue;
              }
              goto label_4;
            case 10:
              exception = this.DeserializeException(dictionary2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 5 : 6;
              continue;
            case 11:
              text = this.StringDescriptor.DeserializeSimple(obj2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 11 : 14;
              continue;
            case 12:
              text = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 0;
              continue;
            case 13:
              goto label_4;
            case 14:
              if (!dictionary1.TryGetValue((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(-53329496 >> 4 ^ -3167184), out obj3))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 18 : 10;
                continue;
              }
              goto case 16;
            case 15:
              if (!dictionary1.TryGetValue((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(1242972401 >> 4 ^ 77849589), out obj1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 16:
              if (obj3 is IDictionary<string, object> dictionary2)
              {
                num2 = 10;
                continue;
              }
              goto label_26;
            default:
              if (dictionary1.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413466119), out obj2))
              {
                num2 = 11;
                continue;
              }
              goto case 14;
          }
        }
label_14:
        Id = 0;
        num1 = 12;
      }
label_4:
      return (object) null;
label_13:
      return (object) new ExceptionData();
label_26:
      return (object) new ExceptionData(Id, text, exception);
label_27:
      return base.DeserializeSimple(value, deserializeToType);
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="entityMetadata"></param>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    private SerializableDictionary<string, object> SerializeException(Exception exception)
    {
      Contract.ArgumentNotNull((object) exception, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283547275));
      object obj1 = this.StringDescriptor.SerializeSimple(exception.StackTrace);
      object obj2 = this.StringDescriptor.SerializeSimple(exception.Message);
      SerializableDictionary<string, object> serializableDictionary1 = new SerializableDictionary<string, object>();
      serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561240830), obj1);
      serializableDictionary1.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218592842), obj2);
      SerializableDictionary<string, object> serializableDictionary2 = serializableDictionary1;
      if (exception.InnerException != null)
      {
        SerializableDictionary<string, object> serializableDictionary3 = this.SerializeException(exception.InnerException);
        serializableDictionary2.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105361508), (object) serializableDictionary3);
      }
      return serializableDictionary2;
    }

    private Exception DeserializeException(IDictionary<string, object> dictionary)
    {
      string message = (string) null;
      string str = (string) null;
      Exception innerException = (Exception) null;
      object obj1;
      if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643690015), out obj1))
        message = this.StringDescriptor.DeserializeSimple(obj1);
      object obj2;
      if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957724122), out obj2))
        str = this.StringDescriptor.DeserializeSimple(obj2);
      object obj3;
      if (dictionary.TryGetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638564241), out obj3) && obj3 is IDictionary<string, object> dictionary1)
        innerException = this.DeserializeException(dictionary1);
      Exception exception = new Exception(message, innerException);
      ExceptionScriptDescriptor.StackTraceProp.SetValue((object) exception, (object) str);
      return exception;
    }

    public ExceptionScriptDescriptor()
    {
      ExceptionScriptDescriptor.QHpfdAo7mFFDid6WnUIy();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ExceptionScriptDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            ExceptionScriptDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218592918));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 2 : 2;
            continue;
          default:
            // ISSUE: type reference
            ExceptionScriptDescriptor.StackTraceProp = ExceptionScriptDescriptor.Buidhxo7yrDKO1H5OOW3(__typeref (Exception)).GetField((string) ExceptionScriptDescriptor.iGpVkeo76MWd9H2vImN6(323422137 << 2 ^ 1293850234), BindingFlags.Instance | BindingFlags.NonPublic);
            num = 3;
            continue;
        }
      }
label_2:;
    }

    internal static void nRjIVxo74DEl0o9XTa96([In] object obj0, [In] object obj1, [In] object obj2) => __nonvirtual (((SimpleTypeDescriptor<ExceptionData>) obj0).ExtendSimplePropertyMapping((INHibernatePropertyTypeMapper) obj1, (EntityPropertyMetadata) obj2));

    internal static bool D1FkIlo7tOUeABNId2Yb() => ExceptionScriptDescriptor.enNR8ao7DAd4wB8aS54n == null;

    internal static ExceptionScriptDescriptor bC2k2go7wPCuAL8nDp2I() => ExceptionScriptDescriptor.enNR8ao7DAd4wB8aS54n;

    internal static object iGpVkeo76MWd9H2vImN6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qHh5wno7HIQQgGhQ8Gu6([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static int MBlu4ro7A5n8yyEO5gXt([In] object obj0) => ((ExceptionData) obj0).ExceptionCode;

    internal static object Y26oBQo77sKdMtplYaOh([In] object obj0) => (object) ((ExceptionData) obj0).Message;

    internal static object eae9L7o7xAWmBLDeDgpn([In] object obj0) => (object) ((ExceptionData) obj0).OriginalException;

    internal static void j83AoZo70qlk80s386Zs([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void QHpfdAo7mFFDid6WnUIy() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type Buidhxo7yrDKO1H5OOW3([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);
  }
}

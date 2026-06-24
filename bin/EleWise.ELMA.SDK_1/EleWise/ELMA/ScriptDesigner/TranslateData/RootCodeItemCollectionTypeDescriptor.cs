// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.RootCodeItemCollectionTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Groups;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  public class RootCodeItemCollectionTypeDescriptor : 
    CLRTypeDescriptor<RootCodeItemCollection, RootCodeItemTypeSettings>
  {
    public const string UID_S = "B996B108-7A4D-4240-B96B-C6C1D99636D7";
    public static readonly Guid UID;
    private static RootCodeItemCollectionTypeDescriptor heP9XKZzdy5blolWard;

    /// <summary>Uid типа</summary>
    public override Guid Uid => RootCodeItemCollectionTypeDescriptor.UID;

    /// <summary>Видимость</summary>
    public override bool Visible => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Список ссылок на веб-сервисы"</summary>
    public override string Name => (string) RootCodeItemCollectionTypeDescriptor.cP6H6YuopRRJcDKYqtM(RootCodeItemCollectionTypeDescriptor.gJTPikuWA1SRi78qjG9(1574260816 ^ 1574246776));

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398677918));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576131338));
      obj = obj.CastAsRealType();
      PropertyInfo property = obj.GetProperty(metadata, propertyMetadata);
      if (property == (PropertyInfo) null || !property.CanRead)
        return (IDictionary<string, object>) null;
      object obj1 = property.GetValue(obj, (object[]) null);
      SerializableDictionary<string, object> serializableDictionary = new SerializableDictionary<string, object>();
      if (obj1 != null)
        serializableDictionary[propertyMetadata.Name] = this.SerializeSimple(obj1, obj1.GetType(), settings);
      return (IDictionary<string, object>) serializableDictionary;
    }

    public override object SerializeSimple(
      object value,
      Type valueType,
      EntitySerializationSettings settings)
    {
      int num1 = 2;
      MemoryStream memoryStream1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            memoryStream1 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_4:
      object obj;
      try
      {
        MemoryStream memoryStream2 = (MemoryStream) RootCodeItemCollectionTypeDescriptor.RZABvGub6DQKco9Db84();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              StreamWriter streamWriter = new StreamWriter((Stream) memoryStream2);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    RootCodeItemCollectionTypeDescriptor.UR0wGyuhiQvAS40NPci((object) streamWriter, (object) value.GetType().AssemblyQualifiedName);
                    int num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                      num4 = 0;
                    while (true)
                    {
                      int num5;
                      switch (num4)
                      {
                        case 1:
                          streamWriter.Flush();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 4;
                          continue;
                        case 2:
                        case 3:
                          goto label_2;
                        case 4:
                          RootCodeItemCollectionTypeDescriptor.qVg5gwuGd3BpRnX4BoI((object) memoryStream1, (object) memoryStream2);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                          continue;
                        case 5:
                          RootCodeItemCollectionTypeDescriptor.NCpy7suEqSs24xRFpRH((object) memoryStream2, 0L, SeekOrigin.Begin);
                          num5 = 6;
                          break;
                        case 6:
                          obj = (object) MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) RootCodeItemCollectionTypeDescriptor.PyafcGufu5s7Jv12TFN((object) memoryStream2), memoryStream2, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(this.SerializeSimpleAction));
                          num5 = 7;
                          break;
                        case 7:
                          goto label_3;
                        default:
                          if (memoryStream2.Length <= 0L)
                          {
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 0;
                            continue;
                          }
                          goto case 5;
                      }
                      num4 = num5;
                    }
                  }
                  finally
                  {
                    int num6;
                    if (streamWriter == null)
                      num6 = 2;
                    else
                      goto label_25;
label_24:
                    switch (num6)
                    {
                      case 1:
                        break;
                      default:
                    }
label_25:
                    RootCodeItemCollectionTypeDescriptor.QB8sxDuQNYic9cnHR7k((object) streamWriter);
                    num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0)
                    {
                      num6 = 0;
                      goto label_24;
                    }
                    else
                      goto label_24;
                  }
              }
            }
            finally
            {
              if (memoryStream2 != null)
              {
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                  num7 = 0;
                while (true)
                {
                  switch (num7)
                  {
                    case 1:
                      goto label_33;
                    default:
                      memoryStream2.Dispose();
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
                      continue;
                  }
                }
              }
label_33:;
            }
        }
      }
      finally
      {
        int num8;
        if (memoryStream1 == null)
          num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 1 : 1;
        else
          goto label_37;
label_36:
        switch (num8)
        {
          case 2:
            break;
          default:
        }
label_37:
        memoryStream1.Dispose();
        num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        {
          num8 = 0;
          goto label_36;
        }
        else
          goto label_36;
      }
label_3:
      return obj;
    }

    /// <summary>Сериализовать данные с использованием буфера</summary>
    /// <param name="buffer">Буфер</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина буфера</param>
    /// <param name="memoryStream">Поток в памяти</param>
    /// <returns>Сериализованные данные</returns>
    private string SerializeSimpleAction(
      byte[] buffer,
      int offset,
      int length,
      MemoryStream memoryStream)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            RootCodeItemCollectionTypeDescriptor.IcU75nuCXX5IkESQYPG((object) memoryStream, (object) buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) RootCodeItemCollectionTypeDescriptor.FTip4Cuvkp327kiRovI((object) BitConverter.ToString(buffer, offset, length), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 121999470), (object) "");
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num1 = 3;
      string str;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              str = value.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
              continue;
            case 2:
              RootCodeItemCollectionTypeDescriptor.did6Seu8Hs28X1ctBjD((object) deserializeToType, RootCodeItemCollectionTypeDescriptor.gJTPikuWA1SRi78qjG9(-1487388570 ^ -1487402526));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_3;
            default:
              goto label_6;
          }
        }
label_3:
        RootCodeItemCollectionTypeDescriptor.did6Seu8Hs28X1ctBjD(value, RootCodeItemCollectionTypeDescriptor.gJTPikuWA1SRi78qjG9(647913418 ^ 647894716));
        num1 = 2;
      }
label_6:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(RootCodeItemCollectionTypeDescriptor.gnJk7cuZyJlE7RTys1D((object) str) >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.DeserializeSimpleAction));
    }

    /// <summary>Десериализовать данные c использование буфера</summary>
    /// <param name="buffer">Буфер</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина буфера</param>
    /// <param name="hexString">HEX-строка</param>
    /// <returns>Объект</returns>
    private object DeserializeSimpleAction(
      byte[] buffer,
      int offset,
      int length,
      string hexString)
    {
      int num1 = 4;
      MemoryStream memoryStream;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
            case 3:
              goto label_37;
            case 4:
              num3 = 0;
              num2 = 3;
              continue;
            case 5:
            case 6:
              buffer[offset + num3] = Convert.ToByte(hexString.Substring(num3 << 1, 2), 16);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 2 : 8;
              continue;
            case 7:
              goto label_7;
            case 8:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 2;
              continue;
            default:
              goto label_5;
          }
        }
label_4:
        memoryStream = (MemoryStream) RootCodeItemCollectionTypeDescriptor.gOtXS7uuMo8k6CdeeqI((object) buffer, offset, length, false);
        num1 = 7;
        continue;
label_37:
        if (num3 < length)
          num1 = 5;
        else
          goto label_4;
      }
label_5:
      object obj;
      return obj;
label_7:
      try
      {
        StreamReader streamReader = new StreamReader((Stream) memoryStream);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
          num4 = 0;
        switch (num4)
        {
          default:
            try
            {
              Type tp = RootCodeItemCollectionTypeDescriptor.thacRZuVgNfC6oRbIZL(RootCodeItemCollectionTypeDescriptor.DEEhdSuIuH5nosChvD9((object) streamReader));
              int num5 = 2;
              XmlTextReader reader;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    reader = new XmlTextReader((TextReader) streamReader);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
                    continue;
                  case 2:
                    streamReader.CheckAndCorrectInternalBOMSymbols();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 1 : 1;
                    continue;
                  default:
                    goto label_15;
                }
              }
label_15:
              try
              {
                obj = ClassSerializationHelper.DeserializeObjectByXml(tp, (XmlReader) reader);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_5;
                }
              }
              finally
              {
                if (reader != null)
                {
                  int num7 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        reader.Dispose();
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_24;
                    }
                  }
                }
label_24:;
              }
            }
            finally
            {
              int num8;
              if (streamReader == null)
                num8 = 2;
              else
                goto label_28;
label_27:
              switch (num8)
              {
                case 1:
                case 2:
              }
label_28:
              RootCodeItemCollectionTypeDescriptor.QB8sxDuQNYic9cnHR7k((object) streamReader);
              num8 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
              {
                num8 = 0;
                goto label_27;
              }
              else
                goto label_27;
            }
        }
      }
      finally
      {
        int num9;
        if (memoryStream == null)
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
        else
          goto label_34;
label_33:
        switch (num9)
        {
          case 2:
            break;
          default:
        }
label_34:
        memoryStream.Dispose();
        num9 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
        {
          num9 = 1;
          goto label_33;
        }
        else
          goto label_33;
      }
    }

    /// <summary>Получить тип колонки в БД</summary>
    /// <param name="propertyMetadata">Метаданные свойства (не может быть NULL)</param>
    /// <returns>Тип колонки БД</returns>
    protected override ColumnType GetDbColumnType(
      EntityMetadata entityMetadata,
      EntityPropertyMetadata propertyMetadata)
    {
      return new ColumnType(DbType.Binary);
    }

    public RootCodeItemCollectionTypeDescriptor()
    {
      RootCodeItemCollectionTypeDescriptor.xrhiYKuSkn6faFmJMY0();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static RootCodeItemCollectionTypeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            RootCodeItemCollectionTypeDescriptor.UID = new Guid((string) RootCodeItemCollectionTypeDescriptor.gJTPikuWA1SRi78qjG9(~289714581 ^ -289732672));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object gJTPikuWA1SRi78qjG9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cP6H6YuopRRJcDKYqtM([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool YOuHwNuFGDcAlgHOWtQ() => RootCodeItemCollectionTypeDescriptor.heP9XKZzdy5blolWard == null;

    internal static RootCodeItemCollectionTypeDescriptor SADE0QuB5MBJtIo3PEs() => RootCodeItemCollectionTypeDescriptor.heP9XKZzdy5blolWard;

    internal static object RZABvGub6DQKco9Db84() => (object) MemoryHelper.GetMemoryStream();

    internal static void UR0wGyuhiQvAS40NPci([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void qVg5gwuGd3BpRnX4BoI([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long NCpy7suEqSs24xRFpRH([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static long PyafcGufu5s7Jv12TFN([In] object obj0) => ((Stream) obj0).Length;

    internal static void QB8sxDuQNYic9cnHR7k([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int IcU75nuCXX5IkESQYPG([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

    internal static object FTip4Cuvkp327kiRovI([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void did6Seu8Hs28X1ctBjD([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int gnJk7cuZyJlE7RTys1D([In] object obj0) => ((string) obj0).Length;

    internal static object gOtXS7uuMo8k6CdeeqI([In] object obj0, int offset, int length, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);

    internal static object DEEhdSuIuH5nosChvD9([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static Type thacRZuVgNfC6oRbIZL([In] object obj0) => Type.GetType((string) obj0);

    internal static void xrhiYKuSkn6faFmJMY0() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

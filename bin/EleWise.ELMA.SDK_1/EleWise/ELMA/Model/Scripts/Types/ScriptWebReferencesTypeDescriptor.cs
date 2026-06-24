// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.ScriptWebReferencesTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Types.Settings;
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

namespace EleWise.ELMA.Model.Scripts.Types
{
  /// <summary>Описание типа "Список ссылок на веб-сервисы"</summary>
  public class ScriptWebReferencesTypeDescriptor : 
    CLRTypeDescriptor<List<ScriptWebReference>, ScriptWebReferencesTypeSettings>
  {
    public const string UID_S = "{F14334F8-4964-4A0E-9846-D7687933F0A4}";
    public static readonly Guid UID;
    private static ScriptWebReferencesTypeDescriptor JrCfTSbkJPu17sgngFZr;

    /// <summary>Uid типа</summary>
    public override Guid Uid => ScriptWebReferencesTypeDescriptor.UID;

    /// <summary>Видимость</summary>
    public override bool Visible => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Список ссылок на веб-сервисы"</summary>
    public override string Name => (string) ScriptWebReferencesTypeDescriptor.YdEiVobkrgn0YZsckYkG(ScriptWebReferencesTypeDescriptor.fLWVvabklMXHN6QegAhT(-35995181 ^ -36174589));

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870906615));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824374065));
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
            goto label_5;
          case 2:
            memoryStream1 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) null;
label_5:
      object obj;
      try
      {
        MemoryStream memoryStream2 = (MemoryStream) ScriptWebReferencesTypeDescriptor.vl3u6lbkgQTRfstsOf6U();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              StreamWriter streamWriter = new StreamWriter((Stream) memoryStream2);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    ScriptWebReferencesTypeDescriptor.vBGZP4bk5o8wQ9SkUs1m((object) streamWriter, (object) value.GetType().AssemblyQualifiedName);
                    int num4 = 2;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                        case 3:
                          goto label_3;
                        case 2:
                          ScriptWebReferencesTypeDescriptor.PWmJcZbkj2Dhs84Il6HR((object) streamWriter);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 5 : 3;
                          continue;
                        case 4:
                          ScriptWebReferencesTypeDescriptor.WxanLsbkUd6PoJh3Z2SO((object) memoryStream2, 0L, SeekOrigin.Begin);
                          num4 = 6;
                          continue;
                        case 5:
                          ScriptWebReferencesTypeDescriptor.MafpDIbkYoNKppYBiBvb((object) memoryStream1, (object) memoryStream2);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 7 : 1;
                          continue;
                        case 6:
                          obj = (object) MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) ScriptWebReferencesTypeDescriptor.smwHD9bkLqgTEEVUm7Cb((object) memoryStream2), memoryStream2, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(this.SerializeSimpleAction));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                          continue;
                        case 7:
                          if (ScriptWebReferencesTypeDescriptor.smwHD9bkLqgTEEVUm7Cb((object) memoryStream2) <= 0L)
                          {
                            num4 = 3;
                            continue;
                          }
                          goto case 4;
                        default:
                          goto label_4;
                      }
                    }
                  }
                  finally
                  {
                    int num5;
                    if (streamWriter == null)
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
                    else
                      goto label_24;
label_23:
                    switch (num5)
                    {
                      case 2:
                        break;
                      default:
                    }
label_24:
                    ScriptWebReferencesTypeDescriptor.NUpohCbks7DFGkPqW0tb((object) streamWriter);
                    num5 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
                    {
                      num5 = 1;
                      goto label_23;
                    }
                    else
                      goto label_23;
                  }
              }
            }
            finally
            {
              if (memoryStream2 != null)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_32;
                    default:
                      ScriptWebReferencesTypeDescriptor.NUpohCbks7DFGkPqW0tb((object) memoryStream2);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_32:;
            }
        }
      }
      finally
      {
        if (memoryStream1 != null)
        {
          int num7 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
            num7 = 1;
          while (true)
          {
            switch (num7)
            {
              case 1:
                ScriptWebReferencesTypeDescriptor.NUpohCbks7DFGkPqW0tb((object) memoryStream1);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                continue;
              default:
                goto label_38;
            }
          }
        }
label_38:;
      }
label_4:
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
            memoryStream.Read(buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return BitConverter.ToString(buffer, offset, length).Replace((string) ScriptWebReferencesTypeDescriptor.fLWVvabklMXHN6QegAhT(1218962250 ^ 1218964774), "");
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 2;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) deserializeToType, (string) ScriptWebReferencesTypeDescriptor.fLWVvabklMXHN6QegAhT(-16752921 ^ -16771229));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 2;
            continue;
          case 2:
            ScriptWebReferencesTypeDescriptor.EnUj4RbkcJhlQPZtVFTF(value, ScriptWebReferencesTypeDescriptor.fLWVvabklMXHN6QegAhT(1581325282 << 3 ^ -234318234));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
            continue;
          case 3:
            str = value.ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(ScriptWebReferencesTypeDescriptor.PgjKD7bkzBfngkLltGAV((object) str) >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.DeserializeSimpleAction));
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
      int num1 = 2;
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
            case 5:
              if (num3 >= length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 6 : 6;
                continue;
              }
              goto case 4;
            case 2:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              buffer[offset + num3] = ScriptWebReferencesTypeDescriptor.b7OoHjbnF1snugQrNybH((object) hexString.Substring(num3 << 1, 2), 16);
              num2 = 3;
              continue;
            case 6:
              memoryStream = (MemoryStream) ScriptWebReferencesTypeDescriptor.xVuW6JbnBAvtkBbEPna4((object) buffer, offset, length, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 7 : 6;
              continue;
            case 7:
              goto label_8;
            default:
              goto label_6;
          }
        }
label_7:
        ++num3;
        num1 = 5;
      }
label_6:
      object obj;
      return obj;
label_8:
      try
      {
        StreamReader streamReader = new StreamReader((Stream) memoryStream);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
          num4 = 0;
        switch (num4)
        {
          default:
            try
            {
              Type tp = ScriptWebReferencesTypeDescriptor.BwDf92bnoIbt2Ng3AltY(ScriptWebReferencesTypeDescriptor.nVwKgObnWvKuUTMlxVtU((object) streamReader));
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
                num5 = 0;
              XmlReader reader;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    reader = XmlReader.Create((TextReader) streamReader);
                    num5 = 2;
                    continue;
                  case 2:
                    goto label_17;
                  default:
                    streamReader.CheckAndCorrectInternalBOMSymbols();
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
                    continue;
                }
              }
label_17:
              try
              {
                obj = ClassSerializationHelper.DeserializeObjectByXml(tp, reader);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                    goto label_6;
                }
              }
              finally
              {
                int num7;
                if (reader == null)
                  num7 = 2;
                else
                  goto label_23;
label_22:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_23:
                ScriptWebReferencesTypeDescriptor.NUpohCbks7DFGkPqW0tb((object) reader);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
                {
                  num7 = 0;
                  goto label_22;
                }
                else
                  goto label_22;
              }
            }
            finally
            {
              if (streamReader != null)
              {
                int num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                  num8 = 1;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      streamReader.Dispose();
                      num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_31;
                  }
                }
              }
label_31:;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num9 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
            num9 = 1;
          while (true)
          {
            switch (num9)
            {
              case 1:
                ScriptWebReferencesTypeDescriptor.NUpohCbks7DFGkPqW0tb((object) memoryStream);
                num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                continue;
              default:
                goto label_37;
            }
          }
        }
label_37:;
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

    public ScriptWebReferencesTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptWebReferencesTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptWebReferencesTypeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146395951));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 0 : 0;
            continue;
          case 2:
            ScriptWebReferencesTypeDescriptor.D6dtqLbnbU8HVhWCtqif();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object fLWVvabklMXHN6QegAhT(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YdEiVobkrgn0YZsckYkG([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool RgYqpcbk9IbQQTwW7LVU() => ScriptWebReferencesTypeDescriptor.JrCfTSbkJPu17sgngFZr == null;

    internal static ScriptWebReferencesTypeDescriptor EOoXv1bkdnK1qltTnnM2() => ScriptWebReferencesTypeDescriptor.JrCfTSbkJPu17sgngFZr;

    internal static object vl3u6lbkgQTRfstsOf6U() => (object) MemoryHelper.GetMemoryStream();

    internal static void vBGZP4bk5o8wQ9SkUs1m([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void PWmJcZbkj2Dhs84Il6HR([In] object obj0) => ((TextWriter) obj0).Flush();

    internal static void MafpDIbkYoNKppYBiBvb([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long smwHD9bkLqgTEEVUm7Cb([In] object obj0) => ((Stream) obj0).Length;

    internal static long WxanLsbkUd6PoJh3Z2SO([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void NUpohCbks7DFGkPqW0tb([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void EnUj4RbkcJhlQPZtVFTF([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int PgjKD7bkzBfngkLltGAV([In] object obj0) => ((string) obj0).Length;

    internal static byte b7OoHjbnF1snugQrNybH([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static object xVuW6JbnBAvtkBbEPna4(
      [In] object obj0,
      int offset,
      int length,
      bool writable)
    {
      return (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);
    }

    internal static object nVwKgObnWvKuUTMlxVtU([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static Type BwDf92bnoIbt2Ng3AltY([In] object obj0) => Type.GetType((string) obj0);

    internal static void D6dtqLbnbU8HVhWCtqif() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

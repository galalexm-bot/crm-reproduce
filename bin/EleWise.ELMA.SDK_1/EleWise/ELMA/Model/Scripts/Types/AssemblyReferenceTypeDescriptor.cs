// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.AssemblyReferenceTypeDescriptor
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
  public class AssemblyReferenceTypeDescriptor : 
    CLRTypeDescriptor<List<AssemblyReference>, AssemblyReferenceTypeSettings>
  {
    public const string UID_S = "{6D4B839B-DADA-4BA9-B163-33A771E84039}";
    public static readonly Guid UID;
    internal static AssemblyReferenceTypeDescriptor LEsPZKbT43vMrs5Evohv;

    /// <summary>Uid типа</summary>
    public override Guid Uid => AssemblyReferenceTypeDescriptor.UID;

    /// <summary>Видимость</summary>
    public override bool Visible => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Список ссылок на веб-сервисы"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) AssemblyReferenceTypeDescriptor.PIBRMUbTAslOu3oHQAdL(323422137 << 2 ^ 1293867572));

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138174650));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461643979));
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
            goto label_3;
          case 2:
            memoryStream1 = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream(value);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          default:
            goto label_38;
        }
      }
label_3:
      object obj;
      try
      {
        MemoryStream memoryStream2 = (MemoryStream) AssemblyReferenceTypeDescriptor.DlRIa6bT7PJtuXjPhUsv();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              StreamWriter streamWriter = new StreamWriter((Stream) memoryStream2);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  try
                  {
                    AssemblyReferenceTypeDescriptor.Ex4BjAbTxjmvFFjnoGVs((object) streamWriter, (object) value.GetType().AssemblyQualifiedName);
                    int num4 = 2;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0)
                      num4 = 3;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          if (AssemblyReferenceTypeDescriptor.V6cpcCbTy4BJJiLFPyTF((object) memoryStream2) <= 0L)
                          {
                            num4 = 2;
                            continue;
                          }
                          goto case 7;
                        case 2:
                        case 4:
                          goto label_38;
                        case 3:
                          AssemblyReferenceTypeDescriptor.me51V1bT0md82PfXCTE9((object) streamWriter);
                          num4 = 5;
                          continue;
                        case 5:
                          AssemblyReferenceTypeDescriptor.GofTphbTmcD4yFkiWKuo((object) memoryStream1, (object) memoryStream2);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                          continue;
                        case 6:
                          goto label_39;
                        case 7:
                          AssemblyReferenceTypeDescriptor.NAKCyKbTMXe3NTb7Ubak((object) memoryStream2, 0L, SeekOrigin.Begin);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                          continue;
                        default:
                          obj = (object) MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) AssemblyReferenceTypeDescriptor.V6cpcCbTy4BJJiLFPyTF((object) memoryStream2), memoryStream2, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(this.SerializeSimpleAction));
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 6;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    int num5;
                    if (streamWriter == null)
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
                    else
                      goto label_23;
label_22:
                    switch (num5)
                    {
                      case 2:
                        break;
                      default:
                    }
label_23:
                    AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) streamWriter);
                    num5 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                    {
                      num5 = 0;
                      goto label_22;
                    }
                    else
                      goto label_22;
                  }
              }
            }
            finally
            {
              if (memoryStream2 != null)
              {
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0)
                  num6 = 0;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_31;
                    default:
                      AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) memoryStream2);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_31:;
            }
        }
      }
      finally
      {
        if (memoryStream1 != null)
        {
          int num7 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
            num7 = 0;
          while (true)
          {
            switch (num7)
            {
              case 1:
                AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) memoryStream1);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 0;
                continue;
              default:
                goto label_37;
            }
          }
        }
label_37:;
      }
label_39:
      return obj;
label_38:
      return (object) null;
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
            AssemblyReferenceTypeDescriptor.oxpiOMbT9kJE6VeSrW8Q((object) memoryStream, (object) buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) AssemblyReferenceTypeDescriptor.hynq6lbTlO5VhHTCmjkf(AssemblyReferenceTypeDescriptor.FGN5tCbTdSAVCuuuLuCs((object) buffer, offset, length), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477142090), (object) "");
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
              goto label_6;
            case 2:
              AssemblyReferenceTypeDescriptor.go4y84bTr3sFMZxrK7dS((object) deserializeToType, AssemblyReferenceTypeDescriptor.PIBRMUbTAslOu3oHQAdL(1925118608 << 2 ^ -889478204));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_5;
            default:
              str = value.ToString();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 0;
              continue;
          }
        }
label_5:
        AssemblyReferenceTypeDescriptor.go4y84bTr3sFMZxrK7dS(value, AssemblyReferenceTypeDescriptor.PIBRMUbTAslOu3oHQAdL(-1598106783 - -968262081 ^ -629859244));
        num1 = 2;
      }
label_6:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(AssemblyReferenceTypeDescriptor.rsSfYebTgMSwdaUIT6Br((object) str) >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.DeserializeSimpleAction));
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
      int num1 = 7;
      MemoryStream memoryStream;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
          case 6:
            if (num2 < length)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 2:
            goto label_3;
          case 4:
            goto label_4;
          case 5:
            memoryStream = (MemoryStream) AssemblyReferenceTypeDescriptor.CVl7PdbTjfSPfrZlgnEK((object) buffer, offset, length, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 4 : 3;
            continue;
          case 7:
            num2 = 0;
            num1 = 6;
            continue;
          case 8:
            ++num2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
            continue;
          default:
            buffer[offset + num2] = AssemblyReferenceTypeDescriptor.CO4g3BbT5urVmpC5OfPx((object) hexString.Substring(num2 << 1, 2), 16);
            num1 = 8;
            continue;
        }
      }
label_3:
      object obj;
      return obj;
label_4:
      try
      {
        StreamReader streamReader = new StreamReader((Stream) memoryStream);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              Type tp = AssemblyReferenceTypeDescriptor.QUX57BbTLFmNYWuKgjwh(AssemblyReferenceTypeDescriptor.MldB5jbTYJsLbLRouJdt((object) streamReader));
              int num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                num4 = 1;
              XmlReader reader;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    AssemblyReferenceTypeDescriptor.TNj3qrbTUR5EmFwgdLPx((object) streamReader);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_13;
                  default:
                    reader = (XmlReader) AssemblyReferenceTypeDescriptor.DboIRQbTs3yhk45xaROF((object) streamReader);
                    num4 = 2;
                    continue;
                }
              }
label_13:
              try
              {
                obj = ClassSerializationHelper.DeserializeObjectByXml(tp, reader);
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                    goto label_3;
                }
              }
              finally
              {
                if (reader != null)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                    num6 = 0;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        goto label_21;
                      default:
                        AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) reader);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_21:;
              }
            }
            finally
            {
              int num7;
              if (streamReader == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
              else
                goto label_25;
label_24:
              switch (num7)
              {
                case 2:
                  break;
                default:
              }
label_25:
              AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) streamReader);
              num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
              {
                num7 = 1;
                goto label_24;
              }
              else
                goto label_24;
            }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num8 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
            num8 = 1;
          while (true)
          {
            switch (num8)
            {
              case 1:
                AssemblyReferenceTypeDescriptor.B30w1NbTJwR5qKgw8Ss5((object) memoryStream);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
                continue;
              default:
                goto label_33;
            }
          }
        }
label_33:;
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

    public AssemblyReferenceTypeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static AssemblyReferenceTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AssemblyReferenceTypeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669484775));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            AssemblyReferenceTypeDescriptor.MR8w00bTc8xqU7QHIg9Z();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object PIBRMUbTAslOu3oHQAdL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool naAReGbT6hRsL4Jia8t7() => AssemblyReferenceTypeDescriptor.LEsPZKbT43vMrs5Evohv == null;

    internal static AssemblyReferenceTypeDescriptor vRvHhRbTHVICb4dUuGmM() => AssemblyReferenceTypeDescriptor.LEsPZKbT43vMrs5Evohv;

    internal static object DlRIa6bT7PJtuXjPhUsv() => (object) MemoryHelper.GetMemoryStream();

    internal static void Ex4BjAbTxjmvFFjnoGVs([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void me51V1bT0md82PfXCTE9([In] object obj0) => ((TextWriter) obj0).Flush();

    internal static void GofTphbTmcD4yFkiWKuo([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long V6cpcCbTy4BJJiLFPyTF([In] object obj0) => ((Stream) obj0).Length;

    internal static long NAKCyKbTMXe3NTb7Ubak([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void B30w1NbTJwR5qKgw8Ss5([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static int oxpiOMbT9kJE6VeSrW8Q([In] object obj0, [In] object obj1, [In] int obj2, [In] int obj3) => ((Stream) obj0).Read((byte[]) obj1, obj2, obj3);

    internal static object FGN5tCbTdSAVCuuuLuCs([In] object obj0, [In] int obj1, [In] int obj2) => (object) BitConverter.ToString((byte[]) obj0, obj1, obj2);

    internal static object hynq6lbTlO5VhHTCmjkf([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void go4y84bTr3sFMZxrK7dS([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int rsSfYebTgMSwdaUIT6Br([In] object obj0) => ((string) obj0).Length;

    internal static byte CO4g3BbT5urVmpC5OfPx([In] object obj0, [In] int obj1) => Convert.ToByte((string) obj0, obj1);

    internal static object CVl7PdbTjfSPfrZlgnEK(
      [In] object obj0,
      int offset,
      int length,
      bool writable)
    {
      return (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);
    }

    internal static object MldB5jbTYJsLbLRouJdt([In] object obj0) => (object) ((TextReader) obj0).ReadLine();

    internal static Type QUX57BbTLFmNYWuKgjwh([In] object obj0) => Type.GetType((string) obj0);

    internal static void TNj3qrbTUR5EmFwgdLPx([In] object obj0) => ((StreamReader) obj0).CheckAndCorrectInternalBOMSymbols();

    internal static object DboIRQbTs3yhk45xaROF([In] object obj0) => (object) XmlReader.Create((TextReader) obj0);

    internal static void MR8w00bTc8xqU7QHIg9Z() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

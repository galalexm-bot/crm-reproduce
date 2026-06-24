// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.ScriptMethodDeclarationTypeDescriptor
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
  public class ScriptMethodDeclarationTypeDescriptor : 
    CLRTypeDescriptor<List<ScriptMethodDeclaration>, ScriptMethodDeclarationTypeSettings>
  {
    public const string UID_S = "{D6E0683F-B70F-4D65-B3FF-E1987CBD40A5}";
    public static readonly Guid UID;
    internal static ScriptMethodDeclarationTypeDescriptor wJMt2PbTS97aQBqnlb0p;

    /// <summary>Uid типа</summary>
    public override Guid Uid => ScriptMethodDeclarationTypeDescriptor.UID;

    /// <summary>Видимость</summary>
    public override bool Visible => false;

    /// <summary>Uid родительской группы типов данных</summary>
    public override Guid ParentUid => SystemTypesDescriptor.UID;

    /// <summary>Имя "Список ссылок на веб-сервисы"</summary>
    public override string Name => (string) ScriptMethodDeclarationTypeDescriptor.Tk5isJbTKuAAynbVN3t0(ScriptMethodDeclarationTypeDescriptor.viY0t0bTqLbSlXr95T7a(-1487388570 ^ -1487240152));

    public override IDictionary<string, object> Serialize(
      object obj,
      ClassMetadata metadata,
      PropertyMetadata propertyMetadata,
      EntitySerializationSettings settings)
    {
      if (obj == null)
        return (IDictionary<string, object>) null;
      if (metadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998520828));
      if (propertyMetadata == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418455000));
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
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
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
        MemoryStream memoryStream2 = (MemoryStream) ScriptMethodDeclarationTypeDescriptor.B5eMnGbTX9yj5MfTUQkn();
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
                    ScriptMethodDeclarationTypeDescriptor.vpOi25bTTnpt8ayH4CaV((object) streamWriter, (object) value.GetType().AssemblyQualifiedName);
                    int num4 = 5;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          goto label_2;
                        case 2:
                          goto label_3;
                        case 3:
                          ScriptMethodDeclarationTypeDescriptor.LjQYlebTOwXx7Ib0PCPu((object) memoryStream2, 0L, SeekOrigin.Begin);
                          num4 = 4;
                          continue;
                        case 4:
                          obj = (object) MemoryHelper.ActionWithMemoryBuffer<byte, MemoryStream, string>((int) ScriptMethodDeclarationTypeDescriptor.cD24y4bTn5YuyS9Fkfxk((object) memoryStream2), memoryStream2, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, MemoryStream, string>(this.SerializeSimpleAction));
                          num4 = 2;
                          continue;
                        case 5:
                          streamWriter.Flush();
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                          continue;
                        case 6:
                          if (ScriptMethodDeclarationTypeDescriptor.cD24y4bTn5YuyS9Fkfxk((object) memoryStream2) > 0L)
                          {
                            num4 = 3;
                            continue;
                          }
                          goto label_2;
                        default:
                          ScriptMethodDeclarationTypeDescriptor.T98eKUbTkmsIG9GEIIVm((object) memoryStream1, (object) memoryStream2);
                          num4 = 6;
                          continue;
                      }
                    }
                  }
                  finally
                  {
                    if (streamWriter != null)
                    {
                      int num5 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
                        num5 = 0;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_25;
                          default:
                            ScriptMethodDeclarationTypeDescriptor.CTk2q5bT2htU12fHTt0d((object) streamWriter);
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 1;
                            continue;
                        }
                      }
                    }
label_25:;
                  }
              }
            }
            finally
            {
              int num6;
              if (memoryStream2 == null)
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
              else
                goto label_29;
label_28:
              switch (num6)
              {
                case 2:
                  break;
                default:
              }
label_29:
              ScriptMethodDeclarationTypeDescriptor.CTk2q5bT2htU12fHTt0d((object) memoryStream2);
              num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
              {
                num6 = 0;
                goto label_28;
              }
              else
                goto label_28;
            }
        }
      }
      finally
      {
        int num7;
        if (memoryStream1 == null)
          num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
        else
          goto label_35;
label_34:
        switch (num7)
        {
          case 1:
            break;
          default:
        }
label_35:
        memoryStream1.Dispose();
        num7 = 2;
        goto label_34;
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
            memoryStream.Read(buffer, offset, length);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (string) ScriptMethodDeclarationTypeDescriptor.JrOgi3bTemA6672yaC0L((object) BitConverter.ToString(buffer, offset, length), ScriptMethodDeclarationTypeDescriptor.viY0t0bTqLbSlXr95T7a(-218496594 ^ -218492990), (object) "");
    }

    public override object DeserializeSimple(object value, Type deserializeToType)
    {
      int num = 3;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            ScriptMethodDeclarationTypeDescriptor.QDMYssbTPIxRAo21WNZ6((object) deserializeToType, ScriptMethodDeclarationTypeDescriptor.viY0t0bTqLbSlXr95T7a(322893104 - -1992822529 ^ -1979232843));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 3:
            ScriptMethodDeclarationTypeDescriptor.QDMYssbTPIxRAo21WNZ6(value, ScriptMethodDeclarationTypeDescriptor.viY0t0bTqLbSlXr95T7a(-105199646 ^ -105214316));
            num = 2;
            continue;
          default:
            str = value.ToString();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(ScriptMethodDeclarationTypeDescriptor.DLsaFWbT1BHjcZkZSyq2((object) str) >> 1, str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(this.DeserializeSimpleAction));
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
      int num1 = 8;
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
              memoryStream = MemoryHelper.GetMemoryStream(buffer, offset, length, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 0;
              continue;
            case 3:
              ++num3;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            case 4:
            case 6:
              buffer[offset + num3] = Convert.ToByte((string) ScriptMethodDeclarationTypeDescriptor.HV4ltgbTNMn3B9CnoRoH((object) hexString, num3 << 1, 2), 16);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 3 : 3;
              continue;
            case 5:
              goto label_37;
            case 8:
              goto label_34;
            default:
              if (num3 < length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 6 : 2;
                continue;
              }
              goto case 2;
          }
        }
label_34:
        num3 = 0;
        num1 = 7;
      }
label_4:
      object obj;
      try
      {
        StreamReader streamReader = new StreamReader((Stream) memoryStream);
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
          num4 = 0;
        switch (num4)
        {
          default:
            try
            {
              Type type = Type.GetType(streamReader.ReadLine());
              int num5 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                num5 = 0;
              XmlReader reader;
              while (true)
              {
                switch (num5)
                {
                  case 1:
                    streamReader.CheckAndCorrectInternalBOMSymbols();
                    num5 = 2;
                    continue;
                  case 2:
                    reader = (XmlReader) ScriptMethodDeclarationTypeDescriptor.kXayaBbT3V7riv3E4tad((object) streamReader);
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_13;
                }
              }
label_13:
              try
              {
                obj = ClassSerializationHelper.DeserializeObjectByXml(type, reader);
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                  num6 = 0;
                switch (num6)
                {
                }
              }
              finally
              {
                if (reader != null)
                {
                  int num7 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
                    num7 = 0;
                  while (true)
                  {
                    switch (num7)
                    {
                      case 1:
                        goto label_22;
                      default:
                        ScriptMethodDeclarationTypeDescriptor.CTk2q5bT2htU12fHTt0d((object) reader);
                        num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_22:;
              }
            }
            finally
            {
              int num8;
              if (streamReader == null)
                num8 = 2;
              else
                goto label_26;
label_25:
              switch (num8)
              {
                case 1:
                  break;
                default:
              }
label_26:
              ScriptMethodDeclarationTypeDescriptor.CTk2q5bT2htU12fHTt0d((object) streamReader);
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
              {
                num8 = 0;
                goto label_25;
              }
              else
                goto label_25;
            }
            break;
        }
      }
      finally
      {
        int num9;
        if (memoryStream == null)
          num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
        else
          goto label_32;
label_31:
        switch (num9)
        {
          case 1:
          case 2:
        }
label_32:
        memoryStream.Dispose();
        num9 = 2;
        goto label_31;
      }
label_37:
      return obj;
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

    public ScriptMethodDeclarationTypeDescriptor()
    {
      ScriptMethodDeclarationTypeDescriptor.nwnQD9bTpgNB2ot7oxCj();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptMethodDeclarationTypeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptMethodDeclarationTypeDescriptor.UID = new Guid((string) ScriptMethodDeclarationTypeDescriptor.viY0t0bTqLbSlXr95T7a(-688192331 - 435440695 ^ -1123779330));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object viY0t0bTqLbSlXr95T7a(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Tk5isJbTKuAAynbVN3t0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool TQuesabTiVO6N1frSm8m() => ScriptMethodDeclarationTypeDescriptor.wJMt2PbTS97aQBqnlb0p == null;

    internal static ScriptMethodDeclarationTypeDescriptor DY5o4qbTRWoBpZ0xFZWI() => ScriptMethodDeclarationTypeDescriptor.wJMt2PbTS97aQBqnlb0p;

    internal static object B5eMnGbTX9yj5MfTUQkn() => (object) MemoryHelper.GetMemoryStream();

    internal static void vpOi25bTTnpt8ayH4CaV([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static void T98eKUbTkmsIG9GEIIVm([In] object obj0, [In] object obj1) => ((Stream) obj0).CopyTo((Stream) obj1);

    internal static long cD24y4bTn5YuyS9Fkfxk([In] object obj0) => ((Stream) obj0).Length;

    internal static long LjQYlebTOwXx7Ib0PCPu([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void CTk2q5bT2htU12fHTt0d([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object JrOgi3bTemA6672yaC0L([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static void QDMYssbTPIxRAo21WNZ6([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static int DLsaFWbT1BHjcZkZSyq2([In] object obj0) => ((string) obj0).Length;

    internal static object HV4ltgbTNMn3B9CnoRoH([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static object kXayaBbT3V7riv3E4tad([In] object obj0) => (object) XmlReader.Create((TextReader) obj0);

    internal static void nwnQD9bTpgNB2ot7oxCj() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

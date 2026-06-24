// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.ClassSerializationHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Text;
using EleWise.ELMA.XmlSerializers;
using j3AmrhgkCleVTGdEwA;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Xml;

namespace EleWise.ELMA.Serialization
{
  /// <summary>Класс с методами для сериализации</summary>
  public static class ClassSerializationHelper
  {
    private static readonly ClassSerializationHelper.XmlSerializerFactory xmlSerFactory;
    private static readonly ClassSerializationHelper.XmlSerializerFactory xmlSerFactoryExtra;
    internal static ClassSerializationHelper odZoMcBgReKNKGhfRWwC;

    /// <summary>Записать данные для сериализации</summary>
    /// <param name="obj"></param>
    /// <param name="info"></param>
    public static void WriteDataForSerialization(object obj, SerializationInfo info)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_7;
          case 2:
            ClassSerializationHelper.OVlovXBgXhAEi2IMKe9f(obj.GetType(), obj, (object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 3:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_7:
      return;
label_8:
      return;
label_2:;
    }

    private static void WriteDataForSerialization(Type type, object obj, object info)
    {
      int num = 6;
      int index;
      FieldInfo[] reflectionFields;
      FieldInfo fieldInfo;
      object obj1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            fieldInfo = reflectionFields[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 8 : 3;
            continue;
          case 2:
            ClassSerializationHelper.lH2tohBgek2V3dObVvig(info, ClassSerializationHelper.dGQOTbBg2wDuCAUZ0WFJ((object) fieldInfo), obj1);
            num = 4;
            continue;
          case 3:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 11;
            continue;
          case 4:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 10 : 4;
            continue;
          case 5:
            goto label_15;
          case 6:
            if (ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 4 : 5;
              continue;
            }
            goto case 7;
          case 7:
            // ISSUE: type reference
            if (ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(type, ClassSerializationHelper.AXcC3QBgkHwSBiAHW5jG(__typeref (object))))
            {
              num = 13;
              continue;
            }
            reflectionFields = type.GetReflectionFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
            num = 3;
            continue;
          case 8:
            if ((ClassSerializationHelper.nHIMuaBgnwtQUJEbthXs((object) fieldInfo) & FieldAttributes.NotSerialized) != FieldAttributes.NotSerialized)
            {
              num = 12;
              continue;
            }
            goto case 4;
          case 9:
            ClassSerializationHelper.OVlovXBgXhAEi2IMKe9f(type.BaseType, obj, info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 10:
          case 11:
            if (index >= reflectionFields.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 3 : 9;
              continue;
            }
            goto case 1;
          case 12:
            obj1 = ClassSerializationHelper.iHdfQ6BgOT722T5NOAF9((object) fieldInfo, obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 2 : 2;
            continue;
          case 13:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_7:
      return;
label_15:
      return;
label_2:
      return;
label_3:;
    }

    /// <summary>Прочитать данные для десериализации</summary>
    /// <param name="obj"></param>
    /// <param name="info"></param>
    public static void ReadDataForDeserialization(object obj, SerializationInfo info)
    {
      int num = 6;
      SerializationInfoEnumerator serializationInfoEnumerator;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            ClassSerializationHelper.vLxUhtBgNFGDeCb2OrtC(type, ClassSerializationHelper.DpNv9GBg1JCYhdnjmivL((object) serializationInfoEnumerator), obj, (object) info);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 3 : 2;
            continue;
          case 2:
            goto label_7;
          case 3:
          case 4:
            if (!serializationInfoEnumerator.MoveNext())
            {
              num = 2;
              continue;
            }
            goto case 1;
          case 5:
            goto label_9;
          case 6:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 5 : 3;
              continue;
            }
            type = obj.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            serializationInfoEnumerator = (SerializationInfoEnumerator) ClassSerializationHelper.eRru6EBgP0eaWqM9Ete2((object) info);
            num = 4;
            continue;
        }
      }
label_7:
      return;
label_9:;
    }

    private static void ReadDataForDeserialization(
      Type type,
      object name,
      object obj,
      object info)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        FieldInfo reflectionField;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!(reflectionField != (FieldInfo) null))
              {
                ClassSerializationHelper.ReadDataForDeserialization(type.BaseType, name, obj, info);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 5 : 1;
                continue;
              }
              goto label_15;
            case 2:
              goto label_5;
            case 3:
              if (!ClassSerializationHelper.FmF92HBg3NCY9vqg5fAy(name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                continue;
              }
              goto label_16;
            case 4:
              if (!ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(type, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 3 : 0;
                continue;
              }
              goto label_3;
            case 5:
              goto label_7;
            case 6:
              goto label_4;
            case 7:
              ClassSerializationHelper.wbnb1HBgDASxOHvw3KwA((object) reflectionField, obj, ClassSerializationHelper.TNMWpJBgatP3vmP0PFhP(info, name, ClassSerializationHelper.KqpUmYBgparQN1odSqVS((object) reflectionField)));
              num2 = 6;
              continue;
            default:
              reflectionField = type.GetReflectionField((string) name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 1 : 0;
              continue;
          }
        }
label_15:
        num1 = 7;
      }
label_5:
      return;
label_7:
      return;
label_4:
      return;
label_3:
      return;
label_16:;
    }

    /// <summary>Клонировать объект</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Клонированный объект</returns>
    public static object CloneObject(object obj)
    {
      int num1 = 4;
      MemoryStream serializationStream;
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
              goto label_5;
            case 3:
              serializationStream = (MemoryStream) ClassSerializationHelper.yHiuvGBgtigHwHXm97lf();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
              continue;
            case 4:
              goto label_6;
            default:
              goto label_8;
          }
        }
label_6:
        if (obj != null)
          num1 = 3;
        else
          break;
      }
label_3:
      return (object) null;
label_5:
      object obj1;
      return obj1;
label_8:
      try
      {
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        ClassSerializationHelper.t2gmBvBgwp6kAqRG7g4u((object) binaryFormatter, (object) serializationStream, obj);
        ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) serializationStream, 0L, SeekOrigin.Begin);
        obj1 = binaryFormatter.Deserialize((Stream) serializationStream);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_5;
        }
      }
      finally
      {
        int num4;
        if (serializationStream == null)
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
        else
          goto label_15;
label_14:
        switch (num4)
        {
          case 2:
            break;
          default:
        }
label_15:
        ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) serializationStream);
        num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        {
          num4 = 0;
          goto label_14;
        }
        else
          goto label_14;
      }
    }

    /// <summary>Клонировать объект</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Клонированный объект</returns>
    public static T CloneObject<T>(T obj) => object.Equals((object) obj, (object) default (T)) ? default (T) : (T) ClassSerializationHelper.CloneObject((object) obj);

    /// <summary>Сериализовать объект</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Массив байт</returns>
    public static byte[] SerializeObject(object obj)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = ClassSerializationHelper.SerializeObjectToMemoryStream(obj);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      byte[] numArray;
      return numArray;
label_3:
      try
      {
        int num2;
        if (memoryStream == null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
        else
          goto label_8;
label_6:
        object obj1;
        switch (num2)
        {
          case 1:
            goto label_2;
          default:
            obj1 = (object) null;
            goto label_9;
        }
label_8:
        obj1 = ClassSerializationHelper.F5kpPkBgHQWgYDJwlehB((object) memoryStream);
label_9:
        numArray = (byte[]) obj1;
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0)
        {
          num2 = 1;
          goto label_6;
        }
        else
          goto label_6;
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
            break;
          default:
        }
label_14:
        memoryStream.Dispose();
        num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        {
          num3 = 2;
          goto label_13;
        }
        else
          goto label_13;
      }
    }

    /// <summary>
    /// Сериализовать объект в <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream SerializeObjectToMemoryStream(object obj)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) memoryStream, 0L, SeekOrigin.Begin);
              num2 = 3;
              continue;
            case 3:
              goto label_8;
            case 4:
              goto label_3;
            case 5:
              ClassSerializationHelper.t2gmBvBgwp6kAqRG7g4u((object) new BinaryFormatter(), (object) memoryStream, obj);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 2;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        memoryStream = (MemoryStream) ClassSerializationHelper.yHiuvGBgtigHwHXm97lf();
        num1 = 5;
      }
label_3:
      return (MemoryStream) null;
label_8:
      return memoryStream;
    }

    /// <summary>Десериализовать объект</summary>
    /// <param name="bytes">Массив байт</param>
    /// <returns>Объект</returns>
    public static object DeserializeObject(byte[] bytes)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (bytes == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      return ClassSerializationHelper.U12oaXBgAOUZII0Kt7wZ((object) bytes, 0, bytes.Length);
label_5:
      return (object) null;
    }

    /// <summary>Десериализовать объект</summary>
    /// <param name="bytes">Массив байт</param>
    /// <param name="bytesOffset">Смещение относительно начала буфера</param>
    /// <param name="bytesLength">Длина полезных данных</param>
    /// <returns>Объект</returns>
    public static object DeserializeObject(byte[] bytes, int bytesOffset, int bytesLength)
    {
      int num1 = 4;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (bytesLength != 0)
            {
              num1 = 6;
              continue;
            }
            goto label_9;
          case 3:
            if (bytes.Length == 0)
            {
              num1 = 2;
              continue;
            }
            goto case 1;
          case 4:
            if (bytes != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 0;
              continue;
            }
            goto label_9;
          case 5:
            goto label_11;
          case 6:
            memoryStream = (MemoryStream) ClassSerializationHelper.aK2BBPBg7dpC8BEWG4JC((object) bytes, bytesOffset, bytesLength, false);
            num1 = 5;
            continue;
          case 7:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      object obj;
      return obj;
label_9:
      return (object) null;
label_11:
      try
      {
        obj = ClassSerializationHelper.DeserializeObjectFromStream((Stream) memoryStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
          num2 = 0;
        switch (num2)
        {
          default:
            goto label_2;
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_19;
              default:
                ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 1;
                continue;
            }
          }
        }
label_19:;
      }
    }

    /// <summary>
    /// Десериализовать объект из <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="memoryStream">Поток с данными</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectFromStream(Stream memoryStream)
    {
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) memoryStream, 0L, SeekOrigin.Begin);
            num1 = 4;
            continue;
          case 3:
            if (memoryStream != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 2 : 2;
              continue;
            }
            goto label_2;
          case 4:
            goto label_6;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) null;
label_6:
      object obj;
      try
      {
        obj = ClassSerializationHelper.eRtOmSBgxI6nGyQEUoSC((object) new BinaryFormatter(), (object) memoryStream);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
          num2 = 0;
        switch (num2)
        {
        }
      }
      finally
      {
        ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) memoryStream, 0L, SeekOrigin.Begin);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
label_13:
      return obj;
    }

    /// <summary>Сериализовать объект</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Строка с сериализованным объектом</returns>
    public static string SerializeObjectToString(object obj)
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            ClassSerializationHelper.bXpUTrBgmXwbEaO38p4q(obj, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(-420743386 ^ -420784978));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_4;
          default:
            memoryStream = (MemoryStream) ClassSerializationHelper.yHiuvGBgtigHwHXm97lf();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 3;
            continue;
        }
      }
label_3:
      string str;
      return str;
label_4:
      try
      {
        ClassSerializationHelper.t2gmBvBgwp6kAqRG7g4u((object) new BinaryFormatter(), (object) memoryStream, obj);
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              memoryStream.Seek(0L, SeekOrigin.Begin);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            default:
              str = (string) ClassSerializationHelper.Mt7PJJBgyZ1ZIeHU6Gys((object) memoryStream, (object) EncodingCache.Win1251Encoding);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
          }
        }
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              default:
                goto label_13;
            }
          }
        }
label_13:;
      }
    }

    /// <summary>Десериализовать объект</summary>
    /// <param name="str">Строка с сериализованным объектом</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectFromString(string str)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNull((object) str, (string) ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(1574260816 ^ 1574248468));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return MemoryHelper.ActionWithMemoryBuffer<byte, string, object>(ClassSerializationHelper.cPmm6TBgMSQErkWAyD24((object) EncodingCache.Win1251Encoding, (object) str), str, new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, string, object>(ClassSerializationHelper.DeserializeObjectFromStringAction));
    }

    private static object DeserializeObjectFromStringAction(
      object buffer,
      int offset,
      int length,
      object str)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ClassSerializationHelper.PQ1qgnBg9mTGa1EX9on9((object) EncodingCache.Win1251Encoding, str, 0, ClassSerializationHelper.oZHSfaBgJKPjGTFwVwpd(str), buffer, offset);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return ClassSerializationHelper.U12oaXBgAOUZII0Kt7wZ(buffer, offset, length);
    }

    /// <summary>Клонировать объект, используя XML-сериализацию</summary>
    /// <param name="obj">Объект</param>
    /// <param name="useComponentManager"></param>
    /// <returns>Клонированный объект</returns>
    public static T CloneObjectByXml<T>(T obj, bool useComponentManager = true) where T : class
    {
      if ((object) obj == null)
        return default (T);
      obj = obj.CastAsRealType<T>();
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream())
      {
        using (XmlTextWriter xmlTextWriter = new XmlTextWriter((Stream) memoryStream, Encoding.UTF8))
        {
          XmlSerializer serializer = (useComponentManager ? ClassSerializationHelper.xmlSerFactoryExtra : ClassSerializationHelper.xmlSerFactory).GetSerializer(obj.GetType());
          serializer.Serialize((XmlWriter) xmlTextWriter, (object) obj);
          xmlTextWriter.Flush();
          memoryStream.Seek(0L, SeekOrigin.Begin);
          using (XmlTextReader xmlTextReader = new XmlTextReader((Stream) memoryStream))
            return (T) serializer.Deserialize((XmlReader) xmlTextReader);
        }
      }
    }

    /// <summary>
    /// Сериализовать объект, используя XML-сериализацию в массив байт
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Сериализованный объект (в кодировке UTF8)</returns>
    public static byte[] SerializeObjectByXmlToBytes(object obj, bool useComponentManager = true)
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            memoryStream = (MemoryStream) ClassSerializationHelper.t3njIIBgllshEBpf5duZ(obj, useComponentManager, ClassSerializationHelper.n5EXOnBgdEiPL5ZhObLn());
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
            continue;
          default:
            goto label_16;
        }
      }
label_2:
      byte[] bytes;
      try
      {
        int num2;
        if (memoryStream != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
        else
          goto label_5;
label_4:
        object obj1;
        switch (num2)
        {
          case 1:
            obj1 = ClassSerializationHelper.F5kpPkBgHQWgYDJwlehB((object) memoryStream);
            goto label_7;
          case 2:
            break;
          default:
            goto label_16;
        }
label_5:
        obj1 = (object) null;
label_7:
        bytes = (byte[]) obj1;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
        {
          num2 = 0;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        if (memoryStream != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
            num3 = 0;
          while (true)
          {
            switch (num3)
            {
              case 1:
                goto label_14;
              default:
                ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) memoryStream);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_14:;
      }
label_16:
      return bytes;
    }

    /// <summary>Сериализовать объект, используя XML-сериализацию</summary>
    /// <param name="obj">Объект</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Сериализованный объект (в кодировке UTF8)</returns>
    public static string SerializeObjectByXml(object obj, bool useComponentManager = true)
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            memoryStream = (MemoryStream) ClassSerializationHelper.t3njIIBgllshEBpf5duZ(obj, useComponentManager, (object) EncodingCache.UTF8WithoutEmitIdentifier);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      string str;
      return str;
label_3:
      try
      {
        int num2;
        if (memoryStream != null)
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 1 : 0;
        else
          goto label_6;
label_5:
        object obj1;
        switch (num2)
        {
          case 1:
            obj1 = ClassSerializationHelper.Mt7PJJBgyZ1ZIeHU6Gys((object) memoryStream, (object) EncodingCache.UTF8WithoutEmitIdentifier);
            goto label_8;
          case 2:
            break;
          default:
            goto label_2;
        }
label_6:
        obj1 = (object) null;
label_8:
        str = (string) obj1;
        num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        {
          num2 = 0;
          goto label_5;
        }
        else
          goto label_5;
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
        else
          goto label_13;
label_12:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_13:
        memoryStream.Dispose();
        num3 = 2;
        goto label_12;
      }
    }

    /// <summary>Сериализовать объект, используя XML-сериализацию</summary>
    /// <param name="obj">Объект</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Поток в памяти, содержащий сериализованный объект (в кодировке UTF8)</returns>
    public static MemoryStream SerializeObjectByXmlToMemoryStream(
      object obj,
      bool useComponentManager = true)
    {
      return ClassSerializationHelper.SerializeByXmlToMemoryStreamInternal(obj, useComponentManager, ClassSerializationHelper.n5EXOnBgdEiPL5ZhObLn());
    }

    /// <summary>Сериализовать объект, используя XML-сериализацию</summary>
    /// <param name="obj">Объект</param>
    /// <param name="writer">Поток записи XML</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Сериализованный объект (в кодировке UTF8)</returns>
    public static void SerializeObjectByXml(object obj, XmlWriter writer, bool useComponentManager = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ClassSerializationHelper.SerializeObjectByXml(obj.GetType(), obj, writer, useComponentManager);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сериализовать объект, используя XML-сериализацию</summary>
    /// <param name="serType">Тип объекта</param>
    /// <param name="obj">Объект</param>
    /// <param name="writer">Поток записи XML</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Сериализованный объект (в кодировке UTF8)</returns>
    public static void SerializeObjectByXml(
      Type serType,
      object obj,
      XmlWriter writer,
      bool useComponentManager = true)
    {
      int num = 3;
      while (true)
      {
        ClassSerializationHelper.XmlSerializerFactory serializerFactory;
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            serializerFactory = ClassSerializationHelper.xmlSerFactory;
            break;
          case 2:
            if (!useComponentManager)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 0;
              continue;
            }
            serializerFactory = ClassSerializationHelper.xmlSerFactoryExtra;
            break;
          case 3:
            obj = ClassSerializationHelper.b94kMQBgrM1IInV8jn6b(obj);
            num = 2;
            continue;
          default:
            goto label_9;
        }
        Type t = serType;
        ClassSerializationHelper.k4NJlFBg5P1xa3XILlcG(ClassSerializationHelper.Xv1oOdBggKnli9a01n6Y((object) serializerFactory, t), (object) writer, obj);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Десериализовать объект, используя XML-сериализацию</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="xml">Сериализованный объект (в кодировке UTF8)</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Объект</returns>
    public static T DeserializeObjectByXml<T>(string xml, bool useComponentManager = true) => (T) ClassSerializationHelper.DeserializeObjectByXml(typeof (T), xml, useComponentManager);

    /// <summary>Десериализовать объект, используя XML-сериализацию</summary>
    /// <param name="tp">Тип объекта</param>
    /// <param name="xml">Сериализованный объект (в кодировке UTF8</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectByXml(Type tp, string xml, bool useComponentManager = true)
    {
      int num1 = 8;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_7;
            case 3:
              num3 = ClassSerializationHelper.TfN22FBgjoY76YeDFfu2((object) xml, '<');
              num2 = 5;
              continue;
            case 4:
              xml = (string) ClassSerializationHelper.HF5CyNBgYCWi2Vw20V62((object) xml, num3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
              continue;
            case 5:
              if (xml.IndexOf('<') <= 0)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 6:
            case 7:
              goto label_9;
            case 8:
              if (ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(tp, (Type) null))
              {
                num2 = 7;
                continue;
              }
              goto label_7;
            default:
              goto label_5;
          }
        }
label_7:
        if (!ClassSerializationHelper.FmF92HBg3NCY9vqg5fAy((object) xml))
          num1 = 3;
        else
          goto label_9;
      }
label_5:
      return MemoryHelper.ActionWithMemoryBuffer<byte, (Type, string, bool), object>(Encoding.UTF8.GetByteCount(xml), (tp, xml, useComponentManager), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (Type, string, bool), object>(ClassSerializationHelper.DeserializeObjectByXmlAction));
label_9:
      return (object) null;
    }

    private static object DeserializeObjectByXmlAction(
      object buffer,
      int offset,
      int length,
      (Type, string, bool) param)
    {
      (Type type, string s, bool useComponentManager) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      return ClassSerializationHelper.DeserializeObjectByXml(type, buffer, length, offset, useComponentManager);
    }

    /// <summary>Десериализовать объект, используя XML-сериализацию</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="bytes">Сериализованный объект</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Объект</returns>
    public static T DeserializeObjectByXml<T>(byte[] bytes, bool useComponentManager = true) => (T) ClassSerializationHelper.DeserializeObjectByXml(typeof (T), bytes, useComponentManager);

    /// <summary>Десериализовать объект, используя XML-сериализацию</summary>
    /// <param name="tp">Тип объекта</param>
    /// <param name="bytes">Сериализованный объект</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectByXml(Type tp, byte[] bytes, bool useComponentManager = true) => ClassSerializationHelper.DeserializeObjectByXml(tp, (object) bytes, bytes.Length, 0, useComponentManager);

    /// <summary>Десериализовать объект, используя XML-сериализацию</summary>
    /// <param name="tp">Тип объекта</param>
    /// <param name="reader">Поток считывания XML</param>
    /// <param name="useComponentManager">Использовать ли менеджер компонентов</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectByXml(
      Type tp,
      XmlReader reader,
      bool useComponentManager = true)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (reader == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
              continue;
            }
            if (!useComponentManager)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto label_10;
          case 3:
            if (!ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(tp, (Type) null))
            {
              num = 2;
              continue;
            }
            goto label_4;
          default:
            goto label_7;
        }
      }
label_4:
      return (object) null;
label_7:
      ClassSerializationHelper.XmlSerializerFactory serializerFactory = ClassSerializationHelper.xmlSerFactory;
      goto label_11;
label_10:
      serializerFactory = ClassSerializationHelper.xmlSerFactoryExtra;
label_11:
      Type t = tp;
      return ClassSerializationHelper.eSuMrZBgLe4eWelDfNkT(ClassSerializationHelper.Xv1oOdBggKnli9a01n6Y((object) serializerFactory, t), (object) reader);
    }

    /// <summary>
    /// Сериализация объекта в json. Использует DataContractJsonSerializer
    /// </summary>
    /// <param name="obj"></param>
    /// <returns></returns>
    public static string SerializeObjectByJson(object obj)
    {
      int num1 = 2;
      DataContractJsonSerializer contractJsonSerializer;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (obj != null)
            {
              contractJsonSerializer = new DataContractJsonSerializer(obj.GetType());
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 4 : 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_6;
          case 4:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = 3;
            continue;
          default:
            goto label_17;
        }
      }
label_2:
      return (string) null;
label_6:
      string str;
      try
      {
        ClassSerializationHelper.FX17UaBgUJpXuvetRGEl((object) contractJsonSerializer, (object) memoryStream, obj);
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) memoryStream, 0L, SeekOrigin.Begin);
              num2 = 2;
              continue;
            case 2:
              str = (string) ClassSerializationHelper.Mt7PJJBgyZ1ZIeHU6Gys((object) memoryStream, ClassSerializationHelper.n5EXOnBgdEiPL5ZhObLn());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            default:
              goto label_17;
          }
        }
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 1;
        else
          goto label_14;
label_13:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_14:
        memoryStream.Dispose();
        num3 = 2;
        goto label_13;
      }
label_17:
      return str;
    }

    /// <summary>
    /// Десериализатор из json в объект. Использует DataContractJsonSerializer
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="json"></param>
    /// <returns></returns>
    public static T DeserializeObjectByJson<T>(string json) => (T) ClassSerializationHelper.DeserializeObjectByJson(typeof (T), json);

    /// <summary>
    /// Десериализатор из json в объект. Использует DataContractJsonSerializer
    /// </summary>
    /// <param name="json">Сериализованные данные в виде потока</param>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <returns>Объект</returns>
    public static T DeserializeObjectByJson<T>(Stream json) => (T) ClassSerializationHelper.DeserializeObjectByJson(typeof (T), json);

    /// <summary>
    /// Десериализатор из json в объект. Использует DataContractJsonSerializer
    /// </summary>
    /// <param name="typeObject"></param>
    /// <param name="json"></param>
    /// <returns></returns>
    public static object DeserializeObjectByJson(Type typeObject, string json) => MemoryHelper.ActionWithMemoryBuffer<byte, (string, Type), object>(ClassSerializationHelper.cPmm6TBgMSQErkWAyD24((object) Encoding.UTF8, (object) json), (json, typeObject), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (string, Type), object>(ClassSerializationHelper.DeserializeObjectByJsonAction));

    /// <summary>
    /// Десериализатор из json в объект. Использует DataContractJsonSerializer
    /// </summary>
    /// <param name="typeObject">Тип объекта</param>
    /// <param name="stream">Сериализованные данные в виде потока</param>
    /// <returns>Объект</returns>
    public static object DeserializeObjectByJson(Type typeObject, Stream stream) => ClassSerializationHelper.HrXmxcBgsjxsv96q9jBP((object) new DataContractJsonSerializer(typeObject), (object) stream);

    private static object DeserializeObjectByJsonAction(
      object buffer,
      int offset,
      int length,
      (string, Type) param)
    {
      (string s, Type typeObject) = param;
      Encoding.UTF8.GetBytes(s, 0, s.Length, (byte[]) buffer, offset);
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream((byte[]) buffer, offset, length, false))
        return ClassSerializationHelper.DeserializeObjectByJson(typeObject, (Stream) memoryStream);
    }

    /// <summary>
    /// Сериализовать объект в json. Использует Newtonsoft.Json
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <returns></returns>
    public static string SerializeObjectByJsonNet(object obj) => ClassSerializationHelper.SerializeObjectByJsonNet(obj, (IEnumerable<JsonConverter>) null);

    /// <summary>
    /// Сериализовать объект в json. Использует Newtonsoft.Json и кастомные конвертеры
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="converters">Конвертеры</param>
    /// <returns></returns>
    public static string SerializeObjectByJsonNet(object obj, IEnumerable<JsonConverter> converters)
    {
      JsonSerializerSettings settings = new JsonSerializerSettings()
      {
        Error = (EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>) ((sender, args) =>
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
                // ISSUE: reference to a compiler-generated method
                ClassSerializationHelper.\u003C\u003Ec.q65qFAQelVc1DWJlAfTx(ClassSerializationHelper.\u003C\u003Ec.aoDmOhQed8p5PjnKXDL2((object) args), true);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        })
      };
      if (converters != null)
        settings.Converters = (IList<JsonConverter>) converters.ToList<JsonConverter>();
      return JsonConvert.SerializeObject(obj, settings);
    }

    /// <summary>Десериализовать объект из json</summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="json">JSON</param>
    /// <returns></returns>
    public static T DeserializeObjectByJsonNet<T>(string json) => (T) ClassSerializationHelper.DeserializeObjectByJsonNet(TypeOf<T>.Raw, json, (IEnumerable<JsonConverter>) null);

    /// <summary>
    /// Десериализовать объект из json. Использует Newtonsoft.Json и кастомные конвертеры
    /// </summary>
    /// <typeparam name="T">Тип объекта</typeparam>
    /// <param name="json">JSON</param>
    /// <param name="converters">Конвертеры</param>
    /// <returns></returns>
    public static T DeserializeObjectByJsonNet<T>(
      string json,
      IEnumerable<JsonConverter> converters)
    {
      return (T) ClassSerializationHelper.DeserializeObjectByJsonNet(TypeOf<T>.Raw, json, converters);
    }

    /// <summary>Десериализовать объект из json</summary>
    /// <param name="json">JSON</param>
    /// <returns></returns>
    public static object DeserializeObjectByJsonNet(string json) => ClassSerializationHelper.DeserializeObjectByJsonNet(json, (IEnumerable<JsonConverter>) null);

    /// <summary>Десериализовать объект из json</summary>
    /// <param name="type">Тип</param>
    /// <param name="json">JSON</param>
    /// <returns></returns>
    public static object DeserializeObjectByJsonNet(Type type, string json) => ClassSerializationHelper.DeserializeObjectByJsonNet(type, json, (IEnumerable<JsonConverter>) null);

    /// <summary>
    /// Десериализовать объект из json. Использует Newtonsoft.Json и кастомные конвертеры
    /// </summary>
    /// <param name="json">JSON</param>
    /// <param name="converters">Конвертеры</param>
    /// <returns></returns>
    public static object DeserializeObjectByJsonNet(
      string json,
      IEnumerable<JsonConverter> converters)
    {
      return ClassSerializationHelper.DeserializeObjectByJsonNet((Type) null, json, converters);
    }

    /// <summary>
    /// Десериализовать объект из json. Использует Newtonsoft.Json и кастомные конвертеры
    /// </summary>
    /// <param name="json">JSON</param>
    /// <param name="converters">Конвертеры</param>
    /// <param name="type">Тип</param>
    /// <returns></returns>
    public static object DeserializeObjectByJsonNet(
      Type type,
      string json,
      IEnumerable<JsonConverter> converters)
    {
      JsonSerializerSettings settings = new JsonSerializerSettings()
      {
        Error = (EventHandler<Newtonsoft.Json.Serialization.ErrorEventArgs>) ((sender, args) =>
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
                ((ErrorContext) ClassSerializationHelper.\u003C\u003Ec.aoDmOhQed8p5PjnKXDL2((object) args)).Handled = true;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        })
      };
      if (converters != null)
        settings.Converters = (IList<JsonConverter>) converters.ToList<JsonConverter>();
      return JsonConvert.DeserializeObject(json, type, settings);
    }

    /// <summary>
    /// Получить строку <see cref="P:Newtonsoft.Json.JsonReader.Path" /> без экранирования символов
    /// </summary>
    /// <param name="path">Путь в <see cref="P:Newtonsoft.Json.JsonReader.Path" /></param>
    /// <returns>Деэкранированная строка</returns>
    internal static string GetUnescapedJsonNetPath(string path)
    {
      int num1 = 3;
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
              goto label_6;
            case 3:
              if (ClassSerializationHelper.DPFsfbBgcGgpovYiXHEu((object) path))
              {
                num2 = 2;
                continue;
              }
              goto label_3;
            case 4:
              goto label_5;
            case 5:
              if (ClassSerializationHelper.nwVa7RB5FbrWHZS4OyjV((object) path, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(-740338220 ^ -740416988)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            default:
              if (ClassSerializationHelper.oZHSfaBgJKPjGTFwVwpd((object) path) > 3)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 4 : 2;
                continue;
              }
              goto label_6;
          }
        }
label_3:
        if (ClassSerializationHelper.fTeglfBgztyBccy9WRob((object) path, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(95909607 + 343705423 ^ 439519710)))
          num1 = 5;
        else
          goto label_6;
      }
label_5:
      return (string) ClassSerializationHelper.boOQ1GB5BJ1dVPvFXbqe((object) path);
label_6:
      return path;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static object DeserializeObjectByXml(
      Type type,
      object bytes,
      int bytesCount,
      int bytesOffset,
      bool useComponentManager = true)
    {
      int num1 = 4;
      MemoryStream input;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_30;
          case 2:
            goto label_2;
          case 3:
            if (bytes != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
              continue;
            }
            goto label_30;
          case 4:
            if (!ClassSerializationHelper.XltplNBgTClCmiBhPHbZ(type, (Type) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 2;
              continue;
            }
            goto label_30;
          case 5:
            goto label_7;
          default:
            input = (MemoryStream) ClassSerializationHelper.aK2BBPBg7dpC8BEWG4JC(bytes, bytesOffset, bytesCount, false);
            num1 = 5;
            continue;
        }
      }
label_2:
      object obj;
      return obj;
label_7:
      try
      {
        XmlTextReader xmlTextReader = new XmlTextReader((Stream) input);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
          num2 = 0;
        switch (num2)
        {
          default:
            try
            {
              int num3;
              if (!useComponentManager)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
              else
                goto label_15;
label_13:
              ClassSerializationHelper.XmlSerializerFactory serializerFactory;
              switch (num3)
              {
                case 1:
                  goto label_2;
                default:
                  serializerFactory = ClassSerializationHelper.xmlSerFactory;
                  goto label_16;
              }
label_15:
              serializerFactory = ClassSerializationHelper.xmlSerFactoryExtra;
label_16:
              Type t = type;
              obj = ((XmlSerializer) ClassSerializationHelper.Xv1oOdBggKnli9a01n6Y((object) serializerFactory, t)).Deserialize((XmlReader) xmlTextReader);
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
              {
                num3 = 0;
                goto label_13;
              }
              else
                goto label_13;
            }
            finally
            {
              if (xmlTextReader != null)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_23;
                    default:
                      ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) xmlTextReader);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                      continue;
                  }
                }
              }
label_23:;
            }
        }
      }
      finally
      {
        int num5;
        if (input == null)
          num5 = 2;
        else
          goto label_27;
label_26:
        switch (num5)
        {
          case 1:
            break;
          default:
        }
label_27:
        input.Dispose();
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        {
          num5 = 0;
          goto label_26;
        }
        else
          goto label_26;
      }
label_30:
      return (object) null;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static MemoryStream SerializeByXmlToMemoryStreamInternal(
      object obj,
      bool useComponentManager,
      object encoding)
    {
      int num1 = 6;
      MemoryStream memoryStreamInternal;
      while (true)
      {
        int num2 = num1;
        XmlTextWriter xmlTextWriter;
        while (true)
        {
          switch (num2)
          {
            case 1:
              xmlTextWriter = new XmlTextWriter((Stream) ClassSerializationHelper.Sy5jRqB5WVLwFBX2rfAx((object) memoryStreamInternal), (Encoding) encoding);
              num2 = 4;
              continue;
            case 2:
              memoryStreamInternal = (MemoryStream) ClassSerializationHelper.yHiuvGBgtigHwHXm97lf();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 1;
              continue;
            case 3:
label_21:
              ClassSerializationHelper.UnKXgbBg4pFUN0t0HbUm((object) memoryStreamInternal, 0L, SeekOrigin.Begin);
              num2 = 7;
              continue;
            case 4:
              try
              {
                ClassSerializationHelper.oDJVnjB5o8PpGwy4CiLN((object) xmlTextWriter, System.Xml.Formatting.Indented);
                int num3 = 4;
                while (true)
                {
                  ClassSerializationHelper.XmlSerializerFactory serializerFactory;
                  switch (num3)
                  {
                    case 1:
                      serializerFactory = ClassSerializationHelper.xmlSerFactory;
                      break;
                    case 2:
                      ClassSerializationHelper.XaiDvWB5bRlYuRjoQaus((object) xmlTextWriter, ' ');
                      num3 = 3;
                      continue;
                    case 3:
                      if (!useComponentManager)
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 0;
                        continue;
                      }
                      serializerFactory = ClassSerializationHelper.xmlSerFactoryExtra;
                      break;
                    case 4:
                      xmlTextWriter.Indentation = 2;
                      num3 = 2;
                      continue;
                    default:
                      goto label_21;
                  }
                  Type type = obj.GetType();
                  ((XmlSerializer) ClassSerializationHelper.Xv1oOdBggKnli9a01n6Y((object) serializerFactory, type)).Serialize((XmlWriter) xmlTextWriter, obj);
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
                }
              }
              finally
              {
                int num4;
                if (xmlTextWriter == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
                else
                  goto label_18;
label_17:
                switch (num4)
                {
                  case 1:
                    break;
                  default:
                }
label_18:
                ClassSerializationHelper.WMhDAiBg6i18PKUhlwGC((object) xmlTextWriter);
                num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                {
                  num4 = 2;
                  goto label_17;
                }
                else
                  goto label_17;
              }
            case 5:
              goto label_4;
            case 6:
              if (obj != null)
              {
                num2 = 5;
                continue;
              }
              goto label_3;
            case 7:
              goto label_23;
            default:
              goto label_3;
          }
        }
label_4:
        obj = ClassSerializationHelper.b94kMQBgrM1IInV8jn6b(obj);
        num1 = 2;
      }
label_3:
      return (MemoryStream) null;
label_23:
      return memoryStreamInternal;
    }

    private static string UnescapeJsonNetPath(object source)
    {
      int num1 = 45;
      StringBuilder stringBuilder1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          int num3;
          string str;
          int num4;
          StringBuilder stringBuilder2;
          char ch;
          bool flag;
          switch (num2)
          {
            case 1:
            case 43:
              ch = ClassSerializationHelper.kPNFHyB5GyXlbdyOkxpN((object) str, num3);
              num2 = 9;
              continue;
            case 3:
              stringBuilder2 = (StringBuilder) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 22 : 25;
              continue;
            case 4:
              if (ch != 'n')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 5 : 5;
                continue;
              }
              goto case 20;
            case 5:
              switch (ch)
              {
                case 'r':
                  goto label_34;
                case 's':
                  goto label_40;
                case 't':
                  goto label_44;
                case 'u':
                  goto label_17;
                default:
                  num2 = 21;
                  continue;
              }
            case 6:
              ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(-2106517564 ^ -2106521422));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 13 : 29;
              continue;
            case 7:
              num4 = ClassSerializationHelper.h275gmB5Q7dJJQt7T4gI((object) stringBuilder2.ToString(), 16);
              num2 = 3;
              continue;
            case 8:
              if (ch != '\\')
              {
                num2 = 46;
                continue;
              }
              goto case 6;
            case 9:
              if (stringBuilder2 == null)
              {
                num2 = 13;
                continue;
              }
              goto case 32;
            case 10:
              flag = false;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 31 : 2;
              continue;
            case 11:
              ClassSerializationHelper.G1t70sB5E5C7WyLfWTVy((object) stringBuilder1, ch);
              num2 = 26;
              continue;
            case 12:
label_34:
              stringBuilder1.Append((string) ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(2008901894 << 3 ^ -1108650296));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 22 : 35;
              continue;
            case 13:
            case 47:
              if (flag)
              {
                num2 = 10;
                continue;
              }
              goto case 14;
            case 14:
            case 16:
            case 21:
label_40:
              if (ch == '\\')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0 ? 39 : 7;
                continue;
              }
              goto case 11;
            case 18:
              ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105195398));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
              continue;
            case 19:
              str = (string) ClassSerializationHelper.brTqFpB5hStVoNFMSv28(source, 2, ClassSerializationHelper.oZHSfaBgJKPjGTFwVwpd(source) - 4);
              num2 = 49;
              continue;
            case 20:
              ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(-1978478350 ^ -1978478762));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 17 : 6;
              continue;
            case 22:
              goto label_18;
            case 23:
              if (ClassSerializationHelper.jqIPysB5fDlNTX73xC9h((object) stringBuilder2) == 4)
              {
                num2 = 7;
                continue;
              }
              break;
            case 25:
              stringBuilder1.Append(ClassSerializationHelper.EtCuYeB5CLPeJf9eqw2A(num4));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 33 : 21;
              continue;
            case 27:
              ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(1051802738 - -1831968059 ^ -1411201805));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 36 : 5;
              continue;
            case 28:
label_44:
              ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470446836));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 11 : 24;
              continue;
            case 30:
              if (ch != 'f')
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 4;
                continue;
              }
              goto label_18;
            case 31:
              if (ch <= 'b')
              {
                num2 = 38;
                continue;
              }
              goto case 30;
            case 32:
              ClassSerializationHelper.G1t70sB5E5C7WyLfWTVy((object) stringBuilder2, ch);
              num2 = 23;
              continue;
            case 34:
            case 41:
              if (num3 < str.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 32 : 43;
                continue;
              }
              goto label_43;
            case 37:
label_17:
              stringBuilder2 = new StringBuilder();
              num2 = 15;
              continue;
            case 38:
              if (ch == '\'')
                goto case 27;
              else
                goto label_47;
            case 39:
              flag = true;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            case 42:
              goto label_43;
            case 44:
              flag = false;
              num2 = 48;
              continue;
            case 45:
              stringBuilder1 = new StringBuilder();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 41 : 44;
              continue;
            case 46:
              if (ch != 'b')
              {
                num2 = 14;
                continue;
              }
              goto case 18;
            case 48:
              stringBuilder2 = (StringBuilder) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 19 : 2;
              continue;
            case 49:
              num3 = 0;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 23 : 41;
              continue;
          }
          ++num3;
          num2 = 34;
        }
label_18:
        ClassSerializationHelper.ShKmDBB5vKjPagIXbG9q((object) stringBuilder1, ClassSerializationHelper.Fn5C9aBg0g2vvsKNa6iK(-1445902765 ^ -1980277732 ^ 539362769));
        num1 = 40;
        continue;
label_47:
        num1 = 8;
      }
label_43:
      return stringBuilder1.ToString();
    }

    static ClassSerializationHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ClassSerializationHelper.xmlSerFactory = new ClassSerializationHelper.XmlSerializerFactory(false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 3;
            continue;
          case 2:
            ClassSerializationHelper.jdHZm1B58okAVub78vgB();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
            continue;
          case 3:
            ClassSerializationHelper.xmlSerFactoryExtra = new ClassSerializationHelper.XmlSerializerFactory(true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static void OVlovXBgXhAEi2IMKe9f(Type type, [In] object obj1, [In] object obj2) => ClassSerializationHelper.WriteDataForSerialization(type, obj1, obj2);

    internal static bool k60WS4BgqhjPlRtCpNMc() => ClassSerializationHelper.odZoMcBgReKNKGhfRWwC == null;

    internal static ClassSerializationHelper sVKLHBBgKD2txYB8O42J() => ClassSerializationHelper.odZoMcBgReKNKGhfRWwC;

    internal static bool XltplNBgTClCmiBhPHbZ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type AXcC3QBgkHwSBiAHW5jG([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static FieldAttributes nHIMuaBgnwtQUJEbthXs([In] object obj0) => ((FieldInfo) obj0).Attributes;

    internal static object iHdfQ6BgOT722T5NOAF9([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static object dGQOTbBg2wDuCAUZ0WFJ([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void lH2tohBgek2V3dObVvig([In] object obj0, [In] object obj1, [In] object obj2) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2);

    internal static object eRru6EBgP0eaWqM9Ete2([In] object obj0) => (object) ((SerializationInfo) obj0).GetEnumerator();

    internal static object DpNv9GBg1JCYhdnjmivL([In] object obj0) => (object) ((SerializationInfoEnumerator) obj0).Name;

    internal static void vLxUhtBgNFGDeCb2OrtC(Type type, [In] object obj1, [In] object obj2, [In] object obj3) => ClassSerializationHelper.ReadDataForDeserialization(type, obj1, obj2, obj3);

    internal static bool FmF92HBg3NCY9vqg5fAy([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static Type KqpUmYBgparQN1odSqVS([In] object obj0) => ((FieldInfo) obj0).FieldType;

    internal static object TNMWpJBgatP3vmP0PFhP([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void wbnb1HBgDASxOHvw3KwA([In] object obj0, [In] object obj1, [In] object obj2) => ((FieldInfo) obj0).SetValue(obj1, obj2);

    internal static object yHiuvGBgtigHwHXm97lf() => (object) MemoryHelper.GetMemoryStream();

    internal static void t2gmBvBgwp6kAqRG7g4u([In] object obj0, [In] object obj1, [In] object obj2) => ((BinaryFormatter) obj0).Serialize((Stream) obj1, obj2);

    internal static long UnKXgbBg4pFUN0t0HbUm([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void WMhDAiBg6i18PKUhlwGC([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object F5kpPkBgHQWgYDJwlehB([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static object U12oaXBgAOUZII0Kt7wZ([In] object obj0, int bytesOffset, int bytesLength) => ClassSerializationHelper.DeserializeObject((byte[]) obj0, bytesOffset, bytesLength);

    internal static object aK2BBPBg7dpC8BEWG4JC(
      [In] object obj0,
      int offset,
      int length,
      bool writable)
    {
      return (object) MemoryHelper.GetMemoryStream((byte[]) obj0, offset, length, writable);
    }

    internal static object eRtOmSBgxI6nGyQEUoSC([In] object obj0, [In] object obj1) => ((BinaryFormatter) obj0).Deserialize((Stream) obj1);

    internal static object Fn5C9aBg0g2vvsKNa6iK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void bXpUTrBgmXwbEaO38p4q([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object Mt7PJJBgyZ1ZIeHU6Gys([In] object obj0, [In] object obj1) => (object) ((MemoryStream) obj0).AsString((Encoding) obj1);

    internal static int cPmm6TBgMSQErkWAyD24([In] object obj0, [In] object obj1) => ((Encoding) obj0).GetByteCount((string) obj1);

    internal static int oZHSfaBgJKPjGTFwVwpd([In] object obj0) => ((string) obj0).Length;

    internal static int PQ1qgnBg9mTGa1EX9on9(
      [In] object obj0,
      [In] object obj1,
      [In] int obj2,
      [In] int obj3,
      [In] object obj4,
      [In] int obj5)
    {
      return ((Encoding) obj0).GetBytes((string) obj1, obj2, obj3, (byte[]) obj4, obj5);
    }

    internal static object n5EXOnBgdEiPL5ZhObLn() => (object) Encoding.UTF8;

    internal static object t3njIIBgllshEBpf5duZ([In] object obj0, bool useComponentManager, [In] object obj2) => (object) ClassSerializationHelper.SerializeByXmlToMemoryStreamInternal(obj0, useComponentManager, obj2);

    internal static object b94kMQBgrM1IInV8jn6b([In] object obj0) => obj0.CastAsRealType();

    internal static object Xv1oOdBggKnli9a01n6Y([In] object obj0, Type t) => (object) ((ClassSerializationHelper.XmlSerializerFactory) obj0).GetSerializer(t);

    internal static void k4NJlFBg5P1xa3XILlcG([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlSerializer) obj0).Serialize((XmlWriter) obj1, obj2);

    internal static int TfN22FBgjoY76YeDFfu2([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object HF5CyNBgYCWi2Vw20V62([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object eSuMrZBgLe4eWelDfNkT([In] object obj0, [In] object obj1) => ((XmlSerializer) obj0).Deserialize((XmlReader) obj1);

    internal static void FX17UaBgUJpXuvetRGEl([In] object obj0, [In] object obj1, [In] object obj2) => ((XmlObjectSerializer) obj0).WriteObject((Stream) obj1, obj2);

    internal static object HrXmxcBgsjxsv96q9jBP([In] object obj0, [In] object obj1) => ((XmlObjectSerializer) obj0).ReadObject((Stream) obj1);

    internal static bool DPFsfbBgcGgpovYiXHEu([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static bool fTeglfBgztyBccy9WRob([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool nwVa7RB5FbrWHZS4OyjV([In] object obj0, [In] object obj1) => ((string) obj0).EndsWith((string) obj1);

    internal static object boOQ1GB5BJ1dVPvFXbqe([In] object obj0) => (object) ClassSerializationHelper.UnescapeJsonNetPath(obj0);

    internal static object Sy5jRqB5WVLwFBX2rfAx([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static void oDJVnjB5o8PpGwy4CiLN([In] object obj0, [In] System.Xml.Formatting obj1) => ((XmlTextWriter) obj0).Formatting = obj1;

    internal static void XaiDvWB5bRlYuRjoQaus([In] object obj0, [In] char obj1) => ((XmlTextWriter) obj0).IndentChar = obj1;

    internal static object brTqFpB5hStVoNFMSv28([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Substring(obj1, obj2);

    internal static char kPNFHyB5GyXlbdyOkxpN([In] object obj0, [In] int obj1) => ((string) obj0)[obj1];

    internal static object G1t70sB5E5C7WyLfWTVy([In] object obj0, [In] char obj1) => (object) ((StringBuilder) obj0).Append(obj1);

    internal static int jqIPysB5fDlNTX73xC9h([In] object obj0) => ((StringBuilder) obj0).Length;

    internal static int h275gmB5Q7dJJQt7T4gI([In] object obj0, [In] int obj1) => Convert.ToInt32((string) obj0, obj1);

    internal static char EtCuYeB5CLPeJf9eqw2A([In] int obj0) => Convert.ToChar(obj0);

    internal static object ShKmDBB5vKjPagIXbG9q([In] object obj0, [In] object obj1) => (object) ((StringBuilder) obj0).Append((string) obj1);

    internal static void jdHZm1B58okAVub78vgB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    private class XmlSerializerFactory
    {
      private bool useExtra;
      public object serializers;
      private static object lK0vwtQe4AXh9Z7EeyX0;

      public XmlSerializerFactory(bool useExtra)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        this.serializers = (object) new Hashtable();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.useExtra = useExtra;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
      }

      public XmlSerializer GetSerializer(Type t)
      {
        int num1 = 3;
        XmlSerializer serializer;
        object obj;
        bool lockTaken;
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
                obj = ClassSerializationHelper.XmlSerializerFactory.QlrpSsQeAi9s2On0UwJc(this.serializers);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                continue;
              case 3:
                serializer = (XmlSerializer) null;
                num2 = 2;
                continue;
              case 4:
                goto label_7;
              default:
                goto label_5;
            }
          }
label_5:
          lockTaken = false;
          num1 = 4;
        }
label_6:
        return serializer;
label_7:
        try
        {
          Monitor.Enter(obj, ref lockTaken);
          int num3 = 2;
          while (true)
          {
            XmlSerializerAttribute attribute;
            XmlSerializer xmlSerializer;
            switch (num3)
            {
              case 1:
                xmlSerializer = (XmlSerializer) ClassSerializationHelper.XmlSerializerFactory.Ejop1VQexcLkcfk4JTwP(ClassSerializationHelper.XmlSerializerFactory.Il09IhQe7cW6rQ1erANM((object) attribute));
                break;
              case 2:
                serializer = ((Hashtable) this.serializers)[(object) t] as XmlSerializer;
                num3 = 4;
                continue;
              case 3:
                goto label_6;
              case 4:
                if (serializer == null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 6 : 0;
                  continue;
                }
                goto label_6;
              case 6:
                if (this.useExtra)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 9;
                  continue;
                }
                goto case 10;
              case 7:
                if (attribute != null)
                {
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
                  continue;
                }
                goto case 8;
              case 8:
                xmlSerializer = CacheableXmlSerializer.Create(t, false);
                break;
              case 9:
                serializer = CacheableXmlSerializer.Create(t, true);
                num3 = 5;
                continue;
              case 10:
                attribute = AttributeHelper<XmlSerializerAttribute>.GetAttribute(t, false);
                num3 = 7;
                continue;
              default:
                ClassSerializationHelper.XmlSerializerFactory.Wu6eREQe0anvIHhZXWsU(this.serializers, (object) t, (object) serializer);
                num3 = 3;
                continue;
            }
            serializer = xmlSerializer;
            num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
          }
        }
        finally
        {
          if (lockTaken)
          {
            int num4 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
              num4 = 0;
            while (true)
            {
              switch (num4)
              {
                case 1:
                  goto label_27;
                default:
                  ClassSerializationHelper.XmlSerializerFactory.AnqLP0QemvqKUxtfUoyV(obj);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 1;
                  continue;
              }
            }
          }
label_27:;
        }
      }

      internal static bool j2lsQTQe6kYX3IOLFqyC() => ClassSerializationHelper.XmlSerializerFactory.lK0vwtQe4AXh9Z7EeyX0 == null;

      internal static ClassSerializationHelper.XmlSerializerFactory KV197kQeHQkYHVfa1cWq() => (ClassSerializationHelper.XmlSerializerFactory) ClassSerializationHelper.XmlSerializerFactory.lK0vwtQe4AXh9Z7EeyX0;

      internal static object QlrpSsQeAi9s2On0UwJc([In] object obj0) => ((Hashtable) obj0).SyncRoot;

      internal static Type Il09IhQe7cW6rQ1erANM([In] object obj0) => ((XmlSerializerAttribute) obj0).SerializerType;

      internal static object Ejop1VQexcLkcfk4JTwP([In] Type obj0) => Activator.CreateInstance(obj0);

      internal static void Wu6eREQe0anvIHhZXWsU([In] object obj0, [In] object obj1, [In] object obj2) => ((Hashtable) obj0).Add(obj1, obj2);

      internal static void AnqLP0QemvqKUxtfUoyV([In] object obj0) => Monitor.Exit(obj0);
    }
  }
}

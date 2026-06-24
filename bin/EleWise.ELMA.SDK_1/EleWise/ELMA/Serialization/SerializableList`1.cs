// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.SerializableList`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace EleWise.ELMA.Serialization
{
  [Serializable]
  public class SerializableList<T> : List<T>, ISerializable, ICloneable
  {
    protected const string VALUE_NAME = "value";
    protected const string ARRAY_NAME = "values";
    private static object N9ZRRaB5ZIvDNWjnGHCU;

    public SerializableList()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public SerializableList(IEnumerable<T> collection)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(collection);
    }

    public SerializableList(int capacity)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(capacity);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 4;
      while (true)
      {
        int index;
        switch (num)
        {
          case 1:
            ++index;
            num = 2;
            continue;
          case 2:
          case 3:
            if (index >= this.Count)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 0;
              continue;
            }
            break;
          case 4:
            index = 0;
            num = 3;
            continue;
          case 5:
            goto label_5;
        }
        info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289732836) + index.ToString(), (object) this[index]);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
      }
label_5:;
    }

    public SerializableList(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      T[] collection;
      SerializationInfoEnumerator enumerator;
      while (true)
      {
        switch (num)
        {
          case 1:
            collection = (T[]) info.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812118090), typeof (T[]));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 11 : 10;
            continue;
          case 2:
            goto label_14;
          case 3:
            if (!SerializableList<T>.IsSerializableFieldExists(enumerator, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113933307)))
            {
              num = 7;
              continue;
            }
            goto case 1;
          case 4:
            enumerator = info.GetEnumerator();
            num = 3;
            continue;
          case 5:
          case 6:
            if (enumerator.MoveNext())
            {
              num = 9;
              continue;
            }
            goto label_10;
          case 7:
            enumerator.Reset();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 5;
            continue;
          case 8:
            goto label_5;
          case 10:
            this.Add((T) info.GetValue(enumerator.Name, enumerator.ObjectType));
            num = 6;
            continue;
          case 11:
            this.AddRange((IEnumerable<T>) collection);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 2 : 1;
            continue;
          default:
            if (enumerator.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813618855)))
            {
              num = 10;
              continue;
            }
            goto case 5;
        }
      }
label_14:
      return;
label_5:
      return;
label_10:;
    }

    public static bool IsSerializableFieldExists(SerializationInfoEnumerator sie, string name)
    {
      int num = 4;
      bool flag;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 8:
            goto label_2;
          case 2:
            if (!(sie.Name == name))
            {
              num = 6;
              continue;
            }
            goto case 5;
          case 3:
            sie.Reset();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 7 : 7;
            continue;
          case 4:
            flag = false;
            num = 3;
            continue;
          case 5:
            flag = true;
            num = 8;
            continue;
          default:
            if (!sie.MoveNext())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto case 2;
        }
      }
label_2:
      return flag;
    }

    public byte[] SerializeByBinary()
    {
      int num1 = 1;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      byte[] array;
      return array;
label_4:
      try
      {
        new BinaryFormatter().Serialize((Stream) memoryStream, (object) this);
        int num2 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_2;
            default:
              array = memoryStream.ToArray();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 1;
              continue;
          }
        }
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
        else
          goto label_12;
label_11:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_12:
        memoryStream.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        {
          num3 = 0;
          goto label_11;
        }
        else
          goto label_11;
      }
    }

    public static SerializableList<T> DeserializeByBinary(byte[] serializedBytes)
    {
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream(serializedBytes, false))
        return (SerializableList<T>) new BinaryFormatter().Deserialize((Stream) memoryStream);
    }

    public object Clone() => (object) ClassSerializationHelper.CloneObject<SerializableList<T>>(this);

    internal static bool Qlka4CB5uQ0Gvb6Bj3SL() => SerializableList<T>.N9ZRRaB5ZIvDNWjnGHCU == null;

    internal static object J8lFEZB5ITuHC16qu06n() => SerializableList<T>.N9ZRRaB5ZIvDNWjnGHCU;
  }
}

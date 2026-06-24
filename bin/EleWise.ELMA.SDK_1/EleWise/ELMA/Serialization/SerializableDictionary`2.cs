// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.SerializableDictionary`2
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
  /// <summary>Сериализуемый словарь</summary>
  /// <typeparam name="TKey">Тип ключа</typeparam>
  /// <typeparam name="TValue">Тип значения</typeparam>
  [Serializable]
  public class SerializableDictionary<TKey, TValue> : 
    Dictionary<TKey, TValue>,
    ISerializable,
    ICloneable
  {
    protected const string KEY_NAME = "key";
    protected const string VALUE_NAME = "value";
    internal static object eCiJdMBgVo0eSfNPcbuF;

    public SerializableDictionary()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public SerializableDictionary(int capacity)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(capacity);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public SerializableDictionary(IEqualityComparer<TKey> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(comparer);
    }

    public SerializableDictionary(int capacity, IEqualityComparer<TKey> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(capacity, comparer);
    }

    public SerializableDictionary(IDictionary<TKey, TValue> dictionary)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(dictionary);
    }

    public SerializableDictionary(
      IDictionary<TKey, TValue> dictionary,
      IEqualityComparer<TKey> comparer)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(dictionary, comparer);
    }

    void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num1 = 3;
      int num2;
      Dictionary<TKey, TValue>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_16;
          case 1:
            goto label_2;
          case 2:
            enumerator = this.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
            continue;
          case 3:
            num2 = 0;
            num1 = 2;
            continue;
          default:
            goto label_12;
        }
      }
label_16:
      return;
label_12:
      return;
label_2:
      try
      {
label_9:
        if (enumerator.MoveNext())
          goto label_6;
        else
          goto label_10;
label_3:
        KeyValuePair<TKey, TValue> current;
        int num3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              ++num2;
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_6;
            case 4:
              goto label_4;
            case 5:
              info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998471014) + num2.ToString(), (object) current.Key);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
              continue;
            default:
              info.AddValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334979207) + num2.ToString(), (object) current.Value);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
              continue;
          }
        }
label_4:
        return;
label_6:
        current = enumerator.Current;
        num3 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        {
          num3 = 5;
          goto label_3;
        }
        else
          goto label_3;
label_10:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 4;
        goto label_3;
      }
      finally
      {
        enumerator.Dispose();
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num4 = 0;
        switch (num4)
        {
          default:
        }
      }
    }

    public SerializableDictionary(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num1 = 0;
      while (true)
      {
        int num2;
        object obj1;
        object obj2;
        SerializationInfoEnumerator enumerator;
        string str;
        switch (num1)
        {
          case 1:
          case 7:
          case 9:
label_16:
            if (enumerator.MoveNext())
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 11;
              continue;
            }
            goto label_10;
          case 2:
            try
            {
              this.Add((TKey) obj1, (TValue) obj2);
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
                num3 = 0;
              switch (num3)
              {
                default:
                  goto label_16;
              }
            }
            catch (Exception ex)
            {
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
                num4 = 0;
              switch (num4)
              {
                default:
                  throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70078297), ex);
              }
            }
          case 3:
            obj1 = info.GetValue(enumerator.Name, typeof (TKey));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 4;
            continue;
          case 4:
            str = enumerator.Name.Substring(z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957762080).Length);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 10 : 5;
            continue;
          case 5:
            enumerator.Reset();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 1;
            continue;
          case 6:
            goto label_15;
          case 8:
          case 11:
            if (!enumerator.Name.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978423470)))
            {
              num2 = 9;
              break;
            }
            goto case 3;
          case 10:
            obj2 = info.GetValue(z2jc63fLkugS1X8Q9N.tE1kD1vbB(516838154 ^ 516823676) + str, typeof (TValue));
            num2 = 2;
            break;
          default:
            enumerator = info.GetEnumerator();
            num2 = 5;
            break;
        }
        num1 = num2;
      }
label_15:
      return;
label_10:;
    }

    public byte[] SerializeByBinary()
    {
      int num1 = 2;
      MemoryStream memoryStream;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            memoryStream = MemoryHelper.GetMemoryStream();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
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
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
          num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              array = memoryStream.ToArray();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
      }
      finally
      {
        int num3;
        if (memoryStream == null)
          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
        else
          goto label_11;
label_10:
        switch (num3)
        {
          case 2:
            break;
          default:
        }
label_11:
        memoryStream.Dispose();
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        {
          num3 = 0;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    public static SerializableDictionary<TKey, TValue> DeserializeByBinary(byte[] serializedBytes)
    {
      using (MemoryStream memoryStream = MemoryHelper.GetMemoryStream(serializedBytes, false))
        return (SerializableDictionary<TKey, TValue>) new BinaryFormatter().Deserialize((Stream) memoryStream);
    }

    public object Clone() => (object) ClassSerializationHelper.CloneObject<SerializableDictionary<TKey, TValue>>(this);

    internal static bool AuHyrgBgSJOC56QAG5Z3() => SerializableDictionary<TKey, TValue>.eCiJdMBgVo0eSfNPcbuF == null;

    internal static object jsc0CFBgiELOEvt2scfV() => SerializableDictionary<TKey, TValue>.eCiJdMBgVo0eSfNPcbuF;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Serialization.PackSerializableEnumerable`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EleWise.ELMA.Serialization
{
  /// <summary>
  /// Перечислитель с возможностью упаковки/распаковки для компактной сериализации
  /// </summary>
  /// <typeparam name="T"></typeparam>
  [Serializable]
  public class PackSerializableEnumerable<T> : IEnumerable<T>, IEnumerable where T : IPackSerializableItem
  {
    private IEnumerable<T> source;
    /// <summary>
    /// Обычное перечисление. При значении false - перечисление является упакованным массивом байт и, при обращении к нему, нуждается в распаковке.
    /// </summary>
    private bool isNormalCollection;
    private readonly byte[] packSource;
    private static object XbvRhnBd9XykIZeECM25;

    public PackSerializableEnumerable(byte[] packSource)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.isNormalCollection = false;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
          default:
            this.packSource = packSource;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    public PackSerializableEnumerable(IEnumerable<T> source)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.source = (IEnumerable<T>) ((object) source ?? (object) new T[0]);
      this.isNormalCollection = true;
    }

    IEnumerator IEnumerable.GetEnumerator() => (IEnumerator) new PackSerializableEnumerable<T>.MyEnumerator(this);

    IEnumerator<T> IEnumerable<T>.GetEnumerator() => (IEnumerator<T>) new PackSerializableEnumerable<T>.MyEnumerator(this);

    /// <summary>Упаковывает перечислитель в массив байт.</summary>
    /// <param name="source">Перечислитель</param>
    /// <returns></returns>
    public static byte[] Pack(PackSerializableEnumerable<T> source) => source != null && source.source != null && source.Any<T>() ? PackSerializableEnumerable<T>.GetBytes(PackSerializableEnumerable<T>.StringSerializable(source.Select<T, string>((Func<T, string>) (value => value.Serialize())).ToList<string>())).Zip(9) : (byte[]) null;

    /// <summary>Распаковать массив байт в перечислитель.</summary>
    /// <param name="packSource"></param>
    /// <returns></returns>
    public static PackSerializableEnumerable<T> Unpack(byte[] packSource)
    {
      if (packSource != null)
      {
        if (packSource.Length != 0)
        {
          try
          {
            return new PackSerializableEnumerable<T>(PackSerializableEnumerable<T>.StringDeserializable(PackSerializableEnumerable<T>.GetString(packSource.Length != 0 ? packSource.Unzip() : Array.Empty<byte>())).Select<string, T>((Func<string, T>) (i =>
            {
              T obj = InterfaceActivator.Create<T>();
              obj.DeserializeFrom(i);
              return obj;
            })));
          }
          catch (Exception ex)
          {
            return (PackSerializableEnumerable<T>) null;
          }
        }
      }
      return new PackSerializableEnumerable<T>((IEnumerable<T>) new T[0]);
    }

    private static byte[] GetBytes(string str)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (string.IsNullOrEmpty(str))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return (byte[]) null;
label_3:
      return Encoding.UTF8.GetBytes(str);
    }

    private static string GetString(byte[] bytes)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (bytes != null)
            {
              if (bytes.Length == 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
              continue;
            }
          default:
            goto label_5;
        }
      }
label_2:
      return (string) null;
label_5:
      return "";
label_6:
      return Encoding.UTF8.GetString(bytes);
    }

    /// <summary>Сериализация строки.</summary>
    /// <param name="listString"></param>
    /// <returns></returns>
    private static string StringSerializable(List<string> listString) => listString == null || !listString.Any<string>() ? (string) null : string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538465700), listString.Select<string, string>((Func<string, string>) (s => s.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87336947), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173561873)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461703123), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606715068)))));

    /// <summary>Десериализация строки в список.</summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static IEnumerable<string> StringDeserializable(string value)
    {
      if (value == null)
        return (IEnumerable<string>) null;
      if (string.IsNullOrEmpty(value))
        return (IEnumerable<string>) new List<string>()
        {
          value
        };
      Guid guid = Guid.NewGuid();
      string tempSeparator = guid.ToString();
      guid = Guid.NewGuid();
      string tempSeparator2 = guid.ToString();
      Func<string, string> selector = (Func<string, string>) (s => s.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408987798), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112633124)).Replace(tempSeparator, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334996875)).Replace(tempSeparator2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710505344)));
      value = value.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1113862659 ^ 1113931859), tempSeparator).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304675093), tempSeparator2);
      return ((IEnumerable<string>) value.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360293975).ToCharArray())).Select<string, string>(selector);
    }

    internal static bool JGMGUMBddV47GFVXgd5g() => PackSerializableEnumerable<T>.XbvRhnBd9XykIZeECM25 == null;

    internal static object ccpa4iBdlkRMtPyPOmeJ() => PackSerializableEnumerable<T>.XbvRhnBd9XykIZeECM25;

    private class MyEnumerator : IEnumerator<T>, IDisposable, IEnumerator
    {
      private readonly PackSerializableEnumerable<T> enumerable;
      private IEnumerator<T> baseEnumerator;
      internal static object b61mmMQ2ehx37mIOPrAf;

      public MyEnumerator(PackSerializableEnumerable<T> enumerable)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.enumerable = enumerable;
      }

      public T Current => this.GetBaseEnumerator().Current;

      public void Dispose()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this.baseEnumerator != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
                continue;
              }
              goto label_6;
            case 2:
              goto label_2;
            default:
              this.baseEnumerator.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 2 : 1;
              continue;
          }
        }
label_2:
        return;
label_6:;
      }

      object IEnumerator.Current => (object) this.GetBaseEnumerator().Current;

      public bool MoveNext() => this.GetBaseEnumerator().MoveNext();

      public void Reset()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.GetBaseEnumerator().Reset();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      private IEnumerator<T> GetBaseEnumerator()
      {
        lock (this.enumerable)
        {
          if (!this.enumerable.isNormalCollection)
          {
            this.enumerable.source = (IEnumerable<T>) PackSerializableEnumerable<T>.Unpack(this.enumerable.packSource) ?? new PackSerializableEnumerable<T>((IEnumerable<T>) new T[0]).source;
            this.enumerable.isNormalCollection = true;
          }
          if (this.baseEnumerator == null)
            this.baseEnumerator = this.enumerable.source.GetEnumerator();
        }
        return this.baseEnumerator;
      }

      internal static bool hsEckcQ2PL0gdXI25kFK() => PackSerializableEnumerable<T>.MyEnumerator.b61mmMQ2ehx37mIOPrAf == null;

      internal static object WdoCybQ21T3sKB4rygP3() => PackSerializableEnumerable<T>.MyEnumerator.b61mmMQ2ehx37mIOPrAf;
    }
  }
}

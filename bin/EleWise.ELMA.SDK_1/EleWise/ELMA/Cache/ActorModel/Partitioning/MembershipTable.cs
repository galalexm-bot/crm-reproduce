// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.ActorModel.Partitioning.MembershipTable
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache.ActorModel.Partitioning
{
  /// <summary>Таблица узлов распределенного кэша.</summary>
  internal class MembershipTable
  {
    private readonly SortedList<double, CacheEntry> nodes;
    private readonly double localNodeAngle;
    internal static MembershipTable MdMneafXLmxytmbrkKpW;

    /// <summary>Инициализирует экземпляр класса.</summary>
    /// <param name="node">Ключ локального узла.</param>
    public MembershipTable(string node)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddNode(node);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 3 : 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.localNodeAngle = this.nodes.Keys[0];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
            continue;
          default:
            this.nodes = new SortedList<double, CacheEntry>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Добавляет узел в таблицу.</summary>
    /// <param name="node">Новый узел.</param>
    /// <returns>Диапазон углов, соответствующий узлу, для передачи части ключей или их копий.</returns>
    public (double start, double end)[] AddNode(string node)
    {
      int num1 = 3;
      uint hash;
      double num2;
      CacheEntry cacheEntry;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            num2 = MembershipTable.O7EV5lfXzjrGj96IXbre(hash);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 3:
            hash = MembershipTable.lh1eWcfXcDqL1iOmgZgR((object) node);
            num1 = 2;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.nodes.Add(num2, cacheEntry);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
            continue;
          default:
            if (!this.nodes.Keys.Contains(num2))
            {
              cacheEntry = new CacheEntry(node, (byte[]) null, hash, num2, DateTime.MaxValue);
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 5 : 3;
              continue;
            }
            num1 = 4;
            continue;
        }
      }
label_3:
      return ((double, double)[]) null;
label_6:
      return this.FindPreviousNodeAngles(num2);
    }

    /// <summary>Удаляет узел из таблицы.</summary>
    /// <param name="node">Узел для удаления.</param>
    /// <returns>Диапазон углов, соответствующий узлу, для передачи части ключей или их копий.</returns>
    public (double start, double end)[] RemoveNode(string node)
    {
      int num1 = 2;
      double num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (this.nodes.ContainsKey(num2))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            num2 = MembershipTable.O7EV5lfXzjrGj96IXbre(MembershipTable.lh1eWcfXcDqL1iOmgZgR((object) node));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      (double, double)[] previousNodeAngles = this.FindPreviousNodeAngles(num2);
      this.nodes.Remove(num2);
      return previousNodeAngles;
label_4:
      return ((double, double)[]) null;
    }

    /// <summary>Находит в таблице узел-владелец ключа.</summary>
    /// <param name="key">Ключ.</param>
    /// <param name="replicaFactor">Количество резервных узлов.</param>
    /// <param name="replicaNodes">Список резервных узлов.</param>
    /// <returns>Ключ узла-владельца.</returns>
    public string FindNode(string key, byte replicaFactor, out string[] replicaNodes)
    {
      int num1 = 4;
      CacheEntry cacheEntry;
      while (true)
      {
        int num2 = num1;
        int num3;
        while (true)
        {
          int num4;
          IEnumerator<KeyValuePair<double, CacheEntry>> enumerator;
          List<string> source;
          int index;
          double num5;
          switch (num2)
          {
            case 1:
              goto label_13;
            case 2:
              try
              {
label_23:
                if (enumerator.MoveNext())
                  goto label_21;
                else
                  goto label_24;
label_17:
                KeyValuePair<double, CacheEntry> current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_23;
                    case 2:
                      if (num5 <= current.Key)
                      {
                        num6 = 4;
                        continue;
                      }
                      goto label_23;
                    case 4:
                      cacheEntry = current.Value;
                      num6 = 3;
                      continue;
                    case 5:
                      goto label_21;
                    default:
                      goto label_4;
                  }
                }
label_21:
                current = enumerator.Current;
                num6 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                {
                  num6 = 2;
                  goto label_17;
                }
                else
                  goto label_17;
label_24:
                num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
                goto label_17;
              }
              finally
              {
                int num7;
                if (enumerator == null)
                  num7 = 2;
                else
                  goto label_28;
label_27:
                switch (num7)
                {
                  case 1:
                    break;
                  default:
                }
label_28:
                MembershipTable.Wj8MLEfTFqNcppEL3HvG((object) enumerator);
                num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
                {
                  num7 = 0;
                  goto label_27;
                }
                else
                  goto label_27;
              }
            case 3:
              num5 = MembershipTable.O7EV5lfXzjrGj96IXbre(key.ToHash());
              num2 = 8;
              continue;
            case 4:
              replicaNodes = new string[0];
              num2 = 3;
              continue;
            case 5:
              source.Add((string) MembershipTable.ryduJRfTBujvJg1TlpSe((object) this.nodes.Values[index]));
              num2 = 14;
              continue;
            case 6:
              enumerator = this.nodes.GetEnumerator();
              num2 = 2;
              continue;
            case 7:
              source = new List<string>((int) replicaFactor);
              num2 = 9;
              continue;
            case 8:
              cacheEntry = this.nodes.Values[0];
              num2 = 6;
              continue;
            case 9:
              num4 = this.nodes.IndexOfKey(cacheEntry.Angle);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 11;
              continue;
            case 10:
              index = (num4 + num3 + 1) % this.nodes.Count;
              num2 = 12;
              continue;
            case 11:
              goto label_3;
            case 12:
              if (index != num4)
              {
                num2 = 5;
                continue;
              }
              break;
            case 13:
label_4:
              if (replicaFactor > (byte) 0)
              {
                num2 = 7;
                continue;
              }
              goto label_13;
            case 14:
              ++num3;
              num2 = 16;
              continue;
            case 15:
            case 16:
              if (num3 >= (int) replicaFactor)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                continue;
              }
              goto case 10;
          }
          replicaNodes = source.Distinct<string>().ToArray<string>();
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 1;
        }
label_3:
        num3 = 0;
        num1 = 15;
      }
label_13:
      return (string) MembershipTable.ryduJRfTBujvJg1TlpSe((object) cacheEntry);
    }

    /// <summary>
    /// Возвращает упорядоченный (по углам) список всех узлов.
    /// </summary>
    /// <returns>Список узлов.</returns>
    public IList<CacheEntry> GetNodes() => this.nodes.Values;

    /// <summary>
    /// Возвращает список узлов, следующих непосредственно за текущим узлом.
    /// </summary>
    /// <param name="count">Количество узлов для поиска.</param>
    /// <returns>Список узлов.</returns>
    public IList<string> GetNodesAfterLocal(byte count)
    {
      List<string> source = new List<string>();
      if (this.nodes.Count == 1)
        return (IList<string>) source;
      int num = this.nodes.IndexOfKey(this.localNodeAngle);
      for (int index1 = 0; index1 < (int) count; ++index1)
      {
        int index2 = (num + index1 + 1) % this.nodes.Count;
        if (index2 != num)
          source.Add(this.nodes.Values[index2].Key);
        else
          break;
      }
      return (IList<string>) source.Distinct<string>().ToList<string>();
    }

    /// <summary>
    /// Находит диапазон углов для предшествующего (вновь добавленного или удаленного) узла.
    /// </summary>
    /// <param name="remoteNodeAngle">Угол узла.</param>
    /// <returns>Диапазон(ы) углов.</returns>
    private (double start, double end)[] FindPreviousNodeAngles(double remoteNodeAngle)
    {
      int num1 = 5;
      double key;
      while (true)
      {
        int num2;
        int index;
        int num3;
        switch (num1)
        {
          case 1:
            key = this.nodes.Keys[index];
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 2 : 1;
            continue;
          case 2:
            if (remoteNodeAngle > key)
            {
              num1 = 3;
              continue;
            }
            goto label_13;
          case 3:
            goto label_12;
          case 4:
            goto label_20;
          case 5:
            if (MembershipTable.yTZ8NvfTWy4RhsfZtHIU((object) this.nodes) == 1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 4 : 4;
              continue;
            }
            num2 = this.nodes.IndexOfKey(remoteNodeAngle);
            num1 = 10;
            continue;
          case 6:
            if (num2 == MembershipTable.yTZ8NvfTWy4RhsfZtHIU((object) this.nodes) - 1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 7:
            if (index < 0)
            {
              num1 = 11;
              continue;
            }
            goto case 1;
          case 8:
            if (num3 - num2 != 1)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 9 : 9;
              continue;
            }
            break;
          case 9:
            if (num3 != 0)
            {
              num1 = 12;
              continue;
            }
            goto case 6;
          case 10:
            num3 = this.nodes.IndexOfKey(this.localNodeAngle);
            num1 = 8;
            continue;
          case 11:
            index = MembershipTable.yTZ8NvfTWy4RhsfZtHIU((object) this.nodes) - 1;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          case 12:
            goto label_14;
        }
        index = num2 - 1;
        num1 = 7;
      }
label_12:
      return new (double, double)[1]
      {
        (key, remoteNodeAngle)
      };
label_13:
      return new (double, double)[2]
      {
        (key, HashExtensions.MaxAngle),
        (0.0, remoteNodeAngle)
      };
label_14:
      return ((double, double)[]) null;
label_20:
      return ((double, double)[]) null;
    }

    internal static bool bQkD1vfXUKQTNRlkdgIo() => MembershipTable.MdMneafXLmxytmbrkKpW == null;

    internal static MembershipTable rbAhZ0fXsu4Gc5w1QOCP() => MembershipTable.MdMneafXLmxytmbrkKpW;

    internal static uint lh1eWcfXcDqL1iOmgZgR([In] object obj0) => ((string) obj0).ToHash();

    internal static double O7EV5lfXzjrGj96IXbre(uint hash) => hash.ToAngle();

    internal static void Wj8MLEfTFqNcppEL3HvG([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object ryduJRfTBujvJg1TlpSe([In] object obj0) => (object) ((CacheEntry) obj0).Key;

    internal static int yTZ8NvfTWy4RhsfZtHIU([In] object obj0) => ((SortedList<double, CacheEntry>) obj0).Count;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.ArrayEqualityComparer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Extensions
{
  public sealed class ArrayEqualityComparer<T> : IEqualityComparer<T[]>
  {
    private static readonly EqualityComparer<T> elementComparer;
    internal static object QuNwpqGwNjioLdmHZrnb;

    public bool Equals(T[] first, T[] second)
    {
      int num = 5;
      int index;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_17;
          case 2:
            goto label_12;
          case 3:
            goto label_8;
          case 4:
            goto label_9;
          case 5:
            if (first == second)
            {
              num = 4;
              continue;
            }
            if (first != null)
            {
              num = 9;
              continue;
            }
            goto label_12;
          case 7:
            goto label_15;
          case 8:
            if (first.Length != second.Length)
            {
              num = 7;
              continue;
            }
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 9:
            if (second != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 2 : 8;
              continue;
            }
            goto label_12;
          case 10:
          case 11:
            if (ArrayEqualityComparer<T>.elementComparer.Equals(first[index], second[index]))
            {
              ++index;
              num = 6;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
            continue;
          default:
            if (index < first.Length)
            {
              num = 10;
              continue;
            }
            goto label_8;
        }
      }
label_8:
      return true;
label_9:
      return true;
label_12:
      return false;
label_15:
      return false;
label_17:
      return false;
    }

    public int GetHashCode(T[] array)
    {
      int num = 3;
      int hashCode;
      T obj;
      int index;
      T[] objArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            hashCode = hashCode * 31 + ArrayEqualityComparer<T>.elementComparer.GetHashCode(obj);
            num = 10;
            continue;
          case 2:
            goto label_12;
          case 3:
            if (array == null)
            {
              num = 2;
              continue;
            }
            hashCode = 17;
            num = 5;
            continue;
          case 5:
            objArray = array;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 7;
            continue;
          case 6:
          case 8:
            obj = objArray[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
            continue;
          case 7:
            index = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 4;
            continue;
          case 9:
            goto label_4;
          case 10:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          default:
            if (index < objArray.Length)
            {
              num = 6;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return hashCode;
label_12:
      return 0;
    }

    public ArrayEqualityComparer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ArrayEqualityComparer()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ArrayEqualityComparer<T>.elementComparer = EqualityComparer<T>.Default;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
            continue;
          case 2:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool RImyGIGw33iNwhOODGRW() => ArrayEqualityComparer<T>.QuNwpqGwNjioLdmHZrnb == null;

    internal static object tOKMjtGwprkGWMLNa8CL() => ArrayEqualityComparer<T>.QuNwpqGwNjioLdmHZrnb;
  }
}

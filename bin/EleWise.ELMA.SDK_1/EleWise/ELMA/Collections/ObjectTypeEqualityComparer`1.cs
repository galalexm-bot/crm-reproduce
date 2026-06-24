// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.ObjectTypeEqualityComparer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Collections
{
  /// <summary>Сравнивает объекты по их типам</summary>
  public class ObjectTypeEqualityComparer<T> : IEqualityComparer, IEqualityComparer<T>
  {
    internal static object c1vYI8m1I3f2IoDNDOe;

    /// <summary>Determines whether the specified objects are equal.</summary>
    /// <returns>
    /// true if the specified objects are equal; otherwise, false.
    /// </returns>
    /// <param name="x">The first object to compare.</param>
    /// <param name="y">The second object to compare.</param>
    bool IEqualityComparer.Equals(object x, object y)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            case 4:
              if (x != y)
              {
                if (x != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                  continue;
                }
                goto label_5;
              }
              else
                goto label_11;
            default:
              if (y != null)
              {
                num2 = 2;
                continue;
              }
              goto label_5;
          }
        }
label_11:
        num1 = 3;
      }
label_5:
      return false;
label_6:
      return x.GetType() == y.GetType();
label_7:
      return true;
    }

    /// <summary>Returns a hash code for the specified object.</summary>
    /// <returns>A hash code for the specified object.</returns>
    /// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
    /// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is null.</exception>
    int IEqualityComparer.GetHashCode([NotNull] object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335017593));
label_5:
      return obj.GetHashCode();
    }

    /// <summary>Determines whether the specified objects are equal.</summary>
    /// <returns>
    /// true if the specified objects are equal; otherwise, false.
    /// </returns>
    /// <param name="x">The first object of type <typeparamref name="T" /> to compare.</param>
    /// <param name="y">The second object of type <typeparamref name="T" /> to compare.</param>
    public bool Equals(T x, T y) => ((IEqualityComparer) this).Equals((object) x, (object) y);

    /// <summary>Returns a hash code for the specified object.</summary>
    /// <returns>A hash code for the specified object.</returns>
    /// <param name="obj">The <see cref="T:System.Object" /> for which a hash code is to be returned.</param>
    /// <exception cref="T:System.ArgumentNullException">The type of <paramref name="obj" /> is a reference type and <paramref name="obj" /> is null.</exception>
    public int GetHashCode(T obj) => ((IEqualityComparer) this).GetHashCode((object) obj);

    public ObjectTypeEqualityComparer()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool g0nG2cmNalBLTsEUlky() => ObjectTypeEqualityComparer<T>.c1vYI8m1I3f2IoDNDOe == null;

    internal static object MDn9Jqm3aFmaontPmpT() => ObjectTypeEqualityComparer<T>.c1vYI8m1I3f2IoDNDOe;
  }
}

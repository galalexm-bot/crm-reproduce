// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Comparers.RefComparer`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;

namespace EleWise.ELMA.Model.Types.Comparers
{
  public class RefComparer<TSource> : IComparer<TSource>
  {
    private readonly PropertyInfo propertyInfo;
    private readonly ListSortDirection order;
    private readonly int orderInt;
    private static object ofjesioUt8qqv1PtDkiV;

    /// <summary>Ctor</summary>
    /// <param name="order"></param>
    public RefComparer(Type source, string propertyName, ListSortDirection order)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.orderInt = this.order == ListSortDirection.Descending ? -1 : 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 3;
            continue;
          case 2:
            this.propertyInfo = source.GetReflectionProperty(propertyName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            this.order = order;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Сравнивание по ключам</summary>
    /// <param name="keyX"></param>
    /// <param name="keyY"></param>
    /// <returns></returns>
    protected virtual int Compare(object keyX, object keyY)
    {
      int num1 = 4;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (num2 != 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 5 : 5;
              continue;
            }
            goto label_3;
          case 2:
            num2 = ((IComparable) keyX).CompareTo(keyY);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_6;
          case 4:
            if (keyX != null)
            {
              if (keyX is IComparable)
              {
                num1 = 2;
                continue;
              }
              goto label_4;
            }
            else
            {
              num1 = 3;
              continue;
            }
          case 5:
            goto label_2;
          default:
            goto label_4;
        }
      }
label_2:
      return num2;
label_3:
      return 1;
label_4:
      throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420916560), (object) keyX.GetType().FullName));
label_6:
      return 1;
    }

    /// <summary>Сравнить</summary>
    /// <param name="x"></param>
    /// <param name="y"></param>
    /// <returns></returns>
    public virtual int Compare(TSource x, TSource y) => object.Equals((object) x, (object) y) ? 0 : this.orderInt * this.Compare(this.propertyInfo.GetValue((object) x, (object[]) null), this.propertyInfo.GetValue((object) y, (object[]) null));

    internal static bool FHBPEjoUwRuIRkfvIS3Q() => RefComparer<TSource>.ofjesioUt8qqv1PtDkiV == null;

    internal static object k41sDFoU4DrY7Jros7Yg() => RefComparer<TSource>.ofjesioUt8qqv1PtDkiV;
  }
}

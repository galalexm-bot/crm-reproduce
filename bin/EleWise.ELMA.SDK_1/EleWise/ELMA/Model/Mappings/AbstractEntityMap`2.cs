// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.AbstractEntityMap`2
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Mappings
{
  public abstract class AbstractEntityMap<T, IdT> : ClassMapping<T> where T : class, IEntity<IdT>
  {
    private static object A6U1Kfhbx1lr60v2wVwZ;

    public AbstractEntityMap(string tableName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num1 = 0;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_3;
          case 2:
            this.Id<IdT>((Expression<Func<T, IdT>>) (obj => obj.Id), (Action<IIdMapper>) (i =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    i.SetGenerator(tableName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44851747));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 1 : 1;
            continue;
          default:
            this.Table(tableName);
            num1 = 2;
            continue;
        }
      }
label_3:;
    }

    internal static bool b8Q27Fhb0qygwm7oTIrI() => AbstractEntityMap<T, IdT>.A6U1Kfhbx1lr60v2wVwZ == null;

    internal static object YKA6WGhbmRLiumRjyMDU() => AbstractEntityMap<T, IdT>.A6U1Kfhbx1lr60v2wVwZ;
  }
}

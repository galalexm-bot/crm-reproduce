// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DataClassTypeReferenceNHMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// NHibernate mapper для <see cref="T:EleWise.ELMA.Model.Scripts.DataClassTypeReference" />
  /// </summary>
  internal sealed class DataClassTypeReferenceNHMap : ClassMapping<DataClassTypeReference>
  {
    internal static DataClassTypeReferenceNHMap ErHVU2bITD9KfGGNZ9ey;

    /// <summary>Ctor</summary>
    public DataClassTypeReferenceNHMap()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) DataClassTypeReferenceNHMap.cEly3rbIegIBtMK1xInb(DataClassTypeReferenceNHMap.gycfZbbI2csEox12nEkg(__typeref (DataClassTypeReference)), DataClassTypeReferenceNHMap.BMTmtPbIOnFVGuSy0dxd(-951514650 ^ -951467202));
            // ISSUE: method reference
            Expression<Func<DataClassTypeReference, long>> idProperty = Expression.Lambda<Func<DataClassTypeReference, long>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) DataClassTypeReferenceNHMap.EVPFKVbIPfGey6Hh3h3r(__methodref (DataClassTypeReference.get_Id))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IIdMapper> action = DataClassTypeReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IIdMapper> idMapper;
            if (action == null)
            {
              // ISSUE: reference to a compiler-generated field
              DataClassTypeReferenceNHMap.\u003C\u003Ec.\u003C\u003E9__0_1 = idMapper = (Action<IIdMapper>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      DataClassTypeReferenceNHMap.\u003C\u003Ec.MF0aDaCPRhsiDNLDgGoW((object) p, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293833922), DataClassTypeReferenceNHMap.\u003C\u003Ec.CgSL2JCPiT5tau41IW5n(1051276242 - 990076387 ^ 61166769));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_9;
label_8:
            this.Id<long>(idProperty, idMapper);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
label_9:
            idMapper = action;
            goto label_8;
          case 2:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) DataClassTypeReferenceNHMap.cEly3rbIegIBtMK1xInb(DataClassTypeReferenceNHMap.gycfZbbI2csEox12nEkg(__typeref (DataClassTypeReference)), DataClassTypeReferenceNHMap.BMTmtPbIOnFVGuSy0dxd(1242972401 >> 4 ^ 77704919));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<DataClassTypeReference, Guid>>((Expression) DataClassTypeReferenceNHMap.AsdVF3bI1Msm4IAt6fec((object) parameterExpression2, (object) (MethodInfo) DataClassTypeReferenceNHMap.EVPFKVbIPfGey6Hh3h3r(__methodref (DataClassTypeReference.get_MetadataUid))), parameterExpression2));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          case 3:
            this.Table((string) DataClassTypeReferenceNHMap.BMTmtPbIOnFVGuSy0dxd(222162814 ^ 222275416));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          case 4:
            goto label_6;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) DataClassTypeReferenceNHMap.cEly3rbIegIBtMK1xInb(DataClassTypeReferenceNHMap.gycfZbbI2csEox12nEkg(__typeref (DataClassTypeReference)), DataClassTypeReferenceNHMap.BMTmtPbIOnFVGuSy0dxd(964881585 - -1459193222 ^ -1870874385));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<DataClassTypeReference, Guid>>((Expression) DataClassTypeReferenceNHMap.AsdVF3bI1Msm4IAt6fec((object) parameterExpression3, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DataClassTypeReference.get_ItemUid))), parameterExpression3));
            num1 = 4;
            continue;
        }
      }
label_6:;
    }

    internal static object BMTmtPbIOnFVGuSy0dxd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Type gycfZbbI2csEox12nEkg([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object cEly3rbIegIBtMK1xInb([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object EVPFKVbIPfGey6Hh3h3r([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object AsdVF3bI1Msm4IAt6fec([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool dkiRrUbIkO7N08yAt8gB() => DataClassTypeReferenceNHMap.ErHVU2bITD9KfGGNZ9ey == null;

    internal static DataClassTypeReferenceNHMap aaNpXibInBN61xT3qvCV() => DataClassTypeReferenceNHMap.ErHVU2bITD9KfGGNZ9ey;
  }
}

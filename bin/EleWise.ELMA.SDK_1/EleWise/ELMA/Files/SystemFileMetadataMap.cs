// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.SystemFileMetadataMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.NH.CustomTypes;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using NHibernate.Mapping.ByCode.Impl.CustomizersImpl;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Files
{
  public class SystemFileMetadataMap : ClassMapping<SystemFile>
  {
    internal static SystemFileMetadataMap OnxHAqGkaSOr8Bn7wraQ;

    public SystemFileMetadataMap()
    {
      SystemFileMetadataMap.WD8wLTGkwPn2FJNVogV1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 7;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
        num1 = 7;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = Expression.Parameter(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), (string) SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-740338220 ^ -740319476));
            // ISSUE: method reference
            Expression<Func<SystemFile, DateTime>> property1 = Expression.Lambda<Func<SystemFile, DateTime>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SystemFile.get_CreateDate))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_8;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_8 = mapping1 = (Action<IPropertyMapper>) (p => p.Type<DateTimeNHType>());
            }
            else
              goto label_3;
label_14:
            this.Property<DateTime>(property1, mapping1);
            num1 = 5;
            continue;
label_3:
            mapping1 = action1;
            goto label_14;
          case 2:
            // ISSUE: reference to a compiler-generated field
            Action<ICacheMapper> action2 = SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_16;
            Action<ICacheMapper> cacheMapping;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_16 = cacheMapping = (Action<ICacheMapper>) (c =>
              {
                int num2 = 2;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      c.Include(CacheInclude.NonLazy);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
                      continue;
                    case 2:
                      // ISSUE: reference to a compiler-generated method
                      SystemFileMetadataMap.\u003C\u003Ec.xtUpl2vzWLdjurlswrQY((object) c, (object) CacheUsage.NonstrictReadWrite);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_5;
                  }
                }
label_2:
                return;
label_5:;
              });
            }
            else
              goto label_23;
label_22:
            this.Cache(cacheMapping);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 2 : 4;
            continue;
label_23:
            cacheMapping = action2;
            goto label_22;
          case 3:
            ParameterExpression parameterExpression2;
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<SystemFile, string>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SystemFile.get_ContentType))), parameterExpression2), (Action<IPropertyMapper>) (p =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Length(int.MaxValue);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            continue;
          case 4:
            goto label_20;
          case 5:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-882126494 ^ -882172998));
            // ISSUE: method reference
            Expression<Func<SystemFile, string>> property2 = Expression.Lambda<Func<SystemFile, string>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression3, (object) (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_FileCrc))), parameterExpression3);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action3 = SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_10;
            Action<IPropertyMapper> mapping2;
            if (action3 == null)
            {
              // ISSUE: reference to a compiler-generated field
              SystemFileMetadataMap.\u003C\u003Ec.\u003C\u003E9__0_10 = mapping2 = (Action<IPropertyMapper>) (p =>
              {
                int num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      SystemFileMetadataMap.\u003C\u003Ec.MqQri1vzFuJ9lM4mXKAn((object) p, int.MaxValue);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_2;
                    default:
                      // ISSUE: reference to a compiler-generated method
                      SystemFileMetadataMap.\u003C\u003Ec.P7H6DQvzBYGMFphRgKXF((object) p, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957707538));
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 0 : 2;
                      continue;
                  }
                }
label_2:;
              });
            }
            else
              goto label_24;
label_17:
            this.Property<string>(property2, mapping2);
            num1 = 6;
            continue;
label_24:
            mapping2 = action3;
            goto label_17;
          case 6:
            ParameterExpression parameterExpression4 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(typeof (SystemFile), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293734972));
            // ISSUE: method reference
            this.Property<long?>(Expression.Lambda<Func<SystemFile, long?>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression4, (object) (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_FileSize))), parameterExpression4));
            num1 = 11;
            continue;
          case 7:
            SystemFileMetadataMap.nBJ5QeGk4LnQBtFeKQE2((object) this, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477289038));
            num1 = 9;
            continue;
          case 8:
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917306962));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<SystemFile, Guid>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression5, (object) (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_Uid))), parameterExpression5));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 9:
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = Expression.Parameter(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), (string) SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-680446928 - -370807692 ^ -309621404));
            // ISSUE: method reference
            this.Id<int>(Expression.Lambda<Func<SystemFile, int>>((Expression) Expression.Property((Expression) parameterExpression6, (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_Id))), parameterExpression6), (Action<IIdMapper>) (p =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    SystemFileMetadataMap.\u003C\u003Ec.qd41Grvcz78iqaI9909H((object) p, SystemFileMetadataMap.\u003C\u003Ec.SREaV5vccJCW7GaR8Yp2(901793403 ^ 901910035), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675538719));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 8;
            continue;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression7 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-1380439818 << 3 ^ 1841401192));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<SystemFile, bool>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression7, (object) (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_Encrypt))), parameterExpression7));
            num1 = 12;
            continue;
          case 11:
            // ISSUE: type reference
            ParameterExpression parameterExpression8 = Expression.Parameter(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), (string) SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-1445902765 ^ -1980277732 ^ 539414679));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<SystemFile, string>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression8, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (SystemFile.get_Salt))), parameterExpression8), (Action<IPropertyMapper>) (p =>
            {
              int num6 = 1;
              while (true)
              {
                switch (num6)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Length(int.MaxValue);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 10;
            continue;
          case 12:
            // ISSUE: type reference
            ParameterExpression parameterExpression9 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(1142330761 ^ 1541959139 ^ 536752818));
            // ISSUE: method reference
            this.Property<bool>(Expression.Lambda<Func<SystemFile, bool>>((Expression) SystemFileMetadataMap.qW5WqsGkxMRSXfcQVPv7((object) parameterExpression9, (object) (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_IsDeleted))), parameterExpression9));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 1 : 2;
            continue;
          default:
            // ISSUE: type reference
            ParameterExpression parameterExpression10 = (ParameterExpression) SystemFileMetadataMap.FLgHtdGk7FuWS0GYIwAp(SystemFileMetadataMap.D7ArMGGk6OyY6lHQSLuc(__typeref (SystemFile)), SystemFileMetadataMap.hmJqB6GkHGAqJVebaGtr(-1380439818 << 3 ^ 1841401192));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<SystemFile, string>>((Expression) Expression.Property((Expression) parameterExpression10, (MethodInfo) SystemFileMetadataMap.P1FcbvGkApex8ysZ8iGN(__methodref (SystemFile.get_Name))), parameterExpression10), (Action<IPropertyMapper>) (p =>
            {
              int num7 = 1;
              while (true)
              {
                switch (num7)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    SystemFileMetadataMap.\u003C\u003Ec.MqQri1vzFuJ9lM4mXKAn((object) p, int.MaxValue);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 3;
            continue;
        }
      }
label_20:;
    }

    internal static void WD8wLTGkwPn2FJNVogV1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void nBJ5QeGk4LnQBtFeKQE2([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<SystemFile>) obj0).Table((string) obj1));

    internal static Type D7ArMGGk6OyY6lHQSLuc([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object hmJqB6GkHGAqJVebaGtr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object P1FcbvGkApex8ysZ8iGN([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object FLgHtdGk7FuWS0GYIwAp([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object qW5WqsGkxMRSXfcQVPv7([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static bool DMMIhCGkD7A2U8bYexlK() => SystemFileMetadataMap.OnxHAqGkaSOr8Bn7wraQ == null;

    internal static SystemFileMetadataMap mBBWuvGktpWp2UtILJHm() => SystemFileMetadataMap.OnxHAqGkaSOr8Bn7wraQ;
  }
}

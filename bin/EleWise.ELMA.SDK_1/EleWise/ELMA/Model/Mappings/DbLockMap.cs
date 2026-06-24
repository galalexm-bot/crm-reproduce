// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.DbLockMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
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

namespace EleWise.ELMA.Model.Mappings
{
  /// <summary>Маппинг DbLock</summary>
  internal sealed class DbLockMap : ClassMapping<DbLock>
  {
    internal static DbLockMap ocqJJjhbGded5QAkNiXx;

    /// <summary>Ctor</summary>
    public DbLockMap()
    {
      DbLockMap.LSgk6KhbQmUfeWyp1wIa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 3;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) DbLockMap.O8uw0ShbZbr7u8BpMV5H(DbLockMap.hJjnwJhb8j4E6K1bmjGx(__typeref (DbLock)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767738589));
            // ISSUE: method reference
            Expression<Func<DbLock, DateTime?>> property1 = Expression.Lambda<Func<DbLock, DateTime?>>((Expression) Expression.Property((Expression) parameterExpression1, (MethodInfo) DbLockMap.FmmM34hbVikmvvjrGDCc(__methodref (DbLock.get_CreationDate))), parameterExpression1);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = DbLockMap.\u003C\u003Ec.\u003C\u003E9__0_5;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbLockMap.\u003C\u003Ec.\u003C\u003E9__0_5 = mapping1 = (Action<IPropertyMapper>) (p => p.Type<DateTimeWithoutOffsetNHType>());
            }
            else
              goto label_14;
label_9:
            this.Property<DateTime?>(property1, mapping1);
            num1 = 4;
            continue;
label_14:
            mapping1 = action1;
            goto label_9;
          case 2:
            this.Lazy(false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 6 : 6;
            continue;
          case 3:
            DbLockMap.yGjROJhbvC72cxua84xt((object) this, DbLockMap.TDvwSXhbC9N18tT2QyEL(-342626196 - 1290888215 ^ -1633477781));
            num1 = 2;
            continue;
          case 4:
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) DbLockMap.O8uw0ShbZbr7u8BpMV5H(DbLockMap.hJjnwJhb8j4E6K1bmjGx(__typeref (DbLock)), DbLockMap.TDvwSXhbC9N18tT2QyEL(--1360331293 ^ 1360382149));
            // ISSUE: method reference
            Expression<Func<DbLock, DateTime?>> property2 = Expression.Lambda<Func<DbLock, DateTime?>>((Expression) DbLockMap.DZR679hbIKYf7cFbR28w((object) parameterExpression2, (object) (MethodInfo) DbLockMap.FmmM34hbVikmvvjrGDCc(__methodref (DbLock.get_ValidUntilDate))), parameterExpression2);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = DbLockMap.\u003C\u003Ec.\u003C\u003E9__0_7;
            Action<IPropertyMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              DbLockMap.\u003C\u003Ec.\u003C\u003E9__0_7 = mapping2 = (Action<IPropertyMapper>) (p => p.Type<DateTimeWithoutOffsetNHType>());
            }
            else
              goto label_15;
label_13:
            this.Property<DateTime?>(property2, mapping2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
label_15:
            mapping2 = action2;
            goto label_13;
          case 5:
            goto label_11;
          case 6:
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) DbLockMap.O8uw0ShbZbr7u8BpMV5H(DbLockMap.hJjnwJhb8j4E6K1bmjGx(__typeref (DbLock)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889550686));
            // ISSUE: method reference
            // ISSUE: type reference
            this.Id<string>(Expression.Lambda<Func<DbLock, string>>((Expression) DbLockMap.DZR679hbIKYf7cFbR28w((object) parameterExpression3, (object) (MethodInfo) DbLockMap.E0g6Ebhbu4KEpXJo7xc3(__methodref (Entity<string>.get_Id), __typeref (Entity<string>))), parameterExpression3), (Action<IIdMapper>) (i =>
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
                    DbLockMap.\u003C\u003Ec.w4wkN9ClwpyhYOoZfgoM((object) i, DbLockMap.\u003C\u003Ec.Ag4mPRCltLheGeC6MK3h());
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 6 : 7;
            continue;
          case 7:
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) DbLockMap.O8uw0ShbZbr7u8BpMV5H(DbLockMap.hJjnwJhb8j4E6K1bmjGx(__typeref (DbLock)), DbLockMap.TDvwSXhbC9N18tT2QyEL(~-397266137 ^ 397215232));
            // ISSUE: method reference
            this.Property<string>(Expression.Lambda<Func<DbLock, string>>((Expression) Expression.Property((Expression) parameterExpression4, (MethodInfo) DbLockMap.FmmM34hbVikmvvjrGDCc(__methodref (DbLock.get_MachineName))), parameterExpression4), (Action<IPropertyMapper>) (p =>
            {
              int num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    DbLockMap.\u003C\u003Ec.QckoAjCl4IS1jfuQsXSa((object) p, int.MaxValue);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
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
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) DbLockMap.O8uw0ShbZbr7u8BpMV5H(DbLockMap.hJjnwJhb8j4E6K1bmjGx(__typeref (DbLock)), DbLockMap.TDvwSXhbC9N18tT2QyEL(-1217523399 ^ -1217471519));
            // ISSUE: method reference
            this.Property<Guid>(Expression.Lambda<Func<DbLock, Guid>>((Expression) DbLockMap.DZR679hbIKYf7cFbR28w((object) parameterExpression5, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (DbLock.get_Value))), parameterExpression5));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 3;
            continue;
        }
      }
label_11:;
    }

    internal static void LSgk6KhbQmUfeWyp1wIa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object TDvwSXhbC9N18tT2QyEL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void yGjROJhbvC72cxua84xt([In] object obj0, [In] object obj1) => __nonvirtual (((ClassCustomizer<DbLock>) obj0).Table((string) obj1));

    internal static Type hJjnwJhb8j4E6K1bmjGx([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object O8uw0ShbZbr7u8BpMV5H([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object E0g6Ebhbu4KEpXJo7xc3([In] RuntimeMethodHandle obj0, [In] RuntimeTypeHandle obj1) => (object) MethodBase.GetMethodFromHandle(obj0, obj1);

    internal static object DZR679hbIKYf7cFbR28w([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object FmmM34hbVikmvvjrGDCc([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static bool rsFyCjhbEBpg9lxGVcpP() => DbLockMap.ocqJJjhbGded5QAkNiXx == null;

    internal static DbLockMap lElT2Dhbfvr4gCcOk7Jy() => DbLockMap.ocqJJjhbGded5QAkNiXx;
  }
}

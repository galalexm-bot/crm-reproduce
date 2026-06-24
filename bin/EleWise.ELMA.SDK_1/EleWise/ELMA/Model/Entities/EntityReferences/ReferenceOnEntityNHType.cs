// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityReferences.ReferenceOnEntityNHType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Engine;
using NHibernate.Type;
using NHibernate.UserTypes;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Data;
using System.Data.Common;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.EntityReferences
{
  [Serializable]
  public class ReferenceOnEntityNHType : ICompositeUserType
  {
    public static string ObjectIdColumn;
    public static string ObjectTypeUid;
    internal static ReferenceOnEntityNHType qI4Zr0hV11IshGVNyXqH;

    public static string GenerateObjectIdName(string propertyName) => (string) ReferenceOnEntityNHType.BVrOFyhVpTtcBGjQtU15((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606608394), (object) propertyName, (object) ReferenceOnEntityNHType.ObjectIdColumn);

    public static string GenerateObjectTypeName(string propertyName) => (string) ReferenceOnEntityNHType.BVrOFyhVpTtcBGjQtU15(ReferenceOnEntityNHType.fawoS3hVaYY1EfahyDre(2008901894 << 3 ^ -1108632870), (object) propertyName, (object) ReferenceOnEntityNHType.ObjectTypeUid);

    public object DeepCopy(object value)
    {
      int num = 3;
      ReferenceOnEntity referenceOnEntity1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            referenceOnEntity1 = ReferenceOnEntityNHType.AsReferenceOnEntity(value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          case 3:
            if (value != null)
            {
              num = 2;
              continue;
            }
            goto label_5;
          default:
            goto label_2;
        }
      }
label_2:
      ReferenceOnEntity referenceOnEntity2 = new ReferenceOnEntity();
      ReferenceOnEntityNHType.DGB34WhVtqTR06LAKCu0((object) referenceOnEntity2, ReferenceOnEntityNHType.AQRRTlhVDuck9Uj6Simy((object) referenceOnEntity1));
      ReferenceOnEntityNHType.uxexFOhV4gkh2cJpTSUb((object) referenceOnEntity2, ReferenceOnEntityNHType.VqZ4PDhVwdOcC3fAQkLM((object) referenceOnEntity1));
      return (object) referenceOnEntity2;
label_5:
      return (object) null;
    }

    public object Assemble(object cached, ISessionImplementor session, object owner) => this.DeepCopy(cached);

    public object Disassemble(object value, ISessionImplementor session) => this.DeepCopy(value);

    public bool Equals(object x, object y)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_4;
          case 3:
            if (x != y)
            {
              if (x != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 4 : 2;
                continue;
              }
              goto label_2;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 2 : 0;
              continue;
            }
          case 4:
            if (y != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 1;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return x.Equals(y);
label_4:
      return true;
    }

    public int GetHashCode(object x)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (x == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return x.GetHashCode();
label_3:
      return typeof (ReferenceOnEntity).GetHashCode() + 321;
    }

    public bool IsMutable => true;

    public object NullSafeGet(
      DbDataReader dr,
      string[] names,
      ISessionImplementor session,
      object owner)
    {
      int num = 4;
      object obj1;
      object obj2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj2 == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 5 : 5;
              continue;
            }
            goto label_2;
          case 2:
          case 5:
            goto label_3;
          case 3:
            obj2 = ReferenceOnEntityNHType.rMJfWHhV6jTYkcAdOQ0X((object) NHibernateUtil.Guid, (object) dr, (object) names[1], (object) session);
            num = 6;
            continue;
          case 4:
            obj1 = ReferenceOnEntityNHType.rMJfWHhV6jTYkcAdOQ0X((object) NHibernateUtil.Int64, (object) dr, (object) names[0], (object) session);
            num = 3;
            continue;
          case 6:
            if (obj1 == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_2;
        }
      }
label_2:
      ReferenceOnEntity referenceOnEntity = new ReferenceOnEntity();
      ReferenceOnEntityNHType.DGB34WhVtqTR06LAKCu0((object) referenceOnEntity, ReferenceOnEntityNHType.JkZic0hVHKwew6bgRDt8(obj1));
      ReferenceOnEntityNHType.uxexFOhV4gkh2cJpTSUb((object) referenceOnEntity, (Guid) obj2);
      return (object) referenceOnEntity;
label_3:
      return (object) null;
    }

    public void NullSafeSet(DbCommand cmd, object value, int index, ISessionImplementor session)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        ReferenceOnEntity referenceOnEntity;
        while (true)
        {
          switch (num2)
          {
            case 1:
              referenceOnEntity = (ReferenceOnEntity) ReferenceOnEntityNHType.c5HeIrhVA6OL6d8sEixM(value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_5;
            case 3:
              ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv(ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv(ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd), index), (object) DBNull.Value);
              num2 = 7;
              continue;
            case 4:
              ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv(ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv(ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd), index + 1), (object) ReferenceOnEntityNHType.VqZ4PDhVwdOcC3fAQkLM((object) referenceOnEntity));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 6 : 6;
              continue;
            case 5:
              goto label_8;
            case 6:
              goto label_7;
            case 7:
              ((IDataParameter) ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv(ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd), index + 1)).Value = (object) DBNull.Value;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 2;
              continue;
            default:
              if (referenceOnEntity != null)
              {
                num2 = 5;
                continue;
              }
              goto case 3;
          }
        }
label_8:
        ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv((object) ((DbParameterCollection) ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd))[index], (object) ReferenceOnEntityNHType.AQRRTlhVDuck9Uj6Simy((object) referenceOnEntity));
        num1 = 4;
      }
label_5:
      return;
label_7:;
    }

    public void NullSafeSet(
      DbCommand cmd,
      object value,
      int index,
      bool[] settable,
      ISessionImplementor session)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        ReferenceOnEntity referenceOnEntity;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_18;
            case 3:
              if (referenceOnEntity == null)
              {
                num2 = 11;
                continue;
              }
              if (!settable[0])
              {
                num2 = 12;
                continue;
              }
              goto case 6;
            case 4:
              goto label_10;
            case 5:
              ((DbParameterCollection) ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd))[index + 1].Value = (object) referenceOnEntity.ObjectTypeUId;
              num2 = 2;
              continue;
            case 6:
              ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv(ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv((object) cmd.Parameters, index), (object) ReferenceOnEntityNHType.AQRRTlhVDuck9Uj6Simy((object) referenceOnEntity));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 3 : 10;
              continue;
            case 7:
              ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv(ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv(ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd), index), (object) DBNull.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
              continue;
            case 8:
              ReferenceOnEntityNHType.XONBM3hV0tikU3xAxrEv(ReferenceOnEntityNHType.blaY5ShVx1Ia03EHppFv(ReferenceOnEntityNHType.HCDpdkhV7gHurE6jcYNV((object) cmd), index + 1), (object) DBNull.Value);
              num2 = 9;
              continue;
            case 9:
              goto label_11;
            case 10:
            case 12:
              if (!settable[1])
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 8 : 13;
                continue;
              }
              goto case 5;
            case 11:
              if (!settable[0])
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                continue;
              }
              goto case 7;
            case 13:
              goto label_5;
            default:
              if (settable[1])
              {
                num2 = 8;
                continue;
              }
              goto label_9;
          }
        }
label_10:
        referenceOnEntity = ReferenceOnEntityNHType.AsReferenceOnEntity(value);
        num1 = 3;
      }
label_18:
      return;
label_11:
      return;
label_5:
      return;
label_9:;
    }

    public string[] PropertyNames => new string[2]
    {
      ReferenceOnEntityNHType.ObjectIdColumn,
      ReferenceOnEntityNHType.ObjectTypeUid
    };

    public IType[] PropertyTypes => new IType[2]
    {
      (IType) NHibernateUtil.Int64,
      (IType) NHibernateUtil.Guid
    };

    public object Replace(
      object original,
      object target,
      ISessionImplementor session,
      object owner)
    {
      return this.DeepCopy(original);
    }

    public System.Type ReturnedClass => ReferenceOnEntityNHType.AJqrcghVmXDxtfQ76Zdp(__typeref (ReferenceOnEntity));

    public object GetPropertyValue(object component, int property)
    {
      int num = 3;
      ReferenceOnEntity referenceOnEntity;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (property == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 4 : 4;
              continue;
            }
            goto case 5;
          case 3:
            referenceOnEntity = (ReferenceOnEntity) ReferenceOnEntityNHType.c5HeIrhVA6OL6d8sEixM(component);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 0;
            continue;
          case 5:
            if (property != 1)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
              continue;
            }
            goto label_8;
          default:
            goto label_7;
        }
      }
label_7:
      return (object) ReferenceOnEntityNHType.AQRRTlhVDuck9Uj6Simy((object) referenceOnEntity);
label_8:
      return (object) ReferenceOnEntityNHType.VqZ4PDhVwdOcC3fAQkLM((object) referenceOnEntity);
label_9:
      throw new Exception(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137584058), (object) property));
    }

    public void SetPropertyValue(object component, int property, object value)
    {
      int num = 3;
      ReferenceOnEntity referenceOnEntity;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            goto label_13;
          case 3:
            if (component == null)
            {
              num = 2;
              continue;
            }
            referenceOnEntity = (ReferenceOnEntity) ReferenceOnEntityNHType.c5HeIrhVA6OL6d8sEixM(component);
            num = 4;
            continue;
          case 4:
            if (property == 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
              continue;
            }
            goto case 5;
          case 5:
            if (property != 1)
            {
              num = 7;
              continue;
            }
            ReferenceOnEntityNHType.uxexFOhV4gkh2cJpTSUb((object) referenceOnEntity, (Guid) value);
            num = 8;
            continue;
          case 7:
            goto label_4;
          case 8:
            goto label_5;
          default:
            ReferenceOnEntityNHType.DGB34WhVtqTR06LAKCu0((object) referenceOnEntity, ReferenceOnEntityNHType.JkZic0hVHKwew6bgRDt8(value));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:
      return;
label_5:
      return;
label_4:
      throw new Exception((string) ReferenceOnEntityNHType.G4JNLnhVyulnpvEKEvVw((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669512291), (object) property));
label_13:
      throw new ArgumentNullException((string) ReferenceOnEntityNHType.fawoS3hVaYY1EfahyDre(1051802738 - -1831968059 ^ -1411321787));
    }

    private static ReferenceOnEntity AsReferenceOnEntity(object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
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
      return (ReferenceOnEntity) null;
label_5:
      // ISSUE: type reference
      return value is ReferenceOnEntity referenceOnEntity ? referenceOnEntity : throw new InvalidCastException(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345283526), (object) ReferenceOnEntityNHType.AJqrcghVmXDxtfQ76Zdp(__typeref (ReferenceOnEntity)), (object) value.GetType()));
    }

    public ReferenceOnEntityNHType()
    {
      ReferenceOnEntityNHType.vHD863hVMEAZMZ43oFGV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ReferenceOnEntityNHType()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ReferenceOnEntityNHType.ObjectIdColumn = (string) ReferenceOnEntityNHType.fawoS3hVaYY1EfahyDre(~289714581 ^ -289928504);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 3;
            continue;
          case 2:
            ReferenceOnEntityNHType.vHD863hVMEAZMZ43oFGV();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 1;
            continue;
          case 3:
            ReferenceOnEntityNHType.ObjectTypeUid = (string) ReferenceOnEntityNHType.fawoS3hVaYY1EfahyDre(-1824388195 ^ -1824436425);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    internal static object BVrOFyhVpTtcBGjQtU15([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool eMcTYThVNkOhthoXT6G5() => ReferenceOnEntityNHType.qI4Zr0hV11IshGVNyXqH == null;

    internal static ReferenceOnEntityNHType aWU1sehV3SZRBPlNEXle() => ReferenceOnEntityNHType.qI4Zr0hV11IshGVNyXqH;

    internal static object fawoS3hVaYY1EfahyDre(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static long AQRRTlhVDuck9Uj6Simy([In] object obj0) => ((ReferenceOnEntity) obj0).ObjectId;

    internal static void DGB34WhVtqTR06LAKCu0([In] object obj0, long value) => ((ReferenceOnEntity) obj0).ObjectId = value;

    internal static Guid VqZ4PDhVwdOcC3fAQkLM([In] object obj0) => ((ReferenceOnEntity) obj0).ObjectTypeUId;

    internal static void uxexFOhV4gkh2cJpTSUb([In] object obj0, Guid value) => ((ReferenceOnEntity) obj0).ObjectTypeUId = value;

    internal static object rMJfWHhV6jTYkcAdOQ0X(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((NullableType) obj0).NullSafeGet((DbDataReader) obj1, (string) obj2, (ISessionImplementor) obj3);
    }

    internal static long JkZic0hVHKwew6bgRDt8([In] object obj0) => Convert.ToInt64(obj0);

    internal static object c5HeIrhVA6OL6d8sEixM([In] object obj0) => (object) ReferenceOnEntityNHType.AsReferenceOnEntity(obj0);

    internal static object HCDpdkhV7gHurE6jcYNV([In] object obj0) => (object) ((DbCommand) obj0).Parameters;

    internal static object blaY5ShVx1Ia03EHppFv([In] object obj0, [In] int obj1) => (object) ((DbParameterCollection) obj0)[obj1];

    internal static void XONBM3hV0tikU3xAxrEv([In] object obj0, [In] object obj1) => ((IDataParameter) obj0).Value = obj1;

    internal static System.Type AJqrcghVmXDxtfQ76Zdp([In] RuntimeTypeHandle obj0) => System.Type.GetTypeFromHandle(obj0);

    internal static object G4JNLnhVyulnpvEKEvVw([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static void vHD863hVMEAZMZ43oFGV() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

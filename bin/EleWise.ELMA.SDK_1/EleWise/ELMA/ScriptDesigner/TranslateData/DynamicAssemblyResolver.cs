// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ScriptDesigner.TranslateData.DynamicAssemblyResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.Security;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.ScriptDesigner.TranslateData
{
  public static class DynamicAssemblyResolver
  {
    private static DynamicAssemblyResolver T6Y2xZ84S33FNHQYKFp;

    public static ActionGroupCodeItemPoint GetElmaApiFullTree(Assembly dynamicAssembly) => DynamicAssemblyResolver.RegistrateActionDesigner(dynamicAssembly.GetType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426078193)), (object) null, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1319452732 ^ 1319436554));

    private static ActionGroupCodeItemPoint RegistrateActionDesigner(
      Type nodeType,
      object actionGroup,
      object callPath)
    {
      int num1 = 13;
      List<IGrouping<string, MethodInfo>>.Enumerator enumerator1;
      ActionGroupCodeItemPoint groupCodeItemPoint1;
      while (true)
      {
        List<PropertyInfo>.Enumerator enumerator2;
        List<MethodInfo> list;
        object obj1;
        switch (num1)
        {
          case 1:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G((object) nodeType), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(901793403 ^ 901777375)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 5;
              continue;
            }
            goto label_44;
          case 2:
          case 3:
          case 7:
            goto label_44;
          case 4:
            goto label_6;
          case 5:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G((object) nodeType), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951498714)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 2 : 0;
              continue;
            }
            goto case 6;
          case 6:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921((object) nodeType.Name, DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(322893104 - -1992822529 ^ -1979234863)))
            {
              num1 = 3;
              continue;
            }
            IEnumerable<MethodInfo> source = ((IEnumerable<MethodInfo>) nodeType.GetMethods()).Where<MethodInfo>(new Func<MethodInfo, bool>(DynamicAssemblyResolver.IsValidMethod));
            // ISSUE: reference to a compiler-generated field
            Func<MethodInfo, string> func = DynamicAssemblyResolver.\u003C\u003Ec.\u003C\u003E9__2_0;
            Func<MethodInfo, string> keySelector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              DynamicAssemblyResolver.\u003C\u003Ec.\u003C\u003E9__2_0 = keySelector = (Func<MethodInfo, string>) (a => a.Name);
            }
            else
              goto label_50;
label_47:
            list = source.OrderBy<MethodInfo, string>(keySelector).ToList<MethodInfo>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 9 : 9;
            continue;
label_50:
            keySelector = func;
            goto label_47;
          case 8:
label_49:
            // ISSUE: reference to a compiler-generated method
            enumerator1 = list.GroupBy<MethodInfo, string>((Func<MethodInfo, string>) (a => (string) DynamicAssemblyResolver.\u003C\u003Ec.zDk32Tf7le7ad4X2hwt3((object) a))).ToList<IGrouping<string, MethodInfo>>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 4;
            continue;
          case 9:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            enumerator2 = ((IEnumerable<PropertyInfo>) nodeType.GetProperties()).Where<PropertyInfo>((Func<PropertyInfo, bool>) (a => DynamicAssemblyResolver.\u003C\u003Ec.VhGc3wf7dLtem7Mary3F(DynamicAssemblyResolver.\u003C\u003Ec.mhPX0Hf793mJn90AdVev((object) a), typeof (Permission)))).ToList<PropertyInfo>().Where<PropertyInfo>(new Func<PropertyInfo, bool>(DynamicAssemblyResolver.IsValidProperty)).ToList<PropertyInfo>().GetEnumerator();
            num1 = 10;
            continue;
          case 10:
            try
            {
label_28:
              if (enumerator2.MoveNext())
                goto label_24;
              else
                goto label_29;
label_20:
              int num2;
              int num3 = num2;
label_21:
              PropertyInfo current;
              ActionGroupCodeItemPoint groupCodeItemPoint2;
              string str;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    groupCodeItemPoint1.ActionGroups.Add((ActionGroupBaseCodeItemPoint) groupCodeItemPoint2);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 5 : 3;
                    continue;
                  case 2:
                    ActionGroupCodeItemPoint groupCodeItemPoint3 = new ActionGroupCodeItemPoint((string) DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G((object) current));
                    DynamicAssemblyResolver.RqlI9l8MBtjZlDFNCUu((object) groupCodeItemPoint3, DynamicAssemblyResolver.GXp8YG8yGCxKghKFrRf((object) current));
                    groupCodeItemPoint2 = groupCodeItemPoint3;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
                    continue;
                  case 3:
                    goto label_28;
                  case 4:
                    if (((IEnumerable<PropertyInfo>) DynamicAssemblyResolver.UgPruH8myrTncoDA61S((object) current).GetProperties()).Any<PropertyInfo>(new Func<PropertyInfo, bool>(DynamicAssemblyResolver.IsValidProperty)))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
                      continue;
                    }
                    goto label_28;
                  case 5:
                    str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272608119), callPath, (object) current.Name);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
                    continue;
                  case 6:
                    if (!((IEnumerable<MethodInfo>) DynamicAssemblyResolver.UgPruH8myrTncoDA61S((object) current).GetMethods()).Where<MethodInfo>(new Func<MethodInfo, bool>(DynamicAssemblyResolver.IsValidMethod)).Any<MethodInfo>())
                    {
                      num3 = 4;
                      continue;
                    }
                    goto case 2;
                  case 7:
                    goto label_49;
                  case 8:
                    goto label_24;
                  default:
                    goto label_22;
                }
              }
label_22:
              DynamicAssemblyResolver.pXashy8J4XDJaMWSi4E(DynamicAssemblyResolver.UgPruH8myrTncoDA61S((object) current), (object) groupCodeItemPoint2, (object) str);
              num2 = 3;
              goto label_20;
label_24:
              current = enumerator2.Current;
              num2 = 6;
              goto label_20;
label_29:
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 7 : 0;
              goto label_21;
            }
            finally
            {
              enumerator2.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          case 11:
            goto label_37;
          case 12:
            obj1 = (object) new ActionGroupCodeItemPoint((string) DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(~541731958 ^ -541748505));
            break;
          case 13:
            object obj2 = actionGroup;
            if (obj2 == null)
            {
              num1 = 12;
              continue;
            }
            obj1 = obj2;
            break;
          default:
            if (!DynamicAssemblyResolver.KdKSsi87Qvv3LG8cVWo((object) nodeType.Namespace, DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(1199946765 ^ 1199963525)))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 7 : 0;
              continue;
            }
            goto case 1;
        }
        groupCodeItemPoint1 = (ActionGroupCodeItemPoint) obj1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
      }
label_6:
      try
      {
label_11:
        if (enumerator1.MoveNext())
          goto label_8;
        else
          goto label_12;
label_7:
        ActionOverridesCodeItemPoint overridesCodeItemPoint;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
              goto label_8;
            case 2:
              goto label_11;
            case 3:
              goto label_37;
            default:
              groupCodeItemPoint1.Actions.Add(overridesCodeItemPoint);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 2;
              continue;
          }
        }
label_8:
        overridesCodeItemPoint = new ActionOverridesCodeItemPoint(enumerator1.Current, (string) callPath);
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
        {
          num5 = 0;
          goto label_7;
        }
        else
          goto label_7;
label_12:
        num5 = 3;
        goto label_7;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
label_37:
      return groupCodeItemPoint1;
label_44:
      return (ActionGroupCodeItemPoint) null;
    }

    private static bool IsValidProperty(object propertyInfo)
    {
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
          case 2:
          case 4:
          case 6:
            goto label_4;
          case 3:
            if ((string) DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(propertyInfo) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121144425))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 0;
              continue;
            }
            goto label_5;
          case 5:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921((object) ((MemberInfo) propertyInfo).Name, DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-606654180 ^ -606637272)))
            {
              num = 4;
              continue;
            }
            break;
          case 7:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(propertyInfo), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-1822890472 ^ -1822907380)))
            {
              num = 6;
              continue;
            }
            goto case 8;
          case 8:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(propertyInfo), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870909419)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 2 : 2;
              continue;
            }
            goto case 5;
        }
        if (!((string) DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(propertyInfo) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420760206)))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 3 : 0;
        else
          break;
      }
label_4:
      return false;
label_5:
      return true;
    }

    private static bool IsValidMethod(object method)
    {
      int num = 22;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(222162814 ^ 222160016)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 4 : 20;
              continue;
            }
            goto case 6;
          case 2:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-1852837372 ^ -1852853976)))
            {
              num = 16;
              continue;
            }
            goto label_28;
          case 3:
            if (DynamicAssemblyResolver.KdKSsi87Qvv3LG8cVWo((object) ((MemberInfo) method).Name, DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(1113862659 ^ 1113865859)))
            {
              num = 11;
              continue;
            }
            goto case 23;
          case 4:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-649342099 - -1150814748 ^ 501456735)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 17 : 4;
              continue;
            }
            goto label_28;
          case 5:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408909926)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 14 : 2;
              continue;
            }
            goto label_28;
          case 6:
            if ((string) DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method) == (string) DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-649342099 - -1150814748 ^ 501456517))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 19 : 5;
              continue;
            }
            goto case 15;
          case 7:
            // ISSUE: type reference
            if (DynamicAssemblyResolver.uCgpTV8lfMG7PZd6rfi(DynamicAssemblyResolver.Vo3mJr89mKnMXZyeGoT(method), DynamicAssemblyResolver.mDupjr8dsKD180UCFo8(__typeref (object))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            }
            goto label_29;
          case 8:
            if (DynamicAssemblyResolver.KdKSsi87Qvv3LG8cVWo(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-1487388570 ^ -1487404294)))
            {
              num = 12;
              continue;
            }
            goto case 18;
          case 9:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921((object) ((MemberInfo) method).Name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494354)))
            {
              num = 5;
              continue;
            }
            goto label_28;
          case 13:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921((object) ((MemberInfo) method).Name, DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(1917256330 ^ 1917272164)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 1 : 1;
              continue;
            }
            goto label_28;
          case 14:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(~541731958 ^ -541748915)))
            {
              num = 4;
              continue;
            }
            goto label_28;
          case 15:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(1251470110 >> 2 ^ 312850905)))
            {
              num = 2;
              continue;
            }
            goto label_28;
          case 16:
            if (!((string) DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70024143)))
            {
              num = 8;
              continue;
            }
            goto label_28;
          case 17:
            if (DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217506341)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 7 : 10;
              continue;
            }
            goto case 13;
          case 18:
            if (!DynamicAssemblyResolver.KdKSsi87Qvv3LG8cVWo(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(1819636893 << 3 ^ 1672210076)))
            {
              num = 3;
              continue;
            }
            goto label_28;
          case 21:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272608241)))
            {
              num = 9;
              continue;
            }
            goto label_28;
          case 22:
            if (!DynamicAssemblyResolver.Kv1J6s80qqyZNH5n921(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(-1217523399 ^ -1217506483)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 21;
              continue;
            }
            goto label_28;
          case 23:
            if (!DynamicAssemblyResolver.KdKSsi87Qvv3LG8cVWo(DynamicAssemblyResolver.LNGs4v8xFpbkVfr0v7G(method), DynamicAssemblyResolver.oP4FUP8AdoRtcbRAIOe(874012245 ^ 874009305)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 7 : 4;
              continue;
            }
            goto label_28;
          default:
            goto label_28;
        }
      }
label_28:
      return false;
label_29:
      return true;
    }

    internal static bool sMqaTW86SNyy5rxJKOS() => DynamicAssemblyResolver.T6Y2xZ84S33FNHQYKFp == null;

    internal static DynamicAssemblyResolver tH22tM8H3riemfOO7OL() => DynamicAssemblyResolver.T6Y2xZ84S33FNHQYKFp;

    internal static object oP4FUP8AdoRtcbRAIOe(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool KdKSsi87Qvv3LG8cVWo([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static object LNGs4v8xFpbkVfr0v7G([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static bool Kv1J6s80qqyZNH5n921([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type UgPruH8myrTncoDA61S([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static object GXp8YG8yGCxKghKFrRf([In] object obj0) => (object) XmlCommentsHelper.GetSummary((PropertyInfo) obj0);

    internal static void RqlI9l8MBtjZlDFNCUu([In] object obj0, [In] object obj1) => ((ActionGroupBaseCodeItemPoint) obj0).Description = (string) obj1;

    internal static object pXashy8J4XDJaMWSi4E(Type nodeType, [In] object obj1, [In] object obj2) => (object) DynamicAssemblyResolver.RegistrateActionDesigner(nodeType, obj1, obj2);

    internal static Type Vo3mJr89mKnMXZyeGoT([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static Type mDupjr8dsKD180UCFo8([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool uCgpTV8lfMG7PZd6rfi([In] Type obj0, [In] Type obj1) => obj0 == obj1;
  }
}

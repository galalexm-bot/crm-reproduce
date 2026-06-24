// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.ExportHelper.ExportRuleList
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.ExportHelper
{
  /// <summary>Набор правил экспорта свойств сущности</summary>
  public class ExportRuleList : List<ExportRule>
  {
    private static ExportRuleList YqEt8SEDZq1QMEiW1CIS;

    private bool IsType(object obj, ExportRuleType exportRuleType)
    {
      int num1 = 1;
      ExportRuleType exportRuleType1;
      object obj1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
              continue;
            case 2:
              obj1 = ExportRuleList.jbkC0FEDimCXDXidFlG1(ExportRuleList.VMKajaEDSbwU4tA2lb7A((object) (INHibernateProxy) obj1));
              num2 = 4;
              continue;
            case 3:
              obj1 = obj;
              num2 = 5;
              continue;
            case 4:
              goto label_8;
            case 5:
              if (ExportRuleList.ksLJBoEDViZjXPnDmmgZ(obj1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 2;
                continue;
              }
              goto label_8;
            default:
              goto label_9;
          }
        }
label_9:
        exportRuleType1 = exportRuleType;
        num1 = 3;
      }
label_8:
      return ExportRuleList.hOOql3EDRRfK70UhQNFi((object) this.FindAll((Predicate<ExportRule>) (r =>
      {
        int num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (ExportRuleList.\u003C\u003Ec__DisplayClass0_0.qJ10lC82NLQ8KSnA7tEw((object) r) == exportRuleType1)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              goto label_6;
            case 3:
              goto label_7;
            default:
              // ISSUE: reference to a compiler-generated method
              if (!ExportRuleList.\u003C\u003Ec__DisplayClass0_0.jl24Tt8237MsXGkXid8o(r.ObjectType, (Type) null))
              {
                num3 = 3;
                continue;
              }
              goto label_6;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        return ExportRuleList.\u003C\u003Ec__DisplayClass0_0.S8T0Wt82p8tY1ucJPIrP((object) r).IsInstanceOfType(obj1);
label_7:
        return false;
      }))) > 0;
    }

    public bool IsTypeIgnore(object obj) => this.IsType(obj, ExportRuleType.Ignore);

    public bool IsTypeExport(object obj) => this.IsType(obj, ExportRuleType.Export);

    public bool IsTypeDeepExport(object obj) => this.IsType(obj, ExportRuleType.ExportDeep);

    private bool IsProperty(PropertyInfo propertyInfo, ExportRuleType exportSettingType)
    {
      int num1 = 3;
      ExportRuleType exportSettingType1;
      PropertyInfo propertyInfo1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            propertyInfo1 = propertyInfo;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
            continue;
          case 2:
            exportSettingType1 = exportSettingType;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ExportRuleList.hOOql3EDRRfK70UhQNFi((object) this.FindAll((Predicate<ExportRule>) (r =>
      {
        int num2 = 2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (ExportRuleList.\u003C\u003Ec__DisplayClass4_0.jlVVwy82A9xFnCL2l3xd(ExportRuleList.\u003C\u003Ec__DisplayClass4_0.UHwGKy826su73B9rtIq9((object) r), ExportRuleList.\u003C\u003Ec__DisplayClass4_0.w5vBYf82HEUQxJC61rsp((object) propertyInfo1)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (ExportRuleList.\u003C\u003Ec__DisplayClass4_0.xdiE8e8241glGvrL1N4q((object) r) == exportSettingType1)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 0;
                continue;
              }
              goto label_10;
            case 3:
              goto label_8;
            default:
              // ISSUE: reference to a compiler-generated method
              if (!ExportRuleList.\u003C\u003Ec__DisplayClass4_0.joc0aV8270iDFlhDEre8(r.ParentType, (Type) null))
              {
                num2 = 3;
                continue;
              }
              goto label_9;
          }
        }
label_8:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ExportRuleList.\u003C\u003Ec__DisplayClass4_0.xhBiDn82xugXZytp0IRD((object) propertyInfo1).IsAssignableFrom(ExportRuleList.\u003C\u003Ec__DisplayClass4_0.tcv8qG820QwqxiR7vN4w((object) r));
label_9:
        return true;
label_10:
        return false;
      }))) > 0;
    }

    public bool IsPropertyIgnore(PropertyInfo propertyInfo)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_10;
          case 3:
            // ISSUE: type reference
            if (!ExportRuleList.NnktKwEDK8tnVBXbdcqj(propertyInfo.PropertyType, ExportRuleList.Wk9wfZEDqaD7uZ8Cn6xE(__typeref (long))))
            {
              num = 2;
              continue;
            }
            goto case 4;
          case 4:
            if (!ExportRuleList.PKpRqeEDknAvMYK5Taeh(ExportRuleList.Dh7jNYEDX5LMFiXclqxv((object) propertyInfo), ExportRuleList.R8VR0xEDT8wfO5f9ieVH(1470998129 - 231418599 ^ 1239612116)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 5:
            if (!ExportRuleList.PKpRqeEDknAvMYK5Taeh((object) propertyInfo.Name, ExportRuleList.R8VR0xEDT8wfO5f9ieVH(-1255365154 ^ 596875508 ^ -1765846344)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            }
            goto label_11;
          default:
            if (ExportRuleList.NnktKwEDK8tnVBXbdcqj(ExportRuleList.AkLl5dEDn5Lt2htAyL8x((object) propertyInfo), typeof (Guid)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 5;
              continue;
            }
            goto label_10;
        }
      }
label_10:
      return this.IsProperty(propertyInfo, ExportRuleType.Ignore);
label_11:
      return true;
    }

    public bool IsPropertyExport(PropertyInfo propertyInfo) => this.IsProperty(propertyInfo, ExportRuleType.Export);

    public bool IsPropertyDeepExport(PropertyInfo propertyInfo) => this.IsProperty(propertyInfo, ExportRuleType.ExportDeep);

    public ExportRuleList()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ksLJBoEDViZjXPnDmmgZ([In] object obj0) => obj0.IsProxy();

    internal static object VMKajaEDSbwU4tA2lb7A([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static object jbkC0FEDimCXDXidFlG1([In] object obj0) => ((ILazyInitializer) obj0).GetImplementation();

    internal static int hOOql3EDRRfK70UhQNFi([In] object obj0) => ((List<ExportRule>) obj0).Count;

    internal static bool h9jxACEDuI7oSR1NrMvF() => ExportRuleList.YqEt8SEDZq1QMEiW1CIS == null;

    internal static ExportRuleList CZ7uKDEDIdEKleuX3hg5() => ExportRuleList.YqEt8SEDZq1QMEiW1CIS;

    internal static Type Wk9wfZEDqaD7uZ8Cn6xE([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool NnktKwEDK8tnVBXbdcqj([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object Dh7jNYEDX5LMFiXclqxv([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object R8VR0xEDT8wfO5f9ieVH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool PKpRqeEDknAvMYK5Taeh([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type AkLl5dEDn5Lt2htAyL8x([In] object obj0) => ((PropertyInfo) obj0).PropertyType;
  }
}

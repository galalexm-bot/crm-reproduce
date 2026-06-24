// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.MetadataItemGroupManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер групп элементов метаданных</summary>
  public class MetadataItemGroupManager : EntityManager<IMetadataItemGroup, long>
  {
    internal static MetadataItemGroupManager bF1dflhFXhemjl6faMYd;

    public static MetadataItemGroupManager Instance => Locator.GetServiceNotNull<MetadataItemGroupManager>();

    /// <summary>Удалить группу</summary>
    /// <param name="group"></param>
    [Transaction]
    [PublicApiMember]
    public override void Delete(IMetadataItemGroup group)
    {
      int num1 = 9;
      // ISSUE: variable of a compiler-generated type
      MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
      IEnumerator<IMetadataItemGroup> enumerator1;
      IEnumerator<IMetadataItemHeader> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) MetadataItemGroupManager.Sko4tahFeLlNSoIjsmXr(MetadataItemGroupManager.sbZQjBhF2ad3XQovf7Pp(__typeref (IMetadataItemGroup)), MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-398663332 ^ -398715172));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            enumerator1 = this.Find(Expression.Lambda<Func<IMetadataItemGroup, bool>>((Expression) MetadataItemGroupManager.BcgFZthFpvmZt98fJJPe(MetadataItemGroupManager.rBBY4dhF1psmeowm68Q5((object) parameterExpression1, (object) (MethodInfo) MetadataItemGroupManager.GaNxx0hFPHRDqh4flgyk(__methodref (IMetadataItemGroup.get_Parent))), MetadataItemGroupManager.jNg0g2hF3kaIql9Ic1OS(MetadataItemGroupManager.kRR7ighFN8jgrxaKVqUB((object) cDisplayClass20, MetadataItemGroupManager.sbZQjBhF2ad3XQovf7Pp(__typeref (MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0))), (object) FieldInfo.GetFieldFromHandle(__fieldref (MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0.group)))), parameterExpression1)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 4 : 4;
            continue;
          case 2:
            try
            {
label_18:
              if (MetadataItemGroupManager.nLeZoxhFt8U3axbhH9MV((object) enumerator2))
                goto label_20;
              else
                goto label_19;
label_17:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_20;
                case 2:
                  goto label_18;
                default:
                  goto label_29;
              }
label_19:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              goto label_17;
label_20:
              IMetadataItemHeader current = enumerator2.Current;
              // ISSUE: reference to a compiler-generated field
              MetadataItemGroupManager.U7EUgRhF6tZ5Fen57UVc((object) current, MetadataItemGroupManager.ftKDCYhFatWEj9vNOFc4((object) cDisplayClass20.group));
              MetadataItemGroupManager.UwLyZThFDfvP0ymnuxVI((object) current);
              num2 = 2;
              goto label_17;
            }
            finally
            {
              int num3;
              if (enumerator2 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              else
                goto label_24;
label_23:
              switch (num3)
              {
                case 1:
                  break;
                default:
              }
label_24:
              enumerator2.Dispose();
              num3 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
              {
                num3 = 1;
                goto label_23;
              }
              else
                goto label_23;
            }
          case 3:
            goto label_26;
          case 4:
            try
            {
label_6:
              if (MetadataItemGroupManager.nLeZoxhFt8U3axbhH9MV((object) enumerator1))
                goto label_8;
              else
                goto label_7;
label_5:
              int num4;
              switch (num4)
              {
                case 1:
                  goto label_30;
                case 2:
                  goto label_6;
                default:
                  goto label_8;
              }
label_7:
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 0;
              goto label_5;
label_8:
              IMetadataItemGroup current = enumerator1.Current;
              // ISSUE: reference to a compiler-generated field
              current.Parent = (IMetadataItemGroup) MetadataItemGroupManager.ftKDCYhFatWEj9vNOFc4((object) cDisplayClass20.group);
              MetadataItemGroupManager.UwLyZThFDfvP0ymnuxVI((object) current);
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
              {
                num4 = 2;
                goto label_5;
              }
              else
                goto label_5;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
              else
                goto label_13;
label_12:
              switch (num5)
              {
                case 1:
                case 2:
              }
label_13:
              MetadataItemGroupManager.WvlxNnhFw4EtTNmSfshu((object) enumerator1);
              num5 = 2;
              goto label_12;
            }
          case 5:
label_29:
            MetadataItemGroupManager.HtOSVOhFHiIsS2Hnqy1F((object) this.Session);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
            continue;
          case 6:
label_30:
            IEntityManager<IMetadataItemHeader> instance = EntityManager<IMetadataItemHeader>.Instance;
            ParameterExpression parameterExpression2 = (ParameterExpression) MetadataItemGroupManager.Sko4tahFeLlNSoIjsmXr(typeof (IMetadataItemHeader), MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(1218962250 ^ 1218924542));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            Expression<Func<IMetadataItemHeader, bool>> condition = Expression.Lambda<Func<IMetadataItemHeader, bool>>((Expression) Expression.Equal((Expression) Expression.Property((Expression) parameterExpression2, (MethodInfo) MetadataItemGroupManager.GaNxx0hFPHRDqh4flgyk(__methodref (IMetadataItemHeader.get_Group))), (Expression) Expression.Field((Expression) MetadataItemGroupManager.kRR7ighFN8jgrxaKVqUB((object) cDisplayClass20, MetadataItemGroupManager.sbZQjBhF2ad3XQovf7Pp(__typeref (MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0))), (FieldInfo) MetadataItemGroupManager.zC9ASvhF4aWWxitObtow(__fieldref (MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0.group)))), parameterExpression2);
            enumerator2 = instance.Find(condition).GetEnumerator();
            num1 = 2;
            continue;
          case 7:
            // ISSUE: reference to a compiler-generated field
            MetadataItemGroupManager.yKpDlDhFOv0f5rwPMA5h((object) cDisplayClass20.group, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-2138958856 ^ -2138905678));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 1 : 1;
            continue;
          case 8:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.group = group;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 7;
            continue;
          case 9:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass20 = new MetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0();
            num1 = 8;
            continue;
          default:
            // ISSUE: reference to a compiler-generated field
            base.Delete(cDisplayClass20.group);
            num1 = 3;
            continue;
        }
      }
label_26:;
    }

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<IMetadataItemGroup>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule1, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule1, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(92412609 - 1050237057 ^ -957729630));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule2, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule2, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-281842504 ^ -281921258));
      exportRule2.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      exportRule3.ParentType = type;
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule3, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(516838154 ^ 516728254));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule4, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule4, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-138018305 ^ -138086607));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule4, ExportRuleType.Export);
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule5, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule5, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(1514961705 ^ 1514932457));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule5, ExportRuleType.Export);
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule6, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule6, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335092669));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      exportRule7.ParentType = type;
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule7, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-740338220 ^ -740309534));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule7, ExportRuleType.Export);
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      MetadataItemGroupManager.Pq4rbohFACTRtIegdx1i((object) exportRule8, type);
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule8, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124700728));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule8, ExportRuleType.Export);
      exportRuleList.Add(exportRule8);
      ExportRule exportRule9 = new ExportRule();
      exportRule9.ParentType = type;
      MetadataItemGroupManager.MIVuJThF7SeerO6a1B2y((object) exportRule9, MetadataItemGroupManager.oJOYu6hFn6xWBW3T1pHd(-281842504 ^ -281869526));
      MetadataItemGroupManager.w6y8XthFxcP3K5ygyksV((object) exportRule9, ExportRuleType.Export);
      exportRuleList.Add(exportRule9);
      return exportRuleList;
    }

    public MetadataItemGroupManager()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object oJOYu6hFn6xWBW3T1pHd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void yKpDlDhFOv0f5rwPMA5h([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type sbZQjBhF2ad3XQovf7Pp([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Sko4tahFeLlNSoIjsmXr([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object GaNxx0hFPHRDqh4flgyk([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object rBBY4dhF1psmeowm68Q5([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object kRR7ighFN8jgrxaKVqUB([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object jNg0g2hF3kaIql9Ic1OS([In] object obj0, [In] object obj1) => (object) Expression.Field((Expression) obj0, (FieldInfo) obj1);

    internal static object BcgFZthFpvmZt98fJJPe([In] object obj0, [In] object obj1) => (object) Expression.Equal((Expression) obj0, (Expression) obj1);

    internal static object ftKDCYhFatWEj9vNOFc4([In] object obj0) => (object) ((IMetadataItemGroup) obj0).Parent;

    internal static void UwLyZThFDfvP0ymnuxVI([In] object obj0) => ((IEntity) obj0).Save();

    internal static bool nLeZoxhFt8U3axbhH9MV([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void WvlxNnhFw4EtTNmSfshu([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object zC9ASvhF4aWWxitObtow([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static void U7EUgRhF6tZ5Fen57UVc([In] object obj0, [In] object obj1) => ((IMetadataItemHeader) obj0).Group = (IMetadataItemGroup) obj1;

    internal static void HtOSVOhFHiIsS2Hnqy1F([In] object obj0) => ((ISession) obj0).Flush();

    internal static bool bDntqZhFTcXQKeceZnAL() => MetadataItemGroupManager.bF1dflhFXhemjl6faMYd == null;

    internal static MetadataItemGroupManager xxjxDMhFkx0iwMQ0kTKQ() => MetadataItemGroupManager.bF1dflhFXhemjl6faMYd;

    internal static void Pq4rbohFACTRtIegdx1i([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static void MIVuJThF7SeerO6a1B2y([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void w6y8XthFxcP3K5ygyksV([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;
  }
}

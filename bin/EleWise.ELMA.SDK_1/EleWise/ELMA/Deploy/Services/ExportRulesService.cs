// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Services.ExportRulesService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Services
{
  /// <summary>Сервис мержа правил экспорта</summary>
  [Service]
  internal class ExportRulesService : IExportRulesService
  {
    internal static ExportRulesService bTFpH0E7CgRJ59lFjq95;

    /// <summary>Объединение базовых правил сущности с кастомными</summary>
    /// <param name="entity"></param>
    /// <param name="customRules"></param>
    /// <returns></returns>
    public virtual ExportRuleList BaseMerge(IEntity entity, ExportRuleList customRules)
    {
      int num1 = 7;
      ExportRuleList source;
      Type type;
      List<ExportRule>.Enumerator enumerator;
      EntityMetadata metadata;
      List<Type> legalTypes;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_6;
          case 2:
            legalTypes.Add(type);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 5;
            continue;
          case 3:
            source.AddRange((IEnumerable<ExportRule>) ExportRulesService.YIQAYsE7ZhOQL28F4hHD((object) this, (object) entity));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 4;
            continue;
          case 4:
            metadata = InterfaceActivator.LoadMetadata(type) as EntityMetadata;
            num1 = 10;
            continue;
          case 6:
            source = new ExportRuleList();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 8 : 3;
            continue;
          case 7:
            num1 = 6;
            continue;
          case 8:
            if (entity == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 1 : 1;
              continue;
            }
            type = entity.GetType();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 3 : 3;
            continue;
          case 9:
            if (legalTypes.Contains(type))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 10:
            List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses((ClassMetadata) metadata);
            // ISSUE: reference to a compiler-generated field
            Func<ClassMetadata, Type> func = ExportRulesService.\u003C\u003Ec.\u003C\u003E9__0_0;
            Func<ClassMetadata, Type> selector;
            if (func == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              ExportRulesService.\u003C\u003Ec.\u003C\u003E9__0_0 = selector = (Func<ClassMetadata, Type>) (m => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ExportRulesService.\u003C\u003Ec.VNeR1b8ayjIhycPPhffe((object) m)));
            }
            else
              goto label_33;
label_32:
            legalTypes = baseClasses.Select<ClassMetadata, Type>(selector).ToList<Type>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 6 : 9;
            continue;
label_33:
            selector = func;
            goto label_32;
          case 11:
            goto label_5;
          case 12:
            goto label_8;
          default:
            enumerator = customRules.Where<ExportRule>((Func<ExportRule, bool>) (r => legalTypes.Contains(r.ParentType))).ToList<ExportRule>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 12 : 2;
            continue;
        }
      }
label_5:
      return source;
label_6:
      return source;
label_8:
      try
      {
label_15:
        if (enumerator.MoveNext())
          goto label_17;
        else
          goto label_16;
label_9:
        int num2;
        ExportRule customRule;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!source.Any<ExportRule>((Func<ExportRule, bool>) (r => (string) ExportRulesService.\u003C\u003Ec__DisplayClass0_1.akU8eA8a6cN6VoloUCa4((object) r) == customRule.PropertyName)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 6 : 4;
                continue;
              }
              goto label_15;
            case 2:
              goto label_5;
            case 3:
              goto label_15;
            case 4:
              customRule = enumerator.Current;
              num2 = 5;
              continue;
            case 5:
              source.ForEach((Action<ExportRule>) (r =>
              {
                int num3 = 2;
                while (true)
                {
                  int num4 = num3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_5;
                      case 2:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!((string) ExportRulesService.\u003C\u003Ec__DisplayClass0_1.akU8eA8a6cN6VoloUCa4((object) r) == (string) ExportRulesService.\u003C\u003Ec__DisplayClass0_1.akU8eA8a6cN6VoloUCa4((object) customRule)))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 1 : 0;
                          continue;
                        }
                        goto label_4;
                      case 3:
                        goto label_3;
                      default:
                        goto label_4;
                    }
                  }
label_4:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ExportRulesService.\u003C\u003Ec__DisplayClass0_1.z2PhZE8aAlLeOLLSfApj((object) r, ExportRulesService.\u003C\u003Ec__DisplayClass0_1.Fr5UGQ8aHmLQRr8puDAt((object) customRule));
                  num3 = 3;
                }
label_5:
                return;
label_3:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 1 : 1;
              continue;
            case 6:
              ExportRuleList exportRuleList = source;
              ExportRule exportRule = new ExportRule();
              ExportRulesService.HZ4sx2E7uqcJY8oCG1Am((object) exportRule, type);
              exportRule.PropertyName = (string) ExportRulesService.FDtUDwE7IqBI8Ty5HckG((object) customRule);
              ExportRulesService.jmRtbgE7SAhYU2oqrl7B((object) exportRule, ExportRulesService.oAa9Z8E7VGS5BeVH5Akg((object) customRule));
              exportRuleList.Add(exportRule);
              num2 = 3;
              continue;
            default:
              goto label_17;
          }
        }
label_16:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 2;
        goto label_9;
label_17:
        num2 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
        {
          num2 = 4;
          goto label_9;
        }
        else
          goto label_9;
      }
      finally
      {
        enumerator.Dispose();
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
          num5 = 0;
        switch (num5)
        {
          default:
        }
      }
    }

    /// <summary>Получение базовых правил сущности</summary>
    /// <param name="entity"></param>
    /// <returns></returns>
    public virtual ExportRuleList Base(IEntity entity)
    {
      int num1 = 8;
      // ISSUE: variable of a compiler-generated type
      ExportRulesService.\u003C\u003Ec__DisplayClass1_0 cDisplayClass10;
      ExportRuleList source;
      List<ClassMetadata>.Enumerator enumerator1;
      while (true)
      {
        int num2 = num1;
        EntityMetadata metadata;
        List<ClassMetadata> baseClasses;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              enumerator1 = baseClasses.GetEnumerator();
              num2 = 4;
              continue;
            case 3:
              goto label_49;
            case 4:
              goto label_18;
            case 5:
              baseClasses = MetadataLoader.GetBaseClasses((ClassMetadata) metadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 9 : 2;
              continue;
            case 6:
              goto label_4;
            case 7:
              source = new ExportRuleList();
              num2 = 14;
              continue;
            case 8:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass10 = new ExportRulesService.\u003C\u003Ec__DisplayClass1_0();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 7 : 0;
              continue;
            case 9:
              ExportRulesService.crAfeBE7igs3iqm2k82a((object) baseClasses);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              if (!cDisplayClass10.legalTypes.Contains(cDisplayClass10.entityType))
              {
                num2 = 12;
                continue;
              }
              goto case 2;
            case 11:
              baseClasses.Add((ClassMetadata) metadata);
              num2 = 13;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass10.legalTypes.Add(cDisplayClass10.entityType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
              continue;
            case 13:
            case 15:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              cDisplayClass10.legalTypes = baseClasses.Select<ClassMetadata, Type>((Func<ClassMetadata, Type>) (m => Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(ExportRulesService.\u003C\u003Ec.VNeR1b8ayjIhycPPhffe((object) m)))).ToList<Type>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 10 : 6;
              continue;
            case 14:
              if (entity != null)
              {
                // ISSUE: reference to a compiler-generated field
                cDisplayClass10.entityType = entity.GetType();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
                continue;
              }
              num2 = 6;
              continue;
            default:
              if (baseClasses.Contains((ClassMetadata) metadata))
              {
                num2 = 15;
                continue;
              }
              goto case 11;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated field
        metadata = InterfaceActivator.LoadMetadata(cDisplayClass10.entityType) as EntityMetadata;
        num1 = 5;
      }
label_4:
      return source;
label_18:
      try
      {
label_20:
        if (enumerator1.MoveNext())
          goto label_42;
        else
          goto label_21;
label_19:
        // ISSUE: variable of a compiler-generated type
        ExportRulesService.\u003C\u003Ec__DisplayClass1_1 cDisplayClass11;
        EntityMetadata entityMetadata;
        List<ExportRule>.Enumerator enumerator2;
        int num3;
        while (true)
        {
          object obj;
          switch (num3)
          {
            case 1:
              goto label_49;
            case 2:
              goto label_24;
            case 3:
              goto label_20;
            case 4:
              // ISSUE: reference to a compiler-generated field
              if (ExportRulesService.z8pDreE7RPgeUCnqTK29((object) (InterfaceActivator.LoadMetadata(cDisplayClass11.baseType, false) as EntityMetadata)) != EntityMetadataType.InterfaceImplementation)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
                continue;
              }
              obj = (object) ModelHelper.GetEntityManagerOrNull(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.ImplementationUid, false));
              break;
            case 5:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass11.baseType = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(entityMetadata.Uid);
              num3 = 4;
              continue;
            case 6:
              goto label_42;
            default:
              // ISSUE: reference to a compiler-generated field
              obj = ExportRulesService.sp0FSmE7qnIBguNdtbtq(cDisplayClass11.baseType);
              break;
          }
          // ISSUE: reference to a compiler-generated method
          enumerator2 = ((IEnumerable<ExportRule>) ExportRulesService.EGFbJaE7KY3VZRah1efr(obj)).Where<ExportRule>(new Func<ExportRule, bool>(cDisplayClass11.\u003CBase\u003Eb__1)).ToList<ExportRule>().GetEnumerator();
          num3 = 2;
        }
label_24:
        try
        {
label_27:
          if (enumerator2.MoveNext())
            goto label_29;
          else
            goto label_28;
label_25:
          // ISSUE: variable of a compiler-generated type
          ExportRulesService.\u003C\u003Ec__DisplayClass1_2 cDisplayClass12;
          int num4;
          while (true)
          {
            switch (num4)
            {
              case 1:
                ExportRuleList exportRuleList = source;
                ExportRule exportRule = new ExportRule();
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated field
                exportRule.ParentType = cDisplayClass12.CS\u0024\u003C\u003E8__locals2.CS\u0024\u003C\u003E8__locals1.entityType;
                // ISSUE: reference to a compiler-generated field
                ExportRulesService.jLEUG2E7XdoHhxeAGOyo((object) exportRule, ExportRulesService.FDtUDwE7IqBI8Ty5HckG((object) cDisplayClass12.baseRule));
                // ISSUE: reference to a compiler-generated field
                ExportRulesService.jmRtbgE7SAhYU2oqrl7B((object) exportRule, ExportRulesService.oAa9Z8E7VGS5BeVH5Akg((object) cDisplayClass12.baseRule));
                exportRuleList.Add(exportRule);
                num4 = 2;
                continue;
              case 2:
                goto label_27;
              case 3:
                // ISSUE: reference to a compiler-generated method
                source.ForEach(new Action<ExportRule>(cDisplayClass12.\u003CBase\u003Eb__2));
                num4 = 6;
                continue;
              case 4:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass12.CS\u0024\u003C\u003E8__locals2 = cDisplayClass11;
                num4 = 7;
                continue;
              case 5:
                goto label_29;
              case 6:
                // ISSUE: reference to a compiler-generated method
                if (!source.Any<ExportRule>(new Func<ExportRule, bool>(cDisplayClass12.\u003CBase\u003Eb__3)))
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
                  continue;
                }
                goto label_27;
              case 7:
                // ISSUE: reference to a compiler-generated field
                cDisplayClass12.baseRule = enumerator2.Current;
                num4 = 3;
                continue;
              default:
                goto label_20;
            }
          }
label_28:
          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
          goto label_25;
label_29:
          // ISSUE: object of a compiler-generated type is created
          cDisplayClass12 = new ExportRulesService.\u003C\u003Ec__DisplayClass1_2();
          num4 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
          {
            num4 = 4;
            goto label_25;
          }
          else
            goto label_25;
        }
        finally
        {
          enumerator2.Dispose();
          int num5 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
            num5 = 0;
          switch (num5)
          {
            default:
          }
        }
label_21:
        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
        goto label_19;
label_42:
        ClassMetadata current = enumerator1.Current;
        // ISSUE: object of a compiler-generated type is created
        cDisplayClass11 = new ExportRulesService.\u003C\u003Ec__DisplayClass1_1();
        // ISSUE: reference to a compiler-generated field
        cDisplayClass11.CS\u0024\u003C\u003E8__locals1 = cDisplayClass10;
        entityMetadata = current as EntityMetadata;
        num3 = 5;
        goto label_19;
      }
      finally
      {
        enumerator1.Dispose();
        int num6 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
          num6 = 0;
        switch (num6)
        {
          default:
        }
      }
label_49:
      return source;
    }

    public ExportRulesService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object YIQAYsE7ZhOQL28F4hHD([In] object obj0, [In] object obj1) => (object) ((ExportRulesService) obj0).Base((IEntity) obj1);

    internal static void HZ4sx2E7uqcJY8oCG1Am([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static object FDtUDwE7IqBI8Ty5HckG([In] object obj0) => (object) ((ExportRule) obj0).PropertyName;

    internal static ExportRuleType oAa9Z8E7VGS5BeVH5Akg([In] object obj0) => ((ExportRule) obj0).ExportRuleType;

    internal static void jmRtbgE7SAhYU2oqrl7B([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static bool qr77R0E7vaiUuHY70Pgj() => ExportRulesService.bTFpH0E7CgRJ59lFjq95 == null;

    internal static ExportRulesService hByjqAE78am1uN81AGNr() => ExportRulesService.bTFpH0E7CgRJ59lFjq95;

    internal static void crAfeBE7igs3iqm2k82a([In] object obj0) => ((List<ClassMetadata>) obj0).Reverse();

    internal static EntityMetadataType z8pDreE7RPgeUCnqTK29([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static object sp0FSmE7qnIBguNdtbtq(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static object EGFbJaE7KY3VZRah1efr([In] object obj0) => (object) ((IEntityManager) obj0).ExportRules();

    internal static void jLEUG2E7XdoHhxeAGOyo([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;
  }
}

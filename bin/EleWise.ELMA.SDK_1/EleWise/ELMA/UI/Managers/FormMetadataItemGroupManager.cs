// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.FormMetadataItemGroupManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Managers
{
  public class FormMetadataItemGroupManager : EntityManager<IFormMetadataItemGroup, long>
  {
    private static FormMetadataItemGroupManager YPgqpHBC5oHTc3pZts5k;

    /// <summary>Получить корневые группы процессов</summary>
    /// <param name="metadataType"></param>
    /// <returns>Корневые группы</returns>
    public IEnumerable<IFormMetadataItemGroup> LoadRootGroups(Guid metadataType) => (IEnumerable<IFormMetadataItemGroup>) this.CreateCriteria().Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979485402), (object) metadataType)).Add((ICriterion) Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917293244))).List<IFormMetadataItemGroup>();

    /// <summary>Удалить группу</summary>
    /// <param name="groupId">Идентификатор группы</param>
    [Transaction]
    public virtual void Delete(long groupId)
    {
      int num = 1;
      IFormMetadataItemGroup metadataItemGroup;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataItemGroup = this.LoadOrNull(groupId);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (metadataItemGroup != null)
            {
              this.Delete(metadataItemGroup);
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return;
label_3:;
    }

    public override void Delete(IFormMetadataItemGroup group)
    {
      int num1 = 3;
      // ISSUE: variable of a compiler-generated type
      FormMetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0 cDisplayClass20;
      IEnumerator<IFormMetadataItemGroup> enumerator1;
      IFormMetadataItemHeaderFilter filter;
      IEnumerator<IFormMetadataItemHeader> enumerator2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_31;
          case 2:
            // ISSUE: reference to a compiler-generated field
            cDisplayClass20.group = group;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 3:
            // ISSUE: object of a compiler-generated type is created
            cDisplayClass20 = new FormMetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 2 : 2;
            continue;
          case 4:
label_7:
            filter = InterfaceActivator.Create<IFormMetadataItemHeaderFilter>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 9 : 9;
            continue;
          case 5:
            FormMetadataItemGroupManager.xRxwIwBvE8VmDyOoJQNg((object) filter, true);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 6 : 6;
            continue;
          case 6:
            enumerator2 = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>().Find((IEntityFilter) filter, (FetchOptions) null).GetEnumerator();
            num1 = 8;
            continue;
          case 7:
label_4:
            // ISSUE: reference to a compiler-generated field
            base.Delete(cDisplayClass20.group);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 1;
            continue;
          case 8:
            try
            {
label_26:
              if (FormMetadataItemGroupManager.o3idqfBvbp7CQhmXIpG8((object) enumerator2))
                goto label_24;
              else
                goto label_27;
label_23:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_26;
                case 2:
                  goto label_4;
              }
label_24:
              IFormMetadataItemHeader current = enumerator2.Current;
              // ISSUE: reference to a compiler-generated field
              FormMetadataItemGroupManager.HZ8qmrBvQCrGeJ6N7KA9((object) current, FormMetadataItemGroupManager.PirILkBvfSkT9CrAXfvG((object) cDisplayClass20.group));
              FormMetadataItemGroupManager.jOSlh9BvCTY514ZD2VuL((object) current);
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
              {
                num2 = 0;
                goto label_23;
              }
              else
                goto label_23;
label_27:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 2 : 2;
              goto label_23;
            }
            finally
            {
              int num3;
              if (enumerator2 == null)
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
              else
                goto label_32;
label_30:
              switch (num3)
              {
                case 2:
                  break;
                default:
              }
label_32:
              FormMetadataItemGroupManager.fVswRtBvhX7VIoCMqPnU((object) enumerator2);
              num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
              {
                num3 = 0;
                goto label_30;
              }
              else
                goto label_30;
            }
          case 9:
            // ISSUE: reference to a compiler-generated field
            FormMetadataItemGroupManager.umsxnSBvGEtuC3pZrJLJ((object) filter, (object) cDisplayClass20.group);
            num1 = 5;
            continue;
          case 10:
            // ISSUE: type reference
            ParameterExpression parameterExpression = System.Linq.Expressions.Expression.Parameter(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), (string) FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(~-122002947 ^ 121989506));
            // ISSUE: method reference
            // ISSUE: type reference
            // ISSUE: field reference
            enumerator1 = this.Find(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, bool>>((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.DZw7LrBvW0NVZWOH1bty(FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression, (object) (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_Parent))), FormMetadataItemGroupManager.X8lF5aBvB4LwMpgRM9Eg((object) System.Linq.Expressions.Expression.Constant((object) cDisplayClass20, FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (FormMetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0))), FormMetadataItemGroupManager.qIJNMjBvFSOrsGSEVBC6(__fieldref (FormMetadataItemGroupManager.\u003C\u003Ec__DisplayClass2_0.group)))), parameterExpression)).GetEnumerator();
            num1 = 11;
            continue;
          case 11:
            try
            {
label_12:
              if (FormMetadataItemGroupManager.o3idqfBvbp7CQhmXIpG8((object) enumerator1))
                goto label_14;
              else
                goto label_13;
label_11:
              int num4;
              switch (num4)
              {
                case 1:
                  goto label_12;
                case 2:
                  goto label_7;
                default:
                  goto label_14;
              }
label_13:
              num4 = 2;
              goto label_11;
label_14:
              IFormMetadataItemGroup current = enumerator1.Current;
              // ISSUE: reference to a compiler-generated field
              FormMetadataItemGroupManager.caCdkrBvoQMCDVyMCATH((object) current, (object) cDisplayClass20.group.Parent);
              current.Save();
              num4 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
              {
                num4 = 0;
                goto label_11;
              }
              else
                goto label_11;
            }
            finally
            {
              int num5;
              if (enumerator1 == null)
                num5 = 2;
              else
                goto label_19;
label_18:
              switch (num5)
              {
                case 1:
                  break;
                default:
              }
label_19:
              FormMetadataItemGroupManager.fVswRtBvhX7VIoCMqPnU((object) enumerator1);
              num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
              {
                num5 = 0;
                goto label_18;
              }
              else
                goto label_18;
            }
          default:
            // ISSUE: reference to a compiler-generated field
            FormMetadataItemGroupManager.TMq4jpBCLCqdbIGH0fYs((object) cDisplayClass20.group, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1765814944));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 10 : 7;
            continue;
        }
      }
label_31:;
    }

    public override ExportRuleList ExportRules()
    {
      int num = 4;
      ExportRuleList exportRuleList1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExportRuleList exportRuleList2 = exportRuleList1;
            ExportRule exportRule1 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule1, type);
            ExportRule exportRule2 = exportRule1;
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = System.Linq.Expressions.Expression.Parameter(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), (string) FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(654297945 ^ 654261465));
            // ISSUE: method reference
            string str1 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemGroup.get_Headers))), parameterExpression1));
            FormMetadataItemGroupManager.RFypMlBvuHdnkJuBBbfy((object) exportRule2, (object) str1);
            FormMetadataItemGroupManager.OALLmLBvIkY2g0CiEnBN((object) exportRule1, ExportRuleType.Ignore);
            ExportRule exportRule3 = exportRule1;
            exportRuleList2.Add(exportRule3);
            num = 7;
            continue;
          case 2:
            ExportRuleList exportRuleList3 = exportRuleList1;
            ExportRule exportRule4 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule4, type);
            ExportRule exportRule5 = exportRule4;
            // ISSUE: type reference
            ParameterExpression parameterExpression2 = (ParameterExpression) FormMetadataItemGroupManager.zdJXeQBvZEB9KGUtqgAH(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(-281842504 ^ -281830600));
            // ISSUE: method reference
            // ISSUE: type reference
            string str2 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression2, (object) (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_Uid))), FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (object))), parameterExpression2));
            exportRule5.PropertyName = str2;
            exportRule4.ExportRuleType = ExportRuleType.Export;
            ExportRule exportRule6 = exportRule4;
            exportRuleList3.Add(exportRule6);
            num = 6;
            continue;
          case 3:
            exportRuleList1 = new ExportRuleList();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 4:
            type = FormMetadataItemGroupManager.O73TOsBvvB6oKZgv9TPj((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 3 : 3;
            continue;
          case 5:
            ExportRuleList exportRuleList4 = exportRuleList1;
            ExportRule exportRule7 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule7, type);
            ExportRule exportRule8 = exportRule7;
            // ISSUE: type reference
            ParameterExpression parameterExpression3 = (ParameterExpression) FormMetadataItemGroupManager.zdJXeQBvZEB9KGUtqgAH(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(--1867379187 ^ 1867318899));
            // ISSUE: method reference
            string str3 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression3, (object) (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_Parent))), parameterExpression3));
            exportRule8.PropertyName = str3;
            FormMetadataItemGroupManager.OALLmLBvIkY2g0CiEnBN((object) exportRule7, ExportRuleType.Export);
            ExportRule exportRule9 = exportRule7;
            exportRuleList4.Add(exportRule9);
            num = 2;
            continue;
          case 6:
            goto label_5;
          case 7:
            ExportRuleList exportRuleList5 = exportRuleList1;
            ExportRule exportRule10 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule10, type);
            ExportRule exportRule11 = exportRule10;
            // ISSUE: type reference
            ParameterExpression parameterExpression4 = (ParameterExpression) FormMetadataItemGroupManager.zdJXeQBvZEB9KGUtqgAH(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669358187));
            // ISSUE: method reference
            // ISSUE: type reference
            string str4 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression4, (object) (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_MetadataType))), FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (object))), parameterExpression4));
            FormMetadataItemGroupManager.RFypMlBvuHdnkJuBBbfy((object) exportRule11, (object) str4);
            FormMetadataItemGroupManager.OALLmLBvIkY2g0CiEnBN((object) exportRule10, ExportRuleType.Export);
            ExportRule exportRule12 = exportRule10;
            exportRuleList5.Add(exportRule12);
            num = 8;
            continue;
          case 8:
            ExportRuleList exportRuleList6 = exportRuleList1;
            ExportRule exportRule13 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule13, type);
            ExportRule exportRule14 = exportRule13;
            // ISSUE: type reference
            ParameterExpression parameterExpression5 = (ParameterExpression) FormMetadataItemGroupManager.zdJXeQBvZEB9KGUtqgAH(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(-606654180 ^ -606615908));
            // ISSUE: method reference
            string str5 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) FormMetadataItemGroupManager.geDJiKBCzy7rPJWgQDXA((object) parameterExpression5, (object) (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_Name))), parameterExpression5));
            FormMetadataItemGroupManager.RFypMlBvuHdnkJuBBbfy((object) exportRule14, (object) str5);
            exportRule13.ExportRuleType = ExportRuleType.Export;
            ExportRule exportRule15 = exportRule13;
            exportRuleList6.Add(exportRule15);
            num = 5;
            continue;
          default:
            ExportRuleList exportRuleList7 = exportRuleList1;
            ExportRule exportRule16 = new ExportRule();
            FormMetadataItemGroupManager.VPn4njBv8KSAOtkJU0AX((object) exportRule16, type);
            ExportRule exportRule17 = exportRule16;
            // ISSUE: type reference
            ParameterExpression parameterExpression6 = (ParameterExpression) FormMetadataItemGroupManager.zdJXeQBvZEB9KGUtqgAH(FormMetadataItemGroupManager.gvd7BgBCU7Hef6sGY2we(__typeref (IFormMetadataItemGroup)), FormMetadataItemGroupManager.DCVVvrBCs6AnqESSw2lv(-688192331 - 435440695 ^ -1123659778));
            // ISSUE: method reference
            string str6 = LinqUtils.NameOf<IFormMetadataItemGroup>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemGroup, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression6, (MethodInfo) FormMetadataItemGroupManager.umOT8JBCcWImwXBTsrWn(__methodref (IFormMetadataItemGroup.get_Groups))), parameterExpression6));
            FormMetadataItemGroupManager.RFypMlBvuHdnkJuBBbfy((object) exportRule17, (object) str6);
            FormMetadataItemGroupManager.OALLmLBvIkY2g0CiEnBN((object) exportRule16, ExportRuleType.Ignore);
            ExportRule exportRule18 = exportRule16;
            exportRuleList7.Add(exportRule18);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 1 : 0;
            continue;
        }
      }
label_5:
      return exportRuleList1;
    }

    /// <summary>Загрузить список групп</summary>
    /// <param name="metadataType">Тип метаданных форм (страница или портлет)</param>
    /// <returns>Корневая группа форм указанного типа</returns>
    internal IEnumerable<FormMetadataItemGroupDTO> LoadGroupDTOList(
      Guid metadataType,
      long? parentId)
    {
      ICriteria criteria = this.CreateCriteria().Add((ICriterion) Restrictions.Eq(LinqUtils.NameOf<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, object>>) (metadataItemGroup => (object) metadataItemGroup.MetadataType)), (object) metadataType)).CreateAlias(LinqUtils.NameOf<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, object>>) (metadataItemGroup => metadataItemGroup.Parent)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786859058), JoinType.LeftOuterJoin);
      if (parentId.HasValue)
        criteria = criteria.Add((ICriterion) Restrictions.Eq(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921240997), (object) parentId.Value));
      return (IEnumerable<FormMetadataItemGroupDTO>) criteria.SetProjection(Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, object>>) (metadataItemGroup => (object) metadataItemGroup.Id))), LinqUtils.NameOf<FormMetadataItemGroupDTO>((Expression<Func<FormMetadataItemGroupDTO, object>>) (metadataItemGroupDto => (object) metadataItemGroupDto.Id))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, object>>) (metadataItemGroup => metadataItemGroup.Name))), LinqUtils.NameOf<FormMetadataItemGroupDTO>((Expression<Func<FormMetadataItemGroupDTO, object>>) (metadataItemGroupDto => metadataItemGroupDto.Name))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272572141)), LinqUtils.NameOf<FormMetadataItemGroupDTO>((Expression<Func<FormMetadataItemGroupDTO, object>>) (metadataItemGroupDto => (object) metadataItemGroupDto.ParentId))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemGroup>((Expression<Func<IFormMetadataItemGroup, object>>) (metadataItemGroup => (object) metadataItemGroup.MetadataType))), LinqUtils.NameOf<FormMetadataItemGroupDTO>((Expression<Func<FormMetadataItemGroupDTO, object>>) (metadataItemGroupDto => (object) metadataItemGroupDto.MetadataType)))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (FormMetadataItemGroupDTO))).List<FormMetadataItemGroupDTO>();
    }

    public FormMetadataItemGroupManager()
    {
      FormMetadataItemGroupManager.j74hZRBvVnCGnTe1eAi4();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool AeatEUBCjHLiGW08FC0R() => FormMetadataItemGroupManager.YPgqpHBC5oHTc3pZts5k == null;

    internal static FormMetadataItemGroupManager dhBb70BCY7pxUwAmOee2() => FormMetadataItemGroupManager.YPgqpHBC5oHTc3pZts5k;

    internal static void TMq4jpBCLCqdbIGH0fYs([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Type gvd7BgBCU7Hef6sGY2we([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object DCVVvrBCs6AnqESSw2lv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object umOT8JBCcWImwXBTsrWn([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object geDJiKBCzy7rPJWgQDXA([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object qIJNMjBvFSOrsGSEVBC6([In] RuntimeFieldHandle obj0) => (object) FieldInfo.GetFieldFromHandle(obj0);

    internal static object X8lF5aBvB4LwMpgRM9Eg([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Field((System.Linq.Expressions.Expression) obj0, (FieldInfo) obj1);

    internal static object DZw7LrBvW0NVZWOH1bty([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Equal((System.Linq.Expressions.Expression) obj0, (System.Linq.Expressions.Expression) obj1);

    internal static void caCdkrBvoQMCDVyMCATH([In] object obj0, [In] object obj1) => ((IFormMetadataItemGroup) obj0).Parent = (IFormMetadataItemGroup) obj1;

    internal static bool o3idqfBvbp7CQhmXIpG8([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void fVswRtBvhX7VIoCMqPnU([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void umsxnSBvGEtuC3pZrJLJ([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeaderFilter) obj0).Group = (IFormMetadataItemGroup) obj1;

    internal static void xRxwIwBvE8VmDyOoJQNg([In] object obj0, bool value) => ((IEntityFilter) obj0).DisableSoftDeletable = value;

    internal static object PirILkBvfSkT9CrAXfvG([In] object obj0) => (object) ((IFormMetadataItemGroup) obj0).Parent;

    internal static void HZ8qmrBvQCrGeJ6N7KA9([In] object obj0, [In] object obj1) => ((IFormMetadataItemHeader) obj0).Group = (IFormMetadataItemGroup) obj1;

    internal static void jOSlh9BvCTY514ZD2VuL([In] object obj0) => ((IEntity) obj0).Save();

    internal static Type O73TOsBvvB6oKZgv9TPj([In] object obj0) => ((EntityManager<IFormMetadataItemGroup, long>) obj0).ImplementationType;

    internal static void VPn4njBv8KSAOtkJU0AX([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static object zdJXeQBvZEB9KGUtqgAH([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static void RFypMlBvuHdnkJuBBbfy([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void OALLmLBvIkY2g0CiEnBN([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static void j74hZRBvVnCGnTe1eAi4() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

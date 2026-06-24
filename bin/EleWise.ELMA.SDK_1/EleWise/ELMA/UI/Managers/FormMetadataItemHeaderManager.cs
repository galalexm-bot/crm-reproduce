// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Managers.FormMetadataItemHeaderManager
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
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
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
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Managers
{
  public class FormMetadataItemHeaderManager : EntityManager<IFormMetadataItemHeader, long>
  {
    private static FormMetadataItemHeaderManager DRf8Z6BvSCEA6JyRedR4;

    /// <summary>Получить следующий номер публикуемой версии формы</summary>
    /// <param name="headerId">Идентификатор заголовка формы</param>
    /// <returns>Номер версии</returns>
    public virtual long GetPublishingVersionNumber(long headerId)
    {
      int num1 = 4;
      object obj;
      while (true)
      {
        int num2 = num1;
        ITransformationProvider service;
        string str;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (obj is DBNull)
              {
                num2 = 5;
                continue;
              }
              goto label_10;
            case 2:
            case 5:
              goto label_9;
            case 3:
              service = Locator.GetService<ITransformationProvider>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 4:
              goto label_7;
            case 6:
              obj = FormMetadataItemHeaderManager.vSoK2PBvkvCOx49odq2J(FormMetadataItemHeaderManager.L6nhZjBvTGU5xOfpPXdA((object) this.Session, (object) str));
              num2 = 8;
              continue;
            case 7:
              goto label_5;
            case 8:
              if (obj == null)
              {
                num2 = 2;
                continue;
              }
              goto case 1;
            default:
              str = (string) FormMetadataItemHeaderManager.a5glHBBvX2caV1PMDtnk(FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-1445902765 ^ -1980277732 ^ 539422207), service != null ? FormMetadataItemHeaderManager.AJ9pE6BvKfErHBZnsNfd((object) service.Dialect, FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-1998538950 ^ -1998585464)) : FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1994213607 >> 4 ^ 124609084), (object) headerId);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 6;
              continue;
          }
        }
label_7:
        if (headerId > 0L)
          num1 = 3;
        else
          break;
      }
label_5:
      return 1;
label_9:
      return 1;
label_10:
      return Convert.ToInt64(obj) + 1L;
    }

    /// <summary>Получить корневые заголовки</summary>
    /// <returns>Корневые заголовки</returns>
    public IEnumerable<IFormMetadataItemHeader> LoadRootHeaders() => (IEnumerable<IFormMetadataItemHeader>) this.CreateCriteria().Add((ICriterion) Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874024087))).List<IFormMetadataItemHeader>();

    /// <summary>Получить корневые заголовки</summary>
    /// <param name="metadataType">Тип метаданных</param>
    /// <returns>Корневые заголовки</returns>
    public IEnumerable<IFormMetadataItemHeader> LoadRootHeaders(Guid metadataType) => (IEnumerable<IFormMetadataItemHeader>) this.CreateCriteria().Add((ICriterion) Restrictions.IsNull(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411249297))).Add((ICriterion) Restrictions.Eq(FormMetadataItemHeaderManager.PropertyNames.MetadataType, (object) metadataType)).List<IFormMetadataItemHeader>();

    /// <summary>Удалить форму</summary>
    /// <param name="headerId"></param>
    [Transaction]
    public virtual void Delete(long headerId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FormMetadataItemHeaderManager.X8G9geBvnE27rA28TMnn((object) this.Load(headerId));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Проверить идентификатор страницы</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="name">Идентификатор страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateName(
      long headerId,
      Guid metadataType,
      string name,
      out string errorMessage)
    {
      return this.ValidateName((ICriterion) FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.Id, (object) headerId), metadataType, name, out errorMessage);
    }

    /// <summary>Проверить идентификатор страницы</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="name">Идентификатор страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateName(
      Guid headerUid,
      Guid metadataType,
      string name,
      out string errorMessage)
    {
      return this.ValidateName((ICriterion) FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.Uid, (object) headerUid), metadataType, name, out errorMessage);
    }

    /// <summary>Проверить отображаемое имя страницы</summary>
    /// <param name="headerId">Id заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="displayName">Отображаемое имя страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateDisplayName(
      long headerId,
      Guid metadataType,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.Id, (object) headerId), metadataType, displayName, out errorMessage);
    }

    /// <summary>Проверить отображаемое имя страницы</summary>
    /// <param name="headerUid">Уникальный идентификатор заголовка</param>
    /// <param name="metadataType">Тип метаданных</param>
    /// <param name="displayName">Отображаемое имя страницы</param>
    /// <param name="errorMessage">Сообщение об ошибке</param>
    /// <returns></returns>
    public virtual bool ValidateDisplayName(
      Guid headerUid,
      Guid metadataType,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.Uid, (object) headerUid), metadataType, displayName, out errorMessage);
    }

    public override ExportRuleList ExportRules()
    {
      int num1 = 4;
      ExportRuleList exportRuleList1;
      while (true)
      {
        int num2 = num1;
        Type type;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              ExportRuleList exportRuleList2 = exportRuleList1;
              ExportRule exportRule1 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule1, type);
              ExportRule exportRule2 = exportRule1;
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (IFormMetadataItemHeader)), FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-2107978722 ^ -2108006230));
              // ISSUE: method reference
              string str1 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.Sacda3BvaTg0k3bRmdIB((object) parameterExpression1, (object) (MethodInfo) FormMetadataItemHeaderManager.VyLk5QBvpOVPQcW1renO(__methodref (IFormMetadataItemHeader.get_MetadataType))), typeof (object)), parameterExpression1));
              exportRule2.PropertyName = str1;
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule1, ExportRuleType.Export);
              ExportRule exportRule3 = exportRule1;
              exportRuleList2.Add(exportRule3);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_6;
            case 4:
              type = FormMetadataItemHeaderManager.dQxQ89Bv2dJs3oXD1aFJ((object) this);
              num2 = 3;
              continue;
            case 5:
              ExportRuleList exportRuleList3 = exportRuleList1;
              ExportRule exportRule4 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule4, type);
              ExportRule exportRule5 = exportRule4;
              // ISSUE: type reference
              ParameterExpression parameterExpression2 = System.Linq.Expressions.Expression.Parameter(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (IFormMetadataItemHeader)), (string) FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1149433385 + 173655049 ^ 1323046534));
              // ISSUE: method reference
              string str2 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.Sacda3BvaTg0k3bRmdIB((object) parameterExpression2, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Draft))), parameterExpression2));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule5, (object) str2);
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule4, ExportRuleType.Export);
              ExportRule exportRule6 = exportRule4;
              exportRuleList3.Add(exportRule6);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 2;
              continue;
            case 6:
              ExportRuleList exportRuleList4 = exportRuleList1;
              ExportRule exportRule7 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule7, type);
              ExportRule exportRule8 = exportRule7;
              // ISSUE: type reference
              ParameterExpression parameterExpression3 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (IFormMetadataItemHeader)), FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1917256330 ^ 1917300286));
              // ISSUE: method reference
              string str3 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.mDbInqBvDsUYfPdiqt9r((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression3, (MethodInfo) FormMetadataItemHeaderManager.VyLk5QBvpOVPQcW1renO(__methodref (IFormMetadataItemHeader.get_Uid))), typeof (object)), parameterExpression3));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule8, (object) str3);
              exportRule7.ExportRuleType = ExportRuleType.Export;
              ExportRule exportRule9 = exportRule7;
              exportRuleList4.Add(exportRule9);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
              continue;
            case 7:
              ExportRuleList exportRuleList5 = exportRuleList1;
              ExportRule exportRule10 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule10, type);
              ParameterExpression parameterExpression4;
              // ISSUE: method reference
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule10, (object) LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.Sacda3BvaTg0k3bRmdIB((object) parameterExpression4, (object) (MethodInfo) FormMetadataItemHeaderManager.VyLk5QBvpOVPQcW1renO(__methodref (IFormMetadataItemHeader.get_DisplayName))), parameterExpression4)));
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule10, ExportRuleType.Export);
              ExportRule exportRule11 = exportRule10;
              exportRuleList5.Add(exportRule11);
              num2 = 5;
              continue;
            case 8:
              ExportRuleList exportRuleList6 = exportRuleList1;
              ExportRule exportRule12 = new ExportRule();
              exportRule12.ParentType = type;
              ExportRule exportRule13 = exportRule12;
              ParameterExpression parameterExpression5 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(typeof (IFormMetadataItemHeader), FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-488881205 ^ -488837249));
              // ISSUE: method reference
              string str4 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.Sacda3BvaTg0k3bRmdIB((object) parameterExpression5, (object) (MethodInfo) FormMetadataItemHeaderManager.VyLk5QBvpOVPQcW1renO(__methodref (IFormMetadataItemHeader.get_Name))), parameterExpression5));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule13, (object) str4);
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule12, ExportRuleType.Export);
              ExportRule exportRule14 = exportRule12;
              exportRuleList6.Add(exportRule14);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 10 : 6;
              continue;
            case 9:
              ExportRuleList exportRuleList7 = exportRuleList1;
              ExportRule exportRule15 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule15, type);
              ExportRule exportRule16 = exportRule15;
              // ISSUE: type reference
              ParameterExpression parameterExpression6 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (IFormMetadataItemHeader)), FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(901793403 ^ 901835471));
              // ISSUE: method reference
              string str5 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression6, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Description))), parameterExpression6));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule16, (object) str5);
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule15, ExportRuleType.Export);
              ExportRule exportRule17 = exportRule15;
              exportRuleList7.Add(exportRule17);
              num2 = 7;
              continue;
            case 10:
              ExportRuleList exportRuleList8 = exportRuleList1;
              ExportRule exportRule18 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule18, type);
              ExportRule exportRule19 = exportRule18;
              ParameterExpression parameterExpression7 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(typeof (IFormMetadataItemHeader), FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-630932142 - 1120244082 ^ -1751152812));
              // ISSUE: method reference
              // ISSUE: type reference
              string str6 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.mDbInqBvDsUYfPdiqt9r(FormMetadataItemHeaderManager.Sacda3BvaTg0k3bRmdIB((object) parameterExpression7, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_IsDeleted))), FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (object))), parameterExpression7));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule19, (object) str6);
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule18, ExportRuleType.Export);
              ExportRule exportRule20 = exportRule18;
              exportRuleList8.Add(exportRule20);
              num2 = 6;
              continue;
            default:
              ExportRuleList exportRuleList9 = exportRuleList1;
              ExportRule exportRule21 = new ExportRule();
              FormMetadataItemHeaderManager.ejhhCPBvewAOIEbXZUuS((object) exportRule21, type);
              ExportRule exportRule22 = exportRule21;
              // ISSUE: type reference
              ParameterExpression parameterExpression8 = (ParameterExpression) FormMetadataItemHeaderManager.cbxsgiBv1lTG42EvgVM2(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (IFormMetadataItemHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538544990));
              // ISSUE: method reference
              string str7 = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression8, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Group))), parameterExpression8));
              FormMetadataItemHeaderManager.D4ae3SBvN8Ltpi3LLNYN((object) exportRule22, (object) str7);
              FormMetadataItemHeaderManager.d8U9ZVBv3K3WJhBw6HAI((object) exportRule21, ExportRuleType.Export);
              ExportRule exportRule23 = exportRule21;
              exportRuleList9.Add(exportRule23);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 8 : 1;
              continue;
          }
        }
label_6:
        exportRuleList1 = new ExportRuleList();
        num1 = 9;
      }
label_4:
      return exportRuleList1;
    }

    internal FormMetadataItemHeaderManager.HeaderDescriptorInfo GetPublishedHeaderDescriptorInfo(
      Guid uid)
    {
      return ((ICriteria) FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw((object) this.CreatePublishedHeaderDescriptorInfos(), FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.Uid, (object) uid))).List<FormMetadataItemHeaderManager.HeaderDescriptorInfo>().FirstOrDefault<FormMetadataItemHeaderManager.HeaderDescriptorInfo>();
    }

    internal IEnumerable<FormMetadataItemHeaderManager.HeaderDescriptorInfo> GetPublishedHeaderDescriptorInfos(
      Guid metadataType)
    {
      return (IEnumerable<FormMetadataItemHeaderManager.HeaderDescriptorInfo>) this.CreatePublishedHeaderDescriptorInfos().Add((ICriterion) Restrictions.Eq(FormMetadataItemHeaderManager.PropertyNames.MetadataType, (object) metadataType)).Add((ICriterion) Restrictions.Or((ICriterion) Restrictions.IsNotNull(FormMetadataItemHeaderManager.PropertyNames.Published), (ICriterion) Restrictions.IsNotNull(FormMetadataItemHeaderManager.PropertyNames.Emulation))).List<FormMetadataItemHeaderManager.HeaderDescriptorInfo>();
    }

    internal ICriteria CreatePublishedHeaderDescriptorInfos() => (ICriteria) FormMetadataItemHeaderManager.CHTVdBBv7cFW74RA5cno(FormMetadataItemHeaderManager.YWhRqaBvAOiMARrgGWlC(FormMetadataItemHeaderManager.hxyaMaBv4tS1Sd8EUpeV(FormMetadataItemHeaderManager.hxyaMaBv4tS1Sd8EUpeV(FormMetadataItemHeaderManager.bOt9XTBvwTJCbmO1S5PX((object) this, (object) null), (object) FormMetadataItemHeaderManager.PropertyNames.Published, FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-787452571 ^ -787442349), JoinType.LeftOuterJoin), (object) FormMetadataItemHeaderManager.PropertyNames.Emulation, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629822110), JoinType.LeftOuterJoin), (object) new IProjection[5]
    {
      (IProjection) FormMetadataItemHeaderManager.LkV1muBvHG7AsTHrZ5ei(FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ((object) FormMetadataItemHeaderManager.PropertyNames.Id), (object) FormMetadataItemHeaderManager.PropertyNames.Id),
      Projections.Alias((IProjection) FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ((object) FormMetadataItemHeaderManager.PropertyNames.Uid), FormMetadataItemHeaderManager.PropertyNames.Uid),
      (IProjection) FormMetadataItemHeaderManager.LkV1muBvHG7AsTHrZ5ei(FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ((object) FormMetadataItemHeaderManager.PropertyNames.Name), (object) FormMetadataItemHeaderManager.PropertyNames.Name),
      (IProjection) FormMetadataItemHeaderManager.LkV1muBvHG7AsTHrZ5ei(FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ(FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1669371371 ^ 1669361057)), (object) FormMetadataItemHeaderManager.PropertyNames.PublishedId),
      (IProjection) FormMetadataItemHeaderManager.LkV1muBvHG7AsTHrZ5ei((object) Projections.Property((string) FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1514961705 ^ 1514963827)), (object) FormMetadataItemHeaderManager.PropertyNames.EmulationId)
    }), (object) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(FormMetadataItemHeaderManager.mQdZO7BvPewtgbCxfOu6(__typeref (FormMetadataItemHeaderManager.HeaderDescriptorInfo))));

    /// <summary>Загрузить список заголовков</summary>
    /// <param name="metadataType">Тип метаданных форм (страница или портлет)</param>
    /// <returns>Корневая группа форм указанного типа</returns>
    internal IEnumerable<FormMetadataItemHeaderDTO> LoadHeaderDTOList(Guid metadataType) => (IEnumerable<FormMetadataItemHeaderDTO>) this.CreateCriteria().Add((ICriterion) Restrictions.Eq(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.MetadataType)), (object) metadataType)).CreateAlias(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => metadataItemHeader.Group)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398715172), JoinType.LeftOuterJoin).CreateAlias(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => metadataItemHeader.Draft)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874030655), JoinType.LeftOuterJoin).CreateAlias(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => metadataItemHeader.Published)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195571421), JoinType.LeftOuterJoin).SetProjection(Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.Id))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.Id))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.Uid))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.Uid))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => metadataItemHeader.Name))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => metadataItemHeaderDto.Name))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => metadataItemHeader.DisplayName))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => metadataItemHeaderDto.DisplayName))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411243557)), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.GroupId))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.CreationDate))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.CreationDate))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.CreationAuthorId))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.CreationAuthorId))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.MetadataType))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.MetadataType))), Projections.Alias((IProjection) Projections.Property(LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.IsDirtyItem))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.IsDirtyItem))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146528351) + LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.Id))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.DraftId))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099728427) + LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.CreationDate))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.Draft_CreationDate))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629822030) + LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.Id))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.PublishedId))), Projections.Alias((IProjection) Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867762980) + LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (metadataItemHeader => (object) metadataItemHeader.CreationDate))), LinqUtils.NameOf<FormMetadataItemHeaderDTO>((Expression<Func<FormMetadataItemHeaderDTO, object>>) (metadataItemHeaderDto => (object) metadataItemHeaderDto.Published_CreationDate)))).SetResultTransformer((IResultTransformer) new EleWise.ELMA.Runtime.NH.AliasToBeanResultTransformer(typeof (FormMetadataItemHeaderDTO))).List<FormMetadataItemHeaderDTO>();

    /// <summary>Критерия валидации наименования</summary>
    /// <param name="name">Наименование</param>
    /// <returns>Критерия</returns>
    internal virtual ICriteria ValidateNameCriteria(string name) => (ICriteria) FormMetadataItemHeaderManager.YWhRqaBvAOiMARrgGWlC(FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw(FormMetadataItemHeaderManager.bOt9XTBvwTJCbmO1S5PX((object) this, (object) null), (object) ElmaRestrictions.InsensitiveLike((IProjection) FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ((object) FormMetadataItemHeaderManager.PropertyNames.Name), (object) name)), (object) new IProjection[1]
    {
      (IProjection) FormMetadataItemHeaderManager.YraW1uBvxs2Rltvr7Xxb((object) FormMetadataItemHeaderManager.PropertyNames.Id)
    });

    protected virtual bool ValidateName(
      ICriterion compareCriterion,
      Guid metadataType,
      string name,
      out string errorMessage)
    {
      int num = 8;
      while (true)
      {
        switch (num)
        {
          case 1:
            errorMessage = EleWise.ELMA.SR.T((string) FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(92412609 - 1050237057 ^ -957859052), (object) name);
            num = 4;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_10;
          case 4:
            goto label_19;
          case 5:
            errorMessage = (string) FormMetadataItemHeaderManager.Ck6nMBBvyAdL1jLJZhfp((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239581462));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 2 : 2;
            continue;
          case 6:
            if (!FormMetadataItemHeaderManager.hkNXNmBvmFEGlaedJrJP((object) name))
            {
              if (FormMetadataItemHeaderManager.PDPsVDBvMuf4svq19DBR((object) name))
              {
                if (Convert.ToInt64(FormMetadataItemHeaderManager.UiWeESBvdLfT2gd6DI0o(FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw(FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw(FormMetadataItemHeaderManager.kSsVWABvJr8D2kqcO5ki((object) this, (object) name), FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.MetadataType, (object) metadataType)), FormMetadataItemHeaderManager.kc6NiJBv9shAtXrpuSG4((object) compareCriterion)))) > 0L)
                {
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 9 : 10;
                  continue;
                }
                if (FormMetadataItemHeaderManager.YBrxuCBvrFAnxQjSuwvA(FormMetadataItemHeaderManager.UiWeESBvdLfT2gd6DI0o(FormMetadataItemHeaderManager.VNFgOABvlMPP7tVsB45U((object) Locator.GetServiceNotNull<ComponentMetadataItemHeaderManager>(), (object) name))) <= 0L)
                {
                  num = 9;
                  continue;
                }
                goto case 1;
              }
              else
              {
                num = 5;
                continue;
              }
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
          case 7:
            errorMessage = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 6;
            continue;
          case 8:
            FormMetadataItemHeaderManager.EoBpmbBv0v9Psw304n79((object) compareCriterion, FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(1917998801 >> 2 ^ 479487106));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 7 : 7;
            continue;
          case 9:
            goto label_20;
          case 10:
            errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822944172), (object) name);
            num = 11;
            continue;
          case 11:
            goto label_7;
          default:
            errorMessage = (string) FormMetadataItemHeaderManager.Ck6nMBBvyAdL1jLJZhfp(FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(516838154 ^ 516858448));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 3;
            continue;
        }
      }
label_4:
      return false;
label_7:
      return false;
label_10:
      return false;
label_19:
      return false;
label_20:
      return true;
    }

    protected virtual bool ValidateDisplayName(
      ICriterion compareCriterion,
      Guid metadataType,
      string displayName,
      out string errorMessage)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string displayName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_4;
            case 2:
              errorMessage = (string) null;
              num2 = 9;
              continue;
            case 3:
              goto label_9;
            case 4:
              FormMetadataItemHeaderManager.EoBpmbBv0v9Psw304n79((object) compareCriterion, FormMetadataItemHeaderManager.yEGiMZBvqfxbdq0jGVBv(-16752921 ^ -16732207));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 2;
              continue;
            case 5:
              displayName1 = displayName;
              num2 = 4;
              continue;
            case 6:
              num2 = 5;
              continue;
            case 7:
              goto label_10;
            case 8:
              errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824327367));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 1;
              continue;
            case 9:
              if (!FormMetadataItemHeaderManager.hkNXNmBvmFEGlaedJrJP((object) displayName1))
              {
                if (!((ICriteria) FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw(FormMetadataItemHeaderManager.vjteVRBvtre5pvnOpwYw(FormMetadataItemHeaderManager.bOt9XTBvwTJCbmO1S5PX((object) this, (object) null), FormMetadataItemHeaderManager.qYyJwBBvOSEg1pI6KHkF((object) FormMetadataItemHeaderManager.PropertyNames.MetadataType, (object) metadataType)), (object) Restrictions.Not(compareCriterion))).SetProjection((IProjection) FormMetadataItemHeaderManager.uPdOo0Bv6s23k4elRTLQ((object) FormMetadataItemHeaderManager.PropertyNames.DisplayName)).List<string>().Any<string>((Func<string, bool>) (n =>
                {
                  int num3 = 2;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        if (n == null)
                        {
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 1;
                          continue;
                        }
                        goto label_2;
                      default:
                        goto label_2;
                    }
                  }
label_2:
                  // ISSUE: reference to a compiler-generated method
                  return FormMetadataItemHeaderManager.\u003C\u003Ec__DisplayClass17_0.gJE71nQGuMeIOPZi5gBY((object) n, (object) displayName1, StringComparison.CurrentCultureIgnoreCase);
label_3:
                  return false;
                })))
                {
                  num2 = 7;
                  continue;
                }
                goto label_15;
              }
              else
              {
                num2 = 8;
                continue;
              }
            default:
              goto label_15;
          }
        }
label_15:
        errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97918316));
        num1 = 3;
      }
label_4:
      return false;
label_9:
      return false;
label_10:
      return true;
    }

    public FormMetadataItemHeaderManager()
    {
      FormMetadataItemHeaderManager.MLQhiJBvgAMKfdwXtkd2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object yEGiMZBvqfxbdq0jGVBv(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object AJ9pE6BvKfErHBZnsNfd([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object a5glHBBvX2caV1PMDtnk([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static object L6nhZjBvTGU5xOfpPXdA([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object vSoK2PBvkvCOx49odq2J([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static bool b2iZpZBviQfq1UNBBIqO() => FormMetadataItemHeaderManager.DRf8Z6BvSCEA6JyRedR4 == null;

    internal static FormMetadataItemHeaderManager JL93TaBvR67pZNT8j1AL() => FormMetadataItemHeaderManager.DRf8Z6BvSCEA6JyRedR4;

    internal static void X8G9geBvnE27rA28TMnn([In] object obj0) => ((IEntity) obj0).Delete();

    internal static object qYyJwBBvOSEg1pI6KHkF([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static Type dQxQ89Bv2dJs3oXD1aFJ([In] object obj0) => ((EntityManager<IFormMetadataItemHeader, long>) obj0).ImplementationType;

    internal static void ejhhCPBvewAOIEbXZUuS([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static Type mQdZO7BvPewtgbCxfOu6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object cbxsgiBv1lTG42EvgVM2([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

    internal static void D4ae3SBvN8Ltpi3LLNYN([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static void d8U9ZVBv3K3WJhBw6HAI([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static object VyLk5QBvpOVPQcW1renO([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object Sacda3BvaTg0k3bRmdIB([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

    internal static object mDbInqBvDsUYfPdiqt9r([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);

    internal static object vjteVRBvtre5pvnOpwYw([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object bOt9XTBvwTJCbmO1S5PX([In] object obj0, [In] object obj1) => (object) ((EntityManager<IFormMetadataItemHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object hxyaMaBv4tS1Sd8EUpeV(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] JoinType obj3)
    {
      return (object) ((ICriteria) obj0).CreateAlias((string) obj1, (string) obj2, obj3);
    }

    internal static object uPdOo0Bv6s23k4elRTLQ([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object LkV1muBvHG7AsTHrZ5ei([In] object obj0, [In] object obj1) => (object) Projections.Alias((IProjection) obj0, (string) obj1);

    internal static object YWhRqaBvAOiMARrgGWlC([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object CHTVdBBv7cFW74RA5cno([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetResultTransformer((IResultTransformer) obj1);

    internal static object YraW1uBvxs2Rltvr7Xxb([In] object obj0) => (object) Projections.Count((string) obj0);

    internal static void EoBpmbBv0v9Psw304n79([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool hkNXNmBvmFEGlaedJrJP([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object Ck6nMBBvyAdL1jLJZhfp([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool PDPsVDBvMuf4svq19DBR([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object kSsVWABvJr8D2kqcO5ki([In] object obj0, [In] object obj1) => (object) ((FormMetadataItemHeaderManager) obj0).ValidateNameCriteria((string) obj1);

    internal static object kc6NiJBv9shAtXrpuSG4([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object UiWeESBvdLfT2gd6DI0o([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static object VNFgOABvlMPP7tVsB45U([In] object obj0, [In] object obj1) => (object) ((ComponentMetadataItemHeaderManager) obj0).ValidateNameCriteria((string) obj1);

    internal static long YBrxuCBvrFAnxQjSuwvA([In] object obj0) => Convert.ToInt64(obj0);

    internal static void MLQhiJBvgAMKfdwXtkd2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal class HeaderDescriptorInfo
    {
      internal static FormMetadataItemHeaderManager.HeaderDescriptorInfo PLQ3qBQh55W9gEUpLIWB;

      public long Id
      {
        get => this.\u003CId\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CId\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public Guid Uid
      {
        get => this.\u003CUid\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CUid\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public string Name
      {
        get => this.\u003CName\u003Ek__BackingField;
        set
        {
          int num = 1;
          while (true)
          {
            switch (num)
            {
              case 0:
                goto label_2;
              case 1:
                this.\u003CName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }
      }

      public long? PublishedId { get; set; }

      public long? EmulationId { get; set; }

      public HeaderDescriptorInfo()
      {
        FormMetadataItemHeaderManager.HeaderDescriptorInfo.QIUsSfQhLhwLWqAfPerO();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool p9HuebQhj2ia2FGyTZTF() => FormMetadataItemHeaderManager.HeaderDescriptorInfo.PLQ3qBQh55W9gEUpLIWB == null;

      internal static FormMetadataItemHeaderManager.HeaderDescriptorInfo LrjnOBQhYipCBFaAjFeT() => FormMetadataItemHeaderManager.HeaderDescriptorInfo.PLQ3qBQh55W9gEUpLIWB;

      internal static void QIUsSfQhLhwLWqAfPerO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }

    internal static class PropertyNames
    {
      public static readonly string Id;
      public static readonly string Uid;
      public static readonly string Name;
      public static readonly string DisplayName;
      public static readonly string MetadataType;
      public static readonly string Published;
      public static readonly string PublishedId;
      public static readonly string Emulation;
      public static readonly string EmulationId;
      internal static FormMetadataItemHeaderManager.PropertyNames VivZZ3QhU3r0BBD4uGAB;

      static PropertyNames()
      {
        int num1 = 15;
        while (true)
        {
          int num2 = num1;
          ParameterExpression parameterExpression1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                // ISSUE: type reference
                parameterExpression1 = System.Linq.Expressions.Expression.Parameter(FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (FormMetadataItemHeaderManager.HeaderDescriptorInfo)), (string) FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(993438473 ^ 993396669));
                num2 = 18;
                continue;
              case 2:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) FormMetadataItemHeaderManager.PropertyNames.bgDEfAQGW1vK8PsWaMmm(FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (IFormMetadataItemHeader)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304567289));
                num2 = 8;
                continue;
              case 3:
                // ISSUE: type reference
                FormMetadataItemHeaderManager.PropertyNames.Id = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert())); // Unable to render the statement
                num2 = 11;
                continue;
              case 4:
                goto label_3;
              case 5:
                // ISSUE: method reference
                FormMetadataItemHeaderManager.PropertyNames.Published = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.upGTW7QGhF0tSNx1dTNY((object) parameterExpression1, (object) (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (IFormMetadataItemHeader.get_Published))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 17;
                continue;
              case 6:
                FormMetadataItemHeaderManager.PropertyNames.DisplayName = LinqUtils.NameOf<IFormMetadataItemHeader>((Expression<Func<IFormMetadataItemHeader, object>>) (parameterExpression => parameterExpression.DisplayName));
                num2 = 2;
                continue;
              case 7:
                // ISSUE: method reference
                FormMetadataItemHeaderManager.PropertyNames.Name = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.upGTW7QGhF0tSNx1dTNY((object) parameterExpression1, (object) (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (IFormMetadataItemHeader.get_Name))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 10 : 19;
                continue;
              case 8:
                // ISSUE: method reference
                // ISSUE: type reference
                FormMetadataItemHeaderManager.PropertyNames.MetadataType = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.fccuDtQGbkX1JoGwDoVa(FormMetadataItemHeaderManager.PropertyNames.upGTW7QGhF0tSNx1dTNY((object) parameterExpression1, (object) (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (IFormMetadataItemHeader.get_MetadataType))), FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (object))), parameterExpression1));
                num2 = 10;
                continue;
              case 9:
                parameterExpression1 = (ParameterExpression) FormMetadataItemHeaderManager.PropertyNames.bgDEfAQGW1vK8PsWaMmm(typeof (IFormMetadataItemHeader), FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(-1978478350 ^ -1978500026));
                num2 = 13;
                continue;
              case 10:
                // ISSUE: type reference
                parameterExpression1 = System.Linq.Expressions.Expression.Parameter(FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (IFormMetadataItemHeader)), (string) FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(1917998801 >> 2 ^ 479475968));
                num2 = 5;
                continue;
              case 11:
                // ISSUE: type reference
                parameterExpression1 = (ParameterExpression) FormMetadataItemHeaderManager.PropertyNames.bgDEfAQGW1vK8PsWaMmm(FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (IFormMetadataItemHeader)), FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(-1426456882 ^ 2009939514 ^ -583766976));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0 ? 14 : 16;
                continue;
              case 12:
                // ISSUE: method reference
                FormMetadataItemHeaderManager.PropertyNames.PublishedId = LinqUtils.NameOf<FormMetadataItemHeaderManager.HeaderDescriptorInfo>(System.Linq.Expressions.Expression.Lambda<Func<FormMetadataItemHeaderManager.HeaderDescriptorInfo, object>>((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression1, (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (FormMetadataItemHeaderManager.HeaderDescriptorInfo.get_PublishedId))), typeof (object)), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 9 : 3;
                continue;
              case 13:
                // ISSUE: method reference
                FormMetadataItemHeaderManager.PropertyNames.Emulation = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.upGTW7QGhF0tSNx1dTNY((object) parameterExpression1, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IFormMetadataItemHeader.get_Emulation))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 0;
                continue;
              case 14:
                parameterExpression1 = System.Linq.Expressions.Expression.Parameter(typeof (IFormMetadataItemHeader), (string) FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(-2092274397 << 4 ^ 883326596));
                num2 = 3;
                continue;
              case 15:
                goto label_22;
              case 16:
                // ISSUE: method reference
                // ISSUE: type reference
                FormMetadataItemHeaderManager.PropertyNames.Uid = LinqUtils.NameOf<IFormMetadataItemHeader>(System.Linq.Expressions.Expression.Lambda<Func<IFormMetadataItemHeader, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.fccuDtQGbkX1JoGwDoVa((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression1, (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (IFormMetadataItemHeader.get_Uid))), FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (object))), parameterExpression1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
                continue;
              case 17:
                // ISSUE: type reference
                parameterExpression1 = System.Linq.Expressions.Expression.Parameter(FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (FormMetadataItemHeaderManager.HeaderDescriptorInfo)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825413042));
                num2 = 12;
                continue;
              case 18:
                // ISSUE: method reference
                // ISSUE: type reference
                FormMetadataItemHeaderManager.PropertyNames.EmulationId = LinqUtils.NameOf<FormMetadataItemHeaderManager.HeaderDescriptorInfo>(System.Linq.Expressions.Expression.Lambda<Func<FormMetadataItemHeaderManager.HeaderDescriptorInfo, object>>((System.Linq.Expressions.Expression) FormMetadataItemHeaderManager.PropertyNames.fccuDtQGbkX1JoGwDoVa((object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) parameterExpression1, (MethodInfo) FormMetadataItemHeaderManager.PropertyNames.WJmKSaQGoZcKuW23MBEU(__methodref (FormMetadataItemHeaderManager.HeaderDescriptorInfo.get_EmulationId))), FormMetadataItemHeaderManager.PropertyNames.kUFAMpQGBqmXHCZF4srf(__typeref (object))), parameterExpression1));
                num2 = 4;
                continue;
              case 19:
                parameterExpression1 = System.Linq.Expressions.Expression.Parameter(typeof (IFormMetadataItemHeader), (string) FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(-688192331 - 435440695 ^ -1123674934));
                num2 = 6;
                continue;
              default:
                parameterExpression1 = (ParameterExpression) FormMetadataItemHeaderManager.PropertyNames.bgDEfAQGW1vK8PsWaMmm(typeof (IFormMetadataItemHeader), FormMetadataItemHeaderManager.PropertyNames.sQvIm9QGFiSDoSxMdM8i(-1876063057 ^ -1876090853));
                num2 = 7;
                continue;
            }
          }
label_22:
          FormMetadataItemHeaderManager.PropertyNames.RDyYxFQhzredLhp7VNml();
          num1 = 14;
        }
label_3:;
      }

      internal static void RDyYxFQhzredLhp7VNml() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object sQvIm9QGFiSDoSxMdM8i(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static Type kUFAMpQGBqmXHCZF4srf([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static object bgDEfAQGW1vK8PsWaMmm([In] Type obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Parameter(obj0, (string) obj1);

      internal static object WJmKSaQGoZcKuW23MBEU([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

      internal static object fccuDtQGbkX1JoGwDoVa([In] object obj0, [In] Type obj1) => (object) System.Linq.Expressions.Expression.Convert((System.Linq.Expressions.Expression) obj0, obj1);

      internal static object upGTW7QGhF0tSNx1dTNY([In] object obj0, [In] object obj1) => (object) System.Linq.Expressions.Expression.Property((System.Linq.Expressions.Expression) obj0, (MethodInfo) obj1);

      internal static bool aZUAPjQhst8ktKNMNjBE() => FormMetadataItemHeaderManager.PropertyNames.VivZZ3QhU3r0BBD4uGAB == null;

      internal static FormMetadataItemHeaderManager.PropertyNames AjJbobQhc6NwhGwydgGE() => FormMetadataItemHeaderManager.PropertyNames.VivZZ3QhU3r0BBD4uGAB;
    }
  }
}

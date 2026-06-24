// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.FunctionMetadataItemHeaderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер заголовков метаданных функций</summary>
  internal class FunctionMetadataItemHeaderManager : 
    EntityManager<FunctionMetadataItemHeader, long>,
    IFunctionMetadataItemHeaderManager,
    IEntityManager<FunctionMetadataItemHeader, long>,
    IEntityManager<FunctionMetadataItemHeader>,
    IEntityManager
  {
    private readonly ITransformationProvider transformationProvider;
    private static FunctionMetadataItemHeaderManager E1TbPwbsJsaRw29D4IOu;

    /// <summary>Ctor</summary>
    /// <param name="transformationProvider">Провайдер преобразования БД</param>
    public FunctionMetadataItemHeaderManager(ITransformationProvider transformationProvider)
    {
      FunctionMetadataItemHeaderManager.KejFmGbslRvNihHB6V7V();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.transformationProvider = transformationProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Экземпляр менеджера</summary>
    public static FunctionMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<FunctionMetadataItemHeaderManager>();

    /// <inheritdoc />
    public virtual long GetPublishingVersionNumber(long headerId)
    {
      int num = 3;
      object obj;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj is DBNull)
            {
              num = 6;
              continue;
            }
            goto label_3;
          case 2:
            str = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479695448), FunctionMetadataItemHeaderManager.Jwfc7Dbs5SXsRtrqm2tn(FunctionMetadataItemHeaderManager.I0uQrpbsri5G4fDO3gYy((object) this.transformationProvider), FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(322893104 - -1992822529 ^ -1979207037)), (object) headerId);
            num = 4;
            continue;
          case 3:
            if (headerId > 0L)
            {
              num = 2;
              continue;
            }
            goto label_10;
          case 4:
            obj = FunctionMetadataItemHeaderManager.lSJBOAbsYKEpH6nYEik1((object) ((IQuery) FunctionMetadataItemHeaderManager.ssqEUsbsj2JtFy9vRPtF((object) this.Session, (object) str)).CleanUpCache(false));
            num = 7;
            continue;
          case 5:
          case 6:
            goto label_2;
          case 7:
            if (obj == null)
            {
              num = 5;
              continue;
            }
            goto case 1;
          default:
            goto label_10;
        }
      }
label_2:
      return 1;
label_3:
      return Convert.ToInt64(obj) + 1L;
label_10:
      return 1;
    }

    /// <inheritdoc />
    public virtual bool ValidateName(long headerId, string name, out string errorMessage) => this.ValidateName((ICriterion) FunctionMetadataItemHeaderManager.PYbGs5bsLl7HEn0NCLqX((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Id, (object) headerId), name, out errorMessage);

    /// <inheritdoc />
    public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage) => this.ValidateName((ICriterion) FunctionMetadataItemHeaderManager.PYbGs5bsLl7HEn0NCLqX((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), name, out errorMessage);

    /// <inheritdoc />
    public virtual bool ValidateDisplayName(
      long headerId,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) Restrictions.Eq(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Id, (object) headerId), displayName, out errorMessage);
    }

    /// <inheritdoc />
    public virtual bool ValidateDisplayName(
      Guid headerUid,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) Restrictions.Eq(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), displayName, out errorMessage);
    }

    /// <inheritdoc />
    public IEnumerable<FunctionMetadataItemHeader> GetAllPublished() => (IEnumerable<FunctionMetadataItemHeader>) this.CreateCriteria(FetchOptions.All, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Published)).List<FunctionMetadataItemHeader>();

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор заголовока метаданных</param>
    /// <param name="group">Группа</param>
    /// <returns>Заголовок метаданных</returns>
    public FunctionMetadataItemHeader Edit(Guid uid, Guid group)
    {
      int num = 3;
      FunctionMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Save(metadataItemHeader);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            metadataItemHeader.Group = MetadataItemGroupUIManager.Instance.LoadOrNull(group);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 1 : 0;
            continue;
          case 3:
            metadataItemHeader = this.Load(uid);
            num = 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return metadataItemHeader;
    }

    /// <inheritdoc />
    public IEnumerable<FunctionMetadataItemHeader> GetAllDrafts() => (IEnumerable<FunctionMetadataItemHeader>) this.CreateCriteria(FetchOptions.All, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Draft)).List<FunctionMetadataItemHeader>();

    /// <inheritdoc />
    public override void Delete(FunctionMetadataItemHeader obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (FunctionMetadataItemHeaderManager.bjnB5ubsUKiy2cUBvZOi((object) obj) != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
              continue;
            }
            base.Delete(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 2 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:
      throw new InvalidOperationException((string) FunctionMetadataItemHeaderManager.lVd8IIbssY8ybxsrGpBt(FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(-2138160520 ^ -2138131936)));
    }

    protected virtual bool ValidateName(
      ICriterion compareCriterion,
      string name,
      out string errorMessage)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              errorMessage = (string) FunctionMetadataItemHeaderManager.lVd8IIbssY8ybxsrGpBt(FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(589593376 ^ -1977315327 ^ -1459611013));
              num2 = 11;
              continue;
            case 2:
              if (FunctionMetadataItemHeaderManager.UIlbFVbcGf7R0S2JW2EC(FunctionMetadataItemHeaderManager.OWUFUGbchs075s5d9PSJ((object) ((ICriteria) FunctionMetadataItemHeaderManager.vV2mBybcBV6ASwIc56dE(FunctionMetadataItemHeaderManager.vV2mBybcBV6ASwIc56dE(FunctionMetadataItemHeaderManager.mcU87HbszRQcZ0SUNLtl((object) this, (object) null), FunctionMetadataItemHeaderManager.U3DyUjbcFbKpEB4gy9YB((object) compareCriterion)), FunctionMetadataItemHeaderManager.nOOCyibcobK4M6xAvEC7(FunctionMetadataItemHeaderManager.NwOsVXbcWgwdAnaFbtcY((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name), (object) name))).SetProjection((IProjection) FunctionMetadataItemHeaderManager.P4Ve2qbcb2lHB1yjEqXZ((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Id)))) > 0L)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
                continue;
              }
              goto label_10;
            case 3:
              goto label_10;
            case 4:
              if (name.IsValidIdentifier())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 2;
                continue;
              }
              goto label_4;
            case 5:
              errorMessage = (string) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 7 : 2;
              continue;
            case 6:
              Contract.ArgumentNotNull((object) compareCriterion, (string) FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(-441065788 ^ -2092910478 ^ 1727371136));
              num2 = 5;
              continue;
            case 7:
              if (!FunctionMetadataItemHeaderManager.QLFPXUbscgcEHZRFuHxj((object) name))
              {
                num2 = 4;
                continue;
              }
              goto case 1;
            case 8:
              goto label_13;
            case 9:
              goto label_4;
            case 10:
              goto label_5;
            case 11:
              goto label_15;
            default:
              errorMessage = EleWise.ELMA.SR.T((string) FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(272623989 ^ 272425231));
              num2 = 8;
              continue;
          }
        }
label_4:
        errorMessage = (string) FunctionMetadataItemHeaderManager.lVd8IIbssY8ybxsrGpBt(FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(-2138958856 ^ -2138903708));
        num1 = 10;
      }
label_5:
      return false;
label_10:
      return true;
label_13:
      return false;
label_15:
      return false;
    }

    protected virtual bool ValidateDisplayName(
      ICriterion compareCriterion,
      string displayName,
      out string errorMessage)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            errorMessage = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            FunctionMetadataItemHeaderManager.hZ1G6EbcESbGPmnS4UDn((object) compareCriterion, FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(1597012150 ^ 1597016448));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          case 4:
            if (FunctionMetadataItemHeaderManager.UIlbFVbcGf7R0S2JW2EC(FunctionMetadataItemHeaderManager.OWUFUGbchs075s5d9PSJ((object) ((ICriteria) FunctionMetadataItemHeaderManager.vV2mBybcBV6ASwIc56dE(FunctionMetadataItemHeaderManager.vV2mBybcBV6ASwIc56dE(FunctionMetadataItemHeaderManager.mcU87HbszRQcZ0SUNLtl((object) this, (object) null), FunctionMetadataItemHeaderManager.U3DyUjbcFbKpEB4gy9YB((object) compareCriterion)), FunctionMetadataItemHeaderManager.nOOCyibcobK4M6xAvEC7(FunctionMetadataItemHeaderManager.NwOsVXbcWgwdAnaFbtcY((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.DisplayName), (object) displayName))).SetProjection((IProjection) FunctionMetadataItemHeaderManager.P4Ve2qbcb2lHB1yjEqXZ((object) FunctionMetadataItemHeaderManager._Resources_PropertyNames.Id)))) > 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 5 : 5;
              continue;
            }
            goto label_5;
          case 5:
            errorMessage = (string) FunctionMetadataItemHeaderManager.lVd8IIbssY8ybxsrGpBt(FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(1917998801 >> 2 ^ 479487862));
            num = 8;
            continue;
          case 6:
            errorMessage = (string) FunctionMetadataItemHeaderManager.lVd8IIbssY8ybxsrGpBt(FunctionMetadataItemHeaderManager.EfK6wVbsgxTW06DKrmdJ(1319452732 ^ 1319482008));
            num = 3;
            continue;
          case 7:
            goto label_5;
          case 8:
            goto label_8;
          default:
            if (!string.IsNullOrEmpty(displayName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 4;
              continue;
            }
            goto case 6;
        }
      }
label_2:
      return false;
label_5:
      return true;
label_8:
      return false;
    }

    internal static void KejFmGbslRvNihHB6V7V() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sJP2Rsbs9VP8KbbuGs3x() => FunctionMetadataItemHeaderManager.E1TbPwbsJsaRw29D4IOu == null;

    internal static FunctionMetadataItemHeaderManager LZAWZRbsdsVnKgnFThB0() => FunctionMetadataItemHeaderManager.E1TbPwbsJsaRw29D4IOu;

    internal static object I0uQrpbsri5G4fDO3gYy([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object EfK6wVbsgxTW06DKrmdJ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Jwfc7Dbs5SXsRtrqm2tn([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object ssqEUsbsj2JtFy9vRPtF([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object lSJBOAbsYKEpH6nYEik1([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static object PYbGs5bsLl7HEn0NCLqX([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object bjnB5ubsUKiy2cUBvZOi([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Published;

    internal static object lVd8IIbssY8ybxsrGpBt([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool QLFPXUbscgcEHZRFuHxj([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object mcU87HbszRQcZ0SUNLtl([In] object obj0, [In] object obj1) => (object) ((EntityManager<FunctionMetadataItemHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object U3DyUjbcFbKpEB4gy9YB([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object vV2mBybcBV6ASwIc56dE([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object NwOsVXbcWgwdAnaFbtcY([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object nOOCyibcobK4M6xAvEC7([In] object obj0, [In] object obj1) => (object) ElmaRestrictions.InsensitiveLike((IProjection) obj0, obj1);

    internal static object P4Ve2qbcb2lHB1yjEqXZ([In] object obj0) => (object) Projections.Count((string) obj0);

    internal static object OWUFUGbchs075s5d9PSJ([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static long UIlbFVbcGf7R0S2JW2EC([In] object obj0) => Convert.ToInt64(obj0);

    internal static void hZ1G6EbcESbGPmnS4UDn([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static class _Resources_PropertyNames
    {
      public static readonly string Id;
      public static readonly string Uid;
      public static readonly string Name;
      public static readonly string DisplayName;
      public static readonly string Published;
      public static readonly string Draft;
      internal static FunctionMetadataItemHeaderManager._Resources_PropertyNames ydQ3N8CM4tR9d9CVlupP;

      static _Resources_PropertyNames()
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid = (string) FunctionMetadataItemHeaderManager._Resources_PropertyNames.s0cBwSCM7Nabqpx84jyd(825385222 ^ 825364116);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 6 : 6;
              continue;
            case 2:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.Draft = (string) FunctionMetadataItemHeaderManager._Resources_PropertyNames.s0cBwSCM7Nabqpx84jyd(964881585 - -1459193222 ^ -1870864437);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 6 : 7;
              continue;
            case 3:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.DisplayName = (string) FunctionMetadataItemHeaderManager._Resources_PropertyNames.s0cBwSCM7Nabqpx84jyd(~289714581 ^ -289818402);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
              continue;
            case 4:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.Id = (string) FunctionMetadataItemHeaderManager._Resources_PropertyNames.s0cBwSCM7Nabqpx84jyd(-16752921 ^ -16719943);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 1 : 1;
              continue;
            case 5:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.UDgtd8CMAEyDRgouBnif();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 3 : 4;
              continue;
            case 6:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218467730);
              num = 3;
              continue;
            case 7:
              goto label_2;
            default:
              FunctionMetadataItemHeaderManager._Resources_PropertyNames.Published = (string) FunctionMetadataItemHeaderManager._Resources_PropertyNames.s0cBwSCM7Nabqpx84jyd(1819636893 << 3 ^ 1672075890);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      internal static void UDgtd8CMAEyDRgouBnif() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object s0cBwSCM7Nabqpx84jyd(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool u8RALeCM65yhmJ8wNKWk() => FunctionMetadataItemHeaderManager._Resources_PropertyNames.ydQ3N8CM4tR9d9CVlupP == null;

      internal static FunctionMetadataItemHeaderManager._Resources_PropertyNames aENmHbCMHtksLj57r2lD() => FunctionMetadataItemHeaderManager._Resources_PropertyNames.ydQ3N8CM4tR9d9CVlupP;
    }
  }
}

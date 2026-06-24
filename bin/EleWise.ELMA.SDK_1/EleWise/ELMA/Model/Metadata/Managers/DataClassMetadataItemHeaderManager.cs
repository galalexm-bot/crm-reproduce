// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.DataClassMetadataItemHeaderManager
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
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер заголовков метаданных DataClass</summary>
  internal class DataClassMetadataItemHeaderManager : 
    EntityManager<DataClassMetadataItemHeader, long>,
    IDataClassMetadataItemHeaderManager,
    IEntityManager<DataClassMetadataItemHeader, long>,
    IEntityManager<DataClassMetadataItemHeader>,
    IEntityManager
  {
    internal static DataClassMetadataItemHeaderManager pOsY8wbU1q5v6P1iCY6E;

    /// <summary>Экземпляр менеджера</summary>
    public static DataClassMetadataItemHeaderManager Instance => Locator.GetServiceNotNull<DataClassMetadataItemHeaderManager>();

    /// <inheritdoc />
    public IEnumerable<DataClassMetadataItemHeader> GetAllPublished() => (IEnumerable<DataClassMetadataItemHeader>) this.CreateCriteria(FetchOptions.All, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(DataClassMetadataItemHeaderManager._Resources_PropertyNames.Published)).List<DataClassMetadataItemHeader>();

    /// <inheritdoc />
    public IEnumerable<DataClassMetadataItemHeader> GetAllDrafts() => (IEnumerable<DataClassMetadataItemHeader>) this.CreateCriteria(new FetchOptions(0, 0)
    {
      FetchRelations = new List<string>()
      {
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108005918),
        z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272428103)
      }
    }, this.ImplementationType).Add((ICriterion) Restrictions.IsNotNull(DataClassMetadataItemHeaderManager._Resources_PropertyNames.Draft)).List<DataClassMetadataItemHeader>();

    /// <inheritdoc />
    public virtual bool ValidateName(Guid headerUid, string name, out string errorMessage) => this.ValidateName((ICriterion) Restrictions.Eq(DataClassMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), name, out errorMessage);

    /// <inheritdoc />
    public virtual bool ValidateDisplayName(
      Guid headerUid,
      string displayName,
      out string errorMessage)
    {
      return this.ValidateDisplayName((ICriterion) DataClassMetadataItemHeaderManager.cgnM98bUpKvcXl89U1ZZ((object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.Uid, (object) headerUid), displayName, out errorMessage);
    }

    /// <inheritdoc />
    public virtual long GetNewPublishingVersionNumber(long headerId)
    {
      int num = 6;
      object obj;
      string str;
      ITransformationProvider service;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj == null)
            {
              num = 4;
              continue;
            }
            goto case 2;
          case 2:
            if (obj is DBNull)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 3:
            obj = DataClassMetadataItemHeaderManager.i9wHv4bUwQ412e8AOI92((object) ((IQuery) DataClassMetadataItemHeaderManager.UtnJ9RbUt4Uw0lGoyeXA((object) this.Session, (object) str)).CleanUpCache(false));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 0;
            continue;
          case 5:
            goto label_9;
          case 6:
            if (headerId <= 0L)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 5 : 4;
              continue;
            }
            service = Locator.GetService<ITransformationProvider>();
            num = 7;
            continue;
          case 7:
            str = string.Format((string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(-420743386 ^ -420941196), service == null ? DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(-649342099 - -1150814748 ^ 501443387) : (object) ((Dialect) DataClassMetadataItemHeaderManager.VlfSP3bUDpj5TLMOKWAq((object) service)).QuoteIfNeeded((string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(-1426456882 ^ 2009939514 ^ -583764410)), (object) headerId);
            num = 3;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return 1;
label_6:
      return DataClassMetadataItemHeaderManager.XIO59PbU4C2K9XPukAcl(obj) + 1L;
label_9:
      return 1;
    }

    /// <summary>Редактировать заголовок метаданных</summary>
    /// <param name="uid">Идентификатор заголовока метаданных</param>
    /// <param name="groupUid">Группа</param>
    /// <returns>Заголовок метаданных</returns>
    public DataClassMetadataItemHeader Edit(Guid uid, Guid groupUid)
    {
      int num = 1;
      DataClassMetadataItemHeader metadataItemHeader;
      while (true)
      {
        switch (num)
        {
          case 1:
            metadataItemHeader = this.Load(uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
            this.Save(metadataItemHeader);
            num = 3;
            continue;
          case 3:
            goto label_4;
          default:
            DataClassMetadataItemHeaderManager.FMUrbXbUHlBw7K2vp7RE((object) metadataItemHeader, (object) ((AbstractNHEntityManager<MetadataItemGroupUI, long>) DataClassMetadataItemHeaderManager.LkmJ8ebU6JgfaKVFgt1t()).LoadOrNull(groupUid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      return metadataItemHeader;
    }

    /// <inheritdoc />
    public override void Delete(DataClassMetadataItemHeader obj)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_6;
          case 2:
            base.Delete(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          case 3:
            if (DataClassMetadataItemHeaderManager.sJlH8ObUAo3cq1CpHjG9((object) obj) == null)
            {
              num = 2;
              continue;
            }
            goto label_6;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_2:
      return;
label_6:
      throw new InvalidOperationException((string) DataClassMetadataItemHeaderManager.S9EfDobU7WqfT4ZDuSuY(DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(-2092274397 << 4 ^ 883303016)));
    }

    private bool ValidateName(ICriterion compareCriterion, string name, out string errorMessage)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              DataClassMetadataItemHeaderManager.bP90prbUxZRH5xS5J55e((object) compareCriterion, DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(1669212571 ^ 1669257389));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_14;
            case 3:
              goto label_11;
            case 4:
              if (DataClassMetadataItemHeaderManager.XIO59PbU4C2K9XPukAcl(DataClassMetadataItemHeaderManager.s117BObUl90ldNci3kEF(DataClassMetadataItemHeaderManager.xij2TybUdVdUjOWjjMlP(DataClassMetadataItemHeaderManager.dPsG0CbUM8CRKQwytWjv(DataClassMetadataItemHeaderManager.dPsG0CbUM8CRKQwytWjv(DataClassMetadataItemHeaderManager.z0V8IbbUmWYT4MnuaRiN((object) this, (object) null), DataClassMetadataItemHeaderManager.wtfTptbUyn7ME8Vnl7oe((object) compareCriterion)), DataClassMetadataItemHeaderManager.fJjNZGbUJEG9AeXmgOK9((object) Projections.Property(DataClassMetadataItemHeaderManager._Resources_PropertyNames.Name), (object) name)), (object) new IProjection[1]
              {
                (IProjection) DataClassMetadataItemHeaderManager.A2YTaYbU9DAoGOXjMqeC((object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.Id)
              }))) > 0L)
              {
                errorMessage = EleWise.ELMA.SR.T((string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(--1418440330 ^ 1418242432));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 2 : 1;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 3 : 6;
              continue;
            case 5:
              goto label_8;
            case 6:
              errorMessage = (string) null;
              num2 = 9;
              continue;
            case 7:
              errorMessage = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138225590));
              num2 = 5;
              continue;
            case 8:
              goto label_3;
            case 9:
              goto label_6;
            default:
              if (!string.IsNullOrEmpty(name))
              {
                if (DataClassMetadataItemHeaderManager.BdDKkobU08nB1Am6fdFa((object) name))
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 2 : 4;
                  continue;
                }
                goto case 7;
              }
              else
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 3 : 2;
                continue;
              }
          }
        }
label_11:
        errorMessage = EleWise.ELMA.SR.T((string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(-630932142 - 1120244082 ^ -1751372286));
        num1 = 8;
      }
label_3:
      return false;
label_6:
      return true;
label_8:
      return false;
label_14:
      return false;
    }

    private bool ValidateDisplayName(
      ICriterion compareCriterion,
      string displayName,
      out string errorMessage)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            goto label_2;
          case 3:
            if (string.IsNullOrEmpty(displayName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 5 : 2;
              continue;
            }
            if (DataClassMetadataItemHeaderManager.XIO59PbU4C2K9XPukAcl(DataClassMetadataItemHeaderManager.s117BObUl90ldNci3kEF((object) ((ICriteria) DataClassMetadataItemHeaderManager.dPsG0CbUM8CRKQwytWjv(DataClassMetadataItemHeaderManager.z0V8IbbUmWYT4MnuaRiN((object) this, (object) null), (object) Restrictions.Not(compareCriterion))).Add((ICriterion) DataClassMetadataItemHeaderManager.fJjNZGbUJEG9AeXmgOK9(DataClassMetadataItemHeaderManager.quTB49bUrIp317JwxqnG((object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.DisplayName), (object) displayName)).SetProjection((IProjection) DataClassMetadataItemHeaderManager.A2YTaYbU9DAoGOXjMqeC((object) DataClassMetadataItemHeaderManager._Resources_PropertyNames.Id)))) > 0L)
            {
              num = 7;
              continue;
            }
            goto case 6;
          case 4:
            Contract.ArgumentNotNull((object) compareCriterion, (string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(1505778440 - 1981636111 ^ -475918897));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0 ? 3 : 2;
            continue;
          case 5:
            errorMessage = EleWise.ELMA.SR.T((string) DataClassMetadataItemHeaderManager.I0JYeGbUaMwxx6V76TWl(1470998129 - 231418599 ^ 1239514728));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
            continue;
          case 6:
            errorMessage = (string) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 7:
            errorMessage = (string) DataClassMetadataItemHeaderManager.S9EfDobU7WqfT4ZDuSuY((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088238382));
            num = 2;
            continue;
          default:
            goto label_10;
        }
      }
label_2:
      return false;
label_6:
      return false;
label_10:
      return true;
    }

    public DataClassMetadataItemHeaderManager()
    {
      DataClassMetadataItemHeaderManager.C3qujhbUgYBovNgP2TjS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool QA709mbUNJbP34tdRLUi() => DataClassMetadataItemHeaderManager.pOsY8wbU1q5v6P1iCY6E == null;

    internal static DataClassMetadataItemHeaderManager zpRRATbU3aOMZHFeRcs4() => DataClassMetadataItemHeaderManager.pOsY8wbU1q5v6P1iCY6E;

    internal static object cgnM98bUpKvcXl89U1ZZ([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object I0JYeGbUaMwxx6V76TWl(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object VlfSP3bUDpj5TLMOKWAq([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object UtnJ9RbUt4Uw0lGoyeXA([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static object i9wHv4bUwQ412e8AOI92([In] object obj0) => ((IQuery) obj0).UniqueResult();

    internal static long XIO59PbU4C2K9XPukAcl([In] object obj0) => Convert.ToInt64(obj0);

    internal static object LkmJ8ebU6JgfaKVFgt1t() => (object) MetadataItemGroupUIManager.Instance;

    internal static void FMUrbXbUHlBw7K2vp7RE([In] object obj0, [In] object obj1) => ((DataClassMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static object sJlH8ObUAo3cq1CpHjG9([In] object obj0) => (object) ((DataClassMetadataItemHeader) obj0).Published;

    internal static object S9EfDobU7WqfT4ZDuSuY([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void bP90prbUxZRH5xS5J55e([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool BdDKkobU08nB1Am6fdFa([In] object obj0) => ((string) obj0).IsValidIdentifier();

    internal static object z0V8IbbUmWYT4MnuaRiN([In] object obj0, [In] object obj1) => (object) ((EntityManager<DataClassMetadataItemHeader, long>) obj0).CreateCriteria((IEntityFilter) obj1);

    internal static object wtfTptbUyn7ME8Vnl7oe([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object dPsG0CbUM8CRKQwytWjv([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object fJjNZGbUJEG9AeXmgOK9([In] object obj0, [In] object obj1) => (object) ElmaRestrictions.InsensitiveLike((IProjection) obj0, obj1);

    internal static object A2YTaYbU9DAoGOXjMqeC([In] object obj0) => (object) Projections.Count((string) obj0);

    internal static object xij2TybUdVdUjOWjjMlP([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).SetProjection((IProjection[]) obj1);

    internal static object s117BObUl90ldNci3kEF([In] object obj0) => ((ICriteria) obj0).UniqueResult();

    internal static object quTB49bUrIp317JwxqnG([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static void C3qujhbUgYBovNgP2TjS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static class _Resources_PropertyNames
    {
      public static readonly string Id;
      public static readonly string Uid;
      public static readonly string Name;
      public static readonly string DisplayName;
      public static readonly string Published;
      public static readonly string Draft;
      private static DataClassMetadataItemHeaderManager._Resources_PropertyNames HO4ZBhCMokY4O9kXSNs2;

      static _Resources_PropertyNames()
      {
        int num1 = 3;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.Published = (string) DataClassMetadataItemHeaderManager._Resources_PropertyNames.QxceOgCMEaUGdfSKijB6(333888594 ^ 1075625116 ^ 1408794196);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              case 2:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.Id = (string) DataClassMetadataItemHeaderManager._Resources_PropertyNames.QxceOgCMEaUGdfSKijB6(-1598106783 - -968262081 ^ -629812100);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 5 : 6;
                continue;
              case 3:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.eiAZXyCMGqwc3YYIeSg6();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 2;
                continue;
              case 4:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767716293);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 7 : 7;
                continue;
              case 5:
                goto label_3;
              case 6:
                goto label_6;
              case 7:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.DisplayName = (string) DataClassMetadataItemHeaderManager._Resources_PropertyNames.QxceOgCMEaUGdfSKijB6(-2112703338 ^ -2112863710);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
                continue;
              default:
                DataClassMetadataItemHeaderManager._Resources_PropertyNames.Draft = (string) DataClassMetadataItemHeaderManager._Resources_PropertyNames.QxceOgCMEaUGdfSKijB6(993438473 ^ 993396469);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 1 : 5;
                continue;
            }
          }
label_6:
          DataClassMetadataItemHeaderManager._Resources_PropertyNames.Uid = (string) DataClassMetadataItemHeaderManager._Resources_PropertyNames.QxceOgCMEaUGdfSKijB6(825385222 ^ 825364116);
          num1 = 4;
        }
label_3:;
      }

      internal static void eiAZXyCMGqwc3YYIeSg6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object QxceOgCMEaUGdfSKijB6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool WP7UZWCMb4CfflPC3R41() => DataClassMetadataItemHeaderManager._Resources_PropertyNames.HO4ZBhCMokY4O9kXSNs2 == null;

      internal static DataClassMetadataItemHeaderManager._Resources_PropertyNames zgFxfXCMhned760DOFtO() => DataClassMetadataItemHeaderManager._Resources_PropertyNames.HO4ZBhCMokY4O9kXSNs2;
    }
  }
}

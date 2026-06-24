// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Managers.DataClassTypeReferenceManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Metadata.Managers
{
  /// <summary>Менеджер ссылки типа DTO</summary>
  [Service(Type = ComponentType.Server, EnableInterceptors = false)]
  internal sealed class DataClassTypeReferenceManager : 
    NHManager,
    IDataClassTypeReferenceManager,
    IDataClassMetadataTypeReferenceService
  {
    internal static DataClassTypeReferenceManager yJcls9bLrbG3LSZEiNwG;

    /// <inheritdoc />
    public long Save(DataClassTypeReference dataClassTypeReference)
    {
      int num = 4;
      Guid itemUid;
      DataClassTypeReference byItemUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (byItemUid != null)
            {
              num = 6;
              continue;
            }
            goto label_9;
          case 2:
            byItemUid = this.FindByItemUid(itemUid, DataClassTypeReferenceManager.KMAAHxbLLh9mqZm8ahu0((object) dataClassTypeReference));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 1;
            continue;
          case 3:
            DataClassTypeReferenceManager.jix7OgbLUuufisNXVUmi(DataClassTypeReferenceManager.KMAAHxbLLh9mqZm8ahu0((object) dataClassTypeReference) != Guid.Empty, DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(874012245 ^ 874208607));
            num = 5;
            continue;
          case 4:
            DataClassTypeReferenceManager.a5iXJubLYVBxm3YLayCd((object) dataClassTypeReference, DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(1461625753 ^ 1461559619));
            num = 3;
            continue;
          case 5:
            itemUid = DataClassTypeReferenceManager.qR4J7ibLsgBuR22Dt99s((object) dataClassTypeReference);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 6:
            goto label_8;
          default:
            if (DataClassTypeReferenceManager.Ln44Q2bLc1H0eovhB9KI(itemUid, Guid.Empty))
            {
              num = 2;
              continue;
            }
            goto label_9;
        }
      }
label_8:
      return DataClassTypeReferenceManager.M7C88vbLzZZDXbiFrLic((object) byItemUid);
label_9:
      return (long) DataClassTypeReferenceManager.P1u0SPbUFnbGprCsf710((object) this.Session, (object) dataClassTypeReference);
    }

    /// <inheritdoc />
    public DataClassTypeReference LoadOrNull(string id)
    {
      int num = 2;
      long result;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (long.TryParse(id, out result))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            Contract.ArgumentNotNullOrEmpty(id, (string) DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(-675505729 ^ -675435835));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.Session.Get<DataClassTypeReference>((object) result);
label_4:
      return (DataClassTypeReference) null;
    }

    /// <inheritdoc />
    public DataClassTypeReference FindByItemUid(Guid itemUid, Guid metadataUid) => ((ICriteria) DataClassTypeReferenceManager.MyfP8tbUWNNH4sQQdgjM(DataClassTypeReferenceManager.MyfP8tbUWNNH4sQQdgjM((object) this.Session.CreateCriteria<DataClassTypeReference>(), DataClassTypeReferenceManager.vMlfWcbUB5YG4ZU88Pgr(DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(-867826612 ^ -867939302), (object) itemUid)), DataClassTypeReferenceManager.vMlfWcbUB5YG4ZU88Pgr(DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(-688192331 - 435440695 ^ -1123749774), (object) metadataUid))).UniqueResult<DataClassTypeReference>();

    /// <inheritdoc />
    public DataClassTypeReference FindByMetadataUid(Guid metadataUid) => ((ICriteria) DataClassTypeReferenceManager.MyfP8tbUWNNH4sQQdgjM((object) this.Session.CreateCriteria<DataClassTypeReference>(), DataClassTypeReferenceManager.vMlfWcbUB5YG4ZU88Pgr((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539251267), (object) metadataUid))).UniqueResult<DataClassTypeReference>();

    /// <inheritdoc />
    public Guid? GetMetadataUid(string typeRef) => this.LoadOrNull(typeRef)?.MetadataUid;

    /// <inheritdoc />
    public DataClassTypeReference[] FindReferencesByItemUid(Guid[] itemUid) => ((ICriteria) DataClassTypeReferenceManager.MyfP8tbUWNNH4sQQdgjM((object) this.Session.CreateCriteria<DataClassTypeReference>(), DataClassTypeReferenceManager.g4iVSrbUo4fYqkWPPVsj(DataClassTypeReferenceManager.xnSkfPbLjpgyU0kFRXwV(-105199646 ^ -105345100), (object) itemUid))).List<DataClassTypeReference>().ToArray<DataClassTypeReference>();

    public DataClassTypeReferenceManager()
    {
      DataClassTypeReferenceManager.lZdSpjbUbMF79D9Rk20y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object xnSkfPbLjpgyU0kFRXwV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void a5iXJubLYVBxm3YLayCd([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static Guid KMAAHxbLLh9mqZm8ahu0([In] object obj0) => ((DataClassTypeReference) obj0).MetadataUid;

    internal static void jix7OgbLUuufisNXVUmi(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static Guid qR4J7ibLsgBuR22Dt99s([In] object obj0) => ((DataClassTypeReference) obj0).ItemUid;

    internal static bool Ln44Q2bLc1H0eovhB9KI([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static long M7C88vbLzZZDXbiFrLic([In] object obj0) => ((DataClassTypeReference) obj0).Id;

    internal static object P1u0SPbUFnbGprCsf710([In] object obj0, [In] object obj1) => ((ISession) obj0).Save(obj1);

    internal static bool JBFpKgbLg17dKsyhQ1dZ() => DataClassTypeReferenceManager.yJcls9bLrbG3LSZEiNwG == null;

    internal static DataClassTypeReferenceManager IPWMHcbL52A7N3jTZb80() => DataClassTypeReferenceManager.yJcls9bLrbG3LSZEiNwG;

    internal static object vMlfWcbUB5YG4ZU88Pgr([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object MyfP8tbUWNNH4sQQdgjM([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object g4iVSrbUo4fYqkWPPVsj([In] object obj0, [In] object obj1) => (object) Restrictions.In((string) obj0, (ICollection) obj1);

    internal static void lZdSpjbUbMF79D9Rk20y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

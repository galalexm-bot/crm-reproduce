// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.Actions.UidInitializeAction
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Db.Actions
{
  /// <summary>
  /// Действие, инициализирующее свойство Uid у существующих записей
  /// </summary>
  public class UidInitializeAction : ModelAction
  {
    private EntityMetadata metadata;
    private EntityPropertyMetadata uidPropertyMetadata;
    private ISession session;
    internal static UidInitializeAction LNis9xohdwbF8JVOsC4W;

    /// <summary>Создать действие</summary>
    /// <param name="updater">Обработчик изменения структуры БД моделей</param>
    /// <param name="metadata">Метаданные сущности</param>
    /// <param name="uidPropertyMetadata">Метаданные свойства "Уникальный идентификатор"</param>
    /// <param name="session">Сессия NHibernate</param>
    public UidInitializeAction(
      IDbModelUpdater updater,
      EntityMetadata metadata,
      EntityPropertyMetadata uidPropertyMetadata,
      ISession session)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(updater);
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.uidPropertyMetadata = uidPropertyMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 4 : 4;
            continue;
          case 2:
            this.metadata = metadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
          case 3:
            Contract.ArgumentNotNull((object) metadata, (string) UidInitializeAction.o91EVAohgNLqJbCi4Ka0(964881585 - -1459193222 ^ -1870906615));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 4:
            this.session = session;
            num = 5;
            continue;
          case 5:
            goto label_2;
          case 6:
            UidInitializeAction.FSVgiEoh5WAYQjv45gSS((object) session, UidInitializeAction.o91EVAohgNLqJbCi4Ka0(-1350312861 << 3 ^ 2082400808));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 2 : 2;
            continue;
          default:
            UidInitializeAction.FSVgiEoh5WAYQjv45gSS((object) uidPropertyMetadata, UidInitializeAction.o91EVAohgNLqJbCi4Ka0(--1360331293 ^ 1360484275));
            num = 6;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнение действия</summary>
    public override void Execute()
    {
      int num1 = 1;
      Type typeByUid;
      IEnumerator<IEntity> enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            base.Execute();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_12;
          case 3:
            enumerator = ((IEnumerable) UidInitializeAction.sVvFcPohLHf1Ju3j46FK((object) this.session.CreateCriteria(typeByUid).Add((ICriterion) Restrictions.Or((ICriterion) UidInitializeAction.Pca8XdohY96vW6kjPBaR(UidInitializeAction.o91EVAohgNLqJbCi4Ka0(-1217523399 ^ -1217495381)), (ICriterion) Restrictions.Eq((string) UidInitializeAction.o91EVAohgNLqJbCi4Ka0(-2106517564 ^ -2106492842), (object) Guid.Empty))))).Cast<IEntity>().GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 4 : 3;
            continue;
          case 4:
            goto label_3;
          default:
            typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(UidInitializeAction.fBxPggohjvGnLtZiygso((object) this.metadata));
            num1 = 3;
            continue;
        }
      }
label_12:
      return;
label_3:
      try
      {
label_6:
        if (UidInitializeAction.veMLVoohs1JWM5yDvOyN((object) enumerator))
          goto label_5;
        else
          goto label_7;
label_4:
        int num2;
        switch (num2)
        {
          case 1:
            return;
          case 2:
            goto label_6;
        }
label_5:
        IEntity current = enumerator.Current;
        UidInitializeAction.Wl4AvAohUpTfDgQ7XPA8((object) current, UidInitializeAction.fBxPggohjvGnLtZiygso((object) this.uidPropertyMetadata), (object) Guid.NewGuid());
        current.Save();
        num2 = 2;
        goto label_4;
label_7:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
        goto label_4;
      }
      finally
      {
        int num3;
        if (enumerator == null)
          num3 = 2;
        else
          goto label_13;
label_10:
        switch (num3)
        {
          case 1:
          case 2:
        }
label_13:
        UidInitializeAction.HGXto2ohceKJOOPbRkMx((object) enumerator);
        num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        {
          num3 = 1;
          goto label_10;
        }
        else
          goto label_10;
      }
    }

    internal static object o91EVAohgNLqJbCi4Ka0(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void FSVgiEoh5WAYQjv45gSS([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static bool U8jUl9ohlaLO5SlBeyiZ() => UidInitializeAction.LNis9xohdwbF8JVOsC4W == null;

    internal static UidInitializeAction SSvZBwohrXsMQ6w69ImC() => UidInitializeAction.LNis9xohdwbF8JVOsC4W;

    internal static Guid fBxPggohjvGnLtZiygso([In] object obj0) => ((EleWise.ELMA.Model.Metadata.AbstractMetadata) obj0).Uid;

    internal static object Pca8XdohY96vW6kjPBaR([In] object obj0) => (object) Restrictions.IsNull((string) obj0);

    internal static object sVvFcPohLHf1Ju3j46FK([In] object obj0) => (object) ((ICriteria) obj0).List();

    internal static void Wl4AvAohUpTfDgQ7XPA8([In] object obj0, Guid propertyUid, [In] object obj2) => ((IEntity) obj0).SetPropertyValue(propertyUid, obj2);

    internal static bool veMLVoohs1JWM5yDvOyN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void HGXto2ohceKJOOPbRkMx([In] object obj0) => ((IDisposable) obj0).Dispose();
  }
}

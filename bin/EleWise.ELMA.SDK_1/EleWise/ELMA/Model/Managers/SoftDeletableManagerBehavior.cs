// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.SoftDeletableManagerBehavior
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>
  /// Точка расширения для реализации логики "мягкого" удаления
  /// </summary>
  [Component(Order = 8)]
  public class SoftDeletableManagerBehavior : EntityManagerBehavior
  {
    private ConcurrentDictionary<System.Type, bool> cacheInstanceSettings;
    internal static SoftDeletableManagerBehavior tBLDbnhGJxi6RJcN4l0F;

    /// <summary>
    /// Сервис для запуска с привилегиями на "мягкое" удаление
    /// </summary>
    public RunWithSoftDeletableService RunWithSoftDeletableService
    {
      get => this.\u003CRunWithSoftDeletableService\u003Ek__BackingField;
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
              this.\u003CRunWithSoftDeletableService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <inheritdoc />
    public override void OnLoad(object target)
    {
      int num1 = 16;
      IEntity entity;
      object obj;
      IMetadata metadata;
      while (true)
      {
        int num2 = num1;
        ISoftDeletable softDeletable;
        IInstanceSettingsPermission settingsPermission;
        bool flag;
        System.Type type;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_31;
            case 1:
              // ISSUE: reference to a compiler-generated method
              settingsPermission = ((ComponentManager) SoftDeletableManagerBehavior.HxQCo6hG5Zk8NcUgftvI()).GetExtensionPoints<IInstanceSettingsPermission>(false).FirstOrDefault<IInstanceSettingsPermission>((Func<IInstanceSettingsPermission, bool>) (p => type.IsInheritOrSame(SoftDeletableManagerBehavior.\u003C\u003Ec__DisplayClass5_0.rjBi8NCg14aT18XHVSwX((object) p))));
              num2 = 5;
              continue;
            case 2:
              type = SoftDeletableManagerBehavior.Fu31DchGl2BFkAG7S3Fo(target);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 10 : 10;
              continue;
            case 3:
              goto label_4;
            case 4:
              if (!this.cacheInstanceSettings.TryGetValue(type, out flag))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
                continue;
              }
              goto case 17;
            case 5:
              flag = settingsPermission != null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 7 : 3;
              continue;
            case 6:
              goto label_21;
            case 7:
              goto label_18;
            case 8:
              if (!SoftDeletableManagerBehavior.AAKfBfhGgcw0FB0JBOyC((object) softDeletable))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
                continue;
              }
              goto case 4;
            case 9:
              entity = (target as IEntity).CastAsRealType<IEntity>();
              num2 = 18;
              continue;
            case 10:
              goto label_5;
            case 11:
              if (target != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 9 : 8;
                continue;
              }
              goto label_13;
            case 12:
              goto label_36;
            case 13:
              if (softDeletable == null)
              {
                num2 = 3;
                continue;
              }
              goto case 8;
            case 14:
              goto label_33;
            case 15:
              if (!this.RunWithSoftDeletableService.Turned)
              {
                num2 = 11;
                continue;
              }
              goto label_14;
            case 16:
              num2 = 15;
              continue;
            case 17:
              if (!flag)
              {
                num2 = 21;
                continue;
              }
              goto label_22;
            case 18:
              if (entity != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
                continue;
              }
              goto label_11;
            case 19:
              softDeletable = entity as ISoftDeletable;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 7 : 13;
              continue;
            case 20:
              goto label_27;
            case 21:
              goto label_8;
            default:
              goto label_3;
          }
        }
label_5:
        obj = SoftDeletableManagerBehavior.wO6wY0hGr2hqUi9qU7sf((object) entity);
        num1 = 19;
        continue;
label_18:
        this.cacheInstanceSettings.TryAdd(type, settingsPermission != null);
        num1 = 17;
        continue;
label_22:
        metadata = MetadataLoader.LoadMetadata(type, false, false);
        num1 = 12;
      }
label_31:
      return;
label_4:
      return;
label_21:
      return;
label_33:
      return;
label_27:
      return;
label_8:
      return;
label_3:
      return;
label_13:
      return;
label_11:
      return;
label_14:
      return;
label_36:
      ObjectIsDeletedException deletedException = new ObjectIsDeletedException(EleWise.ELMA.SR.T((string) SoftDeletableManagerBehavior.hd2RX9hGjAFp7kQemDMM(1470440286 ^ 1470498292), (object) entity.ToString(), obj));
      SoftDeletableManagerBehavior.yG49ashGYgMY6xHlGHLP((object) deletedException, obj);
      SoftDeletableManagerBehavior.ckKrvRhGUv1RlscCbckp((object) deletedException, metadata != null ? SoftDeletableManagerBehavior.BeGr8thGLN9OI83gcAPO((object) metadata) : Guid.Empty);
      throw deletedException;
    }

    /// <inheritdoc />
    public override void OnCreateCriteria(ICriteria criteria, IEntityFilter filter)
    {
      int num1 = 3;
      ITransformationProvider service;
      System.Type type;
      while (true)
      {
        switch (num1)
        {
          case 1:
            service = Locator.GetService<ITransformationProvider>();
            num1 = 9;
            continue;
          case 2:
            type = (System.Type) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 11 : 9;
            continue;
          case 3:
            if (!SoftDeletableManagerBehavior.G0VFDEhGsp3kaptSPeuA((object) this.RunWithSoftDeletableService))
            {
              num1 = 2;
              continue;
            }
            goto label_15;
          case 4:
            goto label_11;
          case 5:
            SoftDeletableManagerBehavior.mlqDGWhEGlhEIbNLJDDN((object) criteria, (object) Restrictions.EqProperty(Projections.SqlFunction((string) SoftDeletableManagerBehavior.LTNECahEosRNTUFmKobM((object) service.Dialect), (IType) NHibernateUtil.Boolean, (IProjection) SoftDeletableManagerBehavior.rwbKdehEbepLyl9VDT9Q(SoftDeletableManagerBehavior.hd2RX9hGjAFp7kQemDMM(--1360331293 ^ 1360481015)), (IProjection) SoftDeletableManagerBehavior.svYXjNhEhExaHabZYriu((object) 0)), Projections.Constant((object) 0)));
            num1 = 10;
            continue;
          case 6:
            goto label_31;
          case 7:
            goto label_5;
          case 8:
            SoftDeletableManagerBehavior.mlqDGWhEGlhEIbNLJDDN((object) criteria, SoftDeletableManagerBehavior.UkTX2FhECG1Xujy3PypQ(SoftDeletableManagerBehavior.pepbixhEEQkNI0dLx2Tt(SoftDeletableManagerBehavior.hd2RX9hGjAFp7kQemDMM(-1886646897 ^ -1886501531)), SoftDeletableManagerBehavior.TJif9whEQOp7EXKBkRLm(SoftDeletableManagerBehavior.jEToSxhEfCwNH0vuPyJm(SoftDeletableManagerBehavior.hd2RX9hGjAFp7kQemDMM(-2099751081 ^ -2099634243), (object) true))));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 13 : 3;
            continue;
          case 9:
            if (service == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 6 : 8;
              continue;
            }
            goto case 5;
          case 10:
            goto label_9;
          case 11:
            try
            {
              type = criteria.GetRootEntityTypeIfAvailable();
              int num2 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
                num2 = 0;
              switch (num2)
              {
                default:
                  goto label_19;
              }
            }
            catch (HibernateException ex)
            {
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
                num3 = 1;
              while (true)
              {
                switch (num3)
                {
                  case 0:
                    goto label_29;
                  case 1:
                    SoftDeletableManagerBehavior.MVOt3nhEFwaPCdqXBFCN(SoftDeletableManagerBehavior.E3mlIZhGckZBnSKP64Zf(), SoftDeletableManagerBehavior.epgRmPhGzMqOSHKbbx1U((object) ex), (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_25;
                }
              }
label_29:
              return;
label_25:
              return;
            }
          case 12:
label_19:
            if (!SoftDeletableManagerBehavior.U8OZFChEBLGMsxYiLDOp(type.GetInterface(typeof (ISoftDeletable).FullName), (System.Type) null))
            {
              if (filter != null)
              {
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            }
            else
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 3 : 6;
              continue;
            }
          case 13:
            goto label_2;
          default:
            if (!SoftDeletableManagerBehavior.wfFlAShEWwmbyicwU9mb((object) filter))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
              continue;
            }
            goto label_24;
        }
      }
label_11:
      return;
label_31:
      return;
label_5:
      return;
label_9:
      return;
label_2:
      return;
label_15:
      return;
label_24:;
    }

    public SoftDeletableManagerBehavior()
    {
      SoftDeletableManagerBehavior.aCZ1AChEvEDfC5u08ShL();
      this.cacheInstanceSettings = new ConcurrentDictionary<System.Type, bool>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool o3J1nqhG9yn7ATvGmmvi() => SoftDeletableManagerBehavior.tBLDbnhGJxi6RJcN4l0F == null;

    internal static SoftDeletableManagerBehavior v47WEohGdLWR0UcZGnEH() => SoftDeletableManagerBehavior.tBLDbnhGJxi6RJcN4l0F;

    internal static System.Type Fu31DchGl2BFkAG7S3Fo([In] object obj0) => EntityHelper.GetType(obj0);

    internal static object wO6wY0hGr2hqUi9qU7sf([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static bool AAKfBfhGgcw0FB0JBOyC([In] object obj0) => ((ISoftDeletable) obj0).IsDeleted;

    internal static object HxQCo6hG5Zk8NcUgftvI() => (object) ComponentManager.Current;

    internal static object hd2RX9hGjAFp7kQemDMM(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void yG49ashGYgMY6xHlGHLP([In] object obj0, [In] object obj1) => ((ObjectIsDeletedException) obj0).ObjectId = obj1;

    internal static Guid BeGr8thGLN9OI83gcAPO([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static void ckKrvRhGUv1RlscCbckp([In] object obj0, Guid value) => ((ObjectIsDeletedException) obj0).ObjectType = value;

    internal static bool G0VFDEhGsp3kaptSPeuA([In] object obj0) => ((RunWithSoftDeletableService) obj0).Turned;

    internal static object E3mlIZhGckZBnSKP64Zf() => (object) Logger.Log;

    internal static object epgRmPhGzMqOSHKbbx1U([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void MVOt3nhEFwaPCdqXBFCN([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool U8OZFChEBLGMsxYiLDOp([In] System.Type obj0, [In] System.Type obj1) => obj0 == obj1;

    internal static bool wfFlAShEWwmbyicwU9mb([In] object obj0) => ((IEntityFilter) obj0).DisableSoftDeletable;

    internal static object LTNECahEosRNTUFmKobM([In] object obj0) => (object) ((Dialect) obj0).GetIsNullFunctionName();

    internal static object rwbKdehEbepLyl9VDT9Q([In] object obj0) => (object) Projections.Property((string) obj0);

    internal static object svYXjNhEhExaHabZYriu([In] object obj0) => (object) Projections.Constant(obj0);

    internal static object mlqDGWhEGlhEIbNLJDDN([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static object pepbixhEEQkNI0dLx2Tt([In] object obj0) => (object) Restrictions.IsNull((string) obj0);

    internal static object jEToSxhEfCwNH0vuPyJm([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object TJif9whEQOp7EXKBkRLm([In] object obj0) => (object) Restrictions.Not((ICriterion) obj0);

    internal static object UkTX2FhECG1Xujy3PypQ([In] object obj0, [In] object obj1) => (object) Restrictions.Or((ICriterion) obj0, (ICriterion) obj1);

    internal static void aCZ1AChEvEDfC5u08ShL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

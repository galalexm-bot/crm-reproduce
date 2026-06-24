// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Audit.EntityAuditActionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Events.Audit
{
  /// <summary>
  /// Провайдер предоставляет информацию о действиях с сущностью
  /// </summary>
  [Component]
  public class EntityAuditActionProvider : IAuditActionProvider
  {
    private IMetadataRuntimeService metadataRuntimeService;
    private readonly Func<Guid, IEnumerable<IAuditAction>> getObjectActionsCached;
    private static EnumMetadata defaultActions;
    internal static EntityAuditActionProvider oif5ZGoBsfNiUCn21EgR;

    public EntityAuditActionProvider(IMetadataRuntimeService metadataService)
    {
      EntityAuditActionProvider.PSGweUoWFV6l4dtjtKwm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.metadataRuntimeService = metadataService;
            num = 2;
            continue;
          case 2:
            ParameterExpression parameterExpression = (ParameterExpression) EntityAuditActionProvider.L0phiNoWWR29VWN6sItQ(typeof (Guid), EntityAuditActionProvider.KnnEGsoWBeKDWfdexuYc(--1333735954 ^ 1333719492));
            // ISSUE: type reference
            // ISSUE: method reference
            this.getObjectActionsCached = MetadataLoader.UseCachingForFunc<Guid, IEnumerable<IAuditAction>>(Expression.Lambda<Func<Guid, IEnumerable<IAuditAction>>>((Expression) EntityAuditActionProvider.LCNoSioWhuvcZqH9AJT2(EntityAuditActionProvider.FWHdhaoWblo7CkUHI06s((object) this, EntityAuditActionProvider.pBJdjvoWo7AW14D68wEC(__typeref (EntityAuditActionProvider))), (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (EntityAuditActionProvider.GetObjectActions)), (object) new Expression[1]
            {
              (Expression) parameterExpression
            }), parameterExpression));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>
    /// Идентификатор объекта. Если не задан - функции поиска действий будет вызываться для всех объектов.
    /// </summary>
    public Guid? ObjectUid => new Guid?();

    /// <summary>Получить список действий объекта</summary>
    /// <param name="obj">Объект</param>
    /// <returns>Список действий объекта</returns>
    public IEnumerable<IAuditAction> GetActions(IAuditObject obj) => obj == null || obj.Type == null || obj.Type.Uid != EntityAuditObjectType.UID ? (IEnumerable<IAuditAction>) null : this.getObjectActionsCached(obj.Uid);

    /// <summary>
    /// Получить действие объекта по уникальному идентификатору
    /// </summary>
    /// <param name="obj">Объект</param>
    /// <param name="uid">Уникальный идентификатор объекта</param>
    /// <returns>Действие. Если не найдено - null</returns>
    public IAuditAction GetAction(IAuditObject obj, Guid uid)
    {
      int num = 4;
      IEnumerable<IAuditAction> actions;
      Guid uid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (actions != null)
            {
              num = 6;
              continue;
            }
            goto label_10;
          case 2:
            if (obj != null)
            {
              num = 5;
              continue;
            }
            goto label_14;
          case 3:
            uid1 = uid;
            num = 2;
            continue;
          case 4:
            num = 3;
            continue;
          case 5:
            if (obj.Type == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 5 : 7;
              continue;
            }
            goto case 10;
          case 6:
            goto label_11;
          case 8:
            actions = this.GetActions(obj);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 1 : 0;
            continue;
          case 9:
            goto label_10;
          case 10:
            if (!EntityAuditActionProvider.NgNEJPoWfumrRXimtjbN(EntityAuditActionProvider.b9iNnJoWEZHRV3RMSdFp(EntityAuditActionProvider.XdZCNnoWGIXueKNNaTrp((object) obj)), EntityAuditObjectType.UID))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 8 : 1;
              continue;
            }
            goto label_14;
          default:
            goto label_14;
        }
      }
label_10:
      return (IAuditAction) null;
label_11:
      return actions.FirstOrDefault<IAuditAction>((Func<IAuditAction, bool>) (a => a.Uid == uid1));
label_14:
      return (IAuditAction) null;
    }

    /// <summary>Стандартные действия с сущностью</summary>
    internal static EnumMetadata DefaultActions
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (EntityAuditActionProvider.defaultActions != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              EntityAuditActionProvider.defaultActions = (EnumMetadata) new EntityActionsMetadata();
              num = 3;
              continue;
            case 3:
              EntityAuditActionProvider.defaultActions.LoadFromType(EntityAuditActionProvider.pBJdjvoWo7AW14D68wEC(__typeref (DefaultEntityActions)), true);
              num = 4;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        return EntityAuditActionProvider.defaultActions;
      }
    }

    private void InitActionsForObject()
    {
    }

    private IEnumerable<IAuditAction> GetObjectActions(Guid objUid)
    {
      List<IAuditAction> actions = new List<IAuditAction>();
      if (this.metadataRuntimeService.GetMetadata(objUid, false) is EntityMetadata metadata2)
      {
        if (metadata2.Type == EntityMetadataType.InterfaceImplementation)
        {
          if (this.metadataRuntimeService.GetMetadata(metadata2.ImplementationUid, false) is EntityMetadata metadata1)
            EntityAuditActionProvider.GetEntityMetadataActions((object) metadata1, actions);
        }
        else if (metadata2.Type == EntityMetadataType.Entity)
          EntityAuditActionProvider.GetEntityMetadataActions((object) metadata2, actions);
      }
      return (IEnumerable<IAuditAction>) actions;
    }

    private static EnumValueMetadata GetDefaultLocalizedMetadata(Guid valueUid)
    {
      int num = 2;
      Guid valueUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueUid1 = valueUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      // ISSUE: reference to a compiler-generated method
      return ((EnumMetadata) EntityAuditActionProvider.tXLBfPoWQ1Um6xdZRSiC()).Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EntityAuditActionProvider.\u003C\u003Ec__DisplayClass12_0.rtNXoSCoQRBqaxne7vO1((object) v) == valueUid1));
    }

    private static EnumValueMetadata GetLocalizedMetadata(Type metadataType, Guid valueUid)
    {
      int num = 2;
      EntityMetadata entityMetadata;
      Guid valueUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            valueUid1 = valueUid;
            num = 4;
            continue;
          case 2:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
            continue;
          case 3:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 4:
            entityMetadata = (EntityMetadata) MetadataLoader.LoadMetadata(metadataType, loadImplementation: false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 3 : 3;
            continue;
          case 5:
            goto label_6;
          default:
            if (entityMetadata.Actions == null)
            {
              num = 5;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      return (EnumValueMetadata) null;
label_7:
      // ISSUE: reference to a compiler-generated method
      return ((EnumMetadata) EntityAuditActionProvider.wGBFwtoWCihQ4Du88upn((object) entityMetadata)).Values.FirstOrDefault<EnumValueMetadata>((Func<EnumValueMetadata, bool>) (v => EntityAuditActionProvider.\u003C\u003Ec__DisplayClass13_0.ujchEbCouoSFkkLID7Lr(v.Uid, valueUid1)));
    }

    private static void GetEntityMetadataActions(object metadata, List<IAuditAction> actions)
    {
      Contract.ArgumentNotNull(metadata, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132930561));
      IMetadataRuntimeService serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
      switch (((EntityMetadata) metadata).Type)
      {
        case EntityMetadataType.Entity:
        case EntityMetadataType.Interface:
        case EntityMetadataType.InterfaceImplementation:
          if (((ClassMetadata) metadata).BaseClassUid != Guid.Empty)
          {
            if (serviceNotNull.GetMetadata(((ClassMetadata) metadata).BaseClassUid, false) is EntityMetadata metadata1 && metadata1.Actions != null)
            {
              EntityAuditActionProvider.GetEntityMetadataActions((object) metadata1, actions);
              break;
            }
            break;
          }
          using (List<EnumValueMetadata>.Enumerator enumerator = EntityAuditActionProvider.DefaultActions.Values.GetEnumerator())
          {
            while (enumerator.MoveNext())
            {
              EnumValueMetadata current = enumerator.Current;
              // ISSUE: reference to a compiler-generated method
              EntityAuditAction entityAuditAction = new EntityAuditAction(current.Uid, current.Name, (Func<EntityAuditAction, EnumValueMetadata>) (a => EntityAuditActionProvider.GetDefaultLocalizedMetadata(EntityAuditActionProvider.\u003C\u003Ec.ShRLgECone60roKR8bE9((object) a))), current.DefaultImage);
              actions.Add((IAuditAction) entityAuditAction);
            }
            break;
          }
      }
      Type metadataType = serviceNotNull.GetTypeByUid(((AbstractMetadata) metadata).Uid, false);
      if (metadataType == (Type) null)
        return;
      foreach (EnumValueMetadata enumValueMetadata in ((EntityMetadata) metadata).Actions.Values)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        EntityAuditAction entityAuditAction = new EntityAuditAction(enumValueMetadata.Uid, enumValueMetadata.Name, (Func<EntityAuditAction, EnumValueMetadata>) (a => (EnumValueMetadata) EntityAuditActionProvider.\u003C\u003Ec__DisplayClass14_0.uQWHnmCoqd2CeoYmIXc8(metadataType, EntityAuditActionProvider.\u003C\u003Ec__DisplayClass14_0.efk9pjCoREct27rsnd6B((object) a))), enumValueMetadata.DefaultImage);
        actions.Add((IAuditAction) entityAuditAction);
      }
      if (((EntityMetadata) metadata).Type != EntityMetadataType.Interface || !(serviceNotNull.GetMetadata(((EntityMetadata) metadata).ImplementationUid, false) is EntityMetadata metadata2) || metadata2.ImplementedExtensionUids == null)
        return;
      foreach (Guid implementedExtensionUid in metadata2.ImplementedExtensionUids)
      {
        EntityMetadata metadata3 = (EntityMetadata) serviceNotNull.GetMetadata(implementedExtensionUid, false);
        if (metadata3 != null)
          EntityAuditActionProvider.GetEntityMetadataActions((object) metadata3, actions);
      }
    }

    internal static void PSGweUoWFV6l4dtjtKwm() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object KnnEGsoWBeKDWfdexuYc(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L0phiNoWWR29VWN6sItQ([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static Type pBJdjvoWo7AW14D68wEC([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object FWHdhaoWblo7CkUHI06s([In] object obj0, [In] Type obj1) => (object) Expression.Constant(obj0, obj1);

    internal static object LCNoSioWhuvcZqH9AJT2([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);

    internal static bool fLjQaUoBcwcmahIqDCBm() => EntityAuditActionProvider.oif5ZGoBsfNiUCn21EgR == null;

    internal static EntityAuditActionProvider uHedcooBzOBvarIfiGQC() => EntityAuditActionProvider.oif5ZGoBsfNiUCn21EgR;

    internal static object XdZCNnoWGIXueKNNaTrp([In] object obj0) => (object) ((IAuditObject) obj0).Type;

    internal static Guid b9iNnJoWEZHRV3RMSdFp([In] object obj0) => ((IAuditObjectType) obj0).Uid;

    internal static bool NgNEJPoWfumrRXimtjbN([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object tXLBfPoWQ1Um6xdZRSiC() => (object) EntityAuditActionProvider.DefaultActions;

    internal static object wGBFwtoWCihQ4Du88upn([In] object obj0) => (object) ((EntityMetadata) obj0).Actions;
  }
}

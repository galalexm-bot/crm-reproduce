// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Settings.Managers.TypeSettingsInstanceStoreManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Cache;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Settings.Managers
{
  /// <summary>Менеджер хранилища настроек экземпляров сущностей</summary>
  public class TypeSettingsInstanceStoreManager : EntityManager<ITypeSettingsInstanceStore, long>
  {
    internal static TypeSettingsInstanceStoreManager IjYu36bWz9fvF7MNaQun;

    /// <summary>Экземпляр данного менеджера</summary>
    public static TypeSettingsInstanceStoreManager Instance => Locator.GetServiceNotNull<TypeSettingsInstanceStoreManager>();

    /// <summary>
    /// Загрузить хранилище настроек для указанной сущности. В данном методе применяется кэширование
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="createIfNotExists">Создавать ли хранилище, если оно не существует</param>
    /// <param name="loadIfNotLoaded">Загружать, если не были загружены</param>
    /// <returns></returns>
    public ITypeSettingsInstanceStore Load(
      IEntity entity,
      bool createIfNotExists,
      bool loadIfNotLoaded)
    {
      int num = 10;
      ITypeSettingsInstanceStore result;
      while (true)
      {
        string str;
        ClassMetadata classMetadata;
        switch (num)
        {
          case 1:
            ContextVars.Set<ITypeSettingsInstanceStore>(str, result);
            num = 13;
            continue;
          case 2:
            result = InterfaceActivator.Create<ITypeSettingsInstanceStore>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 17 : 17;
            continue;
          case 3:
            ((IMemoryCacheService) TypeSettingsInstanceStoreManager.rm2G5tboWAlyAFjMi445((object) this)).TryGetValue<ITypeSettingsInstanceStore>(str, out result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
            continue;
          case 4:
            if (!ContextVars.TryGetValue<ITypeSettingsInstanceStore>(str, out result))
            {
              num = 14;
              continue;
            }
            break;
          case 5:
            goto label_12;
          case 7:
            if (!this.IsNewEntity(entity))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 6 : 8;
              continue;
            }
            break;
          case 8:
            result = this.LoadOrNull(TypeSettingsInstanceStoreManager.z0B6PVbooLAEdnspr3A6((object) classMetadata), TypeSettingsInstanceStoreManager.KjjP62bobOZcm2htrZV5((object) entity));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 1;
            continue;
          case 9:
            str = this.TypeSettingsInstanceStoreCacheKey(entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 16 : 16;
            continue;
          case 10:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entity.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 9 : 5;
            continue;
          case 11:
            ContextVars.Set<ITypeSettingsInstanceStore>(str, result);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 4 : 5;
            continue;
          case 12:
            TypeSettingsInstanceStoreManager.CghYEIboGeXXqaD1SqRG((object) result, (object) TypeSettingsInstanceStoreManager.KjjP62bobOZcm2htrZV5((object) entity).ToString());
            num = 15;
            continue;
          case 14:
            if (!(loadIfNotLoaded | createIfNotExists))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 6 : 1;
              continue;
            }
            goto case 7;
          case 15:
            TypeSettingsInstanceStoreManager.fS3ecSboEIkZaTSxI5oY((object) result, (object) new TypeSettingsInstanceData());
            num = 11;
            continue;
          case 16:
            result = (ITypeSettingsInstanceStore) null;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 17 : 18;
            continue;
          case 17:
            TypeSettingsInstanceStoreManager.qmasB5boh499Uex2UihR((object) result, classMetadata.Uid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 12 : 8;
            continue;
          case 18:
            if (this.IsNewEntity(entity))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 3 : 3;
              continue;
            }
            goto case 4;
        }
        if (result == null & createIfNotExists)
          num = 2;
        else
          break;
      }
label_12:
      return result;
    }

    /// <summary>Сохранить хранилище настроек экземпляра сущности</summary>
    /// <param name="entity">Экземпляр сущности</param>
    /// <param name="settingsStore">Хранилище настроек</param>
    public virtual void Save(IEntity entity, ITypeSettingsInstanceStore settingsStore)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        string key;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_9;
            case 1:
              goto label_8;
            case 2:
            case 7:
              this.AddToPending(entity, settingsStore);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
              continue;
            case 3:
              goto label_7;
            case 4:
              this.Save(settingsStore);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 1;
              continue;
            case 5:
              if (this.IsNewEntity((IEntity) settingsStore))
                break;
              goto label_5;
            case 6:
              if (!this.IsNewEntity(entity))
              {
                num2 = 5;
                continue;
              }
              break;
            case 8:
label_11:
              key = this.TypeSettingsInstanceStoreCacheKey(entity);
              num2 = 3;
              continue;
            default:
              goto label_3;
          }
          if (!this.IsNewEntity(entity))
            num2 = 2;
          else
            goto label_11;
        }
label_5:
        num1 = 4;
        continue;
label_7:
        ((IMemoryCacheService) TypeSettingsInstanceStoreManager.rm2G5tboWAlyAFjMi445((object) this)).Insert<ITypeSettingsInstanceStore>(key, settingsStore);
        num1 = 7;
      }
label_9:
      return;
label_8:
      return;
label_3:;
    }

    /// <summary>Сохранить хранилища настроек, которые</summary>
    internal void SavePending()
    {
      int num1 = 1;
      List<Tuple<IEntity, ITypeSettingsInstanceStore>>.Enumerator enumerator;
      List<object> revertEntities;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Locator.GetServiceNotNull<IUnitOfWorkManager>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            goto label_25;
          default:
            List<Tuple<IEntity, ITypeSettingsInstanceStore>> pending = this.GetPending();
            revertEntities = NHUnitOfWorkManager.GetRevertEntities("");
            enumerator = pending.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 2;
            continue;
        }
      }
label_25:
      return;
label_3:
      try
      {
label_13:
        if (enumerator.MoveNext())
          goto label_5;
        else
          goto label_14;
label_4:
        Tuple<IEntity, ITypeSettingsInstanceStore> current;
        IEnumerable<IEntity> containedEntities;
        int num2;
        List<IEntity> allItemEntities;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Save(current.Item2);
              num2 = 4;
              continue;
            case 2:
            case 4:
            case 11:
              goto label_13;
            case 3:
              goto label_21;
            case 5:
            case 6:
              if (this.IsNewEntity(current.Item1))
              {
                num2 = 11;
                continue;
              }
              goto case 13;
            case 7:
              goto label_5;
            case 8:
              allItemEntities = new List<IEntity>();
              num2 = 12;
              continue;
            case 9:
              if (containedEntities == null)
              {
                num2 = 6;
                continue;
              }
              goto case 10;
            case 10:
              allItemEntities.AddRange(containedEntities);
              num2 = 5;
              continue;
            case 12:
              allItemEntities.Add(current.Item1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
              continue;
            case 13:
              if (revertEntities.Any<object>((Func<object, bool>) (e => ((IEnumerable<object>) allItemEntities).Contains<object>(e))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 2 : 1;
                continue;
              }
              goto case 15;
            case 14:
              num2 = 8;
              continue;
            case 15:
              TypeSettingsInstanceStoreManager.CghYEIboGeXXqaD1SqRG((object) current.Item2, (object) TypeSettingsInstanceStoreManager.KjjP62bobOZcm2htrZV5((object) current.Item1).ToString());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 1 : 1;
              continue;
            default:
              containedEntities = current.Item1.GetContainedEntities();
              num2 = 9;
              continue;
          }
        }
label_21:
        return;
label_5:
        current = enumerator.Current;
        num2 = 14;
        goto label_4;
label_14:
        num2 = 3;
        goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    private string TypeSettingsInstanceStoreCacheKey(IEntity entity)
    {
      int num = 9;
      string str;
      ClassMetadata classMetadata;
      while (true)
      {
        PropertyInfo propertyInfo;
        Guid guid;
        int hashCode;
        Guid empty;
        switch (num)
        {
          case 1:
          case 4:
            empty = Guid.Empty;
            break;
          case 2:
            empty = (Guid) propertyInfo.GetValue((object) entity, (object[]) null);
            break;
          case 3:
          case 12:
            goto label_7;
          case 5:
            if (guid != Guid.Empty)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
              continue;
            }
            goto case 10;
          case 6:
            str = hashCode.ToString();
            num = 3;
            continue;
          case 7:
            if (!TypeSettingsInstanceStoreManager.rfbj7ZboCSreJHh1SiVy((object) propertyInfo, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            }
            goto case 11;
          case 8:
            propertyInfo = (PropertyInfo) TypeSettingsInstanceStoreManager.ADYrupboQx6cUw34e9B4(entity.GetType(), TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(322893104 - -1992822529 ^ -1979225181));
            num = 7;
            continue;
          case 9:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entity.GetType());
            num = 8;
            continue;
          case 10:
            hashCode = entity.GetHashCode();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 6 : 2;
            continue;
          case 11:
            // ISSUE: type reference
            if (TypeSettingsInstanceStoreManager.yirrGTboZb3y58eUJvRj(TypeSettingsInstanceStoreManager.bGG6Yqbovv8mwCZ18F3v((object) propertyInfo), TypeSettingsInstanceStoreManager.HynNLEbo8yDPPeCvTP9W(__typeref (Guid))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 2;
              continue;
            }
            goto case 1;
          default:
            str = guid.ToString();
            num = 12;
            continue;
        }
        guid = empty;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 5 : 0;
      }
label_7:
      return TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(1242972401 >> 4 ^ 77845565).ToString() + (object) TypeSettingsInstanceStoreManager.z0B6PVbooLAEdnspr3A6((object) classMetadata) + TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(1917998801 >> 2 ^ 479517290) + str;
    }

    private ITypeSettingsInstanceStore LoadOrNull(Guid objectTypeUid, object objectId)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (objectId != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 2:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      throw new ArgumentNullException((string) TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(1581325282 << 3 ^ -234197094));
label_3:
      return ((ICriteria) TypeSettingsInstanceStoreManager.s4f4VBboIAhvLOWioyIE(TypeSettingsInstanceStoreManager.s4f4VBboIAhvLOWioyIE((object) this.CreateCriteria(), TypeSettingsInstanceStoreManager.KVNMaXbouBqu8O94Y67i(TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(372753449 ^ 372602039), (object) objectTypeUid)), TypeSettingsInstanceStoreManager.KVNMaXbouBqu8O94Y67i(TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(-477139494 ^ -477242010), (object) objectId.ToString()))).List<ITypeSettingsInstanceStore>().FirstOrDefault<ITypeSettingsInstanceStore>();
    }

    private List<Tuple<IEntity, ITypeSettingsInstanceStore>> GetPending() => ContextVars.GetOrAdd<List<Tuple<IEntity, ITypeSettingsInstanceStore>>>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1925118608 << 2 ^ -889628016), (Func<List<Tuple<IEntity, ITypeSettingsInstanceStore>>>) (() => new List<Tuple<IEntity, ITypeSettingsInstanceStore>>()));

    private void AddToPending(IEntity entity, ITypeSettingsInstanceStore settingsStore)
    {
      int num = 2;
      List<Tuple<IEntity, ITypeSettingsInstanceStore>> pending;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            pending.Add(new Tuple<IEntity, ITypeSettingsInstanceStore>(entity, settingsStore));
            num = 3;
            continue;
          case 2:
            pending = this.GetPending();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
          case 3:
            ContextVars.Set<List<Tuple<IEntity, ITypeSettingsInstanceStore>>>((string) TypeSettingsInstanceStoreManager.txRRY1bofdxkEbIF0G9V(1021410165 ^ 1021561765), pending);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    private bool IsNewEntity(IEntity entity)
    {
      int num = 2;
      IEntityManager entityManagerOrNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entityManagerOrNull == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            entityManagerOrNull = ModelHelper.GetEntityManagerOrNull(entity.GetType());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return true;
label_3:
      return TypeSettingsInstanceStoreManager.sYuNVMboVjeTOY1aSCUQ((object) entityManagerOrNull, (object) entity);
    }

    public TypeSettingsInstanceStoreManager()
    {
      TypeSettingsInstanceStoreManager.ffEcauboSiyw0tMlcD3a();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rm2G5tboWAlyAFjMi445([In] object obj0) => (object) ((EntityManager<ITypeSettingsInstanceStore, long>) obj0).MemoryCacheService;

    internal static Guid z0B6PVbooLAEdnspr3A6([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object KjjP62bobOZcm2htrZV5([In] object obj0) => ((IIdentified) obj0).GetId();

    internal static void qmasB5boh499Uex2UihR([In] object obj0, Guid value) => ((ITypeSettingsInstanceStore) obj0).ObjectTypeUid = value;

    internal static void CghYEIboGeXXqaD1SqRG([In] object obj0, [In] object obj1) => ((ITypeSettingsInstanceStore) obj0).ObjectId = (string) obj1;

    internal static void fS3ecSboEIkZaTSxI5oY([In] object obj0, [In] object obj1) => ((ITypeSettingsInstanceStore) obj0).Settings = (TypeSettingsInstanceData) obj1;

    internal static bool A6MVRCboFfhk8rTxgugT() => TypeSettingsInstanceStoreManager.IjYu36bWz9fvF7MNaQun == null;

    internal static TypeSettingsInstanceStoreManager rxvvOmboBjWUt9Qw324j() => TypeSettingsInstanceStoreManager.IjYu36bWz9fvF7MNaQun;

    internal static object txRRY1bofdxkEbIF0G9V(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ADYrupboQx6cUw34e9B4(Type type, [In] object obj1) => (object) type.GetReflectionProperty((string) obj1);

    internal static bool rfbj7ZboCSreJHh1SiVy([In] object obj0, [In] object obj1) => (PropertyInfo) obj0 != (PropertyInfo) obj1;

    internal static Type bGG6Yqbovv8mwCZ18F3v([In] object obj0) => ((PropertyInfo) obj0).PropertyType;

    internal static Type HynNLEbo8yDPPeCvTP9W([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool yirrGTboZb3y58eUJvRj([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object KVNMaXbouBqu8O94Y67i([In] object obj0, [In] object obj1) => (object) Restrictions.Eq((string) obj0, obj1);

    internal static object s4f4VBboIAhvLOWioyIE([In] object obj0, [In] object obj1) => (object) ((ICriteria) obj0).Add((ICriterion) obj1);

    internal static bool sYuNVMboVjeTOY1aSCUQ([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).IsNew(obj1);

    internal static void ffEcauboSiyw0tMlcD3a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

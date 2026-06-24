// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.TypedDynamicEntityManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Remoting;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  public class TypedDynamicEntityManager : EternalRefObject
  {
    private Type type;
    private EntityMetadata metadata;
    private IEntityManager manager;
    internal static TypedDynamicEntityManager MH3oFohQcxYbMmHsg8he;

    /// <summary>Конструктор</summary>
    /// <param name="typeUid">Уникальный идентификатор типа сущности (объекта метаданных)</param>
    public TypedDynamicEntityManager(Guid typeUid)
    {
      TypedDynamicEntityManager.rPAydZhCBXyvUuDM7nd8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      IMetadataRuntimeService serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 3;
            continue;
          case 3:
            this.type = serviceNotNull.GetTypeByUid(typeUid);
            num = 4;
            continue;
          case 4:
            if (TypedDynamicEntityManager.X12VVbhCWGstyPnRb3jr(this.type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            }
            this.metadata = MetadataLoader.LoadMetadata(this.type) as EntityMetadata;
            num = 5;
            continue;
          case 5:
            if (this.metadata == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
              continue;
            }
            this.manager = ModelHelper.GetEntityManager(this.type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 6 : 6;
            continue;
          case 6:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      throw new Exception((string) TypedDynamicEntityManager.S3vhx1hCoL0GWUaoxl5Y(TypedDynamicEntityManager.QPT2O4hCbKWiBw3sUNP6(-951514650 ^ -951435640), (object) typeUid));
label_11:
      throw new Exception((string) TypedDynamicEntityManager.S3vhx1hCoL0GWUaoxl5Y((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 45077581), (object) typeUid));
    }

    /// <summary>Создать новую сущность</summary>
    /// <returns>Созданная сущность</returns>
    public virtual DynamicEntity New()
    {
      int num = 1;
      object instance;
      while (true)
      {
        switch (num)
        {
          case 1:
            instance = Activator.CreateInstance(this.type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return new DynamicEntity(this.metadata, instance);
    }

    /// <summary>Загрузить сущность</summary>
    /// <param name="id">Идентификатор сущности</param>
    /// <param name="propertyUids">Массив идентификаторов свойств, которые нужно подгружать</param>
    /// <returns>Сущность</returns>
    public virtual DynamicEntity Load(object id, Guid[] propertyUids = null)
    {
      int num = 1;
      object entity;
      while (true)
      {
        switch (num)
        {
          case 1:
            entity = TypedDynamicEntityManager.KS7rllhChbiuGsnRlDJ0((object) this.manager, id);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return new DynamicEntity(this.metadata, entity);
    }

    /// <summary>Сохранить сущность</summary>
    /// <param name="entity">Сущность</param>
    /// <returns>Идентификатор сущности</returns>
    public virtual object Save(DynamicEntity entity)
    {
      int num1 = 8;
      object obj1;
      while (true)
      {
        int num2 = num1;
        object obj2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              TypedDynamicEntityManager.\u003C\u003Eo__6.\u003C\u003Ep__0 = CallSite<Func<CallSite, object, object>>.Create(Binder.GetMember(CSharpBinderFlags.None, z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813571727), typeof (TypedDynamicEntityManager), (IEnumerable<CSharpArgumentInfo>) new CSharpArgumentInfo[1]
              {
                (CSharpArgumentInfo) TypedDynamicEntityManager.OwQoHshCvOOrCkb4BY8m(CSharpArgumentInfoFlags.None, (object) null)
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
              continue;
            case 3:
              goto label_9;
            case 4:
              if (obj1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 6 : 0;
                continue;
              }
              goto case 9;
            case 5:
              // ISSUE: reference to a compiler-generated field
              if (TypedDynamicEntityManager.\u003C\u003Eo__6.\u003C\u003Ep__0 == null)
                goto case 1;
              else
                goto label_6;
            case 6:
            case 10:
              TypedDynamicEntityManager.FrjscahCQHkkYlFbcrSI((object) entity, (object) this.metadata, obj1);
              num2 = 3;
              continue;
            case 7:
              obj1 = TypedDynamicEntityManager.J59fAahCEMR7VYIto7K4((object) this.manager, obj2);
              num2 = 4;
              continue;
            case 8:
              obj2 = TypedDynamicEntityManager.Ko6yvEhCGMJjAfYlyvWW((object) entity);
              num2 = 7;
              continue;
            case 9:
              obj1 = TypedDynamicEntityManager.hU7lIGhCf1tIBSslHjmJ(this.type);
              num2 = 10;
              continue;
            default:
              goto label_7;
          }
        }
label_6:
        num1 = 2;
        continue;
label_9:
        TypedDynamicEntityManager.r78nVChCClB6A2cYsPE5((object) this.manager, obj1);
        num1 = 5;
      }
label_7:
      // ISSUE: reference to a compiler-generated field
      // ISSUE: reference to a compiler-generated field
      return TypedDynamicEntityManager.\u003C\u003Eo__6.\u003C\u003Ep__0.Target((CallSite) TypedDynamicEntityManager.\u003C\u003Eo__6.\u003C\u003Ep__0, obj1);
    }

    /// <summary>Удалить сущность</summary>
    /// <param name="entity">Сущность</param>
    /// <returns>Идентификатор сущности</returns>
    public virtual void Delete(DynamicEntity entity)
    {
      int num = 2;
      object obj1;
      object obj2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            obj2 = TypedDynamicEntityManager.J59fAahCEMR7VYIto7K4((object) this.manager, obj1);
            num = 3;
            continue;
          case 2:
            obj1 = TypedDynamicEntityManager.Ko6yvEhCGMJjAfYlyvWW((object) entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
          case 3:
            if (obj2 == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
          case 4:
            TypedDynamicEntityManager.xjucKihC8iB6iKCLIyFA((object) this.manager, obj2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            goto label_9;
        }
      }
label_8:
      return;
label_2:
      return;
label_9:;
    }

    /// <summary>Найти все сущности</summary>
    /// <returns>Список сущностей</returns>
    public virtual ICollection<DynamicEntity> FindAll()
    {
      IEnumerable all1 = this.manager.FindAll();
      List<DynamicEntity> all2 = new List<DynamicEntity>();
      foreach (object entity in all1)
        all2.Add(new DynamicEntity(this.metadata, entity));
      return (ICollection<DynamicEntity>) all2;
    }

    internal static void rPAydZhCBXyvUuDM7nd8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool X12VVbhCWGstyPnRb3jr([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object S3vhx1hCoL0GWUaoxl5Y([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object QPT2O4hCbKWiBw3sUNP6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool QeurvQhQzvC8DSZb6dqf() => TypedDynamicEntityManager.MH3oFohQcxYbMmHsg8he == null;

    internal static TypedDynamicEntityManager ISFitNhCFJlWoDUSmQWa() => TypedDynamicEntityManager.MH3oFohQcxYbMmHsg8he;

    internal static object KS7rllhChbiuGsnRlDJ0([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Load(obj1);

    internal static object Ko6yvEhCGMJjAfYlyvWW([In] object obj0) => ((DynamicEntity) obj0).Id;

    internal static object J59fAahCEMR7VYIto7K4([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).LoadOrNull(obj1);

    internal static object hU7lIGhCf1tIBSslHjmJ([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void FrjscahCQHkkYlFbcrSI([In] object obj0, [In] object obj1, [In] object obj2) => ((DynamicEntity) obj0).SaveToEntity((EntityMetadata) obj1, obj2);

    internal static void r78nVChCClB6A2cYsPE5([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Save(obj1);

    internal static object OwQoHshCvOOrCkb4BY8m([In] CSharpArgumentInfoFlags obj0, [In] object obj1) => (object) CSharpArgumentInfo.Create(obj0, (string) obj1);

    internal static void xjucKihC8iB6iKCLIyFA([In] object obj0, [In] object obj1) => ((IEntityManager) obj0).Delete(obj1);
  }
}

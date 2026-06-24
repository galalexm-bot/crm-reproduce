// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Managers.EntityManagerMakerBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Managers
{
  /// <summary>Базовый класс генератора менеджеров сущностей</summary>
  public abstract class EntityManagerMakerBase : IManagerMaker
  {
    private static EntityManagerMakerBase R4RuXthhUAer6xt43dWM;

    /// <summary>Сгенерировать тип менеджера</summary>
    /// <param name="objectType">Тип объекта</param>
    /// <returns>Тип менеджера</returns>
    public virtual Type MakeManager(Type objectType)
    {
      int num = 4;
      Type typeByUid;
      Type idType;
      EntityMetadata entityMetadata;
      IMetadataRuntimeService serviceNotNull;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityManagerMakerBase.Xpdf8GhGFiuyQgnSaLWP((object) entityMetadata) == EntityMetadataType.InterfaceImplementation)
            {
              num = 5;
              continue;
            }
            goto label_3;
          case 2:
            entityMetadata = InterfaceActivator.LoadMetadata(objectType, loadImplementation: false) as EntityMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 3:
            serviceNotNull = Locator.GetServiceNotNull<IMetadataRuntimeService>();
            num = 2;
            continue;
          case 4:
            Contract.ArgumentNotNull((object) objectType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870779611));
            num = 3;
            continue;
          case 5:
            typeByUid = serviceNotNull.GetTypeByUid(EntityManagerMakerBase.aQEmAohGBSLbX45FlF50((object) entityMetadata), false);
            num = 6;
            continue;
          case 6:
            goto label_2;
          case 7:
            if (entityMetadata != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 1 : 1;
              continue;
            }
            goto label_3;
          default:
            idType = EntityManagerMakerBase.S6yMfuhhzG3xj0uUjVbk(objectType);
            num = 7;
            continue;
        }
      }
label_2:
      return EntityManagerMakerBase.C78pXohGWmaj85x8wdqx((object) this, objectType, typeByUid, idType);
label_3:
      return EntityManagerMakerBase.fpolk2hGodCMShlpRMkU((object) this, objectType, idType);
    }

    /// <summary>Создание типа менеджера для реализации сущности</summary>
    /// <param name="objectType">Тип объекта</param>
    /// <param name="intfType">Тип интерфейса объекта</param>
    /// <param name="idType">Тип id объекта</param>
    /// <returns>Тип менеджера</returns>
    protected virtual Type MakeEntityImplManager(Type objectType, Type intfType, Type idType) => EntityManagerMakerBase.gBamwqhGbyqaDNh4u4PZ(__typeref (EntityImplManager<,,>)).MakeGenericType(objectType, intfType, idType);

    /// <summary>Создание типа менеджера для интерфейса сущности</summary>
    /// <param name="objectType">Тип объекта</param>
    /// <param name="idType">Тип id объекта</param>
    /// <returns>Тип менеджера</returns>
    protected virtual Type MakeEntityManager(Type objectType, Type idType) => typeof (EntityManager<,>).MakeGenericType(objectType, idType);

    protected EntityManagerMakerBase()
    {
      EntityManagerMakerBase.Qx2iJuhGhCssB6Rq3sCt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type S6yMfuhhzG3xj0uUjVbk(Type entityType) => ModelHelper.GetEntityIdType(entityType);

    internal static EntityMetadataType Xpdf8GhGFiuyQgnSaLWP([In] object obj0) => ((EntityMetadata) obj0).Type;

    internal static Guid aQEmAohGBSLbX45FlF50([In] object obj0) => ((EntityMetadata) obj0).ImplementationUid;

    internal static Type C78pXohGWmaj85x8wdqx(
      [In] object obj0,
      Type objectType,
      Type intfType,
      Type idType)
    {
      return ((EntityManagerMakerBase) obj0).MakeEntityImplManager(objectType, intfType, idType);
    }

    internal static Type fpolk2hGodCMShlpRMkU([In] object obj0, Type objectType, Type idType) => ((EntityManagerMakerBase) obj0).MakeEntityManager(objectType, idType);

    internal static bool QybAFNhhskCbnQE8eB5m() => EntityManagerMakerBase.R4RuXthhUAer6xt43dWM == null;

    internal static EntityManagerMakerBase YZ7kFOhhco81xhPExGm8() => EntityManagerMakerBase.R4RuXthhUAer6xt43dWM;

    internal static Type gBamwqhGbyqaDNh4u4PZ([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void Qx2iJuhGhCssB6Rq3sCt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

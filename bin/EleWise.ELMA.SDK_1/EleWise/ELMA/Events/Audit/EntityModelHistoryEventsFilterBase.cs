// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.EntityModelHistoryEventsFilterBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Базовый класс для точки расширения, позволяющий отфильтровать сущность перед записью факта изменения
  /// </summary>
  public abstract class EntityModelHistoryEventsFilterBase : IEntityModelHistoryEventsFilter
  {
    private EntityMetadata[] entityMetadatas;
    internal static EntityModelHistoryEventsFilterBase YkEMdFGLNfa5ewuTtO8w;

    /// <summary>Массив типов, которые надо исключить из сохранения</summary>
    protected abstract Type[] ExcludeTypes { get; }

    protected virtual EntityMetadata[] MetadataList
    {
      get
      {
        int num = 2;
        EntityMetadata[] array;
        EntityMetadata[] entityMetadatas;
        while (true)
        {
          switch (num)
          {
            case 1:
              object source1 = EntityModelHistoryEventsFilterBase.f5q0dkGLa5TRtv49goQF((object) this);
              Func<Type, IEnumerable<Type>> func = EntityModelHistoryEventsFilterBase.\u003C\u003Ec.\u003C\u003E9__4_0;
              Func<Type, IEnumerable<Type>> selector;
              if (func == null)
                EntityModelHistoryEventsFilterBase.\u003C\u003Ec.\u003C\u003E9__4_0 = selector = (Func<Type, IEnumerable<Type>>) (t => ComponentManager.Current.GetExtensionPointTypes<IEntity>().Where<Type>(new Func<Type, bool>(t.IsAssignableFrom)));
              else
                goto label_9;
label_7:
              IEnumerable<Type> source2 = ((IEnumerable<Type>) source1).SelectMany<Type, Type>(selector);
              this.entityMetadatas = array = source2.Select<Type, IMetadata>((Func<Type, IMetadata>) (t => MetadataLoader.LoadMetadata(t))).OfType<EntityMetadata>().ToArray<EntityMetadata>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
label_9:
              selector = func;
              goto label_7;
            case 2:
              entityMetadatas = this.entityMetadatas;
              if (entityMetadatas == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 1 : 1;
                continue;
              }
              goto label_3;
            default:
              goto label_8;
          }
        }
label_3:
        return entityMetadatas;
label_8:
        return array;
      }
    }

    bool IEntityModelHistoryEventsFilter.IsSupported(IEntity entity, Guid actionUid)
    {
      int num = 1;
      IEntity entity1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            entity1 = entity;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      return !((IEnumerable<Type>) this.ExcludeTypes).Any<Type>((Func<Type, bool>) (t => t.IsInstanceOfType((object) entity1)));
    }

    bool IEntityModelHistoryEventsFilter.IsSupported(
      Guid typeUid,
      long entityId,
      Guid entityUid,
      Guid actionUid)
    {
      int num1 = 1;
      Guid typeUid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            typeUid1 = typeUid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return ((IEnumerable<EntityMetadata>) EntityModelHistoryEventsFilterBase.QyxnUTGLD8YiiTHhBAov((object) this)).All<EntityMetadata>((Func<EntityMetadata, bool>) (m =>
      {
        int num2 = 1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (EntityModelHistoryEventsFilterBase.\u003C\u003Ec__DisplayClass6_0.tpktq48IEVHck8htrL26(EntityModelHistoryEventsFilterBase.\u003C\u003Ec__DisplayClass6_0.ANy0Yq8IGUWdpBgbvMsj((object) m), typeUid1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return EntityModelHistoryEventsFilterBase.\u003C\u003Ec__DisplayClass6_0.tpktq48IEVHck8htrL26(EntityModelHistoryEventsFilterBase.\u003C\u003Ec__DisplayClass6_0.cXTnHG8IffrNrp6fqoUV((object) m), typeUid1);
label_3:
        return false;
      }));
    }

    protected EntityModelHistoryEventsFilterBase()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object f5q0dkGLa5TRtv49goQF([In] object obj0) => (object) ((EntityModelHistoryEventsFilterBase) obj0).ExcludeTypes;

    internal static bool iTojfwGL3JkoO0qC1Ghl() => EntityModelHistoryEventsFilterBase.YkEMdFGLNfa5ewuTtO8w == null;

    internal static EntityModelHistoryEventsFilterBase l65LXFGLptoGSwDVGvPA() => EntityModelHistoryEventsFilterBase.YkEMdFGLNfa5ewuTtO8w;

    internal static object QyxnUTGLD8YiiTHhBAov([In] object obj0) => (object) ((EntityModelHistoryEventsFilterBase) obj0).MetadataList;
  }
}

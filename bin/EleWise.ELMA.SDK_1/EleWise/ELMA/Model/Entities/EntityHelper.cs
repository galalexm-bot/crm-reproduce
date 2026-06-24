// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.EntityHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Views;
using NHibernate.Proxy;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities
{
  public static class EntityHelper
  {
    private static EntityHelper Cuc4LhhZ9JGW8YqS4uPy;

    public static bool Equals<T>(T obj1, T obj2) where T : IIdentified
    {
      if (object.Equals((object) obj1, (object) obj2))
        return true;
      return (object) obj1 != null && (object) obj2 != null && object.Equals(obj1.GetId(), obj2.GetId());
    }

    /// <summary>Получить тип объекта сущности</summary>
    /// <returns></returns>
    public static Type GetType(object target)
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (EntityHelper.ntax5thZr3BCIrIfmg28(target))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            type = target.GetType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 3 : 3;
            continue;
          case 3:
          case 4:
            goto label_5;
          default:
            type = EntityHelper.qtb9K9hZ5HituavwvYmc(EntityHelper.nRqfeOhZgKFEDGSN46CF((object) (INHibernateProxy) target));
            num = 4;
            continue;
        }
      }
label_5:
      return type;
    }

    /// <summary>Выполнить понижающее приведение типа сущности</summary>
    /// <returns></returns>
    public static T Cast<T, S>(this S source) where S : IEntity => source.IsProxy() ? (T) ((INHibernateProxy) (object) source).HibernateLazyInitializer.GetImplementation() : (T) (object) source;

    /// <summary>Получить тип объекта сущности</summary>
    /// <returns></returns>
    public static IEntityManager GetEntityManager(Type entityType)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            if (!EntityHelper.Tv0i8HhZj91qevs5WPQC(entityType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 1 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_2;
        }
      }
label_2:
      throw new ArgumentNullException((string) EntityHelper.uR3QWBhZYWuq1oo4OOB7(1917998801 >> 2 ^ 479479328));
label_3:
      return ModelHelper.GetEntityManager(entityType);
    }

    /// <summary>Имеются ли кастомные представления</summary>
    /// <param name="entity"></param>
    /// <param name="viewType"></param>
    /// <param name="inTab"></param>
    /// <returns></returns>
    public static bool HasCustomFormViews(IEntity entity, ViewType viewType, bool? inTab = null)
    {
      EntityMetadata entityMetadata = entity != null ? EntityHelper.Metadata<EntityMetadata>(entity) : (EntityMetadata) null;
      return entityMetadata != null && entityMetadata.FormViews != null && entityMetadata.FormViews.Any<FormView>((Func<FormView, bool>) (v =>
      {
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_6;
            case 2:
              if (inTab.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 3:
              // ISSUE: reference to a compiler-generated method
              if (EntityHelper.\u003C\u003Ec__DisplayClass4_0.LLwr2nCzoW7X3wiZ5eFh((object) v) == viewType)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
                continue;
              }
              goto label_8;
            default:
              if (!inTab.Value)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 1;
                continue;
              }
              goto label_7;
          }
        }
label_6:
        // ISSUE: reference to a compiler-generated method
        return EntityHelper.\u003C\u003Ec__DisplayClass4_0.wx48ZACzbapZdTdVRaY6((object) v);
label_7:
        return v.ViewInTab;
label_8:
        return false;
      }));
    }

    /// <summary>Получить кастомные представления</summary>
    /// <param name="entity"></param>
    /// <param name="viewType"></param>
    /// <param name="inTab"></param>
    /// <returns></returns>
    public static FormView GetCustomFormView(IEntity entity, ViewType viewType, bool? inTab = null) => EntityHelper.HasCustomFormViews(entity, viewType, inTab) ? EntityHelper.Metadata<EntityMetadata>(entity).FormViews.First<FormView>((Func<FormView, bool>) (v =>
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (inTab.HasValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 3:
            // ISSUE: reference to a compiler-generated method
            if (EntityHelper.\u003C\u003Ec__DisplayClass5_0.FYE3o3CzQg8a18mqkgqq((object) v) == viewType)
            {
              num = 2;
              continue;
            }
            goto label_8;
          default:
            if (!inTab.Value)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
              continue;
            }
            goto label_7;
        }
      }
label_6:
      // ISSUE: reference to a compiler-generated method
      return EntityHelper.\u003C\u003Ec__DisplayClass5_0.PAyWrLCzCWFGyM0puQf1((object) v);
label_7:
      // ISSUE: reference to a compiler-generated method
      return EntityHelper.\u003C\u003Ec__DisplayClass5_0.jgCDpRCzvrXf9rg5ha8Q((object) v);
label_8:
      return false;
    })) : (FormView) null;

    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns></returns>
    public static T Metadata<T>(IEntity entity) where T : class, IMetadata => MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()) as T;

    public static PropertyInfo GetProperty<T>(string path)
    {
      try
      {
        if (string.IsNullOrEmpty(path))
          return (PropertyInfo) null;
        string[] strArray = path.Split(new string[1]
        {
          z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470445978)
        }, StringSplitOptions.None);
        PropertyInfo reflectionProperty = typeof (T).GetReflectionProperty(strArray[0]);
        Type propertyType = reflectionProperty.PropertyType;
        for (int index = 1; index < strArray.Length; ++index)
        {
          reflectionProperty = propertyType.GetReflectionProperty(strArray[index]);
          propertyType = reflectionProperty.PropertyType;
        }
        return reflectionProperty;
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) ex.Message, ex);
        return (PropertyInfo) null;
      }
    }

    /// <summary>
    /// Получить поле которое является наименованием или значение по умолчанию
    /// </summary>
    /// <param name="defaultValue">Дефолтное значение которое должно вернуться в случае если нет поля которое является наименованием (null по умолчанию)</param>
    /// <returns></returns>
    public static string GetTitleOrDefault<TSource>(
      this TSource source,
      Func<TSource, string> defaultValue = null)
      where TSource : IEntity
    {
      IEntityTitle entityTitle = ComponentManager.Current.GetExtensionPoints<IEntityTitle>().FirstOrDefault<IEntityTitle>((Func<IEntityTitle, bool>) (p => p.CheckType((IEntity) source)));
      if (entityTitle != null)
        return entityTitle.Title((IEntity) source);
      string s = source.ToString();
      return !s.IsNullOrEmpty() ? s : (defaultValue != null ? defaultValue(source) : EleWise.ELMA.SR.Untitled);
    }

    internal static bool ntax5thZr3BCIrIfmg28([In] object obj0) => obj0.IsProxy();

    internal static object nRqfeOhZgKFEDGSN46CF([In] object obj0) => (object) ((INHibernateProxy) obj0).HibernateLazyInitializer;

    internal static Type qtb9K9hZ5HituavwvYmc([In] object obj0) => ((ILazyInitializer) obj0).PersistentClass;

    internal static bool SbCXvGhZd5ppu6Ya8vmi() => EntityHelper.Cuc4LhhZ9JGW8YqS4uPy == null;

    internal static EntityHelper I0PFMthZloYVKbBgrFtX() => EntityHelper.Cuc4LhhZ9JGW8YqS4uPy;

    internal static bool Tv0i8HhZj91qevs5WPQC([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object uR3QWBhZYWuq1oo4OOB7(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Services.InterfaceActivator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Services
{
  /// <summary>Активатор интерфейсов</summary>
  public static class InterfaceActivator
  {
    private static Func<Type, string, bool, PropertyMetadata> getPropertyMetadata;
    private static InterfaceActivator udc9eIbZukjAvyD6p9mE;

    /// <summary>
    /// Создать экземпляр класса, реализующего интерфейс <typeparamref name="T" />. Если <typeparamref name="T" /> - класс, то вернется экземпляр этого класса.
    /// </summary>
    /// <typeparam name="T">Тип интерфейса или класса</typeparam>
    /// <returns>Экземпляр класса, реализующего интерфейс T.</returns>
    [NotNull]
    public static T Create<T>() => (T) InterfaceActivator.Create(typeof (T));

    /// <summary>
    /// Создать экземпляр класса, реализующего интерфейс t. Если t - класс, то вернется экземпляр этого класса.
    /// </summary>
    /// <param name="t">Тип интерфейса или класса</param>
    /// <returns>Экземпляр класса, реализующего интерфейс T.</returns>
    [NotNull]
    public static object Create(Type t)
    {
      int num1 = 8;
      IEntityManager entityManager;
      object obj1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              if (!t.IsInheritOrSame<IEntity>())
              {
                num2 = 13;
                continue;
              }
              goto case 4;
            case 3:
              goto label_20;
            case 4:
              entityManager = (IEntityManager) InterfaceActivator.XR6TbgbZiMjBYw8GBceL(t);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 10 : 12;
              continue;
            case 5:
              if (obj1 == null)
              {
                num2 = 14;
                continue;
              }
              goto label_9;
            case 6:
              goto label_16;
            case 7:
              goto label_13;
            case 8:
              if (!(t == (Type) null))
              {
                if (!t.IsClass)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                  continue;
                }
                break;
              }
              num2 = 7;
              continue;
            case 9:
              goto label_3;
            case 10:
              goto label_9;
            case 11:
              goto label_29;
            case 12:
              if (entityManager != null)
              {
                num2 = 6;
                continue;
              }
              goto label_17;
            case 13:
              goto label_17;
            case 14:
              num2 = 3;
              continue;
          }
          if (t.IsInheritOrSame<IEntity>())
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 2;
          else
            goto label_3;
        }
label_17:
        obj1 = InterfaceActivator.QNJtysbZqB8BJcacKZPO(t);
        num1 = 5;
      }
label_3:
      return InterfaceActivator.cHgc3tbZSIsWTD5SNNb2(t);
label_9:
      return obj1;
label_13:
      throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710501336));
label_16:
      return InterfaceActivator.W41RmvbZRqZpwawMEma1((object) entityManager);
label_20:
      object obj2;
      try
      {
        obj2 = InterfaceActivator.cHgc3tbZSIsWTD5SNNb2(t);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
          num4 = 0;
        string message;
        while (true)
        {
          switch (num4)
          {
            case 1:
              InterfaceActivator.hVKH3MbZXkLMyqkl4pyR((object) Logger.Log, (object) message, (object) ex);
              num4 = 2;
              continue;
            case 2:
              goto label_28;
            default:
              message = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133079993), InterfaceActivator.P4KBdxbZKhdEBZrKpEUZ((object) t), (object) t);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 0;
              continue;
          }
        }
label_28:
        throw new Exception(message, ex);
      }
label_29:
      return obj2;
    }

    /// <summary>
    /// Получить тип реализации для интерфейса. Если t - класс, то вернется он же.
    /// </summary>
    /// <param name="t">Тип интерфейса или класса</param>
    /// <returns>Тип класса реализации</returns>
    public static Type TypeOf(Type t)
    {
      int num1 = 2;
      Type type;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_6;
            case 2:
              if (InterfaceActivator.tDR0OZbZTOtRY3TGK42s(t, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
                continue;
              }
              goto label_7;
            case 3:
              goto label_9;
            case 4:
              type = ((ComponentManager) InterfaceActivator.L8jRQabZnAXUsSJ0g7mY()).GetExtensionPointTypes(t).FirstOrDefault<Type>();
              if ((object) type == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            default:
              goto label_12;
          }
        }
label_7:
        if (t.IsInterface)
          num1 = 4;
        else
          goto label_9;
      }
label_6:
      throw new ArgumentNullException((string) InterfaceActivator.h8gEYbbZk2mkV9vJETuE(1669212571 ^ 1669286777));
label_9:
      return t;
label_3:
      return type;
label_12:
      return t;
    }

    /// <summary>
    /// Получить тип реализации для интерфейса. Если <typeparamref name="T" /> - класс, то вернется он же.
    /// </summary>
    /// <typeparam name="T">Тип интерфейса или класса</typeparam>
    /// <returns>Тип класса реализации</returns>
    public static Type TypeOf<T>() => InterfaceActivator.TypeOf(System.Reflection.TypeOf<T>.Raw);

    /// <summary>
    /// Загрузить (восстановить) метаданные из типа <paramref name="t" />
    /// </summary>
    /// <param name="t">Тип, у которого требуется получить метаданные</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata(Type t, bool inherit = true, bool loadImplementation = true)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (!InterfaceActivator.tDR0OZbZTOtRY3TGK42s(t, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 1 : 0;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) InterfaceActivator.h8gEYbbZk2mkV9vJETuE(1470440286 ^ 1470382524));
label_5:
      return MetadataLoader.LoadMetadata(t, inherit, loadImplementation);
    }

    /// <summary>
    /// Загрузить (восстановить) метаданные из типа <typeparamref name="T" />
    /// </summary>
    /// <typeparam name="T">Тип, у которого требуется получить метаданные</typeparam>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Метаданные</returns>
    public static IMetadata LoadMetadata<T>(bool inherit = true, bool loadImplementation = true) => MetadataLoader.LoadMetadata(typeof (T), inherit, loadImplementation);

    /// <summary>Получить уникальный идентификатор типа объекта</summary>
    /// <param name="t">Тип, у которого требуется получить идентификатор</param>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Уникальный идентификатор объекта</returns>
    public static Guid UID(Type t, bool loadImplementation = true) => InterfaceActivator.aTIMMQbZOLAt3n6V42OU((object) MetadataLoader.LoadMetadata(t, false, loadImplementation));

    /// <summary>Получить уникальный идентификатор типа объекта</summary>
    /// <typeparam name="T">Тип, у которого требуется получить идентификатор</typeparam>
    /// <param name="loadImplementation">Загружать ли метаданные реализации, если указанный тип - интерфейс</param>
    /// <returns>Уникальный идентификатор объекта</returns>
    public static Guid UID<T>(bool loadImplementation = true) => MetadataLoader.LoadMetadata(typeof (T), false, loadImplementation).Uid;

    /// <summary>Возвращает Uid свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <returns></returns>
    public static Guid PropertyUid<T>(Expression<Func<T, object>> expr) => InterfaceActivator.PropertyUid<T>(expr, false);

    /// <summary>Возвращает Uid свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns></returns>
    public static Guid PropertyUid<T>(Expression<Func<T, object>> expr, bool inherit)
    {
      PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata<T>(expr, inherit);
      return propertyMetadata == null ? Guid.Empty : propertyMetadata.Uid;
    }

    /// <summary>Возвращает название свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <returns></returns>
    [Obsolete("Метод устарел. Используйте LinqUtils.NameOf<>", false)]
    public static string PropertyName<T>(Expression<Func<T, object>> expr) => InterfaceActivator.PropertyName<T>(expr, false);

    /// <summary>Возвращает название свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns></returns>
    [Obsolete("Метод устарел. Используйте LinqUtils.NameOf<>", false)]
    public static string PropertyName<T>(Expression<Func<T, object>> expr, bool inherit)
    {
      PropertyMetadata propertyMetadata = InterfaceActivator.LoadPropertyMetadata<T>(expr, inherit);
      return propertyMetadata == null ? "" : propertyMetadata.Name;
    }

    /// <summary>Загружает метаданные свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <returns></returns>
    public static PropertyMetadata LoadPropertyMetadata<T>(Expression<Func<T, object>> expr) => InterfaceActivator.LoadPropertyMetadata<T>(expr, false);

    /// <summary>Загружает метаданные свойства.</summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="expr"></param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns></returns>
    public static PropertyMetadata LoadPropertyMetadata<T>(
      Expression<Func<T, object>> expr,
      bool inherit)
    {
      return InterfaceActivator.LoadPropertyMetadata(typeof (T), LinqUtils.NameOf<T>(expr), inherit);
    }

    /// <summary>Загружает метаданные свойства.</summary>
    /// <typeparam name="T">Тип</typeparam>
    /// <param name="propName">Имя свойства</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns></returns>
    public static PropertyMetadata LoadPropertyMetadata<T>(string propName, bool inherit) => InterfaceActivator.LoadPropertyMetadata(typeof (T), propName, inherit);

    /// <summary>Загружает метаданные свойства.</summary>
    /// <param name="type"></param>
    /// <param name="propName"></param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    /// <returns></returns>
    public static PropertyMetadata LoadPropertyMetadata(Type type, string propName, bool inherit) => InterfaceActivator.getPropertyMetadata(type, propName, inherit);

    private static PropertyMetadata GetPropertyMetadata(Type type, object propName, bool inherit)
    {
      int num1 = 1;
      ClassMetadata classMetadata;
      string propName1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_9;
            case 3:
              goto label_8;
            case 4:
              if (classMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 2 : 1;
                continue;
              }
              goto label_8;
            case 5:
              goto label_3;
            default:
              propName1 = (string) propName;
              num2 = 5;
              continue;
          }
        }
label_3:
        classMetadata = MetadataLoader.LoadMetadata(type, inherit) as ClassMetadata;
        num1 = 4;
      }
label_8:
      return (PropertyMetadata) null;
label_9:
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return classMetadata.Properties.FirstOrDefault<PropertyMetadata>((Func<PropertyMetadata, bool>) (p => InterfaceActivator.\u003C\u003Ec__DisplayClass16_0.jkcptjCe04PI4Ok2FQmm(InterfaceActivator.\u003C\u003Ec__DisplayClass16_0.Kftq8uCexQjn2xRb8oI5((object) p), (object) propName1)));
    }

    static InterfaceActivator()
    {
      int num = 5;
      ParameterExpression parameterExpression1;
      ParameterExpression parameterExpression2;
      ParameterExpression parameterExpression3;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameterExpression1 = (ParameterExpression) InterfaceActivator.VHoX3YbZeP9thEeWqPNa(typeof (bool), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3298914));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            // ISSUE: type reference
            parameterExpression3 = (ParameterExpression) InterfaceActivator.VHoX3YbZeP9thEeWqPNa(InterfaceActivator.tFkWtcbZ2xyC4xOVdlQV(__typeref (string)), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107981816));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
            continue;
          case 4:
            // ISSUE: type reference
            parameterExpression2 = (ParameterExpression) InterfaceActivator.VHoX3YbZeP9thEeWqPNa(InterfaceActivator.tFkWtcbZ2xyC4xOVdlQV(__typeref (Type)), InterfaceActivator.h8gEYbbZk2mkV9vJETuE(236071375 ^ 236070381));
            num = 3;
            continue;
          case 5:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 4;
            continue;
          default:
            // ISSUE: method reference
            InterfaceActivator.getPropertyMetadata = MetadataLoader.UseCachingForFunc<Type, string, bool, PropertyMetadata>(Expression.Lambda<Func<Type, string, bool, PropertyMetadata>>((Expression) InterfaceActivator.TDvwQwbZ1XklBPtofDyP((object) null, (object) (MethodInfo) InterfaceActivator.iFYI1xbZPdjCNnGcaZby(__methodref (InterfaceActivator.GetPropertyMetadata)), (object) new Expression[3]
            {
              (Expression) parameterExpression2,
              (Expression) parameterExpression3,
              (Expression) parameterExpression1
            }), parameterExpression2, parameterExpression3, parameterExpression1));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object cHgc3tbZSIsWTD5SNNb2([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static object XR6TbgbZiMjBYw8GBceL(Type entityType) => (object) ModelHelper.GetEntityManagerOrNull(entityType);

    internal static object W41RmvbZRqZpwawMEma1([In] object obj0) => ((IEntityManager) obj0).Create();

    internal static object QNJtysbZqB8BJcacKZPO(Type type) => Locator.GetService(type);

    internal static object P4KBdxbZKhdEBZrKpEUZ([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static void hVKH3MbZXkLMyqkl4pyR([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool YYgZ1ZbZIfB430cGZALa() => InterfaceActivator.udc9eIbZukjAvyD6p9mE == null;

    internal static InterfaceActivator QStiEabZVEiLCPl4u367() => InterfaceActivator.udc9eIbZukjAvyD6p9mE;

    internal static bool tDR0OZbZTOtRY3TGK42s([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object h8gEYbbZk2mkV9vJETuE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object L8jRQabZnAXUsSJ0g7mY() => (object) ComponentManager.Current;

    internal static Guid aTIMMQbZOLAt3n6V42OU([In] object obj0) => ((IMetadata) obj0).Uid;

    internal static Type tFkWtcbZ2xyC4xOVdlQV([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object VHoX3YbZeP9thEeWqPNa([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object iFYI1xbZPdjCNnGcaZby([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object TDvwQwbZ1XklBPtofDyP([In] object obj0, [In] object obj1, [In] object obj2) => (object) Expression.Call((Expression) obj0, (MethodInfo) obj1, (Expression[]) obj2);
  }
}

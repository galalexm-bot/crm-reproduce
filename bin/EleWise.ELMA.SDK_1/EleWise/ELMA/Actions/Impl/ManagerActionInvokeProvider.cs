// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.Impl.ManagerActionInvokeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Actions.Impl
{
  /// <summary>Провайдер действий с объектами</summary>
  [Component]
  internal sealed class ManagerActionInvokeProvider : IActionInvokerProvider
  {
    private readonly ILazy<ActionDispatcherService> actionDispatcherService;
    private readonly IEntityManagerTypesStorage entityManagerTypesStorage;
    private readonly EntityAuditObjectProvider entityAuditObjectProvider;
    /// <summary>Флаги поиска метода для выполнения действия</summary>
    public const BindingFlags INVOKE_METHOD_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod;
    /// <summary>
    /// Флаги поиска метода проверки возможности выполнить действие
    /// </summary>
    public const BindingFlags CHECK_METHOD_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod;
    private readonly HashSet<Type> invokerManagers;
    private IEnumerable<IActionInvoker> invokers;
    private static ManagerActionInvokeProvider pomrdjf481NOIFykBxV7;

    /// <summary>
    /// Получить информацию для идентификации события о методе действия
    /// </summary>
    /// <param name="method">Информация о методе</param>
    /// <returns>Информация для идентификации события</returns>
    public static IAuditEventHolder GetActionInfoForMethod([NotNull] MethodInfo method) => ManagerActionInvokeProvider.GetActionInfo<ActionMethodAttribute>(method);

    /// <summary>
    /// Получить информацию для идентификации события о методе проверки возможности выполнить действие
    /// </summary>
    /// <param name="method">Информация о методе</param>
    /// <returns>Информация для идентификации события</returns>
    public static IAuditEventHolder GetActionInfoForCheck([NotNull] MethodInfo method) => ManagerActionInvokeProvider.GetActionInfo<ActionCheckAttribute>(method);

    /// <summary>Получить информацию для идентификации события</summary>
    /// <param name="method">Информация о методе</param>
    /// <returns>Информация для идентификации события</returns>
    public static IAuditEventHolder GetMethodActionInfo([NotNull] MethodInfo method)
    {
      int num = 1;
      IAuditEventHolder actionInfoForMethod;
      while (true)
      {
        switch (num)
        {
          case 1:
            actionInfoForMethod = ManagerActionInvokeProvider.GetActionInfoForMethod(method);
            if (actionInfoForMethod == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      return actionInfoForMethod;
label_5:
      return ManagerActionInvokeProvider.GetActionInfoForCheck(method);
    }

    /// <summary>Получить информацию для идентификации события</summary>
    /// <typeparam name="TAttrib">Тип атрибута</typeparam>
    /// <param name="method">Информация о методе</param>
    /// <returns>Информация для идентификации события</returns>
    private static IAuditEventHolder GetActionInfo<TAttrib>([NotNull] MethodInfo method) where TAttrib : ActionImplAttribute
    {
      Contract.ArgumentNotNull((object) method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606721014));
      TAttrib attribute = AttributeHelper<TAttrib>.GetAttribute((MemberInfo) method, true);
      Type declaringType = method.DeclaringType;
      IAuditEventHolder actionInfo = (IAuditEventHolder) null;
      if ((object) attribute != null && declaringType != (Type) null)
      {
        if (attribute.AuditObjectUid == Guid.Empty)
        {
          Type type = declaringType.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName);
          Type t = type != (Type) null ? type.GetGenericArguments()[0] : throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575813858), (object) EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName, (object) declaringType.FullName));
          attribute.AuditObjectUid = (Locator.GetServiceNotNull<EntityAuditObjectProvider>().GetObject(InterfaceActivator.UID(t)) ?? throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3652520), (object) t.FullName))).Uid;
        }
        actionInfo = (IAuditEventHolder) new AuditEventHolder(attribute.GetObject(), attribute.GetAction());
      }
      return actionInfo;
    }

    /// <summary>Получить исполнители действия</summary>
    /// <param name="managerType">Тип менеджера сущности</param>
    /// <returns>Исполнители действия</returns>
    private IEnumerable<IActionInvoker> GetInvokers([NotNull] Type managerType)
    {
      Contract.ArgumentNotNull((object) managerType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638754521));
      List<Tuple<MethodInfo, IAuditAction, IAuditObject>> invokeMethods = new List<Tuple<MethodInfo, IAuditAction, IAuditObject>>();
      List<Tuple<MethodInfo, IAuditAction, IAuditObject>> checkMethods = new List<Tuple<MethodInfo, IAuditAction, IAuditObject>>();
      foreach (MethodInfo method in managerType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod))
      {
        foreach (ActionImplAttribute attribute in (IEnumerable<ActionImplAttribute>) AttributeHelper<ActionImplAttribute>.GetAttributes((MemberInfo) method, true))
        {
          if (attribute.AuditObjectUid == Guid.Empty)
          {
            Type type = managerType.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName);
            if (type != (Type) null)
            {
              IAuditObject auditObject = this.entityAuditObjectProvider.GetObject(InterfaceActivator.UID(type.GetGenericArguments()[0]));
              if (auditObject != null)
                attribute.AuditObjectUid = auditObject.Uid;
            }
          }
          if (!(attribute.AuditObjectUid == Guid.Empty))
          {
            IAuditObject auditObject = attribute.GetObject();
            IAuditAction action = attribute.GetAction();
            (attribute is ActionMethodAttribute ? invokeMethods : checkMethods).Add(new Tuple<MethodInfo, IAuditAction, IAuditObject>(method, action, auditObject));
          }
        }
      }
      Tuple<MethodInfo, IAuditAction, IAuditObject> tuple1 = checkMethods.FirstOrDefault<Tuple<MethodInfo, IAuditAction, IAuditObject>>((Func<Tuple<MethodInfo, IAuditAction, IAuditObject>, bool>) (method => !invokeMethods.Any<Tuple<MethodInfo, IAuditAction, IAuditObject>>((Func<Tuple<MethodInfo, IAuditAction, IAuditObject>, bool>) (invokeMethod => invokeMethod.Item2.Uid == method.Item2.Uid && invokeMethod.Item3.Uid == method.Item3.Uid && invokeMethod.Item1.ReturnType.IsAsync() == method.Item1.ReturnType.IsAsync()))));
      if (tuple1 != null)
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283213707), (object) TypeOf<ActionCheckAttribute>.FullName, (object) TypeOf<ActionMethodAttribute>.FullName, (object) tuple1.Item1.Name, (object) managerType.FullName));
      return (IEnumerable<IActionInvoker>) invokeMethods.Select<Tuple<MethodInfo, IAuditAction, IAuditObject>, ActionInvokerAsync>((Func<Tuple<MethodInfo, IAuditAction, IAuditObject>, ActionInvokerAsync>) (invokeMethodTuple =>
      {
        bool flag = invokeMethodTuple.Item1.ReturnType.IsAsync();
        Tuple<MethodInfo, IAuditAction, IAuditObject> tuple2 = checkMethods.FirstOrDefault<Tuple<MethodInfo, IAuditAction, IAuditObject>>((Func<Tuple<MethodInfo, IAuditAction, IAuditObject>, bool>) (checkMethodTuple => checkMethodTuple.Item2.Uid == invokeMethodTuple.Item2.Uid && checkMethodTuple.Item3.Uid == invokeMethodTuple.Item3.Uid && checkMethodTuple.Item1.ReturnType.IsAsync() == invokeMethodTuple.Item1.ReturnType.IsAsync()));
        if (tuple2 != null)
        {
          if (flag)
          {
            if (tuple2.Item1.ReturnParameter.ParameterType != TypeOf<Task<bool>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<ValueTask<bool>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<Task<ActionCheckResult>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<ValueTask<ActionCheckResult>>.Raw)
              throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740723536), (object) TypeOf<ActionCheckAttribute>.FullName, (object) TypeOf<Task<ActionCheckResult>>.FullName, (object) TypeOf<Task<bool>>.FullName, (object) tuple2.Item1.Name, (object) managerType.FullName, (object) TypeOf<ValueTask<bool>>.FullName, (object) TypeOf<ValueTask<ActionCheckResult>>.FullName));
          }
          else if (tuple2.Item1.ReturnParameter.ParameterType != TypeOf<bool>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<ActionCheckResult>.Raw)
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124516066), (object) TypeOf<ActionCheckAttribute>.FullName, (object) TypeOf<ActionCheckResult>.FullName, (object) TypeOf<bool>.FullName, (object) tuple2.Item1.Name, (object) managerType.FullName));
          if (!((IEnumerable<ParameterInfo>) tuple2.Item1.GetParameters()).SequenceEqual<ParameterInfo>((IEnumerable<ParameterInfo>) invokeMethodTuple.Item1.GetParameters(), (IEqualityComparer<ParameterInfo>) new ManagerActionInvokeProvider.PropertyInfoTypeComparer()))
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239701726), (object) TypeOf<ActionCheckAttribute>.FullName, (object) tuple2.Item1.Name, (object) managerType.FullName));
        }
        return new ActionInvokerAsync(this.actionDispatcherService, Locator.GetServiceNotNull(managerType), invokeMethodTuple.Item3, invokeMethodTuple.Item2, invokeMethodTuple.Item1, tuple2?.Item1);
      }));
    }

    /// <summary>Ctor</summary>
    /// <param name="actionDispatcherService">Сервис для работы с действиями</param>
    /// <param name="entityManagerTypesStorage">Хранилище информации о типах менеджеров сущностей</param>
    /// <param name="entityAuditObjectProvider">Провайдер объектов аудита для сущностей</param>
    public ManagerActionInvokeProvider(
      ILazy<ActionDispatcherService> actionDispatcherService,
      IEntityManagerTypesStorage entityManagerTypesStorage,
      EntityAuditObjectProvider entityAuditObjectProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.invokerManagers = new HashSet<Type>();
      this.invokers = Enumerable.Empty<IActionInvoker>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.actionDispatcherService = actionDispatcherService;
      this.entityManagerTypesStorage = entityManagerTypesStorage;
      this.entityAuditObjectProvider = entityAuditObjectProvider;
    }

    /// <inheritdoc />
    public IEnumerable<IActionInvoker> GetInvokers()
    {
      HashSet<Type> hashSet = this.entityManagerTypesStorage.GetManagerTypes().Where<Type>((Func<Type, bool>) (manager =>
      {
        int num = 2;
        ObsoleteAttribute obsoleteAttribute;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (obsoleteAttribute != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              obsoleteAttribute = AttributeHelper<ObsoleteAttribute>.GetAttributes(manager, false).FirstOrDefault<ObsoleteAttribute>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 0 : 1;
              continue;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        return !ManagerActionInvokeProvider.\u003C\u003Ec.cFiwUaZQG9h5cXuS4IIG((object) obsoleteAttribute);
label_5:
        return true;
      })).ToHashSet<Type>();
      if (hashSet.Count > this.invokerManagers.Count)
      {
        lock (this)
        {
          if (hashSet.Count > this.invokerManagers.Count)
          {
            List<Type> managerWithInvokers = new List<Type>();
            hashSet.ExceptWith((IEnumerable<Type>) this.invokerManagers);
            this.invokers = (IEnumerable<IActionInvoker>) this.invokers.Concat<IActionInvoker>(hashSet.SelectMany<Type, IActionInvoker>((Func<Type, IEnumerable<IActionInvoker>>) (managerType =>
            {
              IEnumerable<IActionInvoker> invokers = this.GetInvokers(managerType);
              if ((invokers != null ? invokers.Count<IActionInvoker>() : 0) <= 0)
                return invokers;
              managerWithInvokers.Add(managerType);
              return invokers;
            }))).ToList<IActionInvoker>();
            this.invokerManagers.UnionWith((IEnumerable<Type>) managerWithInvokers);
          }
        }
      }
      return this.invokers;
    }

    /// <inheritdoc />
    public IActionInvoker GetInvoker(Guid actionObjectUid, Guid actionTypeUid)
    {
      int num1 = 1;
      Guid actionTypeUid1;
      Guid actionObjectUid1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_3;
            case 3:
              actionObjectUid1 = actionObjectUid;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 2 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        actionTypeUid1 = actionTypeUid;
        num1 = 3;
      }
label_3:
      return this.GetInvokers().FirstOrDefault<IActionInvoker>((Func<IActionInvoker, bool>) (inv =>
      {
        int num3 = 3;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_4;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!ManagerActionInvokeProvider.\u003C\u003Ec__DisplayClass15_0.nvj75dZQ8PPt4V26VGM5(ManagerActionInvokeProvider.\u003C\u003Ec__DisplayClass15_0.abLY7xZQvQhIIDOqJGRo((object) inv.ActionType), actionTypeUid1))
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 3:
              if (inv != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 1 : 2;
                continue;
              }
              goto label_5;
            default:
              goto label_5;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ManagerActionInvokeProvider.\u003C\u003Ec__DisplayClass15_0.nvj75dZQ8PPt4V26VGM5(ManagerActionInvokeProvider.\u003C\u003Ec__DisplayClass15_0.DN4kOEZQuQeJXssYCtG1(ManagerActionInvokeProvider.\u003C\u003Ec__DisplayClass15_0.L83qVaZQZptkNElYCSd1((object) inv)), actionObjectUid1);
label_5:
        return false;
      }));
    }

    internal static bool yPhIfuf4ZMhao4cce1Ly() => ManagerActionInvokeProvider.pomrdjf481NOIFykBxV7 == null;

    internal static ManagerActionInvokeProvider mQ6YYMf4u7FaEtqMcOMU() => ManagerActionInvokeProvider.pomrdjf481NOIFykBxV7;

    /// <summary>
    /// Компаратор для объекта <see cref="T:System.Reflection.ParameterInfo" />
    /// </summary>
    private class PropertyInfoTypeComparer : IEqualityComparer<ParameterInfo>
    {
      private static object yXr1bQZf0c3FN9kicKER;

      /// <inheritdoc />
      public bool Equals(ParameterInfo x, ParameterInfo y)
      {
        int num = 5;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
            case 7:
              goto label_5;
            case 3:
            case 4:
              if (x != y)
              {
                if (x == null)
                {
                  num = 7;
                  continue;
                }
                break;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
              continue;
            case 5:
              if (x != null)
              {
                num = 4;
                continue;
              }
              goto case 6;
            case 6:
              if (y != null)
              {
                num = 3;
                continue;
              }
              goto label_2;
          }
          if (y == null)
            num = 2;
          else
            goto label_6;
        }
label_2:
        return true;
label_5:
        return false;
label_6:
        return ManagerActionInvokeProvider.PropertyInfoTypeComparer.D3WjX1ZfJOnSqeMFaiRJ(ManagerActionInvokeProvider.PropertyInfoTypeComparer.AOWND6ZfMVq6f7QeFe2s((object) x), ManagerActionInvokeProvider.PropertyInfoTypeComparer.AOWND6ZfMVq6f7QeFe2s((object) y));
      }

      /// <inheritdoc />
      public int GetHashCode(ParameterInfo obj)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (obj != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 1 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        return 0;
label_3:
        return obj.GetHashCode();
      }

      public PropertyInfoTypeComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static Type AOWND6ZfMVq6f7QeFe2s([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

      internal static bool D3WjX1ZfJOnSqeMFaiRJ([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static bool L3FRmkZfmdqaDiTqEpt8() => ManagerActionInvokeProvider.PropertyInfoTypeComparer.yXr1bQZf0c3FN9kicKER == null;

      internal static ManagerActionInvokeProvider.PropertyInfoTypeComparer orsKLkZfyGjv5h7O5RAR() => (ManagerActionInvokeProvider.PropertyInfoTypeComparer) ManagerActionInvokeProvider.PropertyInfoTypeComparer.yXr1bQZf0c3FN9kicKER;
    }
  }
}

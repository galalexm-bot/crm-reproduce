// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Actions.ActionDispatcherServiceExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Actions
{
  /// <summary>Расширения для сервиса работы с действиями</summary>
  public static class ActionDispatcherServiceExtensions
  {
    internal static ActionDispatcherServiceExtensions PJ0UYYft36P5PZ7rU1KQ;

    /// <summary>Проверить доступность действия</summary>
    /// <param name="service">Сервис</param>
    /// <param name="actionObjectUid">Идентификатор объекта действия</param>
    /// <param name="actionTypeUid">Идентификатор типа действия</param>
    /// <param name="methodArgs">Аргументы вызова</param>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Неверный формат параметров <paramref name="actionObjectUid" /> или <paramref name="actionTypeUid" /></exception>
    /// <exception cref="T:System.InvalidOperationException">Не найден объект или тип действия по ключу</exception>
    public static ActionCheckResult CheckActionWithResult(
      [NotNull] this ActionDispatcherService service,
      [NotNull] string actionObjectUid,
      [NotNull] string actionTypeUid,
      params object[] methodArgs)
    {
      int num = 2;
      IAuditAction action;
      IAuditObject actionObject;
      IAuditManager serviceNotNull;
      Guid result1;
      Guid result2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_24;
          case 2:
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            }
            if (actionObjectUid != null)
            {
              if (actionTypeUid != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 9 : 3;
                continue;
              }
              goto label_11;
            }
            else
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
              continue;
            }
          case 3:
            if (Guid.TryParse(actionObjectUid, out result2))
            {
              serviceNotNull = Locator.GetServiceNotNull<IAuditManager>();
              num = 5;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 7 : 12;
            continue;
          case 4:
            goto label_17;
          case 5:
            actionObject = (IAuditObject) ActionDispatcherServiceExtensions.nbbw6Jftt3tYHfb4rhh3((object) serviceNotNull, result2);
            num = 10;
            continue;
          case 6:
            goto label_20;
          case 7:
            action = serviceNotNull.GetAction(actionObject, result1);
            num = 13;
            continue;
          case 8:
            goto label_9;
          case 9:
            if (Guid.TryParse(actionTypeUid, out result1))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 1 : 3;
              continue;
            }
            goto label_17;
          case 10:
            if (actionObject != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 7 : 1;
              continue;
            }
            goto label_9;
          case 11:
            goto label_11;
          case 12:
            goto label_15;
          case 13:
            if (action == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 6;
              continue;
            }
            goto label_21;
          default:
            goto label_4;
        }
      }
label_4:
      throw new ArgumentNullException((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(1242972401 >> 4 ^ 77872661));
label_9:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(874012245 ^ 874316835), (object) actionObjectUid));
label_11:
      throw new ArgumentNullException((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(-1867198571 ^ -1867410007));
label_15:
      throw new ArgumentException((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(-812025778 ^ -811851244), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~1767720452 ^ -1767382047));
label_17:
      throw new ArgumentException((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(--1333735954 ^ 1333422152), (string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(-1839087379 - 334718690 ^ 2120941623));
label_20:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(1051276242 - 990076387 ^ 60854057), (object) actionTypeUid));
label_21:
      return service.CheckAction(actionObject, action, methodArgs);
label_24:
      throw new ArgumentNullException((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(1461625753 ^ 1461699577));
    }

    /// <summary>Проверить доступность действия</summary>
    /// <param name="service">Сервис</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static ActionCheckResult CheckActionWithResult<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression)
      where TManager : IEntityManager
    {
      if (service == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-342626196 - 1290888215 ^ -1633424331));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882123674));
      if (!(expression.Body is MethodCallExpression body) || body.Method == (MethodInfo) null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 60854015)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1870889165));
      IDictionary<string, object> rvd = (IDictionary<string, object>) new Dictionary<string, object>();
      ActionDispatcherServiceExtensions.AddParameterValuesFromExpressionToDictionary(rvd, body);
      IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(body.Method);
      return methodActionInfo != null ? service.CheckAction(methodActionInfo.Object, methodActionInfo.Action, rvd.Values.ToArray<object>()) : ActionCheckResult.False((string) null);
    }

    /// <summary>Проверить доступность действия</summary>
    /// <param name="service">Сервис</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static ActionCheckResult CheckActionWithResult<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : IEntityManager
    {
      if (service == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021319957));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702062));
      if (objectType == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740487994));
      if (!(expression.Body is MethodCallExpression body) || body.Method == (MethodInfo) null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426400215)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-306453669 ^ 306450848));
      IDictionary<string, object> rvd = (IDictionary<string, object>) new Dictionary<string, object>();
      ActionDispatcherServiceExtensions.AddParameterValuesFromExpressionToDictionary(rvd, body);
      IAuditObject actionObject = Locator.GetServiceNotNull<IAuditManager>().GetObject(InterfaceActivator.UID(objectType));
      if (actionObject == null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418655184), (object) objectType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874121031));
      IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(body.Method);
      return methodActionInfo != null ? service.CheckAction(actionObject, methodActionInfo.Action, rvd.Values.ToArray<object>()) : ActionCheckResult.False((string) null);
    }

    /// <summary>Проверить доступность действия</summary>
    /// <param name="manager">Менеджер</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static ActionCheckResult CheckActionWithResult<TManager>(
      [NotNull] this TManager manager,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : class, IEntityManager
    {
      if ((object) manager == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461825605 - 1531863589 ^ -69855754));
      return Locator.GetServiceNotNull<ActionDispatcherService>().CheckActionWithResult<TManager>(expression, objectType);
    }

    /// <summary>Проверить доступность действия</summary>
    /// <param name="service">Сервис</param>
    /// <param name="actionObjectUid">Идентификатор объекта действия</param>
    /// <param name="actionTypeUid">Идентификатор типа действия</param>
    /// <param name="methodArgs">Аргументы вызова</param>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Неверный формат параметров <paramref name="actionObjectUid" /> или <paramref name="actionTypeUid" /></exception>
    /// <exception cref="T:System.InvalidOperationException">Не найден объект или тип действия по ключу</exception>
    public static bool CheckAction(
      [NotNull] this ActionDispatcherService service,
      [NotNull] string actionObjectUid,
      [NotNull] string actionTypeUid,
      params object[] methodArgs)
    {
      return ActionDispatcherServiceExtensions.IGuO7fftwgXUW8qH3tOy(service.CheckActionWithResult(actionObjectUid, actionTypeUid, methodArgs));
    }

    public static bool CheckAction<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression)
      where TManager : IEntityManager
    {
      return (bool) service.CheckActionWithResult<TManager>(expression);
    }

    public static bool CheckAction<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : IEntityManager
    {
      return (bool) service.CheckActionWithResult<TManager>(expression, objectType);
    }

    public static bool CheckAction<TManager>(
      [NotNull] this TManager manager,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : class, IEntityManager
    {
      return (bool) manager.CheckActionWithResult<TManager>(expression, objectType);
    }

    /// <summary>Выполнить действие</summary>
    /// <param name="service">Сервис</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static void InvokeAction<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : IEntityManager
    {
      if (service == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1199946765 ^ 1199889517));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561078176));
      if (objectType == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61312253));
      MethodCallExpression body = expression.Body as MethodCallExpression;
      ActionDispatcherServiceExtensions.InvokeAction((object) service, objectType, (object) body);
    }

    /// <summary>Выполнить действие (функцию)</summary>
    /// <param name="service">Сервис</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static TResult InvokeAction<TManager, TResult>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Func<TManager, TResult>> expression,
      [NotNull] Type objectType)
      where TManager : IEntityManager
    {
      if (service == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501399017));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304607817));
      if (objectType == (Type) null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70148577));
      MethodCallExpression body = expression.Body as MethodCallExpression;
      return (TResult) ActionDispatcherServiceExtensions.InvokeAction((object) service, objectType, (object) body);
    }

    private static object InvokeAction(object service, Type objectType, object methodCall)
    {
      int num1 = 2;
      IDictionary<string, object> rvd;
      IAuditEventHolder methodActionInfo;
      IAuditObject actionObject;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!ActionDispatcherServiceExtensions.NWdRksft4FNXoQo3X40S((object) ((MethodCallExpression) methodCall).Method, (object) null))
              {
                rvd = (IDictionary<string, object>) new Dictionary<string, object>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0 ? 10 : 9;
              continue;
            case 2:
              if (methodCall != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 0;
                continue;
              }
              goto label_3;
            case 3:
              goto label_6;
            case 4:
              goto label_9;
            case 5:
              if (actionObject != null)
              {
                num2 = 3;
                continue;
              }
              goto label_5;
            case 6:
              actionObject = (IAuditObject) ActionDispatcherServiceExtensions.nbbw6Jftt3tYHfb4rhh3((object) Locator.GetServiceNotNull<IAuditManager>(), InterfaceActivator.UID(objectType));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 5 : 2;
              continue;
            case 7:
              goto label_5;
            case 8:
              goto label_10;
            case 9:
              if (methodActionInfo != null)
              {
                num2 = 8;
                continue;
              }
              goto label_9;
            case 10:
              goto label_3;
            default:
              ActionDispatcherServiceExtensions.AddParameterValuesFromExpressionToDictionary(rvd, (MethodCallExpression) methodCall);
              num2 = 6;
              continue;
          }
        }
label_6:
        methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo((MethodInfo) ActionDispatcherServiceExtensions.WTbDQSft6wNZo4hlt3NB(methodCall));
        num1 = 9;
      }
label_3:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(813604817 ^ 813417665)), (string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(-1710575414 ^ -1710232798));
label_5:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(~-122002947 ^ 121685336), (object) objectType), (string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(95909607 + 343705423 ^ 439461668));
label_9:
      throw new ArgumentException(EleWise.ELMA.SR.T((string) ActionDispatcherServiceExtensions.YQSubbftDDhyhkVdsjXA(-1088304168 ^ -1088120872), ActionDispatcherServiceExtensions.WTbDQSft6wNZo4hlt3NB(methodCall)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87158881));
label_10:
      return ((ActionDispatcherService) service).InvokeAction(actionObject, (IAuditAction) ActionDispatcherServiceExtensions.JRmfmVftHCSCb4Cfidj9((object) methodActionInfo), rvd.Values.ToArray<object>());
    }

    /// <summary>Выполнить действие (функцию)</summary>
    /// <param name="manager">Менеджер</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static TResult InvokeAction<TManager, TResult>(
      [NotNull] this TManager manager,
      [NotNull] Expression<Func<TManager, TResult>> expression,
      [NotNull] Type objectType)
      where TManager : class, IEntityManager
    {
      if ((object) manager == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69821221));
      return Locator.GetServiceNotNull<ActionDispatcherService>().InvokeAction<TManager, TResult>(expression, objectType);
    }

    /// <summary>Выполнить действие (функцию)</summary>
    /// <param name="manager">Менеджер</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns><c>true</c>, если действие доступно</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static void InvokeAction<TManager>(
      [NotNull] this TManager manager,
      [NotNull] Expression<Action<TManager>> expression,
      [NotNull] Type objectType)
      where TManager : class, IEntityManager
    {
      if ((object) manager == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239883868));
      Locator.GetServiceNotNull<ActionDispatcherService>().InvokeAction<TManager>(expression, objectType);
    }

    /// <summary>Получить информацию о методе</summary>
    /// <param name="service">Сервис</param>
    /// <param name="expression">Выражение с вызовом метода в менеджере</param>
    /// <typeparam name="TManager">Тип менеджера сущности</typeparam>
    /// <returns>Информация о методе вызова</returns>
    /// <exception cref="T:System.ArgumentNullException">Один из параметров равен <c>null</c></exception>
    /// <exception cref="T:System.ArgumentException">Параметр <paramref name="expression" /> не является выражением с вызовом метода</exception>
    public static IAuditEventArgs GetActionInfoFor<TManager>(
      [NotNull] this ActionDispatcherService service,
      [NotNull] Expression<Action<TManager>> expression)
      where TManager : IEntityManager
    {
      if (service == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1304605005 ^ 1304678701));
      if (expression == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108654796));
      if (!(expression.Body is MethodCallExpression body) || body.Method == (MethodInfo) null)
        throw new ArgumentException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883132704)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(993438473 ^ 993437197));
      Dictionary<string, object> rvd = new Dictionary<string, object>();
      ActionDispatcherServiceExtensions.AddParameterValuesFromExpressionToDictionary((IDictionary<string, object>) rvd, body);
      IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(body.Method);
      AuditEventArgs actionInfoFor = new AuditEventArgs(methodActionInfo.Object, methodActionInfo.Action);
      foreach (KeyValuePair<string, object> keyValuePair in (IEnumerable<KeyValuePair<string, object>>) rvd)
        actionInfoFor.ExtendedProperties.Add(keyValuePair.Key, keyValuePair.Value);
      return (IAuditEventArgs) actionInfoFor;
    }

    internal static void StartMethodInvocation(
      [NotNull] this ActionDispatcherService service,
      [NotNull] MethodInfo method,
      params object[] methodArgs)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ActionDispatcherServiceExtensions.MyuZrmftAM1Ls64L9e5q((object) Locator.GetServiceNotNull<IContextBoundVariableService>(), (object) ActionDispatcherService.GetKey(method, methodArgs), new object());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool InterceptMethodInvocation(
      [NotNull] this ActionDispatcherService service,
      [NotNull] MethodInfo method,
      params object[] methodArgs)
    {
      int num = 4;
      object obj;
      IContextBoundVariableService serviceNotNull;
      string key;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_9;
          case 2:
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 0 : 1;
              continue;
            }
            goto case 5;
          case 3:
            key = ActionDispatcherService.GetKey(method, methodArgs);
            num = 6;
            continue;
          case 4:
            serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
            num = 3;
            continue;
          case 5:
            ActionDispatcherServiceExtensions.MyuZrmftAM1Ls64L9e5q((object) serviceNotNull, (object) key, (object) null);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
            continue;
          case 6:
            if (serviceNotNull.TryGetValue<object>(key, out obj))
            {
              num = 2;
              continue;
            }
            goto label_9;
          default:
            goto label_8;
        }
      }
label_8:
      return false;
label_9:
      return true;
    }

    internal static void AddParameterValuesFromExpressionToDictionary(
      [NotNull] IDictionary<string, object> rvd,
      [NotNull] MethodCallExpression call)
    {
      if (rvd == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312518299));
      ParameterInfo[] parameterInfoArray = call != null ? call.Method.GetParameters() : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293501058));
      if (parameterInfoArray.Length == 0)
        return;
      for (int index = 0; index < parameterInfoArray.Length; ++index)
      {
        Expression expression = call.Arguments[index];
        object obj = !(expression is ConstantExpression constantExpression) ? CachedExpressionCompiler.Evaluate(expression) : constantExpression.Value;
        rvd.Add(parameterInfoArray[index].Name, obj);
      }
    }

    internal static object YQSubbftDDhyhkVdsjXA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object nbbw6Jftt3tYHfb4rhh3([In] object obj0, Guid uid) => (object) ((IAuditManager) obj0).GetObject(uid);

    internal static bool A8YdtIftpRYo0BV1EjHQ() => ActionDispatcherServiceExtensions.PJ0UYYft36P5PZ7rU1KQ == null;

    internal static ActionDispatcherServiceExtensions wRIo6kftanRDLnG1VYrp() => ActionDispatcherServiceExtensions.PJ0UYYft36P5PZ7rU1KQ;

    internal static bool IGuO7fftwgXUW8qH3tOy(ActionCheckResult actionCheckResult) => (bool) actionCheckResult;

    internal static bool NWdRksft4FNXoQo3X40S([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object WTbDQSft6wNZo4hlt3NB([In] object obj0) => (object) ((MethodCallExpression) obj0).Method;

    internal static object JRmfmVftHCSCb4Cfidj9([In] object obj0) => (object) ((IAuditEventHolder) obj0).Action;

    internal static void MyuZrmftAM1Ls64L9e5q([In] object obj0, [In] object obj1, [In] object obj2) => ((IAbstractBoundVariableService) obj0).Set((string) obj1, obj2);
  }
}

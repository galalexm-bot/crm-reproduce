// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Entities.EntityScriptingService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.DynamicForms;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Entities
{
  /// <summary>Сервис исполнения сценариев для сущностей</summary>
  [Service(Type = ComponentType.Server)]
  public class EntityScriptingService : IEntityScriptingService
  {
    private static Func<string, Type> getTypeFunc;
    private static EntityScriptingService Ycw8PmbPt7FKPdGqIp3d;

    /// <summary>Фабрика для создания контекста выполнения</summary>
    public IExecutionScopeFactory ExecutionScopeFactory
    {
      get => this.\u003CExecutionScopeFactory\u003Ek__BackingField;
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
              this.\u003CExecutionScopeFactory\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Получить тип модуля сценариев</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    public virtual Type GetScriptModuleType(IEntity entity) => this.GetScriptModuleType(entity, (string) null);

    /// <summary>
    /// Получить тип модуля сценариев, содержащий указанный сценарий (включая модули сценариев, созданные в базовых классах)
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <param name="scriptName">Название сценария</param>
    /// <returns></returns>
    public virtual Type GetScriptModuleType(IEntity entity, string scriptName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (entity != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return EntityScriptingService.pZgPuWbP6a8c6jvXyhgr(entity.CastAsRealType<IEntity>().GetType(), (object) scriptName);
label_3:
      return (Type) null;
    }

    private static Type GetType(object scriptModuleTypeName)
    {
      int num1 = 2;
      int startIndex;
      while (true)
      {
        switch (num1)
        {
          case 1:
            if (startIndex > 0)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
              continue;
            }
            goto label_12;
          case 2:
            startIndex = EntityScriptingService.fc5mVGbPA2WRVORNJ0dc(scriptModuleTypeName, EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(901793403 ^ 901780619));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_12;
          default:
            goto label_2;
        }
      }
label_2:
      Type type;
      try
      {
        if (EntityScriptingService.jSpXm9bP0B6YAhWrOTYL(EntityScriptingService.VIFsXFbPxqs3JuAWV4bN((object) new AssemblyName((string) EntityScriptingService.wElONibP7Ds5XoV5t0js(scriptModuleTypeName, startIndex + 1))), EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(-630932142 - 1120244082 ^ -1751129754)))
        {
          int num2 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
            num2 = 0;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_13;
              case 2:
                goto label_12;
              default:
                type = ComponentManager.FindLoadedAssembly(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858901209), false).GetType(((string) scriptModuleTypeName).Remove(startIndex));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 1;
                continue;
            }
          }
        }
        else
          goto label_12;
      }
      catch
      {
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_12;
        }
      }
label_13:
      return type;
label_12:
      return EntityScriptingService.W4hLohbPmQh5cCHAUaBs(scriptModuleTypeName);
    }

    private static Type GetScriptModuleType(Type entityType, object scriptName)
    {
      int num = 12;
      ClassMetadata classMetadata;
      Type scriptModuleType;
      while (true)
      {
        string scriptName1;
        switch (num)
        {
          case 1:
            goto label_11;
          case 2:
            classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entityType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 14;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            if (!((IEnumerable<MethodInfo>) scriptModuleType.GetMethods()).Any<MethodInfo>((Func<MethodInfo, bool>) (a => (string) EntityScriptingService.\u003C\u003Ec__DisplayClass8_0.Vk1EpWCaIBqSdykxm3o7(EntityScriptingService.\u003C\u003Ec__DisplayClass8_0.npb7I9CauTiUrtqMgBxx((object) a)) == (string) EntityScriptingService.\u003C\u003Ec__DisplayClass8_0.Vk1EpWCaIBqSdykxm3o7((object) scriptName1))))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            }
            goto label_11;
          case 4:
            goto label_14;
          case 5:
          case 9:
            if (!EntityScriptingService.NYjFeSbPdJwT5WgSSMgB(entityType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 13 : 9;
              continue;
            }
            goto case 2;
          case 6:
            if (scriptName1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 8 : 7;
              continue;
            }
            goto label_11;
          case 7:
            if (!EntityScriptingService.aSNA0MbPJAuLd1gAI1co(scriptModuleType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 6 : 2;
              continue;
            }
            goto label_14;
          case 8:
            if (!EntityScriptingService.jmWZ9fbP9OSrQeOLsvQV((object) scriptModuleType.GetMethod(scriptName1), (object) null))
            {
              num = 3;
              continue;
            }
            goto label_11;
          case 10:
            scriptModuleType = EntityScriptingService.getTypeFunc(classMetadata.ScriptModuleTypeName);
            num = 7;
            continue;
          case 11:
            scriptName1 = (string) scriptName;
            num = 9;
            continue;
          case 12:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 3 : 11;
            continue;
          case 13:
            goto label_3;
          case 14:
            if (!EntityScriptingService.c2EZW6bPM6RTQCJLp2yl(EntityScriptingService.jfYHcsbPyEEqFEATBhAX((object) classMetadata)))
            {
              num = 10;
              continue;
            }
            break;
        }
        entityType = entityType.BaseType;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 5;
      }
label_3:
      return (Type) null;
label_11:
      return scriptModuleType;
label_14:
      throw new ScriptExecuteException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1011996845), EntityScriptingService.jfYHcsbPyEEqFEATBhAX((object) classMetadata)));
    }

    private static (Type ScriptModuleType, MethodInfo MethodInfo) GetScriptModuleType(
      Type entityType,
      object scriptMethodInfo,
      object errorTitle)
    {
      if (((ScriptMethodInfo) scriptMethodInfo).MetadataUid != Guid.Empty)
        return EntityScriptingService.GetExecutionData((object) (ClassMetadata) MetadataLoader.LoadMetadata(((ScriptMethodInfo) scriptMethodInfo).MetadataUid), (object) ((ScriptMethodInfo) scriptMethodInfo).Name, errorTitle);
      for (; entityType != (Type) null; entityType = entityType.BaseType)
      {
        (Type type, MethodInfo methodInfo) = EntityScriptingService.GetExecutionData((object) (ClassMetadata) MetadataLoader.LoadMetadata(entityType), (object) ((ScriptMethodInfo) scriptMethodInfo).Name, errorTitle);
        if (type != (Type) null && methodInfo != (MethodInfo) null)
          return (type, methodInfo);
      }
      return ((Type) null, (MethodInfo) null);
    }

    private static (Type, MethodInfo) GetExecutionData(
      object metadata,
      object scriptName,
      object errorTitle)
    {
      if (string.IsNullOrEmpty(((ClassMetadata) metadata).ScriptModuleTypeName))
        return ((Type) null, (MethodInfo) null);
      Type type = EntityScriptingService.getTypeFunc(((ClassMetadata) metadata).ScriptModuleTypeName);
      if (type == (Type) null)
        throw new ScriptExecuteException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647806872), (object) ((ClassMetadata) metadata).ScriptModuleTypeName));
      MethodInfo methodInfo = EntityScriptingService.GetMethodInfo((string) errorTitle, type, (string) scriptName, false);
      if (!(methodInfo == (MethodInfo) null))
        return (type, methodInfo);
      ScriptExecutionService.MethodNotFound(type, (string) scriptName);
      return ((Type) null, (MethodInfo) null);
    }

    /// <summary>
    /// Получить тип сущности, используемый в модуле сценариев сущности
    /// </summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    public virtual Type GetScriptModuleItemType(IEntity entity)
    {
      int num = 5;
      Type scriptModuleType;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!type.IsGenericType)
            {
              num = 9;
              continue;
            }
            goto case 2;
          case 2:
            // ISSUE: type reference
            if (!EntityScriptingService.aSNA0MbPJAuLd1gAI1co(type.GetGenericTypeDefinition(), EntityScriptingService.sygHKObPlUZ3s1LgnGTR(__typeref (EntityScriptModule<>))))
            {
              num = 12;
              continue;
            }
            goto case 6;
          case 4:
            if (!EntityScriptingService.aSNA0MbPJAuLd1gAI1co(scriptModuleType, (Type) null))
            {
              num = 13;
              continue;
            }
            goto label_6;
          case 5:
            scriptModuleType = this.GetScriptModuleType(entity);
            num = 4;
            continue;
          case 6:
          case 11:
            if (EntityScriptingService.NYjFeSbPdJwT5WgSSMgB(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 4 : 10;
              continue;
            }
            goto label_17;
          case 7:
          case 9:
          case 12:
            type = type.BaseType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 3 : 0;
            continue;
          case 8:
            goto label_6;
          case 10:
            goto label_16;
          case 13:
            type = scriptModuleType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            if (!EntityScriptingService.NYjFeSbPdJwT5WgSSMgB(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 6;
              continue;
            }
            goto case 1;
        }
      }
label_6:
      return (Type) null;
label_16:
      return type.GetGenericArguments()[0];
label_17:
      return (Type) null;
    }

    /// <summary>Получить экземпляр модуля сценариев</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    public virtual object GetScriptInstance(IEntity entity)
    {
      int num = 2;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!EntityScriptingService.aSNA0MbPJAuLd1gAI1co(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            type = EntityScriptingService.hAbdWbbPrJW6R9pL9ITw((object) this, (object) entity);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_4;
        }
      }
label_3:
      return (object) null;
label_4:
      return EntityScriptingService.M8UTCnbPgWcRmFXmLSDj(type);
    }

    /// <summary>Получить экземпляр модуля сценариев</summary>
    /// <param name="entity">Сущность</param>
    /// <returns></returns>
    public virtual object GetScriptInstance(IEntity entity, string scriptName)
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = EntityScriptingService.A3bi76bP5SfloYKp1Ght((object) this, (object) entity, (object) scriptName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            if (EntityScriptingService.aSNA0MbPJAuLd1gAI1co(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 2;
              continue;
            }
            goto label_3;
        }
      }
label_2:
      return (object) null;
label_3:
      return EntityScriptingService.M8UTCnbPgWcRmFXmLSDj(type);
    }

    /// <summary>Выполнить сценарий</summary>
    /// <param name="entity">Сущность</param>
    /// <param name="scriptName">Имя сценария</param>
    /// <param name="parameters">Параметры для сценария</param>
    /// <param name="parameterAccessor">Функция, возвращающая значение параметра</param>
    /// <returns>Результат выполнения сценария</returns>
    public virtual object ExecuteScript(
      IEntity entity,
      string scriptName,
      Dictionary<string, object> parameters = null,
      Func<string, Type, object> parameterAccessor = null)
    {
      Contract.ArgumentNotNull((object) entity, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1574260816 ^ 1574305012));
      Contract.ArgumentNotNull((object) scriptName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515100921));
      ScriptMethodInfo scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(scriptName);
      ClassMetadata classMetadata = (ClassMetadata) MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType());
      string str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051276242 - 990076387 ^ 61289479), (object) scriptMethodInfo.Name, (object) entity.ToString(), (object) classMetadata.DisplayName, entity.GetId());
      EleWise.ELMA.Logging.Logger.Log.Debug((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606743678), (object) scriptMethodInfo.Name, (object) entity.ToString(), (object) classMetadata.FullTypeName, entity.GetId()));
      try
      {
        object scriptInstance = (object) null;
        MethodInfo methodInfo = (MethodInfo) null;
        try
        {
          (Type ScriptModuleType, MethodInfo MethodInfo) scriptModuleType1 = EntityScriptingService.GetScriptModuleType(entity.CastAsRealType<IEntity>().GetType(), (object) scriptMethodInfo, (object) str);
          Type scriptModuleType2 = scriptModuleType1.ScriptModuleType;
          if (scriptModuleType2 != (Type) null)
          {
            methodInfo = scriptModuleType1.MethodInfo;
            using (IExecutionScope executionScope = this.ExecutionScopeFactory.CreateScope().AddRegistration(scriptModuleType2, Array.Empty<Type>()).StartScope())
              scriptInstance = executionScope.Resolve(scriptModuleType2);
          }
        }
        catch (Exception ex)
        {
          throw new ScriptExecuteException(str + EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867910548)), ex);
        }
        if (methodInfo == (MethodInfo) null)
        {
          EleWise.ELMA.Logging.Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70179819));
          return (object) null;
        }
        object obj = this.ExecuteScript(str, methodInfo, scriptInstance, entity, parameters, parameterAccessor);
        EleWise.ELMA.Logging.Logger.Log.Debug((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87903567));
        return obj;
      }
      catch (ScriptExecuteException ex)
      {
        EleWise.ELMA.Logging.Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1756976642), (Exception) ex);
        throw;
      }
      catch (Exception ex)
      {
        EleWise.ELMA.Logging.Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1350312861 << 3 ^ 2082209828), ex);
        throw new ScriptExecuteException(str, ex);
      }
    }

    /// <summary>Получить информацию о методе сценария</summary>
    /// <param name="errorTitle"></param>
    /// <param name="type"></param>
    /// <param name="scriptName"></param>
    /// <param name="throwOnNotFound"></param>
    /// <returns></returns>
    protected static MethodInfo GetMethodInfo(
      string errorTitle,
      Type type,
      string scriptName,
      bool throwOnNotFound)
    {
      int num1 = 7;
      string message;
      MethodInfo methodInfo1;
      while (true)
      {
        string scriptName1;
        switch (num1)
        {
          case 1:
            goto label_8;
          case 2:
            if (!throwOnNotFound)
            {
              num1 = 4;
              continue;
            }
            goto label_3;
          case 3:
            goto label_3;
          case 4:
            EntityScriptingService.cImo1Bb1oP1feJUK4lkK(EntityScriptingService.ePL4yXb1WZmeDy1xc7OP(), (object) message);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 1;
            continue;
          case 5:
            try
            {
              string name = ((IEnumerable<string>) EntityScriptingService.roYEYZbPjWEdCsdqxmya((object) scriptName1, (object) new string[1]
              {
                (string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(--1418440330 ^ 1418423596)
              }, StringSplitOptions.None)).First<string>();
              int num2 = 7;
              List<MethodInfo>.Enumerator enumerator;
              while (true)
              {
                int num3;
                string str;
                MethodInfo methodInfo2;
                List<string> parametersList;
                switch (num2)
                {
                  case 1:
                    str = (string) EntityScriptingService.GHWSgkbPUdbsuRrOxYe2(EntityScriptingService.wElONibP7Ds5XoV5t0js((object) name, EntityScriptingService.iSatrEbPLAvVE5Sv0OI4((object) name, '(') + 1), EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(1925118608 << 2 ^ -889457156), (object) "");
                    num2 = 6;
                    continue;
                  case 2:
                    methodInfo2 = type.GetMethod(name);
                    if ((object) methodInfo2 == null)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 9 : 0;
                      continue;
                    }
                    goto label_36;
                  case 3:
                  case 5:
                    goto label_6;
                  case 4:
                    // ISSUE: reference to a compiler-generated method
                    enumerator = ((IEnumerable<MethodInfo>) type.GetMethods()).ToList<MethodInfo>().Where<MethodInfo>((Func<MethodInfo, bool>) (q => ((IEnumerable<ParameterInfo>) q.GetParameters()).Count<ParameterInfo>() == EntityScriptingService.\u003C\u003Ec__DisplayClass15_1.idt88UCaOkZhPDhpsRcb((object) parametersList))).ToList<MethodInfo>().GetEnumerator();
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
                    continue;
                  case 6:
                    parametersList = ((IEnumerable<string>) EntityScriptingService.roYEYZbPjWEdCsdqxmya((object) str, (object) new string[1]
                    {
                      (string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(--1360331293 ^ 1360334367)
                    }, StringSplitOptions.None)).ToList<string>();
                    num2 = 4;
                    continue;
                  case 7:
                    if (!EntityScriptingService.Hhbn4XbPYeNah0Hp6jW9((object) name, EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(654297945 ^ 654300399)))
                    {
                      num3 = 2;
                      break;
                    }
                    goto case 8;
                  case 8:
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
                    continue;
                  case 9:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    methodInfo2 = ((IEnumerable<MethodInfo>) type.GetMethods()).FirstOrDefault<MethodInfo>((Func<MethodInfo, bool>) (a => EntityScriptingService.\u003C\u003Ec__DisplayClass15_0.YodCX3CaKxldSlmcEWkk((object) ((string) EntityScriptingService.\u003C\u003Ec__DisplayClass15_0.QxHCOTCaRFO3UkLtlbDo((object) a)).ToLower(), EntityScriptingService.\u003C\u003Ec__DisplayClass15_0.JFy3iGCaqAQNuEVgbvUh((object) scriptName1))));
                    goto label_36;
                  default:
                    goto label_14;
                }
label_10:
                num2 = num3;
                continue;
label_36:
                methodInfo1 = methodInfo2;
                num3 = 3;
                goto label_10;
              }
label_14:
              try
              {
label_22:
                if (enumerator.MoveNext())
                  goto label_17;
                else
                  goto label_23;
label_16:
                MethodInfo current;
                List<string> list;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      list = ((IEnumerable<ParameterInfo>) EntityScriptingService.GqGRqxbPs9dIwhPmcljN((object) current)).Select<ParameterInfo, string>((Func<ParameterInfo, string>) (q =>
                      {
                        int num5 = 1;
                        string str;
                        while (true)
                        {
                          switch (num5)
                          {
                            case 1:
                              // ISSUE: reference to a compiler-generated method
                              str = (string) EntityScriptingService.\u003C\u003Ec.AHQtcPCaNCObdNy6QWbW(q.ParameterType);
                              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
                              continue;
                            default:
                              goto label_3;
                          }
                        }
label_3:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        return (string) EntityScriptingService.\u003C\u003Ec.IP5XpjCap045swOGCuZc((object) str, 1, EntityScriptingService.\u003C\u003Ec.XlITKXCa37LtPdBtC87d((object) str) - 2);
                      })).ToList<string>();
                      num4 = 4;
                      continue;
                    case 2:
                      goto label_22;
                    case 3:
                    case 6:
                      goto label_6;
                    case 4:
                      if (!EntityScriptingService.nLXeUjb1FjEIZNQYfo3S(EntityScriptingService.TS8BgbbPzBEwy9qFQhHP((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1242972401 >> 4 ^ 77708865), EntityScriptingService.meXal6bPcoBru4aB10Eh((object) current), (object) string.Join((string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(-740338220 ^ -740337194), (IEnumerable<string>) list)), (object) name))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_22;
                    case 5:
                      goto label_17;
                    default:
                      methodInfo1 = current;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 6 : 4;
                      continue;
                  }
                }
label_17:
                current = enumerator.Current;
                num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
                {
                  num4 = 1;
                  goto label_16;
                }
                else
                  goto label_16;
label_23:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 1;
                goto label_16;
              }
              finally
              {
                enumerator.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
                num7 = 0;
              switch (num7)
              {
                default:
                  throw new ScriptExecuteException((string) EntityScriptingService.eILpAGb1BoiDwaKIshGh((object) errorTitle, (object) EleWise.ELMA.SR.T((string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(-688192331 - 435440695 ^ -1123788010), (object) scriptName1)), ex);
              }
            }
          case 6:
            scriptName1 = scriptName;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 8 : 0;
            continue;
          case 7:
            num1 = 6;
            continue;
          case 8:
            methodInfo1 = (MethodInfo) null;
            num1 = 5;
            continue;
          case 9:
            goto label_44;
        }
label_6:
        if (EntityScriptingService.jmWZ9fbP9OSrQeOLsvQV((object) methodInfo1, (object) null))
        {
          num1 = 9;
        }
        else
        {
          message = (string) EntityScriptingService.eILpAGb1BoiDwaKIshGh((object) errorTitle, (object) EleWise.ELMA.SR.T((string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(-2107978722 ^ -2108149816), (object) scriptName1));
          num1 = 2;
        }
      }
label_3:
      throw new ScriptExecuteException(message);
label_8:
      return (MethodInfo) null;
label_44:
      return methodInfo1;
    }

    private static string GetTypeInfo(Type type)
    {
      int num1 = 9;
      string typeInfo;
      while (true)
      {
        int num2 = num1;
        List<string> values;
        Type type1;
        string str;
        int index;
        Type[] genericArguments;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_16;
            case 3:
            case 5:
              if (index < genericArguments.Length)
              {
                num2 = 13;
                continue;
              }
              goto case 14;
            case 4:
              ++index;
              num2 = 5;
              continue;
            case 6:
              genericArguments = type.GetGenericArguments();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 1 : 15;
              continue;
            case 7:
            case 13:
              type1 = genericArguments[index];
              num2 = 11;
              continue;
            case 9:
              if (!type.IsGenericType)
              {
                num2 = 8;
                continue;
              }
              goto case 12;
            case 10:
              typeInfo = (string) EntityScriptingService.Oxr78cb1bWyjN7KEtKNk(EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(-867826612 ^ -867770834), (object) type.Namespace, (object) type.Name, (object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 1 : 1;
              continue;
            case 11:
              goto label_3;
            case 12:
              values = new List<string>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 6;
              continue;
            case 14:
              str = string.Join((string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(1113862659 ^ 1113874675), (IEnumerable<string>) values);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 10 : 7;
              continue;
            case 15:
              index = 0;
              num2 = 3;
              continue;
            default:
              typeInfo = string.Format((string) EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(1470440286 ^ 1470613322), (object) type.Namespace, (object) type.Name);
              num2 = 2;
              continue;
          }
        }
label_3:
        values.Add(EntityScriptingService.GetTypeInfo(type1));
        num1 = 4;
      }
label_16:
      return typeInfo;
    }

    /// <summary>Выполнить сценарий</summary>
    /// <param name="errorTitle"></param>
    /// <param name="methodInfo"></param>
    /// <param name="scriptInstance"></param>
    /// <param name="entity"></param>
    /// <param name="parameters"></param>
    /// <returns></returns>
    protected virtual object ExecuteScript(
      string errorTitle,
      MethodInfo methodInfo,
      object scriptInstance,
      IEntity entity,
      Dictionary<string, object> parameters,
      Func<string, Type, object> parameterAccessor = null)
    {
      parameters = parameters ?? new Dictionary<string, object>();
      parameters[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576189696)] = (object) entity;
      List<object> objectList = new List<object>();
      foreach (ParameterInfo parameter in methodInfo.GetParameters())
      {
        object obj;
        if (parameters.TryGetValue(parameter.Name, out obj) && (obj == null || parameter.ParameterType.IsAssignableFrom(obj.GetType())))
        {
          objectList.Add(obj);
        }
        else
        {
          obj = (object) null;
          if (parameterAccessor != null)
            obj = parameterAccessor(parameter.Name, parameter.ParameterType);
          if (obj == null && parameter.ParameterType.IsValueType)
            obj = Activator.CreateInstance(parameter.ParameterType);
          objectList.Add(obj);
        }
      }
      object obj1;
      try
      {
        obj1 = EntityScriptingService.InvokeWithDiagnostics(methodInfo, scriptInstance, objectList.ToArray(), errorTitle);
        DynamicFormHelper.ProcessNewTablePartItems(entity, (IEntityMetadata) MetadataLoader.LoadMetadata(entity.CastAsRealType<IEntity>().GetType()));
      }
      catch (TargetInvocationException ex)
      {
        throw new ScriptExecuteException(errorTitle + (ex.InnerException ?? (Exception) ex).Message, (Exception) ex);
      }
      catch (Exception ex)
      {
        throw new ScriptExecuteException(errorTitle + ex.Message, ex);
      }
      return obj1;
    }

    public static object InvokeWithDiagnostics(
      MethodInfo methodInfo,
      object scriptInstance,
      object[] invokedParams,
      string errorTitle)
    {
      int num1 = 6;
      object result;
      while (true)
      {
        int num2 = num1;
        object scriptInstance1;
        MethodInfo methodInfo1;
        object[] invokedParams1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              methodInfo1 = methodInfo;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_10;
            case 3:
              goto label_4;
            case 4:
              goto label_6;
            case 5:
              scriptInstance1 = scriptInstance;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 0;
              continue;
            case 6:
              num2 = 5;
              continue;
            case 7:
              result = (object) null;
              num2 = 2;
              continue;
            default:
              invokedParams1 = invokedParams;
              num2 = 4;
              continue;
          }
        }
label_6:
        string errorTitle1 = errorTitle;
        num1 = 7;
        continue;
label_10:
        System.Action action;
        DiagnosticsManager.StartCall<ScriptCallInfo>((Func<ScriptCallInfo>) (() => new ScriptCallInfo(scriptInstance1.GetType(), (string) null, methodInfo1, invokedParams1)), (System.Action) (() =>
        {
          int num4 = 2;
          while (true)
          {
            System.Action action1;
            System.Action action2;
            switch (num4)
            {
              case 0:
                goto label_2;
              case 1:
                action = action1 = (System.Action) (() =>
                {
                  int num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 0:
                        goto label_2;
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        result = EntityScriptingService.\u003C\u003Ec__DisplayClass18_0.YdjHWCCa43ZBsXcUf177((object) methodInfo1, scriptInstance1, (object) invokedParams1);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_4;
                    }
                  }
label_2:
                  return;
label_4:;
                });
                num4 = 3;
                continue;
              case 2:
                action2 = action;
                if (action2 == null)
                {
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 1 : 0;
                  continue;
                }
                break;
              case 3:
                action2 = action1;
                break;
              default:
                goto label_8;
            }
            // ISSUE: reference to a compiler-generated method
            EntityScriptingService.\u003C\u003Ec__DisplayClass18_0.GUpnYcCaw0M9LorvP9A7((object) action2, (object) errorTitle1);
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
          }
label_2:
          return;
label_8:;
        }));
        num1 = 3;
      }
label_4:
      return result;
    }

    public EntityScriptingService()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static EntityScriptingService()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            // ISSUE: type reference
            ParameterExpression parameterExpression1 = (ParameterExpression) EntityScriptingService.UL5UDHb1GUGu1nhgiZAp(EntityScriptingService.sygHKObPlUZ3s1LgnGTR(__typeref (string)), EntityScriptingService.PfRHWebPH8jwvgxdW5Hy(1505778440 - 1981636111 ^ -475838817));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
            continue;
          case 2:
            EntityScriptingService.TRl5Y7b1hBaE5qMwZy9d();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
          case 3:
            goto label_2;
          default:
            EntityScriptingService.getTypeFunc = MetadataLoader.UseCachingForFunc<string, Type>((Expression<Func<string, Type>>) (parameterExpression => EntityScriptingService.GetType(parameterExpression)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 3;
            continue;
        }
      }
label_2:;
    }

    internal static bool RGXWIqbPwhX7UtYqbdXm() => EntityScriptingService.Ycw8PmbPt7FKPdGqIp3d == null;

    internal static EntityScriptingService fc1XN9bP4PFhs43UiQTL() => EntityScriptingService.Ycw8PmbPt7FKPdGqIp3d;

    internal static Type pZgPuWbP6a8c6jvXyhgr(Type entityType, [In] object obj1) => EntityScriptingService.GetScriptModuleType(entityType, obj1);

    internal static object PfRHWebPH8jwvgxdW5Hy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int fc5mVGbPA2WRVORNJ0dc([In] object obj0, [In] object obj1) => ((string) obj0).IndexOf((string) obj1);

    internal static object wElONibP7Ds5XoV5t0js([In] object obj0, [In] int obj1) => (object) ((string) obj0).Substring(obj1);

    internal static object VIFsXFbPxqs3JuAWV4bN([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static bool jSpXm9bP0B6YAhWrOTYL([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static Type W4hLohbPmQh5cCHAUaBs([In] object obj0) => ReflectionType.GetType((string) obj0);

    internal static object jfYHcsbPyEEqFEATBhAX([In] object obj0) => (object) ((ClassMetadata) obj0).ScriptModuleTypeName;

    internal static bool c2EZW6bPM6RTQCJLp2yl([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool aSNA0MbPJAuLd1gAI1co([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool jmWZ9fbP9OSrQeOLsvQV([In] object obj0, [In] object obj1) => (MethodInfo) obj0 != (MethodInfo) obj1;

    internal static bool NYjFeSbPdJwT5WgSSMgB([In] Type obj0, [In] Type obj1) => obj0 != obj1;

    internal static Type sygHKObPlUZ3s1LgnGTR([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static Type hAbdWbbPrJW6R9pL9ITw([In] object obj0, [In] object obj1) => ((EntityScriptingService) obj0).GetScriptModuleType((IEntity) obj1);

    internal static object M8UTCnbPgWcRmFXmLSDj(Type type) => Locator.GetServiceNotNull(type);

    internal static Type A3bi76bP5SfloYKp1Ght([In] object obj0, [In] object obj1, [In] object obj2) => ((EntityScriptingService) obj0).GetScriptModuleType((IEntity) obj1, (string) obj2);

    internal static object roYEYZbPjWEdCsdqxmya([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((string[]) obj1, obj2);

    internal static bool Hhbn4XbPYeNah0Hp6jW9([In] object obj0, [In] object obj1) => ((string) obj0).Contains((string) obj1);

    internal static int iSatrEbPLAvVE5Sv0OI4([In] object obj0, [In] char obj1) => ((string) obj0).IndexOf(obj1);

    internal static object GHWSgkbPUdbsuRrOxYe2([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0).Replace((string) obj1, (string) obj2);

    internal static object GqGRqxbPs9dIwhPmcljN([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object meXal6bPcoBru4aB10Eh([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static object TS8BgbbPzBEwy9qFQhHP([In] object obj0, [In] object obj1, [In] object obj2) => (object) string.Format((string) obj0, obj1, obj2);

    internal static bool nLXeUjb1FjEIZNQYfo3S([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object eILpAGb1BoiDwaKIshGh([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object ePL4yXb1WZmeDy1xc7OP() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void cImo1Bb1oP1feJUK4lkK([In] object obj0, [In] object obj1) => ((ILogger) obj0).Warn(obj1);

    internal static object Oxr78cb1bWyjN7KEtKNk(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) string.Format((string) obj0, obj1, obj2, obj3);
    }

    internal static void TRl5Y7b1hBaE5qMwZy9d() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object UL5UDHb1GUGu1nhgiZAp([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.AbstractActionExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Абстрактный обработчик выполнения действия</summary>
  [Component]
  public abstract class AbstractActionExecutionHandler : IActionExecutionHandler
  {
    private readonly IExecutionScopeFactory executionScopeFactory;
    private static AbstractActionExecutionHandler HRojDdbuOs7fbfQvEM8k;

    /// <summary>Ctor</summary>
    /// <param name="executionScopeFactory">Фабрика для создания контекста выполнения</param>
    protected AbstractActionExecutionHandler(IExecutionScopeFactory executionScopeFactory)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.executionScopeFactory = executionScopeFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public abstract bool Check(ActionExecutionParams parameters);

    /// <inheritdoc />
    public abstract ActionExecutionResult Execute(ActionExecutionParams parameters);

    /// <summary>Выполнить действие</summary>
    /// <param name="executorType">Тип исполнителя</param>
    /// <param name="parameters">Параметры выполнения действия</param>
    /// <returns>Результат выполнения действия</returns>
    protected ActionExecutionResult Execute(Type executorType, ActionExecutionParams parameters)
    {
      int num1 = 1;
      IExecutionScope executionScope;
      while (true)
      {
        switch (num1)
        {
          case 1:
            executionScope = ((IExecutionScopeBuilder) AbstractActionExecutionHandler.CjQZyXbuPZ5enFxDLL49((object) this.executionScopeFactory)).AddRegistration(executorType, Array.Empty<Type>()).StartScope();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_31;
          default:
            goto label_2;
        }
      }
label_2:
      ActionExecutionResult actionExecutionResult1;
      try
      {
        object executorInstance = AbstractActionExecutionHandler.pd9PV6bu1nZxiEe9ewYS((object) executionScope, executorType);
        int num2 = 2;
        object result;
        MethodInfo methodInfo;
        ScriptMethodInfo scriptMethodInfo;
        while (true)
        {
          switch (num2)
          {
            case 1:
              scriptMethodInfo = ScriptMethodInfoHelper.Deserialize((string) AbstractActionExecutionHandler.f6yrLkbupF8foabWeqOu((object) parameters));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 4 : 4;
              continue;
            case 2:
              if (executorInstance != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
                continue;
              }
              goto label_20;
            case 3:
              goto label_18;
            case 4:
              methodInfo = ScriptHelper.GetMethodInfo(executorType, (string) AbstractActionExecutionHandler.whjuDWbua8FVZDYEePPl((object) scriptMethodInfo));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 4 : 8;
              continue;
            case 5:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
              continue;
            case 6:
label_7:
              ActionExecutionResult actionExecutionResult2 = new ActionExecutionResult();
              AbstractActionExecutionHandler.Wqj7tkbuHKGCoMTL40lK((object) actionExecutionResult2, (object) AbstractActionExecutionHandler.SerializeResult(result, AbstractActionExecutionHandler.v0S27Xbu4brCvxnWYBvp((object) methodInfo), parameters.ReturnType, (EntityTypeSerializationSettings[]) AbstractActionExecutionHandler.peA4Dfbu6CdnCEeiRjQR((object) parameters)));
              actionExecutionResult1 = actionExecutionResult2;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 4 : 9;
              continue;
            case 7:
              goto label_20;
            case 8:
              if (!AbstractActionExecutionHandler.MDio4BbuD9mEFhZEP8u0((object) methodInfo, (object) null))
              {
                num2 = 5;
                continue;
              }
              goto label_18;
            case 9:
              goto label_31;
            default:
              try
              {
                result = this.ExecuteMethod(methodInfo, executorInstance, parameters);
                int num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
                  num3 = 0;
                switch (num3)
                {
                  default:
                    goto label_7;
                }
              }
              catch (Exception ex)
              {
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
                  num4 = 0;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_16;
                    default:
                      AbstractActionExecutionHandler.Vceu2Ibuwo7cJrfVOX9T(AbstractActionExecutionHandler.tNLR0ybuthjXJfoQDEiq(), (object) EleWise.ELMA.SR.T((string) AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(-643786247 ^ -643804931), AbstractActionExecutionHandler.whjuDWbua8FVZDYEePPl((object) scriptMethodInfo), (object) executorType), (object) ex);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_16:
                throw;
              }
          }
        }
label_18:
        throw new Exception(EleWise.ELMA.SR.T((string) AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(-1217523399 ^ -1217615545), (object) executorType, AbstractActionExecutionHandler.whjuDWbua8FVZDYEePPl((object) scriptMethodInfo)));
label_20:
        throw new Exception((string) AbstractActionExecutionHandler.qlVV6Nbu3JhxoySFtaSa(AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(-1824388195 ^ -1824476227)));
      }
      finally
      {
        if (executionScope != null)
        {
          int num5 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
            num5 = 0;
          while (true)
          {
            switch (num5)
            {
              case 1:
                AbstractActionExecutionHandler.KRcgZgbuAQSNZYwrB3PD((object) executionScope);
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
                continue;
              default:
                goto label_29;
            }
          }
        }
label_29:;
      }
label_31:
      return actionExecutionResult1;
    }

    /// <summary>Вызвать метод</summary>
    /// <param name="method">Метод</param>
    /// <param name="executorInstance">Объект вызываемого метода</param>
    /// <param name="parameters">Параметры</param>
    /// <returns></returns>
    protected virtual object Invoke(
      MethodInfo method,
      object executorInstance,
      object[] parameters)
    {
      return AbstractActionExecutionHandler.GuCU6pbu7rt1n8T3oBaY((object) method, executorInstance, (object) parameters, (object) string.Empty);
    }

    /// <summary>Десериализовать входной параметр</summary>
    /// <param name="model">Модель входного</param>
    /// <param name="runtimeType">Тип параметра в рантайме</param>
    /// <param name="typeSignature">Сигнатура параметра</param>
    /// <returns>Входной параметр</returns>
    protected static object DeserializeParameter(
      string model,
      Type runtimeType,
      TypeSignature typeSignature)
    {
      int num1 = 28;
      Guid typeUid;
      Guid subTypeUid;
      IActionExecutionParamModel functionRequest;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          System.Action action;
          TypeSettings typeSettings;
          ISecurityService service;
          ITypeDescriptor typeDescriptor;
          object obj;
          Type type1;
          Type targetType;
          Type type2;
          ISerializableTypeDescriptor serializableTypeDescriptor;
          ClassMetadata requestMetadata;
          PropertyMetadata paramPropertyMetadata;
          IDictionary<string, object> dict;
          switch (num2)
          {
            case 1:
            case 5:
            case 8:
              action = (System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      serializableTypeDescriptor.Deserialize((object) functionRequest, requestMetadata, paramPropertyMetadata, dict);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
              num2 = 12;
              continue;
            case 2:
              dict = (IDictionary<string, object>) null;
              num2 = 30;
              continue;
            case 3:
            case 11:
              AbstractActionExecutionHandler.a1HOebbuYXHJtyx2n3Qw((object) service, (object) action);
              num2 = 16;
              continue;
            case 4:
            case 21:
              goto label_17;
            case 6:
              AbstractActionExecutionHandler.q32KMJbujU5thwyITKdm((object) action);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 8 : 22;
              continue;
            case 7:
              obj = new JsonSerializer().Deserialize(model, targetType);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 19 : 18;
              continue;
            case 9:
              PropertyMetadata propertyMetadata = new PropertyMetadata();
              propertyMetadata.Name = (string) AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(~-122002947 ^ 122103664);
              propertyMetadata.TypeUid = typeUid;
              AbstractActionExecutionHandler.yugSFpbu9PlWsZbEyH48((object) propertyMetadata, subTypeUid);
              AbstractActionExecutionHandler.XR7PBxbud5RFHQaxb23y((object) propertyMetadata, (object) typeSettings);
              AbstractActionExecutionHandler.sa9T4KburHIX7nNUC3oP((object) propertyMetadata, AbstractActionExecutionHandler.m3E5qsbulIqRM5q4IN90((object) typeSignature));
              paramPropertyMetadata = propertyMetadata;
              num2 = 2;
              continue;
            case 10:
              serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 18 : 23;
              continue;
            case 12:
              service = Locator.GetService<ISecurityService>();
              num2 = 20;
              continue;
            case 13:
              subTypeUid = AbstractActionExecutionHandler.xQqZMkbu0adnDFJXllqd((object) typeSignature);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 25;
              continue;
            case 14:
              if (!(typeUid == BinaryFileDescriptor.UID))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 19 : 29;
                continue;
              }
              goto case 32;
            case 15:
              // ISSUE: type reference
              type2 = AbstractActionExecutionHandler.KeSxBfbuMgg47bMvRhd4(__typeref (ExpandoObject));
              break;
            case 16:
            case 22:
              goto label_30;
            case 17:
              // ISSUE: type reference
              type1 = AbstractActionExecutionHandler.KeSxBfbuMgg47bMvRhd4(__typeref (ActionExecutionParamModel<>)).MakeGenericType(runtimeType);
              num2 = 33;
              continue;
            case 18:
              requestMetadata = new ClassMetadata();
              num2 = 9;
              continue;
            case 19:
              dict = (IDictionary<string, object>) new Dictionary<string, object>()
              {
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312951733),
                  obj
                }
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 4 : 5;
              continue;
            case 20:
              if (service == null)
                goto case 6;
              else
                goto label_12;
            case 23:
              if (typeDescriptor == null)
              {
                num2 = 4;
                continue;
              }
              goto case 24;
            case 24:
              if (serializableTypeDescriptor != null)
              {
                typeSettings = (TypeSettings) AbstractActionExecutionHandler.UJZbXGbuypOp3I8CJANh(AbstractActionExecutionHandler.edG68Zbum9WHSE4t222H((object) typeDescriptor), (object) typeSignature);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 8 : 17;
                continue;
              }
              num2 = 21;
              continue;
            case 25:
              typeDescriptor = AbstractActionExecutionHandler.MetadataService.GetTypeDescriptor(typeUid, subTypeUid);
              num2 = 10;
              continue;
            case 26:
            case 29:
              dict = (IDictionary<string, object>) new Dictionary<string, object>()
              {
                {
                  (string) AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(--1418440330 ^ 1418270712),
                  (object) model
                }
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 8;
              continue;
            case 27:
              typeUid = AbstractActionExecutionHandler.JJ3Tg3bux14o0nrxWxdZ((object) typeSignature);
              num2 = 13;
              continue;
            case 28:
              num2 = 27;
              continue;
            case 30:
              if (model == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                continue;
              }
              goto default;
            case 31:
              if (AbstractActionExecutionHandler.etr8Gibu5CXDhtq52T4R((object) typeSignature) == RelationType.ManyToMany)
              {
                // ISSUE: type reference
                type2 = AbstractActionExecutionHandler.KeSxBfbuMgg47bMvRhd4(__typeref (SerializableList<ExpandoObject>));
                break;
              }
              num2 = 15;
              continue;
            case 32:
              if (!AbstractActionExecutionHandler.QBq9g0bugZxk4FeEOEbh(typeUid, ListOfSimpleTypeDescriptor.UID))
              {
                num2 = 31;
                continue;
              }
              type2 = typeof (SerializableList<object>);
              break;
            case 33:
              functionRequest = (IActionExecutionParamModel) AbstractActionExecutionHandler.F1gJxcbuJAyKeYrxExNN(type1);
              num2 = 18;
              continue;
            default:
              if (!(subTypeUid != Guid.Empty))
              {
                num2 = 14;
                continue;
              }
              goto case 32;
          }
          targetType = type2;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 7 : 7;
        }
label_12:
        num1 = 3;
      }
label_17:
      throw new Exception(EleWise.ELMA.SR.T((string) AbstractActionExecutionHandler.L5X4b1buNZc8t0rMOIZj(1581325282 << 3 ^ -234199082), (object) typeUid, (object) subTypeUid));
label_30:
      return AbstractActionExecutionHandler.Gjv62FbuLomtwyQ7SCgO((object) functionRequest);
    }

    /// <summary>Сериализовать результат выполнения действия</summary>
    /// <param name="result">Результат выполнения действия</param>
    /// <param name="runtimeType">Тип результата в рантайме</param>
    /// <param name="typeSignature">Сигнатура типа результат</param>
    /// <param name="entityDependencies">Зависимости от сущностей</param>
    /// <returns>Результат выполнения действия</returns>
    protected static IDictionary<string, object> SerializeResult(
      object result,
      Type runtimeType,
      TypeSignature typeSignature,
      EntityTypeSerializationSettings[] entityDependencies)
    {
      if (result == null || runtimeType == typeof (void))
        return (IDictionary<string, object>) null;
      Guid typeUid = typeSignature.TypeUid;
      Guid subTypeUid = typeSignature.SubTypeUid;
      ITypeDescriptor typeDescriptor = AbstractActionExecutionHandler.MetadataService.GetTypeDescriptor(typeUid, subTypeUid);
      ISerializableTypeDescriptor serializableTypeDescriptor = typeDescriptor as ISerializableTypeDescriptor;
      if (typeDescriptor == null || serializableTypeDescriptor == null)
        throw new Exception(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461459807), (object) typeUid, (object) subTypeUid));
      TypeSettings typeSettings = AbstractActionExecutionHandler.CreateTypeSettings(typeDescriptor.SettingsType, (object) typeSignature);
      IExecuteFunctionResponse instance = (IExecuteFunctionResponse) Activator.CreateInstance(typeof (ExecuteFunctionResponse<>).MakeGenericType(runtimeType));
      instance.Result = result;
      ClassMetadata metadata1 = new ClassMetadata();
      PropertyMetadata propertyMetadata1 = new PropertyMetadata();
      propertyMetadata1.Name = z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979335239);
      propertyMetadata1.TypeUid = typeUid;
      propertyMetadata1.SubTypeUid = subTypeUid;
      propertyMetadata1.Settings = typeSettings;
      propertyMetadata1.Nullable = typeSignature.Nullable;
      PropertyMetadata propertyMetadata2 = propertyMetadata1;
      EntitySerializationSettings settings = new EntitySerializationSettings()
      {
        WriteReferences = true
      };
      if (entityDependencies != null && entityDependencies.Length != 0)
      {
        settings.Mode = EntitySerializationMode.Default;
        // ISSUE: reference to a compiler-generated method
        settings.TypePropertySelector = ((IEnumerable<EntityTypeSerializationSettings>) entityDependencies).ToDictionary<EntityTypeSerializationSettings, Guid, EntitySerializationSelector>((Func<EntityTypeSerializationSettings, Guid>) (dependency => AbstractActionExecutionHandler.\u003C\u003Ec.npS4RwCPE9uDCmii8eHJ((object) dependency)), (Func<EntityTypeSerializationSettings, EntitySerializationSelector>) (dependency =>
        {
          int num1 = 8;
          EntityMetadata metadata2;
          List<string> properties;
          while (true)
          {
            int num2 = num1;
            string[] strArray;
            int index;
            IPropertyMetadata[] array;
            string name;
            while (true)
            {
              switch (num2)
              {
                case 1:
                  goto label_10;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  properties.Add((string) AbstractActionExecutionHandler.\u003C\u003Ec.gq8DliCPQ9kpPFj8antE(-1837662597 ^ -1837690391));
                  num2 = 4;
                  continue;
                case 4:
                  goto label_6;
                case 5:
                  name = strArray[index];
                  num2 = 14;
                  continue;
                case 6:
                case 15:
                  ++index;
                  num2 = 3;
                  continue;
                case 7:
                  properties = dependency.Properties;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 9 : 12;
                  continue;
                case 8:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  metadata2 = ((IMetadataService) AbstractActionExecutionHandler.\u003C\u003Ec.yUmyThCPf0dHW1U5JPsB()).GetMetadata(AbstractActionExecutionHandler.\u003C\u003Ec.npS4RwCPE9uDCmii8eHJ((object) dependency)) as EntityMetadata;
                  num2 = 7;
                  continue;
                case 9:
                  index = 0;
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
                  continue;
                case 10:
                  properties.Remove(name);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 6 : 4;
                  continue;
                case 11:
                  // ISSUE: reference to a compiler-generated method
                  strArray = (string[]) AbstractActionExecutionHandler.\u003C\u003Ec.Sr3ZlaCPCh4C3AlCnsWt((object) properties);
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 7 : 9;
                  continue;
                case 12:
                  // ISSUE: reference to a compiler-generated method
                  if (!properties.Contains((string) AbstractActionExecutionHandler.\u003C\u003Ec.gq8DliCPQ9kpPFj8antE(323422137 << 2 ^ 1293709686)))
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 2 : 0;
                    continue;
                  }
                  goto label_6;
                case 13:
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 1 : 5;
                  continue;
                case 14:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (((IEnumerable<IPropertyMetadata>) array).FirstOrDefault<IPropertyMetadata>((Func<IPropertyMetadata, bool>) (a => AbstractActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.EcGqtfCPWMpdk98lmU8F(AbstractActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.WukOmBCPBotQUeDDXMgT((object) a), (object) name))) != null)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 6 : 15;
                    continue;
                  }
                  goto case 10;
                default:
                  if (index >= strArray.Length)
                  {
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 1 : 0;
                    continue;
                  }
                  goto case 13;
              }
            }
label_6:
            array = metadata2.GetPropertiesAndTableParts().ToArray<IPropertyMetadata>();
            num1 = 11;
          }
label_10:
          // ISSUE: reference to a compiler-generated method
          return (EntitySerializationSelector) AbstractActionExecutionHandler.\u003C\u003Ec.Hj7Dk8CPvuIaBLEGetEU((object) string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825373686), (IEnumerable<string>) properties), (object) metadata2);
        }));
      }
      return serializableTypeDescriptor.Serialize((object) instance, metadata1, propertyMetadata2, settings) ?? (IDictionary<string, object>) null;
    }

    private object ExecuteMethod(
      MethodInfo method,
      object executorInstance,
      ActionExecutionParams parameters)
    {
      int num = 1;
      object obj1;
      object obj2;
      ParameterInfo[] parameterInfoArray;
      while (true)
      {
        switch (num)
        {
          case 1:
            parameterInfoArray = (ParameterInfo[]) AbstractActionExecutionHandler.knvmIkbuU9ofMSQH4fI0((object) method);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          case 2:
          case 3:
            obj1 = AbstractActionExecutionHandler.DeserializeParameter((string) AbstractActionExecutionHandler.p9XF3ybucM4Z9C7i4lNp((object) parameters), parameterInfoArray[0].ParameterType, (TypeSignature) AbstractActionExecutionHandler.tkWAoEbuzG3d91iJEA64((object) parameters));
            num = 6;
            continue;
          case 4:
          case 7:
            goto label_3;
          case 5:
            obj2 = AbstractActionExecutionHandler.h1QwLLbusYqhLnJmkdJN((object) this, (object) method, executorInstance, (object) new object[0]);
            num = 7;
            continue;
          case 6:
            obj2 = AbstractActionExecutionHandler.h1QwLLbusYqhLnJmkdJN((object) this, (object) method, executorInstance, (object) new object[1]
            {
              obj1
            });
            num = 4;
            continue;
          default:
            if (parameterInfoArray.Length != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 3;
              continue;
            }
            goto case 5;
        }
      }
label_3:
      return obj2;
    }

    private static IMetadataService MetadataService => (IMetadataService) AbstractActionExecutionHandler.UFgFhjbIFo8DW0WqJjxd();

    private static TypeSettings CreateTypeSettings(Type settingsType, object type)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (AbstractActionExecutionHandler.BmNkoXbIB8IrMkOqXVWY(settingsType, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (TypeSettings) null;
label_5:
      TypeSettings typeSettings;
      switch (typeSettings = (TypeSettings) AbstractActionExecutionHandler.F1gJxcbuJAyKeYrxExNN(settingsType))
      {
        case null:
          return typeSettings;
        case DataClassSettings dataClassSettings:
          AbstractActionExecutionHandler.KO3VRWbIWYcpCgr71XZ0((object) dataClassSettings, AbstractActionExecutionHandler.etr8Gibu5CXDhtq52T4R(type));
          return typeSettings;
        case EntitySettings entitySettings:
          AbstractActionExecutionHandler.RlYSk5bIoM8cjMoUXtwc((object) entitySettings, ((TypeSignature) type).RelationType);
          return typeSettings;
        case ListOfSimpleTypeSettings simpleTypeSettings:
          simpleTypeSettings.SimpleTypeUid = ((TypeSignature) type).SubTypeUid;
          return typeSettings;
        default:
          return typeSettings;
      }
    }

    internal static bool ShAhQIbu2OgeIAW2KDh1() => AbstractActionExecutionHandler.HRojDdbuOs7fbfQvEM8k == null;

    internal static AbstractActionExecutionHandler KxqfrmbuehxxIN1Qdp6f() => AbstractActionExecutionHandler.HRojDdbuOs7fbfQvEM8k;

    internal static object CjQZyXbuPZ5enFxDLL49([In] object obj0) => (object) ((IExecutionScopeFactory) obj0).CreateScope();

    internal static object pd9PV6bu1nZxiEe9ewYS([In] object obj0, Type objectType) => ((IExecutionScope) obj0).Resolve(objectType);

    internal static object L5X4b1buNZc8t0rMOIZj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object qlVV6Nbu3JhxoySFtaSa([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static object f6yrLkbupF8foabWeqOu([In] object obj0) => (object) ((ActionExecutionParams) obj0).ScriptName;

    internal static object whjuDWbua8FVZDYEePPl([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static bool MDio4BbuD9mEFhZEP8u0([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object tNLR0ybuthjXJfoQDEiq() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void Vceu2Ibuwo7cJrfVOX9T([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static Type v0S27Xbu4brCvxnWYBvp([In] object obj0) => ((MethodInfo) obj0).ReturnType;

    internal static object peA4Dfbu6CdnCEeiRjQR([In] object obj0) => (object) ((ActionExecutionParams) obj0).EntityTypeSerializationSettings;

    internal static void Wqj7tkbuHKGCoMTL40lK([In] object obj0, [In] object obj1) => ((ActionExecutionResult) obj0).Result = obj1;

    internal static void KRcgZgbuAQSNZYwrB3PD([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object GuCU6pbu7rt1n8T3oBaY(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return EntityScriptingService.InvokeWithDiagnostics((MethodInfo) obj0, obj1, (object[]) obj2, (string) obj3);
    }

    internal static Guid JJ3Tg3bux14o0nrxWxdZ([In] object obj0) => ((TypeSignature) obj0).TypeUid;

    internal static Guid xQqZMkbu0adnDFJXllqd([In] object obj0) => ((TypeSignature) obj0).SubTypeUid;

    internal static Type edG68Zbum9WHSE4t222H([In] object obj0) => ((ITypeDescriptor) obj0).SettingsType;

    internal static object UJZbXGbuypOp3I8CJANh(Type settingsType, [In] object obj1) => (object) AbstractActionExecutionHandler.CreateTypeSettings(settingsType, obj1);

    internal static Type KeSxBfbuMgg47bMvRhd4([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object F1gJxcbuJAyKeYrxExNN([In] Type obj0) => Activator.CreateInstance(obj0);

    internal static void yugSFpbu9PlWsZbEyH48([In] object obj0, Guid value) => ((PropertyMetadata) obj0).SubTypeUid = value;

    internal static void XR7PBxbud5RFHQaxb23y([In] object obj0, [In] object obj1) => ((PropertyMetadata) obj0).Settings = (TypeSettings) obj1;

    internal static bool m3E5qsbulIqRM5q4IN90([In] object obj0) => ((TypeSignature) obj0).Nullable;

    internal static void sa9T4KburHIX7nNUC3oP([In] object obj0, bool value) => ((PropertyMetadata) obj0).Nullable = value;

    internal static bool QBq9g0bugZxk4FeEOEbh([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static RelationType etr8Gibu5CXDhtq52T4R([In] object obj0) => ((TypeSignature) obj0).RelationType;

    internal static void q32KMJbujU5thwyITKdm([In] object obj0) => ((System.Action) obj0)();

    internal static void a1HOebbuYXHJtyx2n3Qw([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegiesAndWithDeleted((System.Action) obj1);

    internal static object Gjv62FbuLomtwyQ7SCgO([In] object obj0) => ((IActionExecutionParamModel) obj0).Parameter;

    internal static object knvmIkbuU9ofMSQH4fI0([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static object h1QwLLbusYqhLnJmkdJN(
      [In] object obj0,
      [In] object obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return ((AbstractActionExecutionHandler) obj0).Invoke((MethodInfo) obj1, obj2, (object[]) obj3);
    }

    internal static object p9XF3ybucM4Z9C7i4lNp([In] object obj0) => (object) ((ActionExecutionParams) obj0).Parameter;

    internal static object tkWAoEbuzG3d91iJEA64([In] object obj0) => (object) ((ActionExecutionParams) obj0).ParameterType;

    internal static object UFgFhjbIFo8DW0WqJjxd() => (object) MetadataServiceContext.Service;

    internal static bool BmNkoXbIB8IrMkOqXVWY([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void KO3VRWbIWYcpCgr71XZ0([In] object obj0, RelationType value) => ((DataClassSettings) obj0).RelationType = value;

    internal static void RlYSk5bIoM8cjMoUXtwc([In] object obj0, RelationType value) => ((EntitySettings) obj0).RelationType = value;
  }
}

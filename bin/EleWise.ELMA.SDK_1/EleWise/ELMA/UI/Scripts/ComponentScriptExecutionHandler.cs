// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.ComponentScriptExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using EleWise.ELMA.UI.Results;
using EleWise.ELMA.UI.Scripts.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Scripts
{
  /// <summary>
  /// Выполнение скриптов компонентов и пользовательских страниц
  /// </summary>
  [Component]
  internal sealed class ComponentScriptExecutionHandler : IScriptExecutionHandler
  {
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    private readonly IExecutionScopeFactory executionScopeFactory;
    private readonly IModuleReferenceManager moduleReferenceManager;
    private readonly IEqlPropertiesService eqlPropertiesService;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModuleAssemblyLoader moduleAssemblyLoader;
    private readonly ISecurityService securityService;
    private readonly ILockService lockService;
    internal static ComponentScriptExecutionHandler uodop251pxJkF6rYRBE;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонента</param>
    /// <param name="executionScopeFactory">Сервис по работе с контекстом выполнения Autofac</param>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    /// <param name="eqlPropertiesService">Сервис для работы с свойствами объекта, вычисляемыми через EQL</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="moduleAssemblyLoader">Загрузчик сборок модуля</param>
    /// <param name="securityService">Интерфейс проверки привилегий пользователя</param>
    /// <param name="lockService">Сервис блокировок</param>
    public ComponentScriptExecutionHandler(
      IComponentMetadataItemManager componentMetadataItemManager,
      IExecutionScopeFactory executionScopeFactory,
      IModuleReferenceManager moduleReferenceManager,
      IEqlPropertiesService eqlPropertiesService,
      IModuleMetadataLoader moduleMetadataLoader,
      IModuleAssemblyLoader moduleAssemblyLoader,
      ISecurityService securityService,
      ILockService lockService)
    {
      ComponentScriptExecutionHandler.rsCQUV5pxWJXuYndE8W();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 8;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.securityService = securityService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 0;
            continue;
          case 2:
            this.moduleAssemblyLoader = moduleAssemblyLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 1;
            continue;
          case 3:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 6 : 5;
            continue;
          case 4:
            this.lockService = lockService;
            num = 5;
            continue;
          case 5:
            goto label_3;
          case 6:
            this.eqlPropertiesService = eqlPropertiesService;
            num = 7;
            continue;
          case 7:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = 2;
            continue;
          case 8:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
            continue;
          default:
            this.executionScopeFactory = executionScopeFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 3;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public bool Check(ScriptExecutionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ComponentScriptExecutionHandler.r2bi835th7Der31KAei(ComponentScriptExecutionHandler.K1RHod5DMDdjYTWEIRg(ComponentScriptExecutionHandler.eKNIue5aI5bIqHxL9eR((object) parameters)), ComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            if (!ComponentScriptExecutionHandler.r2bi835th7Der31KAei(ComponentScriptExecutionHandler.K1RHod5DMDdjYTWEIRg(ComponentScriptExecutionHandler.eKNIue5aI5bIqHxL9eR((object) parameters)), PageComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 2 : 1;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
        }
      }
label_2:
      return ComponentScriptExecutionHandler.r2bi835th7Der31KAei(((ModelInfo) ComponentScriptExecutionHandler.eKNIue5aI5bIqHxL9eR((object) parameters)).TypeUid, PortletComponentMetadata.TypeUid);
label_3:
      return true;
    }

    /// <inheritdoc />
    public ScriptExecutionResult ExecuteScript(ScriptExecutionParams parameters)
    {
      int num1 = 52;
      // ISSUE: variable of a compiler-generated type
      ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_0 cDisplayClass100;
      string message1;
      Assembly assembly;
      List<IMetadata> metadataList;
      string message2;
      PropertyViewInfoContainer viewInfoContainer;
      string str1;
      string message3;
      Type type1;
      IExecutionScope executionScope;
      string str2;
      while (true)
      {
        int num2 = num1;
        string fullAssemblyName;
        ModuleVersion moduleVersion;
        ModuleInfoMetadata moduleInfoMetadata1;
        UIRuntimeModel orDefault;
        ServerBuildResult serverBuildResult;
        byte[] debugRaw;
        ItemRuntimeModel itemRuntimeModel;
        ComponentMetadataItem componentMetadataItem;
        byte[] numArray;
        string str3;
        byte[] assemblyRaw1;
        byte[] assemblyRaw2;
        IEnumerator<ItemRuntimeModel> enumerator;
        ModuleReference moduleReference;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 53:
              // ISSUE: reference to a compiler-generated field
              metadataList.Add((IMetadata) cDisplayClass100.componentMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 10 : 11;
              continue;
            case 2:
              goto label_7;
            case 3:
            case 42:
              goto label_22;
            case 4:
              ComponentScriptExecutionHandler.dA4fyY5JS23LYTDyQeF(ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT(), (object) message3);
              num2 = 20;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              if (!(cDisplayClass100.moduleUid == Guid.Empty))
              {
                num2 = 32;
                continue;
              }
              goto case 33;
            case 6:
              if (!ComponentScriptExecutionHandler.JAhWUB55vr6aMCx0FEj((object) assembly, (object) null))
              {
                num2 = 46;
                continue;
              }
              goto case 23;
            case 7:
              // ISSUE: reference to a compiler-generated field
              moduleVersion = (ModuleVersion) ComponentScriptExecutionHandler.N6YJLS5dj2nhIK042ow((object) this.moduleMetadataLoader, cDisplayClass100.moduleUid, ComponentScriptExecutionHandler.m6uYvW59GIOU3sU38Wt((object) itemRuntimeModel));
              num2 = 43;
              continue;
            case 8:
              if (!(assembly == (Assembly) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 18 : 53;
                continue;
              }
              goto case 60;
            case 9:
              // ISSUE: reference to a compiler-generated field
              moduleReference = (ModuleReference) ComponentScriptExecutionHandler.MSqdnn54sQxURcykj1L((object) this.moduleReferenceManager, ComponentScriptExecutionHandler.F1oDhX5waIoBEK8Z1p4(ComponentScriptExecutionHandler.eKNIue5aI5bIqHxL9eR((object) cDisplayClass100.parameters)));
              num2 = 41;
              continue;
            case 10:
              try
              {
label_43:
                if (ComponentScriptExecutionHandler.vK5Tqj5UiWE3tlQqI7X((object) enumerator))
                  goto label_39;
                else
                  goto label_44;
label_38:
                ItemRuntimeModel current;
                ModuleInfoMetadata moduleInfoMetadata2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      metadataList.AddRange(moduleInfoMetadata2.GetMetadataToRegister());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                      continue;
                    case 2:
                      goto label_16;
                    case 3:
                      goto label_39;
                    case 4:
                      moduleInfoMetadata2 = (ModuleInfoMetadata) ComponentScriptExecutionHandler.WuEetR5rm9hbpPLttki((object) this.moduleMetadataLoader.GetSpecificModuleVersion(ComponentScriptExecutionHandler.iHP6aT5LmpMwJs09UaY((object) current), ComponentScriptExecutionHandler.m6uYvW59GIOU3sU38Wt((object) current)));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_43;
                  }
                }
label_39:
                current = enumerator.Current;
                num3 = 4;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
                {
                  num3 = 2;
                  goto label_38;
                }
                else
                  goto label_38;
label_44:
                num3 = 2;
                goto label_38;
              }
              finally
              {
                if (enumerator != null)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
                    num4 = 1;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        ComponentScriptExecutionHandler.Yp8WST5s6FAgBmATf6e((object) enumerator);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_50;
                    }
                  }
                }
label_50:;
              }
            case 11:
              // ISSUE: reference to a compiler-generated field
              metadataList.AddRange(cDisplayClass100.componentMetadata.GetMetadataToRegister());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 38 : 12;
              continue;
            case 12:
              goto label_13;
            case 13:
              // ISSUE: type reference
              message1 = EleWise.ELMA.SR.T((string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(272623989 ^ 272576497), (object) ComponentScriptExecutionHandler.qRC8XB5cTAsllqL0gRv(__typeref (ComponentMetadata)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 0 : 0;
              continue;
            case 14:
              ComponentScriptExecutionHandler.dA4fyY5JS23LYTDyQeF(ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT(), (object) message2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 7 : 12;
              continue;
            case 15:
              assembly = (Assembly) ComponentScriptExecutionHandler.ogWam35ycGSVi6m9KiC((object) this.lockService, (object) fullAssemblyName, true, (object) assemblyRaw2, (object) numArray);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
              continue;
            case 16:
              metadataList = new List<IMetadata>();
              num2 = 9;
              continue;
            case 17:
              assembly = (Assembly) ComponentScriptExecutionHandler.hZwqWK5xVhNtupJdmVq((object) fullAssemblyName, true);
              num2 = 6;
              continue;
            case 18:
              // ISSUE: reference to a compiler-generated field
              message2 = EleWise.ELMA.SR.T((string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(813604817 ^ 813586893), (object) cDisplayClass100.moduleUid);
              num2 = 14;
              continue;
            case 19:
              goto label_11;
            case 20:
              goto label_29;
            case 21:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              cDisplayClass100.componentMetadata = moduleInfoMetadata1.Components.FirstOrDefault<ComponentMetadata>(new Func<ComponentMetadata, bool>(cDisplayClass100.\u003CExecuteScript\u003Eb__3));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 30 : 0;
              continue;
            case 22:
              // ISSUE: reference to a compiler-generated method
              itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault<ItemRuntimeModel>(new Func<ItemRuntimeModel, bool>(cDisplayClass100.\u003CExecuteScript\u003Eb__2));
              num2 = 59;
              continue;
            case 23:
              assemblyRaw1 = (byte[]) ComponentScriptExecutionHandler.xZnT3h5jatvIfHRgOWf((object) serverBuildResult);
              num2 = 19;
              continue;
            case 24:
              IEqlPropertiesService propertiesService = this.eqlPropertiesService;
              // ISSUE: reference to a compiler-generated field
              object contextInstance = cDisplayClass100.contextInstance;
              // ISSUE: reference to a compiler-generated field
              Type contextType = cDisplayClass100.contextType;
              // ISSUE: reference to a compiler-generated field
              List<PropertyMetadata> properties = ((ClassMetadata) ComponentScriptExecutionHandler.VgctibjbyLVxlcRHrGU(ComponentScriptExecutionHandler.wp49s0joIQkxFerGCTu((object) cDisplayClass100.componentMetadata))).Properties;
              // ISSUE: reference to a compiler-generated field
              object source = ComponentScriptExecutionHandler.Nl8JOZjhe3YKS5MVv1R((object) cDisplayClass100.parameters);
              // ISSUE: reference to a compiler-generated field
              Func<SerializedModel, SerializedModel> func = ComponentScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__10_1;
              Func<SerializedModel, SerializedModel> selector;
              if (func == null)
              {
                // ISSUE: reference to a compiler-generated field
                ComponentScriptExecutionHandler.\u003C\u003Ec.\u003C\u003E9__10_1 = selector = (Func<SerializedModel, SerializedModel>) (s =>
                {
                  SerializedModel serializedModel = new SerializedModel();
                  // ISSUE: reference to a compiler-generated method
                  serializedModel.Model = (string) ComponentScriptExecutionHandler.\u003C\u003Ec.K44CW9fYIHfC6VpUtZC6((object) s);
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  ComponentScriptExecutionHandler.\u003C\u003Ec.xhaX92fYSyapm9CnBhp8((object) serializedModel, ComponentScriptExecutionHandler.\u003C\u003Ec.peBOoPfYVtjGrHKcsf6H((object) s));
                  return serializedModel;
                });
              }
              else
                goto label_163;
label_162:
              List<SerializedModel> list = ((IEnumerable<SerializedModel>) source).Select<SerializedModel, SerializedModel>(selector).ToList<SerializedModel>();
              propertiesService.SetEqlComputedProperties(contextInstance, contextType, (IEnumerable<PropertyMetadata>) properties, list);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 9 : 27;
              continue;
label_163:
              selector = func;
              goto label_162;
            case 25:
              numArray = (byte[]) ComponentScriptExecutionHandler.EuU0C35moCMCNgfZGlE(ComponentScriptExecutionHandler.GkF2eP50Mp8DOwq8P79((object) componentMetadataItem));
              num2 = 15;
              continue;
            case 26:
            case 46:
              metadataList.AddRange(moduleInfoMetadata1.GetMetadataToRegister());
              num2 = 31;
              continue;
            case 27:
              str1 = string.Empty;
              num2 = 44;
              continue;
            case 28:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.contextInstance = (object) null;
              num2 = 35;
              continue;
            case 29:
              if (!ComponentScriptExecutionHandler.kpZVYOjfRcVM2phL9YL(type1, (Type) null))
              {
                executionScope = (IExecutionScope) ComponentScriptExecutionHandler.KlddaIjQkbMZ5y9N2S3((object) this.executionScopeFactory.CreateScope().AddRegistration(type1, Array.Empty<Type>()));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 56 : 1;
                continue;
              }
              num2 = 57;
              continue;
            case 30:
              fullAssemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName(serverBuildResult.AssemblyName, ((ModuleVersionHeader) ComponentScriptExecutionHandler.LIvrF55g9WGbLwiNgYJ((object) moduleVersion)).Version.ToString(), (string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(-87337865 ^ -87322223), z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411200693));
              num2 = 17;
              continue;
            case 31:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              enumerator = orDefault.RuntimeModules.Where<ItemRuntimeModel>(cDisplayClass100.\u003C\u003E9__4 ?? (cDisplayClass100.\u003C\u003E9__4 = new Func<ItemRuntimeModel, bool>(cDisplayClass100.\u003CExecuteScript\u003Eb__4))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 3 : 10;
              continue;
            case 32:
            case 36:
              orDefault = ContextVars.GetOrDefault<UIRuntimeModel>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146527525));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 22 : 12;
              continue;
            case 33:
              // ISSUE: reference to a compiler-generated field
              componentMetadataItem = this.componentMetadataItemManager.Load(ComponentScriptExecutionHandler.F1oDhX5waIoBEK8Z1p4((object) cDisplayClass100.parameters.ModelInfo));
              num2 = 45;
              continue;
            case 34:
              assembly = ComponentManager.LoadAssemblyWithLock(this.lockService, fullAssemblyName, true, assemblyRaw1, debugRaw);
              num2 = 26;
              continue;
            case 35:
              // ISSUE: reference to a compiler-generated method
              ComponentScriptExecutionHandler.Hm8uyijWxSC1bFTsfCd((object) this.securityService, (object) new System.Action(cDisplayClass100.\u003CExecuteScript\u003Eb__0));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 2 : 24;
              continue;
            case 37:
              fullAssemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string) ComponentScriptExecutionHandler.Yhjlmi5HHTvNN3uRxtS((object) componentMetadataItem), (string) ComponentScriptExecutionHandler.kWeThG5AW07L37M2gvk((object) componentMetadataItem), (string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(-1886646897 ^ -1886599063), (string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(-812025778 ^ -812029784));
              num2 = 50;
              continue;
            case 38:
            case 39:
label_16:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass100.componentMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 49 : 24;
                continue;
              }
              goto case 13;
            case 40:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.contextExpando = new EntityJsonSerializer().DeserializeJson((string) ComponentScriptExecutionHandler.G0Im9FjBt4PphH0HwFu((object) cDisplayClass100.parameters));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 15 : 28;
              continue;
            case 41:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.moduleUid = moduleReference != null ? moduleReference.ModuleUid : Guid.Empty;
              num2 = 5;
              continue;
            case 43:
              // ISSUE: reference to a compiler-generated field
              serverBuildResult = (ServerBuildResult) ComponentScriptExecutionHandler.FlKlx85lReDuRc1yfJI((object) this.moduleAssemblyLoader, cDisplayClass100.moduleUid, ComponentScriptExecutionHandler.m6uYvW59GIOU3sU38Wt((object) itemRuntimeModel));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 2;
              continue;
            case 44:
              viewInfoContainer = (PropertyViewInfoContainer) null;
              num2 = 55;
              continue;
            case 45:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.componentMetadata = (ComponentMetadata) ComponentScriptExecutionHandler.ERKo9M56MBytU0kERWm((object) componentMetadataItem);
              num2 = 37;
              continue;
            case 47:
              type1 = ComponentScriptExecutionHandler.E8lcTvjF2i786R7bPHb((object) assembly, (object) str2);
              num2 = 29;
              continue;
            case 48:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.contextType = ComponentScriptExecutionHandler.E8lcTvjF2i786R7bPHb((object) assembly, (object) str3);
              num2 = 40;
              continue;
            case 49:
              // ISSUE: reference to a compiler-generated field
              str3 = (string) ComponentScriptExecutionHandler.edD2B35zbwbnINRk4CG((object) cDisplayClass100.componentMetadata);
              num2 = 48;
              continue;
            case 50:
              assembly = (Assembly) ComponentScriptExecutionHandler.hZwqWK5xVhNtupJdmVq((object) fullAssemblyName, true);
              num2 = 8;
              continue;
            case 51:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass100.parameters = parameters;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 16 : 16;
              continue;
            case 52:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass100 = new ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_0();
              num2 = 51;
              continue;
            case 54:
              goto label_32;
            case 55:
              // ISSUE: reference to a compiler-generated field
              if (!ComponentScriptExecutionHandler.aHdW1ejELLpWqGQrGCp(ComponentScriptExecutionHandler.RJasUrjGFFjZpf3UroI((object) cDisplayClass100.parameters), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647927920)))
              {
                num2 = 42;
                continue;
              }
              goto case 58;
            case 56:
              goto label_61;
            case 57:
              goto label_60;
            case 58:
              // ISSUE: reference to a compiler-generated field
              str2 = ComponentMetadataHelperInternal.ControllerTypeName(cDisplayClass100.componentMetadata);
              num2 = 47;
              continue;
            case 59:
              if (itemRuntimeModel != null)
              {
                num2 = 7;
                continue;
              }
              goto case 18;
            case 60:
              assemblyRaw2 = ((ScriptModule) ComponentScriptExecutionHandler.GkF2eP50Mp8DOwq8P79((object) componentMetadataItem)).AssemblyRaw;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 25;
              continue;
            default:
              ComponentScriptExecutionHandler.dA4fyY5JS23LYTDyQeF(ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT(), (object) message1);
              num2 = 54;
              continue;
          }
        }
label_7:
        moduleInfoMetadata1 = (ModuleInfoMetadata) ComponentScriptExecutionHandler.WuEetR5rm9hbpPLttki((object) moduleVersion);
        num1 = 21;
        continue;
label_11:
        debugRaw = (byte[]) ComponentScriptExecutionHandler.UjfaLM5YYto9YTHIF69((object) serverBuildResult);
        num1 = 34;
        continue;
label_60:
        message3 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(2008901894 << 3 ^ -1108635712), (object) str2);
        num1 = 4;
      }
label_13:
      throw new Exception(message2);
label_22:
      ScriptExecutionResult scriptExecutionResult = new ScriptExecutionResult();
      // ISSUE: reference to a compiler-generated field
      ComponentScriptExecutionHandler.ofp4Stj2LdJce6hUalh((object) scriptExecutionResult, cDisplayClass100.contextInstance);
      scriptExecutionResult.PropertyContainer = viewInfoContainer;
      ComponentScriptExecutionHandler.ONKRsojeTFNOZ8LKxnk((object) scriptExecutionResult, (object) str1);
      return scriptExecutionResult;
label_29:
      throw new Exception(message3);
label_32:
      throw new Exception(message1);
label_61:
      try
      {
        // ISSUE: object of a compiler-generated type is created
        // ISSUE: variable of a compiler-generated type
        ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_1 cDisplayClass101 = new ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_1();
        int num5 = 16;
        string message4;
        Type viewModelType;
        MetadataServiceContext metadataServiceContext;
        string message5;
        ScriptMethodInfo scriptMethodInfo;
        while (true)
        {
          int num6;
          // ISSUE: variable of a compiler-generated type
          ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_2 cDisplayClass102;
          // ISSUE: variable of a compiler-generated type
          ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_3 cDisplayClass103;
          ComponentMetadata componentMetadata1;
          // ISSUE: variable of a compiler-generated type
          ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_4 cDisplayClass104;
          Type type2;
          SerializedModel serializedModel;
          string str4;
          switch (num5)
          {
            case 1:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass104.CS\u0024\u003C\u003E8__locals3 = cDisplayClass103;
              num6 = 39;
              break;
            case 2:
              viewInfoContainer = new PropertyViewInfoContainer((ClassMetadata) ComponentScriptExecutionHandler.VgctibjbyLVxlcRHrGU(ComponentScriptExecutionHandler.wp49s0joIQkxFerGCTu((object) componentMetadata3)));
              num5 = 12;
              continue;
            case 3:
              // ISSUE: reference to a compiler-generated field
              if (ComponentScriptExecutionHandler.AWSv2jj8cudwTOsEFCm((object) cDisplayClass101.method, (object) null))
              {
                num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 2 : 8;
                continue;
              }
              // ISSUE: reference to a compiler-generated field
              viewModelType = ComponentScriptExecutionHandler.QteoG2jufIIP541RfyK(ComponentScriptExecutionHandler.HWA9UnjZguqvcbgFdMI((object) cDisplayClass101.method)[0]);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 11 : 5;
              continue;
            case 4:
              ((ILogger) ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT()).Error((object) message5);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 29 : 28;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass103.CS\u0024\u003C\u003E8__locals2 = cDisplayClass102;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 10 : 2;
              continue;
            case 6:
              if (componentMetadata1 is PortletComponentMetadata componentMetadata2)
              {
                num5 = 26;
                continue;
              }
              goto case 20;
            case 7:
              // ISSUE: reference to a compiler-generated method
              this.securityService.RunWithElevatedPrivilegiesAndWithDeleted(new System.Action(cDisplayClass104.\u003CExecuteScript\u003Eb__6));
              num5 = 25;
              continue;
            case 8:
              message5 = EleWise.ELMA.SR.T((string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(1052221104 - 768835541 ^ 283432623), (object) scriptMethodInfo.Name);
              num5 = 4;
              continue;
            case 9:
              // ISSUE: reference to a compiler-generated field
              if (cDisplayClass101.controllerInstance != null)
              {
                num5 = 37;
                continue;
              }
              goto case 13;
            case 10:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              serializedModel = ((IEnumerable<SerializedModel>) ComponentScriptExecutionHandler.Nl8JOZjhe3YKS5MVv1R((object) cDisplayClass100.parameters)).FirstOrDefault<SerializedModel>((Func<SerializedModel, bool>) (model => (string) ComponentScriptExecutionHandler.\u003C\u003Ec.peBOoPfYVtjGrHKcsf6H((object) model) == (string) ComponentScriptExecutionHandler.\u003C\u003Ec.J65IErfYiGkCx1Akbh7U(-630932142 - 1120244082 ^ -1751498056)));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 2 : 15;
              continue;
            case 11:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass102 = new ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_2();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 11 : 28;
              continue;
            case 12:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass101.viewModel = ComponentScriptExecutionHandler.iTbDIGjRsaWQqdHGmbl((object) componentMetadata3, viewModelType, cDisplayClass100.contextInstance, (object) viewInfoContainer);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
              continue;
            case 13:
              message4 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757117712), (object) str2);
              num5 = 38;
              continue;
            case 14:
            case 34:
              num6 = 2;
              break;
            case 15:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              str4 = (string) ComponentScriptExecutionHandler.ewFQnujVWwgeEwlGKy4((object) cDisplayClass103.CS\u0024\u003C\u003E8__locals2.\u003CportletMetadata\u003E5__2.FullTypeName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281861274), ComponentScriptExecutionHandler.qwecQ5jI8GQiQA8wSof((object) cDisplayClass103.CS\u0024\u003C\u003E8__locals2.\u003CportletMetadata\u003E5__2.PersonalizationContext));
              num5 = 33;
              continue;
            case 16:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass101.controllerInstance = executionScope.Resolve(type1);
              num5 = 9;
              continue;
            case 17:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass101.viewModel = ComponentScriptExecutionHandler.EeBmw7jiTy95UvwSaSY((object) cDisplayClass103.CS\u0024\u003C\u003E8__locals2.\u003CportletMetadata\u003E5__2, viewModelType, cDisplayClass100.contextInstance, cDisplayClass103.personalizationInstance, (object) viewInfoContainer);
              num5 = 30;
              continue;
            case 18:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass103.personalizationInstance = Activator.CreateInstance(type2);
              num5 = 19;
              continue;
            case 19:
              if (serializedModel != null)
              {
                num6 = 36;
                break;
              }
              goto case 25;
            case 20:
              if (componentMetadata1 is PageComponentMetadata componentMetadata3)
              {
                num5 = 34;
                continue;
              }
              goto case 32;
            case 21:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass103 = new ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_3();
              num6 = 5;
              break;
            case 22:
            case 26:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass102.\u003CportletMetadata\u003E5__2 = componentMetadata2;
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 19 : 21;
              continue;
            case 23:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass101.method = (MethodInfo) ComponentScriptExecutionHandler.CFNkWPjvISWLSPCBnZn(type1, (object) scriptMethodInfo.Name);
              num5 = 3;
              continue;
            case 24:
              if (componentMetadata1 != null)
              {
                num5 = 6;
                continue;
              }
              goto case 32;
            case 25:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              viewInfoContainer = new PropertyViewInfoContainer((ClassMetadata) ComponentScriptExecutionHandler.VgctibjbyLVxlcRHrGU(ComponentScriptExecutionHandler.wp49s0joIQkxFerGCTu((object) cDisplayClass103.CS\u0024\u003C\u003E8__locals2.\u003CportletMetadata\u003E5__2)));
              num5 = 17;
              continue;
            case 28:
              // ISSUE: reference to a compiler-generated field
              componentMetadata1 = cDisplayClass100.componentMetadata;
              num5 = 24;
              continue;
            case 29:
              goto label_95;
            case 31:
              goto label_103;
            case 32:
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated field
              cDisplayClass101.viewModel = ComponentScriptExecutionHandler.zdeJMHjqcQvXCXtZ3TC(viewModelType, cDisplayClass100.contextInstance);
              num5 = 27;
              continue;
            case 33:
              type2 = ComponentScriptExecutionHandler.E8lcTvjF2i786R7bPHb((object) assembly, (object) str4);
              num5 = 18;
              continue;
            case 35:
              goto label_106;
            case 36:
              // ISSUE: object of a compiler-generated type is created
              cDisplayClass104 = new ComponentScriptExecutionHandler.\u003C\u003Ec__DisplayClass10_4();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
              continue;
            case 37:
              // ISSUE: reference to a compiler-generated field
              scriptMethodInfo = (ScriptMethodInfo) ComponentScriptExecutionHandler.XHX4EXjCmuOkr2DvgQK((object) cDisplayClass100.parameters.ScriptName);
              num6 = 23;
              break;
            case 38:
              ComponentScriptExecutionHandler.dA4fyY5JS23LYTDyQeF(ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT(), (object) message4);
              num5 = 31;
              continue;
            case 39:
              // ISSUE: reference to a compiler-generated field
              cDisplayClass104.personalizationModelExpando = new EntityJsonSerializer().DeserializeJson((string) ComponentScriptExecutionHandler.c1GBUYjSCAiN8AP0Dth((object) serializedModel));
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 2 : 7;
              continue;
            default:
              metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataList);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 35 : 1;
              continue;
          }
          num5 = num6;
        }
label_95:
        throw new Exception(message5);
label_103:
        throw new Exception(message4);
label_106:
        try
        {
          // ISSUE: reference to a compiler-generated method
          ComponentScriptExecutionHandler.QU1btjjKypxqjfCZylc((object) new System.Action(cDisplayClass101.\u003CExecuteScript\u003Eb__7), (object) "");
          int num7 = 18;
          while (true)
          {
            object obj1;
            FieldInfo field;
            object obj2;
            switch (num7)
            {
              case 1:
                if (!(obj2 is RedirectToUrlResult redirectToUrlResult))
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 13 : 4;
                  continue;
                }
                break;
              case 2:
              case 8:
              case 13:
              case 15:
              case 17:
                goto label_22;
              case 3:
                obj2 = obj1;
                num7 = 11;
                continue;
              case 4:
                str1 = (string) ComponentScriptExecutionHandler.A8J8e8jkmaSiy2vLrwM(ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(~-306453669 ^ 306500680), ComponentScriptExecutionHandler.rbnojcjTVfm58Kty8R2((object) redirectToPageResult));
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 2;
                continue;
              case 5:
                if (obj1 == null)
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 16 : 17;
                  continue;
                }
                goto case 3;
              case 6:
                if (obj2 is RedirectToPageResult redirectToPageResult)
                {
                  num7 = 16;
                  continue;
                }
                goto case 1;
              case 7:
                field = viewModelType.GetField((string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(322893104 - -1992822529 ^ -1979200283), BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 12 : 1;
                continue;
              case 10:
                // ISSUE: reference to a compiler-generated field
                obj1 = ComponentScriptExecutionHandler.pXn9BajX5soEEjsVH3q((object) field, cDisplayClass101.viewModel);
                num7 = 5;
                continue;
              case 11:
                if (obj2 != null)
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 6;
                  continue;
                }
                goto label_22;
              case 12:
                if (!(field != (FieldInfo) null))
                {
                  num7 = 8;
                  continue;
                }
                goto case 10;
              case 14:
              case 16:
                num7 = 4;
                continue;
              case 18:
                // ISSUE: reference to a compiler-generated field
                if (cDisplayClass100.componentMetadata is PageComponentMetadata)
                {
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 3 : 7;
                  continue;
                }
                goto label_22;
            }
            str1 = redirectToUrlResult.Url;
            num7 = 15;
          }
        }
        catch (Exception ex)
        {
          int num8 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
            num8 = 0;
          while (true)
          {
            switch (num8)
            {
              case 1:
                goto label_130;
              default:
                ComponentScriptExecutionHandler.ILs57OjOisYNL1bTQcK(ComponentScriptExecutionHandler.tBYBHl5M4FlbtqblhOT(), (object) EleWise.ELMA.SR.T((string) ComponentScriptExecutionHandler.XBlKfn57G1U4arKqa3a(864270449 << 6 ^ -521218748), ComponentScriptExecutionHandler.WGl8lwjn4eJomexVijx((object) scriptMethodInfo), (object) type1), (object) ex);
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
                continue;
            }
          }
label_130:
          throw;
        }
        finally
        {
          int num9;
          if (metadataServiceContext == null)
            num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
          else
            goto label_134;
label_133:
          switch (num9)
          {
            case 2:
              break;
            default:
          }
label_134:
          metadataServiceContext.Dispose();
          num9 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
          {
            num9 = 0;
            goto label_133;
          }
          else
            goto label_133;
        }
      }
      finally
      {
        if (executionScope != null)
        {
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
            num10 = 0;
          while (true)
          {
            switch (num10)
            {
              case 1:
                goto label_142;
              default:
                ComponentScriptExecutionHandler.Yp8WST5s6FAgBmATf6e((object) executionScope);
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 1 : 1;
                continue;
            }
          }
        }
label_142:;
      }
    }

    private static object ProcessPortletComponentMetadata(
      object portletMetadata,
      Type viewModelType,
      object contextInstance,
      object personalizationInstance,
      object propertyContainer)
    {
      int num = 2;
      ConstructorInfo constructorInfo;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ComponentScriptExecutionHandler.KrgnDYj1rR1Qs3E1pWB((object) constructorInfo, (object) null))
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 2:
            constructorInfo = (ConstructorInfo) ComponentScriptExecutionHandler.MBxxtRjP745NuQF5a8j(viewModelType, 5);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
            continue;
          case 3:
            goto label_6;
          case 4:
            constructorInfo = (ConstructorInfo) ComponentScriptExecutionHandler.MBxxtRjP745NuQF5a8j(viewModelType, 2);
            num = 3;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      return ComponentScriptExecutionHandler.dY70EUjN31HNbs03mEI((object) constructorInfo, (object) new object[5]
      {
        contextInstance,
        personalizationInstance,
        null,
        ComponentScriptExecutionHandler.VgctibjbyLVxlcRHrGU(ComponentScriptExecutionHandler.wp49s0joIQkxFerGCTu(portletMetadata)),
        propertyContainer
      });
label_6:
      return constructorInfo.Invoke(new object[2]
      {
        contextInstance,
        personalizationInstance
      });
    }

    private static object ProcessPageComponentMetadata(
      object pageMetadata,
      Type viewModelType,
      object contextInstance,
      object propertyContainer)
    {
      int num = 2;
      ConstructorInfo ctor;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (ComponentScriptExecutionHandler.KrgnDYj1rR1Qs3E1pWB((object) ctor, (object) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            ctor = ComponentScriptExecutionHandler.GetCtor(viewModelType, 4);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_5:
      return ComponentScriptExecutionHandler.dY70EUjN31HNbs03mEI((object) ctor, (object) new object[4]
      {
        contextInstance,
        null,
        ComponentScriptExecutionHandler.VgctibjbyLVxlcRHrGU(ComponentScriptExecutionHandler.wp49s0joIQkxFerGCTu(pageMetadata)),
        propertyContainer
      });
label_6:
      return ComponentScriptExecutionHandler.zdeJMHjqcQvXCXtZ3TC(viewModelType, contextInstance);
    }

    private static object ProcessComponentMetadata(Type viewModelType, object contextInstance) => ComponentScriptExecutionHandler.dY70EUjN31HNbs03mEI((object) ComponentScriptExecutionHandler.GetCtor(viewModelType, 1), (object) new object[1]
    {
      contextInstance
    });

    private static ConstructorInfo GetCtor(Type viewModelType, int paramCount)
    {
      int num = 1;
      int paramCount1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            paramCount1 = paramCount;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 2;
            continue;
        }
      }
label_4:
      return Array.Find<ConstructorInfo>(viewModelType.GetConstructors(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic), (Predicate<ConstructorInfo>) (ctorInfo => ctorInfo.GetParameters().Length == paramCount1));
    }

    internal static void rsCQUV5pxWJXuYndE8W() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool unMLpy5NEVPow1QjFrp() => ComponentScriptExecutionHandler.uodop251pxJkF6rYRBE == null;

    internal static ComponentScriptExecutionHandler XShNo953BH0MEtNelPK() => ComponentScriptExecutionHandler.uodop251pxJkF6rYRBE;

    internal static object eKNIue5aI5bIqHxL9eR([In] object obj0) => (object) ((ScriptExecutionParams) obj0).ModelInfo;

    internal static Guid K1RHod5DMDdjYTWEIRg([In] object obj0) => ((ModelInfo) obj0).TypeUid;

    internal static bool r2bi835th7Der31KAei([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid F1oDhX5waIoBEK8Z1p4([In] object obj0) => ((ModelInfo) obj0).SubTypeUid;

    internal static object MSqdnn54sQxURcykj1L([In] object obj0, Guid metadataUid) => (object) ((IModuleReferenceManager) obj0).LoadOrNull(metadataUid);

    internal static object ERKo9M56MBytU0kERWm([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static object Yhjlmi5HHTvNN3uRxtS([In] object obj0) => (object) ((ComponentMetadataItem) obj0).AssemblyName;

    internal static object kWeThG5AW07L37M2gvk([In] object obj0) => (object) ((ComponentMetadataItem) obj0).AssemblyVersion;

    internal static object XBlKfn57G1U4arKqa3a(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hZwqWK5xVhNtupJdmVq([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object GkF2eP50Mp8DOwq8P79([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ScriptModule;

    internal static object EuU0C35moCMCNgfZGlE([In] object obj0) => (object) ((ScriptModule) obj0).DebugRaw;

    internal static object ogWam35ycGSVi6m9KiC(
      [In] object obj0,
      [In] object obj1,
      bool isFullName,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ComponentManager.LoadAssemblyWithLock((ILockService) obj0, (string) obj1, isFullName, (byte[]) obj3, (byte[]) obj4);
    }

    internal static object tBYBHl5M4FlbtqblhOT() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void dA4fyY5JS23LYTDyQeF([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static Guid m6uYvW59GIOU3sU38Wt([In] object obj0) => ((ItemRuntimeModel) obj0).ItemUid;

    internal static object N6YJLS5dj2nhIK042ow([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleMetadataLoader) obj0).GetSpecificModuleVersion(moduleUid, versionUid);

    internal static object FlKlx85lReDuRc1yfJI([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleAssemblyLoader) obj0).GetServerAssembly(moduleUid, versionUid);

    internal static object WuEetR5rm9hbpPLttki([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object LIvrF55g9WGbLwiNgYJ([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static bool JAhWUB55vr6aMCx0FEj([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object xZnT3h5jatvIfHRgOWf([In] object obj0) => (object) ((ServerBuildResult) obj0).AssemblyRaw;

    internal static object UjfaLM5YYto9YTHIF69([In] object obj0) => (object) ((ServerBuildResult) obj0).DebugRaw;

    internal static Guid iHP6aT5LmpMwJs09UaY([In] object obj0) => ((ItemRuntimeModel) obj0).HeaderUid;

    internal static bool vK5Tqj5UiWE3tlQqI7X([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Yp8WST5s6FAgBmATf6e([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type qRC8XB5cTAsllqL0gRv([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object edD2B35zbwbnINRk4CG([In] object obj0) => (object) ComponentMetadataHelperInternal.ContextTypeName((ComponentMetadata) obj0);

    internal static Type E8lcTvjF2i786R7bPHb([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static object G0Im9FjBt4PphH0HwFu([In] object obj0) => (object) ((ScriptExecutionParams) obj0).Model;

    internal static void Hm8uyijWxSC1bFTsfCd([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegiesAndWithDeleted((System.Action) obj1);

    internal static object wp49s0joIQkxFerGCTu([In] object obj0) => (object) ((ComponentMetadata) obj0).Content;

    internal static object VgctibjbyLVxlcRHrGU([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static object Nl8JOZjhe3YKS5MVv1R([In] object obj0) => (object) ((ScriptExecutionParams) obj0).AdditionalModels;

    internal static object RJasUrjGFFjZpf3UroI([In] object obj0) => (object) ((ScriptExecutionParams) obj0).ScriptName;

    internal static bool aHdW1ejELLpWqGQrGCp([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static bool kpZVYOjfRcVM2phL9YL([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object KlddaIjQkbMZ5y9N2S3([In] object obj0) => (object) ((IExecutionScopeBuilder) obj0).StartScope();

    internal static object XHX4EXjCmuOkr2DvgQK([In] object obj0) => (object) ScriptMethodInfoHelper.Deserialize((string) obj0);

    internal static object CFNkWPjvISWLSPCBnZn(Type type, [In] object obj1) => (object) ScriptHelper.GetMethodInfo(type, (string) obj1);

    internal static bool AWSv2jj8cudwTOsEFCm([In] object obj0, [In] object obj1) => (MethodInfo) obj0 == (MethodInfo) obj1;

    internal static object HWA9UnjZguqvcbgFdMI([In] object obj0) => (object) ((MethodBase) obj0).GetParameters();

    internal static Type QteoG2jufIIP541RfyK([In] object obj0) => ((ParameterInfo) obj0).ParameterType;

    internal static object qwecQ5jI8GQiQA8wSof([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object ewFQnujVWwgeEwlGKy4([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object c1GBUYjSCAiN8AP0Dth([In] object obj0) => (object) ((SerializedModel) obj0).Model;

    internal static object EeBmw7jiTy95UvwSaSY(
      [In] object obj0,
      Type viewModelType,
      [In] object obj2,
      [In] object obj3,
      [In] object obj4)
    {
      return ComponentScriptExecutionHandler.ProcessPortletComponentMetadata(obj0, viewModelType, obj2, obj3, obj4);
    }

    internal static object iTbDIGjRsaWQqdHGmbl(
      [In] object obj0,
      Type viewModelType,
      [In] object obj2,
      [In] object obj3)
    {
      return ComponentScriptExecutionHandler.ProcessPageComponentMetadata(obj0, viewModelType, obj2, obj3);
    }

    internal static object zdeJMHjqcQvXCXtZ3TC(Type viewModelType, [In] object obj1) => ComponentScriptExecutionHandler.ProcessComponentMetadata(viewModelType, obj1);

    internal static void QU1btjjKypxqjfCZylc([In] object obj0, [In] object obj1) => ScriptExecutionService.ScriptExecution((System.Action) obj0, (string) obj1);

    internal static object pXn9BajX5soEEjsVH3q([In] object obj0, [In] object obj1) => ((FieldInfo) obj0).GetValue(obj1);

    internal static object rbnojcjTVfm58Kty8R2([In] object obj0) => (object) ((RedirectToPageResult) obj0).PageId;

    internal static object A8J8e8jkmaSiy2vLrwM([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static object WGl8lwjn4eJomexVijx([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static void ILs57OjOisYNL1bTQcK([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void ofp4Stj2LdJce6hUalh([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).Model = obj1;

    internal static void ONKRsojeTFNOZ8LKxnk([In] object obj0, [In] object obj1) => ((ScriptExecutionResult) obj0).RedirectUrl = (string) obj1;

    internal static object MBxxtRjP745NuQF5a8j(Type viewModelType, int paramCount) => (object) ComponentScriptExecutionHandler.GetCtor(viewModelType, paramCount);

    internal static bool KrgnDYj1rR1Qs3E1pWB([In] object obj0, [In] object obj1) => (ConstructorInfo) obj0 != (ConstructorInfo) obj1;

    internal static object dY70EUjN31HNbs03mEI([In] object obj0, [In] object obj1) => ((ConstructorInfo) obj0).Invoke((object[]) obj1);
  }
}

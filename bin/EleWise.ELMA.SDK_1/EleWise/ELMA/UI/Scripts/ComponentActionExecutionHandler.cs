// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Scripts.ComponentActionExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
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
  /// <summary>Выполнение действия для компонентов</summary>
  internal sealed class ComponentActionExecutionHandler : AbstractActionExecutionHandler
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    private readonly IComponentMetadataItemManager componentMetadataItemManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModuleAssemblyLoader moduleAssemblyLoader;
    private readonly ILockService lockService;
    private static ComponentActionExecutionHandler uk2XLGggmufxWTOlYIC;

    /// <summary>Ctor</summary>
    /// <param name="executionScopeFactory">Фабрика для создания контекста выполнения</param>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    /// <param name="componentMetadataItemManager">Менеджер метаданных компонента</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="moduleAssemblyLoader">Загрузчик сборок модуля</param>
    /// <param name="lockService">Сервис блокировок</param>
    public ComponentActionExecutionHandler(
      IExecutionScopeFactory executionScopeFactory,
      IModuleReferenceManager moduleReferenceManager,
      IComponentMetadataItemManager componentMetadataItemManager,
      IModuleMetadataLoader moduleMetadataLoader,
      IModuleAssemblyLoader moduleAssemblyLoader,
      ILockService lockService)
    {
      ComponentActionExecutionHandler.K13kmQgYcaFI1hkH9Qf();
      // ISSUE: explicit constructor call
      base.\u002Ector(executionScopeFactory);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.moduleReferenceManager = moduleReferenceManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 4 : 4;
            continue;
          case 2:
            this.lockService = lockService;
            num = 5;
            continue;
          case 3:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 0;
            continue;
          case 4:
            this.componentMetadataItemManager = componentMetadataItemManager;
            num = 3;
            continue;
          case 5:
            goto label_3;
          default:
            this.moduleAssemblyLoader = moduleAssemblyLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 2 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(ActionExecutionParams parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!ComponentActionExecutionHandler.oM9qwUgLoVGe1ST6WEv(parameters.TypeUid, ComponentMetadata.TypeUid))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            goto label_2;
          case 3:
            goto label_3;
          default:
            if (ComponentActionExecutionHandler.oM9qwUgLoVGe1ST6WEv(ComponentActionExecutionHandler.XQkE9UgUFmFECwRRZTR((object) parameters), PageComponentMetadata.TypeUid))
            {
              num = 3;
              continue;
            }
            goto label_2;
        }
      }
label_2:
      return ComponentActionExecutionHandler.XQkE9UgUFmFECwRRZTR((object) parameters) == PortletComponentMetadata.TypeUid;
label_3:
      return true;
    }

    /// <inheritdoc />
    public override ActionExecutionResult Execute(ActionExecutionParams parameters)
    {
      int num1 = 31;
      List<IMetadata> metadataList;
      string message1;
      string str1;
      Type executorType;
      string message2;
      string message3;
      while (true)
      {
        int num2 = num1;
        ItemRuntimeModel itemRuntimeModel;
        ScriptMethodInfo scriptMethodInfo;
        Guid itemUid;
        while (true)
        {
          Assembly assembly;
          ComponentMetadataItem componentMetadataItem;
          string fullAssemblyName;
          ModuleInfoMetadata moduleInfoMetadata;
          ComponentMetadata componentMetadata;
          UIRuntimeModel orDefault;
          ModuleReference moduleReference;
          ModuleVersion moduleVersion;
          string str2;
          IEnumerator<ItemRuntimeModel> enumerator;
          ServerBuildResult serverBuildResult;
          Guid moduleUid;
          Guid instanceUid;
          switch (num2)
          {
            case 1:
              assembly = (Assembly) ComponentActionExecutionHandler.H76YNI5WTtybiE2oJ1H((object) fullAssemblyName, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 19 : 19;
              continue;
            case 2:
              goto label_68;
            case 3:
              goto label_67;
            case 4:
              if (!ComponentActionExecutionHandler.oM9qwUgLoVGe1ST6WEv(moduleUid, Guid.Empty))
                goto case 26;
              else
                goto label_73;
            case 5:
            case 47:
              metadataList.AddRange(moduleInfoMetadata.GetMetadataToRegister());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 26 : 33;
              continue;
            case 6:
              // ISSUE: reference to a compiler-generated method
              itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => ComponentActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.vyqgaIfj4ak4btWj3FQh(a.HeaderUid, moduleUid)));
              num2 = 42;
              continue;
            case 7:
              if (!ComponentActionExecutionHandler.u5FvIB52PVskxVyD9VW(executorType, (Type) null))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 13 : 12;
                continue;
              }
              goto case 12;
            case 8:
              metadataList.AddRange(componentMetadata.GetMetadataToRegister());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 34 : 17;
              continue;
            case 9:
              fullAssemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string) ComponentActionExecutionHandler.D9G1IW58lM98Ja5Muuu((object) serverBuildResult), ComponentActionExecutionHandler.hH7BKC5ubNoOx5EZJB8(ComponentActionExecutionHandler.QL0SMc5ZHiLx1MUCBrT((object) moduleVersion)).ToString(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333786612), z2jc63fLkugS1X8Q9N.tE1kD1vbB(712480695 ^ 712476497));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 1 : 1;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              componentMetadata = moduleInfoMetadata.Components.FirstOrDefault<ComponentMetadata>((Func<ComponentMetadata, bool>) (a => ComponentActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.vyqgaIfj4ak4btWj3FQh(ComponentActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.PwlEOAfj6NyTqHua1BT0((object) a), instanceUid)));
              num2 = 9;
              continue;
            case 11:
              // ISSUE: type reference
              message3 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426112067), (object) ComponentActionExecutionHandler.by9K1v5qsIbByWB3maL(__typeref (ComponentMetadata)).FullName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 20 : 41;
              continue;
            case 12:
              message2 = (string) ComponentActionExecutionHandler.tJVeim5emRwUVGVD1UG((object) str1, (object) EleWise.ELMA.SR.T((string) ComponentActionExecutionHandler.t0un5g5B6xcpujZoI3c(-812025778 ^ -812007650), (object) str2));
              num2 = 23;
              continue;
            case 13:
              goto label_82;
            case 14:
              fullAssemblyName = ScriptExecutionHandlerHelper.CreateFullAssemblyName((string) ComponentActionExecutionHandler.JigWTWgzhJCqHU4R20D((object) componentMetadataItem), (string) ComponentActionExecutionHandler.stMS6q5F09naGrUo7kD((object) componentMetadataItem), (string) ComponentActionExecutionHandler.t0un5g5B6xcpujZoI3c(-1998538950 ^ -1998556452), (string) ComponentActionExecutionHandler.t0un5g5B6xcpujZoI3c(236071375 ^ 236075305));
              num2 = 35;
              continue;
            case 15:
              instanceUid = ComponentActionExecutionHandler.sopgp4gsqi6NWVM6tRi((object) parameters);
              num2 = 28;
              continue;
            case 16:
              moduleVersion = (ModuleVersion) ComponentActionExecutionHandler.rCDE0p5QDAi3p1Q2D2J((object) this.moduleMetadataLoader, moduleUid, itemUid);
              num2 = 17;
              continue;
            case 17:
              serverBuildResult = (ServerBuildResult) ComponentActionExecutionHandler.A2BeYB5CAg3KVbIYbJy((object) this.moduleAssemblyLoader, moduleUid, itemUid);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 2 : 36;
              continue;
            case 18:
              goto label_15;
            case 19:
              if (ComponentActionExecutionHandler.TkgpBJ5ocUTBkrCbCTU((object) assembly, (object) null))
                break;
              goto label_4;
            case 20:
              ComponentActionExecutionHandler.RL53HP5f0MZBVXopC2H((object) EleWise.ELMA.Logging.Logger.Log, (object) message1);
              num2 = 32;
              continue;
            case 21:
              componentMetadata = (ComponentMetadata) ComponentActionExecutionHandler.rFeWeJgc40XDcJx3r32((object) componentMetadataItem);
              num2 = 14;
              continue;
            case 22:
              message1 = EleWise.ELMA.SR.T((string) ComponentActionExecutionHandler.t0un5g5B6xcpujZoI3c(1319452732 ^ 1319470624), (object) moduleUid);
              num2 = 20;
              continue;
            case 23:
              ComponentActionExecutionHandler.RL53HP5f0MZBVXopC2H((object) EleWise.ELMA.Logging.Logger.Log, (object) message2);
              num2 = 27;
              continue;
            case 24:
              assembly = (Assembly) ComponentActionExecutionHandler.qYgBdO5ERNIST6ZhgW6((object) this.lockService, (object) fullAssemblyName, true, ComponentActionExecutionHandler.Mp5D8v5b6wICAYguJLO((object) componentMetadataItem.ScriptModule), ComponentActionExecutionHandler.Wq1Ss05GKj5w49AWwgH(ComponentActionExecutionHandler.EdWVsw5hLPoAXmOyrmB((object) componentMetadataItem)));
              num2 = 44;
              continue;
            case 25:
              goto label_7;
            case 26:
              orDefault = ContextVars.GetOrDefault<UIRuntimeModel>((string) ComponentActionExecutionHandler.t0un5g5B6xcpujZoI3c(-420743386 ^ -420793634));
              num2 = 6;
              continue;
            case 27:
              goto label_81;
            case 28:
              moduleReference = this.moduleReferenceManager.LoadOrNull(instanceUid);
              num2 = 29;
              continue;
            case 29:
              moduleUid = moduleReference != null ? moduleReference.ModuleUid : Guid.Empty;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 4;
              continue;
            case 30:
              metadataList = new List<IMetadata>();
              num2 = 15;
              continue;
            case 31:
              num2 = 30;
              continue;
            case 32:
              goto label_75;
            case 33:
              List<ItemRuntimeModel> runtimeModules = orDefault.RuntimeModules;
              Func<ItemRuntimeModel, bool> func;
              Func<ItemRuntimeModel, bool> func1 = func;
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              Func<ItemRuntimeModel, bool> predicate = func1 == null ? (func = (Func<ItemRuntimeModel, bool>) (a => ComponentActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.Krps1FfjAUIaWopAeVKr(ComponentActionExecutionHandler.\u003C\u003Ec__DisplayClass7_0.WPg6BYfjHuhVJ6RMDOVM((object) a), moduleUid))) : func1;
              enumerator = runtimeModules.Where<ItemRuntimeModel>(predicate).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 39 : 39;
              continue;
            case 34:
            case 40:
label_65:
              if (componentMetadata != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 2;
                continue;
              }
              goto case 11;
            case 35:
              assembly = (Assembly) ComponentActionExecutionHandler.H76YNI5WTtybiE2oJ1H((object) fullAssemblyName, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 43 : 27;
              continue;
            case 36:
              moduleInfoMetadata = (ModuleInfoMetadata) ComponentActionExecutionHandler.txqxu55v7CVdUoIDn2f((object) moduleVersion);
              num2 = 10;
              continue;
            case 37:
              executorType = ComponentActionExecutionHandler.gBWF0w5Ou3viDsoeyXX((object) assembly, (object) str2);
              num2 = 7;
              continue;
            case 38:
              str2 = (string) ComponentActionExecutionHandler.brJmIk5nQSYb1BJMDOS((object) componentMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0 ? 34 : 37;
              continue;
            case 39:
              try
              {
label_47:
                if (ComponentActionExecutionHandler.s9cjs25in82RV3m0lMm((object) enumerator))
                  goto label_45;
                else
                  goto label_48;
label_42:
                ItemRuntimeModel current;
                ModuleInfoMetadata metadata;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      metadata = ((ModuleVersion) ComponentActionExecutionHandler.rCDE0p5QDAi3p1Q2D2J((object) this.moduleMetadataLoader, ComponentActionExecutionHandler.TqAvDy5V1g5dR8eqKW6((object) current), ComponentActionExecutionHandler.EIpOBe5SXGs5sh91hK2((object) current))).Metadata;
                      num3 = 2;
                      continue;
                    case 2:
                      metadataList.AddRange(metadata.GetMetadataToRegister());
                      num3 = 4;
                      continue;
                    case 3:
                      goto label_65;
                    case 4:
                      goto label_47;
                    default:
                      goto label_45;
                  }
                }
label_45:
                current = enumerator.Current;
                num3 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
                {
                  num3 = 1;
                  goto label_42;
                }
                else
                  goto label_42;
label_48:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 3 : 3;
                goto label_42;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
                else
                  goto label_52;
label_51:
                switch (num4)
                {
                  case 1:
                  case 2:
                }
label_52:
                ComponentActionExecutionHandler.Qyp7jk5RkS6xvReKTZN((object) enumerator);
                num4 = 2;
                goto label_51;
              }
            case 41:
              ComponentActionExecutionHandler.RL53HP5f0MZBVXopC2H((object) EleWise.ELMA.Logging.Logger.Log, (object) message3);
              num2 = 3;
              continue;
            case 42:
              if (itemRuntimeModel == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 18 : 22;
                continue;
              }
              goto label_76;
            case 43:
              if (ComponentActionExecutionHandler.TkgpBJ5ocUTBkrCbCTU((object) assembly, (object) null))
              {
                num2 = 24;
                continue;
              }
              goto case 44;
            case 44:
              metadataList.Add((IMetadata) componentMetadata);
              num2 = 8;
              continue;
            case 45:
              componentMetadataItem = this.componentMetadataItemManager.Load(instanceUid);
              num2 = 21;
              continue;
            case 46:
              str1 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876080051), ComponentActionExecutionHandler.exVjyc5TrK05P0QWAOZ((object) scriptMethodInfo), ComponentActionExecutionHandler.syVwjE5khpvhmpKhAXR((object) componentMetadata));
              num2 = 38;
              continue;
          }
          assembly = ComponentManager.LoadAssemblyWithLock(this.lockService, fullAssemblyName, true, serverBuildResult.AssemblyRaw, (byte[]) ComponentActionExecutionHandler.VnEcir5IijnEfhfTSb0((object) serverBuildResult));
          num2 = 47;
        }
label_4:
        num1 = 5;
        continue;
label_68:
        scriptMethodInfo = (ScriptMethodInfo) ComponentActionExecutionHandler.TdGdd95XQgXA1Ki9U4V(ComponentActionExecutionHandler.aga0p55KdyaAYglwPvd((object) parameters));
        num1 = 46;
        continue;
label_73:
        num1 = 45;
        continue;
label_76:
        itemUid = itemRuntimeModel.ItemUid;
        num1 = 16;
        continue;
label_82:
        num1 = 18;
      }
label_7:
      ActionExecutionResult actionExecutionResult;
      return actionExecutionResult;
label_15:
      try
      {
        MetadataServiceContext metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataList);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            try
            {
              actionExecutionResult = this.Execute(executorType, parameters);
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
                num6 = 0;
              switch (num6)
              {
                default:
                  goto label_7;
              }
            }
            finally
            {
              int num7;
              if (metadataServiceContext == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 1;
              else
                goto label_25;
label_24:
              switch (num7)
              {
                case 1:
                case 2:
              }
label_25:
              ComponentActionExecutionHandler.Qyp7jk5RkS6xvReKTZN((object) metadataServiceContext);
              num7 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
              {
                num7 = 0;
                goto label_24;
              }
              else
                goto label_24;
            }
        }
      }
      catch (Exception ex)
      {
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
          num8 = 1;
        while (true)
        {
          switch (num8)
          {
            case 1:
              ComponentActionExecutionHandler.NkGlRD5PJuGihNRpfLq((object) EleWise.ELMA.Logging.Logger.Log, (object) str1, (object) ex);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            default:
              goto label_32;
          }
        }
label_32:
        throw;
      }
label_67:
      throw new Exception(message3);
label_75:
      throw new Exception(message1);
label_81:
      throw new Exception(message2);
    }

    internal static void K13kmQgYcaFI1hkH9Qf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cZP668g51Cj6BHkDeDj() => ComponentActionExecutionHandler.uk2XLGggmufxWTOlYIC == null;

    internal static ComponentActionExecutionHandler EJhwVygjGY1yI1vK85X() => ComponentActionExecutionHandler.uk2XLGggmufxWTOlYIC;

    internal static bool oM9qwUgLoVGe1ST6WEv([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid XQkE9UgUFmFECwRRZTR([In] object obj0) => ((ActionExecutionParams) obj0).TypeUid;

    internal static Guid sopgp4gsqi6NWVM6tRi([In] object obj0) => ((ActionExecutionParams) obj0).InstanceUid;

    internal static object rFeWeJgc40XDcJx3r32([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static object JigWTWgzhJCqHU4R20D([In] object obj0) => (object) ((ComponentMetadataItem) obj0).AssemblyName;

    internal static object stMS6q5F09naGrUo7kD([In] object obj0) => (object) ((ComponentMetadataItem) obj0).AssemblyVersion;

    internal static object t0un5g5B6xcpujZoI3c(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object H76YNI5WTtybiE2oJ1H([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static bool TkgpBJ5ocUTBkrCbCTU([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object Mp5D8v5b6wICAYguJLO([In] object obj0) => (object) ((ScriptModule) obj0).AssemblyRaw;

    internal static object EdWVsw5hLPoAXmOyrmB([In] object obj0) => (object) ((ComponentMetadataItem) obj0).ScriptModule;

    internal static object Wq1Ss05GKj5w49AWwgH([In] object obj0) => (object) ((ScriptModule) obj0).DebugRaw;

    internal static object qYgBdO5ERNIST6ZhgW6(
      [In] object obj0,
      [In] object obj1,
      bool isFullName,
      [In] object obj3,
      [In] object obj4)
    {
      return (object) ComponentManager.LoadAssemblyWithLock((ILockService) obj0, (string) obj1, isFullName, (byte[]) obj3, (byte[]) obj4);
    }

    internal static void RL53HP5f0MZBVXopC2H([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object rCDE0p5QDAi3p1Q2D2J([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleMetadataLoader) obj0).GetSpecificModuleVersion(moduleUid, versionUid);

    internal static object A2BeYB5CAg3KVbIYbJy([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleAssemblyLoader) obj0).GetServerAssembly(moduleUid, versionUid);

    internal static object txqxu55v7CVdUoIDn2f([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object D9G1IW58lM98Ja5Muuu([In] object obj0) => (object) ((ServerBuildResult) obj0).AssemblyName;

    internal static object QL0SMc5ZHiLx1MUCBrT([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static object hH7BKC5ubNoOx5EZJB8([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Version;

    internal static object VnEcir5IijnEfhfTSb0([In] object obj0) => (object) ((ServerBuildResult) obj0).DebugRaw;

    internal static Guid TqAvDy5V1g5dR8eqKW6([In] object obj0) => ((ItemRuntimeModel) obj0).HeaderUid;

    internal static Guid EIpOBe5SXGs5sh91hK2([In] object obj0) => ((ItemRuntimeModel) obj0).ItemUid;

    internal static bool s9cjs25in82RV3m0lMm([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void Qyp7jk5RkS6xvReKTZN([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static Type by9K1v5qsIbByWB3maL([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object aga0p55KdyaAYglwPvd([In] object obj0) => (object) ((ActionExecutionParams) obj0).ScriptName;

    internal static object TdGdd95XQgXA1Ki9U4V([In] object obj0) => (object) ScriptMethodInfoHelper.Deserialize((string) obj0);

    internal static object exVjyc5TrK05P0QWAOZ([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static object syVwjE5khpvhmpKhAXR([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object brJmIk5nQSYb1BJMDOS([In] object obj0) => (object) ComponentMetadataHelperInternal.ControllerTypeName((ComponentMetadata) obj0);

    internal static Type gBWF0w5Ou3viDsoeyXX([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool u5FvIB52PVskxVyD9VW([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object tJVeim5emRwUVGVD1UG([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void NkGlRD5PJuGihNRpfLq([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}

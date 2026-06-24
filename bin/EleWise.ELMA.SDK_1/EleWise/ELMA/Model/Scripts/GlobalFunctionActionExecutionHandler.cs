// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.GlobalFunctionActionExecutionHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Scripts.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Services.Scope;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Выполнение действия для глобальных функций</summary>
  internal sealed class GlobalFunctionActionExecutionHandler : AbstractActionExecutionHandler
  {
    private readonly IModuleReferenceManager moduleReferenceManager;
    private readonly IFunctionMetadataItemManager functionMetadataItemManager;
    private readonly IModuleMetadataLoader moduleMetadataLoader;
    private readonly IModuleAssemblyLoader moduleAssemblyLoader;
    private static GlobalFunctionActionExecutionHandler OjPw3bbINKbu8iAPJbv0;

    /// <summary>Ctor</summary>
    /// <param name="executionScopeFactory">Фабрика для создания контекста выполнения</param>
    /// <param name="moduleReferenceManager">Менеджер ссылки метаданных на модуль</param>
    /// <param name="functionMetadataItemManager">Менеджер метаданных функций</param>
    /// <param name="moduleMetadataLoader">Загрузчик метаданных модулей</param>
    /// <param name="moduleAssemblyLoader">Загрузчик сборок модуля</param>
    public GlobalFunctionActionExecutionHandler(
      IExecutionScopeFactory executionScopeFactory,
      IModuleReferenceManager moduleReferenceManager,
      IFunctionMetadataItemManager functionMetadataItemManager,
      IModuleMetadataLoader moduleMetadataLoader,
      IModuleAssemblyLoader moduleAssemblyLoader)
    {
      GlobalFunctionActionExecutionHandler.yOymjRbIagHbQxO7anhK();
      // ISSUE: explicit constructor call
      base.\u002Ector(executionScopeFactory);
      int num = 4;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.functionMetadataItemManager = functionMetadataItemManager;
            num = 3;
            continue;
          case 3:
            this.moduleMetadataLoader = moduleMetadataLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 4:
            this.moduleReferenceManager = moduleReferenceManager;
            num = 2;
            continue;
          default:
            this.moduleAssemblyLoader = moduleAssemblyLoader;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public override bool Check(ActionExecutionParams parameters) => GlobalFunctionActionExecutionHandler.MYmQe8bItrg67018rDE3(GlobalFunctionActionExecutionHandler.ObU9RobIDKqUa8F0sxxL((object) parameters), FunctionMetadata.UID);

    /// <inheritdoc />
    public override ActionExecutionResult Execute(ActionExecutionParams parameters)
    {
      int num1 = 10;
      string str1;
      string message1;
      List<IMetadata> metadataList;
      Type executorType;
      string message2;
      string str2;
      while (true)
      {
        int num2 = num1;
        ItemRuntimeModel itemRuntimeModel;
        ScriptMethodInfo scriptMethodInfo;
        FunctionMetadata functionMetadata;
        ServerBuildResult serverBuildResult;
        ModuleVersion moduleVersion;
        Assembly assembly;
        UIRuntimeModel orDefault;
        ModuleInfoMetadata moduleInfoMetadata;
        FunctionMetadataItem functionMetadataItem;
        Guid versionUid;
        IEnumerator<ItemRuntimeModel> enumerator;
        ModuleReference moduleReference;
        Guid moduleUid;
        Guid instanceUid;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (GlobalFunctionActionExecutionHandler.C7ZBBrbIdNCW80cwfRh1((object) assembly, (object) null))
              {
                num2 = 8;
                continue;
              }
              goto case 21;
            case 2:
              moduleVersion = (ModuleVersion) GlobalFunctionActionExecutionHandler.OsdKmCbI0aIntKvpUY6p((object) this.moduleMetadataLoader, moduleUid, versionUid);
              num2 = 13;
              continue;
            case 3:
              versionUid = GlobalFunctionActionExecutionHandler.Gq1EOVbIxWoqS38hu15N((object) itemRuntimeModel);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 2 : 0;
              continue;
            case 4:
              if (!GlobalFunctionActionExecutionHandler.MYmQe8bItrg67018rDE3(moduleUid, Guid.Empty))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 11 : 0;
                continue;
              }
              goto case 28;
            case 5:
            case 11:
              goto label_10;
            case 6:
              str1 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87321963), GlobalFunctionActionExecutionHandler.FTTkQbbI5eLtPWafIFR9((object) scriptMethodInfo), GlobalFunctionActionExecutionHandler.i8NqSZbIjmAQSEjWa29n((object) functionMetadata));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 33 : 18;
              continue;
            case 7:
              assembly = (Assembly) GlobalFunctionActionExecutionHandler.cjKj2DbI6tFGjO9W2HYQ((object) ScriptExecutionHandlerHelper.CreateFullAssemblyName(functionMetadataItem.AssemblyName, functionMetadataItem.AssemblyVersion, (string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(2008901894 << 3 ^ -1108636202), (string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-1872275253 >> 6 ^ -29258363)), true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 6 : 27;
              continue;
            case 8:
              assembly = (Assembly) GlobalFunctionActionExecutionHandler.wl6wosbIAhe9pp8JFSN0(GlobalFunctionActionExecutionHandler.U2cQ0XbIl019JQtWlZXv((object) serverBuildResult), (object) serverBuildResult.DebugRaw);
              num2 = 21;
              continue;
            case 9:
              metadataList = new List<IMetadata>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 26 : 20;
              continue;
            case 10:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 9 : 6;
              continue;
            case 12:
              moduleReference = this.moduleReferenceManager.LoadOrNull(instanceUid);
              num2 = 20;
              continue;
            case 13:
              serverBuildResult = (ServerBuildResult) GlobalFunctionActionExecutionHandler.dbWwL6bImHOsla5G9PeO((object) this.moduleAssemblyLoader, moduleUid, versionUid);
              num2 = 14;
              continue;
            case 14:
              moduleInfoMetadata = (ModuleInfoMetadata) GlobalFunctionActionExecutionHandler.el4OvJbIyV0N2D3rVKqw((object) moduleVersion);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
              continue;
            case 15:
              if (itemRuntimeModel != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 3 : 3;
                continue;
              }
              goto case 32;
            case 16:
              goto label_38;
            case 17:
            case 22:
label_14:
              if (functionMetadata != null)
              {
                num2 = 39;
                continue;
              }
              goto case 40;
            case 18:
              assembly = (Assembly) GlobalFunctionActionExecutionHandler.wl6wosbIAhe9pp8JFSN0((object) functionMetadataItem.AssemblyRaw, GlobalFunctionActionExecutionHandler.uV9YY7bIHEZrXH1H8sus((object) functionMetadataItem));
              num2 = 22;
              continue;
            case 19:
              functionMetadata = functionMetadataItem.Metadata as FunctionMetadata;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 7;
              continue;
            case 20:
              moduleUid = moduleReference != null ? moduleReference.ModuleUid : Guid.Empty;
              num2 = 4;
              continue;
            case 21:
              metadataList.AddRange(moduleInfoMetadata.GetMetadataToRegister());
              num2 = 34;
              continue;
            case 23:
              goto label_19;
            case 24:
              parameters.ParameterType = (TypeSignature) GlobalFunctionActionExecutionHandler.X5BuJZbIc5KLFgPgeSZw((object) functionMetadata);
              num2 = 43;
              continue;
            case 25:
              try
              {
label_49:
                if (GlobalFunctionActionExecutionHandler.HZmbVGbIrSwAqTSQhWAZ((object) enumerator))
                  goto label_52;
                else
                  goto label_50;
label_48:
                ModuleInfoMetadata metadata;
                ItemRuntimeModel current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      goto label_49;
                    case 2:
                      goto label_52;
                    case 3:
                      goto label_14;
                    case 4:
                      metadata = ((ModuleVersion) GlobalFunctionActionExecutionHandler.OsdKmCbI0aIntKvpUY6p((object) this.moduleMetadataLoader, current.HeaderUid, GlobalFunctionActionExecutionHandler.Gq1EOVbIxWoqS38hu15N((object) current))).Metadata;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
                      continue;
                    default:
                      metadataList.AddRange(metadata.GetMetadataToRegister());
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 1 : 1;
                      continue;
                  }
                }
label_50:
                num3 = 3;
                goto label_48;
label_52:
                current = enumerator.Current;
                num3 = 4;
                goto label_48;
              }
              finally
              {
                int num4;
                if (enumerator == null)
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 1 : 1;
                else
                  goto label_57;
label_56:
                switch (num4)
                {
                  case 2:
                    break;
                  default:
                }
label_57:
                GlobalFunctionActionExecutionHandler.nsMynwbIgjQed7eoNqfo((object) enumerator);
                num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
                {
                  num4 = 0;
                  goto label_56;
                }
                else
                  goto label_56;
              }
            case 26:
              instanceUid = GlobalFunctionActionExecutionHandler.dLCXRjbIwTxDAEIRP9fM((object) parameters);
              num2 = 12;
              continue;
            case 27:
              if (assembly == (Assembly) null)
              {
                num2 = 18;
                continue;
              }
              goto case 17;
            case 28:
              functionMetadataItem = this.functionMetadataItemManager.Load(instanceUid);
              num2 = 19;
              continue;
            case 29:
              goto label_11;
            case 30:
              GlobalFunctionActionExecutionHandler.H1D9flbI7xmf8m4Dn2OO((object) EleWise.ELMA.Logging.Logger.Log, (object) message2);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 26 : 38;
              continue;
            case 31:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              itemRuntimeModel = orDefault.RuntimeModules.FirstOrDefault<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => GlobalFunctionActionExecutionHandler.\u003C\u003Ec__DisplayClass6_0.tl05D5CPkRRAoNedVthN(GlobalFunctionActionExecutionHandler.\u003C\u003Ec__DisplayClass6_0.EXdI5GCPTWR3sWniftM2((object) a), moduleUid)));
              num2 = 15;
              continue;
            case 32:
              message2 = EleWise.ELMA.SR.T((string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-1350312861 << 3 ^ 2082350340), (object) moduleUid);
              num2 = 30;
              continue;
            case 33:
              str2 = (string) GlobalFunctionActionExecutionHandler.amnbFxbIY8u34JQ3iW1m((object) functionMetadata);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 16 : 36;
              continue;
            case 34:
              // ISSUE: reference to a compiler-generated method
              enumerator = orDefault.RuntimeModules.Where<ItemRuntimeModel>((Func<ItemRuntimeModel, bool>) (a => GlobalFunctionActionExecutionHandler.\u003C\u003Ec__DisplayClass6_0.io5sQlCPO11Gv6RDaXV9(a.HeaderUid, moduleUid))).GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 16 : 25;
              continue;
            case 35:
              goto label_75;
            case 36:
              executorType = GlobalFunctionActionExecutionHandler.NqN12KbILLMRO03A1pXp((object) assembly, (object) str2);
              num2 = 41;
              continue;
            case 37:
              assembly = (Assembly) GlobalFunctionActionExecutionHandler.cjKj2DbI6tFGjO9W2HYQ((object) ScriptExecutionHandlerHelper.CreateFullAssemblyName((string) GlobalFunctionActionExecutionHandler.LCxUBGbIMywGTtcNBRYT((object) serverBuildResult), GlobalFunctionActionExecutionHandler.s6mJqxbI9CE5UCTopoIf(GlobalFunctionActionExecutionHandler.huwIpEbIJFW9UdJSfdY1((object) moduleVersion)).ToString(), (string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(694673736 ^ -23604109 ^ -672075555), z2jc63fLkugS1X8Q9N.tE1kD1vbB(323422137 << 2 ^ 1293684226)), true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 1 : 1;
              continue;
            case 38:
              goto label_63;
            case 39:
              scriptMethodInfo = ScriptMethodInfoHelper.Deserialize(parameters.ScriptName);
              num2 = 6;
              continue;
            case 40:
              message1 = EleWise.ELMA.SR.T((string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-1872275253 >> 6 ^ -29271065), (object) typeof (FunctionMetadata).FullName);
              num2 = 42;
              continue;
            case 41:
              if (!GlobalFunctionActionExecutionHandler.GnWk0gbIUQ3lkD3imTGn(executorType, (Type) null))
              {
                GlobalFunctionActionExecutionHandler.uVaCABbIsDFqq5QP4NJp((object) parameters, GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-787452571 ^ -787294443));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 24 : 7;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 16;
              continue;
            case 42:
              GlobalFunctionActionExecutionHandler.H1D9flbI7xmf8m4Dn2OO((object) EleWise.ELMA.Logging.Logger.Log, (object) message1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 35 : 34;
              continue;
            case 43:
              parameters.ReturnType = (TypeSignature) GlobalFunctionActionExecutionHandler.xQEecKbIzYGXS5beBJE2((object) functionMetadata);
              num2 = 23;
              continue;
            default:
              // ISSUE: reference to a compiler-generated method
              functionMetadata = moduleInfoMetadata.Functions.FirstOrDefault<FunctionMetadata>((Func<FunctionMetadata, bool>) (a => GlobalFunctionActionExecutionHandler.\u003C\u003Ec__DisplayClass6_0.FL959OCPnvE6A9TQd1my((object) a) == instanceUid));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 37 : 21;
              continue;
          }
        }
label_10:
        orDefault = ContextVars.GetOrDefault<UIRuntimeModel>((string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-2138958856 ^ -2138909184));
        num1 = 31;
      }
label_11:
      ActionExecutionResult actionExecutionResult;
      return actionExecutionResult;
label_19:
      try
      {
        MetadataServiceContext metadataServiceContext = MetadataServiceContext.Extend((IEnumerable<IMetadata>) metadataList);
        int num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
          num5 = 0;
        switch (num5)
        {
          default:
            try
            {
              actionExecutionResult = this.Execute(executorType, parameters);
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
                num6 = 0;
              switch (num6)
              {
                default:
                  goto label_11;
              }
            }
            finally
            {
              int num7;
              if (metadataServiceContext == null)
                num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
              else
                goto label_29;
label_28:
              switch (num7)
              {
                case 1:
                  break;
                default:
              }
label_29:
              GlobalFunctionActionExecutionHandler.nsMynwbIgjQed7eoNqfo((object) metadataServiceContext);
              num7 = 2;
              goto label_28;
            }
        }
      }
      catch (Exception ex)
      {
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
          num8 = 0;
        while (true)
        {
          switch (num8)
          {
            case 1:
              goto label_35;
            default:
              GlobalFunctionActionExecutionHandler.Dp5bHbbVBgbRN4xPVjsF(GlobalFunctionActionExecutionHandler.DJS2ZjbVFd8Ej6hZ3dcI(), (object) str1, (object) ex);
              num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 1;
              continue;
          }
        }
label_35:
        throw;
      }
label_38:
      throw new Exception(EleWise.ELMA.SR.T((string) GlobalFunctionActionExecutionHandler.oRDpn5bI46Buy5Y16PJH(-688192331 - 435440695 ^ -1123810702), (object) str2));
label_63:
      throw new Exception(message2);
label_75:
      throw new Exception(message1);
    }

    internal static void yOymjRbIagHbQxO7anhK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool JfHdyGbI3BGj8fwsjGii() => GlobalFunctionActionExecutionHandler.OjPw3bbINKbu8iAPJbv0 == null;

    internal static GlobalFunctionActionExecutionHandler aQgsO3bIpq8DLGmhyg01() => GlobalFunctionActionExecutionHandler.OjPw3bbINKbu8iAPJbv0;

    internal static Guid ObU9RobIDKqUa8F0sxxL([In] object obj0) => ((ActionExecutionParams) obj0).TypeUid;

    internal static bool MYmQe8bItrg67018rDE3([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static Guid dLCXRjbIwTxDAEIRP9fM([In] object obj0) => ((ActionExecutionParams) obj0).InstanceUid;

    internal static object oRDpn5bI46Buy5Y16PJH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object cjKj2DbI6tFGjO9W2HYQ([In] object obj0, bool isFullName) => (object) ComponentManager.FindLoadedAssembly((string) obj0, isFullName);

    internal static object uV9YY7bIHEZrXH1H8sus([In] object obj0) => (object) ((FunctionMetadataItem) obj0).DebugRaw;

    internal static object wl6wosbIAhe9pp8JFSN0([In] object obj0, [In] object obj1) => (object) ComponentManager.LoadAssembly((byte[]) obj0, (byte[]) obj1);

    internal static void H1D9flbI7xmf8m4Dn2OO([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static Guid Gq1EOVbIxWoqS38hu15N([In] object obj0) => ((ItemRuntimeModel) obj0).ItemUid;

    internal static object OsdKmCbI0aIntKvpUY6p([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleMetadataLoader) obj0).GetSpecificModuleVersion(moduleUid, versionUid);

    internal static object dbWwL6bImHOsla5G9PeO([In] object obj0, Guid moduleUid, Guid versionUid) => (object) ((IModuleAssemblyLoader) obj0).GetServerAssembly(moduleUid, versionUid);

    internal static object el4OvJbIyV0N2D3rVKqw([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object LCxUBGbIMywGTtcNBRYT([In] object obj0) => (object) ((ServerBuildResult) obj0).AssemblyName;

    internal static object huwIpEbIJFW9UdJSfdY1([In] object obj0) => (object) ((ModuleVersion) obj0).Header;

    internal static object s6mJqxbI9CE5UCTopoIf([In] object obj0) => (object) ((ModuleVersionHeader) obj0).Version;

    internal static bool C7ZBBrbIdNCW80cwfRh1([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object U2cQ0XbIl019JQtWlZXv([In] object obj0) => (object) ((ServerBuildResult) obj0).AssemblyRaw;

    internal static bool HZmbVGbIrSwAqTSQhWAZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void nsMynwbIgjQed7eoNqfo([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object FTTkQbbI5eLtPWafIFR9([In] object obj0) => (object) ((ScriptMethodInfo) obj0).Name;

    internal static object i8NqSZbIjmAQSEjWa29n([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static object amnbFxbIY8u34JQ3iW1m([In] object obj0) => (object) FunctionMetadataHelper.ExecutorTypeName((FunctionMetadata) obj0);

    internal static Type NqN12KbILLMRO03A1pXp([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool GnWk0gbIUQ3lkD3imTGn([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static void uVaCABbIsDFqq5QP4NJp([In] object obj0, [In] object obj1) => ((ActionExecutionParams) obj0).ScriptName = (string) obj1;

    internal static object X5BuJZbIc5KLFgPgeSZw([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static object xQEecKbIzYGXS5beBJE2([In] object obj0) => (object) ((FunctionMetadata) obj0).ReturnType;

    internal static object DJS2ZjbVFd8Ej6hZ3dcI() => (object) EleWise.ELMA.Logging.Logger.Log;

    internal static void Dp5bHbbVBgbRN4xPVjsF([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);
  }
}

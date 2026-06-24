// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.FunctionMetadataImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.BPMApps.Enum;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Events;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Signatures;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки функций при импорте конфигурации
  /// </summary>
  [Component]
  internal class FunctionMetadataImportExtension : NamedMetadataImportExtension<FunctionMetadata>
  {
    private static readonly ILogger ImportLog;
    private readonly IFunctionMetadataItemManager functionMetadataItemManager;
    private readonly IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager;
    private readonly IMetadataItemGroupUIManager metadataItemGroupUIManager;
    private readonly IActorContextService actorContextService;
    private readonly IFeatureFlagService featureFlagService;
    private static FunctionMetadataImportExtension ldwAEZEdb7WQ6l9lGVSL;

    /// <summary>ctor</summary>
    /// <param name="functionMetadataItemManager">Интерфейс менеджера метаданных функций</param>
    /// <param name="functionMetadataItemHeaderManager">Интерфейс менеджера заголовка метаданных функций</param>
    /// <param name="metadataItemGroupUIManager">Менеджер метаданных групп КИ</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public FunctionMetadataImportExtension(
      IFunctionMetadataItemManager functionMetadataItemManager,
      IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager,
      IMetadataItemGroupUIManager metadataItemGroupUIManager,
      IActorContextService actorContextService,
      IFeatureFlagService featureFlagService)
    {
      FunctionMetadataImportExtension.m8fsciEdEeKnAYIlyPnb();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.featureFlagService = featureFlagService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            this.metadataItemGroupUIManager = metadataItemGroupUIManager;
            num = 4;
            continue;
          case 3:
            this.functionMetadataItemHeaderManager = functionMetadataItemHeaderManager;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 2 : 2;
            continue;
          case 4:
            this.actorContextService = actorContextService;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          case 5:
            this.functionMetadataItemManager = functionMetadataItemManager;
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_2:
      return;
label_8:;
    }

    /// <inheritdoc />
    protected override bool TestMetadata(
      FunctionMetadata mdMerged,
      ReadMetadataParameters parameters,
      bool isTestRead)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            FunctionMetadataImportExtension.fCbs8UEdQyEhEGTJ7T3p((object) parameters, (object) new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335280539), FunctionMetadataImportExtension.Ce4txZEdfSnFOW1ESNOh((object) mdMerged))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!this.SecondRuntimeEnabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_5;
        }
      }
label_5:
      return false;
label_6:
      return base.TestMetadata(mdMerged, parameters, isTestRead);
    }

    /// <inheritdoc />
    protected override bool CheckMetadata(
      FunctionMetadata mdImported,
      FunctionMetadata mdDraft,
      ReadMetadataParameters parameters)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.SecondRuntimeEnabled)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            parameters.TestMessagesAdd(new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T((string) FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(589593376 ^ -1977315327 ^ -1459336373), FunctionMetadataImportExtension.Ce4txZEdfSnFOW1ESNOh((object) mdImported))));
            num = 3;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_3;
        }
      }
label_2:
      return false;
label_3:
      return base.CheckMetadata(mdImported, mdDraft, parameters);
    }

    /// <inheritdoc />
    protected override void CheckNewMetadata(
      FunctionMetadata mdImported,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((TypeSignature) FunctionMetadataImportExtension.rVGQaCEdIsmUusiV0ZoC((object) mdImported)).SubTypeUid = FunctionMetadataImportExtension.oB8UHqEdZ5cFxSMTLGSv(FunctionMetadataImportExtension.bVem78EdV7e8yUhAfplC((object) parameters), FunctionMetadataImportExtension.M9CudCEd8q8dgWqYAUeg(FunctionMetadataImportExtension.rVGQaCEdIsmUusiV0ZoC((object) mdImported)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
            continue;
          case 2:
            if (!isTestRead)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0 ? 4 : 4;
              continue;
            }
            goto label_8;
          case 3:
            base.CheckNewMetadata(mdImported, isTestRead, parameters);
            num = 2;
            continue;
          case 4:
            FunctionMetadataImportExtension.px81SwEdu18e2Wvx0R9a(FunctionMetadataImportExtension.Lske4VEdvs27KL03YrJ5((object) mdImported), FunctionMetadataImportExtension.oB8UHqEdZ5cFxSMTLGSv((object) parameters.MergeReplace, FunctionMetadataImportExtension.M9CudCEd8q8dgWqYAUeg(FunctionMetadataImportExtension.Lske4VEdvs27KL03YrJ5((object) mdImported))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 0;
            continue;
          default:
            goto label_9;
        }
      }
label_2:
      return;
label_9:
      return;
label_8:;
    }

    /// <inheritdoc />
    protected override void MergeMetadata(
      FunctionMetadata mdImported,
      FunctionMetadata mdDraft,
      bool isTestRead,
      ReadMetadataParameters parameters)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            mdDraft.ParameterType = (TypeSignature) FunctionMetadataImportExtension.rVGQaCEdIsmUusiV0ZoC((object) mdImported);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 2 : 2;
            continue;
          case 2:
            FunctionMetadataImportExtension.px81SwEdu18e2Wvx0R9a(FunctionMetadataImportExtension.Lske4VEdvs27KL03YrJ5((object) mdDraft), parameters.MergeReplace.GetUidReplaceMD(FunctionMetadataImportExtension.M9CudCEd8q8dgWqYAUeg(FunctionMetadataImportExtension.Lske4VEdvs27KL03YrJ5((object) mdDraft))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0 ? 2 : 6;
            continue;
          case 3:
            goto label_7;
          case 4:
            if (isTestRead)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            base.MergeMetadata(mdImported, mdDraft, isTestRead, parameters);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 4 : 1;
            continue;
          case 6:
            FunctionMetadataImportExtension.px81SwEdu18e2Wvx0R9a(FunctionMetadataImportExtension.rVGQaCEdIsmUusiV0ZoC((object) mdDraft), FunctionMetadataImportExtension.oB8UHqEdZ5cFxSMTLGSv((object) parameters.MergeReplace, FunctionMetadataImportExtension.M9CudCEd8q8dgWqYAUeg(FunctionMetadataImportExtension.rVGQaCEdIsmUusiV0ZoC((object) mdDraft))));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 7 : 4;
            continue;
          case 7:
            goto label_2;
        }
        mdDraft.ReturnType = (TypeSignature) FunctionMetadataImportExtension.Lske4VEdvs27KL03YrJ5((object) mdImported);
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 1;
      }
label_7:
      return;
label_2:;
    }

    /// <inheritdoc />
    protected override void SaveMetadata(
      FunctionMetadata mdMerged,
      ReadMetadataParameters parameters)
    {
      int num1 = 19;
      while (true)
      {
        int num2 = num1;
        FunctionMetadataItem functionMetadataItem;
        Type type1;
        while (true)
        {
          Guid result;
          MetadataItemGroupUI metadataItemGroupUi;
          string key;
          string input;
          object obj;
          switch (num2)
          {
            case 1:
              parameters.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178519268), (object) FunctionMetadataImportExtension.xa1LINEdNDWe2dTHL2gc((object) mdMerged), FunctionMetadataImportExtension.Ce4txZEdfSnFOW1ESNOh((object) mdMerged), FunctionMetadataImportExtension.QyIj43EdRBCVhiGgH7hC((object) mdMerged)), false));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 20 : 8;
              continue;
            case 2:
              FunctionMetadataImportExtension.sbe2MmEdkRtg4j9EwXL6(FunctionMetadataImportExtension.GcM0wjEdTtOYQss3Uktb((object) functionMetadataItem), mdMerged.Uid);
              num2 = 8;
              continue;
            case 3:
              FunctionMetadataImportExtension.ImportLog.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917046656), (object) type1.Name, (object) FunctionMetadataImportExtension.Gd0fObEdDX0QbOTBStLb((object) functionMetadataItem));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 1 : 1;
              continue;
            case 4:
              if (metadataItemGroupUi != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              }
              goto case 14;
            case 5:
              if (Guid.TryParse(input, out result))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 24 : 21;
                continue;
              }
              goto case 14;
            case 6:
              functionMetadataItem = (FunctionMetadataItem) FunctionMetadataImportExtension.xmkXjAEdiYGnDQE7KwYK((object) this.functionMetadataItemManager, mdMerged.ModuleUid, Guid.Empty, FunctionMetadataImportExtension.Ce4txZEdfSnFOW1ESNOh((object) mdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 17 : 11;
              continue;
            case 7:
              FunctionMetadataImportExtension.ImportLog.InfoFormat((string) FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(712480695 ^ 712203127), FunctionMetadataImportExtension.VBTIfbEdaRQmO9vAmios((object) type1), (object) FunctionMetadataImportExtension.Gd0fObEdDX0QbOTBStLb((object) functionMetadataItem));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 12 : 13;
              continue;
            case 8:
              FunctionMetadataImportExtension.omj4j8EdOh1i6dDyFbpZ(FunctionMetadataImportExtension.oN4sR5EdnC45JLlK5895((object) functionMetadataItem));
              num2 = 16;
              continue;
            case 9:
              FunctionMetadataImportExtension.v9od59EdXphV3ySLFe6S((object) functionMetadataItem.Header, FunctionMetadataImportExtension.PXseL8EdKKXcWR5pSL78((object) mdMerged));
              num2 = 2;
              continue;
            case 10:
              if (functionMetadataItem == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 6;
                continue;
              }
              goto label_17;
            case 11:
              goto label_21;
            case 12:
              goto label_3;
            case 13:
              functionMetadataItem.Save();
              num2 = 3;
              continue;
            case 14:
              if (!FunctionMetadataImportExtension.ImportLog.IsInfoEnabled())
              {
                num2 = 11;
                continue;
              }
              goto label_37;
            case 15:
              EntityMetadataDependencyService.GetPromisedMetadataDependencies(this.actorContextService).Add((IMetadata) mdMerged);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 12 : 0;
              continue;
            case 16:
              goto label_31;
            case 17:
              FunctionMetadataImportExtension.jBYs0QEdqsnRI19JxJwB((object) functionMetadataItem.Header, FunctionMetadataImportExtension.QyIj43EdRBCVhiGgH7hC((object) mdMerged));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 9 : 9;
              continue;
            case 18:
              obj = (object) null;
              break;
            case 19:
              FunctionMetadataItemHeader metadataItemHeader = this.functionMetadataItemHeaderManager.LoadOrNull(mdMerged.Uid);
              if (metadataItemHeader == null)
              {
                num2 = 18;
                continue;
              }
              obj = FunctionMetadataImportExtension.R77Xb4EdS8sx0lxhc1LO((object) metadataItemHeader);
              break;
            case 20:
              FunctionMetadataImportExtension.GetImportHeaders((object) this.actorContextService).Add(FunctionMetadataImportExtension.X6xJB5EdtgvMCavatuNA((object) functionMetadataItem.Header));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 11 : 15;
              continue;
            case 21:
              goto label_17;
            case 22:
              key = (string) FunctionMetadataImportExtension.b59VkWEd3VguqrxgWl40(FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(-867826612 ^ -868038440), (object) FunctionMetadataImportExtension.xa1LINEdNDWe2dTHL2gc((object) mdMerged));
              num2 = 25;
              continue;
            case 23:
              FunctionMetadataItem metadataItem = functionMetadataItem;
              // ISSUE: type reference
              ParameterExpression parameterExpression = (ParameterExpression) FunctionMetadataImportExtension.owhoMHEdPHaxHeYrfMoG(FunctionMetadataImportExtension.yncGLZEdepJEH1F4QC0I(__typeref (FunctionMetadataItem)), FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(1113862659 ^ 1113900947));
              // ISSUE: method reference
              Expression<Func<FunctionMetadataItem, ScriptModule>> propertyExpression = Expression.Lambda<Func<FunctionMetadataItem, ScriptModule>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) FunctionMetadataImportExtension.oqFM6XEd1lZjp30Krux1(__methodref (FunctionMetadataItem.get_ScriptModule))), parameterExpression);
              ReadMetadataParameters parameters1 = parameters;
              this.SetScriptModule<FunctionMetadataItem>(metadataItem, propertyExpression, parameters1);
              num2 = 22;
              continue;
            case 24:
              metadataItemGroupUi = this.metadataItemGroupUIManager.LoadOrNull(result);
              num2 = 4;
              continue;
            case 25:
              if (parameters.ServiceData.TryGetValue(key, out input))
              {
                num2 = 5;
                continue;
              }
              goto case 14;
            default:
              FunctionMetadataImportExtension.nhoct7EdpvpJVLKqEEKO(FunctionMetadataImportExtension.GcM0wjEdTtOYQss3Uktb((object) functionMetadataItem), (object) metadataItemGroupUi);
              num2 = 14;
              continue;
          }
          functionMetadataItem = (FunctionMetadataItem) obj;
          num2 = 10;
        }
label_17:
        FunctionMetadataImportExtension.GcsajsEd23Wnannrxr2M((object) functionMetadataItem, (object) mdMerged);
        num1 = 23;
        continue;
label_21:
        Type type2 = (Type) null;
        goto label_38;
label_31:
        functionMetadataItem.ScriptModule = (ScriptModule) null;
        num1 = 21;
        continue;
label_37:
        type2 = mdMerged.GetType();
label_38:
        type1 = type2;
        num1 = 7;
      }
label_3:;
    }

    private static ICollection<Guid> GetImportHeaders(object actorContextService)
    {
      object importHeaders;
      if (!((IActorContextService) actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998292318), out importHeaders))
        ((IActorContextService) actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112456434), (object) (List<Guid>) (importHeaders = (object) new List<Guid>()));
      return (ICollection<Guid>) importHeaders;
    }

    /// <summary>Включен ли второй рантайм</summary>
    private bool SecondRuntimeEnabled => FunctionMetadataImportExtension.dLYlr9EdwsKFmlFeW06D((object) this.featureFlagService, FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(572119659 - -337058038 ^ 909139307), false);

    static FunctionMetadataImportExtension()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            FunctionMetadataImportExtension.ImportLog = EleWise.ELMA.Logging.Logger.GetLogger((string) FunctionMetadataImportExtension.OHWPRAEdCPvCkCi9QOGF(1251470110 >> 2 ^ 312572185));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            FunctionMetadataImportExtension.m8fsciEdEeKnAYIlyPnb();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void m8fsciEdEeKnAYIlyPnb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool SR2NF3EdhUf3aNcVGGc6() => FunctionMetadataImportExtension.ldwAEZEdb7WQ6l9lGVSL == null;

    internal static FunctionMetadataImportExtension x9d0vsEdGDeYhkkYxlvl() => FunctionMetadataImportExtension.ldwAEZEdb7WQ6l9lGVSL;

    internal static object Ce4txZEdfSnFOW1ESNOh([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static void fCbs8UEdQyEhEGTJ7T3p([In] object obj0, [In] object obj1) => ((ReadMetadataParameters) obj0).TestMessagesAdd((TestImportMessages) obj1);

    internal static object OHWPRAEdCPvCkCi9QOGF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object Lske4VEdvs27KL03YrJ5([In] object obj0) => (object) ((FunctionMetadata) obj0).ReturnType;

    internal static Guid M9CudCEd8q8dgWqYAUeg([In] object obj0) => ((TypeSignature) obj0).SubTypeUid;

    internal static Guid oB8UHqEdZ5cFxSMTLGSv([In] object obj0, Guid uidFrom) => ((MergeReplace) obj0).GetUidReplaceMD(uidFrom);

    internal static void px81SwEdu18e2Wvx0R9a([In] object obj0, Guid value) => ((TypeSignature) obj0).SubTypeUid = value;

    internal static object rVGQaCEdIsmUusiV0ZoC([In] object obj0) => (object) ((FunctionMetadata) obj0).ParameterType;

    internal static object bVem78EdV7e8yUhAfplC([In] object obj0) => (object) ((ReadMetadataParameters) obj0).MergeReplace;

    internal static object R77Xb4EdS8sx0lxhc1LO([In] object obj0) => (object) ((FunctionMetadataItemHeader) obj0).Draft;

    internal static object xmkXjAEdiYGnDQE7KwYK(
      [In] object obj0,
      Guid moduleUid,
      Guid group,
      [In] object obj3)
    {
      return (object) ((IFunctionMetadataItemManager) obj0).Create(moduleUid, group, (string) obj3);
    }

    internal static object QyIj43EdRBCVhiGgH7hC([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static void jBYs0QEdqsnRI19JxJwB([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Name = (string) obj1;

    internal static object PXseL8EdKKXcWR5pSL78([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static void v9od59EdXphV3ySLFe6S([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Description = (string) obj1;

    internal static object GcM0wjEdTtOYQss3Uktb([In] object obj0) => (object) ((FunctionMetadataItem) obj0).Header;

    internal static void sbe2MmEdkRtg4j9EwXL6([In] object obj0, Guid value) => ((FunctionMetadataItemHeader) obj0).Uid = value;

    internal static object oN4sR5EdnC45JLlK5895([In] object obj0) => (object) ((FunctionMetadataItem) obj0).ScriptModule;

    internal static void omj4j8EdOh1i6dDyFbpZ([In] object obj0) => ((Entity<long>) obj0).Delete();

    internal static void GcsajsEd23Wnannrxr2M([In] object obj0, [In] object obj1) => ((FunctionMetadataItem) obj0).Metadata = obj1;

    internal static Type yncGLZEdepJEH1F4QC0I([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object owhoMHEdPHaxHeYrfMoG([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object oqFM6XEd1lZjp30Krux1([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static Guid xa1LINEdNDWe2dTHL2gc([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static object b59VkWEd3VguqrxgWl40([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void nhoct7EdpvpJVLKqEEKO([In] object obj0, [In] object obj1) => ((FunctionMetadataItemHeader) obj0).Group = (MetadataItemGroupUI) obj1;

    internal static object VBTIfbEdaRQmO9vAmios([In] object obj0) => (object) ((MemberInfo) obj0).Name;

    internal static Guid Gd0fObEdDX0QbOTBStLb([In] object obj0) => ((FunctionMetadataItem) obj0).Uid;

    internal static Guid X6xJB5EdtgvMCavatuNA([In] object obj0) => ((FunctionMetadataItemHeader) obj0).Uid;

    internal static bool dLYlr9EdwsKFmlFeW06D([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    /// <summary>Расширение обработки метаданных функций после импорта</summary>
    [Component(Order = 2300)]
    private sealed class FunctionConfigImportExtension : ConfigImportExtension
    {
      private readonly object functionMetadataItemHeaderManager;
      private readonly object functionMetadataItemManager;
      private readonly object securityService;
      private readonly object actorContextService;
      internal static object TpFonX8Hu1uQ1GivblVK;

      /// <summary>Ctor</summary>
      /// <param name="functionMetadataItemHeaderManager">Менеджер заголовков метаданных функций</param>
      /// <param name="functionMetadataItemManager">Менеджер метаданных функций</param>
      /// <param name="securityService">Сервис проверки привилегий</param>
      /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
      public FunctionConfigImportExtension(
        IFunctionMetadataItemHeaderManager functionMetadataItemHeaderManager,
        IFunctionMetadataItemManager functionMetadataItemManager,
        ISecurityService securityService,
        IActorContextService actorContextService)
      {
        FunctionMetadataImportExtension.FunctionConfigImportExtension.R9pFj88HS2bXgFaXmk4a();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 3;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              this.functionMetadataItemManager = (object) functionMetadataItemManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 3:
              this.functionMetadataItemHeaderManager = (object) functionMetadataItemHeaderManager;
              num = 2;
              continue;
            case 4:
              this.actorContextService = (object) actorContextService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
              continue;
            default:
              this.securityService = (object) securityService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 4 : 4;
              continue;
          }
        }
label_2:;
      }

      /// <inheritdoc />
      public override void OnPostReadPackets(PostReadPacketsParameters parameters)
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          ICollection<Guid> importHeaders;
          List<KeyValuePair<string, string>> list;
          Guid[] array;
          PostReadPacketsParameters parameters1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                parameters1 = parameters;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 9 : 14;
                continue;
              case 2:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
                continue;
              case 3:
                array = list.Select<KeyValuePair<string, string>, Guid>((Func<KeyValuePair<string, string>, Guid>) (record => new Guid(record.Value))).ToArray<Guid>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
                continue;
              case 4:
              case 7:
                if (FunctionMetadataImportExtension.FunctionConfigImportExtension.ueZX5N8HiMPZeKIHNi9s((object) parameters1) == 2)
                {
                  num2 = 12;
                  continue;
                }
                goto label_20;
              case 5:
                this.Publish((IEnumerable<Guid>) importHeaders, (ICollection<DeployLogMessage>) parameters1.Messages, (string) FunctionMetadataImportExtension.FunctionConfigImportExtension.lDo5qi8HqCcGfIvPap0t((object) parameters1));
                num2 = 4;
                continue;
              case 6:
                goto label_22;
              case 8:
                goto label_16;
              case 9:
                this.Publish((IEnumerable<Guid>) array, (ICollection<DeployLogMessage>) parameters1.Messages, (string) FunctionMetadataImportExtension.FunctionConfigImportExtension.lDo5qi8HqCcGfIvPap0t((object) parameters1));
                num2 = 15;
                continue;
              case 10:
                goto label_7;
              case 11:
                if (FunctionMetadataImportExtension.FunctionConfigImportExtension.PcZ8wm8HRF5JjQ7c3nVW((object) importHeaders) > 0)
                  goto case 5;
                else
                  goto label_4;
              case 12:
                Dictionary<string, string> serviceData = parameters1.ServiceData;
                // ISSUE: reference to a compiler-generated field
                Func<KeyValuePair<string, string>, bool> func = FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__5_0;
                Func<KeyValuePair<string, string>, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__5_0 = predicate = (Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283257721)));
                }
                else
                  goto label_26;
label_24:
                list = serviceData.Where<KeyValuePair<string, string>>(predicate).ToList<KeyValuePair<string, string>>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 3;
                continue;
label_26:
                predicate = func;
                goto label_24;
              case 13:
                if (parameters1.HeaderIds.Count == 0)
                {
                  num2 = 10;
                  continue;
                }
                goto case 4;
              case 14:
                if (FunctionMetadataImportExtension.FunctionConfigImportExtension.ueZX5N8HiMPZeKIHNi9s((object) parameters1) == 1)
                {
                  num2 = 13;
                  continue;
                }
                goto case 4;
              case 15:
                list.ForEach((Action<KeyValuePair<string, string>>) (r =>
                {
                  if (!parameters1.ServiceData.ContainsKey(r.Key))
                    return;
                  parameters1.ServiceData.Remove(r.Key);
                }));
                num2 = 6;
                continue;
              default:
                if (array.Length == 0)
                {
                  num2 = 8;
                  continue;
                }
                goto case 9;
            }
          }
label_4:
          num1 = 7;
          continue;
label_7:
          importHeaders = FunctionMetadataImportExtension.GetImportHeaders(this.actorContextService);
          num1 = 11;
        }
label_22:
        return;
label_16:
        return;
label_20:;
      }

      public void Publish(
        IEnumerable<Guid> headerUids,
        ICollection<DeployLogMessage> messages = null,
        string treeUid = null)
      {
        messages = messages ?? this.DeployLogMessages;
        ((ISecurityService) this.securityService).RunWithElevatedPrivilegies((System.Action) (() =>
        {
          int num1 = 1;
          IEnumerator<Guid> enumerator;
          while (true)
          {
            switch (num1)
            {
              case 1:
                enumerator = headerUids.GetEnumerator();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_29;
              default:
                goto label_2;
            }
          }
label_29:
          return;
label_2:
          try
          {
label_7:
            // ISSUE: reference to a compiler-generated method
            if (FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.GnJY3oZP3p9onigd9MVd((object) enumerator))
              goto label_5;
            else
              goto label_8;
label_4:
            Guid current;
            int num2;
            switch (num2)
            {
              case 1:
                return;
              case 2:
                break;
              case 3:
                goto label_7;
              default:
                try
                {
                  ((IFunctionMetadataItemManager) this.functionMetadataItemManager).Publish(current, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -489011707));
                  int num3 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
                    num3 = 1;
                  string str;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        str = EleWise.ELMA.SR.T((string) FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.PapsvbZPe5X9EXyHdulJ(993438473 ^ 993042115), (object) current);
                        num3 = 3;
                        continue;
                      case 2:
                        goto label_7;
                      case 3:
                        FunctionMetadataImportExtension.ImportLog.Info((object) str);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                        continue;
                      default:
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Info, str, false));
                        num3 = 2;
                        continue;
                    }
                  }
                }
                catch (Exception ex)
                {
                  int num4 = 3;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T((string) FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.PapsvbZPe5X9EXyHdulJ(-1872275253 >> 6 ^ -28857505), (object) current, FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.Tyrx5uZP1TmZRqEwYiUV((object) ex)), false));
                        num4 = 4;
                        continue;
                      case 2:
                        goto label_7;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.nmIY3VZPPK5AftC9BP1G((object) FunctionMetadataImportExtension.ImportLog, (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218565494), (object) current, (object) ex));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 0;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        if (!FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.bEOyoMZPNZ9JqJd12vKl((object) treeUid))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
                          continue;
                        }
                        goto label_7;
                      default:
                        messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, current, treeUid));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 2 : 2;
                        continue;
                    }
                  }
                }
            }
label_5:
            current = enumerator.Current;
            num2 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
            {
              num2 = 0;
              goto label_4;
            }
            else
              goto label_4;
label_8:
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 1 : 1;
            goto label_4;
          }
          finally
          {
            int num5;
            if (enumerator == null)
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
            else
              goto label_27;
label_25:
            switch (num5)
            {
              case 1:
              case 2:
            }
label_27:
            // ISSUE: reference to a compiler-generated method
            FunctionMetadataImportExtension.FunctionConfigImportExtension.\u003C\u003Ec__DisplayClass6_0.lu0DLOZPpbeNntTc8OTC((object) enumerator);
            num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
            {
              num5 = 2;
              goto label_25;
            }
            else
              goto label_25;
          }
        }));
      }

      private ICollection<DeployLogMessage> DeployLogMessages
      {
        get
        {
          object deployLogMessages;
          if (!((IActorContextService) this.actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811630888), out deployLogMessages))
            ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222030312), (object) (List<DeployLogMessage>) (deployLogMessages = (object) new List<DeployLogMessage>()));
          return (ICollection<DeployLogMessage>) deployLogMessages;
        }
      }

      /// <inheritdoc />
      public override void OnPreStartTest(PreStartTestImportParameters parameters)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.SetPromisedDependenciesKey((IDictionary<string, string>) parameters.ServiceData);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      /// <inheritdoc />
      public override void OnPrePublish(PrePublishParameters parameters)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.SetPromisedDependenciesKey(parameters.ServiceData);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      private void SetPromisedDependenciesKey(IDictionary<string, string> serviceData)
      {
        foreach (KeyValuePair<string, string> keyValuePair in serviceData.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459167613)))).ToList<KeyValuePair<string, string>>())
        {
          Guid result;
          if (Guid.TryParse(keyValuePair.Value, out result))
          {
            ((IActorContextService) this.actorContextService).Set(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138904566), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137526504), (object) keyValuePair.Value), (object) result);
            ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16718813), (object) string.Empty);
            serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538549550)] = string.Empty;
          }
        }
      }

      internal static void R9pFj88HS2bXgFaXmk4a() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool XLDYDv8HIeyGXAH79qC2() => FunctionMetadataImportExtension.FunctionConfigImportExtension.TpFonX8Hu1uQ1GivblVK == null;

      internal static FunctionMetadataImportExtension.FunctionConfigImportExtension n381wq8HViWuWpLn9b3h() => (FunctionMetadataImportExtension.FunctionConfigImportExtension) FunctionMetadataImportExtension.FunctionConfigImportExtension.TpFonX8Hu1uQ1GivblVK;

      internal static int ueZX5N8HiMPZeKIHNi9s([In] object obj0) => ((ImportExtensionParameters) obj0).ImportStep;

      internal static int PcZ8wm8HRF5JjQ7c3nVW([In] object obj0) => ((ICollection<Guid>) obj0).Count;

      internal static object lDo5qi8HqCcGfIvPap0t([In] object obj0) => (object) ((ImportExtensionParameters) obj0).TreeUid;
    }

    [Component(Order = -80)]
    private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
    {
      private readonly object actorContextService;
      private readonly ILazy<FunctionMetadataImportExtension.FunctionConfigImportExtension> functionConfigImportExtension;

      public ModelAssemblyBuilderHandler(
        IActorContextService actorContextService,
        ILazy<FunctionMetadataImportExtension.FunctionConfigImportExtension> functionConfigImportExtension)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.actorContextService = (object) actorContextService;
        this.functionConfigImportExtension = functionConfigImportExtension;
      }

      public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
      {
        ICollection<Guid> importHeaders = FunctionMetadataImportExtension.GetImportHeaders(this.actorContextService);
        if (importHeaders.Count <= 0)
          return;
        this.functionConfigImportExtension.Value.Publish((IEnumerable<Guid>) importHeaders);
      }

      public void DynamicModelAssemblyBuilt(IEnumerable<EntityMetadata> systemMetadata)
      {
      }

      public void AfterAll(
        IEnumerable<AbstractMetadata> publishMetadataList,
        IEnumerable<ScriptModule> scriptModules,
        IEnumerable<ScriptModule> clientScriptModules)
      {
      }
    }

    /// <summary>Обработка метаданных функций при импорте</summary>
    [Component]
    internal class FunctionMetadataImport : MetadataImport
    {
      internal static FunctionMetadataImportExtension.FunctionMetadataImport RYFoHB8HkbrPyjFWQ7g3;

      /// <inheritdoc />
      public override void CreateFakeChapter(
        NamedMetadata namedMd,
        BPMAppFakeManifest fakeManifest,
        BPMAppManifest manifest)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              if (fakeManifest == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 2:
              goto label_3;
            case 3:
              if (!(namedMd is FunctionMetadata functionMetadata))
              {
                num = 4;
                continue;
              }
              goto case 5;
            case 4:
              goto label_2;
            case 5:
              fakeManifest.GetOrCreateChapterByUid(FunctionExportConsts.ExportExtensionUid).GetOrCreateItemByUid(FunctionMetadataImportExtension.FunctionMetadataImport.VZK9yt8H2M9fG9qnbYDP((object) functionMetadata), (string) FunctionMetadataImportExtension.FunctionMetadataImport.aJobil8He48YblCMivd6((object) functionMetadata));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 2 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_5:
        return;
label_3:
        return;
label_2:
        return;
label_10:;
      }

      public FunctionMetadataImport()
      {
        FunctionMetadataImportExtension.FunctionMetadataImport.hWOCtR8HP6KOnlGLOICT();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static Guid VZK9yt8H2M9fG9qnbYDP([In] object obj0) => ((AbstractMetadata) obj0).Uid;

      internal static object aJobil8He48YblCMivd6([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

      internal static bool lcQ36f8HnwARwZW6Na3b() => FunctionMetadataImportExtension.FunctionMetadataImport.RYFoHB8HkbrPyjFWQ7g3 == null;

      internal static FunctionMetadataImportExtension.FunctionMetadataImport JRLgmA8HOfwPiFh18Bbe() => FunctionMetadataImportExtension.FunctionMetadataImport.RYFoHB8HkbrPyjFWQ7g3;

      internal static void hWOCtR8HP6KOnlGLOICT() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

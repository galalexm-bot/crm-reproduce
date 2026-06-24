// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ExtensionPoints.ComponentMetadataImportExtension
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
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.ExtensionPoints
{
  /// <summary>
  /// Точка расширения для обработки компонентов при импорте конфигурации
  /// </summary>
  [Component(Order = 20)]
  internal class ComponentMetadataImportExtension : 
    ComponentMetadataImportExtension<ComponentMetadata>
  {
    private static readonly ILogger ImportLog;
    private static ComponentMetadataImportExtension jEwQAQE9UG3TqO5cFvH6;

    /// <summary>Ctor</summary>
    /// <param name="componentMetadataItemManager">Интерфейс менеджера метаданных компонента</param>
    /// <param name="componentMetadataItemHeaderManager">Интерфейс менеджера заголовков метаданных компонента</param>
    /// <param name="metadataItemGroupUIManager">Менеджер метаданных групп КИ</param>
    /// <param name="dataClassMetadataImportExtension">Точка расширения для обработки датаклассов при импорте конфигурации</param>
    /// <param name="actorContextService">Сервис контекста исполнения в акторе</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public ComponentMetadataImportExtension(
      IComponentMetadataItemManager componentMetadataItemManager,
      IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
      IMetadataItemGroupUIManager metadataItemGroupUIManager,
      DataClassMetadataImportExtension dataClassMetadataImportExtension,
      IActorContextService actorContextService,
      IFeatureFlagService featureFlagService)
    {
      ComponentMetadataImportExtension.nO0T01E9zkKuesjybqhJ();
      // ISSUE: explicit constructor call
      base.\u002Ector(componentMetadataItemManager, componentMetadataItemHeaderManager, metadataItemGroupUIManager, dataClassMetadataImportExtension, actorContextService, featureFlagService);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ComponentMetadataImportExtension()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadataImportExtension.nO0T01E9zkKuesjybqhJ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadataImportExtension.ImportLog = (ILogger) ComponentMetadataImportExtension.MhKR8QEdFlvYYShdwRyR((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672423222));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void nO0T01E9zkKuesjybqhJ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool nBUrBdE9sLBVNeQFQuW6() => ComponentMetadataImportExtension.jEwQAQE9UG3TqO5cFvH6 == null;

    internal static ComponentMetadataImportExtension VZc1D7E9cvn9tZBTD7A1() => ComponentMetadataImportExtension.jEwQAQE9UG3TqO5cFvH6;

    internal static object MhKR8QEdFlvYYShdwRyR([In] object obj0) => (object) EleWise.ELMA.Logging.Logger.GetLogger((string) obj0);

    /// <summary>
    /// Расширение обработки метаданных компонентов после импорта
    /// </summary>
    [Component(Order = 2400)]
    private sealed class ComponentConfigImportExtension : ConfigImportExtension
    {
      private readonly object componentMetadataItemHeaderManager;
      private readonly object componentMetadataItemManager;
      private readonly object securityService;
      private readonly object actorContextService;
      private readonly object featureFlagService;
      private static object AyrMjE86xk1k3nvSQXTH;

      public ComponentConfigImportExtension(
        IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager,
        IComponentMetadataItemManager componentMetadataItemManager,
        ISecurityService securityService,
        IActorContextService actorContextService,
        IFeatureFlagService featureFlagService)
      {
        ComponentMetadataImportExtension.ComponentConfigImportExtension.eoyFLj86yEPqc3abyOoS();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              this.securityService = (object) securityService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 3;
              continue;
            case 3:
              this.actorContextService = (object) actorContextService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 5;
              continue;
            case 4:
              this.componentMetadataItemManager = (object) componentMetadataItemManager;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 2 : 1;
              continue;
            case 5:
              this.featureFlagService = (object) featureFlagService;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 1 : 1;
              continue;
            default:
              this.componentMetadataItemHeaderManager = (object) componentMetadataItemHeaderManager;
              num = 4;
              continue;
          }
        }
label_3:;
      }

      /// <inheritdoc />
      public override void OnPostReadPackets(PostReadPacketsParameters parameters)
      {
        int num1 = 1;
        while (true)
        {
          int num2 = num1;
          ICollection<Guid> importHeaders;
          IEnumerator<ComponentMetadataItemHeader> enumerator;
          Guid[] array;
          List<KeyValuePair<string, string>> list;
          PostReadPacketsParameters parameters1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
                continue;
              case 2:
                if (ComponentMetadataImportExtension.ComponentConfigImportExtension.LxT2Ra8696RqBB4eafxM((object) importHeaders) > 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 5 : 7;
                  continue;
                }
                goto case 6;
              case 3:
                goto label_30;
              case 4:
                if (ComponentMetadataImportExtension.ComponentConfigImportExtension.nlP3ko86J9xUrTBgRqkP((object) parameters1.HeaderIds) != 0)
                {
                  num2 = 17;
                  continue;
                }
                goto case 5;
              case 5:
                importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService) this.actorContextService);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 2 : 1;
                continue;
              case 6:
              case 17:
label_25:
                if (ComponentMetadataImportExtension.ComponentConfigImportExtension.Xtb1VI86MQW9jP4fTS69((object) parameters1) == 2)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 16 : 10;
                  continue;
                }
                goto label_39;
              case 7:
                this.SetPromisedDependenciesKey((IEnumerable<Guid>) importHeaders);
                num2 = 13;
                continue;
              case 8:
                if (ComponentMetadataImportExtension.ComponentConfigImportExtension.Xtb1VI86MQW9jP4fTS69((object) parameters1) == 1)
                {
                  num2 = 4;
                  continue;
                }
                goto case 6;
              case 9:
                enumerator = this.Publish((IEnumerable<Guid>) array, (ICollection<DeployLogMessage>) parameters1.Messages, (string) ComponentMetadataImportExtension.ComponentConfigImportExtension.dL6M0U86deB2cK1rbXFw((object) parameters1)).GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 3 : 1;
                continue;
              case 10:
                goto label_27;
              case 11:
                array = list.Select<KeyValuePair<string, string>, Guid>((Func<KeyValuePair<string, string>, Guid>) (record => new Guid(record.Value))).ToArray<Guid>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 12 : 4;
                continue;
              case 12:
                if (array.Length != 0)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 9;
                  continue;
                }
                goto label_43;
              case 13:
                enumerator = this.Publish((IEnumerable<Guid>) importHeaders, (ICollection<DeployLogMessage>) parameters1.Messages, (string) ComponentMetadataImportExtension.ComponentConfigImportExtension.dL6M0U86deB2cK1rbXFw((object) parameters1)).GetEnumerator();
                num2 = 14;
                continue;
              case 14:
                try
                {
label_7:
                  if (ComponentMetadataImportExtension.ComponentConfigImportExtension.oAI85h86r72dQZAVG0ae((object) enumerator))
                    goto label_9;
                  else
                    goto label_8;
label_6:
                  int num3;
                  switch (num3)
                  {
                    case 1:
                      goto label_9;
                    case 2:
                      goto label_7;
                    default:
                      goto label_25;
                  }
label_8:
                  num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
                  goto label_6;
label_9:
                  ComponentMetadataImportExtension.ComponentConfigImportExtension.Wpnhd186lZTHcULEVpnB((object) enumerator.Current);
                  num3 = 2;
                  goto label_6;
                }
                finally
                {
                  if (enumerator != null)
                  {
                    int num4 = 1;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
                      num4 = 1;
                    while (true)
                    {
                      switch (num4)
                      {
                        case 1:
                          ComponentMetadataImportExtension.ComponentConfigImportExtension.V3no4Y86gNkANfyT5FfG((object) enumerator);
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
                          continue;
                        default:
                          goto label_15;
                      }
                    }
                  }
label_15:;
                }
              case 15:
                goto label_46;
              case 16:
                Dictionary<string, string> serviceData = parameters1.ServiceData;
                // ISSUE: reference to a compiler-generated field
                Func<KeyValuePair<string, string>, bool> func = ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__6_0;
                Func<KeyValuePair<string, string>, bool> predicate;
                if (func == null)
                {
                  // ISSUE: reference to a compiler-generated field
                  ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec.\u003C\u003E9__6_0 = predicate = (Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(44884861 ^ 44750713)));
                }
                else
                  goto label_50;
label_48:
                list = serviceData.Where<KeyValuePair<string, string>>(predicate).ToList<KeyValuePair<string, string>>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 11;
                continue;
label_50:
                predicate = func;
                goto label_48;
              default:
                parameters1 = parameters;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 8 : 4;
                continue;
            }
          }
label_27:
          list.ForEach((Action<KeyValuePair<string, string>>) (r =>
          {
            if (!parameters1.ServiceData.ContainsKey(r.Key))
              return;
            parameters1.ServiceData.Remove(r.Key);
          }));
          num1 = 15;
          continue;
label_30:
          try
          {
label_34:
            if (ComponentMetadataImportExtension.ComponentConfigImportExtension.oAI85h86r72dQZAVG0ae((object) enumerator))
              goto label_32;
            else
              goto label_35;
label_31:
            int num5;
            switch (num5)
            {
              case 1:
                goto label_34;
              case 2:
                goto label_27;
            }
label_32:
            ComponentMetadataImportExtension.ComponentConfigImportExtension.Wpnhd186lZTHcULEVpnB((object) enumerator.Current);
            num5 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
            {
              num5 = 1;
              goto label_31;
            }
            else
              goto label_31;
label_35:
            num5 = 2;
            goto label_31;
          }
          finally
          {
            int num6;
            if (enumerator == null)
              num6 = 2;
            else
              goto label_40;
label_38:
            switch (num6)
            {
              case 1:
                break;
              default:
            }
label_40:
            enumerator.Dispose();
            num6 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
            {
              num6 = 0;
              goto label_38;
            }
            else
              goto label_38;
          }
        }
label_46:
        return;
label_43:
        return;
label_39:;
      }

      /// <inheritdoc />
      public override void OnPrePublish(PrePublishParameters parameters)
      {
        int num1 = 2;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            ICollection<Guid> importHeaders;
            switch (num2)
            {
              case 1:
                if (ComponentMetadataImportExtension.ComponentConfigImportExtension.LxT2Ra8696RqBB4eafxM((object) importHeaders) > 0)
                  break;
                goto label_8;
              case 2:
                importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService) this.actorContextService);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 1;
                continue;
              case 3:
                goto label_4;
              case 4:
                goto label_9;
              case 5:
                this.SetPromisedDependenciesKey(parameters.ServiceData);
                num2 = 3;
                continue;
            }
            this.SetPromisedDependenciesKey((IEnumerable<Guid>) importHeaders);
            num2 = 4;
          }
label_8:
          num1 = 5;
        }
label_4:
        return;
label_9:;
      }

      /// <inheritdoc />
      public override void OnPostPublish(PostPublishParameters parameters)
      {
        int num = 4;
        ICollection<DeployLogMessage> deployLogMessages;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_5;
            case 1:
              goto label_2;
            case 2:
              parameters.Messages.AddRange((IEnumerable<DeployLogMessage>) deployLogMessages);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
              continue;
            case 3:
              if (ComponentMetadataImportExtension.ComponentConfigImportExtension.ybD8ta865h6cfMheQpo8((object) deployLogMessages) <= 0)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                continue;
              }
              goto case 2;
            case 4:
              deployLogMessages = this.DeployLogMessages;
              num = 3;
              continue;
            default:
              goto label_8;
          }
        }
label_5:
        return;
label_2:
        return;
label_8:;
      }

      public IEnumerable<ComponentMetadataItemHeader> Publish(
        IEnumerable<Guid> headerUids,
        ICollection<DeployLogMessage> messages = null,
        string treeUid = null)
      {
        messages = messages ?? this.DeployLogMessages;
        List<ComponentMetadataItemHeader> result = new List<ComponentMetadataItemHeader>();
        ((ISecurityService) this.securityService).RunWithElevatedPrivilegies((System.Action) (() =>
        {
          int num1 = 1;
          IEnumerable<ComponentMetadataItemHeader> metadataItemHeaders;
          IEnumerator<ComponentMetadataItemHeader> enumerator;
          while (true)
          {
            switch (num1)
            {
              case 1:
                metadataItemHeaders = Enumerable.Empty<ComponentMetadataItemHeader>();
                num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
                continue;
              case 2:
                goto label_41;
              case 3:
                goto label_13;
              case 4:
label_3:
                enumerator = metadataItemHeaders.GetEnumerator();
                num1 = 3;
                continue;
              default:
                try
                {
                  metadataItemHeaders = ((IComponentMetadataItemHeaderManager) this.componentMetadataItemHeaderManager).SortByDependencies((IEnumerable<ComponentMetadataItemHeader>) ((IComponentMetadataItemHeaderManager) this.componentMetadataItemHeaderManager).FindByIdArray(headerUids.ToArray<Guid>()));
                  int num2 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
                    num2 = 0;
                  switch (num2)
                  {
                    default:
                      goto label_3;
                  }
                }
                catch (Exception ex)
                {
                  int num3 = 2;
                  string text;
                  while (true)
                  {
                    switch (num3)
                    {
                      case 1:
                        goto label_3;
                      case 2:
                        text = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272227675), (object) ex);
                        num3 = 3;
                        continue;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.vSaEcbZPENoeNOmC8CvO((object) ComponentMetadataImportExtension.ImportLog, (object) text);
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
                        continue;
                      default:
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, false));
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
            }
          }
label_41:
          return;
label_13:
          try
          {
label_17:
            // ISSUE: reference to a compiler-generated method
            if (ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.Q604pDZPuwRZPgyEMCDp((object) enumerator))
              goto label_15;
            else
              goto label_18;
label_14:
            ComponentMetadataItemHeader current;
            int num4;
            switch (num4)
            {
              case 0:
                return;
              case 1:
                break;
              case 2:
                goto label_17;
              case 3:
                try
                {
                  int num5;
                  if (!this.Publish(current, messages))
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                  else
                    goto label_25;
label_21:
                  string text;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.Wxu4ATZPQpsXOh3ElYI1((object) ComponentMetadataImportExtension.ImportLog, (object) text);
                        num5 = 5;
                        continue;
                      case 2:
                        goto label_25;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        text = EleWise.ELMA.SR.T((string) ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.jCrmvAZPfEagS2vmD3oY(-1876063057 ^ -1876183037), (object) current.Uid);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 1 : 1;
                        continue;
                      case 5:
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Info, text, false));
                        num5 = 3;
                        continue;
                      default:
                        goto label_17;
                    }
                  }
label_25:
                  result.Add(current);
                  num5 = 4;
                  goto label_21;
                }
                catch (Exception ex)
                {
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                    num6 = 0;
                  string text;
                  while (true)
                  {
                    switch (num6)
                    {
                      case 1:
                        // ISSUE: reference to a compiler-generated method
                        if (!ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.AM9IAVZPZkdJMBuxJJwi((object) treeUid))
                        {
                          num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 3;
                          continue;
                        }
                        goto label_17;
                      case 2:
                        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, text, false));
                        num6 = 4;
                        continue;
                      case 3:
                        // ISSUE: reference to a compiler-generated method
                        messages.Add(new DeployLogMessage(BPMAppItemImportStatus.Error, ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.gTsEXeZPCHI2tpo5Aehs((object) current), treeUid));
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 5 : 0;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.khBloLZP85gAIxtYhqb7((object) ComponentMetadataImportExtension.ImportLog, (object) text, (object) ex);
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
                        continue;
                      case 5:
                        goto label_17;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        text = EleWise.ELMA.SR.T((string) ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.jCrmvAZPfEagS2vmD3oY(2045296739 + 1688595713 ^ -561473468), (object) ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.gTsEXeZPCHI2tpo5Aehs((object) current), ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.bm548lZPvnyuCrMjM9E4((object) ex));
                        num6 = 2;
                        continue;
                    }
                  }
                }
              default:
                return;
            }
label_15:
            current = enumerator.Current;
            num4 = 1;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
            {
              num4 = 3;
              goto label_14;
            }
            else
              goto label_14;
label_18:
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            goto label_14;
          }
          finally
          {
            if (enumerator != null)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    goto label_43;
                  default:
                    // ISSUE: reference to a compiler-generated method
                    ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec__DisplayClass9_0.DlhO2YZPIyapH5rsNnw5((object) enumerator);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 1;
                    continue;
                }
              }
            }
label_43:;
          }
        }));
        return (IEnumerable<ComponentMetadataItemHeader>) result;
      }

      private bool Publish(
        ComponentMetadataItemHeader header,
        ICollection<DeployLogMessage> messages)
      {
        if (!(header.Draft?.Metadata is ComponentMetadata))
        {
          string str = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1668820183), (object) header.DisplayName);
          ComponentMetadataImportExtension.ImportLog.Error((object) str);
          messages.Add(new DeployLogMessage(DeployLogMessageType.Error, str, false));
          return false;
        }
        UIMetadataPublishResult metadataPublishResult = ((IComponentMetadataItemManager) this.componentMetadataItemManager).Publish(header.Uid, z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236203009), false);
        if (metadataPublishResult.Errors.Count == 0)
          return true;
        string str1 = EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1514831555), (object) header.DisplayName);
        ComponentMetadataImportExtension.ImportLog.Error((object) str1);
        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, str1, false));
        string message = ValidationErrorHelper.GetMessage(metadataPublishResult.Errors.ToArray());
        ComponentMetadataImportExtension.ImportLog.Error((object) message);
        messages.Add(new DeployLogMessage(DeployLogMessageType.Error, message, false));
        return false;
      }

      private ICollection<DeployLogMessage> DeployLogMessages
      {
        get
        {
          object deployLogMessages;
          if (!((IActorContextService) this.actorContextService).TryGet(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138827326), out deployLogMessages))
            ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2120768561), (object) (List<DeployLogMessage>) (deployLogMessages = (object) new List<DeployLogMessage>()));
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
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
        Guid result;
        // ISSUE: reference to a compiler-generated method
        if (!this.SetPromisedDependenciesKey(serviceData.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (m => m.Key.StartsWith(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629972698)))).ToList<KeyValuePair<string, string>>().Select<KeyValuePair<string, string>, Guid>((Func<KeyValuePair<string, string>, Guid>) (p => !Guid.TryParse(p.Value, out result) ? Guid.Empty : result)).Where<Guid>((Func<Guid, bool>) (u => ComponentMetadataImportExtension.ComponentConfigImportExtension.\u003C\u003Ec.jSW6p7ZPW6laZ080Elwi(u, Guid.Empty)))) || !this.SecondRuntimeEnabled)
          return;
        ((IActorContextService) this.actorContextService).Set(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978504650), (object) string.Empty);
        serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501442381)] = string.Empty;
      }

      private bool SetPromisedDependenciesKey(IEnumerable<Guid> importHeaders)
      {
        bool flag = false;
        foreach (Guid importHeader in importHeaders)
        {
          ((IActorContextService) this.actorContextService).Set(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146528047), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420805392), (object) importHeader), (object) importHeader);
          flag = true;
        }
        return flag;
      }

      /// <summary>Включен ли второй рантайм</summary>
      private bool SecondRuntimeEnabled => ((IFeatureFlagService) this.featureFlagService).Enabled((string) ComponentMetadataImportExtension.ComponentConfigImportExtension.UsFXtm86jM3ftqbQteMs(572119659 - -337058038 ^ 909139307), false);

      internal static void eoyFLj86yEPqc3abyOoS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool t3Sv17860PslyNV7FBZH() => ComponentMetadataImportExtension.ComponentConfigImportExtension.AyrMjE86xk1k3nvSQXTH == null;

      internal static ComponentMetadataImportExtension.ComponentConfigImportExtension Iqu8Dq86md8Aj6G2xfeQ() => (ComponentMetadataImportExtension.ComponentConfigImportExtension) ComponentMetadataImportExtension.ComponentConfigImportExtension.AyrMjE86xk1k3nvSQXTH;

      internal static int Xtb1VI86MQW9jP4fTS69([In] object obj0) => ((ImportExtensionParameters) obj0).ImportStep;

      internal static int nlP3ko86J9xUrTBgRqkP([In] object obj0) => ((List<long>) obj0).Count;

      internal static int LxT2Ra8696RqBB4eafxM([In] object obj0) => ((ICollection<Guid>) obj0).Count;

      internal static object dL6M0U86deB2cK1rbXFw([In] object obj0) => (object) ((ImportExtensionParameters) obj0).TreeUid;

      internal static void Wpnhd186lZTHcULEVpnB([In] object obj0) => ((Entity<long>) obj0).Refresh();

      internal static bool oAI85h86r72dQZAVG0ae([In] object obj0) => ((IEnumerator) obj0).MoveNext();

      internal static void V3no4Y86gNkANfyT5FfG([In] object obj0) => ((IDisposable) obj0).Dispose();

      internal static int ybD8ta865h6cfMheQpo8([In] object obj0) => ((ICollection<DeployLogMessage>) obj0).Count;

      internal static object UsFXtm86jM3ftqbQteMs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
    }

    [Component(Order = -70)]
    private sealed class ModelAssemblyBuilderHandler : IModelAssemblyBuilderHandler, IEventHandler
    {
      private readonly object actorContextService;
      private readonly ILazy<ComponentMetadataImportExtension.ComponentConfigImportExtension> componentConfigImportExtension;

      public ModelAssemblyBuilderHandler(
        IActorContextService actorContextService,
        ILazy<ComponentMetadataImportExtension.ComponentConfigImportExtension> componentConfigImportExtension)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        this.actorContextService = (object) actorContextService;
        this.componentConfigImportExtension = componentConfigImportExtension;
      }

      public void ConfigurationModelAssemblyBuilt(IEnumerable<AbstractMetadata> _)
      {
        ICollection<Guid> importHeaders = ComponentMetadataImportExtension<ComponentMetadata>.GetImportHeaders((IActorContextService) this.actorContextService);
        if (importHeaders.Count <= 0)
          return;
        this.componentConfigImportExtension.Value.Publish((IEnumerable<Guid>) importHeaders);
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

    /// <summary>Обработка метаданных компонентов при импорте</summary>
    [Component]
    internal class ComponentMetadataImport : MetadataImport
    {
      private static ComponentMetadataImportExtension.ComponentMetadataImport tRC0rs86s2tsaQXw1YZm;

      /// <inheritdoc />
      public override void CreateFakeChapter(
        NamedMetadata namedMd,
        BPMAppFakeManifest fakeManifest,
        BPMAppManifest manifest)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_8;
            case 1:
              if (!(namedMd is ComponentMetadata componentMetadata))
              {
                num = 3;
                continue;
              }
              goto case 4;
            case 2:
              if (fakeManifest != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            case 3:
              goto label_9;
            case 4:
              fakeManifest.GetOrCreateChapterByUid(ComponentExportConsts.ExportExtensionUid).GetOrCreateItemByUid(ComponentMetadataImportExtension.ComponentMetadataImport.IKDtjK8HF0W7PwslxLB5((object) componentMetadata), componentMetadata.DisplayName);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 0 : 0;
              continue;
            default:
              goto label_10;
          }
        }
label_8:
        return;
label_9:
        return;
label_10:
        return;
label_2:;
      }

      public ComponentMetadataImport()
      {
        ComponentMetadataImportExtension.ComponentMetadataImport.pChiWY8HBIqI9VUJtWGg();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static Guid IKDtjK8HF0W7PwslxLB5([In] object obj0) => ((AbstractMetadata) obj0).Uid;

      internal static bool YxrKNM86crY4VygIAVMa() => ComponentMetadataImportExtension.ComponentMetadataImport.tRC0rs86s2tsaQXw1YZm == null;

      internal static ComponentMetadataImportExtension.ComponentMetadataImport sJLbQD86zaHweU3QMax2() => ComponentMetadataImportExtension.ComponentMetadataImport.tRC0rs86s2tsaQXw1YZm;

      internal static void pChiWY8HBIqI9VUJtWGg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

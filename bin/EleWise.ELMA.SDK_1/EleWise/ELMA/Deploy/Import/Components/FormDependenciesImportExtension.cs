// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.Components.FormDependenciesImportExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import.Components
{
  /// <summary>Расширение для импорта зависимостей форм</summary>
  [Component]
  internal class FormDependenciesImportExtension : ConfigImportExtension
  {
    private readonly ISecurityService securityService;
    private readonly IEnumerable<IFormDependencyExtension> formDependencyExtensions;
    internal static FormDependenciesImportExtension mSGQdoEyYNVpcO40mg5b;

    /// <summary>Ctor</summary>
    /// <param name="securityService">Сервис проверки привилегий</param>
    /// <param name="formDependencyExtensions">Расширения работы с зависимостями формы</param>
    public FormDependenciesImportExtension(
      ISecurityService securityService,
      IEnumerable<IFormDependencyExtension> formDependencyExtensions)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.securityService = securityService;
      this.formDependencyExtensions = formDependencyExtensions;
    }

    /// <inheritdoc />
    public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        List<IFormDependencyData> dependencies;
        Dictionary<Guid, List<Guid>> forms;
        FormDependenciesImportExtension dependenciesImportExtension;
        PostCompleteTestImportParameters parameters1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              parameters1 = parameters;
              num2 = 3;
              continue;
            case 2:
              FormDependenciesImportExtension.luSiI1Eys40RTGENypPt((object) this.securityService, (object) (System.Action) (() =>
              {
                int num3 = 2;
                List<IFormDependencyData>.Enumerator enumerator;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_35;
                    case 1:
                      goto label_3;
                    case 2:
                      enumerator = dependencies.GetEnumerator();
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_31;
                  }
                }
label_35:
                return;
label_31:
                return;
label_3:
                try
                {
label_19:
                  if (enumerator.MoveNext())
                    goto label_6;
                  else
                    goto label_20;
label_5:
                  int num4;
                  while (true)
                  {
                    int num5;
                    IFormDependencyExtension dependencyExtension;
                    string dependencyObjectName;
                    IFormDependencyData dep;
                    switch (num4)
                    {
                      case 1:
                      case 11:
                        // ISSUE: reference to a compiler-generated method
                        dependencyObjectName = dependenciesImportExtension.GetDependencyObjectName((string) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.K2fbVA8tcbcB1OnmNiBt((object) dep), parameters1.ServiceData);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 2 : 2;
                        continue;
                      case 2:
                        List<TestImportMessages> messages = parameters1.Messages;
                        TestImportMessages testImportMessages;
                        // ISSUE: reference to a compiler-generated method
                        if (!FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.JHDojW8tzK9syjZ9ix92((object) dependencyObjectName))
                        {
                          // ISSUE: reference to a compiler-generated method
                          testImportMessages = new TestImportMessages(TestImportMessagesType.InfoLose, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876395719), (object) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.FasKJm8wF7kBh4Jpu2Ia((object) dep), (object) dependencyObjectName));
                        }
                        else
                        {
                          // ISSUE: reference to a compiler-generated method
                          // ISSUE: reference to a compiler-generated method
                          testImportMessages = new TestImportMessages(TestImportMessagesType.InfoLose, EleWise.ELMA.SR.T((string) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.NP5Rji8wBGdXpmJl4tIZ(-710283084 ^ -537863435 ^ 173858745), (object) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.FasKJm8wF7kBh4Jpu2Ia((object) dep)));
                        }
                        messages.Add(testImportMessages);
                        num4 = 7;
                        continue;
                      case 3:
                        dep = enumerator.Current;
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
                        continue;
                      case 4:
                        // ISSUE: reference to a compiler-generated method
                        if (!FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.obiN358tsvPxHNnDLhvg((object) dependencyExtension, dep.UsesObjectUid, dep.UsesObjectFormUid))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
                          continue;
                        }
                        goto label_19;
                      case 5:
                        // ISSUE: reference to a compiler-generated method
                        if (FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.KtkM018tUs7UWGWbMI3v((object) dep) != FormDependencyDataType.Default)
                        {
                          num4 = 14;
                          continue;
                        }
                        goto label_19;
                      case 6:
                      case 12:
                        dependencyExtension = dependenciesImportExtension.formDependencyExtensions.FirstOrDefault<IFormDependencyExtension>((Func<IFormDependencyExtension, bool>) (q => q.CheckType(dep.UsesObjectUid)));
                        num5 = 9;
                        break;
                      case 7:
                        goto label_19;
                      case 8:
                        // ISSUE: reference to a compiler-generated method
                        if (!forms.ContainsKey(FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.Veil8m8tYM8LV8kc7uKv((object) dep)))
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 2 : 6;
                          continue;
                        }
                        goto case 10;
                      case 9:
                        if (dependencyExtension == null)
                        {
                          num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 11 : 11;
                          continue;
                        }
                        goto case 4;
                      case 10:
                        // ISSUE: reference to a compiler-generated method
                        if (!forms[FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.Veil8m8tYM8LV8kc7uKv((object) dep)].Contains(dep.UsesObjectFormUid))
                        {
                          num4 = 12;
                          continue;
                        }
                        goto label_19;
                      case 13:
                        goto label_27;
                      case 14:
                        // ISSUE: reference to a compiler-generated method
                        if (FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.KtkM018tUs7UWGWbMI3v((object) dep) != FormDependencyDataType.DefaultInherit)
                        {
                          num4 = 8;
                          continue;
                        }
                        goto label_19;
                      case 15:
                        goto label_6;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        // ISSUE: reference to a compiler-generated method
                        if (!FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.hnegTf8tLwNrnihPtKKe(FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.H3W3nc8tjwv24IxFmp2p((object) dep), FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass3_0.Veil8m8tYM8LV8kc7uKv((object) dep)))
                        {
                          num5 = 5;
                          break;
                        }
                        goto label_19;
                    }
                    num4 = num5;
                  }
label_27:
                  return;
label_6:
                  num4 = 3;
                  goto label_5;
label_20:
                  num4 = 13;
                  goto label_5;
                }
                finally
                {
                  enumerator.Dispose();
                  int num6 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
                    num6 = 0;
                  switch (num6)
                  {
                    default:
                  }
                }
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            case 3:
              if (parameters1 != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 6;
                continue;
              }
              goto label_18;
            case 4:
              dependenciesImportExtension = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
              continue;
            case 5:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 4;
              continue;
            case 6:
              if (parameters1.ServiceData != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 5 : 8;
                continue;
              }
              goto label_17;
            case 7:
              goto label_13;
            case 8:
              if (parameters1.Messages == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 9 : 9;
                continue;
              }
              goto label_9;
            case 9:
              goto label_3;
            default:
              goto label_19;
          }
        }
label_9:
        forms = this.ReadObjectForms(parameters1.ServiceData);
        num1 = 7;
        continue;
label_13:
        dependencies = this.ReadDependencies(parameters1.ServiceData);
        num1 = 2;
      }
label_8:
      return;
label_3:
      return;
label_19:
      return;
label_17:
      return;
label_18:;
    }

    /// <inheritdoc />
    public override void OnPostCompleteImport(PostCompleteImportParameters parameters)
    {
      int num1 = 10;
      while (true)
      {
        int num2 = num1;
        FormDependenciesImportExtension dependenciesImportExtension;
        PostCompleteImportParameters parameters1;
        bool hasMessages;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_8;
            case 1:
              parameters1 = parameters;
              num2 = 7;
              continue;
            case 2:
              if (hasMessages)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 11 : 0;
                continue;
              }
              goto label_3;
            case 3:
              goto label_7;
            case 4:
              goto label_15;
            case 5:
              if (parameters1.ServiceData == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 2 : 6;
                continue;
              }
              goto case 8;
            case 6:
              goto label_22;
            case 7:
              if (parameters1 != null)
              {
                num2 = 5;
                continue;
              }
              goto label_21;
            case 8:
              if (parameters1.Messages == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 3;
                continue;
              }
              hasMessages = false;
              num2 = 4;
              continue;
            case 9:
              dependenciesImportExtension = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 1 : 1;
              continue;
            case 10:
              num2 = 9;
              continue;
            case 11:
              parameters1.Messages.Add(new DeployLogMessage(DeployLogMessageType.Empty, "", false));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
              continue;
            default:
              goto label_20;
          }
        }
label_15:
        this.securityService.RunWithElevatedPrivilegies((System.Action) (() =>
        {
          int num3 = 3;
          List<Guid> guidList;
          List<IFormDependencyData>.Enumerator enumerator;
          while (true)
          {
            switch (num3)
            {
              case 0:
                goto label_34;
              case 1:
                goto label_4;
              case 2:
                enumerator = dependenciesImportExtension.ReadDependencies(parameters1.ServiceData).GetEnumerator();
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
                continue;
              case 3:
                guidList = new List<Guid>();
                num3 = 2;
                continue;
              default:
                goto label_30;
            }
          }
label_34:
          return;
label_30:
          return;
label_4:
          try
          {
label_22:
            if (enumerator.MoveNext())
              goto label_11;
            else
              goto label_23;
label_5:
            int num4;
            while (true)
            {
              IFormDependencyExtension dependencyExtension;
              Guid dependObjectUid;
              Guid guid;
              IFormDependencyData dep;
              switch (num4)
              {
                case 1:
                  // ISSUE: reference to a compiler-generated method
                  dependencyExtension = dependenciesImportExtension.formDependencyExtensions.FirstOrDefault<IFormDependencyExtension>((Func<IFormDependencyExtension, bool>) (q => FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_1.c3blHf8wq2QorFsDkKm3((object) q, dep.DependObjectUid)));
                  num4 = 9;
                  continue;
                case 2:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  parameters1.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.HCy0mm8wZYHKQBP6lGxH(FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.R9bvlR8wI9Mlakb2H6Zf(1218962250 ^ 1218581968), (object) dependObjectUid), false));
                  num4 = 17;
                  continue;
                case 3:
                  // ISSUE: reference to a compiler-generated method
                  if (FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.HsfZ9a8wC0PM6OB5LPZk((object) dep) == PageMetadata.TypeUid)
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 12 : 2;
                    continue;
                  }
                  goto case 4;
                case 4:
                  // ISSUE: reference to a compiler-generated method
                  // ISSUE: reference to a compiler-generated method
                  if (!FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.NyTdyr8wvogUWB2SFBAi(FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.HsfZ9a8wC0PM6OB5LPZk((object) dep), PortletMetadata.TypeUid))
                  {
                    num4 = 13;
                    continue;
                  }
                  goto case 12;
                case 5:
                  guidList.Add(dependObjectUid);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 4 : 6;
                  continue;
                case 6:
                case 10:
                  goto label_22;
                case 7:
                  hasMessages = true;
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 0 : 10;
                  continue;
                case 8:
                  dep = enumerator.Current;
                  num4 = 3;
                  continue;
                case 9:
                  if (dependencyExtension == null)
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 0 : 0;
                    continue;
                  }
                  goto case 16;
                case 11:
                  goto label_16;
                case 12:
                  // ISSUE: reference to a compiler-generated method
                  guid = FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.tgVAew8w8KRl9tSC0cx2((object) dep);
                  break;
                case 13:
                  // ISSUE: reference to a compiler-generated method
                  guid = FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.HsfZ9a8wC0PM6OB5LPZk((object) dep);
                  break;
                case 14:
                  if (!guidList.Contains(dependObjectUid))
                  {
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
                    continue;
                  }
                  goto label_22;
                case 15:
                  goto label_11;
                case 16:
                  // ISSUE: reference to a compiler-generated method
                  FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.dIHtAx8wuGutZ25aTBHV((object) dependencyExtension, dependObjectUid);
                  num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 0;
                  continue;
                case 17:
                  hasMessages = true;
                  num4 = 5;
                  continue;
                default:
                  // ISSUE: reference to a compiler-generated method
                  parameters1.Messages.Add(new DeployLogMessage(DeployLogMessageType.Info, (string) FormDependenciesImportExtension.\u003C\u003Ec__DisplayClass4_0.HCy0mm8wZYHKQBP6lGxH((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -575843870), (object) dependObjectUid), false));
                  num4 = 7;
                  continue;
              }
              dependObjectUid = guid;
              num4 = 14;
            }
label_16:
            return;
label_11:
            num4 = 8;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
            {
              num4 = 6;
              goto label_5;
            }
            else
              goto label_5;
label_23:
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 7 : 11;
            goto label_5;
          }
          finally
          {
            enumerator.Dispose();
            int num5 = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
              num5 = 0;
            switch (num5)
            {
              default:
            }
          }
        }));
        num1 = 2;
      }
label_8:
      return;
label_7:
      return;
label_22:
      return;
label_20:
      return;
label_3:
      return;
label_21:;
    }

    private string GetDependencyObjectName(
      string dependency,
      Dictionary<string, string> serviceData)
    {
      string key = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333739112), new string[2]
      {
        ExportFormDependencyHelper.FormDependencyDisplayName,
        dependency
      });
      return !serviceData.ContainsKey(key) ? string.Empty : serviceData[key];
    }

    private List<IFormDependencyData> ReadDependencies(Dictionary<string, string> serviceData)
    {
      List<IFormDependencyData> formDependencyDataList = new List<IFormDependencyData>();
      string keyPrefix = ExportFormDependencyHelper.FormDependencyPrefix + FormDependencyHelper.KeySplitter;
      foreach (KeyValuePair<string, string> keyValuePair in serviceData.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (p => p.Key.StartsWith(keyPrefix))))
      {
        string[] strArray1 = keyValuePair.Key.Replace(keyPrefix, "").Split(new string[1]
        {
          FormDependencyHelper.KeySplitter
        }, StringSplitOptions.None);
        string[] strArray2 = keyValuePair.Value.Split(new string[1]
        {
          FormDependencyHelper.KeySplitter
        }, StringSplitOptions.None);
        Guid result1;
        Guid result2;
        Guid result3;
        Guid result4;
        FormDependencyDataType result5;
        if (Guid.TryParse(strArray1[0], out result1) && Guid.TryParse(strArray1[1], out result2) && Guid.TryParse(strArray2[0], out result3) && Guid.TryParse(strArray2[1], out result4) && Enum.TryParse<FormDependencyDataType>(strArray1[2], out result5))
          formDependencyDataList.Add((IFormDependencyData) new FormDependencyData(result1, result2, result3, result4, result5));
      }
      return formDependencyDataList;
    }

    private Dictionary<Guid, List<Guid>> ReadObjectForms(Dictionary<string, string> serviceData)
    {
      Dictionary<Guid, List<Guid>> dictionary = new Dictionary<Guid, List<Guid>>();
      string keyPrefix = ExportFormDependencyHelper.ObjectFormsPrefix + FormDependencyHelper.KeySplitter;
      foreach (KeyValuePair<string, string> keyValuePair in serviceData.Where<KeyValuePair<string, string>>((Func<KeyValuePair<string, string>, bool>) (q => q.Key.StartsWith(keyPrefix))))
      {
        Guid result1;
        if (Guid.TryParse(keyValuePair.Key.Replace(keyPrefix, ""), out result1))
        {
          string str = keyValuePair.Value;
          string[] separator = new string[1]
          {
            z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675749631)
          };
          foreach (string input in str.Split(separator, StringSplitOptions.None))
          {
            Guid result2;
            if (Guid.TryParse(input, out result2))
            {
              if (dictionary.ContainsKey(result1))
                dictionary[result1].Add(result2);
              else
                dictionary.Add(result1, new List<Guid>()
                {
                  result2
                });
            }
          }
        }
      }
      return dictionary;
    }

    internal static void luSiI1Eys40RTGENypPt([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static bool di5ysmEyLW89b2mRpPTs() => FormDependenciesImportExtension.mSGQdoEyYNVpcO40mg5b == null;

    internal static FormDependenciesImportExtension EcnLD3EyUFTt4YmpGkR4() => FormDependenciesImportExtension.mSGQdoEyYNVpcO40mg5b;
  }
}

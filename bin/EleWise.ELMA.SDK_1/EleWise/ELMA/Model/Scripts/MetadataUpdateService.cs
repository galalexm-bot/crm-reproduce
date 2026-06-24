// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.MetadataUpdateService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <inheritdoc />
  [Service]
  internal sealed class MetadataUpdateService : IMetadataUpdateService
  {
    private readonly IEnumerable<IMetadataUpdateDataHandler> metadataUpdateDataHandlers;
    private readonly IEnumerable<IMetadataUpdateHandler> metadataUpdateHandlers;
    private readonly IFeatureFlagService featureFlagService;
    internal static MetadataUpdateService y5xxxIbVT9afGGcbpG4g;

    /// <summary>Ctor</summary>
    /// <param name="metadataUpdateDataHandlers">Обработчики получения данных для обновления метаданных на новый рантайм</param>
    /// <param name="metadataUpdateHandlers">Обработчики обновления метаданных на новый рантайм</param>
    /// <param name="featureFlagService">Сервис флагов функций</param>
    public MetadataUpdateService(
      IEnumerable<IMetadataUpdateDataHandler> metadataUpdateDataHandlers,
      IEnumerable<IMetadataUpdateHandler> metadataUpdateHandlers,
      IFeatureFlagService featureFlagService)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.metadataUpdateDataHandlers = metadataUpdateDataHandlers;
      this.metadataUpdateHandlers = metadataUpdateHandlers;
      this.featureFlagService = featureFlagService;
    }

    /// <inheritdoc />
    public IMetadataUpdateResult Update(IMetadata metadata) => this.Update(metadata, Guid.Empty);

    /// <inheritdoc />
    public IMetadataUpdateResult Update(IMetadata metadata, Guid formUid)
    {
      int num1 = 6;
      List<Guid> guidList;
      MetadataUpdateResult updateResult;
      List<IMetadataUpdateHandler>.Enumerator enumerator1;
      IMetadata metadata1;
      while (true)
      {
        int num2 = num1;
        List<IMetadataUpdateDataHandler>.Enumerator enumerator2;
        List<IMetadataUpdateHandler> list1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_30;
            case 2:
              goto label_6;
            case 3:
              goto label_13;
            case 4:
              goto label_3;
            case 5:
              goto label_5;
            case 6:
              num2 = 5;
              continue;
            case 7:
label_29:
              enumerator1 = list1.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 1;
              continue;
            case 8:
              if (MetadataUpdateService.cCwNL8bVOiZBmXH3Bm1M((object) this.featureFlagService, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 1418395776), false))
              {
                // ISSUE: reference to a compiler-generated method
                list1 = this.metadataUpdateHandlers.Where<IMetadataUpdateHandler>((Func<IMetadataUpdateHandler, bool>) (handler => MetadataUpdateService.\u003C\u003Ec__DisplayClass5_0.Eqxth8CPNKrD529PovdW((object) handler, (object) metadata1))).ToList<IMetadataUpdateHandler>();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 4 : 9;
                continue;
              }
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 2 : 2;
              continue;
            case 9:
              if (MetadataUpdateService.hBcpLYbVPjgpxkP5g5ST((object) list1) != 0)
              {
                // ISSUE: reference to a compiler-generated method
                List<IMetadataUpdateDataHandler> list2 = this.metadataUpdateDataHandlers.Where<IMetadataUpdateDataHandler>((Func<IMetadataUpdateDataHandler, bool>) (handler => MetadataUpdateService.\u003C\u003Ec__DisplayClass5_0.WVvTiFCP3xOxAG42svVV((object) handler, (object) metadata1))).ToList<IMetadataUpdateDataHandler>();
                guidList = new List<Guid>();
                updateResult = new MetadataUpdateResult(ClassSerializationHelper.CloneObjectByXml<IMetadata>(metadata1), (IList<ScriptModule>) new List<ScriptModule>(), (IList<IEntity>) new List<IEntity>());
                enumerator2 = list2.GetEnumerator();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              num2 = 4;
              continue;
            default:
              try
              {
label_17:
                if (enumerator2.MoveNext())
                  goto label_23;
                else
                  goto label_18;
label_16:
                IMetadataUpdateDataHandler current;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                    case 2:
                      guidList.Add(formUid);
                      num3 = 7;
                      continue;
                    case 3:
                      guidList.AddRange(current.GetFormUids((IMetadataUpdateResult) updateResult));
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                      continue;
                    case 4:
                      updateResult.ScriptModules.AddRange<ScriptModule>(current.GetScriptModules((IMetadataUpdateResult) updateResult));
                      num3 = 5;
                      continue;
                    case 5:
                      if (!MetadataUpdateService.InSpGUbV1YVEMd2jOvto(formUid, Guid.Empty))
                      {
                        num3 = 2;
                        continue;
                      }
                      goto case 3;
                    case 6:
                      goto label_29;
                    case 8:
                      goto label_23;
                    default:
                      goto label_17;
                  }
                }
label_18:
                num3 = 6;
                goto label_16;
label_23:
                current = enumerator2.Current;
                num3 = 4;
                goto label_16;
              }
              finally
              {
                enumerator2.Dispose();
                int num4 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                  num4 = 0;
                switch (num4)
                {
                  default:
                }
              }
          }
        }
label_5:
        metadata1 = metadata;
        num1 = 8;
      }
label_3:
      throw new Exception(EleWise.ELMA.SR.T((string) MetadataUpdateService.NiN6DobV2mUTCNQVPCrL(~1767720452 ^ -1767898305), (object) metadata1.GetType()));
label_6:
      throw new MetadataException((string) MetadataUpdateService.rk5mPSbVePrsnhnQtUCZ(MetadataUpdateService.NiN6DobV2mUTCNQVPCrL(1242972401 >> 4 ^ 77848205)));
label_13:
      return (IMetadataUpdateResult) updateResult;
label_30:
      try
      {
label_47:
        if (enumerator1.MoveNext())
          goto label_42;
        else
          goto label_48;
label_31:
        List<Guid>.Enumerator enumerator3;
        IMetadataUpdateHandler current1;
        int num5;
        while (true)
        {
          switch (num5)
          {
            case 1:
label_46:
              MetadataUpdateService.oamxUYbV3n8AlyBLHRPk((object) current1, (object) updateResult);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 3 : 6;
              continue;
            case 2:
              goto label_13;
            case 3:
              try
              {
label_36:
                if (enumerator3.MoveNext())
                  goto label_34;
                else
                  goto label_37;
label_33:
                Guid current2;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_36;
                    case 2:
                      goto label_46;
                    case 3:
                      current1.UpdateForm((IMetadataUpdateResult) updateResult, current2);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 1;
                      continue;
                    default:
                      goto label_34;
                  }
                }
label_34:
                current2 = enumerator3.Current;
                num6 = 3;
                goto label_33;
label_37:
                num6 = 2;
                goto label_33;
              }
              finally
              {
                enumerator3.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 4:
              enumerator3 = guidList.GetEnumerator();
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 3;
              continue;
            case 5:
              goto label_42;
            case 6:
              goto label_47;
            default:
              MetadataUpdateService.sBoeWqbVN6vXhNJlHCYu((object) current1, (object) updateResult);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 4;
              continue;
          }
        }
label_42:
        current1 = enumerator1.Current;
        num5 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        {
          num5 = 0;
          goto label_31;
        }
        else
          goto label_31;
label_48:
        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 1 : 2;
        goto label_31;
      }
      finally
      {
        enumerator1.Dispose();
        int num8 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
          num8 = 0;
        switch (num8)
        {
          default:
        }
      }
    }

    internal static bool GcDa4gbVkneMdqNAkUIo() => MetadataUpdateService.y5xxxIbVT9afGGcbpG4g == null;

    internal static MetadataUpdateService YEsGUibVnMYg6eJxsgqL() => MetadataUpdateService.y5xxxIbVT9afGGcbpG4g;

    internal static bool cCwNL8bVOiZBmXH3Bm1M([In] object obj0, [In] object obj1, bool defaultEnabled) => ((IFeatureFlagService) obj0).Enabled((string) obj1, defaultEnabled);

    internal static object NiN6DobV2mUTCNQVPCrL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object rk5mPSbVePrsnhnQtUCZ([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static int hBcpLYbVPjgpxkP5g5ST([In] object obj0) => ((List<IMetadataUpdateHandler>) obj0).Count;

    internal static bool InSpGUbV1YVEMd2jOvto([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static void sBoeWqbVN6vXhNJlHCYu([In] object obj0, [In] object obj1) => ((IMetadataUpdateHandler) obj0).UpdateMetadata((IMetadataUpdateResult) obj1);

    internal static void oamxUYbV3n8AlyBLHRPk([In] object obj0, [In] object obj1) => ((IMetadataUpdateHandler) obj0).UpdateScriptModules((IMetadataUpdateResult) obj1);
  }
}

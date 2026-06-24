// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Import.ScriptModuleSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Deploy.Import
{
  /// <summary>Действия, выполняемые при сохранении модуля сценариев</summary>
  public class ScriptModuleSaveActions : EntityImportSaveActions
  {
    private readonly string tagDoNotTouch;
    /// <summary>UID типа сущности ScriptModule</summary>
    public static readonly Guid Uid;
    internal static ScriptModuleSaveActions jlCx1MEmyhmyZXsZQAeh;

    public override bool IsSupported(Guid typeGuid) => typeGuid == ScriptModuleSaveActions.Uid;

    private string CutOldScript(string script)
    {
      int num1 = 4;
      string str;
      int num2;
      int num3;
      while (true)
      {
        int num4 = num1;
        int num5;
        int num6;
        while (true)
        {
          switch (num4)
          {
            case 1:
              if (num5 != -1)
              {
                num4 = 6;
                continue;
              }
              goto label_12;
            case 2:
              if (num6 != -1)
              {
                num4 = 10;
                continue;
              }
              goto label_12;
            case 3:
              num3 = ScriptModuleSaveActions.KUdbajEmdf1AugnpQijk((object) str, ScriptModuleSaveActions.z34x8oEm9mdL4YhsbNY9(1642859704 ^ 1642637096), StringComparison.CurrentCulture);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
              continue;
            case 4:
              str = script;
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 3;
              continue;
            case 5:
              if (num3 >= num2)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 13 : 13;
                continue;
              }
              goto label_11;
            case 6:
              if (num3 == num6)
              {
                num4 = 12;
                continue;
              }
              goto label_12;
            case 7:
              num5 = ScriptModuleSaveActions.M3UltuEmleXLw02wIO6T((object) str, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917256330 ^ 1917036860), StringComparison.CurrentCulture);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 6 : 8;
              continue;
            case 8:
              if (num3 != -1)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 1 : 2;
                continue;
              }
              goto label_12;
            case 9:
              num2 = str.IndexOf((string) ScriptModuleSaveActions.z34x8oEm9mdL4YhsbNY9(-1334993905 ^ -1335281735), StringComparison.CurrentCulture);
              num4 = 7;
              continue;
            case 10:
              if (num2 != -1)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
                continue;
              }
              goto label_12;
            case 11:
              goto label_11;
            case 12:
              if (num2 == num5)
              {
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 5;
                continue;
              }
              goto label_12;
            case 13:
              goto label_12;
            default:
              goto label_14;
          }
        }
label_14:
        num6 = ScriptModuleSaveActions.M3UltuEmleXLw02wIO6T((object) str, ScriptModuleSaveActions.z34x8oEm9mdL4YhsbNY9(1642859704 ^ 1642637096), StringComparison.CurrentCulture);
        num1 = 9;
      }
label_11:
      return (string) ScriptModuleSaveActions.HFUhVREmrvSU49FUCXwQ((object) str, num3, num2 - num3 + ((string) ScriptModuleSaveActions.z34x8oEm9mdL4YhsbNY9(1925118608 << 2 ^ -889241098)).Length);
label_12:
      return str;
    }

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      Guid result = Guid.Empty;
      if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825364116)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(222162814 ^ 222134508)] != null)
        Guid.TryParse(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647901272)].ToString(), out result);
      if (result != Guid.Empty && propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137415964)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1409006048)] != null)
      {
        string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459339015) + (object) result;
        if (!data.ServiceData.ContainsKey(key))
          return true;
        ScriptModule scriptModule = Locator.GetServiceNotNull<ScriptModuleManager>().LoadOrNull(result);
        if (scriptModule == null || scriptModule.SourceCode == null)
          return true;
        string str1 = this.CutOldScript(scriptModule.SourceCode);
        string str2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824087961), (object) str1.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195610959), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787168915), (object) Environment.NewLine)));
        propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883387166)] = (object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881885840), (object) this.CutOldScript(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146610675)].ToString()), (object) str2, (object) this.tagDoNotTouch, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868044836), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138237367));
      }
      return true;
    }

    public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
    {
      if (entity is ScriptModule scriptModule && scriptModule.LocalReferences != null)
      {
        foreach (AssemblyReference localReference in scriptModule.LocalReferences)
        {
          string input;
          Guid result;
          if (serviceData.TryGetValue(localReference.Uid.ToString(), out input) && Guid.TryParse(input, out result))
            localReference.Uid = result;
        }
      }
      base.ExecSaveActions(entity, serviceData);
    }

    public ScriptModuleSaveActions()
    {
      ScriptModuleSaveActions.k14OMoEmgAomrqFKmRAK();
      this.tagDoNotTouch = EleWise.ELMA.SR.T((string) ScriptModuleSaveActions.z34x8oEm9mdL4YhsbNY9(516838154 ^ 516620096));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptModuleSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptModuleSaveActions.Uid = ScriptModuleSaveActions.jMWITTEm5kFQ9wPfdx0q((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751415008));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 0 : 0;
            continue;
          case 2:
            ScriptModuleSaveActions.k14OMoEmgAomrqFKmRAK();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool MCSlFSEmMu22h01V0M7v() => ScriptModuleSaveActions.jlCx1MEmyhmyZXsZQAeh == null;

    internal static ScriptModuleSaveActions RcNuGXEmJcyBg43IP8Hm() => ScriptModuleSaveActions.jlCx1MEmyhmyZXsZQAeh;

    internal static object z34x8oEm9mdL4YhsbNY9(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static int KUdbajEmdf1AugnpQijk([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).IndexOf((string) obj1, obj2);

    internal static int M3UltuEmleXLw02wIO6T([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).LastIndexOf((string) obj1, obj2);

    internal static object HFUhVREmrvSU49FUCXwQ([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((string) obj0).Remove(obj1, obj2);

    internal static void k14OMoEmgAomrqFKmRAK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Guid jMWITTEm5kFQ9wPfdx0q([In] object obj0) => Guid.Parse((string) obj0);
  }
}

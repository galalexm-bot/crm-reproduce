// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Deploy.Import.ScriptModuleImportSaveActions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Model.Scripts.Deploy.Import
{
  /// <summary>
  /// Действия для импорта заголовка пользовательского расширения
  /// </summary>
  public class ScriptModuleImportSaveActions : EntityImportSaveActions
  {
    public static readonly Guid UID;
    internal static ScriptModuleImportSaveActions WOM9iWbXnrL1jVXA22tF;

    public override bool IsSupported(Guid typeGuid) => ScriptModuleImportSaveActions.biiUGSbXeZbZECT4I8Xb(typeGuid, ScriptModuleImportSaveActions.UID);

    public override bool CanBeSaved(
      Dictionary<string, object> propValues,
      ImportEntityCanBeSavedData data)
    {
      if (propValues == null)
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413583273))));
        return false;
      }
      Locator.GetServiceNotNull<GlobalScriptModuleHeaderManager>();
      if (string.IsNullOrWhiteSpace(propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488886261)) ? propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576138140)].ToString() : (string) null))
      {
        data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-244066886 - -48452443 ^ -195585241))));
        return false;
      }
      Guid result = Guid.Empty;
      if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576141258)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(1819636893 << 3 ^ 1672203130)] != null)
        Guid.TryParse(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(864270449 << 6 ^ -521243694)].ToString(), out result);
      if (!(result == Guid.Empty))
        return true;
      data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951469270))));
      return false;
    }

    public override List<TestImportMessages> ExecPreSaveActions(
      IEntity entity,
      ImportEntityPreSaveData data)
    {
      if (entity is IGlobalScriptModuleHeader)
        return new List<TestImportMessages>();
      EleWise.ELMA.Logging.Logger.Log.Error((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1917998801 >> 2 ^ 479614956));
      return new List<TestImportMessages>()
      {
        new TestImportMessages(TestImportMessagesType.Error, EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021556857)))
      };
    }

    /// <summary>
    /// 
    /// </summary>
    public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        XmlReader reader;
        Guid result1;
        string title;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_35;
            case 1:
              if (data.ConfigImportSettings == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
              if (ScriptModuleImportSaveActions.sR5IjWbX0gx0AjubcsUM(result1, new Guid()))
              {
                num2 = 7;
                continue;
              }
              goto label_31;
            case 3:
            case 10:
            case 25:
              ScriptModuleImportSaveActions.ONLecUbXAIwIfVnpXuo1((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 2 : 26;
              continue;
            case 4:
              ScriptModuleImportSaveActions.rqJMGEbX1QC6DZ0OMFJi((object) reader);
              num2 = 24;
              continue;
            case 5:
              reader = data.Reader;
              num2 = 22;
              continue;
            case 6:
            case 8:
            case 9:
            case 21:
              if (ScriptModuleImportSaveActions.PeI5ILbXNv5KydoaxNkT((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 28 : 23;
                continue;
              }
              goto case 3;
            case 7:
              ((BPMAppFakeManifest) ScriptModuleImportSaveActions.uhxsZtbXmslnQUxHlVmt((object) data.ConfigImportSettings)).GetOrCreateChapterByUid(ScriptModuleExportConsts.ExportExtensionUid).GetOrCreateItemByUid(result1, title);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 10 : 17;
              continue;
            case 11:
              if (!ScriptModuleImportSaveActions.PeI5ILbXNv5KydoaxNkT((object) reader))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 9 : 0;
                continue;
              }
              goto case 23;
            case 12:
              title = "";
              num2 = 16;
              continue;
            case 13:
              ScriptModuleImportSaveActions.rqJMGEbX1QC6DZ0OMFJi((object) reader);
              num2 = 20;
              continue;
            case 14:
              if (ScriptModuleImportSaveActions.LMkKuBbXHYuoq3jF1V7J((object) reader))
              {
                num2 = 3;
                continue;
              }
              goto case 30;
            case 15:
              ScriptModuleImportSaveActions.JymLSnbXPg8sCqOSDPr9((object) reader);
              num2 = 10;
              continue;
            case 16:
              ScriptModuleImportSaveActions.JymLSnbXPg8sCqOSDPr9((object) reader);
              num2 = 13;
              continue;
            case 17:
              goto label_12;
            case 18:
            case 29:
              if (ScriptModuleImportSaveActions.FCC479bXxke4lkkmA9Wt((object) reader) == XmlNodeType.EndElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 0;
                continue;
              }
              goto case 11;
            case 19:
              reader.MoveToElement();
              num2 = 18;
              continue;
            case 20:
              ScriptModuleImportSaveActions.JymLSnbXPg8sCqOSDPr9((object) reader);
              num2 = 19;
              continue;
            case 22:
              result1 = Guid.Empty;
              num2 = 12;
              continue;
            case 23:
              object obj1 = ScriptModuleImportSaveActions.hwJ3mxbX3lbOBPIMNS82((object) reader);
              // ISSUE: type reference
              ParameterExpression parameterExpression1 = (ParameterExpression) ScriptModuleImportSaveActions.f2Ls8wbXDhi59bOCMoXJ(ScriptModuleImportSaveActions.j2AstjbXpyA4eCjdtU8j(__typeref (IGlobalScriptModuleHeader)), ScriptModuleImportSaveActions.pgCS4ZbXaBWoVy8sEIRq(-740338220 ^ -740479110));
              // ISSUE: method reference
              string str1 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) ScriptModuleImportSaveActions.XKMhCebXw23Jora9rTim((object) parameterExpression1, (object) (MethodInfo) ScriptModuleImportSaveActions.opeILsbXtl7sy4Fo6A4Z(__methodref (IGlobalScriptModuleHeader.get_Name))), parameterExpression1));
              if ((string) obj1 == str1)
                goto case 32;
              else
                goto label_37;
            case 24:
              title = (string) ScriptModuleImportSaveActions.EB6F0bbX4KpSuErNOktU((object) reader);
              num2 = 15;
              continue;
            case 26:
              int num3 = (int) ScriptModuleImportSaveActions.wtgmErbX7m3np1G3mtO3((object) reader);
              num2 = 29;
              continue;
            case 27:
              ScriptModuleImportSaveActions.JymLSnbXPg8sCqOSDPr9((object) reader);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 25 : 17;
              continue;
            case 28:
              object obj2 = ScriptModuleImportSaveActions.hwJ3mxbX3lbOBPIMNS82((object) reader);
              ParameterExpression parameterExpression2 = (ParameterExpression) ScriptModuleImportSaveActions.f2Ls8wbXDhi59bOCMoXJ(typeof (IGlobalScriptModuleHeader), ScriptModuleImportSaveActions.pgCS4ZbXaBWoVy8sEIRq(1218962250 ^ 1218812388));
              // ISSUE: method reference
              // ISSUE: type reference
              string str2 = LinqUtils.NameOf<IGlobalScriptModuleHeader>(Expression.Lambda<Func<IGlobalScriptModuleHeader, object>>((Expression) ScriptModuleImportSaveActions.M8I5arbX6NqLnLPKJpw1((object) Expression.Property((Expression) parameterExpression2, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (IGlobalScriptModuleHeader.get_Uid))), ScriptModuleImportSaveActions.j2AstjbXpyA4eCjdtU8j(__typeref (object))), parameterExpression2));
              if ((string) obj2 == str2)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 14 : 14;
                continue;
              }
              goto case 3;
            case 30:
              ScriptModuleImportSaveActions.rqJMGEbX1QC6DZ0OMFJi((object) reader);
              num2 = 31;
              continue;
            case 31:
              Guid.TryParse((string) ScriptModuleImportSaveActions.EB6F0bbX4KpSuErNOktU((object) reader), out result1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 8 : 27;
              continue;
            case 32:
              if (reader.IsEmptyElement)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 6;
                continue;
              }
              goto case 4;
            default:
              goto label_8;
          }
        }
label_37:
        num1 = 21;
      }
label_35:
      return;
label_12:
      return;
label_8:
      return;
label_31:;
    }

    public ScriptModuleImportSaveActions()
    {
      ScriptModuleImportSaveActions.yRaIGLbXyWAD2ZlFRM0Y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptModuleImportSaveActions()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptModuleImportSaveActions.UID = new Guid((string) ScriptModuleImportSaveActions.pgCS4ZbXaBWoVy8sEIRq(95909607 + 343705423 ^ 439434628));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            ScriptModuleImportSaveActions.yRaIGLbXyWAD2ZlFRM0Y();
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

    internal static bool biiUGSbXeZbZECT4I8Xb([In] Guid obj0, [In] Guid obj1) => obj0 == obj1;

    internal static bool x3rhl2bXOONY3RqO7YOv() => ScriptModuleImportSaveActions.WOM9iWbXnrL1jVXA22tF == null;

    internal static ScriptModuleImportSaveActions ki1VDkbX2uxeXh8H7gcN() => ScriptModuleImportSaveActions.WOM9iWbXnrL1jVXA22tF;

    internal static bool JymLSnbXPg8sCqOSDPr9([In] object obj0) => ((XmlReader) obj0).Read();

    internal static bool rqJMGEbX1QC6DZ0OMFJi([In] object obj0) => ((XmlReader) obj0).MoveToElement();

    internal static bool PeI5ILbXNv5KydoaxNkT([In] object obj0) => ((XmlReader) obj0).IsStartElement();

    internal static object hwJ3mxbX3lbOBPIMNS82([In] object obj0) => (object) ((XmlReader) obj0).Name;

    internal static Type j2AstjbXpyA4eCjdtU8j([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object pgCS4ZbXaBWoVy8sEIRq(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object f2Ls8wbXDhi59bOCMoXJ([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

    internal static object opeILsbXtl7sy4Fo6A4Z([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

    internal static object XKMhCebXw23Jora9rTim([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

    internal static object EB6F0bbX4KpSuErNOktU([In] object obj0) => (object) ((XmlReader) obj0).ReadString();

    internal static object M8I5arbX6NqLnLPKJpw1([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

    internal static bool LMkKuBbXHYuoq3jF1V7J([In] object obj0) => ((XmlReader) obj0).IsEmptyElement;

    internal static void ONLecUbXAIwIfVnpXuo1([In] object obj0) => ((XmlReader) obj0).Skip();

    internal static XmlNodeType wtgmErbX7m3np1G3mtO3([In] object obj0) => ((XmlReader) obj0).MoveToContent();

    internal static XmlNodeType FCC479bXxke4lkkmA9Wt([In] object obj0) => ((XmlReader) obj0).NodeType;

    internal static bool sR5IjWbX0gx0AjubcsUM([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static object uhxsZtbXmslnQUxHlVmt([In] object obj0) => (object) ((IConfigImportSettings) obj0).FakeManifest;

    internal static void yRaIGLbXyWAD2ZlFRM0Y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

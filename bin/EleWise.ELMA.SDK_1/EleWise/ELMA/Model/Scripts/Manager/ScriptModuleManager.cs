// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Manager.ScriptModuleManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts.Manager
{
  public class ScriptModuleManager : EntityManager<ScriptModule, long>
  {
    public static readonly string[] GlobalAssemblyList;
    internal static ScriptModuleManager MMVOwAbOYTTLLANhvKWB;

    public static ScriptModuleManager Instance => Locator.GetServiceNotNull<ScriptModuleManager>();

    public IEnumerable<IScriptModuleType> ScriptModuleTypes { get; set; }

    public override ExportRuleList ExportRules()
    {
      int num = 1;
      Type type;
      while (true)
      {
        switch (num)
        {
          case 1:
            type = InterfaceActivator.TypeOf<ScriptModule>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      ExportRuleList exportRuleList = new ExportRuleList();
      ExportRule exportRule1 = new ExportRule();
      exportRule1.ParentType = type;
      exportRule1.PropertyName = (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1142330761 ^ 1541959139 ^ 536823866);
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule1, ExportRuleType.Export);
      exportRuleList.Add(exportRule1);
      ExportRule exportRule2 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule2, type);
      exportRule2.PropertyName = z2jc63fLkugS1X8Q9N.tE1kD1vbB(654297945 ^ 654211673);
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule2, ExportRuleType.Export);
      exportRuleList.Add(exportRule2);
      ExportRule exportRule3 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule3, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule3, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1255365154 ^ 596875508 ^ -1765898968));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule3, ExportRuleType.Export);
      exportRuleList.Add(exportRule3);
      ExportRule exportRule4 = new ExportRule();
      exportRule4.ParentType = type;
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule4, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1876063057 ^ -1876151167));
      exportRule4.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule4);
      ExportRule exportRule5 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule5, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule5, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1858887263 ^ -1858989893));
      exportRule5.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule5);
      ExportRule exportRule6 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule6, type);
      exportRule6.PropertyName = (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(654297945 ^ 654272165);
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule6, ExportRuleType.Export);
      exportRuleList.Add(exportRule6);
      ExportRule exportRule7 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule7, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule7, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-630932142 - 1120244082 ^ -1751213578));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule7, ExportRuleType.Export);
      exportRuleList.Add(exportRule7);
      ExportRule exportRule8 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule8, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule8, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1012087039 ^ 1012039853));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule8, ExportRuleType.Export);
      exportRuleList.Add(exportRule8);
      ExportRule exportRule9 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule9, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule9, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1149433385 + 173655049 ^ 1323121790));
      exportRule9.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule9);
      ExportRule exportRule10 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule10, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule10, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(--1418440330 ^ 1418335994));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule10, ExportRuleType.Export);
      exportRuleList.Add(exportRule10);
      ExportRule exportRule11 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule11, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule11, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(277947046 - -1479185048 ^ 1757023672));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule11, ExportRuleType.Export);
      exportRuleList.Add(exportRule11);
      ExportRule exportRule12 = new ExportRule();
      exportRule12.ParentType = type;
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule12, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-740338220 ^ -740365062));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule12, ExportRuleType.Export);
      exportRuleList.Add(exportRule12);
      ExportRule exportRule13 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule13, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule13, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1012087039 ^ 1012039911));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule13, ExportRuleType.Export);
      exportRuleList.Add(exportRule13);
      ExportRule exportRule14 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule14, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule14, ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-342626196 - 1290888215 ^ -1633492025));
      ScriptModuleManager.o29KxubOcZFj3muL8PXG((object) exportRule14, ExportRuleType.Export);
      exportRuleList.Add(exportRule14);
      ExportRule exportRule15 = new ExportRule();
      ScriptModuleManager.JoWOZBbOzrj9GMe7B1D1((object) exportRule15, type);
      ScriptModuleManager.eMty7mb2FWQb0NsmdQyC((object) exportRule15, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283486109));
      exportRule15.ExportRuleType = ExportRuleType.Export;
      exportRuleList.Add(exportRule15);
      return exportRuleList;
    }

    public void ConvertOldReferences(ScriptModule module)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        List<string>.Enumerator enumerator;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              if (module.GlobalScriptModules == null)
              {
                num2 = 6;
                continue;
              }
              goto default;
            case 3:
              goto label_35;
            case 4:
              module.WebReferences = new List<ScriptWebReference>();
              num2 = 10;
              continue;
            case 5:
              if (module.WebReferences == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 11 : 4;
                continue;
              }
              goto case 14;
            case 6:
              module.GlobalScriptModules = new List<AssemblyReference>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
              continue;
            case 7:
              ScriptModuleManager.WFdwVIb2W5xwRfl6sW7N((object) module, (object) "");
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 1 : 1;
              continue;
            case 8:
            case 11:
              if (ScriptModuleManager.zlwxofb2BJH4XrL4sb8s((object) module) != null)
              {
                num2 = 2;
                continue;
              }
              goto case 7;
            case 9:
              if (module.GlobalScriptModules == null)
              {
                num2 = 8;
                continue;
              }
              goto case 5;
            case 10:
              if (!string.IsNullOrEmpty((string) ScriptModuleManager.MLJfwqb2ojd3aOY3mSco((object) module)))
              {
                num2 = 18;
                continue;
              }
              goto case 13;
            case 12:
              if (module.WebReferences == null)
              {
                num2 = 4;
                continue;
              }
              goto case 10;
            case 13:
label_41:
              ScriptModuleManager.MoHpFJb2hoBoL2utbG9m((object) module);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 3 : 0;
              continue;
            case 14:
              if (module.LocalReferences != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 15 : 4;
                continue;
              }
              goto case 8;
            case 15:
              goto label_40;
            case 16:
              module.LocalReferences = new List<AssemblyReference>();
              num2 = 12;
              continue;
            case 17:
              try
              {
label_22:
                if (enumerator.MoveNext())
                  goto label_27;
                else
                  goto label_23;
label_18:
                int num3;
                int num4 = num3;
label_19:
                string current;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_27;
                    case 2:
                      goto label_41;
                    case 3:
                      if (((IEnumerable<string>) ScriptModuleManager.GlobalAssemblyList).Contains<string>(current))
                      {
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
                        continue;
                      }
                      goto case 4;
                    case 4:
                      if (!((string) ScriptModuleManager.zlwxofb2BJH4XrL4sb8s((object) module)).Contains(current))
                      {
                        num4 = 5;
                        continue;
                      }
                      goto label_22;
                    case 5:
                      goto label_24;
                    default:
                      goto label_22;
                  }
                }
label_24:
                ScriptModule scriptModule = module;
                ScriptModuleManager.WFdwVIb2W5xwRfl6sW7N((object) scriptModule, (object) ((string) ScriptModuleManager.zlwxofb2BJH4XrL4sb8s((object) scriptModule) + string.Format((string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-882126494 ^ -882304270), (object) current)));
                num3 = 6;
                goto label_18;
label_23:
                num4 = 2;
                goto label_19;
label_27:
                current = enumerator.Current;
                num3 = 3;
                goto label_18;
              }
              finally
              {
                enumerator.Dispose();
                int num5 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
                  num5 = 0;
                switch (num5)
                {
                  default:
                }
              }
            case 18:
              enumerator = ((IEnumerable<string>) module.References.Split((char[]) ScriptModuleManager.PYyjcRb2bVvcJkUti2UW((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-710283084 ^ -537863435 ^ 173637277)), StringSplitOptions.RemoveEmptyEntries)).ToList<string>().GetEnumerator();
              num2 = 17;
              continue;
            default:
              if (module.LocalReferences != null)
                goto case 12;
              else
                goto label_7;
          }
        }
label_7:
        num1 = 16;
      }
label_35:
      return;
label_40:;
    }

    /// <summary>Получить тип скрипт модуля</summary>
    /// <param name="moduleTypeUid">Уникальный идентификатор модуля</param>
    /// <returns>Тип скрипт модуля</returns>
    public IScriptModuleType GetScriptModuleType(Guid moduleTypeUid)
    {
      int num = 1;
      Guid moduleTypeUid1;
      while (true)
      {
        switch (num)
        {
          case 1:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_4;
          default:
            moduleTypeUid1 = moduleTypeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
            continue;
        }
      }
label_4:
      // ISSUE: reference to a compiler-generated method
      return this.ScriptModuleTypes.FirstOrDefault<IScriptModuleType>((Func<IScriptModuleType, bool>) (smt => ScriptModuleManager.\u003C\u003Ec__DisplayClass8_0.MeFOiICpu6PJgjsZmpdu((object) smt) == moduleTypeUid1));
    }

    public ScriptModuleManager()
    {
      ScriptModuleManager.eCD9C1b2GHFOQib9boyC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ScriptModuleManager()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ScriptModuleManager.eCD9C1b2GHFOQib9boyC();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ScriptModuleManager.GlobalAssemblyList = new string[115]
            {
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1876063057 ^ -1875949773),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1669371371 ^ 1669488209),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1021410165 ^ 1021554859),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1317790512 ^ -1317611736),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1380439818 << 3 ^ 1841531818),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-138018305 ^ -138097245),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1822890472 ^ -1822807404),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(~-122002947 ^ 122114752),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(322893104 - -1992822529 ^ -1979332405),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1574260816 ^ 1574411626),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1319452732 ^ 1319603548),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1654249598 >> 2 ^ 413449105),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1178210108 ^ 1178125028),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-244066886 - -48452443 ^ -195696839),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487237580),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1597012150 ^ 1597158960),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2099751081 ^ -2099602975),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1917256330 ^ 1917176912),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1654249598 >> 2 ^ 413448471),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(979449278 ^ 979630846),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420923304),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218575336),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(272623989 ^ 272443015),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(2045296739 + 1688595713 ^ -561218186),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(333888594 ^ 1075625116 ^ 1408962192),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1317790512 ^ -1317614346),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(~-122002947 ^ 122113614),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123784472),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(92412609 - 1050237057 ^ -957738336),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1051802738 - -1831968059 ^ -1411381107),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(993438473 ^ 993294901),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045230),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1638402543 ^ -1638495799),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-680446928 - -370807692 ^ -309750260),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1824388195 ^ -1824466367),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(323422137 << 2 ^ 1293771098),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045408),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-87337865 ^ -87456201),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(322893104 - -1992822529 ^ -1979328953),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(272623989 ^ 272448495),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(~538519529 ^ -538703144),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-244066886 - -48452443 ^ -195691537),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751254828),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2138958856 ^ -2139045738),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-218496594 ^ -218574280),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461481509),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-710283084 ^ -537863435 ^ 173799835),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1710575414 ^ -1710726350),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(--1360331293 ^ 1360516657),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1839087379 - 334718690 ^ 2121043599),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1994213607 >> 4 ^ 124772788),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1654249598 >> 2 ^ 413442771),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1994213607 >> 4 ^ 124715124),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(322893104 - -1992822529 ^ -1979330303),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710725738),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921117601),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(323422137 << 2 ^ 1293863774),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2112703338 ^ -2112855690),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-740338220 ^ -740457486),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-649342099 - -1150814748 ^ 501287875),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(2045296739 + 1688595713 ^ -561218810),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-16752921 ^ -16611229),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-105199646 ^ -105377468),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2112703338 ^ -2112844162),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(~1767720452 ^ -1767870675),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1819636893 << 3 ^ 1672094738),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643043760),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218613118),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-812025778 ^ -812058466),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-867826612 ^ -867904728),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-951514650 ^ -951329214),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1470998129 - 231418599 ^ 1239460974),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1461625753 ^ 1461484473),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-2138160520 ^ -2138269146),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36169397),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146389015),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1917998801 >> 2 ^ 479612236),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-812025778 ^ -811884200),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-218496594 ^ -218398248),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(572119659 - -337058038 ^ 909257249),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(--1360331293 ^ 1360517999),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1142330761 ^ 1541959139 ^ 536617432),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1253244298 - 1829393894 ^ -576029110),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1350312861 << 3 ^ 2082224416),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1669371371 ^ 1669484419),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1232639661 >> 3 ^ 153995379),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1290212282 ^ -644262414 ^ 1786995576),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1837662597 ^ -1837808331),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1875945553),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1255365154 ^ 596875508 ^ -1765939690),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 235991725),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345270684),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(654297945 ^ 654199767),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(647913418 ^ 647791618),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813450277),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1574260816 ^ 1574407188),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-16752921 ^ -16612795),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87978057),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426236899),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1597012150 ^ 1597154794),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(92412609 - 1050237057 ^ -957734948),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-951514650 ^ -951331800),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87455113),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1052221104 - 768835541 ^ 283517523),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1033719030 - 2012070891 ^ -978495727),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(1470998129 - 231418599 ^ 1239677912),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1232639661 >> 3 ^ 153954331),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1638402543 ^ -1638500695),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-70007027 ^ -70182571),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-643786247 ^ -643676295),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629699616),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1380439818 << 3 ^ 1841535326),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(-1858887263 ^ -1859027275),
              z2jc63fLkugS1X8Q9N.tE1kD1vbB(1597012150 ^ 1597155224),
              (string) ScriptModuleManager.h6p9C9bOsM01G9cgjIEP(277947046 - -1479185048 ^ 1756981854)
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object h6p9C9bOsM01G9cgjIEP(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void o29KxubOcZFj3muL8PXG([In] object obj0, ExportRuleType value) => ((ExportRule) obj0).ExportRuleType = value;

    internal static void JoWOZBbOzrj9GMe7B1D1([In] object obj0, Type value) => ((ExportRule) obj0).ParentType = value;

    internal static void eMty7mb2FWQb0NsmdQyC([In] object obj0, [In] object obj1) => ((ExportRule) obj0).PropertyName = (string) obj1;

    internal static bool HX9H8UbOLLp4RsBdXhLF() => ScriptModuleManager.MMVOwAbOYTTLLANhvKWB == null;

    internal static ScriptModuleManager io1cQ3bOUmgUKCMmUupy() => ScriptModuleManager.MMVOwAbOYTTLLANhvKWB;

    internal static object zlwxofb2BJH4XrL4sb8s([In] object obj0) => (object) ((ScriptModule) obj0).ElmaReferences;

    internal static void WFdwVIb2W5xwRfl6sW7N([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).ElmaReferences = (string) obj1;

    internal static object MLJfwqb2ojd3aOY3mSco([In] object obj0) => (object) ((ScriptModule) obj0).References;

    internal static object PYyjcRb2bVvcJkUti2UW([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static void MoHpFJb2hoBoL2utbG9m([In] object obj0) => ((Entity<long>) obj0).Save();

    internal static void eCD9C1b2GHFOQib9boyC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

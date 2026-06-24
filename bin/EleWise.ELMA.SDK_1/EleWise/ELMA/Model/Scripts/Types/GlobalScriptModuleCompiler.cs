// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.Types.GlobalScriptModuleCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Model.Scripts.Types
{
  public class GlobalScriptModuleCompiler : ScriptCompiler
  {
    private readonly IDictionary<string, ProjectItem> projectItems;
    private List<ScriptCompileMessage> messages;
    internal static GlobalScriptModuleCompiler cEDaXYbTzIt8f2Kp7YDX;

    /// <summary>Сервис для добавления ссылки на глобальный модуль</summary>
    internal new IGlobalModulesReferenceService GlobalModulesReferenceService => Locator.GetServiceNotNull<IGlobalModulesReferenceService>();

    /// <summary>Ctor</summary>
    /// <param name="module">Модуль сценариев</param>
    public GlobalScriptModuleCompiler(ScriptModule module, IGlobalScriptModule globalScriptModule)
    {
      GlobalScriptModuleCompiler.mHkWxvbkWPwb3AiCn8uB();
      this.projectItems = (IDictionary<string, ProjectItem>) new Dictionary<string, ProjectItem>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
      // ISSUE: explicit constructor call
      base.\u002Ector((IScriptModule) module);
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddReferenceByName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643787817));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 5 : 5;
            continue;
          case 2:
            this.GlobalScriptModule = globalScriptModule;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          case 4:
            GlobalScriptModuleCompiler.dyvlaObkbVbFZZchUKRm((object) this, GlobalScriptModuleCompiler.jOWg8Mbko8K9m7gD74Hn(-1939377524 ^ -1939375896));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          case 5:
            this.GlobalScriptProject = GlobalScriptModuleCompiler.P0mpvtbkh1ktapve61IK((object) globalScriptModule) as ProjectInfo;
            num = 2;
            continue;
          default:
            this.AddReferenceByName((string) GlobalScriptModuleCompiler.jOWg8Mbko8K9m7gD74Hn(-1290212282 ^ -644262414 ^ 1786868530));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public GlobalScriptModuleManager GlobalScriptModuleManager => Locator.GetServiceNotNull<GlobalScriptModuleManager>();

    /// <summary>Проект модуля сценариев</summary>
    public ProjectInfo GlobalScriptProject
    {
      get => this.\u003CGlobalScriptProject\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CGlobalScriptProject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Глобальный модуль сценарий</summary>
    public IGlobalScriptModule GlobalScriptModule
    {
      get => this.\u003CGlobalScriptModule\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CGlobalScriptModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Компиляция</summary>
    /// <returns></returns>
    public override ScriptCompileResult Compile()
    {
      int num1 = 2;
      bool lockTaken;
      GlobalScriptModuleCompiler scriptModuleCompiler;
      while (true)
      {
        switch (num1)
        {
          case 1:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 0;
            continue;
          case 2:
            scriptModuleCompiler = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_5;
        }
      }
label_2:
      ScriptCompileResult scriptCompileResult1;
      return scriptCompileResult1;
label_5:
      try
      {
        Monitor.Enter((object) scriptModuleCompiler, ref lockTaken);
        int num2 = 5;
        while (true)
        {
          int num3;
          DirectoryInfo directoryInfo;
          IEnumerator<string> enumerator1;
          IEnumerator<KeyValuePair<string, ProjectItem>> enumerator2;
          string directoryName;
          IList<IScriptModule> scriptModuleList1;
          List<AssemblyReference>.Enumerator enumerator3;
          IList<IScriptModule> scriptModuleList2;
          IList<IScriptModule> scriptModuleList3;
          switch (num2)
          {
            case 1:
              this.AssemblyName = (string) GlobalScriptModuleCompiler.PjtwMTbkSFvsZTb8KbG2((object) this.Modules[0]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 1 : 7;
              continue;
            case 2:
              IList<IScriptModule> source1 = scriptModuleList2;
              // ISSUE: reference to a compiler-generated field
              Func<IScriptModule, IEnumerable<string>> func1 = GlobalScriptModuleCompiler.\u003C\u003Ec.\u003C\u003E9__13_0;
              Func<IScriptModule, IEnumerable<string>> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                // ISSUE: reference to a compiler-generated method
                GlobalScriptModuleCompiler.\u003C\u003Ec.\u003C\u003E9__13_0 = selector1 = (Func<IScriptModule, IEnumerable<string>>) (m => m.References == null ? (IEnumerable<string>) new List<string>() : (IEnumerable<string>) ((IEnumerable<string>) m.References.Split(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1994213607 >> 4 ^ 124616786).ToCharArray(), StringSplitOptions.RemoveEmptyEntries)).Select<string, string>((Func<string, string>) (s => (string) GlobalScriptModuleCompiler.\u003C\u003Ec.s7IXUIC3Sj0eWncn0q03((object) s))).ToList<string>());
              }
              else
                goto label_39;
label_79:
              enumerator1 = source1.SelectMany<IScriptModule, string>(selector1).Distinct<string>().GetEnumerator();
              num3 = 4;
              break;
label_39:
              selector1 = func1;
              goto label_79;
            case 3:
              GlobalScriptModuleCompiler.IOi8v6bkKeoBbWiAH0bH((object) (ProjectInfo) GlobalScriptModuleCompiler.P0mpvtbkh1ktapve61IK((object) this.GlobalScriptModule), (object) directoryName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 13 : 15;
              continue;
            case 4:
              try
              {
label_20:
                if (GlobalScriptModuleCompiler.L1gEaGbkEcgdG10WtDfR((object) enumerator1))
                  goto label_16;
                else
                  goto label_21;
label_15:
                string current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_13;
                    case 2:
                      GlobalScriptModuleCompiler.XA15rRbkGMvfdo2o9KuF((object) this, (object) current);
                      num4 = 3;
                      continue;
                    case 3:
                      goto label_20;
                    case 4:
                      if (!GlobalScriptModuleCompiler.dyvlaObkbVbFZZchUKRm((object) this, (object) current))
                      {
                        num4 = 2;
                        continue;
                      }
                      goto label_20;
                    default:
                      goto label_16;
                  }
                }
label_16:
                current = enumerator1.Current;
                num4 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
                {
                  num4 = 4;
                  goto label_15;
                }
                else
                  goto label_15;
label_21:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                goto label_15;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        GlobalScriptModuleCompiler.U9XACkbkfmWfY6SmAcOL((object) enumerator1);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_28;
                    }
                  }
                }
label_28:;
              }
            case 5:
              if (this.MainModule == null)
              {
                num2 = 17;
                continue;
              }
              goto default;
            case 6:
              directoryInfo = new DirectoryInfo((string) GlobalScriptModuleCompiler.ACoSGdbkCmLFE2s4SRBY());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 5 : 13;
              continue;
            case 7:
            case 11:
              directoryName = Path.GetDirectoryName(this.GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~289714581 ^ -289727430), string.Empty));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 3 : 0;
              continue;
            case 8:
              GlobalScriptModuleCompiler.Jjv7RAbkqEfUyE3HQdC1((object) this.Modules[0], GlobalScriptModuleCompiler.xHTnRJbkRwoFCmx80ttm(GlobalScriptModuleCompiler.jOWg8Mbko8K9m7gD74Hn(1819636893 << 3 ^ 1672044980), (object) this.Modules[0].Uid.ToString((string) GlobalScriptModuleCompiler.jOWg8Mbko8K9m7gD74Hn(~-397266137 ^ 397227664))));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
              continue;
            case 9:
              try
              {
label_67:
                if (enumerator3.MoveNext())
                  goto label_66;
                else
                  goto label_68;
label_62:
                AssemblyReference current;
                int num6;
                while (true)
                {
                  string str;
                  switch (num6)
                  {
                    case 1:
                      goto label_66;
                    case 2:
                    case 4:
                      goto label_67;
                    case 3:
                      str = (string) GlobalScriptModuleCompiler.HktK7PbkuVOTq9jsOrXx((object) this.GlobalModulesReferenceService, GlobalScriptModuleCompiler.IA2pNlbkZxJXsMUv7NMi((object) current));
                      num6 = 5;
                      continue;
                    case 5:
                      if (str == null)
                      {
                        num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 2 : 4;
                        continue;
                      }
                      break;
                    case 6:
                      goto label_9;
                  }
                  GlobalScriptModuleCompiler.pHWHoIbkI9ywxw1R5jah((object) this, (object) str);
                  num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 2 : 0;
                }
label_66:
                current = enumerator3.Current;
                num6 = 3;
                goto label_62;
label_68:
                num6 = 6;
                goto label_62;
              }
              finally
              {
                enumerator3.Dispose();
                int num7 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
                  num7 = 0;
                switch (num7)
                {
                  default:
                }
              }
            case 10:
label_9:
              GlobalScriptModuleCompiler.Jc3bmPbkVv1TwGHrOVy1((object) this.projectItems);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 6 : 28;
              continue;
            case 12:
              this.AddSources((IEnumerable<ProjectItem>) this.GlobalScriptProject.Items, directoryName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 19 : 29;
              continue;
            case 13:
              if (GlobalScriptModuleCompiler.NvhRUVbkvufGjNSYUNxk((object) directoryInfo))
              {
                num2 = 22;
                continue;
              }
              goto case 24;
            case 14:
              GlobalScriptModuleCompiler.WYuHEjbkTAsddP7rHpUv((object) this);
              num2 = 27;
              continue;
            case 15:
              GlobalScriptModuleCompiler.iDdYvQbkXm131BdAGYM6((object) this.GlobalScriptModule);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 21 : 23;
              continue;
            case 16:
              scriptModuleList3 = scriptModuleList1;
              goto label_76;
            case 17:
              scriptModuleList3 = this.Modules;
              goto label_76;
            case 18:
              try
              {
label_32:
                if (enumerator2.MoveNext())
                  goto label_34;
                else
                  goto label_33;
label_30:
                KeyValuePair<string, ProjectItem> current;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      goto label_54;
                    case 2:
                      goto label_32;
                    case 3:
                      goto label_34;
                    default:
                      current.Value.CompiledFileName = current.Key;
                      num8 = 2;
                      continue;
                  }
                }
label_33:
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 1 : 1;
                goto label_30;
label_34:
                current = enumerator2.Current;
                num8 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
                {
                  num8 = 0;
                  goto label_30;
                }
                else
                  goto label_30;
              }
              finally
              {
                int num9;
                if (enumerator2 == null)
                  num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
                else
                  goto label_40;
label_38:
                switch (num9)
                {
                  case 2:
                    break;
                  default:
                }
label_40:
                enumerator2.Dispose();
                num9 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
                {
                  num9 = 1;
                  goto label_38;
                }
                else
                  goto label_38;
              }
            case 19:
            case 22:
              IList<IScriptModule> source2 = scriptModuleList2;
              // ISSUE: reference to a compiler-generated field
              Func<IScriptModule, IEnumerable<AssemblyReference>> func2 = GlobalScriptModuleCompiler.\u003C\u003Ec.\u003C\u003E9__13_1;
              Func<IScriptModule, IEnumerable<AssemblyReference>> selector2;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                GlobalScriptModuleCompiler.\u003C\u003Ec.\u003C\u003E9__13_1 = selector2 = (Func<IScriptModule, IEnumerable<AssemblyReference>>) (a => (IEnumerable<AssemblyReference>) a.GlobalScriptModules);
              }
              else
                goto label_89;
label_82:
              enumerator3 = source2.SelectMany<IScriptModule, AssemblyReference>(selector2).ToList<AssemblyReference>().GetEnumerator();
              num2 = 9;
              continue;
label_89:
              selector2 = func2;
              goto label_82;
            case 20:
label_54:
              ScriptCompileResult scriptCompileResult2 = new ScriptCompileResult();
              GlobalScriptModuleCompiler.ueZXKfbkk1Xjkc2lkTyC((object) scriptCompileResult2, this.AssemblyRaw != null);
              scriptCompileResult2.Messages = this.messages;
              scriptCompileResult1 = scriptCompileResult2;
              num2 = 25;
              continue;
            case 21:
              this.Build();
              num2 = 14;
              continue;
            case 23:
              this.messages = new List<ScriptCompileMessage>();
              num2 = 12;
              continue;
            case 24:
              GlobalScriptModuleCompiler.MtOg1dbk8CofwNejcEaa((object) directoryInfo);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 19 : 4;
              continue;
            case 25:
              goto label_2;
            case 26:
label_13:
              GlobalScriptModuleCompiler.VjV5PZbkQuZNpgcxrVyg((object) this);
              num2 = 6;
              continue;
            case 27:
              enumerator2 = this.projectItems.GetEnumerator();
              num2 = 18;
              continue;
            case 28:
              if (!GlobalScriptModuleCompiler.th4l1Cbkiog4AVfv63Be(GlobalScriptModuleCompiler.PjtwMTbkSFvsZTb8KbG2((object) this.Modules[0])))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 11;
                continue;
              }
              goto case 8;
            case 29:
              this.AddSourceCode((string) GlobalScriptModuleCompiler.jOWg8Mbko8K9m7gD74Hn(87862435 ^ 87976229));
              num3 = 21;
              break;
            default:
              scriptModuleList1 = (IList<IScriptModule>) new List<IScriptModule>()
              {
                (IScriptModule) this.MainModule
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 9 : 16;
              continue;
          }
          num2 = num3;
          continue;
label_76:
          scriptModuleList2 = scriptModuleList3;
          num2 = 2;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num10 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
            num10 = 0;
          while (true)
          {
            switch (num10)
            {
              case 1:
                goto label_88;
              default:
                GlobalScriptModuleCompiler.WUCxwwbknWUgb36yg9Py((object) scriptModuleCompiler);
                num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
                continue;
            }
          }
        }
label_88:;
      }
    }

    public void DeleteDirectory(string targetDir)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        int index;
        string targetDir1;
        string[] strArray1;
        string[] strArray2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 12:
              if (index < strArray1.Length)
              {
                num2 = 6;
                continue;
              }
              goto case 3;
            case 2:
            case 4:
              if (index < strArray1.Length)
              {
                num2 = 14;
                continue;
              }
              goto case 7;
            case 3:
              strArray1 = strArray2;
              num2 = 9;
              continue;
            case 5:
              goto label_17;
            case 6:
            case 13:
              string str = strArray1[index];
              GlobalScriptModuleCompiler.UA6KbJbk2hFpnXQBLOG4((object) str, FileAttributes.Normal);
              GlobalScriptModuleCompiler.YMxYJibkeqInpx4W45vp((object) str);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 8 : 7;
              continue;
            case 7:
              GlobalScriptModuleCompiler.FTUbLCbkP8dDJYmEGUyW((object) targetDir, false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 5 : 2;
              continue;
            case 8:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 1;
              continue;
            case 9:
              index = 0;
              num2 = 2;
              continue;
            case 10:
            case 14:
              goto label_6;
            case 11:
              this.DeleteDirectory(targetDir1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            case 15:
              string[] files = Directory.GetFiles(targetDir);
              strArray2 = (string[]) GlobalScriptModuleCompiler.bALlkfbkOS6fWrHXUDrY((object) targetDir);
              strArray1 = files;
              num2 = 17;
              continue;
            case 16:
              File.SetAttributes(targetDir, FileAttributes.Normal);
              num2 = 15;
              continue;
            case 17:
              index = 0;
              num2 = 12;
              continue;
            default:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 4 : 2;
              continue;
          }
        }
label_6:
        targetDir1 = strArray1[index];
        num1 = 11;
      }
label_17:;
    }

    protected override void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
    {
      this.SaveSourceCodes();
      StringBuilder errorMessages = new StringBuilder();
      this.messages.AddRange(diagnostics.Where<Diagnostic>((Func<Diagnostic, bool>) (x =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (GlobalScriptModuleCompiler.\u003C\u003Ec.LYnaRaC3iqdu0sNWYf2v((object) x) == DiagnosticSeverity.Warning)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              // ISSUE: reference to a compiler-generated method
              if (GlobalScriptModuleCompiler.\u003C\u003Ec.LYnaRaC3iqdu0sNWYf2v((object) x) != DiagnosticSeverity.Error)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 1;
                continue;
              }
              goto label_6;
            default:
              goto label_6;
          }
        }
label_6:
        return x.Id != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97731444);
label_7:
        return false;
      })).Select<Diagnostic, ScriptCompileMessage>((Func<Diagnostic, int, ScriptCompileMessage>) ((err, i) =>
      {
        int num = 5;
        ProjectItem projectItem;
        while (true)
        {
          switch (num)
          {
            case 1:
            case 4:
              projectItem = (ProjectItem) null;
              num = 3;
              continue;
            case 2:
              goto label_7;
            case 3:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              this.projectItems.TryGetValue((string) GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.rtMkMhC3OfiO0apK7sms(GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.ULXNC9C3nYlwnHknUXI7((object) err)), out projectItem);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 2 : 2;
              continue;
            case 5:
              // ISSUE: reference to a compiler-generated method
              if (!GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.MAmXO1C3TXHG4yRsNDye((object) ScriptCompiler.ScriptCompilerLogger))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 4;
                continue;
              }
              break;
          }
          // ISSUE: reference to a compiler-generated method
          GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.pUtaXnC3kF02IIbhWkZd((object) errorMessages.AppendLine(), (object) err);
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 1 : 1;
        }
label_7:
        ScriptCompileMessage scriptCompileMessage = new ScriptCompileMessage();
        // ISSUE: reference to a compiler-generated method
        GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.LPeBA3C32e4EI6GdC53o((object) scriptCompileMessage, i + 1);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.JVjgsqC3PIRCUJ7HcoVW((object) scriptCompileMessage, GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.sRJgluC3etbDMivbPjKT((object) err) == DiagnosticSeverity.Warning ? ScriptCompileMessageType.Warning : ScriptCompileMessageType.Error);
        // ISSUE: reference to a compiler-generated method
        GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.n6f93kC31q7efpYdMWY3((object) scriptCompileMessage, (object) err.Message);
        // ISSUE: reference to a compiler-generated method
        scriptCompileMessage.Line = ((Location) GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.ULXNC9C3nYlwnHknUXI7((object) err)).Line;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.OZqlodC33rGYBUJT4HGw((object) scriptCompileMessage, GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.VwhXKBC3NcqenQrY4RXd((object) err.Location));
        // ISSUE: reference to a compiler-generated method
        scriptCompileMessage.ModuleUid = projectItem != null ? GlobalScriptModuleCompiler.\u003C\u003Ec__DisplayClass15_0.bVnM1CC3pGjnDYECXl5n((object) projectItem) : Guid.Empty;
        return scriptCompileMessage;
      })));
      if (!ScriptCompiler.ScriptCompilerLogger.IsErrorEnabled())
        return;
      errorMessages.AppendLine().Append(new StackTrace(3, true).ToString().TrimEnd());
      ScriptCompiler.ScriptCompilerLogger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87453065), (object) errorMessages));
    }

    private void AddSources(IEnumerable<ProjectItem> items, string folderName)
    {
      foreach (ProjectItem projectItem in items)
      {
        if (projectItem.GetType() == typeof (ProjectItem))
        {
          string str = Path.Combine(folderName, projectItem.FileName);
          this.projectItems[str] = projectItem;
          this.AddSourceCodeWithName(projectItem.Code, str);
        }
        else if (projectItem is ProjectFolderItem projectFolderItem)
          this.AddSources((IEnumerable<ProjectItem>) projectFolderItem.Items, Path.Combine(folderName, projectFolderItem.Name));
      }
    }

    internal static void mHkWxvbkWPwb3AiCn8uB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object jOWg8Mbko8K9m7gD74Hn(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool dyvlaObkbVbFZZchUKRm([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReferenceByName((string) obj1);

    internal static object P0mpvtbkh1ktapve61IK([In] object obj0) => ((IGlobalScriptModule) obj0).Items;

    internal static bool zGm5JcbkFg1EpVK7tRfb() => GlobalScriptModuleCompiler.cEDaXYbTzIt8f2Kp7YDX == null;

    internal static GlobalScriptModuleCompiler neixPfbkB4J60qZqpkfj() => GlobalScriptModuleCompiler.cEDaXYbTzIt8f2Kp7YDX;

    internal static void XA15rRbkGMvfdo2o9KuF([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddGlobalReference((string) obj1);

    internal static bool L1gEaGbkEcgdG10WtDfR([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void U9XACkbkfmWfY6SmAcOL([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void VjV5PZbkQuZNpgcxrVyg([In] object obj0) => ((AssemblyBuilder) obj0).AddAllElmaReferences();

    internal static object ACoSGdbkCmLFE2s4SRBY() => (object) AssemblyReferenceHelper.ExternalAssemblyLocation;

    internal static bool NvhRUVbkvufGjNSYUNxk([In] object obj0) => ((FileSystemInfo) obj0).Exists;

    internal static void MtOg1dbk8CofwNejcEaa([In] object obj0) => ((DirectoryInfo) obj0).Create();

    internal static Guid IA2pNlbkZxJXsMUv7NMi([In] object obj0) => ((AssemblyReference) obj0).Uid;

    internal static object HktK7PbkuVOTq9jsOrXx([In] object obj0, Guid globalModuleHeaderUid) => (object) ((IGlobalModulesReferenceService) obj0).CreateGlobalModuleAssembly(globalModuleHeaderUid);

    internal static void pHWHoIbkI9ywxw1R5jah([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((string) obj1);

    internal static void Jc3bmPbkVv1TwGHrOVy1([In] object obj0) => ((ICollection<KeyValuePair<string, ProjectItem>>) obj0).Clear();

    internal static object PjtwMTbkSFvsZTb8KbG2([In] object obj0) => (object) ((IScriptModule) obj0).AssemblyName;

    internal static bool th4l1Cbkiog4AVfv63Be([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static object xHTnRJbkRwoFCmx80ttm([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void Jjv7RAbkqEfUyE3HQdC1([In] object obj0, [In] object obj1) => ((IScriptModule) obj0).AssemblyName = (string) obj1;

    internal static void IOi8v6bkKeoBbWiAH0bH([In] object obj0, [In] object obj1) => ((ProjectInfo) obj0).CompiledFolderPath = (string) obj1;

    internal static void iDdYvQbkXm131BdAGYM6([In] object obj0) => ((IEntity) obj0).Save();

    internal static void WYuHEjbkTAsddP7rHpUv([In] object obj0) => ((ScriptCompiler) obj0).ProcessResults();

    internal static void ueZXKfbkk1Xjkc2lkTyC([In] object obj0, bool value) => ((ScriptCompileResult) obj0).Success = value;

    internal static void WUCxwwbknWUgb36yg9Py([In] object obj0) => Monitor.Exit(obj0);

    internal static object bALlkfbkOS6fWrHXUDrY([In] object obj0) => (object) Directory.GetDirectories((string) obj0);

    internal static void UA6KbJbk2hFpnXQBLOG4([In] object obj0, [In] FileAttributes obj1) => File.SetAttributes((string) obj0, obj1);

    internal static void YMxYJibkeqInpx4W45vp([In] object obj0) => File.Delete((string) obj0);

    internal static void FTUbLCbkP8dDJYmEGUyW([In] object obj0, [In] bool obj1) => Directory.Delete((string) obj0, obj1);
  }
}

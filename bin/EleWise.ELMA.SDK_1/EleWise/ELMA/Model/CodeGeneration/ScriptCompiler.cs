// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.ScriptCompiler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Projects;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.DTO.Manager;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.ScriptDesigner.CodeItems;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Компилятор сценариев</summary>
  public class ScriptCompiler : AssemblyBuilder
  {
    /// <summary>
    /// Логгер <see cref="T:EleWise.ELMA.Model.CodeGeneration.ScriptCompiler" />
    /// </summary>
    protected static readonly ILogger ScriptCompilerLogger;
    private readonly List<IScriptModule> modules;
    private IScriptModule singleModule;
    private List<ScriptCompileMessage> messages;
    private readonly IDictionary<string, ScriptCompiler.ScripModuleBinding> moduleFileNames;
    private static ScriptCompiler F8VjoQhDTStnpiNWkkWb;

    public IExternalAssemblyDtoManager ExternalAssemblyDtoManager => Locator.GetServiceNotNull<IExternalAssemblyDtoManager>();

    /// <summary>Сервис для добавления ссылки на глобальный модуль</summary>
    internal IGlobalModulesReferenceService GlobalModulesReferenceService => Locator.GetServiceNotNull<IGlobalModulesReferenceService>();

    /// <summary>Работа со средой исполнения приложения</summary>
    internal IRuntimeApplication RuntimeApplication => Locator.GetService<IRuntimeApplication>();

    /// <summary>Конструктор</summary>
    public ScriptCompiler()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.modules = new List<IScriptModule>();
      this.moduleFileNames = (IDictionary<string, ScriptCompiler.ScripModuleBinding>) new Dictionary<string, ScriptCompiler.ScripModuleBinding>((IEqualityComparer<string>) ScriptCompiler.guF0XyhDOj0dfCNiUkvO());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Конструктор</summary>
    /// <param name="assemblyName">Имя сборки</param>
    public ScriptCompiler(string assemblyName, IEnumerable<IScriptModule> modules)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.modules = new List<IScriptModule>();
      this.moduleFileNames = (IDictionary<string, ScriptCompiler.ScripModuleBinding>) new Dictionary<string, ScriptCompiler.ScripModuleBinding>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      Contract.ArgumentNotNull((object) modules, z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272407005));
      Contract.ArgumentNotNull((object) assemblyName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1334904397));
      this.modules.AddRange(modules);
      this.AssemblyName = assemblyName;
    }

    /// <summary>Конструктор</summary>
    /// <param name="module">Модуль сценариев</param>
    public ScriptCompiler(IScriptModule module)
    {
      ScriptCompiler.B4lpJ1hD2tyHvcfs8Lh3();
      this.modules = new List<IScriptModule>();
      this.moduleFileNames = (IDictionary<string, ScriptCompiler.ScripModuleBinding>) new Dictionary<string, ScriptCompiler.ScripModuleBinding>((IEqualityComparer<string>) ScriptCompiler.guF0XyhDOj0dfCNiUkvO());
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            ScriptCompiler.guHNXPhDeHXkEyVqP4U9((object) module, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-649342099 - -1150814748 ^ 501411153));
            num = 3;
            continue;
          case 3:
            this.modules.Add(module);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 4:
            this.AssemblyName = module.AssemblyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
            continue;
          default:
            this.singleModule = module;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 4 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Главный модуль (из него берутся референсы)</summary>
    public ScriptModule MainModule
    {
      get => this.\u003CMainModule\u003Ek__BackingField;
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
              this.\u003CMainModule\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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

    /// <summary>Сгенерировать файл AssemblyInfo.cs</summary>
    /// <param name="conversions">Преобразования с текстом шаблона</param>
    public void GenerateAssemblyInfoFile(System.Func<string, string> conversions = null) => this.AddSourceCodeWithName(ModelProject.GenerateAssemblyInfoFile(conversions), this.GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099566611), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105128276)));

    /// <inheritdoc />
    public override void AddSourceCode(string code)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptCompiler.ecKf7nhD1trWLCLK7PJw((object) this, (object) code, (object) this.GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951420580), (string) ScriptCompiler.CuLl61hDPEUhJkddGxbA(1470440286 ^ 1470380560)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Скомпилировать</summary>
    /// <returns>Результаты компиляции</returns>
    public virtual ScriptCompileResult Compile()
    {
      int num1 = 3;
      ScriptCompiler scriptCompiler;
      bool lockTaken;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_145;
          case 2:
            lockTaken = false;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 3:
            scriptCompiler = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      ScriptCompileResult scriptCompileResult1;
      try
      {
        Monitor.Enter((object) scriptCompiler, ref lockTaken);
        int num2 = 9;
        while (true)
        {
          int num3;
          IEnumerator<string> enumerator1;
          List<IScriptModule> source1;
          List<IScriptModule>.Enumerator enumerator2;
          IEnumerator<KeyValuePair<string, ScriptCompiler.ScripModuleBinding>> enumerator3;
          switch (num2)
          {
            case 1:
label_22:
              source1 = new List<IScriptModule>()
              {
                (IScriptModule) this.MainModule
              };
              num2 = 18;
              continue;
            case 2:
              enumerator3 = this.moduleFileNames.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
              continue;
            case 3:
              ScriptCompiler.aUJTdOhDNfyZAb2EeEN2((object) this);
              num2 = 21;
              continue;
            case 4:
              this.Build();
              num2 = 13;
              continue;
            case 5:
label_111:
              ScriptCompileResult scriptCompileResult2 = new ScriptCompileResult();
              ScriptCompiler.xN1jPhhD0GIxk8HKogtP((object) scriptCompileResult2, this.AssemblyRaw != null);
              scriptCompileResult2.Messages = this.messages;
              scriptCompileResult1 = scriptCompileResult2;
              num2 = 19;
              continue;
            case 6:
label_128:
              List<IScriptModule> source2 = source1;
              // ISSUE: reference to a compiler-generated field
              System.Func<IScriptModule, IEnumerable<string>> func1 = ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_1;
              System.Func<IScriptModule, IEnumerable<string>> selector1;
              if (func1 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_1 = selector1 = (System.Func<IScriptModule, IEnumerable<string>>) (m => ReferencesListHelper.GetElmaReferences(m.ElmaReferences));
              }
              else
                goto label_15;
label_130:
              enumerator1 = source2.SelectMany<IScriptModule, string>(selector1).Distinct<string>().GetEnumerator();
              num3 = 15;
              break;
label_15:
              selector1 = func1;
              goto label_130;
            case 7:
              enumerator2 = this.modules.GetEnumerator();
              num2 = 23;
              continue;
            case 8:
            case 18:
              this.AddDefaultReferences();
              num2 = 3;
              continue;
            case 9:
              if (this.MainModule == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 17 : 7;
                continue;
              }
              goto case 10;
            case 10:
              if (this.MainModule.WebReferences == null)
              {
                num2 = 11;
                continue;
              }
              goto case 14;
            case 11:
              this.MainModule.WebReferences = new List<ScriptWebReference>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 14 : 0;
              continue;
            case 12:
              try
              {
label_115:
                if (ScriptCompiler.bAuZGchD3VI1bWVKJjdN((object) enumerator1))
                  goto label_117;
                else
                  goto label_116;
label_114:
                string current;
                int num4;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_128;
                    case 2:
                      if (!this.AddReferenceByName(current))
                      {
                        num4 = 4;
                        continue;
                      }
                      goto label_115;
                    case 3:
                      goto label_115;
                    case 4:
                      this.AddGlobalReference(current);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 3;
                      continue;
                    default:
                      goto label_117;
                  }
                }
label_116:
                num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
                goto label_114;
label_117:
                current = enumerator1.Current;
                num4 = 2;
                goto label_114;
              }
              finally
              {
                if (enumerator1 != null)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                    num5 = 1;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        enumerator1.Dispose();
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_126;
                    }
                  }
                }
label_126:;
              }
            case 13:
              ScriptCompiler.x8mDm9hD6miRu5u7vPY6((object) this);
              num3 = 2;
              break;
            case 14:
              enumerator2 = this.modules.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 2 : 20;
              continue;
            case 15:
              try
              {
label_8:
                if (ScriptCompiler.bAuZGchD3VI1bWVKJjdN((object) enumerator1))
                  goto label_10;
                else
                  goto label_9;
label_7:
                string current;
                int num6;
                while (true)
                {
                  switch (num6)
                  {
                    case 1:
                      goto label_10;
                    case 2:
                    case 4:
                      goto label_8;
                    case 3:
                      ScriptCompiler.VyTuoshDawt9gedvimGT((object) this, (object) current);
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 4 : 4;
                      continue;
                    case 5:
                      goto label_131;
                    default:
                      if (ScriptCompiler.XWUSpFhDpoul6yariy1O((object) this, (object) current))
                      {
                        num6 = 2;
                        continue;
                      }
                      goto case 3;
                  }
                }
label_9:
                num6 = 5;
                goto label_7;
label_10:
                current = enumerator1.Current;
                num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
                {
                  num6 = 0;
                  goto label_7;
                }
                else
                  goto label_7;
              }
              finally
              {
                int num7;
                if (enumerator1 == null)
                  num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 0;
                else
                  goto label_19;
label_18:
                switch (num7)
                {
                  case 1:
                  case 2:
                }
label_19:
                ScriptCompiler.KdoeqkhDDBRxkgEia4aT((object) enumerator1);
                num7 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                {
                  num7 = 2;
                  goto label_18;
                }
                else
                  goto label_18;
              }
            case 16:
label_107:
              this.messages = new List<ScriptCompileMessage>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 4;
              continue;
            case 17:
              source1 = this.modules;
              num2 = 8;
              continue;
            case 19:
              goto label_145;
            case 20:
              try
              {
label_45:
                if (enumerator2.MoveNext())
                  goto label_29;
                else
                  goto label_46;
label_26:
                IScriptModule current;
                List<ScriptWebReference>.Enumerator enumerator4;
                int num8;
                while (true)
                {
                  switch (num8)
                  {
                    case 1:
                      if (current.WebReferences == null)
                      {
                        num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 6 : 0;
                        continue;
                      }
                      goto case 5;
                    case 2:
                      goto label_22;
                    case 3:
                      goto label_31;
                    case 4:
                      goto label_29;
                    case 5:
                      enumerator4 = current.WebReferences.GetEnumerator();
                      num8 = 3;
                      continue;
                    default:
                      goto label_45;
                  }
                }
label_31:
                try
                {
label_33:
                  if (enumerator4.MoveNext())
                    goto label_38;
                  else
                    goto label_34;
label_32:
                  int num9;
                  ScriptWebReference webReference;
                  while (true)
                  {
                    switch (num9)
                    {
                      case 1:
                        webReference = enumerator4.Current;
                        num9 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                        continue;
                      case 2:
                        goto label_33;
                      case 3:
                        this.MainModule.WebReferences.Add(webReference);
                        num9 = 2;
                        continue;
                      case 4:
                        goto label_45;
                      case 5:
                        goto label_38;
                      default:
                        // ISSUE: reference to a compiler-generated method
                        if (!this.MainModule.WebReferences.Any<ScriptWebReference>((System.Func<ScriptWebReference, bool>) (q => ScriptCompiler.\u003C\u003Ec__DisplayClass15_0.TJ7akrvq5JlFYqLrLYFH((object) q.Name, (object) webReference.Name))))
                        {
                          num9 = 3;
                          continue;
                        }
                        goto label_33;
                    }
                  }
label_34:
                  num9 = 4;
                  goto label_32;
label_38:
                  num9 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
                  {
                    num9 = 1;
                    goto label_32;
                  }
                  else
                    goto label_32;
                }
                finally
                {
                  enumerator4.Dispose();
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
                    num10 = 0;
                  switch (num10)
                  {
                    default:
                  }
                }
label_29:
                current = enumerator2.Current;
                num8 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
                {
                  num8 = 1;
                  goto label_26;
                }
                else
                  goto label_26;
label_46:
                num8 = 2;
                goto label_26;
              }
              finally
              {
                enumerator2.Dispose();
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
                  num11 = 0;
                switch (num11)
                {
                  default:
                }
              }
            case 21:
              enumerator1 = source1.SelectMany<IScriptModule, string>((System.Func<IScriptModule, IEnumerable<string>>) (m => ReferencesListHelper.GetReferences(m.References))).Distinct<string>().GetEnumerator();
              num2 = 12;
              continue;
            case 22:
label_131:
              List<IScriptModule> source3 = source1;
              // ISSUE: reference to a compiler-generated field
              System.Func<IScriptModule, bool> func2 = ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_2;
              System.Func<IScriptModule, bool> predicate;
              if (func2 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_2 = predicate = (System.Func<IScriptModule, bool>) (a => a.GlobalScriptModules != null);
              }
              else
                goto label_149;
label_133:
              IEnumerable<IScriptModule> source4 = source3.Where<IScriptModule>(predicate);
              // ISSUE: reference to a compiler-generated field
              System.Func<IScriptModule, IEnumerable<AssemblyReference>> func3 = ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_3;
              System.Func<IScriptModule, IEnumerable<AssemblyReference>> selector2;
              if (func3 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_3 = selector2 = (System.Func<IScriptModule, IEnumerable<AssemblyReference>>) (a => (IEnumerable<AssemblyReference>) a.GlobalScriptModules);
              }
              else
                goto label_148;
label_135:
              IEnumerable<AssemblyReference> source5 = source4.SelectMany<IScriptModule, AssemblyReference>(selector2);
              // ISSUE: reference to a compiler-generated field
              System.Func<AssemblyReference, Guid> func4 = ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_4;
              System.Func<AssemblyReference, Guid> selector3;
              if (func4 == null)
              {
                // ISSUE: reference to a compiler-generated field
                ScriptCompiler.\u003C\u003Ec.\u003C\u003E9__15_4 = selector3 = (System.Func<AssemblyReference, Guid>) (r => r.Uid);
              }
              else
                goto label_147;
label_137:
              this.AddGlobalScriptModules((ICollection<Guid>) source5.Select<AssemblyReference, Guid>(selector3).ToHashSet<Guid>());
              num2 = 7;
              continue;
label_147:
              selector3 = func4;
              goto label_137;
label_148:
              selector2 = func3;
              goto label_135;
label_149:
              predicate = func2;
              goto label_133;
            case 23:
              try
              {
label_84:
                if (enumerator2.MoveNext())
                  goto label_88;
                else
                  goto label_85;
label_75:
                string sourceFileName;
                IScriptModule current1;
                List<RootCodeItem>.Enumerator enumerator5;
                int num12;
                while (true)
                {
                  switch (num12)
                  {
                    case 1:
                      ScriptCompiler.ecKf7nhD1trWLCLK7PJw((object) this, ScriptCompiler.C2MIXihDtG8GiCAALj20((object) current1), (object) sourceFileName);
                      num12 = 6;
                      continue;
                    case 2:
                      this.moduleFileNames[sourceFileName] = new ScriptCompiler.ScripModuleBinding(current1);
                      num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 0;
                      continue;
                    case 3:
                      enumerator5 = ((RootCodeItemCollection) ScriptCompiler.b6MdLNhDwPLOugMXnKky((object) current1)).Items.GetEnumerator();
                      num12 = 11;
                      continue;
                    case 4:
                      sourceFileName = this.GetSourceFileName((string) ScriptCompiler.CuLl61hDPEUhJkddGxbA(-1837662597 ^ -1837887807), z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272560187));
                      num12 = 2;
                      continue;
                    case 5:
                    case 8:
                      goto label_84;
                    case 6:
                      if (current1.CodeItems != null)
                      {
                        num12 = 10;
                        continue;
                      }
                      goto label_84;
                    case 7:
                      goto label_107;
                    case 9:
                      if (current1.CodeItems.Items.Any<RootCodeItem>())
                      {
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 3;
                        continue;
                      }
                      goto label_84;
                    case 10:
                      if (((RootCodeItemCollection) ScriptCompiler.b6MdLNhDwPLOugMXnKky((object) current1)).Items == null)
                      {
                        num12 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 8 : 0;
                        continue;
                      }
                      goto case 9;
                    case 11:
                      goto label_89;
                    default:
                      goto label_88;
                  }
                }
label_89:
                try
                {
label_95:
                  if (enumerator5.MoveNext())
                    goto label_91;
                  else
                    goto label_96;
label_90:
                  RootCodeItem current2;
                  int num13;
                  while (true)
                  {
                    switch (num13)
                    {
                      case 1:
                        goto label_95;
                      case 2:
                        sourceFileName = this.GetSourceFileName(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886421707), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121220933));
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 3;
                        continue;
                      case 3:
                        this.moduleFileNames[sourceFileName] = new ScriptCompiler.ScripModuleBinding(current1, current2);
                        num13 = 5;
                        continue;
                      case 4:
                        goto label_91;
                      case 5:
                        ScriptCompiler.ecKf7nhD1trWLCLK7PJw((object) this, ScriptCompiler.VNCmBMhD498WNCygZjKR((object) current2), (object) sourceFileName);
                        num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 1 : 1;
                        continue;
                      default:
                        goto label_84;
                    }
                  }
label_91:
                  current2 = enumerator5.Current;
                  num13 = 2;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                  {
                    num13 = 1;
                    goto label_90;
                  }
                  else
                    goto label_90;
label_96:
                  num13 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
                  goto label_90;
                }
                finally
                {
                  enumerator5.Dispose();
                  int num14 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
                    num14 = 0;
                  switch (num14)
                  {
                    default:
                  }
                }
label_85:
                num12 = 7;
                goto label_75;
label_88:
                current1 = enumerator2.Current;
                num12 = 4;
                goto label_75;
              }
              finally
              {
                enumerator2.Dispose();
                int num15 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0)
                  num15 = 0;
                switch (num15)
                {
                  default:
                }
              }
            default:
              try
              {
label_59:
                if (ScriptCompiler.bAuZGchD3VI1bWVKJjdN((object) enumerator3))
                  goto label_63;
                else
                  goto label_60;
label_58:
                KeyValuePair<string, ScriptCompiler.ScripModuleBinding> current;
                int num16;
                while (true)
                {
                  switch (num16)
                  {
                    case 1:
                    case 3:
                      goto label_59;
                    case 2:
                    case 5:
                      ScriptCompiler.F20aQJhDxDPhh40Cy7rg(ScriptCompiler.yMq82vhD7x3sswpgrWkx((object) current.Value), (object) current.Key);
                      num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 1 : 1;
                      continue;
                    case 4:
                      if (current.Value.CodeItem != null)
                      {
                        num16 = 2;
                        continue;
                      }
                      break;
                    case 6:
                      goto label_63;
                    case 7:
                      goto label_111;
                  }
                  ScriptCompiler.MdkOWChDAr9JHmjoMLeG(ScriptCompiler.KsEdethDHEoLBEaQETnb((object) current.Value), (object) current.Key);
                  num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 3 : 3;
                }
label_60:
                num16 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 6 : 7;
                goto label_58;
label_63:
                current = enumerator3.Current;
                num16 = 4;
                goto label_58;
              }
              finally
              {
                int num17;
                if (enumerator3 == null)
                  num17 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 1 : 1;
                else
                  goto label_69;
label_68:
                switch (num17)
                {
                  case 1:
                  case 2:
                }
label_69:
                ScriptCompiler.KdoeqkhDDBRxkgEia4aT((object) enumerator3);
                num17 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
                {
                  num17 = 1;
                  goto label_68;
                }
                else
                  goto label_68;
              }
          }
          num2 = num3;
        }
      }
      finally
      {
        if (lockTaken)
        {
          int num18 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
            num18 = 0;
          while (true)
          {
            switch (num18)
            {
              case 1:
                goto label_143;
              default:
                ScriptCompiler.fns7rRhDmqLUGGTObpA7((object) scriptCompiler);
                num18 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 1 : 1;
                continue;
            }
          }
        }
label_143:;
      }
label_145:
      return scriptCompileResult1;
    }

    /// <summary>Компилируемые модули сценариев</summary>
    public IList<IScriptModule> Modules => (IList<IScriptModule>) this.modules;

    /// <summary>Обработать ошибки компиляции</summary>
    /// <param name="diagnostics">Результат сборки</param>
    protected override void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
    {
      this.SaveSourceCodes();
      StringBuilder errorMessages = new StringBuilder();
      this.messages.AddRange(diagnostics.Where<Diagnostic>((System.Func<Diagnostic, bool>) (x =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (ScriptCompiler.\u003C\u003Ec.WuCNdavqs2wXeyyMhOEa((object) x) == DiagnosticSeverity.Warning)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              if (x.Severity != DiagnosticSeverity.Error)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_2;
          }
        }
label_2:
        // ISSUE: reference to a compiler-generated method
        return x.Id != (string) ScriptCompiler.\u003C\u003Ec.zeAgjGvqcFL2Fruk7vBv(1012087039 ^ 1012306981);
label_3:
        return false;
      })).Select<Diagnostic, ScriptCompileMessage>((Func<Diagnostic, int, ScriptCompileMessage>) ((err, i) =>
      {
        int num = 1;
        ScriptCompiler.ScripModuleBinding scripModuleBinding;
        while (true)
        {
          switch (num)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              if (!ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.gVHd6xvKo0eZ3lPEknE1((object) ScriptCompiler.ScriptCompilerLogger))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            case 3:
              // ISSUE: reference to a compiler-generated method
              ((StringBuilder) ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.UP1kbgvKbaNZmwKc9PWN((object) errorMessages)).Append((object) err);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 2 : 2;
              continue;
            case 4:
              goto label_6;
            default:
              IDictionary<string, ScriptCompiler.ScripModuleBinding> moduleFileNames = this.moduleFileNames;
              // ISSUE: reference to a compiler-generated method
              string filePath = ((Location) ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo((object) err))?.FilePath;
              string key = filePath == null ? "" : filePath;
              ref ScriptCompiler.ScripModuleBinding local = ref scripModuleBinding;
              moduleFileNames.TryGetValue(key, out local);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 4 : 4;
              continue;
          }
        }
label_6:
        ScriptCompileMessage scriptCompileMessage = new ScriptCompileMessage();
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.TJYFPQvKGYNa2xTOVy8b((object) scriptCompileMessage, i + 1);
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.sAANUFvKEfmZkAaEkAAB((object) scriptCompileMessage, err.Severity == DiagnosticSeverity.Warning ? ScriptCompileMessageType.Warning : ScriptCompileMessageType.Error);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.sfYLhhvKQtK9MvHsaAd1((object) scriptCompileMessage, ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.f1RS8HvKfdLBUuvwh32e((object) err));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.GT1elJvKvjFLKrW2rIaC((object) scriptCompileMessage, err.Location == null ? 0 : ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.XPKZS3vKCjFN3yGcm1Hv(ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo((object) err)));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.JuXnM9vK80SWOntvdwfw((object) scriptCompileMessage, ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo((object) err) == null ? 0 : ((Location) ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.NasOtgvKh79m0Nyqyclo((object) err)).Character);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.VIbFM7vKI7oAvEvJlVTX((object) scriptCompileMessage, scripModuleBinding == null ? Guid.Empty : ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.SIK3iQvKumjPRbecvW7e(ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.Q1Fgk4vKZrjJIkuKGIVs((object) scripModuleBinding)));
        // ISSUE: reference to a compiler-generated method
        scriptCompileMessage.ObjectUid = scripModuleBinding != null ? ((IScriptModule) ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.Q1Fgk4vKZrjJIkuKGIVs((object) scripModuleBinding)).ObjectUid : Guid.Empty;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.IxoL0gvKiPkjYC4Sg1tG((object) scriptCompileMessage, scripModuleBinding == null || ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.psJjnZvKVtZlgGgVklYo((object) scripModuleBinding) == null ? Guid.Empty : ScriptCompiler.\u003C\u003Ec__DisplayClass19_0.CmpJ6HvKSXt86SP7x8pw((object) scripModuleBinding.CodeItem));
        return scriptCompileMessage;
      })));
      if (!ScriptCompiler.ScriptCompilerLogger.IsErrorEnabled())
        return;
      errorMessages.AppendLine().Append(new StackTrace(3, true).ToString().TrimEnd());
      ScriptCompiler.ScriptCompilerLogger.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1142330761 ^ 1541959139 ^ 536624746), (object) errorMessages));
    }

    /// <summary>Обработать результаты компиляции</summary>
    protected virtual void ProcessResults()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (!(this.singleModule is ScriptModule))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
            goto label_2;
          case 3:
            ScriptModule singleModule = this.singleModule as ScriptModule;
            ScriptCompiler.Rl2EkohDytQ0xGmqDhio((object) singleModule, (object) this.AssemblyRaw);
            ScriptCompiler.lNu1OUhDMstVd4O71Vly((object) singleModule, (object) this.DebugRaw);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 2;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    private void AddGlobalScriptModules(ICollection<Guid> globalModulesReferenceUids)
    {
      if (globalModulesReferenceUids.Count == 0)
        return;
      if (this.RuntimeApplication != null)
      {
        string parameterSeparator = this.RuntimeApplication.TransformationProvider.ParameterSeparator;
        Dialect dialect = this.RuntimeApplication.TransformationProvider.Dialect;
        string str1 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121011707).Substring(1));
        string str2 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~210725948 ^ -210509041).Substring(1));
        string str3 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477167032));
        string str4 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 1360493703));
        string str5 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138926426));
        string str6 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(87862435 ^ 87841331));
        string str7 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236117855));
        string str8 = dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372667689));
        // ISSUE: reference to a compiler-generated method
        using (IDataReader reader = this.RuntimeApplication.TransformationProvider.ExecuteQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1581325282 << 3 ^ -234115098) + str8 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822859360) + str1 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669093249) + str2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420902630) + str5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825237334) + str4 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-688192331 - 435440695 ^ -1123614284) + str6 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487195798) + str5 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1642859704 ^ 1643085208) + str7 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(~541731958 ^ -541610541) + str3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(1051802738 - -1831968059 ^ -1411333781) + string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70006001), globalModulesReferenceUids.Select<Guid, string>((Func<Guid, int, string>) ((_, i) => parameterSeparator + ScriptCompiler.\u003C\u003Ec__DisplayClass25_0.MWHm59vKTYGstY302VA7(1669212571 ^ 1669260099) + (object) i))) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137456526), globalModulesReferenceUids.Select<Guid, (Guid, int)>((Func<Guid, int, (Guid, int)>) ((u, i) => (u, i))).ToDictionary<(Guid, int), string, object>((System.Func<(Guid, int), string>) (p => z2jc63fLkugS1X8Q9N.tE1kD1vbB(1251470110 >> 2 ^ 312815647) + (object) p.index), (System.Func<(Guid, int), object>) (p => (object) p.uid))))
        {
          while (reader.Read())
            this.AddReference(reader.GetStream(0));
        }
      }
      else
      {
        foreach (Guid modulesReferenceUid in (IEnumerable<Guid>) globalModulesReferenceUids)
        {
          string globalModuleAssembly = this.GlobalModulesReferenceService.CreateGlobalModuleAssembly(modulesReferenceUid);
          if (globalModuleAssembly != null)
            this.AddReference(globalModuleAssembly);
        }
      }
    }

    static ScriptCompiler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ScriptCompiler.B4lpJ1hD2tyHvcfs8Lh3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            ScriptCompiler.ScriptCompilerLogger = (ILogger) ScriptCompiler.oDNLkhhD9AK1oKCJKtCo(ScriptCompiler.yDmXOahDJKnGIUyrpnYK(__typeref (ScriptCompiler)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object guF0XyhDOj0dfCNiUkvO() => (object) StringComparer.CurrentCultureIgnoreCase;

    internal static bool GbCcEfhDkiUy0cHepUA8() => ScriptCompiler.F8VjoQhDTStnpiNWkkWb == null;

    internal static ScriptCompiler u1BHx5hDnpNd59SLMRds() => ScriptCompiler.F8VjoQhDTStnpiNWkkWb;

    internal static void B4lpJ1hD2tyHvcfs8Lh3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void guHNXPhDeHXkEyVqP4U9([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static object CuLl61hDPEUhJkddGxbA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void ecKf7nhD1trWLCLK7PJw([In] object obj0, [In] object obj1, [In] object obj2) => ((AssemblyBuilder) obj0).AddSourceCodeWithName((string) obj1, (string) obj2);

    internal static void aUJTdOhDNfyZAb2EeEN2([In] object obj0) => ((AssemblyBuilder) obj0).AddAllElmaReferences();

    internal static bool bAuZGchD3VI1bWVKJjdN([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static bool XWUSpFhDpoul6yariy1O([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReferenceByName((string) obj1);

    internal static void VyTuoshDawt9gedvimGT([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddGlobalReference((string) obj1);

    internal static void KdoeqkhDDBRxkgEia4aT([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object C2MIXihDtG8GiCAALj20([In] object obj0) => (object) ((IScriptModule) obj0).SourceCode;

    internal static object b6MdLNhDwPLOugMXnKky([In] object obj0) => (object) ((IScriptModule) obj0).CodeItems;

    internal static object VNCmBMhD498WNCygZjKR([In] object obj0) => (object) ((RootCodeItem) obj0).SourceCode;

    internal static void x8mDm9hD6miRu5u7vPY6([In] object obj0) => ((ScriptCompiler) obj0).ProcessResults();

    internal static object KsEdethDHEoLBEaQETnb([In] object obj0) => (object) ((ScriptCompiler.ScripModuleBinding) obj0).Module;

    internal static void MdkOWChDAr9JHmjoMLeG([In] object obj0, [In] object obj1) => ((IScriptModule) obj0).CompiledFileName = (string) obj1;

    internal static object yMq82vhD7x3sswpgrWkx([In] object obj0) => (object) ((ScriptCompiler.ScripModuleBinding) obj0).CodeItem;

    internal static void F20aQJhDxDPhh40Cy7rg([In] object obj0, [In] object obj1) => ((RootCodeItem) obj0).CompiledFileName = (string) obj1;

    internal static void xN1jPhhD0GIxk8HKogtP([In] object obj0, bool value) => ((ScriptCompileResult) obj0).Success = value;

    internal static void fns7rRhDmqLUGGTObpA7([In] object obj0) => Monitor.Exit(obj0);

    internal static void Rl2EkohDytQ0xGmqDhio([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).AssemblyRaw = (byte[]) obj1;

    internal static void lNu1OUhDMstVd4O71Vly([In] object obj0, [In] object obj1) => ((ScriptModule) obj0).DebugRaw = (byte[]) obj1;

    internal static Type yDmXOahDJKnGIUyrpnYK([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object oDNLkhhD9AK1oKCJKtCo(Type componentType) => (object) EleWise.ELMA.Logging.Logger.GetLogger(componentType);

    protected class ScripModuleBinding
    {
      internal static ScriptCompiler.ScripModuleBinding Hgx1MvvqMdAGT0DjBaDB;

      public ScripModuleBinding(IScriptModule module)
      {
        ScriptCompiler.ScripModuleBinding.goj0JyvqdMYIuNn8shvc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.Module = module;
              num = 2;
              continue;
            case 2:
              this.CodeItem = (RootCodeItem) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 0 : 0;
              continue;
            default:
              goto label_6;
          }
        }
label_3:
        return;
label_6:;
      }

      public ScripModuleBinding(IScriptModule module, RootCodeItem codeItem)
      {
        ScriptCompiler.ScripModuleBinding.goj0JyvqdMYIuNn8shvc();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.CodeItem = codeItem;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
              continue;
            case 2:
              this.Module = module;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 1 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      public IScriptModule Module
      {
        get => this.\u003CModule\u003Ek__BackingField;
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
                this.\u003CModule\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
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

      public RootCodeItem CodeItem
      {
        get => this.\u003CCodeItem\u003Ek__BackingField;
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
                this.\u003CCodeItem\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

      internal static void goj0JyvqdMYIuNn8shvc() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool ihkFUkvqJKyqKIGjmXCd() => ScriptCompiler.ScripModuleBinding.Hgx1MvvqMdAGT0DjBaDB == null;

      internal static ScriptCompiler.ScripModuleBinding b7ZBTKvq9H3eNrkDtpQ8() => ScriptCompiler.ScripModuleBinding.Hgx1MvvqMdAGT0DjBaDB;
    }
  }
}

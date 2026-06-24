// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Configuration;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scripts;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.Diagnostics;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web.Configuration;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Базовый класс для построителей сборок</summary>
  public class AssemblyBuilder : IDisposable
  {
    private IRuntimeApplication runtimeApplication;
    private IEnumerable<IReferenceProvider> referenceProviders;
    private readonly Lazy<string> tempDir;
    private readonly ISet<string> fileNames;
    private HashSet<string> _references;
    private HashSet<Assembly> _referencedAssemblies;
    private readonly List<MemoryStream> referencedAssemblyRaws;
    private HashSet<string> _referenceNames;
    private List<AssemblyBuilder.SourceCode> _sourceCodes;
    private Dictionary<string, byte[]> _embeddedResources;
    private byte[] assemblyRaw;
    private MemoryStream assemblyRawStream;
    private byte[] documentationRaw;
    private MemoryStream documentationRawStream;
    private byte[] debugRaw;
    private MemoryStream debugRawStream;
    private static HashSet<string> elmaAssemblies;
    private List<DiagnosticAnalyzer> analyzers;
    private bool disposed;
    private static ConcurrentDictionary<string, Tuple<DateTime, long, MetadataReference>> fileReferences;
    private static AssemblyBuilder FBF21fhpGakSivTQiG7a;

    /// <summary>Имя генерируемой сборки</summary>
    public string AssemblyName
    {
      get => this.\u003CAssemblyName\u003Ek__BackingField;
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
              this.\u003CAssemblyName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
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

    /// <summary>Информация о среде исполнения</summary>
    private IRuntimeApplication RuntimeApplication
    {
      get
      {
        int num = 2;
        IRuntimeApplication service;
        IRuntimeApplication runtimeApplication;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.runtimeApplication = service = AssemblyBuilder.Bhi4xshpQcIFE0dawrt2() ? Locator.GetService<IRuntimeApplication>() : (IRuntimeApplication) null;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0 ? 0 : 0;
              continue;
            case 2:
              runtimeApplication = this.runtimeApplication;
              if (runtimeApplication == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 1;
                continue;
              }
              goto label_2;
            default:
              goto label_6;
          }
        }
label_2:
        return runtimeApplication;
label_6:
        return service;
      }
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
              this.runtimeApplication = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
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

    /// <summary>Провайдер ссылок</summary>
    private IEnumerable<IReferenceProvider> ReferenceProviders
    {
      get => this.referenceProviders ?? (this.referenceProviders = ComponentManager.Current.GetExtensionPoints<IReferenceProvider>());
      set => this.referenceProviders = value;
    }

    /// <summary>
    /// Публичный ключ, которым будет подписана генерируемая сборка
    /// </summary>
    public byte[] PublicKey
    {
      get => this.\u003CPublicKey\u003Ek__BackingField;
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
              this.\u003CPublicKey\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
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

    /// <summary>Токен отмены</summary>
    public CancellationToken CancellationToken
    {
      get => this.\u003CCancellationToken\u003Ek__BackingField;
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
              this.\u003CCancellationToken\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
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

    /// <summary>Добавить ссылки на сборки по умолчанию</summary>
    public virtual void AddDefaultReferences()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.AddReferences((IEnumerable<IReferenceProviderBase>) this.ReferenceProviders);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.AddDefaultReferencesFromElmaConfig((string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(~-122002947 ^ 122091006));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
            continue;
          default:
            this.AddDefaultReferencesFromConfig((string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1822890472 ^ -1822716444));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Добавить ссылки на все сборки ELMA</summary>
    public virtual void AddAllElmaReferences()
    {
      int num1 = 12;
      while (true)
      {
        int num2 = num1;
        List<string> list;
        List<string>.Enumerator enumerator1;
        string str1;
        Assembly[] assemblyArray;
        int index;
        Assembly assembly;
        string str2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              try
              {
label_15:
                if (enumerator1.MoveNext())
                  goto label_11;
                else
                  goto label_16;
label_10:
                string current1;
                IEnumerator<string> enumerator2;
                int num3;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_44;
                    case 1:
                      goto label_45;
                    case 2:
                      if (AssemblyBuilder.KkRhd5hpZ1I3J3MHNqyj((object) current1))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 5 : 4;
                        continue;
                      }
                      goto label_38;
                    case 3:
                      goto label_11;
                    case 4:
                      goto label_17;
                    case 5:
                    case 6:
                      enumerator2 = ((IEnumerable<string>) Directory.GetFiles(current1, (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(1669212571 ^ 1669295453))).Union<string>((IEnumerable<string>) AssemblyBuilder.T5ifyghpu0dcVG05lFSD((object) current1, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(1925118608 << 2 ^ -889682338))).GetEnumerator();
                      num3 = 4;
                      continue;
                    case 7:
                      goto label_15;
                    default:
                      goto label_37;
                  }
                }
label_44:
                return;
label_37:
                return;
label_38:
                return;
label_17:
                try
                {
label_19:
                  if (AssemblyBuilder.PnTAsShpV09df55rTsxZ((object) enumerator2))
                    goto label_21;
                  else
                    goto label_20;
label_18:
                  string current2;
                  int num4;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        goto label_21;
                      case 2:
                        AssemblyBuilder.elmaAssemblies.Add((string) AssemblyBuilder.gFClR1hpIWkaN4XtN9bi((object) current2));
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0 ? 0 : 0;
                        continue;
                      case 3:
                        goto label_15;
                      default:
                        goto label_19;
                    }
                  }
label_20:
                  num4 = 3;
                  goto label_18;
label_21:
                  current2 = enumerator2.Current;
                  num4 = 2;
                  goto label_18;
                }
                finally
                {
                  int num5;
                  if (enumerator2 == null)
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 0 : 0;
                  else
                    goto label_26;
label_25:
                  switch (num5)
                  {
                    case 2:
                      break;
                    default:
                  }
label_26:
                  AssemblyBuilder.tAM9WjhpS4bs2XrbYpaA((object) enumerator2);
                  num5 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
                  {
                    num5 = 1;
                    goto label_25;
                  }
                  else
                    goto label_25;
                }
label_11:
                current1 = enumerator1.Current;
                num3 = 2;
                goto label_10;
label_16:
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
                goto label_10;
              }
              finally
              {
                enumerator1.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
            case 2:
              if (!AssemblyBuilder.XojJMYhpTAWEvMubFfZs((object) str2, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239576996)))
              {
                num2 = 8;
                continue;
              }
              goto default;
            case 3:
              str2 = (string) AssemblyBuilder.GsyvvZhpqMSCTx5M7UZ1((object) assembly);
              num2 = 6;
              continue;
            case 4:
              if (!AssemblyBuilder.fV1oR4hpR9MOMp7OQ1IU((object) assembly))
              {
                num2 = 3;
                continue;
              }
              goto case 5;
            case 5:
            case 7:
            case 8:
            case 22:
            case 26:
              ++index;
              num2 = 9;
              continue;
            case 6:
              if (!AssemblyBuilder.WtO2JnhpXsH8jk2KuwEN(AssemblyBuilder.FMevcAhpK1GuqjdF9Dhs((object) assembly)))
              {
                num2 = 23;
                continue;
              }
              goto case 5;
            case 9:
            case 24:
              if (index >= assemblyArray.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 17 : 6;
                continue;
              }
              goto case 28;
            case 10:
            case 18:
label_45:
              assemblyArray = (Assembly[]) AssemblyBuilder.X1rYLshpi5ZdVKpXe57J();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 20 : 8;
              continue;
            case 11:
              if (AssemblyBuilder.elmaAssemblies != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 10 : 8;
                continue;
              }
              goto case 21;
            case 12:
              if (ComponentManager.Initialized)
              {
                num2 = 11;
                continue;
              }
              goto case 10;
            case 13:
              if (!AssemblyBuilder.elmaAssemblies.Contains(str2))
              {
                num2 = 7;
                continue;
              }
              goto case 14;
            case 14:
              AssemblyBuilder.g1EFALhpk1151nQsQa8W((object) this, (object) assembly.Location);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 5 : 22;
              continue;
            case 15:
              str1 = (string) AssemblyBuilder.MaYP2bhp8cx97MPpo7xA((object) ComponentManager.Current.WorkDirectory, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1598106783 - -968262081 ^ -629930678));
              num2 = 27;
              continue;
            case 16:
              list = ((IEnumerable<string>) AssemblyBuilder.PXrSMFhpv8D5FZMSTYg0((object) ComponentManager.Current)).ToList<string>();
              num2 = 15;
              continue;
            case 17:
              goto label_54;
            case 19:
              enumerator1 = list.GetEnumerator();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 1 : 0;
              continue;
            case 20:
              goto label_50;
            case 21:
              AssemblyBuilder.elmaAssemblies = new HashSet<string>((IEqualityComparer<string>) StringComparer.CurrentCultureIgnoreCase);
              num2 = 16;
              continue;
            case 23:
              if (AssemblyBuilder.XojJMYhpTAWEvMubFfZs((object) str2, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-35995181 ^ -35992649)))
                goto case 2;
              else
                goto label_60;
            case 25:
              list.Add(str1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 19 : 7;
              continue;
            case 27:
              if (!AssemblyBuilder.KkRhd5hpZ1I3J3MHNqyj((object) str1))
                goto case 19;
              else
                goto label_47;
            case 28:
              assembly = assemblyArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 4 : 4;
              continue;
            default:
              if (AssemblyBuilder.elmaAssemblies == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 2 : 5;
                continue;
              }
              goto case 13;
          }
        }
label_47:
        num1 = 25;
        continue;
label_50:
        index = 0;
        num1 = 24;
        continue;
label_60:
        num1 = 26;
      }
label_54:;
    }

    /// <summary>
    /// Добавить ссылки на все загруженные в домен сборки, у которых задано свойство Location
    /// </summary>
    public void AddAllAssembliesWithLocation()
    {
      int num = 2;
      int index;
      Assembly[] assemblyArray;
      Assembly assembly;
      string str;
      while (true)
      {
        switch (num)
        {
          case 1:
            index = 0;
            num = 8;
            continue;
          case 2:
            assemblyArray = (Assembly[]) AssemblyBuilder.X1rYLshpi5ZdVKpXe57J();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 1 : 1;
            continue;
          case 3:
            if (str != z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1445902765 ^ -1980277732 ^ 539365419))
            {
              num = 9;
              continue;
            }
            goto case 4;
          case 4:
          case 6:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 8 : 10;
            continue;
          case 5:
            str = (string) AssemblyBuilder.GsyvvZhpqMSCTx5M7UZ1((object) assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 11 : 6;
            continue;
          case 7:
            goto label_10;
          case 8:
          case 10:
            if (index >= assemblyArray.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 7 : 1;
              continue;
            }
            goto case 13;
          case 9:
            if (str != (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(--1867379187 ^ 1867381725))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
              continue;
            }
            goto case 4;
          case 11:
            if (AssemblyBuilder.WtO2JnhpXsH8jk2KuwEN(AssemblyBuilder.FMevcAhpK1GuqjdF9Dhs((object) assembly)))
            {
              num = 4;
              continue;
            }
            goto case 3;
          case 12:
            if (!AssemblyBuilder.fV1oR4hpR9MOMp7OQ1IU((object) assembly))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 5 : 0;
              continue;
            }
            goto case 4;
          case 13:
            assembly = assemblyArray[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 4 : 12;
            continue;
          default:
            AssemblyBuilder.g1EFALhpk1151nQsQa8W((object) this, (object) assembly.Location);
            num = 6;
            continue;
        }
      }
label_10:;
    }

    /// <summary>Добавить исходный код</summary>
    /// <param name="code">Код</param>
    public virtual void AddSourceCode(string code)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            goto label_2;
          case 2:
            if (AssemblyBuilder.WtO2JnhpXsH8jk2KuwEN((object) code))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            }
            goto case 3;
          case 3:
            List<AssemblyBuilder.SourceCode> sourceCodes = this._sourceCodes;
            AssemblyBuilder.SourceCode sourceCode = new AssemblyBuilder.SourceCode();
            AssemblyBuilder.AtuYfHhpnoNr4OUmiQZF((object) sourceCode, (object) code);
            sourceCodes.Add(sourceCode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_6:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>Добавить файл исходного кода</summary>
    /// <param name="fileName">Полное имя файла</param>
    public virtual void AddSourceCodeFile(string fileName)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            List<AssemblyBuilder.SourceCode> sourceCodes = this._sourceCodes;
            AssemblyBuilder.SourceCode sourceCode = new AssemblyBuilder.SourceCode();
            AssemblyBuilder.lyqwZEhpOX3wSviCpqwS((object) sourceCode, (object) fileName);
            sourceCodes.Add(sourceCode);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
            continue;
          case 2:
            if (!AssemblyBuilder.WtO2JnhpXsH8jk2KuwEN((object) fileName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 1;
              continue;
            }
            goto label_7;
          case 3:
            goto label_2;
          default:
            this.fileNames.Add(fileName);
            num = 3;
            continue;
        }
      }
label_2:
      return;
label_7:;
    }

    /// <summary>Добавить файл исходного кода</summary>
    /// <param name="code">Код</param>
    /// <param name="fileName">Имя файла для диагностики</param>
    public virtual void AddSourceCodeWithName(string code, string fileName)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (!string.IsNullOrEmpty(code))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
                continue;
              }
              goto label_8;
            case 2:
              goto label_3;
            case 3:
              this.fileNames.Add(fileName);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 1 : 2;
              continue;
            default:
              goto label_5;
          }
        }
label_5:
        List<AssemblyBuilder.SourceCode> sourceCodes = this._sourceCodes;
        AssemblyBuilder.SourceCode sourceCode = new AssemblyBuilder.SourceCode();
        AssemblyBuilder.AtuYfHhpnoNr4OUmiQZF((object) sourceCode, (object) code);
        sourceCode.FileName = fileName;
        sourceCodes.Add(sourceCode);
        num1 = 3;
      }
label_3:
      return;
label_8:;
    }

    /// <summary>Получить хэш исходного кода</summary>
    /// <returns></returns>
    public virtual string GetSourceCodeHash()
    {
      int num1 = 3;
      MemoryStream inputStream;
      List<AssemblyBuilder.SourceCode> list;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
            List<AssemblyBuilder.SourceCode> sourceCodes = this._sourceCodes;
            // ISSUE: reference to a compiler-generated field
            Comparison<AssemblyBuilder.SourceCode> comparison1 = AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_2;
            Comparison<AssemblyBuilder.SourceCode> comparison2;
            if (comparison1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_2 = comparison2 = (Comparison<AssemblyBuilder.SourceCode>) ((l, r) => AssemblyBuilder.\u003C\u003Ec.JtQ5LOviuOQ7n4UeYZ7Z(AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) l), (object) r.Code));
            }
            else
              goto label_72;
label_67:
            sourceCodes.Sort(comparison2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
            continue;
label_72:
            comparison2 = comparison1;
            goto label_67;
          case 3:
            // ISSUE: reference to a compiler-generated method
            IEnumerable<AssemblyBuilder.SourceCode> enumeration = this._sourceCodes.Where<AssemblyBuilder.SourceCode>((Func<AssemblyBuilder.SourceCode, bool>) (sc => AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) sc) == null));
            // ISSUE: reference to a compiler-generated field
            Action<AssemblyBuilder.SourceCode> action1 = AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_1;
            Action<AssemblyBuilder.SourceCode> action2;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_1 = action2 = (Action<AssemblyBuilder.SourceCode>) (sc =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyBuilder.\u003C\u003Ec.ysyXBOviZPiKVVVncZts((object) sc, AssemblyBuilder.\u003C\u003Ec.DfunG7vi8ixkcySeWGK2(AssemblyBuilder.\u003C\u003Ec.JK6rvWvivKknSqA7LAFt((object) sc), (object) Encoding.UTF8));
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_73;
label_64:
            enumeration.ForEach<AssemblyBuilder.SourceCode>(action2);
            num1 = 2;
            continue;
label_73:
            action2 = action1;
            goto label_64;
          case 4:
            inputStream = (MemoryStream) AssemblyBuilder.LWLbrHhp27nEGXQBPLgD();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            Dictionary<string, byte[]> embeddedResources = this._embeddedResources;
            // ISSUE: reference to a compiler-generated field
            Func<KeyValuePair<string, byte[]>, AssemblyBuilder.SourceCode> func1 = AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_3;
            Func<KeyValuePair<string, byte[]>, AssemblyBuilder.SourceCode> selector1;
            if (func1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_3 = selector1 = (Func<KeyValuePair<string, byte[]>, AssemblyBuilder.SourceCode>) (resource => new AssemblyBuilder.SourceCode()
              {
                FileName = resource.Key,
                Code = Convert.ToBase64String(resource.Value)
              });
            }
            else
              goto label_60;
label_70:
            list = embeddedResources.Select<KeyValuePair<string, byte[]>, AssemblyBuilder.SourceCode>(selector1).OrderBy<AssemblyBuilder.SourceCode, string>((Func<AssemblyBuilder.SourceCode, string>) (r => r.Code)).ToList<AssemblyBuilder.SourceCode>();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 4 : 4;
            continue;
label_60:
            selector1 = func1;
            goto label_70;
        }
      }
label_2:
      string sourceCodeHash;
      return sourceCodeHash;
label_4:
      try
      {
        StreamWriter streamWriter1 = new StreamWriter((Stream) inputStream);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            try
            {
              AssemblyBuilder.HhGlyqhpPCf1DgHFeE9Z((object) streamWriter1, AssemblyBuilder.rpKnaVhpebLllViSqwR9((object) this._sourceCodes.Count<AssemblyBuilder.SourceCode>(), AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(1642859704 ^ 1642861034)));
              int num4 = 2;
              List<AssemblyBuilder.SourceCode>.Enumerator enumerator;
              SHA1 shA1;
              while (true)
              {
                switch (num4)
                {
                  case 1:
                    shA1 = (SHA1) AssemblyBuilder.d4MPmQhp3ohNjSFAvZvf();
                    num4 = 3;
                    continue;
                  case 2:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AssemblyBuilder.HhGlyqhpPCf1DgHFeE9Z((object) streamWriter1, (object) (this._sourceCodes.Sum<AssemblyBuilder.SourceCode>((Func<AssemblyBuilder.SourceCode, int>) (s => AssemblyBuilder.\u003C\u003Ec.vvZF7AviIkinCTaI8ZtT(AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) s)))).ToString() + AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-2107978722 ^ -2107977396)));
                    num4 = 4;
                    continue;
                  case 3:
                    goto label_40;
                  case 4:
                    enumerator = this._sourceCodes.GetEnumerator();
                    num4 = 6;
                    continue;
                  case 5:
                    try
                    {
label_26:
                      if (enumerator.MoveNext())
                        goto label_24;
                      else
                        goto label_27;
label_23:
                      AssemblyBuilder.SourceCode current;
                      int num5;
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            goto label_21;
                          case 2:
                            goto label_26;
                          case 3:
                            AssemblyBuilder.mDdUyGhp1vF0Fm0yjT5K((object) streamWriter1, (object) current.ToString());
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 1 : 2;
                            continue;
                          default:
                            goto label_24;
                        }
                      }
label_24:
                      current = enumerator.Current;
                      num5 = 3;
                      goto label_23;
label_27:
                      num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 0 : 1;
                      goto label_23;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num6 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
                        num6 = 0;
                      switch (num6)
                      {
                        default:
                      }
                    }
                  case 6:
                    try
                    {
label_13:
                      if (enumerator.MoveNext())
                        goto label_16;
                      else
                        goto label_14;
label_12:
                      AssemblyBuilder.SourceCode current;
                      int num7;
                      while (true)
                      {
                        switch (num7)
                        {
                          case 1:
                            goto label_34;
                          case 2:
                            goto label_13;
                          case 3:
                            AssemblyBuilder.mDdUyGhp1vF0Fm0yjT5K((object) streamWriter1, (object) current.ToString());
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 2 : 2;
                            continue;
                          default:
                            goto label_16;
                        }
                      }
label_14:
                      num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                      goto label_12;
label_16:
                      current = enumerator.Current;
                      num7 = 3;
                      goto label_12;
                    }
                    finally
                    {
                      enumerator.Dispose();
                      int num8 = 0;
                      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                        num8 = 0;
                      switch (num8)
                      {
                        default:
                      }
                    }
                  case 7:
                    StreamWriter streamWriter2 = streamWriter1;
                    List<AssemblyBuilder.SourceCode> source1 = list;
                    // ISSUE: reference to a compiler-generated field
                    Func<AssemblyBuilder.SourceCode, int> func2 = AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_6;
                    Func<AssemblyBuilder.SourceCode, int> selector2;
                    if (func2 == null)
                    {
                      // ISSUE: reference to a compiler-generated field
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__28_6 = selector2 = (Func<AssemblyBuilder.SourceCode, int>) (source => AssemblyBuilder.\u003C\u003Ec.vvZF7AviIkinCTaI8ZtT(AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) source)));
                    }
                    else
                      goto label_71;
label_39:
                    object obj = AssemblyBuilder.rpKnaVhpebLllViSqwR9((object) source1.Sum<AssemblyBuilder.SourceCode>(selector2), AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(381945751 ^ 1158627804 ^ 1405836057));
                    AssemblyBuilder.HhGlyqhpPCf1DgHFeE9Z((object) streamWriter2, obj);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 0 : 0;
                    continue;
label_71:
                    selector2 = func2;
                    goto label_39;
                  case 8:
label_34:
                    AssemblyBuilder.HhGlyqhpPCf1DgHFeE9Z((object) streamWriter1, AssemblyBuilder.rpKnaVhpebLllViSqwR9((object) AssemblyBuilder.SiBTN5hpNDTPBWELCoT7((object) list), AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-740338220 ^ -740341626)));
                    num4 = 7;
                    continue;
                  case 9:
                    inputStream.Seek(0L, SeekOrigin.Begin);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
                    continue;
                  case 10:
label_21:
                    streamWriter1.Flush();
                    num4 = 9;
                    continue;
                  default:
                    enumerator = list.GetEnumerator();
                    num4 = 5;
                    continue;
                }
              }
label_40:
              try
              {
                sourceCodeHash = (string) AssemblyBuilder.mDj3pOhppkfNiqAxXp2H((object) shA1.ComputeHash((Stream) inputStream));
                int num9 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
                  num9 = 0;
                switch (num9)
                {
                  default:
                    goto label_2;
                }
              }
              finally
              {
                if (shA1 != null)
                {
                  int num10 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                    num10 = 0;
                  while (true)
                  {
                    switch (num10)
                    {
                      case 1:
                        goto label_48;
                      default:
                        AssemblyBuilder.tAM9WjhpS4bs2XrbYpaA((object) shA1);
                        num10 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 1;
                        continue;
                    }
                  }
                }
label_48:;
              }
            }
            finally
            {
              if (streamWriter1 != null)
              {
                int num11 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
                  num11 = 0;
                while (true)
                {
                  switch (num11)
                  {
                    case 1:
                      goto label_54;
                    default:
                      AssemblyBuilder.tAM9WjhpS4bs2XrbYpaA((object) streamWriter1);
                      num11 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 1 : 1;
                      continue;
                  }
                }
              }
label_54:;
            }
        }
      }
      finally
      {
        int num12;
        if (inputStream == null)
          num12 = 2;
        else
          goto label_58;
label_57:
        switch (num12)
        {
          case 1:
          case 2:
        }
label_58:
        inputStream.Dispose();
        num12 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
        {
          num12 = 1;
          goto label_57;
        }
        else
          goto label_57;
      }
    }

    /// <summary>
    /// Добавить ссылку на сборку по полному пути до файла сборки
    /// </summary>
    /// <param name="assemblyFileName">Полный путь до файла сборки</param>
    public virtual void AddReference(string assemblyFileName)
    {
      int num = 2;
      string fileName;
      while (true)
      {
        switch (num)
        {
          case 1:
            Contract.ArgumentNotNullOrEmpty(assemblyFileName, (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1876063057 ^ -1875976061));
            num = 4;
            continue;
          case 2:
            AssemblyBuilder.SFDpObhparY6r5PkKhqe((object) assemblyFileName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1255365154 ^ 596875508 ^ -1766043386));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
          case 3:
            this._references.Add(assemblyFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 5;
            continue;
          case 4:
            fileName = Path.GetFileName(assemblyFileName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          default:
            if (this._referenceNames.Add(fileName))
            {
              num = 3;
              continue;
            }
            goto label_9;
        }
      }
label_2:
      return;
label_9:;
    }

    /// <summary>Добавить ссылку на сборку платформы</summary>
    /// <param name="assemblyName">Имя сборки</param>
    public virtual void AddGlobalReference(string assemblyName)
    {
      int num = 1;
      while (true)
      {
        string str;
        switch (num)
        {
          case 1:
            AssemblyBuilder.Np39euhpDEdOiQXpDEJu((object) assemblyName, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(277947046 - -1479185048 ^ 1756942466));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_7;
          case 3:
            if (!this._referenceNames.Add(assemblyName))
            {
              num = 4;
              continue;
            }
            goto case 5;
          case 4:
            goto label_2;
          case 5:
            this._references.Add((string) AssemblyBuilder.MaYP2bhp8cx97MPpo7xA((object) AssemblyReferenceHelper.GlobalAssemblyLocation, (object) assemblyName));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 1 : 2;
            continue;
          case 6:
            str = assemblyName + (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-16752921 ^ -16704931);
            break;
          default:
            if (!AssemblyBuilder.wHor53hptiKJhrZvo2kk((object) assemblyName, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-218496594 ^ -218413804), StringComparison.OrdinalIgnoreCase))
            {
              num = 6;
              continue;
            }
            str = assemblyName;
            break;
        }
        assemblyName = str;
        num = 3;
      }
label_7:
      return;
label_2:;
    }

    /// <summary>Добавить ссылку на сборку</summary>
    /// <param name="assembly">Сборка</param>
    public virtual void AddReference(Assembly assembly)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._referencedAssemblies.Add(assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          case 2:
            AssemblyBuilder.SFDpObhparY6r5PkKhqe((object) assembly, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669225717));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Добавить ссылку на сборку по бинарному коду сборки</summary>
    /// <param name="assemblyRaw">Бинарный код сборки</param>
    public virtual void AddReference(byte[] assemblyRaw)
    {
      int num = 1;
      while (true)
      {
        MemoryStream memoryStream;
        object obj;
        switch (num)
        {
          case 1:
            if (assemblyRaw == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
              continue;
            }
            obj = AssemblyBuilder.QkdShyhpw7kQu19SBJul((object) assemblyRaw, false);
            break;
          case 2:
            goto label_2;
          case 3:
            AssemblyBuilder.J7S20Jhp4Qlf8NYYJIq0((object) this, (object) memoryStream);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 2;
            continue;
          default:
            obj = (object) null;
            break;
        }
        memoryStream = (MemoryStream) obj;
        num = 3;
      }
label_2:;
    }

    /// <summary>Добавить ссылку на сборку по бинарному коду сборки</summary>
    /// <param name="assemblyRaw">Поток, содержащий бинарный код сборки</param>
    public virtual void AddReference(MemoryStream assemblyRaw)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilder.SFDpObhparY6r5PkKhqe((object) assemblyRaw, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(647913418 ^ 647836570));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_9;
          case 3:
            goto label_7;
          case 4:
            if (assemblyRaw.Length <= 0L)
            {
              num = 3;
              continue;
            }
            goto case 5;
          case 5:
            this.referencedAssemblyRaws.Add(assemblyRaw);
            num = 6;
            continue;
          case 6:
            goto label_2;
          default:
            if (assemblyRaw == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
              continue;
            }
            goto case 4;
        }
      }
label_9:
      return;
label_7:
      return;
label_2:;
    }

    /// <summary>Добавить ссылку на сборку по ее имени</summary>
    /// <param name="assemblyName">Имя сборки</param>
    public virtual bool AddReferenceByName(string assemblyName)
    {
      int num1 = 7;
      while (true)
      {
        int num2 = num1;
        MemoryStream memoryStream;
        Assembly assembly;
        string assemblyName1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 14:
              goto label_14;
            case 2:
              if (!(assembly == (Assembly) null))
              {
                if (!assembly.IsDynamic)
                {
                  num2 = 9;
                  continue;
                }
                goto case 11;
              }
              else
                goto label_9;
            case 3:
              goto label_4;
            case 4:
            case 9:
              AssemblyBuilder.GnS7jRhpHwlMLeubvpMe((object) this, (object) assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
              continue;
            case 5:
              AssemblyBuilder.Np39euhpDEdOiQXpDEJu((object) assemblyName1, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(964881585 - -1459193222 ^ -1870719093));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 12 : 5;
              continue;
            case 6:
              assemblyName1 = assemblyName;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 10 : 13;
              continue;
            case 7:
              num2 = 6;
              continue;
            case 8:
              goto label_16;
            case 10:
              if (memoryStream != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 3 : 3;
                continue;
              }
              goto label_3;
            case 11:
              memoryStream = (MemoryStream) AssemblyBuilder.nWqb3Ehp61P9GWtxWXxx((object) assembly);
              num2 = 10;
              continue;
            case 12:
              assembly = ((IEnumerable<Assembly>) ComponentManager.GetAssemblies()).FirstOrDefault<Assembly>((Func<Assembly, bool>) (a =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 1:
                      // ISSUE: reference to a compiler-generated method
                      // ISSUE: reference to a compiler-generated method
                      if (!AssemblyBuilder.\u003C\u003Ec__DisplayClass34_0.FMBovZviaOlgqB7KCuWL(AssemblyBuilder.\u003C\u003Ec__DisplayClass34_0.vTUhaLvipFB3taX2tyYl((object) a), (object) assemblyName1))
                      {
                        num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                        continue;
                      }
                      goto label_5;
                    default:
                      goto label_4;
                  }
                }
label_4:
                // ISSUE: reference to a compiler-generated method
                return AssemblyBuilder.\u003C\u003Ec__DisplayClass34_0.FMBovZviaOlgqB7KCuWL((object) ComponentManager.GetAssemblyShortName(a), (object) assemblyName1);
label_5:
                return true;
              }));
              num2 = 2;
              continue;
            case 13:
              Contract.ArgumentNotNull((object) assemblyName1, (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(1669371371 ^ 1669591127));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 5 : 3;
              continue;
            default:
              goto label_3;
          }
        }
label_4:
        AssemblyBuilder.J7S20Jhp4Qlf8NYYJIq0((object) this, (object) memoryStream);
        num1 = 14;
        continue;
label_9:
        num1 = 8;
      }
label_3:
      return false;
label_14:
      return true;
label_16:
      return false;
    }

    /// <summary>Добавить встроенный ресурс</summary>
    /// <param name="name">Имя ресурса</param>
    /// <param name="data">Данные</param>
    public virtual void AddEmbeddedResource(string name, byte[] data)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            AssemblyBuilder.Np39euhpDEdOiQXpDEJu((object) name, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-688192331 - 435440695 ^ -1123634072));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 4 : 0;
            continue;
          case 3:
            AssemblyBuilder.SFDpObhparY6r5PkKhqe((object) name, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1505778440 - 1981636111 ^ -475860753));
            num = 2;
            continue;
          case 4:
            AssemblyBuilder.SFDpObhparY6r5PkKhqe((object) data, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-2138160520 ^ -2138079352));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          default:
            this._embeddedResources.Add(name, data);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 1 : 0;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Raw подключенных сборок</summary>
    internal IEnumerable<MemoryStream> ReferencedAssemblyRaws => (IEnumerable<MemoryStream>) this.referencedAssemblyRaws;

    /// <summary>Raw сборки (DLL)</summary>
    public byte[] AssemblyRaw
    {
      get
      {
        int num = 1;
        byte[] assemblyRaw1;
        byte[] assemblyRaw2;
        while (true)
        {
          switch (num)
          {
            case 1:
              assemblyRaw2 = this.assemblyRaw;
              if (assemblyRaw2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_6;
            default:
              MemoryStream assemblyRawStream = this.assemblyRawStream;
              this.assemblyRaw = assemblyRaw1 = assemblyRawStream == null ? (byte[]) (object) null : (byte[]) AssemblyBuilder.VxBKmdhpACqRNCBMIACQ((object) assemblyRawStream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 1;
              continue;
          }
        }
label_3:
        return assemblyRaw2;
label_6:
        return assemblyRaw1;
      }
    }

    /// <summary>Поток в памяти, содержащий Raw сборки (DLL)</summary>
    /// <remarks>Свойство доступно только при использовании метода <see cref="M:EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder.BuildToStream(System.Boolean,System.Boolean)" /></remarks>
    public MemoryStream AssemblyRawStream
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              MemoryStream assemblyRawStream = this.assemblyRawStream;
              if (assemblyRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
                continue;
              }
              assemblyRawStream.Seek(0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 2 : 2;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.assemblyRawStream;
      }
    }

    /// <summary>Raw файла XML-документации</summary>
    public byte[] DocumentationRaw
    {
      get
      {
        int num = 1;
        byte[] documentationRaw1;
        byte[] documentationRaw2;
        while (true)
        {
          switch (num)
          {
            case 1:
              documentationRaw2 = this.documentationRaw;
              if (documentationRaw2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
                continue;
              }
              goto label_5;
            case 2:
              goto label_6;
            default:
              MemoryStream documentationRawStream = this.documentationRawStream;
              this.documentationRaw = documentationRaw1 = documentationRawStream == null ? (byte[]) (object) null : (byte[]) AssemblyBuilder.VxBKmdhpACqRNCBMIACQ((object) documentationRawStream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 2 : 2;
              continue;
          }
        }
label_5:
        return documentationRaw2;
label_6:
        return documentationRaw1;
      }
    }

    /// <summary>Поток в памяти, содержащий Raw файла XML-документации</summary>
    /// <remarks>Свойство доступно только при использовании метода <see cref="M:EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder.BuildToStream(System.Boolean,System.Boolean)" /></remarks>
    public MemoryStream DocumentationRawStream
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              MemoryStream documentationRawStream = this.documentationRawStream;
              if (documentationRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              }
              documentationRawStream.Seek(0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 2;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.documentationRawStream;
      }
    }

    /// <summary>Raw файла отладочной информации (PDB)</summary>
    public byte[] DebugRaw
    {
      get
      {
        int num = 1;
        byte[] debugRaw1;
        byte[] debugRaw2;
        while (true)
        {
          switch (num)
          {
            case 1:
              debugRaw2 = this.debugRaw;
              if (debugRaw2 == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 2:
              goto label_6;
            default:
              MemoryStream debugRawStream = this.debugRawStream;
              this.debugRaw = debugRaw1 = debugRawStream == null ? (byte[]) (object) null : (byte[]) AssemblyBuilder.VxBKmdhpACqRNCBMIACQ((object) debugRawStream);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 0;
              continue;
          }
        }
label_3:
        return debugRaw2;
label_6:
        return debugRaw1;
      }
    }

    /// <summary>
    /// Поток в памяти, содержащий Raw файла отладочной информации (PDB)
    /// </summary>
    /// <remarks>Свойство доступно только при использовании метода <see cref="M:EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder.BuildToStream(System.Boolean,System.Boolean)" /></remarks>
    public MemoryStream DebugRawStream
    {
      get
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 2:
              MemoryStream debugRawStream = this.debugRawStream;
              if (debugRawStream == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
                continue;
              }
              AssemblyBuilder.xBAygdhp7pAtxIrWK85t((object) debugRawStream, 0L, SeekOrigin.Begin);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return this.debugRawStream;
      }
    }

    /// <summary>Добавление ссылок на стандартные сборки платформы</summary>
    protected virtual void AddDefaultGlobalReferences()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilder.YX7XXrhpxZ74lBQPeMux((object) this, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(1470998129 - 231418599 ^ 1239433490));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 0 : 0;
            continue;
          case 2:
            this.AddGlobalReference((string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1120607109 - 305487170 ^ -1426214375));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_2;
          default:
            AssemblyBuilder.YX7XXrhpxZ74lBQPeMux((object) this, AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(572119659 - -337058038 ^ 909297211));
            num = 3;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Добавление Roslyn-анализаторов</summary>
    /// <param name="analyzers">Roslyn-анализаторы</param>
    public void AddAnalyzers(params DiagnosticAnalyzer[] analyzers)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.analyzers.AddRange((IEnumerable<DiagnosticAnalyzer>) analyzers);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Сгенерировать имя файла компиляции</summary>
    /// <param name="prefix">Перфикс имени файла</param>
    /// <param name="extension">Расширение файла</param>
    /// <returns>Сгенерированное имя файла компиляции</returns>
    public string GetSourceFileName(string prefix = "Source", string extension = ".cs")
    {
      int num1 = 4;
      int num2;
      string path2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_4;
          case 2:
          case 3:
            path2 = prefix + (object) num2++ + extension;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 4:
            num2 = 1;
            num1 = 3;
            continue;
          default:
            if (!this.fileNames.Add(path2))
            {
              num1 = 2;
              continue;
            }
            goto label_4;
        }
      }
label_4:
      return Path.Combine(this.tempDir.Value, path2);
    }

    /// <summary>Построить сборку</summary>
    /// <returns>Сборка</returns>
    public virtual byte[] Build(bool pdb = true, bool doc = true)
    {
      int num = 1;
      MemoryStream stream;
      while (true)
      {
        switch (num)
        {
          case 1:
            stream = this.BuildToStream(pdb, doc);
            if (stream == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return (byte[]) null;
label_5:
      return (byte[]) AssemblyBuilder.VxBKmdhpACqRNCBMIACQ((object) stream);
    }

    /// <summary>Построить сборку</summary>
    /// <param name="pdb"><c>true</c> если требует генерация файла отладки</param>
    /// <param name="doc"><c>true</c> если требует генерация XML-документации</param>
    /// <returns>Поток в памяти, содержащий сборку</returns>
    public virtual MemoryStream BuildToStream(bool pdb = true, bool doc = true)
    {
      int num1 = 5;
      EmitResult emitResult;
      HashSet<Assembly>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            this.ProcessErrors(emitResult.Diagnostics);
            num1 = 8;
            continue;
          case 2:
            enumerator = this._referencedAssemblies.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 6;
            continue;
          case 3:
            // ISSUE: reference to a compiler-generated method
            this._sourceCodes.Where<AssemblyBuilder.SourceCode>((Func<AssemblyBuilder.SourceCode, bool>) (sc => AssemblyBuilder.\u003C\u003Ec.JK6rvWvivKknSqA7LAFt((object) sc) == null)).ForEach<AssemblyBuilder.SourceCode>((Action<AssemblyBuilder.SourceCode>) (sc =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    AssemblyBuilder.lyqwZEhpOX3wSviCpqwS((object) sc, (object) this.GetSourceFileName((string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1852837372 ^ -1853055288), (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(~1767720452 ^ -1767661387)));
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 4:
            AssemblyBuilder.enVqImhpmKIHWOPhiBpS((object) this);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 2;
            continue;
          case 5:
            AssemblyBuilder.sOF4DLhp0vaQjBNtjOLJ((object) this.AssemblyName, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(813604817 ^ 813641601));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 4 : 2;
            continue;
          case 6:
            try
            {
label_17:
              if (enumerator.MoveNext())
                goto label_15;
              else
                goto label_18;
label_6:
              Assembly current;
              MemoryStream assemblyRaw;
              int num3;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    AssemblyBuilder.g1EFALhpk1151nQsQa8W((object) this, AssemblyBuilder.FMevcAhpK1GuqjdF9Dhs((object) current));
                    num3 = 5;
                    continue;
                  case 2:
                  case 3:
                    if ((object) (assemblyRaw = (MemoryStream) AssemblyBuilder.nWqb3Ehp61P9GWtxWXxx((object) current)) == null)
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 8 : 8;
                      continue;
                    }
                    goto case 7;
                  case 4:
                    if (AssemblyBuilder.fV1oR4hpR9MOMp7OQ1IU((object) current))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 2 : 0;
                      continue;
                    }
                    goto case 6;
                  case 6:
                    if (!AssemblyBuilder.WtO2JnhpXsH8jk2KuwEN(AssemblyBuilder.FMevcAhpK1GuqjdF9Dhs((object) current)))
                    {
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 1 : 1;
                      continue;
                    }
                    goto case 2;
                  case 7:
                    this.AddReference(assemblyRaw);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
                    continue;
                  case 9:
                    goto label_29;
                  case 10:
                    goto label_15;
                  default:
                    goto label_17;
                }
              }
label_15:
              current = enumerator.Current;
              num3 = 4;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
              {
                num3 = 1;
                goto label_6;
              }
              else
                goto label_6;
label_18:
              num3 = 9;
              goto label_6;
            }
            finally
            {
              enumerator.Dispose();
              int num4 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
                num4 = 0;
              switch (num4)
              {
                default:
              }
            }
          case 7:
label_29:
            // ISSUE: reference to a compiler-generated method
            this._sourceCodes.Where<AssemblyBuilder.SourceCode>((Func<AssemblyBuilder.SourceCode, bool>) (sc => AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) sc) == null)).ForEach<AssemblyBuilder.SourceCode>((Action<AssemblyBuilder.SourceCode>) (sc =>
            {
              int num5 = 1;
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    AssemblyBuilder.\u003C\u003Ec.ysyXBOviZPiKVVVncZts((object) sc, AssemblyBuilder.\u003C\u003Ec.DfunG7vi8ixkcySeWGK2(AssemblyBuilder.\u003C\u003Ec.JK6rvWvivKknSqA7LAFt((object) sc), (object) Encoding.UTF8));
                    num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 3;
            continue;
          case 8:
            goto label_25;
          case 9:
            if (!AssemblyBuilder.tT6g06hpyD6t80BMYbmD((object) emitResult))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 1 : 1;
              continue;
            }
            goto label_26;
          default:
            emitResult = AssemblyBuilder.Compile((object) this.AssemblyName, (IEnumerable<AssemblyBuilder.SourceCode>) this._sourceCodes, (IEnumerable<string>) this._references, (IEnumerable<MemoryStream>) this.referencedAssemblyRaws, (IEnumerable<KeyValuePair<string, byte[]>>) this._embeddedResources, pdb, doc, out this.assemblyRawStream, out this.debugRawStream, out this.documentationRawStream, this.analyzers, (object) this.PublicKey, this.CancellationToken);
            num1 = 9;
            continue;
        }
      }
label_25:
      return (MemoryStream) null;
label_26:
      return this.AssemblyRawStream;
    }

    protected virtual void SaveSourceCodes()
    {
      int num1 = 1;
      List<AssemblyBuilder.SourceCode>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = this._sourceCodes.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_19;
          default:
            goto label_2;
        }
      }
label_19:
      return;
label_2:
      try
      {
label_11:
        if (enumerator.MoveNext())
          goto label_13;
        else
          goto label_12;
label_4:
        AssemblyBuilder.SourceCode current;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 2:
              goto label_11;
            case 3:
              Directory.CreateDirectory(Path.GetDirectoryName((string) AssemblyBuilder.hmHV7xhpMSSghQjMegQh((object) current)));
              num2 = 7;
              continue;
            case 4:
              goto label_13;
            case 5:
              if (AssemblyBuilder.NNyJywhpJSNrqyxOLZmO(AssemblyBuilder.hmHV7xhpMSSghQjMegQh((object) current)))
              {
                num2 = 2;
                continue;
              }
              goto default;
            case 6:
            case 7:
              AssemblyBuilder.Y2r5RBhpdvXO5ElyQSfB(AssemblyBuilder.hmHV7xhpMSSghQjMegQh((object) current), (object) current.Code, AssemblyBuilder.Dlo9JZhp9pw2vNNx89ar());
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
              continue;
            case 8:
              goto label_15;
            default:
              if (Directory.Exists(Path.GetDirectoryName((string) AssemblyBuilder.hmHV7xhpMSSghQjMegQh((object) current))))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 6;
                continue;
              }
              goto case 3;
          }
        }
label_15:
        return;
label_12:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 8 : 3;
        goto label_4;
label_13:
        current = enumerator.Current;
        num2 = 5;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        {
          num2 = 2;
          goto label_4;
        }
        else
          goto label_4;
      }
      finally
      {
        enumerator.Dispose();
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
          num3 = 0;
        switch (num3)
        {
          default:
        }
      }
    }

    /// <summary>Обработать ошибки компиляции</summary>
    /// <param name="diagnostics">Результат сборки</param>
    protected virtual void ProcessErrors(IEnumerable<Diagnostic> diagnostics)
    {
      this.SaveSourceCodes();
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998333104)));
      foreach (Diagnostic diagnostic in diagnostics.Where<Diagnostic>((Func<Diagnostic, bool>) (x => x.Severity == DiagnosticSeverity.Error)))
      {
        stringBuilder.AppendLine();
        stringBuilder.Append((object) diagnostic);
      }
      throw new Exception(stringBuilder.ToString());
    }

    /// <summary>Добавить ссылки на сборки по умолчанию</summary>
    [Obsolete("Использовать не рекомендуется, используйте AddReferences(IEnumerable<IReferenceProviderBase>)", false)]
    protected void AddDefaultReferences<T>() where T : IReferenceProviderBase
    {
      if (!ComponentManager.Initialized)
        return;
      this.AddReferences(ComponentManager.Current.GetExtensionPoints<T>().Cast<IReferenceProviderBase>());
    }

    /// <summary>Добавить ссылки на сборки</summary>
    /// <param name="providers">Провайдер ссылок на сборки</param>
    protected void AddReferences(IEnumerable<IReferenceProviderBase> providers)
    {
      foreach (IReferenceProviderBase provider in providers)
      {
        string[] defaultReferences = provider.GetDefaultReferences();
        if (defaultReferences != null)
        {
          foreach (string str in defaultReferences)
          {
            if (Path.IsPathRooted(str))
              this.AddReference(str);
            else
              this.AddReferenceByName(str);
          }
        }
      }
    }

    /// <summary>
    /// Добавить ссылки на сборки по умолчанию из секции конфигурации
    /// </summary>
    protected void AddDefaultReferencesFromConfig(AssemblyBuilderSection configSection)
    {
      int num1 = 2;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_26;
          case 2:
            if (configSection == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            }
            if (AssemblyBuilder.Y9IkLKhpl1xSq3l2kRNP((object) configSection) == null)
            {
              num1 = 5;
              continue;
            }
            goto case 3;
          case 3:
            enumerator = ((ConfigurationElementCollection) AssemblyBuilder.Y9IkLKhpl1xSq3l2kRNP((object) configSection)).GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_25;
          case 5:
            goto label_14;
          default:
            goto label_4;
        }
      }
label_25:
      return;
label_14:
      return;
label_4:
      try
      {
label_11:
        if (AssemblyBuilder.PnTAsShpV09df55rTsxZ((object) enumerator))
          goto label_9;
        else
          goto label_12;
label_6:
        Assembly assembly;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_19;
            case 1:
            case 5:
              goto label_11;
            case 2:
              goto label_9;
            case 3:
              this.AddReference(assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
              continue;
            case 4:
              if (!AssemblyBuilder.X0q8Ughp5itH2g28fD4y((object) assembly, (object) null))
              {
                num2 = 5;
                continue;
              }
              goto case 3;
            default:
              goto label_15;
          }
        }
label_19:
        return;
label_15:
        return;
label_9:
        assembly = Assembly.Load((string) AssemblyBuilder.vGAJCshpgs4Cduh3J3Vx((object) (AssemblyInfo) AssemblyBuilder.uFUYnqhprO3O2WJRrUrT((object) enumerator)));
        num2 = 4;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
        {
          num2 = 4;
          goto label_6;
        }
        else
          goto label_6;
label_12:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
        goto label_6;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
          num3 = 0;
        while (true)
        {
          switch (num3)
          {
            case 1:
              AssemblyBuilder.tAM9WjhpS4bs2XrbYpaA((object) disposable);
              num3 = 2;
              continue;
            case 2:
              goto label_23;
            default:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
                continue;
              }
              goto label_23;
          }
        }
label_23:;
      }
label_26:
      throw new ArgumentNullException((string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-1445902765 ^ -1980277732 ^ 539326177));
    }

    /// <summary>
    /// Добавить ссылки на сборки по умолчанию из секции конфигурации приложения
    /// </summary>
    protected void AddDefaultReferencesFromConfig(string sectionName)
    {
      int num = 4;
      AssemblyBuilderSection configSection;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.AddDefaultReferencesFromConfig(configSection);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 1 : 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (configSection == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            configSection = AssemblyBuilder.S2SnaYhpjGdR3c5JooAP((object) sectionName) as AssemblyBuilderSection;
            num = 3;
            continue;
          default:
            goto label_8;
        }
      }
label_3:
      return;
label_2:
      return;
label_8:;
    }

    /// <summary>
    /// Добавить ссылки на сборки по умолчанию из секции файл конфигурации ELMA (если находимся в Runtime)
    /// </summary>
    protected void AddDefaultReferencesFromElmaConfig(string sectionName)
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        AssemblyBuilderSection configSection;
        while (true)
        {
          System.Configuration.Configuration configuration;
          switch (num2)
          {
            case 1:
              goto label_5;
            case 2:
              configuration = (System.Configuration.Configuration) null;
              break;
            case 3:
              IRuntimeApplication runtimeApplication = this.RuntimeApplication;
              if (runtimeApplication == null)
              {
                num2 = 2;
                continue;
              }
              object obj = AssemblyBuilder.C8ZkElhpYTpwWKwH2jXO((object) runtimeApplication);
              if (obj == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
                continue;
              }
              configuration = ((RuntimeConfiguration) obj).Config;
              break;
            case 4:
              this.AddDefaultReferencesFromConfig(configSection);
              num2 = 6;
              continue;
            case 5:
              goto label_11;
            case 6:
              goto label_14;
            case 7:
              if (configSection != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 2;
                continue;
              }
              goto label_8;
            default:
              configuration = (System.Configuration.Configuration) null;
              break;
          }
          if (configuration != null)
            num2 = 5;
          else
            goto label_3;
        }
label_11:
        configSection = AssemblyBuilder.aLM9FhhpUYZ0J86CJJPu(AssemblyBuilder.BmnkcohpLe8s92Cki1O6((object) this.runtimeApplication.Configuration), (object) sectionName) as AssemblyBuilderSection;
        num1 = 7;
      }
label_5:
      return;
label_14:
      return;
label_8:
      return;
label_3:;
    }

    private static EmitResult Compile(
      object assemblyName,
      IEnumerable<AssemblyBuilder.SourceCode> sourceCodes,
      IEnumerable<string> referencePaths,
      IEnumerable<MemoryStream> referencedAssemblyRaws,
      IEnumerable<KeyValuePair<string, byte[]>> embeddedResources,
      bool pdb,
      bool doc,
      out MemoryStream peRaw,
      out MemoryStream pdbRaw,
      out MemoryStream docRaw,
      List<DiagnosticAnalyzer> analyzers,
      object publicKey,
      CancellationToken cancellationToken)
    {
      IEnumerable<SyntaxTree> syntaxTrees = sourceCodes.Select<AssemblyBuilder.SourceCode, SyntaxTree>((Func<AssemblyBuilder.SourceCode, SyntaxTree>) (sourceCode =>
      {
        // ISSUE: reference to a compiler-generated method
        object obj1 = AssemblyBuilder.\u003C\u003Ec.jH7qB6viCvjisCIndC8h((object) sourceCode);
        // ISSUE: reference to a compiler-generated method
        Encoding encoding1 = (Encoding) AssemblyBuilder.\u003C\u003Ec.uKRiZTviVwXx2US4GxjU();
        string fileName = sourceCode.FileName;
        // ISSUE: reference to a compiler-generated method
        object obj2 = AssemblyBuilder.\u003C\u003Ec.u5h6MKviSN4GtvmyIdh3();
        string str = fileName;
        Encoding encoding2 = encoding1;
        CancellationToken cancellationToken1 = new CancellationToken();
        return SyntaxFactory.ParseSyntaxTree((string) obj1, (ParseOptions) obj2, str, encoding2, (ImmutableDictionary<string, ReportDiagnostic>) null, cancellationToken1);
      }));
      MetadataReference[] array = (referencePaths ?? Enumerable.Empty<string>()).Select<string, MetadataReference>(new Func<string, MetadataReference>(AssemblyBuilder.GetMetadataReference)).Concat<MetadataReference>((referencedAssemblyRaws ?? Enumerable.Empty<MemoryStream>()).Select<MemoryStream, MetadataReference>(new Func<MemoryStream, MetadataReference>(AssemblyBuilder.GetMetadataReference))).ToArray<MetadataReference>();
      AssemblyIdentityComparer identityComparer = (AssemblyIdentityComparer) DesktopAssemblyIdentityComparer.Default;
      CSharpCompilationOptions options = new CSharpCompilationOptions(OutputKind.DynamicallyLinkedLibrary, false, (string) null, (string) null, (string) null, (IEnumerable<string>) null, (OptimizationLevel) (pdb ? 0 : 1), false, false, (string) null, (string) null, new ImmutableArray<byte>(), new bool?(), Platform.AnyCpu, ReportDiagnostic.Default, 4, (IEnumerable<KeyValuePair<string, ReportDiagnostic>>) null, true, false, (XmlReferenceResolver) null, (SourceReferenceResolver) null, (MetadataReferenceResolver) null, identityComparer, (StrongNameProvider) null, false, MetadataImportOptions.Public, NullableContextOptions.Disable);
      if (publicKey != null && publicKey.Length != 0)
        options = options.WithPublicSign(true).WithCryptoPublicKey(((IEnumerable<byte>) publicKey).ToImmutableArray<byte>());
      CSharpCompilation csharpCompilation = CSharpCompilation.Create((string) assemblyName, syntaxTrees, (IEnumerable<MetadataReference>) array, options);
      if (analyzers.Count > 0)
      {
        ImmutableArray<Microsoft.CodeAnalysis.Diagnostic> result = DiagnosticAnalyzerExtensions.WithAnalyzers((Compilation) csharpCompilation, ImmutableArray.Create<DiagnosticAnalyzer>(analyzers.ToArray()), (AnalyzerOptions) null, new CancellationToken()).GetAllDiagnosticsAsync().GetAwaiter().GetResult();
        // ISSUE: reference to a compiler-generated method
        if (result.Any<Microsoft.CodeAnalysis.Diagnostic>((Func<Microsoft.CodeAnalysis.Diagnostic, bool>) (d => AssemblyBuilder.\u003C\u003Ec.W5ddYVviiO0kQFx3oEVM((object) d) == Microsoft.CodeAnalysis.DiagnosticSeverity.Error)))
        {
          peRaw = (MemoryStream) null;
          pdbRaw = (MemoryStream) null;
          docRaw = (MemoryStream) null;
          return EmitResult.ErrorResult(AssemblyBuilder.CastDiagnostics((IEnumerable<Microsoft.CodeAnalysis.Diagnostic>) result));
        }
      }
      // ISSUE: reference to a compiler-generated method
      IEnumerable<ResourceDescription> manifestResources = embeddedResources != null ? embeddedResources.Select<KeyValuePair<string, byte[]>, ResourceDescription>((Func<KeyValuePair<string, byte[]>, ResourceDescription>) (manifestResource => new ResourceDescription(manifestResource.Key, (Func<Stream>) (() => (Stream) AssemblyBuilder.\u003C\u003Ec__DisplayClass78_0.jAme2hvi6q6vtgFeM6MO((object) manifestResource.Value, false)), true))) : (IEnumerable<ResourceDescription>) null;
      MemoryStream peStream = (MemoryStream) null;
      MemoryStream memoryStream1 = (MemoryStream) null;
      MemoryStream memoryStream2 = (MemoryStream) null;
      try
      {
        peStream = MemoryHelper.GetMemoryStream();
        memoryStream1 = MemoryHelper.GetMemoryStream();
        memoryStream2 = MemoryHelper.GetMemoryStream();
        Microsoft.CodeAnalysis.Emit.EmitResult emitResult = csharpCompilation.Emit((Stream) peStream, pdb ? (Stream) memoryStream1 : (Stream) null, doc ? (Stream) memoryStream2 : (Stream) null, manifestResources: manifestResources, cancellationToken: cancellationToken);
        if (!emitResult.Success)
        {
          peRaw = (MemoryStream) null;
          pdbRaw = (MemoryStream) null;
          docRaw = (MemoryStream) null;
          return EmitResult.ErrorResult(AssemblyBuilder.CastDiagnostics((IEnumerable<Microsoft.CodeAnalysis.Diagnostic>) emitResult.Diagnostics));
        }
        peRaw = peStream;
        if (pdb && memoryStream1.Length > 0L)
        {
          pdbRaw = memoryStream1;
        }
        else
        {
          pdbRaw = (MemoryStream) null;
          memoryStream1.Dispose();
        }
        if (doc && memoryStream2.Length > 0L)
        {
          docRaw = memoryStream2;
        }
        else
        {
          docRaw = (MemoryStream) null;
          memoryStream2.Dispose();
        }
        return EmitResult.SuccessResult(AssemblyBuilder.CastDiagnostics((IEnumerable<Microsoft.CodeAnalysis.Diagnostic>) emitResult.Diagnostics));
      }
      catch
      {
        peStream?.Dispose();
        memoryStream1?.Dispose();
        memoryStream2?.Dispose();
        throw;
      }
    }

    private static IEnumerable<Diagnostic> CastDiagnostics(IEnumerable<Microsoft.CodeAnalysis.Diagnostic> diagnostics) => (IEnumerable<Diagnostic>) diagnostics.Select<Microsoft.CodeAnalysis.Diagnostic, Diagnostic>((Func<Microsoft.CodeAnalysis.Diagnostic, Diagnostic>) (d =>
    {
      int num = 1;
      FileLinePositionSpan? nullable1;
      while (true)
      {
        FileLinePositionSpan? nullable2;
        FileLinePositionSpan? nullable3;
        switch (num)
        {
          case 1:
            // ISSUE: reference to a compiler-generated method
            object obj = AssemblyBuilder.\u003C\u003Ec.uUvUiuviRSFLvMIOMpcS((object) d);
            if (obj == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 0;
              continue;
            }
            // ISSUE: reference to a compiler-generated method
            nullable3 = new FileLinePositionSpan?(AssemblyBuilder.\u003C\u003Ec.K3NVyiviqHaYZY8vSUox(obj));
            break;
          case 2:
            nullable3 = nullable2;
            break;
          case 3:
            goto label_8;
          default:
            nullable2 = new FileLinePositionSpan?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 2;
            continue;
        }
        nullable1 = nullable3;
        num = 3;
      }
label_8:
      Diagnostic diagnostic = new Diagnostic();
      // ISSUE: reference to a compiler-generated method
      AssemblyBuilder.\u003C\u003Ec.Yqcx8eviKeaWrejK5pBX((object) diagnostic, (DiagnosticSeverity) d.Severity);
      // ISSUE: reference to a compiler-generated method
      AssemblyBuilder.\u003C\u003Ec.y72n4wviXc5qGUENPUbU((object) diagnostic, (object) d.Id);
      Location location = new Location();
      string path = !nullable1.HasValue ? (string) null : nullable1.GetValueOrDefault().Path;
      string str;
      if (path == null)
      {
        if (d == null)
        {
          str = (string) null;
        }
        else
        {
          // ISSUE: reference to a compiler-generated method
          object obj1 = AssemblyBuilder.\u003C\u003Ec.uUvUiuviRSFLvMIOMpcS((object) d);
          if (obj1 == null)
          {
            str = (string) null;
          }
          else
          {
            // ISSUE: reference to a compiler-generated method
            object obj2 = AssemblyBuilder.\u003C\u003Ec.kOW3ijviTSIdWF40DqVX(obj1);
            str = obj2 == null ? (string) null : ((SyntaxTree) obj2).FilePath;
          }
        }
      }
      else
        goto label_15;
label_14:
      // ISSUE: reference to a compiler-generated method
      AssemblyBuilder.\u003C\u003Ec.mGK2lDvik0OWWYDGf50e((object) location, (object) str);
      location.Character = nullable1.HasValue ? nullable1.GetValueOrDefault().StartLinePosition.Character + 1 : 0;
      // ISSUE: reference to a compiler-generated method
      AssemblyBuilder.\u003C\u003Ec.BOvMx4vinA7yarxexieg((object) location, !nullable1.HasValue ? 0 : nullable1.GetValueOrDefault().StartLinePosition.Line + 1);
      // ISSUE: reference to a compiler-generated method
      AssemblyBuilder.\u003C\u003Ec.XcaOWXviOJPCwicJi9mT((object) diagnostic, (object) location);
      // ISSUE: reference to a compiler-generated method
      diagnostic.Message = (string) AssemblyBuilder.\u003C\u003Ec.tB9WFWvi2VQLXiFuQG4C((object) d, (object) null);
      return diagnostic;
label_15:
      str = path;
      goto label_14;
    })).ToArray<Diagnostic>();

    private static MetadataReference GetMetadataReference(object path)
    {
      int num1 = 2;
      Tuple<DateTime, long, MetadataReference> tuple;
      while (true)
      {
        int num2 = num1;
        FileInfo info;
        string path1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              path1 = (string) path;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 4 : 0;
              continue;
            case 2:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 0 : 1;
              continue;
            case 3:
              if (tuple.Item2 != AssemblyBuilder.SFQKLLhaFR6VfGiP11Ja((object) info))
              {
                num2 = 9;
                continue;
              }
              goto label_12;
            case 4:
              if (!AssemblyBuilder.oCHJy6hpsyRsmX9pBnMr((object) path1, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867942700)))
              {
                num2 = 5;
                continue;
              }
              goto case 8;
            case 5:
            case 11:
              info = new FileInfo(path1);
              num2 = 7;
              continue;
            case 6:
              goto label_12;
            case 7:
              if (AssemblyBuilder.fileReferences.TryGetValue(path1, out tuple))
              {
                num2 = 10;
                continue;
              }
              goto label_4;
            case 8:
              path1 = (string) AssemblyBuilder.zbGPnmhpCXXdX5PMmcRs(-97972138 ^ -97834290);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 11 : 10;
              continue;
            case 10:
              if (AssemblyBuilder.P4jjMIhpz7io0nBvkwuU(tuple.Item1, AssemblyBuilder.gAtxGxhpcdEEYFU9fefq((object) info)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
                continue;
              }
              goto case 3;
            default:
              goto label_4;
          }
        }
label_4:
        tuple = AssemblyBuilder.fileReferences.AddOrUpdate(path1, (Func<string, Tuple<DateTime, long, MetadataReference>>) (p => new Tuple<DateTime, long, MetadataReference>(info.LastWriteTime, info.Length, (MetadataReference) MetadataReference.CreateFromFile(path1 == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108098938) ? TypeOf<object>.Assembly.Location : path1))), (Func<string, Tuple<DateTime, long, MetadataReference>, Tuple<DateTime, long, MetadataReference>>) ((p, m) => new Tuple<DateTime, long, MetadataReference>(info.LastWriteTime, info.Length, (MetadataReference) MetadataReference.CreateFromFile(path1))));
        num1 = 6;
      }
label_12:
      return tuple.Item3;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    private static MetadataReference GetMetadataReference(object referenceRaw)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilder.xBAygdhp7pAtxIrWK85t(referenceRaw, 0L, SeekOrigin.Begin);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      object metadataReference = AssemblyBuilder.RmhfRNhaWlOlYJjKybPA(AssemblyBuilder.MshxW3haBykmHeEUTsWq(referenceRaw), new MetadataReferenceProperties(), (object) null, (object) null);
      ((Stream) referenceRaw).Seek(0L, SeekOrigin.Begin);
      return (MetadataReference) metadataReference;
    }

    /// <summary>Dctor</summary>
    ~AssemblyBuilder()
    {
      switch (1)
      {
        case 1:
          try
          {
            AssemblyBuilder.URnqoghaooGYEj9TVItL((object) this, false);
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          finally
          {
            // ISSUE: explicit finalizer call
            base.Finalize();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    /// <inheritdoc />
    public void Dispose()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilder.URnqoghaooGYEj9TVItL((object) this, true);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            GC.SuppressFinalize((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Очистить данные</summary>
    /// <param name="disposing"><c>true</c> если метод вызывается из <see cref="M:EleWise.ELMA.Model.CodeGeneration.AssemblyBuilder.Dispose" /></param>
    protected virtual void Dispose(bool disposing)
    {
      int num1 = 4;
      List<MemoryStream>.Enumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_15;
          case 1:
            goto label_17;
          case 2:
            try
            {
label_4:
              if (enumerator.MoveNext())
                goto label_6;
              else
                goto label_5;
label_3:
              int num2;
              switch (num2)
              {
                case 1:
                  goto label_19;
                case 2:
                  goto label_6;
                default:
                  goto label_4;
              }
label_5:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 1;
              goto label_3;
label_6:
              MemoryStream current = enumerator.Current;
              if (current == null)
              {
                num2 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
                {
                  num2 = 0;
                  goto label_3;
                }
                else
                  goto label_3;
              }
              else
              {
                AssemblyBuilder.DXGPSdhabjdBx46DaQg6((object) current);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 3;
                goto label_3;
              }
            }
            finally
            {
              enumerator.Dispose();
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
                num3 = 0;
              switch (num3)
              {
                default:
              }
            }
          case 3:
            enumerator = this.referencedAssemblyRaws.GetEnumerator();
            num1 = 2;
            continue;
          case 4:
            if (!this.disposed)
            {
              num1 = 3;
              continue;
            }
            goto label_11;
          case 5:
label_19:
            this.disposed = true;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 0 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_15:
      return;
label_17:
      return;
label_9:
      return;
label_11:;
    }

    public AssemblyBuilder()
    {
      AssemblyBuilder.zMrEe2hahbyXPPNXZI1k();
      // ISSUE: reference to a compiler-generated field
      Func<string> func = AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__86_0;
      Func<string> valueFactory;
      if (func == null)
      {
        // ISSUE: reference to a compiler-generated field
        // ISSUE: reference to a compiler-generated method
        AssemblyBuilder.\u003C\u003Ec.\u003C\u003E9__86_0 = valueFactory = (Func<string>) (() => (string) AssemblyBuilder.\u003C\u003Ec.BGTOUOvieajh7AGA8BIl());
      }
      else
        goto label_7;
label_3:
      this.tempDir = new Lazy<string>(valueFactory);
      this.fileNames = (ISet<string>) new HashSet<string>((IEqualityComparer<string>) StringComparer.OrdinalIgnoreCase);
      this._references = new HashSet<string>((IEqualityComparer<string>) AssemblyBuilder.xCWhUXhaG0nNCH33cJxE());
      this._referencedAssemblies = new HashSet<Assembly>();
      this.referencedAssemblyRaws = new List<MemoryStream>();
      this._referenceNames = new HashSet<string>((IEqualityComparer<string>) StringComparer.InvariantCultureIgnoreCase);
      this._sourceCodes = new List<AssemblyBuilder.SourceCode>();
      this._embeddedResources = new Dictionary<string, byte[]>();
      this.analyzers = new List<DiagnosticAnalyzer>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
        num = 0;
      switch (num)
      {
        case 0:
          return;
        default:
          return;
      }
label_7:
      valueFactory = func;
      goto label_3;
    }

    static AssemblyBuilder()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            AssemblyBuilder.zMrEe2hahbyXPPNXZI1k();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            AssemblyBuilder.fileReferences = new ConcurrentDictionary<string, Tuple<DateTime, long, MetadataReference>>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool GKZQA7hpEvQJHeuGDYMl() => AssemblyBuilder.FBF21fhpGakSivTQiG7a == null;

    internal static AssemblyBuilder mpTQbxhpfyMkb1jvKyP7() => AssemblyBuilder.FBF21fhpGakSivTQiG7a;

    internal static bool Bhi4xshpQcIFE0dawrt2() => Locator.Initialized;

    internal static object zbGPnmhpCXXdX5PMmcRs(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object PXrSMFhpv8D5FZMSTYg0([In] object obj0) => (object) ((ComponentManager) obj0).AssemblyPaths;

    internal static object MaYP2bhp8cx97MPpo7xA([In] object obj0, [In] object obj1) => (object) Path.Combine((string) obj0, (string) obj1);

    internal static bool KkRhd5hpZ1I3J3MHNqyj([In] object obj0) => Directory.Exists((string) obj0);

    internal static object T5ifyghpu0dcVG05lFSD([In] object obj0, [In] object obj1) => (object) Directory.GetFiles((string) obj0, (string) obj1);

    internal static object gFClR1hpIWkaN4XtN9bi([In] object obj0) => (object) Path.GetFileNameWithoutExtension((string) obj0);

    internal static bool PnTAsShpV09df55rTsxZ([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void tAM9WjhpS4bs2XrbYpaA([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object X1rYLshpi5ZdVKpXe57J() => (object) ComponentManager.GetAssemblies();

    internal static bool fV1oR4hpR9MOMp7OQ1IU([In] object obj0) => ((Assembly) obj0).IsDynamic;

    internal static object GsyvvZhpqMSCTx5M7UZ1([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object FMevcAhpK1GuqjdF9Dhs([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static bool WtO2JnhpXsH8jk2KuwEN([In] object obj0) => string.IsNullOrEmpty((string) obj0);

    internal static bool XojJMYhpTAWEvMubFfZs([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static void g1EFALhpk1151nQsQa8W([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((string) obj1);

    internal static void AtuYfHhpnoNr4OUmiQZF([In] object obj0, [In] object obj1) => ((AssemblyBuilder.SourceCode) obj0).Code = (string) obj1;

    internal static void lyqwZEhpOX3wSviCpqwS([In] object obj0, [In] object obj1) => ((AssemblyBuilder.SourceCode) obj0).FileName = (string) obj1;

    internal static object LWLbrHhp27nEGXQBPLgD() => (object) MemoryHelper.GetMemoryStream();

    internal static object rpKnaVhpebLllViSqwR9([In] object obj0, [In] object obj1) => (object) (obj0.ToString() + obj1);

    internal static void HhGlyqhpPCf1DgHFeE9Z([In] object obj0, [In] object obj1) => ((TextWriter) obj0).Write((string) obj1);

    internal static void mDdUyGhp1vF0Fm0yjT5K([In] object obj0, [In] object obj1) => ((TextWriter) obj0).WriteLine((string) obj1);

    internal static int SiBTN5hpNDTPBWELCoT7([In] object obj0) => ((List<AssemblyBuilder.SourceCode>) obj0).Count;

    internal static object d4MPmQhp3ohNjSFAvZvf() => (object) SHA1.Create();

    internal static object mDj3pOhppkfNiqAxXp2H([In] object obj0) => (object) Convert.ToBase64String((byte[]) obj0);

    internal static void SFDpObhparY6r5PkKhqe([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void Np39euhpDEdOiQXpDEJu([In] object obj0, [In] object obj1) => Contract.ArgumentNotNullOrEmpty((string) obj0, (string) obj1);

    internal static bool wHor53hptiKJhrZvo2kk([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).EndsWith((string) obj1, obj2);

    internal static object QkdShyhpw7kQu19SBJul([In] object obj0, bool writable) => (object) MemoryHelper.GetMemoryStream((byte[]) obj0, writable);

    internal static void J7S20Jhp4Qlf8NYYJIq0([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((MemoryStream) obj1);

    internal static object nWqb3Ehp61P9GWtxWXxx([In] object obj0) => (object) ComponentManager.GetLoadedAssemblyRawAsStream((Assembly) obj0);

    internal static void GnS7jRhpHwlMLeubvpMe([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddReference((Assembly) obj1);

    internal static object VxBKmdhpACqRNCBMIACQ([In] object obj0) => (object) ((MemoryStream) obj0).ToArray();

    internal static long xBAygdhp7pAtxIrWK85t([In] object obj0, [In] long obj1, [In] SeekOrigin obj2) => ((Stream) obj0).Seek(obj1, obj2);

    internal static void YX7XXrhpxZ74lBQPeMux([In] object obj0, [In] object obj1) => ((AssemblyBuilder) obj0).AddGlobalReference((string) obj1);

    internal static void sOF4DLhp0vaQjBNtjOLJ([In] object obj0, [In] object obj1) => Contract.NotNull(obj0, (string) obj1);

    internal static void enVqImhpmKIHWOPhiBpS([In] object obj0) => ((AssemblyBuilder) obj0).AddDefaultGlobalReferences();

    internal static bool tT6g06hpyD6t80BMYbmD([In] object obj0) => ((EmitResult) obj0).Success;

    internal static object hmHV7xhpMSSghQjMegQh([In] object obj0) => (object) ((AssemblyBuilder.SourceCode) obj0).FileName;

    internal static bool NNyJywhpJSNrqyxOLZmO([In] object obj0) => File.Exists((string) obj0);

    internal static object Dlo9JZhp9pw2vNNx89ar() => (object) Encoding.UTF8;

    internal static void Y2r5RBhpdvXO5ElyQSfB([In] object obj0, [In] object obj1, [In] object obj2) => File.WriteAllText((string) obj0, (string) obj1, (Encoding) obj2);

    internal static object Y9IkLKhpl1xSq3l2kRNP([In] object obj0) => (object) ((AssemblyBuilderSection) obj0).Assemblies;

    internal static object uFUYnqhprO3O2WJRrUrT([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object vGAJCshpgs4Cduh3J3Vx([In] object obj0) => (object) ((AssemblyInfo) obj0).Assembly;

    internal static bool X0q8Ughp5itH2g28fD4y([In] object obj0, [In] object obj1) => (Assembly) obj0 != (Assembly) obj1;

    internal static object S2SnaYhpjGdR3c5JooAP([In] object obj0) => ConfigurationManager.GetSection((string) obj0);

    internal static object C8ZkElhpYTpwWKwH2jXO([In] object obj0) => (object) ((IRuntimeApplication) obj0).Configuration;

    internal static object BmnkcohpLe8s92Cki1O6([In] object obj0) => (object) ((RuntimeConfiguration) obj0).Config;

    internal static object aLM9FhhpUYZ0J86CJJPu([In] object obj0, [In] object obj1) => (object) ((System.Configuration.Configuration) obj0).GetSection((string) obj1);

    internal static bool oCHJy6hpsyRsmX9pBnMr([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static DateTime gAtxGxhpcdEEYFU9fefq([In] object obj0) => ((FileSystemInfo) obj0).LastWriteTime;

    internal static bool P4jjMIhpz7io0nBvkwuU([In] DateTime obj0, [In] DateTime obj1) => obj0 != obj1;

    internal static long SFQKLLhaFR6VfGiP11Ja([In] object obj0) => ((FileInfo) obj0).Length;

    internal static object MshxW3haBykmHeEUTsWq([In] object obj0) => (object) ((MemoryStream) obj0).AsNoClose();

    internal static object RmhfRNhaWlOlYJjKybPA(
      [In] object obj0,
      [In] MetadataReferenceProperties obj1,
      [In] object obj2,
      [In] object obj3)
    {
      return (object) MetadataReference.CreateFromStream((Stream) obj0, obj1, (DocumentationProvider) obj2, (string) obj3);
    }

    internal static void URnqoghaooGYEj9TVItL([In] object obj0, bool disposing) => ((AssemblyBuilder) obj0).Dispose(disposing);

    internal static void DXGPSdhabjdBx46DaQg6([In] object obj0) => __nonvirtual (((Stream) obj0).Dispose());

    internal static void zMrEe2hahbyXPPNXZI1k() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object xCWhUXhaG0nNCH33cJxE() => (object) StringComparer.InvariantCultureIgnoreCase;

    private class SourceCode
    {
      private static object FSwYltviWfZ28hZwxa5B;

      public string FileName
      {
        get => this.\u003CFileName\u003Ek__BackingField;
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
                this.\u003CFileName\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0 ? 0 : 0;
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

      public string Code
      {
        get => this.\u003CCode\u003Ek__BackingField;
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
                this.\u003CCode\u003Ek__BackingField = value;
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
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

      public SourceCode()
      {
        AssemblyBuilder.SourceCode.qOwDYovihAl724m30Zaa();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool jXOTYJviohQ5YjwgTyEB() => AssemblyBuilder.SourceCode.FSwYltviWfZ28hZwxa5B == null;

      internal static AssemblyBuilder.SourceCode O30gT9vibuyu3OFwg98c() => (AssemblyBuilder.SourceCode) AssemblyBuilder.SourceCode.FSwYltviWfZ28hZwxa5B;

      internal static void qOwDYovihAl724m30Zaa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

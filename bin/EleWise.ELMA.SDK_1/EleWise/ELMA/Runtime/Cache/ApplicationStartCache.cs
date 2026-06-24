// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Cache.ApplicationStartCache
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml;

namespace EleWise.ELMA.Runtime.Cache
{
  /// <summary>
  /// Кэш с информацией о приложении для оптимизации запуска
  /// </summary>
  public class ApplicationStartCache
  {
    private ITransformationProvider _transform;
    private Dictionary<string, AssemblyInfoCache> _assembliesByName;
    private Dictionary<Assembly, AssemblyInfoCache> _assemblies;
    internal static ApplicationStartCache XTuqPgWevgrjn9H7hgDH;

    /// <summary>Информация о сборках</summary>
    public AssemblyInfoCache[] AssemblyInfos
    {
      get => this._assembliesByName.Values.ToArray<AssemblyInfoCache>();
      set
      {
        int num1 = 7;
        while (true)
        {
          int num2 = num1;
          AssemblyInfoCache assemblyInfoCache;
          int index;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_10;
              case 1:
              case 4:
                if (index >= value.Length)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
                  continue;
                }
                goto case 8;
              case 2:
                goto label_8;
              case 3:
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 1 : 1;
                continue;
              case 5:
                this._assembliesByName[(string) ApplicationStartCache.XFd7SBWeuAOT36RMaqyD((object) assemblyInfoCache)] = assemblyInfoCache;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 2;
                continue;
              case 6:
                goto label_7;
              case 7:
                this._assembliesByName.Clear();
                num2 = 6;
                continue;
              case 8:
                assemblyInfoCache = value[index];
                num2 = 5;
                continue;
              case 9:
                if (value == null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 11 : 2;
                  continue;
                }
                goto case 3;
              case 10:
                ++index;
                num2 = 4;
                continue;
              case 11:
                goto label_6;
              default:
                goto label_3;
            }
          }
label_7:
          this._assemblies.Clear();
          num1 = 9;
          continue;
label_8:
          assemblyInfoCache._owner = this;
          num1 = 10;
        }
label_10:
        return;
label_6:
        return;
label_3:;
      }
    }

    /// <summary>Маппинги NHibernate</summary>
    public string Mappings
    {
      get => this.\u003CMappings\u003Ek__BackingField;
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
              this.\u003CMappings\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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

    /// <summary>Имена перехватчиков</summary>
    public List<string> InterceptorNames { get; set; }

    /// <summary>Возможность Delta-публикации</summary>
    [DefaultValue(true)]
    public bool DynamicPublication
    {
      get => this.\u003CDynamicPublication\u003Ek__BackingField;
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
              this.\u003CDynamicPublication\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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

    /// <summary>Ctor</summary>
    public ApplicationStartCache()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: reference to a compiler-generated field
      this.\u003CDynamicPublication\u003Ek__BackingField = true;
      this._assembliesByName = new Dictionary<string, AssemblyInfoCache>();
      this._assemblies = new Dictionary<Assembly, AssemblyInfoCache>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.InterceptorNames = new List<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Получить (или создать) информацию о сборке</summary>
    /// <param name="assembly">Сборка</param>
    /// <returns></returns>
    public AssemblyInfoCache GetAssemblyInfo(Assembly assembly)
    {
      int num1 = 12;
      AssemblyInfoCache assemblyInfo;
      while (true)
      {
        int num2 = num1;
        Assembly loadedAssembly;
        string key;
        AssemblyName assemblyName;
        int index;
        AssemblyName[] assemblyNameArray;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 4:
            case 27:
            case 34:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 19 : 0;
              continue;
            case 2:
            case 11:
              goto label_39;
            case 3:
              if (this.GetAssemblyInfo(loadedAssembly)._changed)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
                continue;
              }
              goto case 1;
            case 5:
              if (!ApplicationStartCache.a5Zh4OWeTJ5vWgbyKrvH((object) AssemblyInfoCache.EvaluateHashCode(assembly), (object) assemblyInfo.HashCode))
              {
                num2 = 30;
                continue;
              }
              goto case 8;
            case 6:
              if (assemblyInfo != null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 3 : 22;
                continue;
              }
              goto case 17;
            case 7:
              assemblyInfo._changed = true;
              num2 = 24;
              continue;
            case 8:
              assemblyInfo = (AssemblyInfoCache) null;
              num2 = 28;
              continue;
            case 9:
              if (assemblyInfo != null)
              {
                num2 = 5;
                continue;
              }
              goto case 28;
            case 10:
            case 22:
              goto label_43;
            case 12:
              if (!this._assemblies.TryGetValue(assembly, out assemblyInfo))
                goto case 35;
              else
                goto label_9;
            case 13:
              if (((ComponentManager) ApplicationStartCache.JlCDjbWeXQgIDLKv4ohG()).registrationData.Assemblies.Contains(loadedAssembly))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 3 : 3;
                continue;
              }
              goto case 1;
            case 14:
              this._assembliesByName[key] = assemblyInfo;
              num2 = 10;
              continue;
            case 15:
              goto label_20;
            case 16:
              if (!this._assembliesByName.TryGetValue(key, out assemblyInfo))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 6;
                continue;
              }
              goto case 9;
            case 17:
              assemblyInfo = new AssemblyInfoCache(this, assembly);
              num2 = 26;
              continue;
            case 18:
              assemblyInfo = new AssemblyInfoCache(this, assembly);
              num2 = 7;
              continue;
            case 19:
            case 31:
              if (index >= assemblyNameArray.Length)
              {
                num2 = 9;
                continue;
              }
              goto case 21;
            case 20:
              loadedAssembly = ComponentManager.FindLoadedAssembly((string) ApplicationStartCache.xPsU9xWeRnXk0rdMronK((object) assemblyName), false);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 23 : 4;
              continue;
            case 21:
              assemblyName = assemblyNameArray[index];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 32 : 5;
              continue;
            case 23:
              if (!(loadedAssembly != (Assembly) null))
              {
                num2 = 34;
                continue;
              }
              goto case 25;
            case 24:
              this._assemblies[assembly] = assemblyInfo;
              num2 = 15;
              continue;
            case 25:
              if (ApplicationStartCache.sTVIcLWeqYxPsfnGbFYD((object) loadedAssembly))
              {
                num2 = 4;
                continue;
              }
              goto case 29;
            case 26:
              assemblyInfo._changed = true;
              num2 = 14;
              continue;
            case 28:
            case 30:
              if (assemblyInfo != null)
                goto case 24;
              else
                goto label_27;
            case 29:
              if (ApplicationStartCache.AbWBLoWeKiD6dJopMl1A((object) loadedAssembly) == null)
              {
                num2 = 27;
                continue;
              }
              goto case 13;
            case 32:
              if (!ApplicationStartCache.WRacW7WeiDtW6Yq9lwtf(ApplicationStartCache.Q2wX23WeSWBFxiMkAvfm((object) assemblyName), (object) assembly.FullName))
              {
                num2 = 20;
                continue;
              }
              goto case 1;
            case 33:
              index = 0;
              num2 = 31;
              continue;
            case 35:
              key = (string) ApplicationStartCache.qqCOvkWeIi8lsGV44yAQ((object) assembly);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 13 : 16;
              continue;
            default:
              assemblyInfo = (AssemblyInfoCache) null;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 1;
              continue;
          }
        }
label_9:
        num1 = 11;
        continue;
label_20:
        this._assembliesByName[(string) ApplicationStartCache.XFd7SBWeuAOT36RMaqyD((object) assemblyInfo)] = assemblyInfo;
        num1 = 2;
        continue;
label_27:
        num1 = 18;
        continue;
label_43:
        assemblyNameArray = (AssemblyName[]) ApplicationStartCache.CZ1P7wWeVvfH5emyHfHT((object) assembly);
        num1 = 33;
      }
label_39:
      return assemblyInfo;
    }

    /// <summary>Получить индекс перехватчика</summary>
    /// <param name="name">Имя перехватчика</param>
    /// <returns></returns>
    public int GetInterceptorIndex(string name) => this.InterceptorNames.IndexOf(name);

    /// <summary>Создать структуры в БД</summary>
    /// <param name="transform"></param>
    internal static void CreateDbStructures(ITransformationProvider transform, int version)
    {
      int num = 4;
      EleWise.ELMA.Runtime.Db.Migrator.Framework.Table table;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            table = new EleWise.ELMA.Runtime.Db.Migrator.Framework.Table()
            {
              Name = (string) ApplicationStartCache.MS6xVJWekkF5lQJkg40L(-1598106783 - -968262081 ^ -629711408),
              Columns = new List<Column>()
              {
                new Column((string) ApplicationStartCache.MS6xVJWekkF5lQJkg40L(--1360331293 ^ 1360464693), DbType.Binary)
              }
            };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
            continue;
          case 3:
            if (!ApplicationStartCache.bNk11qWenNTx0jHrPmpg((object) transform, ApplicationStartCache.MS6xVJWekkF5lQJkg40L(-2138160520 ^ -2138289526)))
            {
              num = 2;
              continue;
            }
            goto label_10;
          case 4:
            if (version == 0)
            {
              num = 3;
              continue;
            }
            goto label_9;
          default:
            transform.AddTable(table);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 1;
            continue;
        }
      }
label_2:
      return;
label_9:
      return;
label_10:;
    }

    internal static ApplicationStartCache Load(ITransformationProvider transform)
    {
      int num1 = 6;
      ApplicationStartCache applicationStartCache;
      IDataReader reader1;
      DateTime now;
      while (true)
      {
        switch (num1)
        {
          case 1:
label_38:
            if (applicationStartCache == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 7 : 5;
              continue;
            }
            goto case 4;
          case 2:
            reader1 = transform.ExecuteQuery((string) ApplicationStartCache.MS6xVJWekkF5lQJkg40L(-882126494 ^ -882255780), (Dictionary<string, object>) null);
            num1 = 3;
            continue;
          case 3:
            try
            {
              int num2;
              if (!reader1.Read())
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              else
                goto label_26;
label_7:
              MemoryStream stream;
              switch (num2)
              {
                case 2:
                  try
                  {
                    XmlReader reader2 = (XmlReader) ApplicationStartCache.p9YIFLWeOawu0KAY0nXN((object) stream);
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
                      num3 = 1;
                    switch (num3)
                    {
                      case 1:
                        try
                        {
                          applicationStartCache = (ApplicationStartCache) ClassSerializationHelper.DeserializeObjectByXml(TypeOf<ApplicationStartCache>.Raw, reader2, false);
                          int num4 = 0;
                          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
                            num4 = 0;
                          switch (num4)
                          {
                            default:
                              goto label_38;
                          }
                        }
                        finally
                        {
                          if (reader2 != null)
                          {
                            int num5 = 0;
                            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
                              num5 = 0;
                            while (true)
                            {
                              switch (num5)
                              {
                                case 1:
                                  goto label_19;
                                default:
                                  reader2.Dispose();
                                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
                                  continue;
                              }
                            }
                          }
label_19:;
                        }
                      default:
                        goto label_38;
                    }
                  }
                  finally
                  {
                    int num6;
                    if (stream == null)
                      num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 0 : 0;
                    else
                      goto label_23;
label_22:
                    switch (num6)
                    {
                      case 1:
                        break;
                      default:
                    }
label_23:
                    ApplicationStartCache.d8LVP1We20yGMVqoN7xj((object) stream);
                    num6 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
                    {
                      num6 = 2;
                      goto label_22;
                    }
                    else
                      goto label_22;
                  }
                case 3:
                  break;
                default:
                  goto label_38;
              }
label_26:
              stream = reader1.GetStream(0);
              num2 = 2;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
              {
                num2 = 2;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num7 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                num7 = 0;
              while (true)
              {
                switch (num7)
                {
                  case 1:
                    goto label_38;
                  default:
                    ApplicationStartCache.MACqkXWePWTj6gYbM0oq(ApplicationStartCache.aDKfHWWee9XZsPX1jJ6R(), ApplicationStartCache.MS6xVJWekkF5lQJkg40L(572119659 - -337058038 ^ 909310657), (object) ex);
                    num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 1;
                    continue;
                }
              }
            }
            finally
            {
              int num8;
              if (reader1 == null)
                num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              else
                goto label_35;
label_34:
              switch (num8)
              {
                case 2:
                  break;
                default:
              }
label_35:
              ApplicationStartCache.d8LVP1We20yGMVqoN7xj((object) reader1);
              num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
              {
                num8 = 1;
                goto label_34;
              }
              else
                goto label_34;
            }
          case 4:
            applicationStartCache._transform = transform;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          case 5:
            applicationStartCache = (ApplicationStartCache) null;
            num1 = 2;
            continue;
          case 6:
            now = DateTime.Now;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 5;
            continue;
          case 7:
            applicationStartCache = new ApplicationStartCache();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 4 : 4;
            continue;
          case 8:
            goto label_3;
          default:
            ApplicationStartCache.RLufG0We3mTbQ9BTYSnb(ApplicationStartCache.aDKfHWWee9XZsPX1jJ6R(), (object) (z2jc63fLkugS1X8Q9N.tE1kD1vbB(1218962250 ^ 1218833068) + (object) (int) ApplicationStartCache.fUWkqOWeNlAvu4xZ0wjI(ApplicationStartCache.jZAV5EWe1Qnm8tOoOg4h(), now).TotalMilliseconds + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867138135)));
            num1 = 8;
            continue;
        }
      }
label_3:
      return applicationStartCache;
    }

    /// <summary>Сохранить</summary>
    internal void Save()
    {
      int num1 = 2;
      while (true)
      {
        DateTime now;
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            if (this._assembliesByName.Values.Any<AssemblyInfoCache>((System.Func<AssemblyInfoCache, bool>) (a =>
            {
              int num2 = 2;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    goto label_5;
                  case 2:
                    if (a._changed)
                    {
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 1 : 0;
                      continue;
                    }
                    goto label_4;
                  default:
                    goto label_4;
                }
              }
label_4:
              return a._typesChanged;
label_5:
              return true;
            })))
            {
              now = DateTime.Now;
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0 ? 2 : 4;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 1 : 0;
            continue;
          case 3:
            try
            {
              this._transform.ExecuteNonQuery(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-680446928 - -370807692 ^ -309768802));
              int num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
                num3 = 1;
              MemoryStream memoryStream;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    memoryStream = ClassSerializationHelper.SerializeObjectByXmlToMemoryStream((object) this, false);
                    num3 = 2;
                    continue;
                  case 2:
                    goto label_6;
                  default:
                    goto label_25;
                }
              }
label_6:
              try
              {
                ApplicationStartCache.yfFu1hWeaGIra8hSnQ49((object) this._transform, ApplicationStartCache.MS6xVJWekkF5lQJkg40L(--1418440330 ^ 1418307192), (object) new string[1]
                {
                  z2jc63fLkugS1X8Q9N.tE1kD1vbB(277947046 - -1479185048 ^ 1757002774)
                }, (object) new object[1]
                {
                  (object) new ParameterValue(DbType.Binary, (object) memoryStream)
                });
                int num4 = 1;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
                  num4 = 1;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      ApplicationStartCache.vcErQ9WeDmM1gDDkn94p((object) this._transform);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_25;
                  }
                }
              }
              finally
              {
                int num5;
                if (memoryStream == null)
                  num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
                else
                  goto label_13;
label_12:
                switch (num5)
                {
                  case 1:
                    break;
                  default:
                }
label_13:
                ApplicationStartCache.d8LVP1We20yGMVqoN7xj((object) memoryStream);
                num5 = 2;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
                {
                  num5 = 1;
                  goto label_12;
                }
                else
                  goto label_12;
              }
            }
            catch (Exception ex)
            {
              int num6 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    ApplicationStartCache.MACqkXWePWTj6gYbM0oq(ApplicationStartCache.aDKfHWWee9XZsPX1jJ6R(), ApplicationStartCache.MS6xVJWekkF5lQJkg40L(1242972401 >> 4 ^ 77819519), (object) ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                    continue;
                  case 2:
                    goto label_25;
                  default:
                    ApplicationStartCache.VV43vwWetBSgtabHjiq2((object) this._transform);
                    num6 = 2;
                    continue;
                }
              }
            }
          case 4:
            ApplicationStartCache.kPgAnwWepKRktsl5m3JW((object) this._transform);
            num1 = 3;
            continue;
          case 5:
            goto label_22;
        }
label_25:
        ApplicationStartCache.RLufG0We3mTbQ9BTYSnb(ApplicationStartCache.aDKfHWWee9XZsPX1jJ6R(), ApplicationStartCache.vjnJxVWewsvKTvnQlNqo(ApplicationStartCache.MS6xVJWekkF5lQJkg40L(-2107978722 ^ -2108111192), (object) (int) ApplicationStartCache.fUWkqOWeNlAvu4xZ0wjI(ApplicationStartCache.jZAV5EWe1Qnm8tOoOg4h(), now).TotalMilliseconds, ApplicationStartCache.MS6xVJWekkF5lQJkg40L(1505778440 - 1981636111 ^ -475821883)));
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 5 : 5;
      }
label_2:
      return;
label_22:;
    }

    internal static bool xCsHGuWe8C4D64dhTBGr() => ApplicationStartCache.XTuqPgWevgrjn9H7hgDH == null;

    internal static ApplicationStartCache rbmVXiWeZ0g8KwXWorMP() => ApplicationStartCache.XTuqPgWevgrjn9H7hgDH;

    internal static object XFd7SBWeuAOT36RMaqyD([In] object obj0) => (object) ((AssemblyInfoCache) obj0).AssemblyName;

    internal static object qqCOvkWeIi8lsGV44yAQ([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object CZ1P7wWeVvfH5emyHfHT([In] object obj0) => (object) ((Assembly) obj0).GetReferencedAssemblies();

    internal static object Q2wX23WeSWBFxiMkAvfm([In] object obj0) => (object) ((AssemblyName) obj0).FullName;

    internal static bool WRacW7WeiDtW6Yq9lwtf([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object xPsU9xWeRnXk0rdMronK([In] object obj0) => (object) ((AssemblyName) obj0).Name;

    internal static bool sTVIcLWeqYxPsfnGbFYD([In] object obj0) => ((Assembly) obj0).IsDynamic;

    internal static object AbWBLoWeKiD6dJopMl1A([In] object obj0) => (object) ((Assembly) obj0).Location;

    internal static object JlCDjbWeXQgIDLKv4ohG() => (object) ComponentManager.Current;

    internal static bool a5Zh4OWeTJ5vWgbyKrvH([In] object obj0, [In] object obj1) => (string) obj0 != (string) obj1;

    internal static object MS6xVJWekkF5lQJkg40L(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool bNk11qWenNTx0jHrPmpg([In] object obj0, [In] object obj1) => ((ITransformationProvider) obj0).TableExists((string) obj1);

    internal static object p9YIFLWeOawu0KAY0nXN([In] object obj0) => (object) XmlReader.Create((Stream) obj0);

    internal static void d8LVP1We20yGMVqoN7xj([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static object aDKfHWWee9XZsPX1jJ6R() => (object) Logger.Log;

    internal static void MACqkXWePWTj6gYbM0oq([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static DateTime jZAV5EWe1Qnm8tOoOg4h() => DateTime.Now;

    internal static TimeSpan fUWkqOWeNlAvu4xZ0wjI([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void RLufG0We3mTbQ9BTYSnb([In] object obj0, [In] object obj1) => ((ILogger) obj0).Debug(obj1);

    internal static void kPgAnwWepKRktsl5m3JW([In] object obj0) => ((ITransformationProvider) obj0).BeginTransaction();

    internal static int yfFu1hWeaGIra8hSnQ49([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((ITransformationProvider) obj0).Insert((string) obj1, (string[]) obj2, (object[]) obj3);

    internal static void vcErQ9WeDmM1gDDkn94p([In] object obj0) => ((ITransformationProviderBase) obj0).CommitTransaction();

    internal static void VV43vwWetBSgtabHjiq2([In] object obj0) => ((ITransformationProvider) obj0).RollbackTransaction();

    internal static object vjnJxVWewsvKTvnQlNqo([In] object obj0, [In] object obj1, [In] object obj2) => (object) (obj0.ToString() + obj1 + obj2);

    /// <summary>Структура БД</summary>
    private static class Db
    {
      /// <summary>Поля</summary>
      public static class Fields
      {
        /// <summary>Кэш в сериализованном виде</summary>
        public const string CacheData = "CacheData";
      }
    }
  }
}

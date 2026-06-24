// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Scripts.Types.Settings;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.ScriptDesigner.TranslateData;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Модуль сценариев какого-либо объекта</summary>
  [Entity("ScriptModule")]
  [DisplayName(typeof (ScriptModule_Resources), "DisplayName")]
  [ShowInDesigner(false)]
  [ShowInTypeTree(true)]
  [EleWise.ELMA.Model.Attributes.Uid("{53EBA73B-29A5-4609-9D37-A93E409DC09F}")]
  [MetadataType(typeof (EntityMetadata))]
  [ClassMap(typeof (ScriptModule_Map))]
  public class ScriptModule : Entity<long>, IScriptModule
  {
    public const string UID_S = "{53EBA73B-29A5-4609-9D37-A93E409DC09F}";
    private static ScriptModule rtwfW8bqVIMbpsPcyGL2;

    public ScriptModule()
    {
      ScriptModule.MjyqFLbqRdQRoNgGKNH7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.WebReferences = new List<ScriptWebReference>();
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.CodeItems = new RootCodeItemCollection();
            num = 4;
            continue;
          case 4:
            this.LocalReferences = new List<AssemblyReference>();
            num = 5;
            continue;
          case 5:
            this.GlobalScriptModules = new List<AssemblyReference>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0 ? 0 : 0;
            continue;
          default:
            this.ScriptMethods = new List<ScriptMethodDeclaration>();
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Уникальный идентификатор модуля</summary>
    [GuidSettings(FieldName = "Uid")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{6D42ADC9-AC19-4D8B-A9C1-69D8DDD7422F}")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [SystemProperty]
    public virtual Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
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

    /// <summary>Уникальный идентификатор типа модуля</summary>
    [EntityProperty]
    [GuidSettings(FieldName = "ModuleTypeUid")]
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EleWise.ELMA.Model.Attributes.Uid("{AAC72ECC-D993-4845-88DF-6E02D2DCC8D9}")]
    public virtual Guid ModuleTypeUid
    {
      get => this.\u003CModuleTypeUid\u003Ek__BackingField;
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
              this.\u003CModuleTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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

    /// <summary>
    /// Уникальный идентификатор объекта, с которым связан сценарий
    /// </summary>
    [Property("{EB6E8DDC-FAFE-4E0E-9018-1A7667012579}")]
    [EleWise.ELMA.Model.Attributes.Uid("{0AF338B8-8286-4B22-AF43-E4CF7E38B7E7}")]
    [EntityProperty]
    [GuidSettings(FieldName = "ObjectUid")]
    public virtual Guid ObjectUid
    {
      get => this.\u003CObjectUid\u003Ek__BackingField;
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
              this.\u003CObjectUid\u003Ek__BackingField = value;
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

    /// <summary>Имя модуля</summary>
    [EntityProperty]
    [StringSettings(FieldName = "ModuleName", MaxValueString = "255")]
    [EleWise.ELMA.Model.Attributes.Uid("{61AEFECA-816E-45AF-8D11-095C6C520401}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string ModuleName
    {
      get => this.\u003CModuleName\u003Ek__BackingField;
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
              this.\u003CModuleName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 0;
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

    /// <summary>Исходный код</summary>
    [StringSettings(FieldName = "SourceCode", MaxValueString = "2147483647", MultiLine = true)]
    [EntityProperty]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EleWise.ELMA.Model.Attributes.Uid("{23F03DE5-F469-482F-9F97-BCB6B22350F7}")]
    public virtual string SourceCode
    {
      get => this.\u003CSourceCode\u003Ek__BackingField;
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
              this.\u003CSourceCode\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 0 : 0;
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

    /// <summary>Дизайнеры конструктора</summary>
    [EntityProperty]
    [RootCodeItemTypeSettings(FieldName = "CodeItems")]
    [EleWise.ELMA.Model.Attributes.Uid("D2725740-4F4E-46A8-9A23-518654C6DC9F")]
    [Property("B996B108-7A4D-4240-B96B-C6C1D99636D7")]
    public virtual RootCodeItemCollection CodeItems
    {
      get => this.\u003CCodeItems\u003Ek__BackingField;
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
              this.\u003CCodeItems\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    /// <summary>Список методов в сценария процесса</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{D56978B8-F71B-4668-A50A-3CD109BFB6DC}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EntityProperty]
    [StringSettings(FieldName = "ScriptMetodsList", MaxValueString = "2147483647", MultiLine = true)]
    public virtual string ScriptMetodsList
    {
      get => this.\u003CScriptMetodsList\u003Ek__BackingField;
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
              this.\u003CScriptMetodsList\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0 ? 0 : 0;
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

    /// <summary>Полное имя скомпилированного исходного файла</summary>
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{CDEFC7DA-CA36-4E0A-B4F9-77401141ADEA}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "CompiledFileName", MaxValueString = "2147483647")]
    public virtual string CompiledFileName
    {
      get => this.\u003CCompiledFileName\u003Ek__BackingField;
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
              this.\u003CCompiledFileName\u003Ek__BackingField = value;
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

    /// <summary>
    /// Список имен требуемых сборок для компиляции сценария (через точку с запятой)
    /// </summary>
    [StringSettings(FieldName = "References", MaxValueString = "2147483647", MultiLine = true)]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{DAACFC5C-6F74-4630-A59F-FD10B550D9B0}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    public virtual string References
    {
      get => this.\u003CReferences\u003Ek__BackingField;
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
              this.\u003CReferences\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
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

    /// <summary>
    /// Список имен сборок elma для компиляции сценария (через точку с запятой)
    /// </summary>
    [StringSettings(FieldName = "ElmaReferences", MaxValueString = "2147483647", MultiLine = true)]
    [EntityProperty]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EleWise.ELMA.Model.Attributes.Uid("{B1A03C14-F8CF-4A9C-A5EF-ED6A5C7BE8FD}")]
    public virtual string ElmaReferences
    {
      get => this.\u003CElmaReferences\u003Ek__BackingField;
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
              this.\u003CElmaReferences\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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

    /// <summary>Ссылки на веб-сервисы</summary>
    [EleWise.ELMA.Model.Attributes.Uid("{CF5EAC0A-0948-4C3B-ADD9-564EFAA6442B}")]
    [Property("{F14334F8-4964-4A0E-9846-D7687933F0A4}")]
    [EntityProperty]
    [ScriptWebReferencesTypeSettings(FieldName = "WebReferences")]
    public virtual List<ScriptWebReference> WebReferences { get; set; }

    /// <summary>Локальные ссылки на сборки</summary>
    [EntityProperty]
    [AssemblyReferenceTypeSettings(FieldName = "LocalReferences")]
    [Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
    [EleWise.ELMA.Model.Attributes.Uid("{45B49B1D-DB7A-404A-A644-3C5ED2369C8A}")]
    public virtual List<AssemblyReference> LocalReferences { get; set; }

    /// <summary>Ссылки на глобальные модули сценариев</summary>
    [AssemblyReferenceTypeSettings(FieldName = "GlobalScriptModules")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{56FF3F44-4C36-4337-9B04-DDA9E8E39427}")]
    [Property("{6D4B839B-DADA-4BA9-B163-33A771E84039}")]
    public virtual List<AssemblyReference> GlobalScriptModules { get; set; }

    /// <summary>Имя сборки</summary>
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{EA44042E-6283-4FBF-B3A0-6F9E83B99188}")]
    [StringSettings(FieldName = "AssemblyName")]
    public virtual string AssemblyName
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
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

    /// <summary>
    /// Пространство имен, в котором содержится класс сценариев
    /// </summary>
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{960864C3-2E38-489F-9D07-3F05D129B6E5}")]
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [StringSettings(FieldName = "Namespace")]
    public virtual string Namespace
    {
      get => this.\u003CNamespace\u003Ek__BackingField;
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
              this.\u003CNamespace\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
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

    /// <summary>Имя класса сценариев</summary>
    [Property("{9B9AAC17-22BB-425C-AA93-9C02C5146965}")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{B61E66C6-FBDE-4245-9A8E-034A817B37FB}")]
    [StringSettings(FieldName = "ClassName")]
    public virtual string ClassName
    {
      get => this.\u003CClassName\u003Ek__BackingField;
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
              this.\u003CClassName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Методы сценария</summary>
    [Property("{D6E0683F-B70F-4D65-B3FF-E1987CBD40A5}")]
    [StringSettings(FieldName = "ScriptMethods")]
    [EleWise.ELMA.Model.Attributes.Uid("{B54AEEEA-A2C5-435B-B09F-4253FE9E8085}")]
    [EntityProperty]
    public virtual List<ScriptMethodDeclaration> ScriptMethods { get; set; }

    /// <summary>Скомпилированное состояние сборки</summary>
    [EntityProperty]
    [BlobSettings(FieldName = "AssemblyRaw")]
    [EleWise.ELMA.Model.Attributes.Uid("{02015E6F-DB15-441B-9275-BB94055AA78B}")]
    [Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
    public virtual byte[] AssemblyRaw
    {
      get => this.\u003CAssemblyRaw\u003Ek__BackingField;
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
              this.\u003CAssemblyRaw\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
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

    /// <summary>Скомпилированная отладочная информация</summary>
    [BlobSettings(FieldName = "DebugRaw")]
    [Property("{1911B22D-0CE2-4743-832F-6A44CB0357FE}")]
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{667A5D08-319F-4F03-8ABD-0419150D6224}")]
    public virtual byte[] DebugRaw
    {
      get => this.\u003CDebugRaw\u003Ek__BackingField;
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
              this.\u003CDebugRaw\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 0 : 0;
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

    /// <summary>Черновой вариант опубликованного сценария</summary>
    [EntityProperty]
    [EntitySettings(FieldName = "Draft")]
    [Property("{72ED98CA-F260-4671-9BCD-FF1D80235F47}", "{53EBA73B-29A5-4609-9D37-A93E409DC09F}")]
    [EleWise.ELMA.Model.Attributes.Uid("{947D25F6-1D98-43DD-A304-244107426396}")]
    public virtual ScriptModule Draft
    {
      get => this.\u003CDraft\u003Ek__BackingField;
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
              this.\u003CDraft\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    /// <summary>Зависимости</summary>
    /// <remarks>Сериализованные зависимости модуля сценариев</remarks>
    [EntityProperty]
    [EleWise.ELMA.Model.Attributes.Uid("{39DCFC2A-6BD5-4BF9-A366-9228112451B6}")]
    [XmlSerializableObjectSettings(FieldName = "Dependencies")]
    [Property("{66C7898B-E56B-49E0-BFB8-9F9C4A7A0C52}")]
    public virtual object Dependencies
    {
      get => this.\u003CDependencies\u003Ek__BackingField;
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
              this.\u003CDependencies\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
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

    /// <summary>Полное имя класса</summary>
    public virtual string FullClassName => (string) ScriptModule.OPsT8GbqXJksPvDCGQEf(ScriptModule.UewFrqbqqVsRukbv9Bux((object) this), ScriptModule.FMVRKEbqKCyOj2HlPbPF(-2107978722 ^ -2107975974), (object) this.ClassName);

    internal static void MjyqFLbqRdQRoNgGKNH7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rjSpgXbqSFDNuus3EluD() => ScriptModule.rtwfW8bqVIMbpsPcyGL2 == null;

    internal static ScriptModule O2e5JdbqiaGv9O64UNS9() => ScriptModule.rtwfW8bqVIMbpsPcyGL2;

    internal static object UewFrqbqqVsRukbv9Bux([In] object obj0) => (object) ((ScriptModule) obj0).Namespace;

    internal static object FMVRKEbqKCyOj2HlPbPF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OPsT8GbqXJksPvDCGQEf([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);
  }
}

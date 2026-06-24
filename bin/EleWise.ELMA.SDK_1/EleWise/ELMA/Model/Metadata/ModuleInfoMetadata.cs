// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ModuleInfoMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Attributes;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Scripts.DTO.Models;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные модуля</summary>
  [XmlExport]
  [DataContract]
  [XmlRoot("ModuleInfo")]
  [Serializable]
  public class ModuleInfoMetadata : NamedMetadata, IRootMetadata, IMetadata, IXsiType
  {
    private static ModuleInfoMetadata Gqolpeb4vV9M7jKS7f0s;

    /// <summary>Ctor</summary>
    public ModuleInfoMetadata()
    {
      ModuleInfoMetadata.bBxN39b4uBaRv5ZR04Wo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Components = new List<ComponentMetadata>();
            num = 6;
            continue;
          case 2:
            this.DependencyModules = new List<LinkToModule>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 0 : 1;
            continue;
          case 3:
            this.ModuleType = ModuleType.Default;
            num = 7;
            continue;
          case 4:
            goto label_3;
          case 5:
            this.Functions = new List<FunctionMetadata>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 6:
            this.DataClasses = new List<DataClassMetadata>();
            num = 5;
            continue;
          case 7:
            this.DefaultStatus = ModuleStatus.Unknown;
            num = 2;
            continue;
          default:
            this.ProjectItems = new List<ProjectItem>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 4 : 4;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Тип модуля</summary>
    [DefaultValue(ModuleType.Default)]
    public ModuleType ModuleType
    {
      get => this.\u003CModuleType\u003Ek__BackingField;
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
              this.\u003CModuleType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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

    /// <summary>Веб-сайт</summary>
    public string WebSite
    {
      get => this.\u003CWebSite\u003Ek__BackingField;
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
              this.\u003CWebSite\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    /// <summary>HTML-описание</summary>
    public string HtmlDescription
    {
      get => this.\u003CHtmlDescription\u003Ek__BackingField;
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
              this.\u003CHtmlDescription\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
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
    /// Требуется ли, чтобы данный модуль был доступен на сервере
    /// </summary>
    [DefaultValue(false)]
    public bool ServerModuleRequired
    {
      get => this.\u003CServerModuleRequired\u003Ek__BackingField;
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
              this.\u003CServerModuleRequired\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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

    /// <summary>Статус по умолчанию</summary>
    [DefaultValue(ModuleStatus.Unknown)]
    public ModuleStatus DefaultStatus
    {
      get => this.\u003CDefaultStatus\u003Ek__BackingField;
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
              this.\u003CDefaultStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
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

    /// <summary>Зависимости модуля</summary>
    [DefaultValue(null)]
    public ModuleDependency Dependency
    {
      get => this.\u003CDependency\u003Ek__BackingField;
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
              this.\u003CDependency\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
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
    /// Список идентификаторов модулей, от которых зависит данный модуль
    /// </summary>
    [XmlArray("DependencyModules")]
    [XmlArrayItem("Module")]
    public List<LinkToModule> DependencyModules { get; set; }

    /// <summary>
    /// Метаданные компонентов модуля, заполнены только у опубликованного модуля
    /// </summary>
    public List<ComponentMetadata> Components { get; set; }

    /// <summary>
    /// Метаданные датаклассов модуля, заполнены только у опубликованного модуля
    /// </summary>
    public List<DataClassMetadata> DataClasses { get; set; }

    /// <summary>
    /// Метаданные функций модуля, заполнены только у опубликованного модуля
    /// </summary>
    public List<FunctionMetadata> Functions { get; set; }

    /// <summary>Список элементов глобального кода (папки, файлы)</summary>
    [Obsolete("Данный API может быть изменен или удален в любой момент", false)]
    [XmlForceElement]
    public List<ProjectItem> ProjectItems { get; set; }

    /// <inheritdoc />
    public override void InitNew()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ModuleInfoMetadata.dvddvNb4VO3hbCmUJ0mn((object) this, ModuleInfoMetadata.DWdTX2b4Inh9vFkKE2Rw((object) this));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить метаданные для регистрации</summary>
    /// <returns>Список метаданных</returns>
    internal IEnumerable<IMetadata> GetMetadataToRegister()
    {
      List<IMetadata> metadataToRegister = new List<IMetadata>();
      metadataToRegister.AddRange((IEnumerable<IMetadata>) this.DataClasses);
      metadataToRegister.AddRange((IEnumerable<IMetadata>) this.Functions);
      foreach (ComponentMetadata component in this.Components)
      {
        metadataToRegister.Add((IMetadata) component);
        metadataToRegister.AddRange(component.GetMetadataToRegister());
      }
      return (IEnumerable<IMetadata>) metadataToRegister;
    }

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public void LoadFromType(Type type, bool inherit = true)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            this.LoadFromAssembly(type.Assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 1;
            continue;
          case 3:
            if (!ModuleInfoMetadata.R3yQJxb4S4JquH3hLUEB(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 2 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_6:
      return;
label_4:
      throw new ArgumentNullException((string) ModuleInfoMetadata.HGSDA3b4ie9Q8AoHgHwF(647913418 ^ 647910376));
    }

    /// <summary>Загрузить метаданные из сборки</summary>
    /// <param name="asm">Сборка</param>
    public void LoadFromAssembly(Assembly asm)
    {
      int num1 = 13;
      while (true)
      {
        int num2 = num1;
        ModuleAttribute attribute1;
        ModuleTitleAttribute attribute2;
        ServerModuleRequiredAttribute attribute3;
        ModuleWebSiteAttribute attribute4;
        ModuleTypeAttribute attribute5;
        ModuleDefaultStatusAttribute attribute6;
        ModuleHtmlDescriptionAttribute attribute7;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Name = (string) ModuleInfoMetadata.ensUvib4TE5kApdB8HqU((object) attribute1);
              num2 = 6;
              continue;
            case 2:
              attribute6 = AttributeHelper<ModuleDefaultStatusAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 9 : 10;
              continue;
            case 3:
              attribute7 = AttributeHelper<ModuleHtmlDescriptionAttribute>.GetAttribute(asm);
              num2 = 14;
              continue;
            case 4:
              goto label_21;
            case 5:
              attribute2 = AttributeHelper<ModuleTitleAttribute>.GetAttribute(asm);
              num2 = 16;
              continue;
            case 6:
              ModuleInfoMetadata.dvddvNb4VO3hbCmUJ0mn((object) this, ModuleInfoMetadata.DWdTX2b4Inh9vFkKE2Rw((object) this));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 5;
              continue;
            case 7:
              this.WebSite = attribute4 == null ? "" : (string) ModuleInfoMetadata.CuHoP6b42uVPGaGC7h3Z((object) attribute4);
              num2 = 3;
              continue;
            case 8:
              attribute5 = AttributeHelper<ModuleTypeAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 15 : 12;
              continue;
            case 9:
              goto label_15;
            case 10:
              this.DefaultStatus = attribute6 == null ? ModuleStatus.Enabled : attribute6.Status;
              num2 = 8;
              continue;
            case 11:
              this.ServerModuleRequired = attribute3 != null;
              num2 = 4;
              continue;
            case 12:
              if (attribute1 != null)
              {
                ModuleInfoMetadata.WfQHE9b4XUfxcRNQCikh((object) this, ModuleInfoMetadata.XgQmngb4KvoVx9QKq7C7((object) attribute1));
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 1;
                continue;
              }
              goto label_10;
            case 13:
              attribute1 = AttributeHelper<ModuleAttribute>.GetAttribute(asm);
              num2 = 12;
              continue;
            case 14:
              this.HtmlDescription = attribute7 != null ? (string) ModuleInfoMetadata.kda7wHb4eR8NPqkxydT0((object) attribute7) : "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 17 : 9;
              continue;
            case 15:
              this.ModuleType = attribute5 != null ? ModuleInfoMetadata.rq5bo4b4O1rWmQ1Xsek9((object) attribute5) : ModuleType.Default;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0 ? 0 : 0;
              continue;
            case 16:
              ModuleInfoMetadata.a7q8DGb4nwrRihH5eZOJ((object) this, attribute2 != null ? ModuleInfoMetadata.vjHOOgb4ktu0X72dRh8M((object) attribute2) : (object) string.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 2 : 1;
              continue;
            case 17:
              attribute3 = AttributeHelper<ServerModuleRequiredAttribute>.GetAttribute(asm);
              num2 = 11;
              continue;
            default:
              attribute4 = AttributeHelper<ModuleWebSiteAttribute>.GetAttribute(asm);
              num2 = 7;
              continue;
          }
        }
label_10:
        num1 = 9;
      }
label_21:
      return;
label_15:
      throw new InvalidOperationException((string) ModuleInfoMetadata.NVPERSb4qnIt0M6WjgVA((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138086989), ModuleInfoMetadata.HQBSdrb4RX3w3KOfdL0L((object) asm), ModuleInfoMetadata.HGSDA3b4ie9Q8AoHgHwF(277947046 - -1479185048 ^ 1756971356)));
    }

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    public virtual bool IsRestartNeeded(IRootMetadata metadata) => true;

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public virtual void ApplyRestartUnrequiredChanges(bool inherit)
    {
    }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDependencyModules() => ModuleInfoMetadata.EZxJUBb4PqL8nnMMhLna((object) this.DependencyModules) > 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComponents() => ModuleInfoMetadata.c6cXiLb41Vk5HZIywHxO((object) this.Components) != 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClasses() => ModuleInfoMetadata.msstVWb4NjCg6p0UkWsd((object) this.DataClasses) != 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFunctions() => ModuleInfoMetadata.YPYXSxb43ckulE8UmkJn((object) this.Functions) != 0;

    /// <summary>
    /// Нужно ли сериализовать <see cref="P:EleWise.ELMA.Model.Metadata.ModuleInfoMetadata.ProjectItems" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProjectItems() => ModuleInfoMetadata.dfDVs6b4pa50e82vAtUY((object) this.ProjectItems) != 0;

    /// <summary>
    /// Нужно ли сериализовать <see cref="!:Description" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDescription() => !ModuleInfoMetadata.dF0eX1b4Dlx2HhkTAHe1(ModuleInfoMetadata.EXILVRb4a1LZiASkSAfy((object) this));

    /// <summary>Сделать поверхностную копию</summary>
    internal ModuleInfoMetadata ShallowCopy() => (ModuleInfoMetadata) ModuleInfoMetadata.yw51b3b4tZ0ihgXnPMyZ((object) this);

    internal static void bBxN39b4uBaRv5ZR04Wo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool zyyWN1b48me3eZ0UH9eo() => ModuleInfoMetadata.Gqolpeb4vV9M7jKS7f0s == null;

    internal static ModuleInfoMetadata b0dh0Tb4ZYhtXbaK0VRI() => ModuleInfoMetadata.Gqolpeb4vV9M7jKS7f0s;

    internal static Guid DWdTX2b4Inh9vFkKE2Rw([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void dvddvNb4VO3hbCmUJ0mn([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static bool R3yQJxb4S4JquH3hLUEB([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object HGSDA3b4ie9Q8AoHgHwF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object HQBSdrb4RX3w3KOfdL0L([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static object NVPERSb4qnIt0M6WjgVA([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static Guid XgQmngb4KvoVx9QKq7C7([In] object obj0) => ((ModuleAttribute) obj0).Uid;

    internal static void WfQHE9b4XUfxcRNQCikh([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static object ensUvib4TE5kApdB8HqU([In] object obj0) => (object) ((ModuleAttribute) obj0).Id;

    internal static object vjHOOgb4ktu0X72dRh8M([In] object obj0) => (object) ((ModuleTitleAttribute) obj0).Title;

    internal static void a7q8DGb4nwrRihH5eZOJ([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static ModuleType rq5bo4b4O1rWmQ1Xsek9([In] object obj0) => ((ModuleTypeAttribute) obj0).ModuleType;

    internal static object CuHoP6b42uVPGaGC7h3Z([In] object obj0) => (object) ((ModuleWebSiteAttribute) obj0).WebSite;

    internal static object kda7wHb4eR8NPqkxydT0([In] object obj0) => (object) ((ModuleHtmlDescriptionAttribute) obj0).Description;

    internal static int EZxJUBb4PqL8nnMMhLna([In] object obj0) => ((List<LinkToModule>) obj0).Count;

    internal static int c6cXiLb41Vk5HZIywHxO([In] object obj0) => ((List<ComponentMetadata>) obj0).Count;

    internal static int msstVWb4NjCg6p0UkWsd([In] object obj0) => ((List<DataClassMetadata>) obj0).Count;

    internal static int YPYXSxb43ckulE8UmkJn([In] object obj0) => ((List<FunctionMetadata>) obj0).Count;

    internal static int dfDVs6b4pa50e82vAtUY([In] object obj0) => ((List<ProjectItem>) obj0).Count;

    internal static object EXILVRb4a1LZiASkSAfy([In] object obj0) => (object) ((NamedMetadata) obj0).Description;

    internal static bool dF0eX1b4Dlx2HhkTAHe1([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object yw51b3b4tZ0ihgXnPMyZ([In] object obj0) => obj0.MemberwiseClone();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private class Info : IMetadataTypeInfo
    {
      private static object dTAlXICtY43OiX1VIv30;

      public string Name => EleWise.ELMA.SR.T((string) ModuleInfoMetadata.Info.BpgNEFCtsJhM4jTG8AMQ(272623989 ^ 272254163));

      public string Description => string.Empty;

      public Type MetadataType => ModuleInfoMetadata.Info.oEqMlaCtcm0gfLKMQE1D(__typeref (ModuleInfoMetadata));

      public Type GeneratorType => typeof (ModuleInfoGenerator);

      public Info()
      {
        ModuleInfoMetadata.Info.NELpr4CtziirfVjoxr71();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object BpgNEFCtsJhM4jTG8AMQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool HqDJxwCtLlJTYFVXuhIW() => ModuleInfoMetadata.Info.dTAlXICtY43OiX1VIv30 == null;

      internal static ModuleInfoMetadata.Info eUCXvtCtUpqYmbwcXXBL() => (ModuleInfoMetadata.Info) ModuleInfoMetadata.Info.dTAlXICtY43OiX1VIv30;

      internal static Type oEqMlaCtcm0gfLKMQE1D([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void NELpr4CtziirfVjoxr71() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

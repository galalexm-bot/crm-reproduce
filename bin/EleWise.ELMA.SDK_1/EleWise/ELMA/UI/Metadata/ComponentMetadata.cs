// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.ComponentMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Services;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.CodeGeneration;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Метаданные пользовательского компонента</summary>
  [DataContract]
  [XmlRoot("Component")]
  [EleWise.ELMA.Model.Attributes.Uid("{66457AD6-CE6E-4CD5-AE3A-D46DC83A0E85}")]
  [Serializable]
  public class ComponentMetadata : 
    NamedMetadata,
    ICodeItemMetadata,
    IMetadata,
    IXsiType,
    IRootMetadata
  {
    /// <summary>Уникальный идентификатор данного типа метаданных</summary>
    public static readonly Guid TypeUid;
    /// <summary>Пространство имен по умолчанию</summary>
    internal const string DefaultNamespace = "EleWise.ELMA.UI.Components";
    internal static ComponentMetadata X6D1IdBGO0dXEdL4ndlD;

    /// <summary>Ctor</summary>
    public ComponentMetadata(Guid moduleUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ModuleUid = moduleUid;
            num = 2;
            continue;
          case 2:
            ComponentMetadata.EdYQnoBG1BYqgUwj7YMi((object) this, ComponentMetadata.f0OgCJBGPSNdgTDNA63D(moduleUid, Guid.Empty));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_3:
      return;
label_6:;
    }

    /// <summary>Ctor</summary>
    public ComponentMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 9 : 0;
            continue;
          case 2:
            this.FunctionDependencies = new List<FunctionDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 8;
            continue;
          case 3:
            this.ImplementationForms = new List<ImplementationForm>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 6 : 0;
            continue;
          case 4:
            this.DataClasses = new List<DataClassMetadata>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
            continue;
          case 5:
            this.Implementations = new List<Implementation>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 3 : 2;
            continue;
          case 6:
            this.UserDefinedListInfos = new List<UserDefinedListInfo>();
            num = 7;
            continue;
          case 7:
            goto label_2;
          case 8:
            this.DataClassDependencies = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 9:
            this.EnumDependencies = new List<EnumDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 5 : 2;
            continue;
          default:
            this.ComponentDependencies = new List<ComponentDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.ICodeItemMetadata" />
    [DefaultValue("")]
    public string Namespace
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 0 : 0;
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

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.ICodeItemMetadata" />
    [DefaultValue("")]
    public string NamespaceForDisplay
    {
      get => this.\u003CNamespaceForDisplay\u003Ek__BackingField;
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
              this.\u003CNamespaceForDisplay\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.ICodeItemMetadata" />
    public string FullTypeName => (string) ComponentMetadata.jbnbiLBG3yPD4mipsTxK((object) this.Namespace, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1088304168 ^ -1088302820), ComponentMetadata.xyubDJBGN0PjHVvjrg1q((object) this));

    /// <summary>Метаданные содержимого компонента</summary>
    public ComponentContentMetadata Content
    {
      get => this.\u003CContent\u003Ek__BackingField;
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
              this.\u003CContent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Список локальных вложенных объектов</summary>
    public List<DataClassMetadata> DataClasses { get; set; }

    /// <summary>Список реализаций</summary>
    public List<Implementation> Implementations { get; set; }

    /// <summary>
    /// Список метаданных, формы которых реализует данный компонент
    /// </summary>
    public List<ImplementationForm> ImplementationForms { get; set; }

    /// <summary>Информация о пользовательских списках</summary>
    public List<UserDefinedListInfo> UserDefinedListInfos { get; set; }

    /// <summary>Реализация кастомного типа</summary>
    public CustomTypeImplementationModel CustomTypeImplementation
    {
      get => this.\u003CCustomTypeImplementation\u003Ek__BackingField;
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
              this.\u003CCustomTypeImplementation\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    /// <summary>Ссылка на код серверного скрипта</summary>
    public Guid? ScriptUid { get; set; }

    /// <summary>Ссылка на код клиентского скрипта</summary>
    public Guid? ClientScriptUid { get; set; }

    /// <summary>Ссылка на код скрипта представления</summary>
    public Guid? ViewScriptUid { get; set; }

    /// <summary>Ссылка на код тестового скрипта</summary>
    public Guid? TestScriptUid { get; set; }

    /// <summary>
    /// Зависимости от функций. Список заполнен только у элементов конфигурации
    /// </summary>
    public List<FunctionDependency> FunctionDependencies { get; set; }

    /// <summary>
    /// Зависимости от датаклассов. Список заполнен только у элементов конфигурации
    /// </summary>
    public List<DataClassDependency> DataClassDependencies { get; set; }

    /// <summary>
    /// Зависимости от компонентов. Список заполнен только у элементов конфигурации
    /// </summary>
    public List<ComponentDependency> ComponentDependencies { get; set; }

    /// <summary>Зависимости от сущностей.</summary>
    /// <remarks>
    /// Список заполняется, если в компоненте используются свойства сущности на форме или в клиентском сценарии
    /// </remarks>
    public List<EntityDependency> EntityDependencies { get; set; }

    /// <summary>Зависимости от перечислений.</summary>
    /// <remarks>
    /// Список заполняется, если в компоненте используются свойства перечисления на форме или в клиентском сценарии
    /// </remarks>
    public List<EnumDependency> EnumDependencies { get; set; }

    /// <summary>Получить уникальный идентификатор типа метаданных</summary>
    /// <returns>Уникальный идентификатор типа метаданных</returns>
    public virtual Guid GetMetadataTypeUid() => ComponentMetadata.TypeUid;

    /// <summary>Инициализировать новый объект метаданных</summary>
    public override void InitNew()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_8;
          case 1:
            ComponentMetadata.LhZg7YBGD7fhV7JiDZkP((object) this.Content);
            num = 6;
            continue;
          case 2:
            this.Namespace = (string) ComponentMetadata.atgksABGpw8NMYIwO1Cj(-1598106783 - -968262081 ^ -629819076);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 4 : 0;
            continue;
          case 3:
            base.InitNew();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 2 : 2;
            continue;
          case 4:
            if (this.Content != null)
            {
              num = 7;
              continue;
            }
            ComponentContentMetadata componentContentMetadata = new ComponentContentMetadata();
            componentContentMetadata.ModuleUid = ComponentMetadata.NwljwrBGaZJZ7ZsnLed7((object) this);
            this.Content = componentContentMetadata;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0 ? 0 : 1;
            continue;
          case 5:
            ComponentMetadata.IBWOlaBG6wU5bg8L2AmS(ComponentMetadata.C6dSJRBGtwa5VHKBfLlC((object) this.Content), ComponentMetadata.lcyqRcBG45Ut74e0BFv0(ComponentMetadata.atgksABGpw8NMYIwO1Cj(-1998538950 ^ -1998562452)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
            continue;
          case 6:
            ComponentMetadata.trXEiCBGwkC6y61jdpp2(ComponentMetadata.C6dSJRBGtwa5VHKBfLlC((object) this.Content), ComponentMetadata.atgksABGpw8NMYIwO1Cj(979449278 ^ 979464634));
            num = 5;
            continue;
          case 7:
            goto label_2;
          default:
            goto label_12;
        }
      }
label_8:
      return;
label_2:
      return;
label_12:;
    }

    /// <summary>
    /// Сгенерировать новые идентификаторы для всех составляющих элементов (например, для публикации или копирования)
    /// </summary>
    public void GenerateNewUids()
    {
      int num = 1;
      Guid oldMetadataUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            oldMetadataUid = ComponentMetadata.oE3qSrBGHdyArjSSoPGf((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
            continue;
          case 2:
            ComponentMetadata.lB20vuBGAi2nB30lWQpo((object) this.Content);
            num = 4;
            continue;
          case 3:
            goto label_2;
          case 4:
            ComponentMetadata.oBEmE6BG7uZJfS566oK6((object) this, oldMetadataUid);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 3;
            continue;
          default:
            ComponentMetadata.LhZg7YBGD7fhV7JiDZkP((object) this);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.IRootMetadata" />
    public void LoadFromType(Type type, bool inherit = true)
    {
      int num1 = 16;
      while (true)
      {
        int num2 = num1;
        Guid guid;
        int index;
        PropertyInfo propertyInfo;
        ComponentMetadata componentMetadata;
        PropertyInfo[] properties;
        Type type1;
        while (true)
        {
          switch (num2)
          {
            case 1:
            case 7:
              if (index >= properties.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 2 : 11;
                continue;
              }
              goto case 17;
            case 2:
              if (!propertyInfo.CanRead)
              {
                num2 = 9;
                continue;
              }
              goto case 13;
            case 3:
            case 21:
              goto label_19;
            case 4:
            case 14:
              componentMetadata = (ComponentMetadata) ComponentMetadata.opW5RnBGJ0CoymDwghmn((object) ((AbstractNHEntityManager<ComponentMetadataItem, long>) ComponentMetadata.uUbc5LBGMviRiQBHt0T8()).Load(guid));
              num2 = 3;
              continue;
            case 5:
              ComponentMetadata.uqQ3kMBGr33Yo6I3X4Ge((object) propertyInfo, (object) this, ComponentMetadata.cu4o8DBGlTrfyEdubAs1((object) propertyInfo, (object) componentMetadata, (object) null), (object) null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0 ? 19 : 4;
              continue;
            case 6:
              guid = ComponentMetadata.dUU07kBGx8l2YfcZD3gj((object) AttributeHelper<MetadataItemUidAttribute>.GetAttribute(type1.Assembly));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 8 : 6;
              continue;
            case 8:
              if (!ComponentMetadata.PpnG6FBGmnKecAcdT2KY(ComponentMetadata.mgwGORBG0vRW0TgD4jSp((object) type1.Assembly), ComponentMetadata.atgksABGpw8NMYIwO1Cj(-1334993905 ^ -1335004993)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 14;
                continue;
              }
              goto case 10;
            case 9:
            case 19:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
              continue;
            case 10:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              componentMetadata = ((ModuleInfoMetadata) ComponentMetadata.y3EWWuBGyR4AMQFW9owH((object) Locator.GetServiceNotNull<IModuleMetadataLoader>().GetSpecificModuleVersion(AttributeHelper<AssemblyModuleAttribute>.GetAttribute(type1.Assembly).Uid, guid))).Components.Find((Predicate<ComponentMetadata>) (c => ComponentMetadata.\u003C\u003Ec__DisplayClass79_0.ibx9NpQo6QJRBp9S1Vo8(ComponentMetadata.\u003C\u003Ec__DisplayClass79_0.aoBsAtQo4EVNOUZDOnSg((object) c), (object) type1.FullName)));
              num2 = 21;
              continue;
            case 11:
              goto label_17;
            case 12:
              goto label_24;
            case 13:
              if (propertyInfo.CanWrite)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 18 : 10;
                continue;
              }
              goto case 9;
            case 15:
              type1 = type;
              num2 = 6;
              continue;
            case 16:
              num2 = 15;
              continue;
            case 17:
              propertyInfo = properties[index];
              num2 = 2;
              continue;
            case 18:
              if (ComponentMetadata.HfmqBGBGdUy4XXwspKXF((object) propertyInfo).Length == 0)
              {
                num2 = 5;
                continue;
              }
              goto case 9;
            case 20:
              properties = ComponentMetadata.gbOrfrBG9fsr9wgUYe7X((object) this).GetProperties();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
              continue;
            default:
              index = 0;
              num2 = 7;
              continue;
          }
        }
label_19:
        if (componentMetadata != null)
          num1 = 20;
        else
          goto label_9;
      }
label_17:
      return;
label_24:
      return;
label_9:;
    }

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.IRootMetadata" />
    public bool IsRestartNeeded(IRootMetadata metadata) => false;

    /// <inheritdoc cref="T:EleWise.ELMA.Model.Metadata.IRootMetadata" />
    public void ApplyRestartUnrequiredChanges(bool inherit)
    {
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.DataClasses" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClasses() => ComponentMetadata.DULU2lBGgjhKoiZHnNJD((object) this.DataClasses) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.Implementations" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeImplementations() => ComponentMetadata.CTrFOhBG5Yp5E3qen25I((object) this.Implementations) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.ImplementationForms" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeImplementationForms() => this.ImplementationForms.Count != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.DataClassDependencies" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClassDependencies() => ComponentMetadata.iHYegvBGj34hDeBj6qBC((object) this.DataClassDependencies) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.FunctionDependencies" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFunctionDependencies() => this.FunctionDependencies.Count != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.ComponentDependencies" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComponentDependencies() => ComponentMetadata.hlXJmLBGYcqPquqFqENE((object) this.ComponentDependencies) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.EntityDependencies" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEntityDependencies() => ComponentMetadata.nb0cO9BGLoWxWR9e0lEl((object) this.EntityDependencies) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.EnumDependencies" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEnumDependencies() => ComponentMetadata.yfPKIxBGUtfIZB8XR8rV((object) this.EnumDependencies) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство<see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.UserDefinedListInfos" />
    ///  </summary>
    /// <returns></returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeUserDefinedListInfos() => ComponentMetadata.SBOnSMBGsXEfjAcNmlnV((object) this.UserDefinedListInfos) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.ScriptUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeScriptUid()
    {
      int num = 1;
      Guid? scriptUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            scriptUid = this.ScriptUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return scriptUid.HasValue;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.ClientScriptUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeClientScriptUid()
    {
      int num = 1;
      Guid? clientScriptUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            clientScriptUid = this.ClientScriptUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return clientScriptUid.HasValue;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.ViewScriptUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeViewScriptUid()
    {
      int num = 1;
      Guid? viewScriptUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            viewScriptUid = this.ViewScriptUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return viewScriptUid.HasValue;
    }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.ComponentMetadata.TestScriptUid" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeTestScriptUid()
    {
      int num = 1;
      Guid? testScriptUid;
      while (true)
      {
        switch (num)
        {
          case 1:
            testScriptUid = this.TestScriptUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return testScriptUid.HasValue;
    }

    /// <summary>Получить метаданные для регистрации</summary>
    /// <returns>Список метаданных</returns>
    internal IEnumerable<IMetadata> GetMetadataToRegister()
    {
      List<IMetadata> metadataToRegister = new List<IMetadata>(this.DataClasses.Count + 1);
      if (this.Content?.Context != null)
        metadataToRegister.Add((IMetadata) this.Content.Context);
      if (this.DataClasses != null)
        metadataToRegister.AddRange((IEnumerable<IMetadata>) this.DataClasses);
      return (IEnumerable<IMetadata>) metadataToRegister;
    }

    static ComponentMetadata()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ComponentMetadata.M4o95aBGcPlsgDIqiSan();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ComponentMetadata.TypeUid = new Guid((string) ComponentMetadata.atgksABGpw8NMYIwO1Cj(-1978478350 ^ -1978516438));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static bool f0OgCJBGPSNdgTDNA63D([In] Guid obj0, [In] Guid obj1) => obj0 != obj1;

    internal static void EdYQnoBG1BYqgUwj7YMi([In] object obj0, bool value) => ((AbstractMetadata) obj0).Internal = value;

    internal static bool i801gYBG2blSf5u12lGC() => ComponentMetadata.X6D1IdBGO0dXEdL4ndlD == null;

    internal static ComponentMetadata nbyvbMBGecBFxdb8tM5I() => ComponentMetadata.X6D1IdBGO0dXEdL4ndlD;

    internal static object xyubDJBGN0PjHVvjrg1q([In] object obj0) => (object) ((NamedMetadata) obj0).Name;

    internal static object jbnbiLBG3yPD4mipsTxK([In] object obj0, [In] object obj1, [In] object obj2) => (object) ((string) obj0 + (string) obj1 + (string) obj2);

    internal static object atgksABGpw8NMYIwO1Cj(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static Guid NwljwrBGaZJZ7ZsnLed7([In] object obj0) => ((AbstractMetadata) obj0).ModuleUid;

    internal static void LhZg7YBGD7fhV7JiDZkP([In] object obj0) => ((AbstractMetadata) obj0).InitNew();

    internal static object C6dSJRBGtwa5VHKBfLlC([In] object obj0) => (object) ((ComponentContentMetadata) obj0).Context;

    internal static void trXEiCBGwkC6y61jdpp2([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static object lcyqRcBG45Ut74e0BFv0([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static void IBWOlaBG6wU5bg8L2AmS([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static Guid oE3qSrBGHdyArjSSoPGf([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static void lB20vuBGAi2nB30lWQpo([In] object obj0) => ((ComponentContentMetadata) obj0).GenerateNewUids();

    internal static void oBEmE6BG7uZJfS566oK6([In] object obj0, Guid oldMetadataUid) => ComponentMetadataHelperInternal.ReplaceOldUids((ComponentMetadata) obj0, oldMetadataUid);

    internal static Guid dUU07kBGx8l2YfcZD3gj([In] object obj0) => ((MetadataItemUidAttribute) obj0).ItemUid;

    internal static object mgwGORBG0vRW0TgD4jSp([In] object obj0) => (object) ((Assembly) obj0).FullName;

    internal static bool PpnG6FBGmnKecAcdT2KY([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static object y3EWWuBGyR4AMQFW9owH([In] object obj0) => (object) ((ModuleVersion) obj0).Metadata;

    internal static object uUbc5LBGMviRiQBHt0T8() => (object) ComponentMetadataItemManager.Instance;

    internal static object opW5RnBGJ0CoymDwghmn([In] object obj0) => ((ComponentMetadataItem) obj0).Metadata;

    internal static Type gbOrfrBG9fsr9wgUYe7X([In] object obj0) => obj0.GetType();

    internal static object HfmqBGBGdUy4XXwspKXF([In] object obj0) => (object) ((PropertyInfo) obj0).GetIndexParameters();

    internal static object cu4o8DBGlTrfyEdubAs1([In] object obj0, [In] object obj1, [In] object obj2) => ((PropertyInfo) obj0).GetValue(obj1, (object[]) obj2);

    internal static void uqQ3kMBGr33Yo6I3X4Ge([In] object obj0, [In] object obj1, [In] object obj2, [In] object obj3) => ((PropertyInfo) obj0).SetValue(obj1, obj2, (object[]) obj3);

    internal static int DULU2lBGgjhKoiZHnNJD([In] object obj0) => ((List<DataClassMetadata>) obj0).Count;

    internal static int CTrFOhBG5Yp5E3qen25I([In] object obj0) => ((List<Implementation>) obj0).Count;

    internal static int iHYegvBGj34hDeBj6qBC([In] object obj0) => ((List<DataClassDependency>) obj0).Count;

    internal static int hlXJmLBGYcqPquqFqENE([In] object obj0) => ((List<ComponentDependency>) obj0).Count;

    internal static int nb0cO9BGLoWxWR9e0lEl([In] object obj0) => ((List<EntityDependency>) obj0).Count;

    internal static int yfPKIxBGUtfIZB8XR8rV([In] object obj0) => ((List<EnumDependency>) obj0).Count;

    internal static int SBOnSMBGsXEfjAcNmlnV([In] object obj0) => ((List<UserDefinedListInfo>) obj0).Count;

    internal static void M4o95aBGcPlsgDIqiSan() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private sealed class Info : IMetadataTypeInfo
    {
      private static object VDTXkcQoeesawHbLj5rq;

      /// <inheritdoc />
      public string Name => EleWise.ELMA.SR.T((string) ComponentMetadata.Info.DPrT0AQoN4xqYRX5bN9u(372753449 ^ 372420375));

      /// <inheritdoc />
      public string Description => EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217693075));

      /// <inheritdoc />
      public Type MetadataType => typeof (ComponentMetadata);

      /// <inheritdoc />
      public Type GeneratorType => ComponentMetadata.Info.tIuYDVQo3xe1Hlxnbb9m(__typeref (ComponentMetadataGenerator));

      public Info()
      {
        ComponentMetadata.Info.ExfoeyQopsApneqVZqnb();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object DPrT0AQoN4xqYRX5bN9u(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static bool zUJ2RkQoPDJi7HwnNwCI() => ComponentMetadata.Info.VDTXkcQoeesawHbLj5rq == null;

      internal static ComponentMetadata.Info AaNkF2Qo1eDYFqMXVals() => (ComponentMetadata.Info) ComponentMetadata.Info.VDTXkcQoeesawHbLj5rq;

      internal static Type tIuYDVQo3xe1Hlxnbb9m([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void ExfoeyQopsApneqVZqnb() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

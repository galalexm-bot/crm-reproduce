// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.ModuleDependency
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Зависимости модуля</summary>
  [Serializable]
  public sealed class ModuleDependency
  {
    internal static ModuleDependency tJLcfHhRnEuOZh9IypwS;

    /// <summary>ctor</summary>
    public ModuleDependency()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.EnumDependencies = new List<EnumDependency>();
            num = 5;
            continue;
          case 2:
            this.Functions = new List<FunctionDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 2 : 3;
            continue;
          case 3:
            this.Components = new List<ComponentDependency>();
            num = 4;
            continue;
          case 4:
            this.EntityDependencies = new List<EntityDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 1 : 0;
            continue;
          case 5:
            goto label_3;
          default:
            this.DataClasses = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 2;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список зависимостей от датаклассов</summary>
    [XmlArrayItem("DataClass")]
    [XmlArray("DataClasses")]
    public List<DataClassDependency> DataClasses { get; }

    /// <summary>Список зависимостей от функций</summary>
    [XmlArray("Functions")]
    [XmlArrayItem("Function")]
    public List<FunctionDependency> Functions { get; }

    /// <summary>Список зависимостей от компонентов</summary>
    [XmlArrayItem("Component")]
    [XmlArray("Components")]
    public List<ComponentDependency> Components { get; }

    /// <summary>Список зависимостей от сущностей</summary>
    [XmlArrayItem("EntityDependency")]
    [XmlArray("EntityDependencies")]
    public List<EntityDependency> EntityDependencies { get; }

    /// <summary>Список зависимостей от перечислений</summary>
    [XmlArrayItem("EnumDependency")]
    [XmlArray("EnumDependencies")]
    public List<EnumDependency> EnumDependencies { get; }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClasses() => this.DataClasses.Count > 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFunctions() => ModuleDependency.hpfGB5hReo5PgY3xWFiQ((object) this.Functions) > 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComponents() => ModuleDependency.shXxlJhRPwV0yco2XSHj((object) this.Components) > 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEntityDependencies() => ModuleDependency.NI87bYhR1oeOYaU7c18f((object) this.EntityDependencies) > 0;

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeEnumDependencies() => ModuleDependency.oCa3dEhRNmsfWKXdV6Hj((object) this.EnumDependencies) > 0;

    internal static bool f6PTCDhROmHaUlkrUQ5v() => ModuleDependency.tJLcfHhRnEuOZh9IypwS == null;

    internal static ModuleDependency pfwtHLhR24gOmkTPRFVl() => ModuleDependency.tJLcfHhRnEuOZh9IypwS;

    internal static int hpfGB5hReo5PgY3xWFiQ([In] object obj0) => ((List<FunctionDependency>) obj0).Count;

    internal static int shXxlJhRPwV0yco2XSHj([In] object obj0) => ((List<ComponentDependency>) obj0).Count;

    internal static int NI87bYhR1oeOYaU7c18f([In] object obj0) => ((List<EntityDependency>) obj0).Count;

    internal static int oCa3dEhRNmsfWKXdV6Hj([In] object obj0) => ((List<EnumDependency>) obj0).Count;
  }
}

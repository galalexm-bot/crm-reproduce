// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Signatures.ModuleSignature
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Signatures
{
  /// <summary>
  /// Сигнатура модуля
  /// Вычисляется из метаданных, записывается в базу в отдельное поле, для упрощения поиска
  /// </summary>
  [DataContract]
  [Serializable]
  public class ModuleSignature
  {
    internal static ModuleSignature F9PRqGWzznBtS7pKdXUB;

    /// <summary>ctor</summary>
    public ModuleSignature()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Functions = new List<FunctionDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 2 : 2;
            continue;
          case 2:
            this.Components = new List<ComponentSignature>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
            continue;
          case 3:
            this.DataClasses = new List<DataClassDependency>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
            continue;
          case 4:
            this.ExtensionPoints = new List<ImplementationSignature>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 4 : 5;
            continue;
          case 5:
            this.CustomTypes = new List<CustomTypeImplementationModel>();
            num = 6;
            continue;
          case 6:
            goto label_3;
          default:
            this.Implementations = new List<ImplementationSignature>();
            num = 4;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Сигнатура датаклассов модуля</summary>
    public List<DataClassDependency> DataClasses { get; set; }

    /// <summary>Сигнатура функций модуля</summary>
    public List<FunctionDependency> Functions { get; set; }

    /// <summary>Сигнатура компонентов модуля</summary>
    public List<ComponentSignature> Components { get; set; }

    /// <summary>
    /// Список реализуемых расширений
    /// Не хранится в компоненте, т.к. учитывает и приватные компоненты
    /// </summary>
    public List<ImplementationSignature> Implementations { get; set; }

    /// <summary>Список используемых расширений в модуле</summary>
    public List<ImplementationSignature> ExtensionPoints { get; set; }

    /// <summary>
    /// Список типов, для которых есть реализации компонентов в модуле
    /// </summary>
    public List<CustomTypeImplementationModel> CustomTypes { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.DataClasses" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeDataClasses() => ModuleSignature.zROMrBoFW8cvktfjUR96((object) this.DataClasses) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.Functions" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeFunctions() => ModuleSignature.NdwgysoFoEBpYBG4onYo((object) this.Functions) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.Components" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeComponents() => ModuleSignature.YZ0UecoFbSRWIO5OHfRi((object) this.Components) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.Implementations" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeImplementations() => ModuleSignature.GuSYGgoFh7FkH3i787oC((object) this.Implementations) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.ExtensionPoints" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeExtensionPoints() => ModuleSignature.GuSYGgoFh7FkH3i787oC((object) this.ExtensionPoints) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ModuleSignature.CustomTypes" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeCustomTypes() => this.CustomTypes.Count != 0;

    internal static bool yi9ntroFFhep9ZS91YsE() => ModuleSignature.F9PRqGWzznBtS7pKdXUB == null;

    internal static ModuleSignature fTFW6loFBOGDFbGxBP0v() => ModuleSignature.F9PRqGWzznBtS7pKdXUB;

    internal static int zROMrBoFW8cvktfjUR96([In] object obj0) => ((List<DataClassDependency>) obj0).Count;

    internal static int NdwgysoFoEBpYBG4onYo([In] object obj0) => ((List<FunctionDependency>) obj0).Count;

    internal static int YZ0UecoFbSRWIO5OHfRi([In] object obj0) => ((List<ComponentSignature>) obj0).Count;

    internal static int GuSYGgoFh7FkH3i787oC([In] object obj0) => ((List<ImplementationSignature>) obj0).Count;
  }
}

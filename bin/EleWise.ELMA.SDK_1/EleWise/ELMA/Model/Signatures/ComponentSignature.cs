// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Signatures.ComponentSignature
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Signatures
{
  /// <summary>
  /// Сигнатура компонента
  /// Вычисляется из метаданных, записывается в базу в отдельное поле, для упрощения поиска
  /// </summary>
  [Serializable]
  public sealed class ComponentSignature : Dependency
  {
    internal static ComponentSignature ze8JmFWzjK1AiXpwEPdR;

    /// <summary>ctor</summary>
    public ComponentSignature()
    {
      ComponentSignature.SqCk3OWzU0MUVZ91rxeU();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Inputs = new List<InputComputedValue>();
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.Implementations = new List<ImplementationSignature>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
            continue;
          default:
            this.ExtensionPoints = new List<ImplementationSignature>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 2 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список входных инпутов</summary>
    public List<InputComputedValue> Inputs { get; set; }

    /// <summary>
    /// Список реализуемых расширений, заполняется только в конфигурации
    /// </summary>
    public List<ImplementationSignature> Implementations { get; set; }

    /// <summary>
    /// Список используемых расширений в компоненте, заполняется только в конфигурации
    /// </summary>
    public List<ImplementationSignature> ExtensionPoints { get; set; }

    /// <summary>
    /// Реализация кастомного типа, заполняется только в конфигурации
    /// </summary>
    public CustomTypeImplementationModel CustomType
    {
      get => this.\u003CCustomType\u003Ek__BackingField;
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
              this.\u003CCustomType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 0 : 0;
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
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ComponentSignature.Inputs" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeInputs() => ComponentSignature.QvrnRuWzswPchoFjeZH0((object) this.Inputs) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ComponentSignature.Implementations" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeImplementations() => ComponentSignature.GyJdO9WzcabcZrGQ5mMe((object) this.Implementations) != 0;

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.Model.Signatures.ComponentSignature.ExtensionPoints" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeExtensionPoints() => ComponentSignature.GyJdO9WzcabcZrGQ5mMe((object) this.ExtensionPoints) != 0;

    internal static void SqCk3OWzU0MUVZ91rxeU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool lg6NgqWzYGmWLXZDflI6() => ComponentSignature.ze8JmFWzjK1AiXpwEPdR == null;

    internal static ComponentSignature M3N4L6WzL8ZNxAAKuy90() => ComponentSignature.ze8JmFWzjK1AiXpwEPdR;

    internal static int QvrnRuWzswPchoFjeZH0([In] object obj0) => ((List<InputComputedValue>) obj0).Count;

    internal static int GyJdO9WzcabcZrGQ5mMe([In] object obj0) => ((List<ImplementationSignature>) obj0).Count;
  }
}

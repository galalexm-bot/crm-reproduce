// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Metadata.IncludedProperty
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Metadata
{
  /// <summary>Реализация вложенного свойства</summary>
  [Serializable]
  public sealed class IncludedProperty : DatePartProperty
  {
    private static IncludedProperty MoALuCBhPVCN3dW0Krp8;

    /// <summary>ctor</summary>
    public IncludedProperty()
    {
      IncludedProperty.YVnb8rBh3BuZEsc4d5eF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.PropertyParents = new List<Guid>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Родительские свойства</summary>
    public List<Guid> PropertyParents { get; set; }

    /// <summary>
    /// Нужно ли сериализовать свойство <see cref="P:EleWise.ELMA.UI.Metadata.IncludedProperty.PropertyParents" />
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializePropertyParents() => IncludedProperty.YcxMHhBhpuWBtXTTQ4IU((object) this.PropertyParents) != 0;

    internal static void YVnb8rBh3BuZEsc4d5eF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool PKbquSBh1iPciabbNwWE() => IncludedProperty.MoALuCBhPVCN3dW0Krp8 == null;

    internal static IncludedProperty pXos8XBhNuewPyyhDyj9() => IncludedProperty.MoALuCBhPVCN3dW0Krp8;

    internal static int YcxMHhBhpuWBtXTTQ4IU([In] object obj0) => ((List<Guid>) obj0).Count;
  }
}

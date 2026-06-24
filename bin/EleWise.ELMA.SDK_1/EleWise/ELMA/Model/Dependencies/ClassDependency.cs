// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Dependencies.ClassDependency
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Signatures;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Dependencies
{
  /// <summary>Зависимость от класса</summary>
  [DataContract]
  [Serializable]
  public abstract class ClassDependency : Dependency
  {
    private static ClassDependency Kx2t0khit2JbyTWZ0P9e;

    /// <summary>Ctor</summary>
    protected ClassDependency()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Properties = new List<PropertySignature>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Список свойств</summary>
    [DataMember]
    public List<PropertySignature> Properties { get; set; }

    /// <summary>Нужно ли сериализовать</summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public bool ShouldSerializeProperties() => ClassDependency.Fui2FShi6Kk7ciBNruVM((object) this.Properties) != 0;

    internal static bool P0XEl2hiwSLwoOF7E48W() => ClassDependency.Kx2t0khit2JbyTWZ0P9e == null;

    internal static ClassDependency fxfZimhi4N2pGII7CnSo() => ClassDependency.Kx2t0khit2JbyTWZ0P9e;

    internal static int Fui2FShi6Kk7ciBNruVM([In] object obj0) => ((List<PropertySignature>) obj0).Count;
  }
}

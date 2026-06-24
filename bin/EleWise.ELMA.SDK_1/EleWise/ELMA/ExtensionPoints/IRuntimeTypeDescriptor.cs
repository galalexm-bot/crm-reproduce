// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IRuntimeTypeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Описание Runtime-типа</summary>
  public interface IRuntimeTypeDescriptor
  {
    /// <summary>Runtime-тип</summary>
    Type RuntimeType { get; }

    /// <summary>
    /// Можно ли использовать данное описание типа при определении описания типа по Runtime-типу
    /// </summary>
    bool IsRuntimeType { get; }
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.DeclarationModifiers
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.CodeGeneration
{
  [Flags]
  public enum DeclarationModifiers
  {
    None = 0,
    Abstract = 1,
    New = 2,
    Sealed = 4,
    Override = 8,
    Virtual = 16, // 0x00000010
    Static = 32, // 0x00000020
    Async = 64, // 0x00000040
    Const = 128, // 0x00000080
    ReadOnly = 256, // 0x00000100
    Unsafe = 512, // 0x00000200
    Partial = 1024, // 0x00000400
  }
}

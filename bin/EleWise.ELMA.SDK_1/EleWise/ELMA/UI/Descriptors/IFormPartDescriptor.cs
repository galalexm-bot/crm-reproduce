// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.IFormPartDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Metadata;
using System;

namespace EleWise.ELMA.UI.Descriptors
{
  public interface IFormPartDescriptor
  {
    IFormDescriptor FormDescriptor { get; }

    FormPartMetadata Metadata { get; }

    Type ContextType { get; }
  }
}

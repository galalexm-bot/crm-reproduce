// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.IPublicApplication
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.API.Models
{
  /// <summary>Интерфейс описания публичного приложения</summary>
  public interface IPublicApplication
  {
    Guid Uid { get; }

    string Name { get; }

    string Description { get; }

    string Author { get; }

    string Site { get; }
  }
}

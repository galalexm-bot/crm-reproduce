// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Licensing.Storages.IActivationKeyStorage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Licensing.Storages
{
  /// <summary>Хранилище ключей активации</summary>
  public interface IActivationKeyStorage
  {
    bool CanRead { get; }

    bool CanWrite { get; }

    Dictionary<Guid, string> GetActivationKeys();

    void AddActivationKey(Guid uid, string key);

    void RemoveActivationKey(Guid uid);
  }
}

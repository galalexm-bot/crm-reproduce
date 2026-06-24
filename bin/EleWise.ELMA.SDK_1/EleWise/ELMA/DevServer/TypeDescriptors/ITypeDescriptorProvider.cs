// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.TypeDescriptors.ITypeDescriptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Collections.Generic;

namespace EleWise.ELMA.DevServer.TypeDescriptors
{
  /// <summary>Провайдер дескрипторов типов для DevServer</summary>
  [Obsolete("Не использовать! Указанный API не зафиксирован и может быть изменен или удален в любой момент!", false)]
  public interface ITypeDescriptorProvider
  {
    /// <summary>Возвращает дескрипторы типов для DevServer</summary>
    /// <returns>Типы дескрипторов типов</returns>
    IEnumerable<Type> GetTypeDescriptors();
  }
}

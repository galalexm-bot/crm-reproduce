// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.IPagination`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections;
using System.Collections.Generic;

namespace EleWise.ELMA.Collections
{
  /// <summary>
  /// Generic form of <see cref="T:EleWise.ELMA.Collections.IPagination" />
  /// </summary>
  /// <typeparam name="T">Type of object being paged</typeparam>
  public interface IPagination<T> : IPagination, IEnumerable, IEnumerable<T>
  {
  }
}

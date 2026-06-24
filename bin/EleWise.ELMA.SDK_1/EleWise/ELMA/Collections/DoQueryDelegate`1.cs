// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Collections.DoQueryDelegate`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Collections
{
  /// <summary>Delegate method invoked to</summary>
  /// <typeparam name="T"></typeparam>
  /// <param name="sender"></param>
  /// <param name="e">Event arguments passed to the method</param>
  /// <returns>The page of data based on the parameters</returns>
  public delegate IList<T> DoQueryDelegate<T>(object sender, PagingQueryEventArgs e);
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.SyntaxTriviaExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.CodeGeneration.CSharp.Trivias;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EleWise.ELMA.Model.CodeGeneration
{
  public static class SyntaxTriviaExtension
  {
    public static ISyntaxTrivia Pack(this IEnumerable<SyntaxTrivia> syntaxTrivia) => (ISyntaxTrivia) new SyntaxTriviaContainer(syntaxTrivia);

    public static IEnumerable<SyntaxTrivia> Unpack(this ISyntaxTrivia syntaxTrivia) => ((SyntaxTriviaContainer) syntaxTrivia).SyntaxTrivia;

    public static IEnumerable<SyntaxTrivia> Unpack(this IEnumerable<ISyntaxTrivia> syntaxTrivias) => syntaxTrivias == null ? (IEnumerable<SyntaxTrivia>) null : syntaxTrivias.Where<ISyntaxTrivia>((Func<ISyntaxTrivia, bool>) (t => t != null)).SelectMany<ISyntaxTrivia, SyntaxTrivia>(new Func<ISyntaxTrivia, IEnumerable<SyntaxTrivia>>(SyntaxTriviaExtension.Unpack));
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.RestrictionBuilderBase`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Helpers
{
  public abstract class RestrictionBuilderBase<T>
  {
    protected internal readonly Restriction restriction;
    protected internal readonly RestrictionsBuilder<T> restrictionsBuilder;

    internal RestrictionBuilderBase(
      Restriction restriction,
      RestrictionsBuilder<T> restrictionsBuilder)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.restriction = restriction;
      this.restrictionsBuilder = restrictionsBuilder;
    }
  }
}

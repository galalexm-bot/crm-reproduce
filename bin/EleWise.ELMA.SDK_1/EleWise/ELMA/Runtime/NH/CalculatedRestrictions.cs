// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.CalculatedRestrictions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate.Criterion;

namespace EleWise.ELMA.Runtime.NH
{
  public static class CalculatedRestrictions
  {
    internal static CalculatedRestrictions I3cFxNWthbDpL3Kn2sJF;

    public static IProjection Addition(string firstPropertyName, string secondPropertyName) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Addition, firstPropertyName, secondPropertyName);

    public static IProjection Addition(IProjection firstProjection, IProjection secondProjection) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Addition, firstProjection, secondProjection);

    public static IProjection Subtraction(string firstPropertyName, string secondPropertyName) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Subtraction, firstPropertyName, secondPropertyName);

    public static IProjection Subtraction(IProjection firstProjection, IProjection secondProjection) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Subtraction, firstProjection, secondProjection);

    public static IProjection Multiplication(string firstPropertyName, string secondPropertyName) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Multiplication, firstPropertyName, secondPropertyName);

    public static IProjection Multiplication(
      IProjection firstProjection,
      IProjection secondProjection)
    {
      return (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Multiplication, firstProjection, secondProjection);
    }

    public static IProjection Division(string firstPropertyName, string secondPropertyName) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Division, firstPropertyName, secondPropertyName);

    public static IProjection Division(IProjection firstProjection, IProjection secondProjection) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Division, firstProjection, secondProjection);

    public static IProjection Minus(string propertyName) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Minus, propertyName, (string) null);

    public static IProjection Minus(IProjection projection) => (IProjection) new CalculatedProjection(CalculatedProjection.CalculationType.Minus, projection, (IProjection) null);

    internal static bool JGNA7eWtGK8N95jubf1V() => CalculatedRestrictions.I3cFxNWthbDpL3Kn2sJF == null;

    internal static CalculatedRestrictions LdLHcSWtERC4o9fJFWIE() => CalculatedRestrictions.I3cFxNWthbDpL3Kn2sJF;
  }
}

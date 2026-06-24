// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Common.GenericIdentityExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Model.Common
{
  public static class GenericIdentityExtensions
  {
    public static bool Same<T>(this IGenericIdentity<T> source, IGenericIdentity<T> target)
    {
      if (source == null && target == null)
        return true;
      return source != null && target != null && source.Id.Equals((object) target.Id);
    }
  }
}

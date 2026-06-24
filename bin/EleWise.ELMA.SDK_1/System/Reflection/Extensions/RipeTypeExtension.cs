// Decompiled with JetBrains decompiler
// Type: System.Reflection.Extensions.RipeTypeExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace System.Reflection.Extensions
{
  public static class RipeTypeExtension
  {
    public static RipeType ToRipeType(this Type type) => new RipeType(type);
  }
}

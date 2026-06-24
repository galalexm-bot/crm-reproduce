// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters.EnumToInt32Converter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters
{
  /// <summary>Конвертер из Enum в Int32 и обратно</summary>
  internal sealed class EnumToInt32Converter : ITypeConverter
  {
    private static EnumToInt32Converter A0GIu6hmburvs6pqweQ3;

    /// <inheritdoc />
    public Type Type => EnumToInt32Converter.hSfHMEhmEcNdo6TG2riH(__typeref (Enum));

    /// <inheritdoc />
    public bool CanConvertTo(Type type) => EnumToInt32Converter.ieGnD7hmfaO1TttTr1T2(type, TypeOf<int>.Raw);

    /// <inheritdoc />
    public object ConvertTo(object value, Type destinationType) => Convert.ChangeType(value, TypeCode.Int32);

    public EnumToInt32Converter()
    {
      EnumToInt32Converter.BgBhwMhmQvuMZ8FGGSDo();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type hSfHMEhmEcNdo6TG2riH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ieGnD7hmfaO1TttTr1T2([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool bTB4qOhmhcBNEIvl6Jng() => EnumToInt32Converter.A0GIu6hmburvs6pqweQ3 == null;

    internal static EnumToInt32Converter zIPZXNhmGneKRRRwbHer() => EnumToInt32Converter.A0GIu6hmburvs6pqweQ3;

    internal static void BgBhwMhmQvuMZ8FGGSDo() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

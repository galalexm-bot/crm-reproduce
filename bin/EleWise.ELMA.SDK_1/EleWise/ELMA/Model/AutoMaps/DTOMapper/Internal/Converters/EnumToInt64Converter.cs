// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters.EnumToInt64Converter
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
  /// <summary>Конвертер из Enum в Int64 и обратно</summary>
  internal sealed class EnumToInt64Converter : ITypeConverter
  {
    private static EnumToInt64Converter HB3mkKh0sF0mTRwdCtJU;

    /// <inheritdoc />
    public Type Type => EnumToInt64Converter.pd5FYvhmFRM6oV2lvODd(__typeref (Enum));

    /// <inheritdoc />
    public bool CanConvertTo(Type type) => EnumToInt64Converter.j2dZnYhmB3YmDuZAGsH3(type, TypeOf<long>.Raw);

    /// <inheritdoc />
    public object ConvertTo(object value, Type destinationType) => EnumToInt64Converter.gJtOJBhmW0Mt5umyXQIo(value, TypeCode.Int64);

    public EnumToInt64Converter()
    {
      EnumToInt64Converter.hZI0nphmoXfb4m08HpJE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type pd5FYvhmFRM6oV2lvODd([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool j2dZnYhmB3YmDuZAGsH3([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static bool eYrlaoh0cpRr8l3n1ZP6() => EnumToInt64Converter.HB3mkKh0sF0mTRwdCtJU == null;

    internal static EnumToInt64Converter SdscJEh0zMk5qlximYXx() => EnumToInt64Converter.HB3mkKh0sF0mTRwdCtJU;

    internal static object gJtOJBhmW0Mt5umyXQIo([In] object obj0, [In] TypeCode obj1) => Convert.ChangeType(obj0, obj1);

    internal static void hZI0nphmoXfb4m08HpJE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

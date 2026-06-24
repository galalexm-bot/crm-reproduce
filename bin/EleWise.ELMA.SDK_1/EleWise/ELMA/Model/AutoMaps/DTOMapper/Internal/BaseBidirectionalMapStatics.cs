// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.BaseBidirectionalMapStatics
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.Converters;
using EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal.InstanceCreators;
using j3AmrhgkCleVTGdEwA;
using System.Collections.Generic;

namespace EleWise.ELMA.Model.AutoMaps.DTOMapper.Internal
{
  /// <summary>
  /// Статический класс для статических членов BaseBidirectionalMap
  /// </summary>
  internal static class BaseBidirectionalMapStatics
  {
    internal static BaseBidirectionalMapStatics RlPWKFh0bhUeRg3NSfR0;

    /// <summary>Список создателей экземпляров</summary>
    internal static List<IInstanceCreator> InstanceCreators { get; }

    /// <summary>Список конвертеров типов</summary>
    internal static List<ITypeConverter> TypeConverters { get; }

    static BaseBidirectionalMapStatics()
    {
      int num1 = 3;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_3;
            case 1:
              BaseBidirectionalMapStatics.TypeConverters = new List<ITypeConverter>()
              {
                (ITypeConverter) new EnumToInt32Converter(),
                (ITypeConverter) new EnumToInt64Converter()
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            case 2:
              BaseBidirectionalMapStatics.InstanceCreators = new List<IInstanceCreator>()
              {
                (IInstanceCreator) new EntityInstanceCreator(),
                (IInstanceCreator) new DefaultInstanceCreator()
              };
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
              continue;
            case 3:
              goto label_6;
            default:
              goto label_7;
          }
        }
label_6:
        BaseBidirectionalMapStatics.Jan2qbh0Eps5pMuoV1AK();
        num1 = 2;
      }
label_3:
      return;
label_7:;
    }

    internal static void Jan2qbh0Eps5pMuoV1AK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GUXb4Mh0hmVRnq12G0hS() => BaseBidirectionalMapStatics.RlPWKFh0bhUeRg3NSfR0 == null;

    internal static BaseBidirectionalMapStatics YiVFfMh0GB7fNshn3fCX() => BaseBidirectionalMapStatics.RlPWKFh0bhUeRg3NSfR0;
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.DataClassTypeReferenceNHManagerRegistrar
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Autofac;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>
  /// Регистратор менеджера для ссылок типов DTO на метаданные
  /// </summary>
  [Component]
  internal sealed class DataClassTypeReferenceNHManagerRegistrar : INHManagerRegistrar
  {
    internal static DataClassTypeReferenceNHManagerRegistrar jDk0X2bIISAWTfV8tuPV;

    /// <inheritdoc />
    public void Register(NHManagerRegisterParams parameters)
    {
      int num1 = 2;
      IStartInformation startInformation;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_14;
          case 1:
            goto label_4;
          case 2:
            startInformation = (IStartInformation) DataClassTypeReferenceNHManagerRegistrar.HjWnwbbIqSLBGtGsbE85(99.0, DataClassTypeReferenceNHManagerRegistrar.XCw3LfbIRV8nNwjluwyo(DataClassTypeReferenceNHManagerRegistrar.FeJaRebIiHNJcxRtHB3W(-630932142 - 1120244082 ^ -1751281032)));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 1 : 1;
            continue;
          default:
            goto label_9;
        }
      }
label_14:
      return;
label_9:
      return;
label_4:
      try
      {
        ((ContainerBuilder) DataClassTypeReferenceNHManagerRegistrar.mrJJ1IbIKrgkTPrQ923s((object) parameters)).RegisterNHManager(typeof (DataClassTypeReferenceManager)).As<DataClassTypeReferenceManager>().As<IDataClassTypeReferenceManager>().SingleInstance();
        int num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num2 = 0;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_7;
            case 1:
              parameters.Add<DataClassTypeReferenceNHMap>();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_7:
        return;
label_2:;
      }
      finally
      {
        if (startInformation != null)
        {
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
            num3 = 1;
          while (true)
          {
            switch (num3)
            {
              case 1:
                DataClassTypeReferenceNHManagerRegistrar.UQG57TbIXsksAThK7Efm((object) startInformation);
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
                continue;
              default:
                goto label_16;
            }
          }
        }
label_16:;
      }
    }

    public DataClassTypeReferenceNHManagerRegistrar()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object FeJaRebIiHNJcxRtHB3W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object XCw3LfbIRV8nNwjluwyo([In] object obj0) => (object) EleWise.ELMA.SR.M((string) obj0);

    internal static object HjWnwbbIqSLBGtGsbE85(double completePercent, [In] object obj1) => (object) StartInformation.Operation(completePercent, (string) obj1);

    internal static object mrJJ1IbIKrgkTPrQ923s([In] object obj0) => (object) ((NHManagerRegisterParams) obj0).Builder;

    internal static void UQG57TbIXsksAThK7Efm([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool hZEUr3bIV60w3IlGLDh8() => DataClassTypeReferenceNHManagerRegistrar.jDk0X2bIISAWTfV8tuPV == null;

    internal static DataClassTypeReferenceNHManagerRegistrar Qwm7yAbISBr73eO4pdBI() => DataClassTypeReferenceNHManagerRegistrar.jDk0X2bIISAWTfV8tuPV;
  }
}

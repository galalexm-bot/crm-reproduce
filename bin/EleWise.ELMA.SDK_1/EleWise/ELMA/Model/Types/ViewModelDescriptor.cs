// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.ViewModelDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Дескриптор для типа "ViewModel"</summary>
  [Component(Order = 2147483647)]
  public sealed class ViewModelDescriptor : DataClassDescriptor
  {
    private new static readonly Guid UID;
    private IEnumerable<IViewModelDescriptorExtension> handlers;
    private static ViewModelDescriptor xfHTJro4xu2r1eGDtpey;

    private IEnumerable<IViewModelDescriptorExtension> Handlers => this.handlers ?? (this.handlers = Locator.GetServiceNotNull<IEnumerable<IViewModelDescriptorExtension>>());

    /// <inheritdoc />
    public override Guid Uid => ViewModelDescriptor.UID;

    /// <inheritdoc />
    public override string Name => (string) ViewModelDescriptor.RNs8TFo4y5e6Nph7wXVk((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36127897));

    /// <inheritdoc />
    public override bool Visible => false;

    /// <inheritdoc />
    internal override DataClass.ValueContainer GetValueContainer(string typeRef)
    {
      int num1 = 4;
      string typeRef1;
      while (true)
      {
        int num2 = num1;
        IViewModelDescriptorExtension descriptorExtension;
        while (true)
        {
          switch (num2)
          {
            case 1:
              // ISSUE: reference to a compiler-generated method
              descriptorExtension = this.Handlers.FirstOrDefault<IViewModelDescriptorExtension>((Func<IViewModelDescriptorExtension, bool>) (h => ViewModelDescriptor.\u003C\u003Ec__DisplayClass11_0.yDUV0JCuWAaaNsUiKSUA((object) h, (object) typeRef1)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 2 : 2;
              continue;
            case 2:
              if (descriptorExtension == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              }
              if (!(descriptorExtension.GetMetadata(typeRef1) is EntityMetadata metadata))
              {
                num2 = 5;
                continue;
              }
              goto label_5;
            case 3:
              typeRef1 = typeRef;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0 ? 1 : 1;
              continue;
            case 4:
              goto label_8;
            case 5:
              goto label_4;
            default:
              goto label_10;
          }
        }
label_8:
        num1 = 3;
      }
label_4:
      return base.GetValueContainer(typeRef1);
label_5:
      return DataClass.ValueContainer.CreateViewModelValueContainer(metadata);
label_10:
      return base.GetValueContainer(typeRef1);
    }

    public ViewModelDescriptor()
    {
      ViewModelDescriptor.fdevoCo4MuOkPIPvVAF1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static ViewModelDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ViewModelDescriptor.UID = new Guid((string) ViewModelDescriptor.npEY1Po4JOD0kYpI0j46(95909607 + 343705423 ^ 439452892));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object RNs8TFo4y5e6Nph7wXVk([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool lcCKdLo408AKnnKxedUu() => ViewModelDescriptor.xfHTJro4xu2r1eGDtpey == null;

    internal static ViewModelDescriptor laqv9Xo4mbbH6P4ZNHkw() => ViewModelDescriptor.xfHTJro4xu2r1eGDtpey;

    internal static void fdevoCo4MuOkPIPvVAF1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object npEY1Po4JOD0kYpI0j46(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}

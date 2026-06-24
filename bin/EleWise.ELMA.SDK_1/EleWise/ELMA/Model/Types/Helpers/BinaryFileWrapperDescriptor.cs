// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.BinaryFileWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class BinaryFileWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static BinaryFileWrapperDescriptor sMDByBboMgmQn4wxqjYp;

    public Type OriginalType => typeof (BinaryFile);

    public Type WrapperType => BinaryFileWrapperDescriptor.B5q2AabodBg4kBqnIxjq(__typeref (BinaryFileWrapper));

    public object CreateWrapper(object obj) => (object) new BinaryFileWrapper((BinaryFile) obj);

    public object GetObject(object wrapper)
    {
      int num = 3;
      BinaryFileWrapper binaryFileWrapper;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            if (binaryFileWrapper == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 3:
            binaryFileWrapper = wrapper as BinaryFileWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 2 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_2:
      BinaryFile binaryFile = new BinaryFile();
      binaryFile.Id = binaryFileWrapper.Id;
      BinaryFileWrapperDescriptor.M8AWQAborxJL2tpoFurH((object) binaryFile, BinaryFileWrapperDescriptor.fLSS1HbolMMwnU22OdUB((object) binaryFileWrapper));
      return (object) binaryFile;
label_3:
      return (object) null;
    }

    public bool TestType(Type type) => false;

    public BinaryFileWrapperDescriptor()
    {
      BinaryFileWrapperDescriptor.FkZkXCbogDc4dUmkUBaY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type B5q2AabodBg4kBqnIxjq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool u36EnVboJKPeYkY7RBsc() => BinaryFileWrapperDescriptor.sMDByBboMgmQn4wxqjYp == null;

    internal static BinaryFileWrapperDescriptor HV944nbo984mRAjYUvI0() => BinaryFileWrapperDescriptor.sMDByBboMgmQn4wxqjYp;

    internal static object fLSS1HbolMMwnU22OdUB([In] object obj0) => (object) ((BinaryFileWrapper) obj0).SecondId;

    internal static void M8AWQAborxJL2tpoFurH([In] object obj0, [In] object obj1) => ((BinaryFile) obj0).SecondId = (string) obj1;

    internal static void FkZkXCbogDc4dUmkUBaY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

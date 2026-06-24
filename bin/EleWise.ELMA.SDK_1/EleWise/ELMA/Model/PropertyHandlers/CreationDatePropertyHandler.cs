// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.PropertyHandlers.CreationDatePropertyHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.PropertyHandlers
{
  /// <summary>Обработчик свойства "Дата создания"</summary>
  [Component(Order = 100)]
  public class CreationDatePropertyHandler : TypedPropertyHandler
  {
    /// <summary>UID данного обработчика</summary>
    public const string UID_S = "{D0C00D8A-E003-427D-9942-F52CFB77B0F0}";
    /// <summary>UID данного обработчика</summary>
    public static readonly Guid UID;
    private static CreationDatePropertyHandler rqG5o3WcEt37TfBjXcEN;

    /// <summary>Уникальный идентификатор обработчика</summary>
    public override Guid Uid => CreationDatePropertyHandler.UID;

    /// <summary>Имя обработчика (для текущей культуры)</summary>
    public override string Name => (string) CreationDatePropertyHandler.mben0yWcvo64QhjYs1Pm(CreationDatePropertyHandler.EgJ5NiWcCwdyjucEgNdY(-680446928 - -370807692 ^ -309616284));

    /// <summary>Uid типа, для которого предназначен обработчик</summary>
    protected override Guid? TypeUid => new Guid?(DateTimeDescriptor.UID);

    public CreationDatePropertyHandler()
    {
      CreationDatePropertyHandler.eTnwf9Wc8fYr9Skd7Obl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static CreationDatePropertyHandler()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            CreationDatePropertyHandler.eTnwf9Wc8fYr9Skd7Obl();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            CreationDatePropertyHandler.UID = new Guid((string) CreationDatePropertyHandler.EgJ5NiWcCwdyjucEgNdY(993438473 ^ 993324913));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static object EgJ5NiWcCwdyjucEgNdY(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object mben0yWcvo64QhjYs1Pm([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool AJDjo9WcfZRoF9hTfIR2() => CreationDatePropertyHandler.rqG5o3WcEt37TfBjXcEN == null;

    internal static CreationDatePropertyHandler HXVtFiWcQGT2qOli8lbd() => CreationDatePropertyHandler.rqG5o3WcEt37TfBjXcEN;

    internal static void eTnwf9Wc8fYr9Skd7Obl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

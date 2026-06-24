// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.Services.GroupDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Security.Services
{
  public class GroupDescriptor
  {
    private Guid uid;
    private string name;
    private string description;
    private static GroupDescriptor hVohvtBUz6pnkNK2m39J;

    public GroupDescriptor(Guid uid, string name, string description)
    {
      GroupDescriptor.fVO9FPBsWqCwpcfR5wQk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.name = name;
            num = 3;
            continue;
          case 2:
            this.uid = uid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 0;
            continue;
          case 3:
            this.description = description;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    public Guid Uid => this.uid;

    public string Name => this.name;

    public string Description => this.description;

    internal static void fVO9FPBsWqCwpcfR5wQk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool THan3OBsFkPFNV6d5p5u() => GroupDescriptor.hVohvtBUz6pnkNK2m39J == null;

    internal static GroupDescriptor xqydYdBsBsEEIRD9WOgV() => GroupDescriptor.hVohvtBUz6pnkNK2m39J;
  }
}

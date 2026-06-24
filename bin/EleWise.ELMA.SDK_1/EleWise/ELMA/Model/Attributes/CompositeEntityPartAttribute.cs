// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.CompositeEntityPartAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Указывает тип сущности, являющейся частью для данной составной сущности
  /// </summary>
  [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
  public class CompositeEntityPartAttribute : Attribute
  {
    private Type entityType;
    private int tableNumber;
    internal static CompositeEntityPartAttribute AU0RQjouG2bGCdnuiLAI;

    public CompositeEntityPartAttribute(Type entityType, int tableNumber)
    {
      CompositeEntityPartAttribute.WNvbXAouQZNXFCdohLNA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.tableNumber = tableNumber;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
            continue;
          default:
            this.entityType = entityType;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    public Type EntityType => this.entityType;

    public int TableNumber => this.tableNumber;

    internal static void WNvbXAouQZNXFCdohLNA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool rh3TWuouEP2ASOPEx3rZ() => CompositeEntityPartAttribute.AU0RQjouG2bGCdnuiLAI == null;

    internal static CompositeEntityPartAttribute vg0WYuoufOpyY55AQVDi() => CompositeEntityPartAttribute.AU0RQjouG2bGCdnuiLAI;
  }
}

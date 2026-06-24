// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Events.Audit.EntityAuditObjectType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Events.Audit;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Events.Audit
{
  /// <summary>Тип объекта "Сущность"</summary>
  [Serializable]
  public class EntityAuditObjectType : IAuditObjectType
  {
    /// <summary>UID</summary>
    public const string UID_S = "{CA0411EC-8D96-4D56-93CD-08FFADB1CE01}";
    /// <summary>UID</summary>
    public static readonly Guid UID;
    private static readonly EntityAuditObjectType instance;
    private static EntityAuditObjectType OM5x0woWvv3Uk9ISkvHM;

    /// <summary>Экземпляр типа объекта "Сущность"</summary>
    public static IAuditObjectType Instance => (IAuditObjectType) EntityAuditObjectType.instance;

    /// <summary>UID</summary>
    public Guid Uid => EntityAuditObjectType.UID;

    static EntityAuditObjectType()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            EntityAuditObjectType.UID = new Guid((string) EntityAuditObjectType.VuvQkXoWukcpDUX5S4EF(1642859704 ^ 1643006754));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 0;
            continue;
          case 3:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = 2;
            continue;
          default:
            EntityAuditObjectType.instance = new EntityAuditObjectType();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    public EntityAuditObjectType()
    {
      EntityAuditObjectType.XXnK1uoWIianGfIWh30C();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object VuvQkXoWukcpDUX5S4EF(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool AuSX4AoW8dBG3KlD73Uu() => EntityAuditObjectType.OM5x0woWvv3Uk9ISkvHM == null;

    internal static EntityAuditObjectType VfAgDqoWZ0kZA9PIbqdL() => EntityAuditObjectType.OM5x0woWvv3Uk9ISkvHM;

    internal static void XXnK1uoWIianGfIWh30C() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.InstancePermissionAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Тип привилегий доступа</summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
  public class InstancePermissionAttribute : Attribute
  {
    private readonly bool enabled;
    private readonly string permissionPropertyName;
    private readonly string permissionClassName;
    internal static InstancePermissionAttribute uYVZtCoflyH0Iyf3wlBj;

    /// <summary>Привилегии уровня экземпляра не включены</summary>
    public InstancePermissionAttribute()
    {
      InstancePermissionAttribute.TAE6KQof5INvUU9lSwHh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="enabled">Включена ли поддержка прав доступа на уровне экземпляра</param>
    public InstancePermissionAttribute(bool enabled)
    {
      InstancePermissionAttribute.TAE6KQof5INvUU9lSwHh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.enabled = enabled;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    /// <param name="enabled">Включена ли поддержка прав доступа на уровне экземпляра</param>
    /// <param name="permissionClassName">Имя класса привилегий</param>
    /// <param name="permissionPropertyName">Имя свойства блока привилегий</param>
    public InstancePermissionAttribute(
      bool enabled,
      string permissionClassName,
      string permissionPropertyName)
    {
      InstancePermissionAttribute.TAE6KQof5INvUU9lSwHh();
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
            this.permissionPropertyName = permissionPropertyName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
            continue;
          case 2:
            this.enabled = enabled;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 3 : 1;
            continue;
          case 3:
            this.permissionClassName = permissionClassName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 1 : 1;
            continue;
          default:
            goto label_6;
        }
      }
label_2:
      return;
label_6:;
    }

    /// <summary>Включено ли кешироване</summary>
    public bool Enabled => this.enabled;

    /// <summary>Имя свойства привилегий</summary>
    public string PermissionPropertyName => this.permissionPropertyName;

    /// <summary>Имя класса привилегий</summary>
    public string PermissionClassName => this.permissionClassName;

    internal static void TAE6KQof5INvUU9lSwHh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool CeajhfofrU7SLwMAM9og() => InstancePermissionAttribute.uYVZtCoflyH0Iyf3wlBj == null;

    internal static InstancePermissionAttribute LS90vWofgqTNsWc4nYSr() => InstancePermissionAttribute.uYVZtCoflyH0Iyf3wlBj;
  }
}

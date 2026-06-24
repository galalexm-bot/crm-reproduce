// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.PermissionStereotype
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Security
{
  /// <summary>Информация о назначении привилеги ролям по умолчанию</summary>
  public class PermissionStereotype
  {
    internal static PermissionStereotype xwvdHxBj65Ms4wj80aVr;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="permissions"></param>
    /// <param name="defaultAssignee"></param>
    public PermissionStereotype(
      IEnumerable<Permission> permissions,
      GroupDescriptor defaultAssignee)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      if (permissions == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1021410165 ^ 1021313971));
      if (defaultAssignee == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(825385222 ^ 825432550));
      this.Permissions = permissions;
      this.DefaultAssignee = defaultAssignee;
    }

    /// <summary>Привилегии</summary>
    public IEnumerable<Permission> Permissions { get; private set; }

    /// <summary>Назначение роли по умолчанию</summary>
    public GroupDescriptor DefaultAssignee
    {
      get => this.\u003CDefaultAssignee\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CDefaultAssignee\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal static bool QX7fFtBjH6kPgHFwk1tD() => PermissionStereotype.xwvdHxBj65Ms4wj80aVr == null;

    internal static PermissionStereotype S6ACWNBjAJnYQTIefE6R() => PermissionStereotype.xwvdHxBj65Ms4wj80aVr;
  }
}

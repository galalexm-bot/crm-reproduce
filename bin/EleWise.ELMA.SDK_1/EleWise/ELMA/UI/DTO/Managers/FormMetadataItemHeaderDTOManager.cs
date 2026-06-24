// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.FormMetadataItemHeaderDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.Managers;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public class FormMetadataItemHeaderDTOManager : 
    DTOManager,
    IFormMetadataItemHeaderDTOManager,
    IConfigurationService
  {
    private static FormMetadataItemHeaderDTOManager X1y49J90QPwq6DGi7Ym;

    public FormMetadataItemHeaderManager Manager
    {
      get => this.\u003CManager\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CManager\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    public ISecurityService SecurityService
    {
      get => this.\u003CSecurityService\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CSecurityService\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
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

    public virtual long GetPublishingVersionNumber(long headerId) => FormMetadataItemHeaderDTOManager.OetfEb9M76BBwWdhp4F((object) this.Manager, headerId);

    public virtual void Delete(long headerId)
    {
      int num1 = 3;
      FormMetadataItemHeaderDTOManager headerDtoManager;
      long headerId1;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_2;
          case 1:
            headerId1 = headerId;
            num1 = 4;
            continue;
          case 2:
            headerDtoManager = this;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 1 : 1;
            continue;
          case 3:
            num1 = 2;
            continue;
          case 4:
            FormMetadataItemHeaderDTOManager.penDaK9JvX6QPdyHPnD((object) this.SecurityService, (object) (System.Action) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    FormMetadataItemHeaderDTOManager.\u003C\u003Ec__DisplayClass9_0.UZIXNkf5AlwhvISu012X((object) headerDtoManager.Manager, headerId1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    public virtual bool ValidateName(
      long headerId,
      Guid metadataType,
      string name,
      out string errorMessage)
    {
      return this.Manager.ValidateName(headerId, metadataType, name, out errorMessage);
    }

    public virtual bool ValidateDisplayName(
      long headerId,
      Guid metadataType,
      string displayName,
      out string errorMessage)
    {
      return this.Manager.ValidateDisplayName(headerId, metadataType, displayName, out errorMessage);
    }

    public virtual string GetDisplayName(Guid uid)
    {
      int num1 = 5;
      string displayName;
      while (true)
      {
        int num2 = num1;
        FormMetadataItemHeaderDTOManager headerDtoManager;
        Guid uid1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_3;
            case 2:
              this.SecurityService.RunWithElevatedPrivilegies((System.Action) (() =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      displayName = headerDtoManager.Manager.Load(uid1).DisplayName;
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              }));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 1 : 1;
              continue;
            case 3:
              displayName = "";
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 != 0 ? 2 : 1;
              continue;
            case 4:
              headerDtoManager = this;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
              continue;
            case 5:
              goto label_5;
            default:
              uid1 = uid;
              num2 = 3;
              continue;
          }
        }
label_5:
        num1 = 4;
      }
label_3:
      return displayName;
    }

    public FormMetadataItemHeaderDTOManager()
    {
      FormMetadataItemHeaderDTOManager.FgZ7ft99yYHChx8Xdli();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool G66PFi9mmi2WIpG5C0F() => FormMetadataItemHeaderDTOManager.X1y49J90QPwq6DGi7Ym == null;

    internal static FormMetadataItemHeaderDTOManager uqjTHt9ydMhYj1e37BW() => FormMetadataItemHeaderDTOManager.X1y49J90QPwq6DGi7Ym;

    internal static long OetfEb9M76BBwWdhp4F([In] object obj0, long headerId) => ((FormMetadataItemHeaderManager) obj0).GetPublishingVersionNumber(headerId);

    internal static void penDaK9JvX6QPdyHPnD([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void FgZ7ft99yYHChx8Xdli() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

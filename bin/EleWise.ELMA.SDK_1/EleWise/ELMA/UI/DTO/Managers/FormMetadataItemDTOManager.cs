// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.DTO.Managers.FormMetadataItemDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.UI.DTO.Models;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.DTO.Managers
{
  public class FormMetadataItemDTOManager : 
    DTOManager,
    IFormMetadataItemDTOManager,
    IConfigurationService
  {
    private static FormMetadataItemDTOManager thokMm9wY1mUdfwXmsQ;

    public FormMetadataItemManager Manager
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    public virtual FormMetadataItemDTO Load(long id) => Mapper.Map<IFormMetadataItem, FormMetadataItemDTO>(this.Manager.Load(id));

    public virtual FormMetadataItemDTO Save(FormMetadataItemDTO objDto)
    {
      int num = 3;
      IFormMetadataItem source;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Manager.Save(source);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 2:
            source = Mapper.Map<FormMetadataItemDTO, IFormMetadataItem>(objDto);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 1 : 1;
            continue;
          case 3:
            FormMetadataItemDTOManager.pp7Gi49A2NsGfredKYR((object) objDto, FormMetadataItemDTOManager.OdLLWy9HXapY3rHJn7m(1461825605 - 1531863589 ^ -69999974));
            num = 2;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return Mapper.Map<IFormMetadataItem, FormMetadataItemDTO>(source);
    }

    public virtual void Publish(long headerId, string comment, bool forEmulation)
    {
      int num1 = 2;
      FormMetadataItemDTOManager metadataItemDtoManager;
      long headerId1;
      string comment1;
      bool forEmulation1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            metadataItemDtoManager = this;
            num1 = 4;
            continue;
          case 2:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 1 : 1;
            continue;
          case 3:
            FormMetadataItemDTOManager.u1aCRA97JHK850XRbio((object) this.SecurityService, (object) (System.Action) (() =>
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
                    FormMetadataItemDTOManager.\u003C\u003Ec__DisplayClass10_0.Jwujlgf5t3RQfGjFw5Ib((object) metadataItemDtoManager.Manager, headerId1, (object) comment1, forEmulation1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = 5;
            continue;
          case 4:
            headerId1 = headerId;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
            continue;
          case 5:
            goto label_2;
          case 6:
            forEmulation1 = forEmulation;
            num1 = 3;
            continue;
          default:
            comment1 = comment;
            num1 = 6;
            continue;
        }
      }
label_2:;
    }

    public virtual void Publish(long[] headerIds, string comment)
    {
      int num = 3;
      long[] numArray;
      int index;
      long headerId;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Publish(headerId, comment, false);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 3 : 6;
            continue;
          case 2:
            numArray = headerIds;
            num = 9;
            continue;
          case 3:
            FormMetadataItemDTOManager.pp7Gi49A2NsGfredKYR((object) headerIds, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886609083));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 2 : 0;
            continue;
          case 4:
          case 7:
            headerId = numArray[index];
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 0;
            continue;
          case 5:
            goto label_6;
          case 6:
            ++index;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 9:
            index = 0;
            num = 8;
            continue;
          default:
            if (index < numArray.Length)
            {
              num = 7;
              continue;
            }
            goto label_3;
        }
      }
label_6:
      return;
label_3:;
    }

    public FormMetadataItemDTOManager()
    {
      FormMetadataItemDTOManager.h3duLa9xuDIA45aajDg();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NBcNEk94ADViCo31Khb() => FormMetadataItemDTOManager.thokMm9wY1mUdfwXmsQ == null;

    internal static FormMetadataItemDTOManager CqUd8V96C40yuNSu8ct() => FormMetadataItemDTOManager.thokMm9wY1mUdfwXmsQ;

    internal static object OdLLWy9HXapY3rHJn7m(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void pp7Gi49A2NsGfredKYR([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void u1aCRA97JHK850XRbio([In] object obj0, [In] object obj1) => ((ISecurityService) obj0).RunWithElevatedPrivilegies((System.Action) obj1);

    internal static void h3duLa9xuDIA45aajDg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

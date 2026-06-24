// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.DTO.CommonSettingsDTOManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.Settings.DTO
{
  public class CommonSettingsDTOManager : 
    DTOManager,
    ICommonSettingsDTOManager,
    IConfigurationService
  {
    private static CommonSettingsDTOManager UZ27PVWGn64x6iFgyiAA;

    public virtual string GetApplicationBaseUrl() => (string) CommonSettingsDTOManager.SxK29fWGefLi7AKOvCO1((object) Locator.GetServiceNotNull<CommonSettingsModule>().Settings);

    public CommonSettingsDTOManager()
    {
      CommonSettingsDTOManager.zmhLEZWGPQ85mG0xBlip();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object SxK29fWGefLi7AKOvCO1([In] object obj0) => (object) ((CommonSettings) obj0).ApplicationBaseUrl;

    internal static bool HK4SUIWGOymJ6iKEFy3B() => CommonSettingsDTOManager.UZ27PVWGn64x6iFgyiAA == null;

    internal static CommonSettingsDTOManager ibJAKnWG24I7ipvOBeNT() => CommonSettingsDTOManager.UZ27PVWGn64x6iFgyiAA;

    internal static void zmhLEZWGPQ85mG0xBlip() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

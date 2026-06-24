// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Globalization.BaseLocalizationFileResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Globalization
{
  public abstract class BaseLocalizationFileResolver : ILocalizationFileResolver
  {
    private static BaseLocalizationFileResolver YnktLUGox97ofNHvIyhZ;

    public abstract string FileName { get; }

    public abstract IEnumerable<PoLineDescriptor> CollectResources(LocalizationLoadSettings settings);

    protected virtual EntityMetadata LoadOrNullMetadata(Guid uid)
    {
      int num1 = 1;
      EntityMetadata metadata;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          case 2:
            metadata = (EntityMetadata) null;
            num1 = 4;
            continue;
          case 3:
            goto label_3;
          case 4:
            goto label_4;
          default:
            uid1 = uid;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 2 : 1;
            continue;
        }
      }
label_3:
      return metadata;
label_4:
      try
      {
        EleWise.ELMA.SR.RunWithCulture((CultureInfo) BaseLocalizationFileResolver.jrQl5WGoyhQZe6HhCEKG(), (System.Action) (() =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                metadata = MetadataLoader.LoadMetadata(uid1) as EntityMetadata;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
          num3 = 0;
        switch (num3)
        {
          default:
            goto label_3;
        }
      }
      catch (Exception ex)
      {
        int num4 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              BaseLocalizationFileResolver.ECuDeBGo9Zi43hEDMTtm(BaseLocalizationFileResolver.ne0Y0GGoMnii35RUWuEV(), BaseLocalizationFileResolver.xp0uVmGoJOZt3GsK8Ma4((object) ex), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
      }
    }

    protected virtual EnumMetadata LoadOrNullEnumMetadata(Guid uid)
    {
      int num1 = 4;
      EnumMetadata metadata;
      Guid uid1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_13;
          case 2:
            metadata = (EnumMetadata) null;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b == 0 ? 0 : 0;
            continue;
          case 3:
            uid1 = uid;
            num1 = 2;
            continue;
          case 4:
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 3 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_4:
      try
      {
        BaseLocalizationFileResolver.sTdDnRGodpWd6iREdFMR(BaseLocalizationFileResolver.jrQl5WGoyhQZe6HhCEKG(), (object) (System.Action) (() =>
        {
          int num2 = 1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_2;
              case 1:
                metadata = MetadataLoader.LoadMetadata(uid1) as EnumMetadata;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
                continue;
              default:
                goto label_4;
            }
          }
label_2:
          return;
label_4:;
        }));
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
          num3 = 0;
        switch (num3)
        {
        }
      }
      catch (Exception ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_13;
            default:
              BaseLocalizationFileResolver.ECuDeBGo9Zi43hEDMTtm(BaseLocalizationFileResolver.ne0Y0GGoMnii35RUWuEV(), BaseLocalizationFileResolver.xp0uVmGoJOZt3GsK8Ma4((object) ex), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 1;
              continue;
          }
        }
      }
label_13:
      return metadata;
    }

    protected virtual void GetFromEnum(EnumMetadata metadata, List<PoLineDescriptor> res)
    {
      if (metadata == null)
        return;
      this.AddWithCheck(res, metadata.DisplayName);
      this.AddWithCheck(res, metadata.Description);
      foreach (EnumValueMetadata enumValueMetadata in metadata.Values)
      {
        this.AddWithCheck(res, enumValueMetadata.DisplayName);
        this.AddWithCheck(res, enumValueMetadata.Description);
      }
    }

    protected virtual void GetFromMetadata(EntityMetadata metadata, List<PoLineDescriptor> res)
    {
      if (metadata == null)
        return;
      this.AddWithCheck(res, metadata.DisplayName);
      this.AddWithCheck(res, metadata.Description);
      foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
      {
        this.AddWithCheck(res, propertiesAndTablePart.DisplayName);
        this.AddWithCheck(res, propertiesAndTablePart.Description);
        this.GetFromPropertyType(propertiesAndTablePart as PropertyMetadata, res);
        if (propertiesAndTablePart is TablePartMetadata metadata1)
          this.GetFromMetadata((EntityMetadata) metadata1, res);
      }
      foreach (EntityPropertyMetadata entityProperty in (IEnumerable<EntityPropertyMetadata>) metadata.EntityProperties)
      {
        this.AddWithCheck(res, entityProperty.DisplayName);
        this.AddWithCheck(res, entityProperty.Description);
        this.GetFromPropertyType((PropertyMetadata) entityProperty, res);
      }
      foreach (TablePartMetadata entityTablePart in (IEnumerable<TablePartMetadata>) metadata.EntityTableParts)
      {
        this.AddWithCheck(res, entityTablePart.DisplayName);
        this.AddWithCheck(res, entityTablePart.Description);
        this.GetFromMetadata((EntityMetadata) entityTablePart, res);
      }
      if (metadata.Forms == null)
        return;
      foreach (ViewItem form in metadata.GetForms())
      {
        string[] array = form.GetLocalizableStrings().ToArray<string>();
        this.AddWithCheck(res, array);
      }
    }

    protected virtual void GetFromPropertyType(
      PropertyMetadata propertyMetadata,
      List<PoLineDescriptor> res)
    {
      if (propertyMetadata == null || !(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeDescriptor(propertyMetadata.TypeUid, propertyMetadata.SubTypeUid) is ILocalizableType typeDescriptor))
        return;
      string[] array = typeDescriptor.GetLocalizableStrings(propertyMetadata).ToArray<string>();
      this.AddWithCheck(res, array);
    }

    protected virtual void AddWithCheck(List<PoLineDescriptor> res, params string[] keys)
    {
      foreach (string key in keys)
      {
        PoLineDescriptor line = new PoLineDescriptor()
        {
          Key = key
        };
        this.AddWithCheck(res, line);
      }
    }

    protected virtual void AddWithCheck(List<PoLineDescriptor> res, PoLineDescriptor line)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (string.IsNullOrWhiteSpace(line.Key) || !res.All<PoLineDescriptor>((Func<PoLineDescriptor, bool>) (r => !BaseLocalizationFileResolver.\u003C\u003Ec__DisplayClass9_0.wS4pbbvl68Ms4CK0L9Al(BaseLocalizationFileResolver.\u003C\u003Ec__DisplayClass9_0.rahKYNvl4sdNCQRhCWI5((object) r), BaseLocalizationFileResolver.\u003C\u003Ec__DisplayClass9_0.rahKYNvl4sdNCQRhCWI5((object) line), StringComparison.Ordinal))))
        return;
      res.Add(line);
    }

    protected BaseLocalizationFileResolver()
    {
      BaseLocalizationFileResolver.hM7DRyGolQ2fRp5ANA3Y();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jrQl5WGoyhQZe6HhCEKG() => (object) EleWise.ELMA.SR.KeyCultureInfo;

    internal static object ne0Y0GGoMnii35RUWuEV() => (object) Logger.Log;

    internal static object xp0uVmGoJOZt3GsK8Ma4([In] object obj0) => (object) ((Exception) obj0).Message;

    internal static void ECuDeBGo9Zi43hEDMTtm([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static bool UNjeE2Go0NelNd8LxV3V() => BaseLocalizationFileResolver.YnktLUGox97ofNHvIyhZ == null;

    internal static BaseLocalizationFileResolver KA6cyJGomHLvqvAxpqiY() => BaseLocalizationFileResolver.YnktLUGox97ofNHvIyhZ;

    internal static void sTdDnRGodpWd6iREdFMR([In] object obj0, [In] object obj1) => EleWise.ELMA.SR.RunWithCulture((CultureInfo) obj0, (System.Action) obj1);

    internal static void hM7DRyGolQ2fRp5ANA3Y() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

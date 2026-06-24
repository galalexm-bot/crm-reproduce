// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.AssemblyInfoMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Modules.Attributes;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Метаданные сборки</summary>
  [XmlRoot("AssemblyInfo")]
  [Serializable]
  public class AssemblyInfoMetadata : NamedMetadata, IRootMetadata, IMetadata, IXsiType
  {
    private EleWise.ELMA.SR.LocalizableString summary;
    internal static AssemblyInfoMetadata DqABqtbAdGIjMIIb0YYP;

    /// <summary>COM-visible</summary>
    public virtual bool IsComVisible
    {
      get => this.\u003CIsComVisible\u003Ek__BackingField;
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
              this.\u003CIsComVisible\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    /// <summary>Является ли компонентной сборкой</summary>
    public virtual bool IsComponentAssembly
    {
      get => this.\u003CIsComponentAssembly\u003Ek__BackingField;
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
              this.\u003CIsComponentAssembly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
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

    /// <summary>Является ли сборкой, содержащей модели</summary>
    public virtual bool IsModelAssembly
    {
      get => this.\u003CIsModelAssembly\u003Ek__BackingField;
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
              this.\u003CIsModelAssembly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 0 : 0;
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

    /// <summary>Номер версии файла сборки</summary>
    [DefaultValue("")]
    public virtual string FileVersion
    {
      get => this.\u003CFileVersion\u003Ek__BackingField;
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
              this.\u003CFileVersion\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 0 : 0;
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

    /// <summary>Компания-производитель</summary>
    [DefaultValue("")]
    public virtual string Company
    {
      get => this.\u003CCompany\u003Ek__BackingField;
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
              this.\u003CCompany\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    /// <summary>Краткое описание</summary>
    [DefaultValue("")]
    public virtual string Summary
    {
      get => (string) this.summary;
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
              this.summary = (EleWise.ELMA.SR.LocalizableString) AssemblyInfoMetadata.IcSESbbAg1dLFghDm61N((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
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

    /// <summary>Загрузить метаданные из скомпилированного типа</summary>
    /// <param name="type">Тип</param>
    /// <param name="inherit">True, если нужно выбирать свойства, включая родительские классы</param>
    public void LoadFromType(Type type, bool inherit = true)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            goto label_5;
          case 2:
            if (AssemblyInfoMetadata.X4ADsRbA5M45quU60mwS(type, (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
              continue;
            }
            this.LoadFromAssembly(type.Assembly);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_5:
      throw new ArgumentNullException((string) AssemblyInfoMetadata.i2i8v8bAjgudkpc7knWh(-420743386 ^ -420742396));
    }

    /// <summary>Загрузить метаданные из сборки</summary>
    /// <param name="asm">Сборка</param>
    public void LoadFromAssembly(Assembly asm)
    {
      int num1 = 5;
      while (true)
      {
        int num2 = num1;
        ComponentAssemblyAttribute attribute1;
        AssemblySummaryAttribute attribute2;
        AssemblyCompanyAttribute attribute3;
        AssemblyModuleAttribute attribute4;
        ComVisibleAttribute attribute5;
        ModelAssemblyAttribute attribute6;
        GuidAttribute attribute7;
        AssemblyTitleAttribute attribute8;
        AssemblyDescriptionAttribute attribute9;
        AssemblyFileVersionAttribute attribute10;
        AssemblyModuleAttribute attribute11;
        while (true)
        {
          switch (num2)
          {
            case 1:
              this.Company = attribute3 == null ? "" : (string) AssemblyInfoMetadata.UlsIoob7ffFDp9kGWskk((object) attribute3);
              num2 = 11;
              continue;
            case 2:
              AssemblyInfoMetadata.JiGevDbAcjhvGZTO98sX((object) this, AssemblyInfoMetadata.L3MUkfbAskRSmYbyV46M((object) asm));
              num2 = 18;
              continue;
            case 3:
              AssemblyInfoMetadata.o7B0Sob7ETalwFNBtMUK((object) this, attribute10 != null ? (object) attribute10.Version : (object) "");
              num2 = 14;
              continue;
            case 4:
              AssemblyInfoMetadata.wkWhIKbALwAjrDZx6wsJ((object) this, attribute7 == null ? Guid.Empty : new Guid((string) AssemblyInfoMetadata.GCIA7CbAYlWmXCyrqJIL((object) attribute7)));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 14 : 17;
              continue;
            case 5:
              attribute7 = AttributeHelper<GuidAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 4;
              continue;
            case 6:
              attribute10 = AttributeHelper<AssemblyFileVersionAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 1 : 3;
              continue;
            case 7:
              this.summary = attribute2 != null ? attribute2.LocalizedString : (EleWise.ELMA.SR.LocalizableString) AssemblyInfoMetadata.cCWnlFb7QTf1snS6VVZY();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0 ? 6 : 13;
              continue;
            case 8:
              AssemblyInfoMetadata.Cll4K7bAUN7m10fOZbWI((object) this, attribute4 != null ? AssemblyInfoMetadata.ReOsX7b7Gy78oQdC50hi((object) attribute4) : Guid.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 2 : 6;
              continue;
            case 9:
              AssemblyInfoMetadata.ouokxEb7bR14BoBJOvVb((object) this, attribute1 != null);
              num2 = 19;
              continue;
            case 10:
              attribute9 = AttributeHelper<AssemblyDescriptionAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 7 : 21;
              continue;
            case 11:
              attribute2 = AttributeHelper<AssemblySummaryAttribute>.GetAttribute(asm);
              num2 = 7;
              continue;
            case 12:
              AssemblyInfoMetadata.u0rasjb7BYtuT0Iqt2LM((object) this, attribute8 != null ? AssemblyInfoMetadata.CqkTY0b7FRiv0SjKIcgJ((object) attribute8) : (object) string.Empty);
              num2 = 10;
              continue;
            case 13:
              goto label_25;
            case 14:
              attribute3 = AttributeHelper<AssemblyCompanyAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 1;
              continue;
            case 15:
              attribute1 = AttributeHelper<ComponentAssemblyAttribute>.GetAttribute(asm);
              num2 = 9;
              continue;
            case 16:
              goto label_18;
            case 17:
              attribute11 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(asm);
              num2 = 16;
              continue;
            case 18:
              attribute5 = AttributeHelper<ComVisibleAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
              continue;
            case 19:
              attribute6 = AttributeHelper<ModelAssemblyAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 8 : 20;
              continue;
            case 20:
              AssemblyInfoMetadata.jeYagCb7he9PMpG5EJnR((object) this, attribute6 != null);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 22 : 21;
              continue;
            case 21:
              AssemblyInfoMetadata.vW6QhGb7oBT72GWnbFb1((object) this, attribute9 != null ? AssemblyInfoMetadata.EiJcBdb7WWRiWAjIGFYJ((object) attribute9) : (object) string.Empty);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 4 : 15;
              continue;
            case 22:
              attribute4 = AttributeHelper<AssemblyModuleAttribute>.GetAttribute(asm);
              num2 = 8;
              continue;
            case 23:
              attribute8 = AttributeHelper<AssemblyTitleAttribute>.GetAttribute(asm);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 2 : 12;
              continue;
            default:
              AssemblyInfoMetadata.X48r9UbAzTjKVvV8M52A((object) this, attribute5 != null && attribute5.Value);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 20 : 23;
              continue;
          }
        }
label_18:
        AssemblyInfoMetadata.Cll4K7bAUN7m10fOZbWI((object) this, attribute11 == null ? Guid.Empty : attribute11.Uid);
        num1 = 2;
      }
label_25:;
    }

    /// <summary>Требуют ли изменения в метаданных перезапуска сервера</summary>
    /// <param name="metadata">Измененные метаданные</param>
    /// <returns>True, если требуют</returns>
    public virtual bool IsRestartNeeded(IRootMetadata metadata) => true;

    /// <summary>Применить изменения, не требующие перезапуска сервера</summary>
    public virtual void ApplyRestartUnrequiredChanges(bool inherit)
    {
    }

    public AssemblyInfoMetadata()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.summary = (EleWise.ELMA.SR.LocalizableString) AssemblyInfoMetadata.cCWnlFb7QTf1snS6VVZY();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool qNRBxjbAlcxpsQbwYVHk() => AssemblyInfoMetadata.DqABqtbAdGIjMIIb0YYP == null;

    internal static AssemblyInfoMetadata KXHYCcbAr8VlJJ1lBQGt() => AssemblyInfoMetadata.DqABqtbAdGIjMIIb0YYP;

    internal static object IcSESbbAg1dLFghDm61N([In] object obj0) => (object) (EleWise.ELMA.SR.LocalizableString) (string) obj0;

    internal static bool X4ADsRbA5M45quU60mwS([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object i2i8v8bAjgudkpc7knWh(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object GCIA7CbAYlWmXCyrqJIL([In] object obj0) => (object) ((GuidAttribute) obj0).Value;

    internal static void wkWhIKbALwAjrDZx6wsJ([In] object obj0, Guid value) => ((AbstractMetadata) obj0).Uid = value;

    internal static void Cll4K7bAUN7m10fOZbWI([In] object obj0, Guid value) => ((AbstractMetadata) obj0).ModuleUid = value;

    internal static object L3MUkfbAskRSmYbyV46M([In] object obj0) => (object) ComponentManager.GetAssemblyShortName((Assembly) obj0);

    internal static void JiGevDbAcjhvGZTO98sX([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Name = (string) obj1;

    internal static void X48r9UbAzTjKVvV8M52A([In] object obj0, bool value) => ((AssemblyInfoMetadata) obj0).IsComVisible = value;

    internal static object CqkTY0b7FRiv0SjKIcgJ([In] object obj0) => (object) ((AssemblyTitleAttribute) obj0).Title;

    internal static void u0rasjb7BYtuT0Iqt2LM([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).DisplayName = (string) obj1;

    internal static object EiJcBdb7WWRiWAjIGFYJ([In] object obj0) => (object) ((AssemblyDescriptionAttribute) obj0).Description;

    internal static void vW6QhGb7oBT72GWnbFb1([In] object obj0, [In] object obj1) => ((NamedMetadata) obj0).Description = (string) obj1;

    internal static void ouokxEb7bR14BoBJOvVb([In] object obj0, bool value) => ((AssemblyInfoMetadata) obj0).IsComponentAssembly = value;

    internal static void jeYagCb7he9PMpG5EJnR([In] object obj0, bool value) => ((AssemblyInfoMetadata) obj0).IsModelAssembly = value;

    internal static Guid ReOsX7b7Gy78oQdC50hi([In] object obj0) => ((AssemblyModuleAttribute) obj0).Uid;

    internal static void o7B0Sob7ETalwFNBtMUK([In] object obj0, [In] object obj1) => ((AssemblyInfoMetadata) obj0).FileVersion = (string) obj1;

    internal static object UlsIoob7ffFDp9kGWskk([In] object obj0) => (object) ((AssemblyCompanyAttribute) obj0).Company;

    internal static object cCWnlFb7QTf1snS6VVZY() => (object) EleWise.ELMA.SR.LocalizableString.Empty;

    /// <summary>Информация о типе метаданных</summary>
    [Component]
    private class Info : IMetadataTypeInfo
    {
      internal static object z0yuKQCwaacCHB1UFnu5;

      public string Name => (string) AssemblyInfoMetadata.Info.jjWj9TCw4aJZyhreCnQB(AssemblyInfoMetadata.Info.sxEyN7Cwwmda3k2Kg2QA(-420743386 ^ -420586762));

      public string Description => string.Empty;

      public Type MetadataType => AssemblyInfoMetadata.Info.mU6GbjCw6MMZBpa7T4Wp(__typeref (AssemblyInfoMetadata));

      public Type GeneratorType => typeof (AssemblyInfoGenerator);

      public Info()
      {
        AssemblyInfoMetadata.Info.o2Eh9PCwH5js2Y6qw8DN();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static object sxEyN7Cwwmda3k2Kg2QA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static object jjWj9TCw4aJZyhreCnQB([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

      internal static bool YiVnWdCwDjcxOFtyacrX() => AssemblyInfoMetadata.Info.z0yuKQCwaacCHB1UFnu5 == null;

      internal static AssemblyInfoMetadata.Info LmM049CwtOXcsG9tK5oB() => (AssemblyInfoMetadata.Info) AssemblyInfoMetadata.Info.z0yuKQCwaacCHB1UFnu5;

      internal static Type mU6GbjCw6MMZBpa7T4Wp([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

      internal static void o2Eh9PCwH5js2Y6qw8DN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

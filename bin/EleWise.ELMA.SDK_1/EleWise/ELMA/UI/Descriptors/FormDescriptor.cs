// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.FormDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.UI.Descriptors
{
  /// <summary>Дескриптор формы</summary>
  public class FormDescriptor : IFormDescriptor
  {
    private static FormDescriptor UGCcs4MIXRO06LJWKoe;

    public FormDescriptor(IFormMetadataItem item)
    {
      FormDescriptor.JTWDFrMiolLi4OXejWC();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num1 = 15;
      string str;
      while (true)
      {
        int num2;
        switch (num1)
        {
          case 1:
            this.Assembly = ComponentManager.FindLoadedAssembly(item.AssemblyName, false);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0 ? 9 : 7;
            continue;
          case 2:
            goto label_6;
          case 3:
            FormDescriptor.T2f4brMKH7LavuIXau3(item.Metadata != null, FormDescriptor.o4mPEHMRiX03bc63Lsr(236071375 ^ 236093765));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 7;
            continue;
          case 4:
            str = (string) FormDescriptor.ehq8H4M15gbP1ccixy5((object) this.Metadata) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822929568);
            num2 = 12;
            break;
          case 5:
            goto label_4;
          case 6:
            if (!FormDescriptor.zvZa0hM3ddvIfp8OPjc(this.ControllerType, (Type) null))
            {
              num1 = 5;
              continue;
            }
            goto label_6;
          case 7:
            Contract.NotNullOrEmpty((string) FormDescriptor.I3XFduMXLHjVkVrjj23((object) item), (string) FormDescriptor.o4mPEHMRiX03bc63Lsr(-675505729 ^ -675532127));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0 ? 0 : 0;
            continue;
          case 8:
            this.MetadataItemHederId = ((IEntity<long>) FormDescriptor.e2iOoHMT7f6Z6tI2hF8((object) item)).Id;
            num1 = 11;
            continue;
          case 9:
            if (!FormDescriptor.EAX9YeMO2JyODtV1C1E((object) this.Assembly, (object) null))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 19 : 4;
              continue;
            }
            goto case 17;
          case 10:
          case 19:
            if (FormDescriptor.TF5naaMPTOAkesMKD3x((object) item) != null)
            {
              num1 = 4;
              continue;
            }
            goto label_22;
          case 11:
            this.MetadataItemHederUid = FormDescriptor.oYAIO3MkdqbVJVjM8k7(FormDescriptor.e2iOoHMT7f6Z6tI2hF8((object) item));
            num1 = 14;
            continue;
          case 12:
            this.ControllerType = FormDescriptor.Sik3tqMN0dEK6B3Wg4E((object) this.Assembly, (object) str);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 6 : 5;
            continue;
          case 13:
            this.Uid = FormDescriptor.t3G1NuMn8Y5bVy18fqv((object) this.Metadata);
            num2 = 20;
            break;
          case 14:
            this.AuthorId = item.CreationAuthorId;
            num1 = 13;
            continue;
          case 15:
            FormDescriptor.gKeNogMqFDnp6wy1MHP((object) item, FormDescriptor.o4mPEHMRiX03bc63Lsr(1597012150 ^ 1597034696));
            num1 = 3;
            continue;
          case 16:
            this.MetadataItemId = item.Id;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 8 : 7;
            continue;
          case 17:
            this.Assembly = ComponentManager.LoadAssembly((byte[]) FormDescriptor.nDF1VBM2CMybxWJyik6((object) item), (byte[]) FormDescriptor.DP8UP0Me60Vd6cjRr9Y((object) item));
            num1 = 10;
            continue;
          case 18:
            this.Metadata = (FormMetadata) item.Metadata;
            num1 = 16;
            continue;
          case 20:
            this.HeaderUid = FormDescriptor.oYAIO3MkdqbVJVjM8k7(FormDescriptor.e2iOoHMT7f6Z6tI2hF8((object) item));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 1 : 1;
            continue;
          default:
            FormDescriptor.T2f4brMKH7LavuIXau3(item.AssemblyRaw != null, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1204263869 ^ -1341583247 ^ 137486198));
            num2 = 18;
            break;
        }
        num1 = num2;
      }
label_4:
      return;
label_6:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) FormDescriptor.o4mPEHMRiX03bc63Lsr(-1445902765 ^ -1980277732 ^ 539406815), (object) str, FormDescriptor.jr0sPEMpo9Nwt4vGqpB((object) this.Metadata)));
label_22:;
    }

    /// <summary>Уникальный идентификатор</summary>
    public Guid Uid
    {
      get => this.\u003CUid\u003Ek__BackingField;
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
              this.\u003CUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 0 : 0;
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

    /// <summary>
    /// Уникальный идентификатор заголовка (не меняется от версии к версии)
    /// </summary>
    public Guid HeaderUid
    {
      get => this.\u003CHeaderUid\u003Ek__BackingField;
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
              this.\u003CHeaderUid\u003Ek__BackingField = value;
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

    /// <summary>Идентификатор элемента метаданных формы</summary>
    public long MetadataItemId
    {
      get => this.\u003CMetadataItemId\u003Ek__BackingField;
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
              this.\u003CMetadataItemId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
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

    /// <summary>Идентификатор заголовка элемента метаданных формы</summary>
    public long MetadataItemHederId
    {
      get => this.\u003CMetadataItemHederId\u003Ek__BackingField;
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
              this.\u003CMetadataItemHederId\u003Ek__BackingField = value;
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

    /// <summary>
    /// Уникальный идентификатор заголовка элемента метаданных формы
    /// </summary>
    public Guid MetadataItemHederUid
    {
      get => this.\u003CMetadataItemHederUid\u003Ek__BackingField;
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
              this.\u003CMetadataItemHederUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
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

    /// <summary>Id автора</summary>
    public long? AuthorId { get; set; }

    /// <summary>Метаданные</summary>
    public FormMetadata Metadata
    {
      get => this.\u003CMetadata\u003Ek__BackingField;
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
              this.\u003CMetadata\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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

    /// <summary>Сборка</summary>
    public Assembly Assembly
    {
      get => this.\u003CAssembly\u003Ek__BackingField;
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
              this.\u003CAssembly\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
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

    /// <summary>Тип контроллера</summary>
    public Type ControllerType
    {
      get => this.\u003CControllerType\u003Ek__BackingField;
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
              this.\u003CControllerType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
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

    internal static void JTWDFrMiolLi4OXejWC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object o4mPEHMRiX03bc63Lsr(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void gKeNogMqFDnp6wy1MHP([In] object obj0, [In] object obj1) => Contract.ArgumentNotNull(obj0, (string) obj1);

    internal static void T2f4brMKH7LavuIXau3(bool condition, [In] object obj1) => Contract.CheckArgument(condition, (string) obj1);

    internal static object I3XFduMXLHjVkVrjj23([In] object obj0) => (object) ((IFormMetadataItem) obj0).AssemblyName;

    internal static object e2iOoHMT7f6Z6tI2hF8([In] object obj0) => (object) ((IFormMetadataItem) obj0).Header;

    internal static Guid oYAIO3MkdqbVJVjM8k7([In] object obj0) => ((IFormMetadataItemHeader) obj0).Uid;

    internal static Guid t3G1NuMn8Y5bVy18fqv([In] object obj0) => ((AbstractMetadata) obj0).Uid;

    internal static bool EAX9YeMO2JyODtV1C1E([In] object obj0, [In] object obj1) => (Assembly) obj0 == (Assembly) obj1;

    internal static object nDF1VBM2CMybxWJyik6([In] object obj0) => (object) ((IFormMetadataItem) obj0).AssemblyRaw;

    internal static object DP8UP0Me60Vd6cjRr9Y([In] object obj0) => (object) ((IFormMetadataItem) obj0).DebugRaw;

    internal static object TF5naaMPTOAkesMKD3x([In] object obj0) => (object) ((IFormMetadataItem) obj0).ScriptModule;

    internal static object ehq8H4M15gbP1ccixy5([In] object obj0) => (object) ((FormMetadata) obj0).FullTypeName;

    internal static Type Sik3tqMN0dEK6B3Wg4E([In] object obj0, [In] object obj1) => ((Assembly) obj0).GetType((string) obj1);

    internal static bool zvZa0hM3ddvIfp8OPjc([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object jr0sPEMpo9Nwt4vGqpB([In] object obj0) => (object) ((NamedMetadata) obj0).DisplayName;

    internal static bool gth2HCMVtrfqePmoj6H() => FormDescriptor.UGCcs4MIXRO06LJWKoe == null;

    internal static FormDescriptor otrf9vMS0RQi8mRjBGE() => FormDescriptor.UGCcs4MIXRO06LJWKoe;
  }
}

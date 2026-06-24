// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.Components.FormUIQualifiedTypeResolver
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Metadata.ExtensionPoints;
using EleWise.ELMA.UI;
using EleWise.ELMA.UI.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

namespace EleWise.ELMA.Model.Metadata.Components
{
  /// <summary>
  /// Реализация <see cref="T:EleWise.ELMA.Model.Metadata.ExtensionPoints.IQualifiedTypeResolverExtension" /> для форм
  /// </summary>
  [Component(Order = 900)]
  internal class FormUIQualifiedTypeResolver : IQualifiedTypeResolverExtension
  {
    private readonly Guid uid;
    private readonly FormDescriptorProvider formDescriptorProvider;
    internal static FormUIQualifiedTypeResolver Mq9D1OhBlupWvDnV0KSR;

    /// <summary>ctor</summary>
    /// <param name="formDescriptorProvider">Провайдер дескрипторов форм</param>
    public FormUIQualifiedTypeResolver(FormDescriptorProvider formDescriptorProvider)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.uid = new Guid((string) FormUIQualifiedTypeResolver.CsZC3xhB5kC83GJVPtkL(-87337865 ^ -87526295));
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.formDescriptorProvider = formDescriptorProvider;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <inheritdoc />
    public Guid Uid => this.uid;

    /// <inheritdoc />
    public bool CheckType(Type type)
    {
      int num = 1;
      MetadataTypeAttribute customAttribute;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!FormUIQualifiedTypeResolver.qqXPfWhBYo3w1Fy0IaO6(FormUIQualifiedTypeResolver.wOh8XThBjRJTbJGqe6dj((object) type), (Type) null))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
              continue;
            }
            goto label_6;
          case 2:
            if (customAttribute == null)
            {
              num = 3;
              continue;
            }
            goto label_2;
          case 3:
            goto label_3;
          case 4:
            goto label_2;
          case 5:
            goto label_6;
          default:
            customAttribute = FormUIQualifiedTypeResolver.wOh8XThBjRJTbJGqe6dj((object) type).GetCustomAttribute<MetadataTypeAttribute>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0 ? 0 : 2;
            continue;
        }
      }
label_2:
      return TypeOf<FormMetadata>.Raw.IsAssignableFrom(FormUIQualifiedTypeResolver.NKkOo5hBLAExDGn563HM((object) customAttribute));
label_3:
      return false;
label_6:
      return false;
    }

    /// <inheritdoc />
    public IEnumerable<byte> GetQualifiedTypeData(Type type)
    {
      FormMetadata formMetadata = (FormMetadata) MetadataLoader.LoadMetadata(type.DeclaringType);
      Guid typeUid = formMetadata.GetTypeUid();
      Guid uid = formMetadata.Uid;
      string fullName = type.FullName;
      return ((IEnumerable<byte>) typeUid.ToByteArray()).Concat<byte>((IEnumerable<byte>) uid.ToByteArray()).Concat<byte>((IEnumerable<byte>) Encoding.UTF8.GetBytes(fullName));
    }

    /// <inheritdoc />
    public Type GetType(IEnumerable<byte> data)
    {
      Guid metadataType = new Guid(data.Take<byte>(16).ToArray<byte>());
      Guid descriptorUid = new Guid(data.Skip<byte>(16).Take<byte>(16).ToArray<byte>());
      string name = Encoding.UTF8.GetString(data.Skip<byte>(32).ToArray<byte>());
      return this.formDescriptorProvider.GetDescriptor(metadataType, descriptorUid).Assembly.GetType(name);
    }

    internal static object CsZC3xhB5kC83GJVPtkL(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool B94hnThBr1cnwAiqRd2K() => FormUIQualifiedTypeResolver.Mq9D1OhBlupWvDnV0KSR == null;

    internal static FormUIQualifiedTypeResolver dBY8O8hBgrFrV6tAhddv() => FormUIQualifiedTypeResolver.Mq9D1OhBlupWvDnV0KSR;

    internal static Type wOh8XThBjRJTbJGqe6dj([In] object obj0) => ((MemberInfo) obj0).DeclaringType;

    internal static bool qqXPfWhBYo3w1Fy0IaO6([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static Type NKkOo5hBLAExDGn563HM([In] object obj0) => ((MetadataTypeAttribute) obj0).MetadataType;
  }
}

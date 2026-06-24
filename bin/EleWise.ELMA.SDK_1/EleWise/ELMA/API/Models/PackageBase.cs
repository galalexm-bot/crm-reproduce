// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.PackageBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract]
  [KnownType("GetPackageKnownTypes")]
  [Serializable]
  public abstract class PackageBase
  {
    private static readonly object packageKnownTypesLocker;
    private static Type[] packageKnownTypes;
    internal static PackageBase DvpCc0fNK3CZAwYxNKPT;

    /// <summary>
    /// Этот конструктор предназначен только для десериализации.
    /// </summary>
    [Obsolete("Этот конструктор предназначен только для десериализации.", true)]
    public PackageBase()
    {
      PackageBase.jPoHr8fNkXmQJmlpOVhi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public PackageBase(Guid serviceUid, Guid typeUid)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.TypeUid = typeUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 1 : 0;
            continue;
          default:
            this.ServiceUid = serviceUid;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    [DataMember]
    public Guid ServiceUid
    {
      get => this.\u003CServiceUid\u003Ek__BackingField;
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
              this.\u003CServiceUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0 ? 0 : 0;
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

    [DataMember]
    public Guid TypeUid
    {
      get => this.\u003CTypeUid\u003Ek__BackingField;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    private static IEnumerable<Type> GetPackageKnownTypes()
    {
      if (PackageBase.packageKnownTypes != null)
        return (IEnumerable<Type>) PackageBase.packageKnownTypes;
      lock (PackageBase.packageKnownTypesLocker)
      {
        if (PackageBase.packageKnownTypes != null)
          return (IEnumerable<Type>) PackageBase.packageKnownTypes;
        PackageBase.packageKnownTypes = ((IEnumerable<Type>) new Type[2]
        {
          typeof (DeletedIdsPackage),
          typeof (UpdateIdPackage)
        }).Union<Type>(ComponentManager.Current.GetExtensionPoints<IUpdatePackageService>().SelectMany<IUpdatePackageService, Type>((Func<IUpdatePackageService, IEnumerable<Type>>) (s => s.KnownTypes((ICustomAttributeProvider) null)))).ToArray<Type>();
        return (IEnumerable<Type>) PackageBase.packageKnownTypes;
      }
    }

    static PackageBase()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PackageBase.jPoHr8fNkXmQJmlpOVhi();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PackageBase.packageKnownTypesLocker = new object();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void jPoHr8fNkXmQJmlpOVhi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Npu6FRfNXa2DPk1HhxlS() => PackageBase.DvpCc0fNK3CZAwYxNKPT == null;

    internal static PackageBase QC4ympfNTwt8EWQCs9gk() => PackageBase.DvpCc0fNK3CZAwYxNKPT;
  }
}

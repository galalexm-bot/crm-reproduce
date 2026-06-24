// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.DeletedIdsPackage
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract(Name = "DeletedIdsPackage")]
  [Serializable]
  public class DeletedIdsPackage : PackageBase
  {
    private static DeletedIdsPackage vNPdWIf1k1UWEBOUxakT;

    /// <summary>
    /// Этот конструктор предназначен только для десериализации.
    /// </summary>
    [Obsolete("Этот конструктор предназначен только для десериализации.", true)]
    public DeletedIdsPackage()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DeletedIdsPackage(Guid serviceUid, Guid typeUid)
    {
      DeletedIdsPackage.TNW8lxf12RQpdyRixl96();
      // ISSUE: explicit constructor call
      base.\u002Ector(serviceUid, typeUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public DeletedIdsPackage(Guid serviceUid, Guid typeUid, long deleted)
    {
      DeletedIdsPackage.TNW8lxf12RQpdyRixl96();
      // ISSUE: explicit constructor call
      this.\u002Ector(serviceUid, typeUid);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Deleted = new long[1]{ deleted };
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public DeletedIdsPackage(Guid serviceUid, Guid typeUid, IEnumerable<long> deleted)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(serviceUid, typeUid);
      this.Deleted = deleted.ToArray<long>();
    }

    [DataMember]
    public long[] Deleted
    {
      get => this.\u003CDeleted\u003Ek__BackingField;
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
              this.\u003CDeleted\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
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

    internal static bool VxJpGQf1nqcXTqYeBLRp() => DeletedIdsPackage.vNPdWIf1k1UWEBOUxakT == null;

    internal static DeletedIdsPackage duQ6LMf1OH7JvitX9L79() => DeletedIdsPackage.vNPdWIf1k1UWEBOUxakT;

    internal static void TNW8lxf12RQpdyRixl96() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

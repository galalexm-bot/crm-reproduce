// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.Models.CheckPermissionRequest
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.API.Models
{
  [DataContract]
  [Serializable]
  public class CheckPermissionRequest
  {
    internal static CheckPermissionRequest fPC77Qf1VLwb3QTRpUjW;

    [DataMember]
    public Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
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
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 0;
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
    public long ObjectId
    {
      get => this.\u003CObjectId\u003Ek__BackingField;
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
              this.\u003CObjectId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 0 : 0;
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
              this.\u003CTypeUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
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

    public CheckPermissionRequest()
    {
      CheckPermissionRequest.Mfo8Klf1RJvVPsmsG2Pe();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Go8ISpf1S6iwJYk9Xl7j() => CheckPermissionRequest.fPC77Qf1VLwb3QTRpUjW == null;

    internal static CheckPermissionRequest QwfPMJf1iR1wPj2OsYL6() => CheckPermissionRequest.fPC77Qf1VLwb3QTRpUjW;

    internal static void Mfo8Klf1RJvVPsmsG2Pe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

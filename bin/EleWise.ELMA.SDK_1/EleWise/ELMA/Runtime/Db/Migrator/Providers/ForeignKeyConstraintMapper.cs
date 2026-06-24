// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Db.Migrator.Providers.ForeignKeyConstraintMapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Migrator.Providers
{
  public class ForeignKeyConstraintMapper
  {
    private static ForeignKeyConstraintMapper GhXM50WOCFOqY0wxcCwC;

    public string SqlForConstraint(ForeignKeyConstraint constraint)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            switch (constraint)
            {
              case ForeignKeyConstraint.Cascade:
                goto label_4;
              case ForeignKeyConstraint.SetNull:
                goto label_7;
              case ForeignKeyConstraint.NoAction:
                goto label_8;
              case ForeignKeyConstraint.Restrict:
                goto label_5;
              case ForeignKeyConstraint.SetDefault:
                goto label_6;
              default:
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
                continue;
            }
          case 2:
            goto label_4;
          default:
            goto label_8;
        }
      }
label_4:
      return (string) ForeignKeyConstraintMapper.kQlkWeWOZEdt02D5e9R3(1033719030 - 2012070891 ^ -978481195);
label_5:
      return (string) ForeignKeyConstraintMapper.kQlkWeWOZEdt02D5e9R3(-244066886 - -48452443 ^ -195743771);
label_6:
      return (string) ForeignKeyConstraintMapper.kQlkWeWOZEdt02D5e9R3(-1921202237 ^ -1921072953);
label_7:
      return (string) ForeignKeyConstraintMapper.kQlkWeWOZEdt02D5e9R3(-1858887263 ^ -1859017025);
label_8:
      return (string) ForeignKeyConstraintMapper.kQlkWeWOZEdt02D5e9R3(-1088304168 ^ -1088172822);
    }

    public ForeignKeyConstraintMapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object kQlkWeWOZEdt02D5e9R3(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool iyNjjZWOvJLLIpQHYLcv() => ForeignKeyConstraintMapper.GhXM50WOCFOqY0wxcCwC == null;

    internal static ForeignKeyConstraintMapper OTh08xWO8ogXKyyePM34() => ForeignKeyConstraintMapper.GhXM50WOCFOqY0wxcCwC;
  }
}

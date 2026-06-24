// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Mappings.NamedMetadataMap`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Mapping.ByCode;
using System;
using System.Linq.Expressions;

namespace EleWise.ELMA.Model.Mappings
{
  public class NamedMetadataMap<T> : AbstractMetadataMap<T> where T : NamedMetadata
  {
    internal static object OfsZhkhhbkLqtZvY93UE;

    public NamedMetadataMap(string tableName)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(tableName);
      int num1 = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num1 = 2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            Expression<Func<T, string>> property1 = (Expression<Func<T, string>>) (obj => obj.Description);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action1 = NamedMetadataMap<T>.\u003C\u003Ec.\u003C\u003E9__0_5;
            Action<IPropertyMapper> mapping1;
            if (action1 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NamedMetadataMap<T>.\u003C\u003Ec.\u003C\u003E9__0_5 = mapping1 = (Action<IPropertyMapper>) (p =>
              {
                int num2 = 1;
                while (true)
                {
                  switch (num2)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Length(int.MaxValue);
                      num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_11;
label_10:
            this.Property<string>(property1, mapping1);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 3 : 0;
            continue;
label_11:
            mapping1 = action1;
            goto label_10;
          case 2:
            Expression<Func<T, string>> property2 = (Expression<Func<T, string>>) (obj => obj.Name);
            // ISSUE: reference to a compiler-generated field
            Action<IPropertyMapper> action2 = NamedMetadataMap<T>.\u003C\u003Ec.\u003C\u003E9__0_1;
            Action<IPropertyMapper> mapping2;
            if (action2 == null)
            {
              // ISSUE: reference to a compiler-generated field
              NamedMetadataMap<T>.\u003C\u003Ec.\u003C\u003E9__0_1 = mapping2 = (Action<IPropertyMapper>) (p =>
              {
                int num3 = 1;
                while (true)
                {
                  switch (num3)
                  {
                    case 0:
                      goto label_2;
                    case 1:
                      p.Length(int.MaxValue);
                      num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                      continue;
                    default:
                      goto label_4;
                  }
                }
label_2:
                return;
label_4:;
              });
            }
            else
              goto label_12;
label_5:
            this.Property<string>(property2, mapping2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
            continue;
label_12:
            mapping2 = action2;
            goto label_5;
          case 3:
            goto label_8;
          default:
            this.Property<string>((Expression<Func<T, string>>) (obj => obj.DisplayName), (Action<IPropertyMapper>) (p =>
            {
              int num4 = 1;
              while (true)
              {
                switch (num4)
                {
                  case 0:
                    goto label_2;
                  case 1:
                    p.Length(int.MaxValue);
                    num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_2:
              return;
label_4:;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 1 : 1;
            continue;
        }
      }
label_8:;
    }

    internal static bool ubr2QWhhhuFxahFpHfPf() => NamedMetadataMap<T>.OfsZhkhhbkLqtZvY93UE == null;

    internal static object L7VlHchhGnufBafay5Jq() => NamedMetadataMap<T>.OfsZhkhhbkLqtZvY93UE;
  }
}

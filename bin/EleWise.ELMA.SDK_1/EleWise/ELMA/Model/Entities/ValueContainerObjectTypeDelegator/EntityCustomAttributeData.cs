// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator.EntityCustomAttributeData
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Entities.ValueContainerObjectTypeDelegator
{
  internal class EntityCustomAttributeData : 
    CustomAttributeData,
    IEquatable<EntityCustomAttributeData>
  {
    private static IEqualityComparer<CustomAttributeTypedArgument> typedArgumentComparer;
    private static IEqualityComparer<CustomAttributeNamedArgument> namedArgumentComparer;
    internal static EntityCustomAttributeData TelA8HhSPfnXGs9Wpvie;

    public EntityCustomAttributeData(ConstructorInfo constructor)
    {
      EntityCustomAttributeData.xj2cn6hS3ZJ35pQ4LOJ2();
      // ISSUE: explicit constructor call
      this.\u002Ector(constructor, (IList<CustomAttributeTypedArgument>) new CustomAttributeTypedArgument[0]);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public EntityCustomAttributeData(
      ConstructorInfo constructor,
      IList<CustomAttributeTypedArgument> constructorArguments)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      this.\u002Ector(constructor, constructorArguments, (IList<CustomAttributeNamedArgument>) new CustomAttributeNamedArgument[0]);
    }

    public EntityCustomAttributeData(
      ConstructorInfo constructor,
      IList<CustomAttributeTypedArgument> constructorArguments,
      IList<CustomAttributeNamedArgument> namedArguments)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Constructor = constructor;
      this.ConstructorArguments = constructorArguments;
      this.NamedArguments = namedArguments;
    }

    public override ConstructorInfo Constructor { get; }

    public override IList<CustomAttributeTypedArgument> ConstructorArguments { get; }

    public override IList<CustomAttributeNamedArgument> NamedArguments { get; }

    public bool Equals(EntityCustomAttributeData data)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.ConstructorArguments.EmptyIfNull<CustomAttributeTypedArgument>().SequenceEqual<CustomAttributeTypedArgument>(data.ConstructorArguments.EmptyIfNull<CustomAttributeTypedArgument>(), EntityCustomAttributeData.typedArgumentComparer))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
              continue;
            }
            goto label_5;
          case 2:
            if ((ConstructorInfo) EntityCustomAttributeData.qQUkpphSpBiIlSiwxD25((object) this) == data.Constructor)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 1 : 1;
              continue;
            }
            goto label_5;
          default:
            goto label_4;
        }
      }
label_4:
      return this.NamedArguments.EmptyIfNull<CustomAttributeNamedArgument>().SetEqual<CustomAttributeNamedArgument>(data.NamedArguments.EmptyIfNull<CustomAttributeNamedArgument>(), EntityCustomAttributeData.namedArgumentComparer);
label_5:
      return false;
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (obj is EntityCustomAttributeData data)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Equals(data);
label_3:
      return false;
    }

    public override int GetHashCode()
    {
      int num1 = (414553146 * -1521134295 + EntityCustomAttributeData.qQUkpphSpBiIlSiwxD25((object) this).GetHashCode()) * -1521134295;
      IList<CustomAttributeTypedArgument> constructorArguments = this.ConstructorArguments;
      int hashCode1 = (constructorArguments != null ? constructorArguments.Count : 0).GetHashCode();
      int num2 = (num1 + hashCode1) * -1521134295;
      IList<CustomAttributeNamedArgument> namedArguments = this.NamedArguments;
      int hashCode2 = (namedArguments == null ? 0 : EntityCustomAttributeData.AHxP9AhSaGKywwNyHvRV((object) namedArguments)).GetHashCode();
      return num2 + hashCode2;
    }

    static EntityCustomAttributeData()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
            continue;
          case 2:
            EntityCustomAttributeData.namedArgumentComparer = (IEqualityComparer<CustomAttributeNamedArgument>) new EntityCustomAttributeData.CustomAttributeNamedArgumentComparer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            EntityCustomAttributeData.typedArgumentComparer = (IEqualityComparer<CustomAttributeTypedArgument>) new EntityCustomAttributeData.CustomAttributeTypedArgumentComparer();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void xj2cn6hS3ZJ35pQ4LOJ2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool poPKb3hS17vv87v0wvoT() => EntityCustomAttributeData.TelA8HhSPfnXGs9Wpvie == null;

    internal static EntityCustomAttributeData oY6ReQhSNooZflkKsLq5() => EntityCustomAttributeData.TelA8HhSPfnXGs9Wpvie;

    internal static object qQUkpphSpBiIlSiwxD25([In] object obj0) => (object) ((CustomAttributeData) obj0).Constructor;

    internal static int AHxP9AhSaGKywwNyHvRV([In] object obj0) => ((ICollection<CustomAttributeNamedArgument>) obj0).Count;

    private class CustomAttributeTypedArgumentComparer : 
      IEqualityComparer<CustomAttributeTypedArgument>
    {
      private static object GmDFh5vWhUS5n8MqRhwR;

      public bool Equals(CustomAttributeTypedArgument x, CustomAttributeTypedArgument y)
      {
        int num1 = 4;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 1:
                goto label_8;
              case 2:
                if (x.Value != null)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 5;
                  continue;
                }
                goto label_4;
              case 3:
                goto label_7;
              case 4:
                if (EntityCustomAttributeData.CustomAttributeTypedArgumentComparer.OhKB7CvWf7Pn2Td6JmiH(x, y))
                {
                  num2 = 3;
                  continue;
                }
                break;
              case 5:
                goto label_3;
            }
            if (EntityCustomAttributeData.CustomAttributeTypedArgumentComparer.TjZNtfvWQ02q1ZoH0KxU(x.ArgumentType, y.ArgumentType))
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 1 : 1;
            else
              goto label_6;
          }
label_8:
          if (x.Value != y.Value)
            num1 = 2;
          else
            goto label_5;
        }
label_3:
        return x.Value.Equals(y.Value);
label_4:
        return false;
label_5:
        return true;
label_6:
        return false;
label_7:
        return true;
      }

      public int GetHashCode(CustomAttributeTypedArgument obj)
      {
        int num1 = 7;
        int? nullable1;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            int num3;
            int? nullable2;
            int? nullable3;
            int? nullable4;
            int? nullable5;
            switch (num2)
            {
              case 1:
                goto label_6;
              case 2:
                nullable4 = nullable3;
                goto label_19;
              case 3:
                if (!nullable2.HasValue)
                {
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
                  continue;
                }
                nullable4 = new int?(num3 + nullable2.GetValueOrDefault());
                goto label_19;
              case 4:
                goto label_11;
              case 5:
                nullable5 = nullable3;
                break;
              case 6:
                object obj1 = obj.Value;
                if (obj1 == null)
                {
                  num2 = 8;
                  continue;
                }
                nullable5 = new int?(obj1.GetHashCode());
                break;
              case 7:
                num3 = (811832965 * -1521134295 + obj.ArgumentType.GetHashCode()) * -1521134295;
                num2 = 6;
                continue;
              case 8:
                nullable3 = new int?();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 5 : 2;
                continue;
              default:
                nullable3 = new int?();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 != 0 ? 2 : 2;
                continue;
            }
            nullable2 = nullable5;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 2 : 3;
            continue;
label_19:
            nullable1 = nullable4;
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 1 : 0;
          }
label_6:
          if (!nullable1.HasValue)
            num1 = 4;
          else
            goto label_12;
        }
label_11:
        return 0;
label_12:
        return nullable1.GetValueOrDefault();
      }

      public CustomAttributeTypedArgumentComparer()
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool OhKB7CvWf7Pn2Td6JmiH(
        [In] CustomAttributeTypedArgument obj0,
        [In] CustomAttributeTypedArgument obj1)
      {
        return obj0 == obj1;
      }

      internal static bool TjZNtfvWQ02q1ZoH0KxU([In] Type obj0, [In] Type obj1) => obj0 == obj1;

      internal static bool PRAlRQvWG4MM1Amb3woF() => EntityCustomAttributeData.CustomAttributeTypedArgumentComparer.GmDFh5vWhUS5n8MqRhwR == null;

      internal static EntityCustomAttributeData.CustomAttributeTypedArgumentComparer hwOo04vWEcmUb2t7yFGl() => (EntityCustomAttributeData.CustomAttributeTypedArgumentComparer) EntityCustomAttributeData.CustomAttributeTypedArgumentComparer.GmDFh5vWhUS5n8MqRhwR;
    }

    private class CustomAttributeNamedArgumentComparer : 
      IEqualityComparer<CustomAttributeNamedArgument>
    {
      internal static object fQm2CavWCmkBSVFyVfjD;

      public bool Equals(CustomAttributeNamedArgument x, CustomAttributeNamedArgument y)
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (x.MemberName == y.MemberName)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 2:
              if (!EntityCustomAttributeData.CustomAttributeNamedArgumentComparer.u8cmPCvWZ4xmdoJnq8Gr(x, y))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 1;
                continue;
              }
              goto label_8;
            default:
              goto label_6;
          }
        }
label_6:
        return EntityCustomAttributeData.typedArgumentComparer.Equals(x.TypedValue, y.TypedValue);
label_7:
        return false;
label_8:
        return true;
      }

      public int GetHashCode(CustomAttributeNamedArgument obj) => (811832965 * -1521134295 + obj.MemberName.GetHashCode()) * -1521134295 + EntityCustomAttributeData.typedArgumentComparer.GetHashCode(obj.TypedValue);

      public CustomAttributeNamedArgumentComparer()
      {
        EntityCustomAttributeData.CustomAttributeNamedArgumentComparer.suEVBwvWuqTnHSlNyWEk();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static bool u8cmPCvWZ4xmdoJnq8Gr(
        [In] CustomAttributeNamedArgument obj0,
        [In] CustomAttributeNamedArgument obj1)
      {
        return obj0 == obj1;
      }

      internal static bool DSte6PvWvhues5XERx93() => EntityCustomAttributeData.CustomAttributeNamedArgumentComparer.fQm2CavWCmkBSVFyVfjD == null;

      internal static EntityCustomAttributeData.CustomAttributeNamedArgumentComparer GQn66svW8UKXK6nFcl7H() => (EntityCustomAttributeData.CustomAttributeNamedArgumentComparer) EntityCustomAttributeData.CustomAttributeNamedArgumentComparer.fQm2CavWCmkBSVFyVfjD;

      internal static void suEVBwvWuqTnHSlNyWEk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}

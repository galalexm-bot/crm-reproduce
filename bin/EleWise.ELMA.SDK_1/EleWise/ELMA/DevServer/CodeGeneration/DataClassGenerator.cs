// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.DevServer.CodeGeneration.DataClassGenerator
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.DevServer.CodeGeneration
{
  /// <summary>Генератор кода для DataClass на DevServer</summary>
  internal sealed class DataClassGenerator : EleWise.ELMA.Model.CodeGeneration.DataClassGenerator
  {
    private static DataClassGenerator kXENJuEOZUsD5AGDLuJj;

    private static DataClassDescriptor DataClassDescriptor => Locator.GetServiceNotNull<DataClassDescriptor>();

    /// <inheritdoc />
    protected override void WritePropertyAttributes(
      ISyntaxNode property,
      PropertyMetadata propertyMetadata,
      string resourcePrefix = null)
    {
    }

    /// <inheritdoc />
    protected override void WriteTypeAttributes(ISyntaxNode type)
    {
      int num1 = 1;
      List<DataClassDependency>.Enumerator enumerator;
      List<ISyntaxTrivia> comments;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_20;
          case 1:
            if (this.metadata is DataClassMetadata metadata)
            {
              comments = new List<ISyntaxTrivia>();
              num1 = 3;
              continue;
            }
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          case 2:
            try
            {
label_12:
              if (enumerator.MoveNext())
                goto label_4;
              else
                goto label_13;
label_3:
              DataClassDependency current;
              int num2;
              switch (num2)
              {
                case 1:
                  break;
                case 2:
                  goto label_12;
                case 3:
                  try
                  {
                    DataClassMetadata dataClassMetadata = (DataClassMetadata) DataClassGenerator.vwdbgsEOitHfk1VYcv5A(DataClassGenerator.ak58dnEOVUfRyTB8kEJk(), DataClassGenerator.dvdJQ1EOSFEMM9Ru6B0E((object) current));
                    int num3 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0)
                      num3 = 0;
                    while (true)
                    {
                      switch (num3)
                      {
                        case 1:
                          goto label_12;
                        default:
                          comments.Add((ISyntaxTrivia) DataClassGenerator.iE43wYEOKSriXhJ9XXeL(DataClassGenerator.YS4MhWEOqdCBDpTAyg5h(DataClassGenerator.HhOugrEOR2W4DIjNu4M6(825385222 ^ 825638134), (object) dataClassMetadata.FullTypeName)));
                          num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0 ? 1 : 0;
                          continue;
                      }
                    }
                  }
                  catch (Exception ex)
                  {
                    int num4 = 0;
                    if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
                      num4 = 0;
                    switch (num4)
                    {
                      default:
                        goto label_12;
                    }
                  }
                default:
                  goto label_23;
              }
label_4:
              current = enumerator.Current;
              num2 = 3;
              goto label_3;
label_13:
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 0 : 0;
              goto label_3;
            }
            finally
            {
              enumerator.Dispose();
              int num5 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
                num5 = 0;
              switch (num5)
              {
                default:
              }
            }
          case 3:
            enumerator = metadata.IncludeList.GetEnumerator();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 2 : 0;
            continue;
          case 4:
label_23:
            type.TextComments((IEnumerable<ISyntaxTrivia>) comments);
            num1 = 5;
            continue;
          case 5:
            goto label_18;
          default:
            goto label_14;
        }
      }
label_20:
      return;
label_18:
      return;
label_14:;
    }

    public DataClassGenerator()
    {
      DataClassGenerator.gnRIZcEOXraTm8qFCPvE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object ak58dnEOVUfRyTB8kEJk() => (object) DataClassGenerator.DataClassDescriptor;

    internal static Guid dvdJQ1EOSFEMM9Ru6B0E([In] object obj0) => ((Dependency) obj0).HeaderUid;

    internal static object vwdbgsEOitHfk1VYcv5A([In] object obj0, Guid typeUid) => (object) ((DataClassDescriptor) obj0).GetMetadataByUid(typeUid);

    internal static object HhOugrEOR2W4DIjNu4M6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object YS4MhWEOqdCBDpTAyg5h([In] object obj0, [In] object obj1) => (object) string.Format((string) obj0, obj1);

    internal static object iE43wYEOKSriXhJ9XXeL([In] object obj0) => (object) ((string) obj0).TextComment();

    internal static bool Bv6UA3EOujxaeEZIRZln() => DataClassGenerator.kXENJuEOZUsD5AGDLuJj == null;

    internal static DataClassGenerator sdWrF6EOI6triR0vc5GH() => DataClassGenerator.kXENJuEOZUsD5AGDLuJj;

    internal static void gnRIZcEOXraTm8qFCPvE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}

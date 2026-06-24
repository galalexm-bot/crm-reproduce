// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Files.DTO.AutoMaps.BinaryFileMap
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using AutoMapper;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.AutoMaps;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using System;
using System.IO;

namespace EleWise.ELMA.Files.DTO.AutoMaps
{
  public class BinaryFileMap : BidirectionalMap<BinaryFile, BinaryFileDTO>
  {
    internal static BinaryFileMap w3aRYoGnN5hK8j63fyHL;

    protected override void InitMap(IMappingExpression<BinaryFile, BinaryFileDTO> map)
    {
      base.InitMap(map);
      map.AfterMap((Action<BinaryFile, BinaryFileDTO>) ((f, dto) =>
      {
        int num1 = 3;
        Stream content;
        while (true)
        {
          int num2 = num1;
          while (true)
          {
            switch (num2)
            {
              case 0:
                goto label_19;
              case 1:
                goto label_8;
              case 2:
                content = f.GetContent(GetContentOptions.NonSeekable);
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 1 : 1;
                continue;
              case 3:
                goto label_5;
              case 4:
                goto label_3;
              default:
                goto label_12;
            }
          }
label_5:
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          if (!BinaryFileMap.\u003C\u003Ec.yqiAFUvzvluAsGxQgxZT(BinaryFileMap.\u003C\u003Ec.tbkUhmvzCZMOhwDG5brO((object) f), Guid.Empty))
            num1 = 2;
          else
            goto label_16;
        }
label_19:
        return;
label_3:
        return;
label_12:
        return;
label_16:
        return;
label_8:
        try
        {
          // ISSUE: reference to a compiler-generated method
          dto.Content = (byte[]) BinaryFileMap.\u003C\u003Ec.RZ8E9qvz8b7gWM8rGma1((object) content);
          int num3 = 0;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
            num3 = 0;
          switch (num3)
          {
          }
        }
        finally
        {
          int num4;
          if (content == null)
            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
          else
            goto label_17;
label_15:
          switch (num4)
          {
            case 2:
              break;
            default:
          }
label_17:
          // ISSUE: reference to a compiler-generated method
          BinaryFileMap.\u003C\u003Ec.lvaCkavzZ8LoZmEQJXMS((object) content);
          num4 = 1;
          if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
          {
            num4 = 1;
            goto label_15;
          }
          else
            goto label_15;
        }
      }));
    }

    protected override void InitReverseMap(IMappingExpression<BinaryFileDTO, BinaryFile> map)
    {
      base.InitReverseMap(map);
      map.ConstructUsing((Func<BinaryFileDTO, BinaryFile>) (dto =>
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_5;
            case 2:
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (!BinaryFileMap.\u003C\u003Ec.GjcK5ovzIOwIsj0aZXHE(BinaryFileMap.\u003C\u003Ec.UYtZptvzuUks7mXI6jbN((object) dto)))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 1;
                continue;
              }
              goto label_4;
            default:
              goto label_4;
          }
        }
label_4:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return ((BinaryFileBuilder) BinaryFileMap.\u003C\u003Ec.jwcUOsvzSlKLFBy9rywG((object) BinaryFile.CreateNew(), BinaryFileMap.\u003C\u003Ec.RkJXp1vzV5xEegInQZQX((object) dto))).Build();
label_5:
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        return (BinaryFile) BinaryFileMap.\u003C\u003Ec.sseWHgvzibB2v3gdkxLV((object) Locator.GetServiceNotNull<IFileManager>(), BinaryFileMap.\u003C\u003Ec.UYtZptvzuUks7mXI6jbN((object) dto));
      }));
    }

    public BinaryFileMap()
    {
      BinaryFileMap.T4wB3QGna8Y7iTTgpeIZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void T4wB3QGna8Y7iTTgpeIZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool sdIYn2Gn3ojrwLKk2cwK() => BinaryFileMap.w3aRYoGnN5hK8j63fyHL == null;

    internal static BinaryFileMap M6v5quGnpRQ7YcTpCxnr() => BinaryFileMap.w3aRYoGnN5hK8j63fyHL;
  }
}

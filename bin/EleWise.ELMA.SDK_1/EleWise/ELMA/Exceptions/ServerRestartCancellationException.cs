// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ServerRestartCancellationException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка отмены запланированного перезапуска сервера.</summary>
  [Serializable]
  public class ServerRestartCancellationException : Exception
  {
    internal static ServerRestartCancellationException fM1xhtGg4Hr67NYhaRDQ;

    /// <summary>Идентификатор перезапуска.</summary>
    public Guid RestartId
    {
      get => this.\u003CRestartId\u003Ek__BackingField;
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
              this.\u003CRestartId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" />.
    /// </summary>
    public ServerRestartCancellationException()
    {
      ServerRestartCancellationException.Q8jr7vGgAUSmy2iM6bvk();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" /> с
    /// идентификатором запланированного перезапуска и сообщением об ошибке.
    /// </summary>
    /// <param name="restartId">Идентификатор перезапуска.</param>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    public ServerRestartCancellationException(Guid restartId, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.RestartId = restartId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" /> с
    /// идентификатором запланированного перезапуска, сообщением об ошибке и
    /// ссылкой на внутреннее исключение, вызвавшее данное исключение.
    /// </summary>
    /// <param name="restartId">Идентификатор перезапуска.</param>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка, если внутреннее исключение не задано.</param>
    public ServerRestartCancellationException(
      Guid restartId,
      string message,
      Exception innerException)
    {
      ServerRestartCancellationException.Q8jr7vGgAUSmy2iM6bvk();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.RestartId = restartId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" /> с
    /// указанным сообщением об ошибке.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    public ServerRestartCancellationException(string message)
    {
      ServerRestartCancellationException.Q8jr7vGgAUSmy2iM6bvk();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" /> с
    /// указанным сообщением об ошибке и ссылкой на внутреннее исключение, вызвавшее данное исключение.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или пустая ссылка, если внутреннее исключение не задано.</param>
    public ServerRestartCancellationException(string message, Exception innerException)
    {
      ServerRestartCancellationException.Q8jr7vGgAUSmy2iM6bvk();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartCancellationException" /> с сериализованными данными.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
    /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
    protected ServerRestartCancellationException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.RestartId = (Guid) ServerRestartCancellationException.hnLZXSGgx7IDp9F5g6TR((object) info, ServerRestartCancellationException.YvG4xmGg7tCaqaAPHguI(-1317790512 ^ -1318057728), typeof (Guid));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Заполняет объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> данными, необходимыми для сериализации исключения.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" /> для заполнения данными.</param>
    /// <param name="context">Конечный объект <see cref="T:System.Runtime.Serialization.StreamingContext" /> для этой сериализации.</param>
    public override void GetObjectData(SerializationInfo info, StreamingContext context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            ServerRestartCancellationException.qtVCXDGgyqqnVitV9h3S((object) info, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(964881585 - -1459193222 ^ -1871157273), (object) this.RestartId, ServerRestartCancellationException.hwDMOyGgmOtkMnEyuqWv(__typeref (Guid)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa != 0 ? 0 : 0;
            continue;
          case 2:
            ServerRestartCancellationException.DXLc2dGg05tMpJs3tNTK((object) this, (object) info, context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool y03v0TGg61PCPBC1EHKh() => ServerRestartCancellationException.fM1xhtGg4Hr67NYhaRDQ == null;

    internal static ServerRestartCancellationException RPWsXOGgHuuOlfBkfL5i() => ServerRestartCancellationException.fM1xhtGg4Hr67NYhaRDQ;

    internal static void Q8jr7vGgAUSmy2iM6bvk() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object YvG4xmGg7tCaqaAPHguI(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object hnLZXSGgx7IDp9F5g6TR([In] object obj0, [In] object obj1, [In] Type obj2) => ((SerializationInfo) obj0).GetValue((string) obj1, obj2);

    internal static void DXLc2dGg05tMpJs3tNTK([In] object obj0, [In] object obj1, [In] StreamingContext obj2) => __nonvirtual (((Exception) obj0).GetObjectData((SerializationInfo) obj1, obj2));

    internal static Type hwDMOyGgmOtkMnEyuqWv([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static void qtVCXDGgyqqnVitV9h3S([In] object obj0, [In] object obj1, [In] object obj2, [In] Type obj3) => ((SerializationInfo) obj0).AddValue((string) obj1, obj2, obj3);
  }
}

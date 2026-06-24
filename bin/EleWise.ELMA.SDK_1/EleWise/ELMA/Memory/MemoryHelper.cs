// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Memory.MemoryHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.IO;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace EleWise.ELMA.Memory
{
  /// <summary>Класс хелпера для работы с памятью</summary>
  public static class MemoryHelper
  {
    private static MemoryHelper Ll3imgBeHpVGSsDffDVM;

    /// <summary>
    /// Получить <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream GetMemoryStream() => (MemoryStream) new NativeMemoryStream();

    /// <summary>
    /// Получить <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="requiredSize">Требуемый размер в байтах</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream GetMemoryStream(int requiredSize) => (MemoryStream) new NativeMemoryStream(requiredSize);

    /// <summary>
    /// Получить <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="buffer">Буфер состояния потока</param>
    /// <param name="writable"><c>true</c> если поток предназначен для записи</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream GetMemoryStream(byte[] buffer, bool writable) => new MemoryStream(buffer, writable);

    /// <summary>
    /// Получить <see cref="T:System.IO.MemoryStream" />
    /// </summary>
    /// <param name="buffer">Буфер состояния потока</param>
    /// <param name="offset">Смещение относительно начала буфера</param>
    /// <param name="length">Длина считываемых из буфера данных</param>
    /// <param name="writable"><c>true</c> если поток предназначен для записи</param>
    /// <returns>Поток в памяти</returns>
    public static MemoryStream GetMemoryStream(
      byte[] buffer,
      int offset,
      int length,
      bool writable)
    {
      return new MemoryStream(buffer, offset, length, writable);
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    public static void ActionWithMemoryBuffer<T>(
      int minimumBufferLength,
      MemoryHelper.ActionWithMemoryBufferDelegate<T> action)
    {
      Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751247332));
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1120607109 - 305487170 ^ -1426153779));
      using (IMemoryOwner<T> memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength))
      {
        ArraySegment<T> segment;
        if (!MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memoryOwner.Memory.Slice(0, minimumBufferLength), out segment))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3401164)));
        action(segment.Array, segment.Offset, minimumBufferLength);
      }
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип передаваемого параметра</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    public static void ActionWithMemoryBuffer<T, TParam>(
      int minimumBufferLength,
      TParam param,
      MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<T, TParam> action)
    {
      Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822827548));
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787385199));
      using (IMemoryOwner<T> memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength))
      {
        ArraySegment<T> segment;
        if (!MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memoryOwner.Memory.Slice(0, minimumBufferLength), out segment))
          throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 901871701)));
        action(segment.Array, segment.Offset, minimumBufferLength, param);
      }
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип передаваемого параметра</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    public static async Task ActionWithMemoryBufferAsync<T, TParam>(
      int minimumBufferLength,
      TParam param,
      MemoryHelper.ActionWithMemoryBufferAndParameterDelegateAsync<T, TParam> action)
    {
      int num1 = 4;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_47;
          case 1:
label_4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = 2;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0 ? 0 : 0;
            continue;
          case 3:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 3;
              else
                goto label_35;
label_7:
              IMemoryOwner<T> memoryOwner;
              while (true)
              {
                switch (num3)
                {
                  case 1:
label_38:
                    memoryOwner = (IMemoryOwner<T>) null;
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
                    continue;
                  case 2:
                    try
                    {
                      int num4;
                      if (num2 != 0)
                        num4 = 13;
                      else
                        goto label_14;
label_10:
                      TaskAwaiter taskAwaiter;
                      TaskAwaiter awaiter;
                      System.Memory<T> memory;
                      ArraySegment<T> segment;
                      while (true)
                      {
                        switch (num4)
                        {
                          case 1:
                            goto label_14;
                          case 2:
                            awaiter = action(segment.Array, segment.Offset, minimumBufferLength, param).GetAwaiter();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 4 : 10;
                            continue;
                          case 3:
                            goto label_38;
                          case 4:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, MemoryHelper.\u003CActionWithMemoryBufferAsync\u003Ed__12<T, TParam>>(ref awaiter, this);
                            num4 = 9;
                            continue;
                          case 5:
                          case 14:
                            goto label_24;
                          case 7:
                            taskAwaiter = awaiter;
                            num4 = 4;
                            continue;
                          case 8:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = -1;
                            num4 = 6;
                            continue;
                          case 9:
                            goto label_40;
                          case 10:
                            if (awaiter.IsCompleted)
                            {
                              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                              continue;
                            }
                            goto case 11;
                          case 11:
                            // ISSUE: explicit reference operation
                            // ISSUE: reference to a compiler-generated field
                            (^this).\u003C\u003E1__state = num2 = 0;
                            num4 = 7;
                            continue;
                          case 12:
                            taskAwaiter = new TaskAwaiter();
                            num4 = 8;
                            continue;
                          case 13:
                            memory = memoryOwner.Memory;
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 15 : 11;
                            continue;
                          case 15:
                            if (!MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memory.Slice(0, minimumBufferLength), out segment))
                            {
                              num4 = 5;
                              continue;
                            }
                            goto case 2;
                          default:
                            awaiter.GetResult();
                            num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 2 : 3;
                            continue;
                        }
                      }
label_40:
                      return;
label_24:
                      throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 1333660732)));
label_14:
                      awaiter = taskAwaiter;
                      num4 = 12;
                      goto label_10;
                    }
                    finally
                    {
                      int num5;
                      if (num2 >= 0)
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
                      else
                        goto label_28;
label_27:
                      while (true)
                      {
                        switch (num5)
                        {
                          case 1:
                            memoryOwner.Dispose();
                            num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 2 : 1;
                            continue;
                          case 3:
                            goto label_28;
                          default:
                            goto label_33;
                        }
                      }
label_28:
                      if (memoryOwner != null)
                      {
                        num5 = 1;
                        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
                        {
                          num5 = 1;
                          goto label_27;
                        }
                        else
                          goto label_27;
                      }
label_33:;
                    }
                  case 3:
                    Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317723860));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 6;
                    continue;
                  case 4:
                    goto label_35;
                  case 5:
                    memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 4 : 1;
                    continue;
                  case 6:
                    Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751240172));
                    num3 = 5;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_35:
              num3 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
              {
                num3 = 2;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num6 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
                num6 = 0;
              while (true)
              {
                switch (num6)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 2 : 0;
                    continue;
                  case 2:
                    goto label_32;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num6 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
                    continue;
                }
              }
label_32:
              return;
            }
          case 4:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = 3;
            continue;
          default:
            goto label_44;
        }
      }
label_47:
      return;
label_44:;
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    /// <returns>Результат</returns>
    public static TResult ActionWithMemoryBuffer<T, TResult>(
      int minimumBufferLength,
      MemoryHelper.ActionWithMemoryBufferDelegate<T, TResult> action)
    {
      Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824311711));
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 132975819));
      using (IMemoryOwner<T> memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength))
      {
        ArraySegment<T> segment;
        if (MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memoryOwner.Memory.Slice(0, minimumBufferLength), out segment))
          return action(segment.Array, segment.Offset, minimumBufferLength);
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1839087379 - 334718690 ^ 2121229349)));
      }
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип передаваемого параметра</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    /// <returns>Результат</returns>
    public static TResult ActionWithMemoryBuffer<T, TParam, TResult>(
      int minimumBufferLength,
      TParam param,
      MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<T, TParam, TResult> action)
    {
      Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(2045296739 + 1688595713 ^ -561016680));
      Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335065093));
      using (IMemoryOwner<T> memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength))
      {
        ArraySegment<T> segment;
        if (MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memoryOwner.Memory.Slice(0, minimumBufferLength), out segment))
          return action(segment.Array, segment.Offset, minimumBufferLength, param);
        throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217450217)));
      }
    }

    /// <summary>
    /// Выполнить указанное действие, используя буфер памяти требуемого размера
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип передаваемого параметра</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="minimumBufferLength">Минимальный требуемый размер буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <param name="action">Действие, выполняемое при использовании буфера памяти</param>
    /// <returns>Результат</returns>
    public static async Task<TResult> ActionWithMemoryBufferAsync<T, TParam, TResult>(
      int minimumBufferLength,
      TParam param,
      MemoryHelper.ActionWithMemoryBufferAndParameterDelegateAsync<T, TParam, TResult> action)
    {
      int num1 = 1;
      TResult result;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            num2 = (^this).\u003C\u003E1__state;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 2:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003Et__builder.SetResult(result);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0 ? 0 : 4;
            continue;
          case 3:
label_46:
            // ISSUE: explicit reference operation
            // ISSUE: reference to a compiler-generated field
            (^this).\u003C\u003E1__state = -2;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 1 : 2;
            continue;
          case 4:
            goto label_45;
          default:
            try
            {
              int num3;
              if (num2 != 0)
                num3 = 4;
              else
                goto label_10;
label_7:
              IMemoryOwner<T> memoryOwner;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_10;
                  case 2:
                    Contract.ArgumentNotNull((object) action, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1598106783 - -968262081 ^ -629912362));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
                    continue;
                  case 3:
                    goto label_12;
                  case 4:
                    Contract.CheckArgument(minimumBufferLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669371371 ^ 1669441559));
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 2 : 2;
                    continue;
                  default:
                    memoryOwner = MemoryPool<T>.Shared.Rent(minimumBufferLength);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 1;
                    continue;
                }
              }
label_12:
              try
              {
                int num4;
                if (num2 != 0)
                {
                  num4 = 3;
                  goto label_15;
                }
                else
                  goto label_26;
label_14:
                int num5;
                num4 = num5;
label_15:
                TaskAwaiter<TResult> taskAwaiter;
                System.Memory<T> memory;
                ArraySegment<T> segment;
                TaskAwaiter<TResult> awaiter;
                while (true)
                {
                  switch (num4)
                  {
                    case 1:
                      goto label_46;
                    case 2:
                      if (awaiter.IsCompleted)
                      {
                        num4 = 11;
                        continue;
                      }
                      goto case 12;
                    case 3:
                      memory = memoryOwner.Memory;
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                      continue;
                    case 4:
                      goto label_26;
                    case 5:
                      awaiter = action(segment.Array, segment.Offset, minimumBufferLength, param).GetAwaiter();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 2 : 2;
                      continue;
                    case 6:
                      taskAwaiter = awaiter;
                      num4 = 7;
                      continue;
                    case 7:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TResult>, MemoryHelper.\u003CActionWithMemoryBufferAsync\u003Ed__15<T, TParam, TResult>>(ref awaiter, this);
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 8 : 8;
                      continue;
                    case 8:
                      goto label_42;
                    case 9:
                    case 14:
                      goto label_29;
                    case 10:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = -1;
                      num4 = 15;
                      continue;
                    case 11:
                    case 15:
                      result = awaiter.GetResult();
                      num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 1 : 1;
                      continue;
                    case 12:
                      // ISSUE: explicit reference operation
                      // ISSUE: reference to a compiler-generated field
                      (^this).\u003C\u003E1__state = num2 = 0;
                      num4 = 6;
                      continue;
                    case 13:
                      taskAwaiter = new TaskAwaiter<TResult>();
                      num4 = 10;
                      continue;
                    default:
                      if (MemoryMarshal.TryGetArray<T>((ReadOnlyMemory<T>) memory.Slice(0, minimumBufferLength), out segment))
                        goto case 5;
                      else
                        goto label_22;
                  }
                }
label_42:
                return;
label_22:
                num5 = 9;
                goto label_14;
label_29:
                throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2106517564 ^ -2106578454)));
label_26:
                awaiter = taskAwaiter;
                num5 = 13;
                goto label_14;
              }
              finally
              {
                if (num2 < 0)
                {
                  int num6 = 2;
                  while (true)
                  {
                    int num7 = num6;
                    while (true)
                    {
                      switch (num7)
                      {
                        case 1:
                        case 3:
                          goto label_38;
                        case 2:
                          if (memoryOwner == null)
                          {
                            num7 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
                            continue;
                          }
                          goto label_34;
                        default:
                          goto label_34;
                      }
                    }
label_34:
                    memoryOwner.Dispose();
                    num6 = 3;
                  }
                }
label_38:;
              }
label_10:
              num3 = 3;
              goto label_7;
            }
            catch (Exception ex)
            {
              int num8 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
                num8 = 0;
              while (true)
              {
                switch (num8)
                {
                  case 1:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003Et__builder.SetException(ex);
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 0;
                    continue;
                  case 2:
                    goto label_35;
                  default:
                    // ISSUE: explicit reference operation
                    // ISSUE: reference to a compiler-generated field
                    (^this).\u003C\u003E1__state = -2;
                    num8 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 0 : 1;
                    continue;
                }
              }
label_35:
              return;
            }
        }
      }
label_45:;
    }

    /// <summary>Сравнение 2-х потоков</summary>
    /// <param name="stream1">Поток 1</param>
    /// <param name="stream2">Поток 2</param>
    /// <returns><see langword="true" />, если потоки идентичны, иначе <see langword="false" /></returns>
    /// <remarks>
    /// Потоки сравниваются с текущей позиции, необходимо предварительно их перевести в начало, если нужно сравнить полностью
    /// </remarks>
    public static bool StreamEquals(Stream stream1, Stream stream2) => MemoryHelper.ActionWithMemoryBuffer<byte, (Stream, Stream), bool>(2048, (stream1, stream2), new MemoryHelper.ActionWithMemoryBufferAndParameterDelegate<byte, (Stream, Stream), bool>(MemoryHelper.StreamEquals));

    private static bool StreamEquals(
      object buffer,
      int bufferOffset,
      int bufferLength,
      (Stream, Stream) param)
    {
      (Stream stream1, Stream stream2) = param;
      int length1;
      int length2;
      do
      {
        length1 = stream1.Read((byte[]) buffer, bufferOffset, 1024);
        length2 = stream2.Read((byte[]) buffer, bufferOffset + 1024, 1024);
        if (length1 != length2 || !((byte[]) buffer).AsSpan<byte>(bufferOffset, length1).SequenceEqual<byte>((ReadOnlySpan<byte>) ((byte[]) buffer).AsSpan<byte>(bufferOffset + 1024, length2)))
          return false;
      }
      while (length1 < 1024 && length2 < 1024);
      return true;
    }

    internal static bool sBUOAGBeAEJF0mBTyU7n() => MemoryHelper.Ll3imgBeHpVGSsDffDVM == null;

    internal static MemoryHelper w5CS7vBe7qkpxlXvavIb() => MemoryHelper.Ll3imgBeHpVGSsDffDVM;

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate void ActionWithMemoryBufferDelegate<in T>(
      T[] buffer,
      int bufferOffset,
      int bufferLength);

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип параметра</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate void ActionWithMemoryBufferAndParameterDelegate<in T, in TParam>(
      T[] buffer,
      int bufferOffset,
      int bufferLength,
      TParam param);

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип параметра</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate Task ActionWithMemoryBufferAndParameterDelegateAsync<in T, in TParam>(
      T[] buffer,
      int bufferOffset,
      int bufferLength,
      TParam param);

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate TResult ActionWithMemoryBufferDelegate<in T, out TResult>(
      T[] buffer,
      int bufferOffset,
      int bufferLength);

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип параметра</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate TResult ActionWithMemoryBufferAndParameterDelegate<in T, in TParam, out TResult>(
      T[] buffer,
      int bufferOffset,
      int bufferLength,
      TParam param);

    /// <summary>
    /// Тип метода действия, выполняемого при использовании буфера памяти
    /// </summary>
    /// <typeparam name="T">Тип элемента буфера</typeparam>
    /// <typeparam name="TParam">Тип параметра</typeparam>
    /// <typeparam name="TResult">Тип результата</typeparam>
    /// <param name="buffer">Буфер памяти</param>
    /// <param name="bufferOffset">Положение первого элемента в диапазоне, ограниченном фрагментом буфера, относительно начала буфера</param>
    /// <param name="bufferLength">Rоличество элементов в диапазоне, ограниченном фрагментом буфера</param>
    /// <param name="param">Передаваемый параметр</param>
    /// <remarks>
    /// При необходимости использовать <c>buffer</c> за пределами тела делегата, необходимо создать его копию.
    /// В противном случае данные, хранящиеся в буфере, могут быть повреждены
    /// </remarks>
    public delegate Task<TResult> ActionWithMemoryBufferAndParameterDelegateAsync<in T, in TParam, TResult>(
      T[] buffer,
      int bufferOffset,
      int bufferLength,
      TParam param);
  }
}

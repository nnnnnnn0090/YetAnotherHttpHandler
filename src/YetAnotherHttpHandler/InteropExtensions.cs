using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;

namespace Cysharp.Net.Http
{
    partial struct StringBuffer
    {
        public unsafe StringBuffer(byte* ptr,  int length)
        {
            this.ptr = ptr;
            this.length = length;
        }
    }

    partial struct ByteBuffer
    {
        public unsafe Span<byte> AsSpan()
        {
            return new Span<byte>(ptr, length);
        }

        public unsafe Span<T> AsSpan<T>() where T : unmanaged
        {
            int size = sizeof(T);
            return new Span<T>(ptr, length / size);
        }
    }
}

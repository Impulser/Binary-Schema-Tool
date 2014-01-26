// ****************************************
// Assembly : Schema Tool
// File     : Unsigned.cs
// Author   : Alex
// Created  : 26/01/2014
// ****************************************

using System.Runtime.InteropServices;
using SchemaTool.Schema.Fields;

namespace SchemaTool.Schema.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public class u1 : Field<byte> { }

    [StructLayout(LayoutKind.Sequential)]
    public class u2 : Field<uint> { }

    [StructLayout(LayoutKind.Sequential)]
    public class u4 : Field<uint> { }

    [StructLayout(LayoutKind.Sequential)]
    public class u8 : Field<ulong> { }
}
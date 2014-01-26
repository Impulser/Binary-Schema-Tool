// ****************************************
// Assembly : Schema Tool
// File     : Signed.cs
// Author   : Alex
// Created  : 26/01/2014
// ****************************************

using System.Runtime.InteropServices;
using SchemaTool.Schema.Fields;

namespace SchemaTool.Schema.Types
{
    [StructLayout(LayoutKind.Sequential)]
    public class i1 : Field<sbyte> { }

    [StructLayout(LayoutKind.Sequential)]
    public class i2 : Field<int> { }

    [StructLayout(LayoutKind.Sequential)]
    public class i4 : Field<int> { }

    [StructLayout(LayoutKind.Sequential)]
    public class i8 : Field<long> { }
}
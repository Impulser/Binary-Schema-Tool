// ****************************************
// Assembly : Schema Tool
// File     : BaseElement.cs
// Author   : Alex
// Created  : 26/01/2014
// ****************************************

using System;
using System.Runtime.InteropServices;
using SchemaTool.Schema.Fields;

namespace SchemaTool.Schema.Elements
{
    public class BaseElement<TElement>
        : Field<TElement>
    {
        private readonly TypeCode _elementTypeCode;
        private readonly int _size;

        public BaseElement(TElement elementValue)
            : base(elementValue)
        {
            var elementType = typeof (TElement);
            _elementTypeCode = elementType.Attributes.GetTypeCode();
            _size = Marshal.SizeOf(elementType);
        }

        public BaseElement(string elementName, TElement elementValue)
            : this(elementValue)
        {
            Name = elementName;
        }

        public TConvert GetValue<TConvert>()
        {
            return (TConvert) Convert.ChangeType(Value, typeof (TConvert));
        }

        public string Name { get; set; }

        public TypeCode ElementTypeCode
        {
            get { return _elementTypeCode; }
        }

        public int Size
        {
            get { return _size; }
        }
    }
}
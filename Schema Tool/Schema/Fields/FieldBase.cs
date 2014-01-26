using System.Runtime.InteropServices;

namespace SchemaTool.Schema.Fields
{
    [StructLayout(LayoutKind.Sequential)]
    public class FieldBase
    {
        public FieldBase()
            : this(null) { }

        public FieldBase(object fieldValue)
        {
            Value = fieldValue;
        }

        public object Value { get; set; }
    }
}
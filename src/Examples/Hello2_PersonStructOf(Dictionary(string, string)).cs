//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on 2018 June 16 17:46:02 UTC
// </auto-generated>
//---------------------------------------------------------
using System.CodeDom.Compiler;
using System.Runtime.CompilerServices;

namespace go
{
    public static partial class main_package
    {
        [GeneratedCode("go2cs", "0.1.1.0")]
        public partial struct Person
        {
            // Value of the Person struct
            private readonly Dictionary<string, string> m_value;

            public Person(Dictionary<string, string> value) => m_value = value;

            // Enable implicit conversions between Dictionary<string, string> and Person struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Person(Dictionary<string, string> value) => new Person(value);
            
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Dictionary<string, string>(Person value) => value.m_value;
            
            // Enable comparisons between nil and Person struct
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(Person value, NilType nil) => value.Equals(default(Person));

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(Person value, NilType nil) => !(value == nil);

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator ==(NilType nil, Person value) => value == nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static bool operator !=(NilType nil, Person value) => value != nil;

            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            public static implicit operator Person(NilType nil) => default(Person);
        }
    }
}

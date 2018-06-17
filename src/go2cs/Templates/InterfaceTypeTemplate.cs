﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version: 15.0.0.0
//  
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------
namespace go2cs.Templates
{
    using System.Linq;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "15.0.0.0")]
    public partial class InterfaceTypeTemplate : TemplateBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public override string TransformText()
        {
            
            #line 1 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
 // This template creates a <PackageName>_<InterfaceName>Interface.cs file 
            
            #line default
            #line hidden
            this.Write(@"//---------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool. Changes to this
//     file may cause incorrect behavior and will be lost
//     if the code is regenerated.
//
//     Generated on ");
            
            #line 11 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedTime));
            
            #line default
            #line hidden
            this.Write("\r\n// </auto-generated>\r\n//-------------------------------------------------------" +
                    "--\r\nusing System;\r\nusing System.CodeDom.Compiler;\r\nusing System.Diagnostics;\r\nus" +
                    "ing System.Reflection;\r\nusing System.Runtime.CompilerServices;\r\n");
            
            #line 19 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
if (!NamespacePrefix.Equals("go")) {
            
            #line default
            #line hidden
            this.Write("using go;\r\n");
            
            #line 21 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
}
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 23 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceHeader));
            
            #line default
            #line hidden
            this.Write("\r\n    public static partial class ");
            
            #line 24 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package\r\n    {\r\n        [");
            
            #line 26 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            
            #line default
            #line hidden
            this.Write("]\r\n        [PromotedInterface(typeof(");
            
            #line 27 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("))]\r\n        ");
            
            #line 28 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Scope));
            
            #line default
            #line hidden
            this.Write(" struct ");
            
            #line 28 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> : ");
            
            #line 28 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("\r\n        {\r\n            private T m_target;");
            
            #line 30 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"

        
            foreach (var decl in Functions)
            {
                
            
            #line default
            #line hidden
            
            #line 34 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new InterfaceFuncDeclTemplate
                {
                    FunctionName = decl.functionName,
                    Scope = "public",
                    ParameterSignature = decl.parameterSignature,
                    NamedParameters = decl.namedParameters,
                    ParameterTypes = decl.parameterTypes,
                    ResultType = decl.resultType
                }
                .TransformText()));
            
            #line default
            #line hidden
            
            #line 43 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"

            }
            
            #line default
            #line hidden
            this.Write("\r\n\r\n            [DebuggerStepperBoundary]\r\n            static ");
            
            #line 48 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("()\r\n            {\r\n                Type targetType = typeof(T);\r\n                " +
                    "MethodInfo extensionMethod;");
            
            #line 51 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"

                
                foreach (var decl in Functions)
                {
                    
            
            #line default
            #line hidden
            
            #line 55 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(new InterfaceFuncInitTemplate
                    {
                        FunctionName = decl.functionName,
                        InterfaceName = InterfaceName
                    }
                    .TransformText()));
            
            #line default
            #line hidden
            
            #line 60 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"

                }
            
            #line default
            #line hidden
            this.Write("\r\n            }\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveInlining)," +
                    " DebuggerNonUserCode]\r\n            public static explicit operator ");
            
            #line 66 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T>(T target) => new ");
            
            #line 66 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> { m_target = target };\r\n\r\n            // Enable comparisons between nil and ");
            
            #line 68 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> interface instance\r\n            [MethodImpl(MethodImplOptions.AggressiveInlin" +
                    "ing)]\r\n            public static bool operator ==(");
            
            #line 70 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> value, NilType nil) => (object)value == null || Activator.CreateInstance<");
            
            #line 70 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T>>().Equals(value);\r\n\r\n            [MethodImpl(MethodImplOptions.AggressiveInli" +
                    "ning)]\r\n            public static bool operator !=(");
            
            #line 73 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> value, NilType nil) => !(value == nil);\r\n\r\n            [MethodImpl(MethodImpl" +
                    "Options.AggressiveInlining)]\r\n            public static bool operator ==(NilType" +
                    " nil, ");
            
            #line 76 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> value) => value == nil;\r\n\r\n            [MethodImpl(MethodImplOptions.Aggressi" +
                    "veInlining)]\r\n            public static bool operator !=(NilType nil, ");
            
            #line 79 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T> value) => value != nil;\r\n        }\r\n\r\n        [");
            
            #line 82 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(GeneratedCodeAttribute));
            
            #line default
            #line hidden
            this.Write(", MethodImpl(MethodImplOptions.AggressiveInlining), DebuggerNonUserCode]\r\n       " +
                    " ");
            
            #line 83 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(Scope));
            
            #line default
            #line hidden
            this.Write(" static ");
            
            #line 83 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 83 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("_cast<T>(T target)\r\n        {\r\n            if (typeof(");
            
            #line 85 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(").IsAssignableFrom(typeof(T)))\r\n                return target as ");
            
            #line 86 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(";\r\n\r\n            return (");
            
            #line 88 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write("<T>)target;\r\n        }\r\n    }\r\n");
            
            #line 91 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespaceFooter));
            
            #line default
            #line hidden
            this.Write("\r\n\r\nnamespace go\r\n{\r\n    public partial class NilType\r\n    {\r\n        // Enable c" +
                    "omparisons between nil and ");
            
            #line 97 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" interface\r\n        [MethodImpl(MethodImplOptions.AggressiveInlining)]\r\n        p" +
                    "ublic static bool operator ==(");
            
            #line 99 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespacePrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 99 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package.");
            
            #line 99 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => (object)value == null || Activator.CreateInstance(value.G" +
                    "etType()).Equals(value);\r\n\r\n        [MethodImpl(MethodImplOptions.AggressiveInli" +
                    "ning)]\r\n        public static bool operator !=(");
            
            #line 102 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespacePrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 102 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package.");
            
            #line 102 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" value, NilType nil) => !(value == nil);\r\n\r\n        [MethodImpl(MethodImplOptions" +
                    ".AggressiveInlining)]\r\n        public static bool operator ==(NilType nil, ");
            
            #line 105 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespacePrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 105 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package.");
            
            #line 105 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" value) => value == nil;\r\n\r\n        [MethodImpl(MethodImplOptions.AggressiveInlin" +
                    "ing)]\r\n        public static bool operator !=(NilType nil, ");
            
            #line 108 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(NamespacePrefix));
            
            #line default
            #line hidden
            this.Write(".");
            
            #line 108 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(PackageName));
            
            #line default
            #line hidden
            this.Write("_package.");
            
            #line 108 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(InterfaceName));
            
            #line default
            #line hidden
            this.Write(" value) => value != nil;\r\n    }\r\n}");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 110 "C:\Projects\go2cs\src\go2cs\Templates\InterfaceTypeTemplate.tt"

// Template Parameters
public string NamespacePrefix;
public string NamespaceHeader;
public string NamespaceFooter;
public string PackageName;
public string InterfaceName;
public string Scope;
public (string functionName, string parameterSignature, string namedParameters, string parameterTypes, string resultType)[] Functions;

        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
}
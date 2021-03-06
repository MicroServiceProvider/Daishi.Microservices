﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Daishi.Microservices.Components.Serialisation.Specs {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Daishi.Microservices.Components.Serialisation.Specs.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;response&quot;:{&quot;item&quot;:{&quot;name&quot;:&quot;Item #1&quot;,&quot;metadata&quot;:&quot;1&quot;}},&quot;item&quot;:{&quot;name&quot;:&quot;Item #2&quot;,&quot;metadata&quot;:&quot;2&quot;},&quot;footer&quot;:{&quot;item&quot;:{&quot;name&quot;:&quot;Item #1&quot;,&quot;metadata&quot;:&quot;1&quot;}}}.
        /// </summary>
        internal static string JSONWithDuplicateObjects {
            get {
                return ResourceManager.GetString("JSONWithDuplicateObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;item&quot;:{&quot;name&quot;:&quot;Item #1&quot;},&quot;container&quot;:{&quot;item&quot;:{&quot;name&quot;:&quot;Item #2&quot;}}}.
        /// </summary>
        internal static string JSONWithMultipleItems {
            get {
                return ResourceManager.GetString("JSONWithMultipleItems", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;name&quot;:[&quot;address&quot;,&quot;test&quot;],&quot;address&quot;:{&quot;line1&quot;:&quot;1&quot;,&quot;line2&quot;:&quot;Fake Road&quot;,&quot;town&quot;:&quot;Some Town&quot;}}.
        /// </summary>
        internal static string JSONWithSameValueAsPropertyName {
            get {
                return ResourceManager.GetString("JSONWithSameValueAsPropertyName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;commandName&quot;:&quot;GETTOCBYPROGRAMGRADE&quot;,&quot;response&quot;:{&quot;levels&quot;:{&quot;level&quot;:[{&quot;hierarchy&quot;:&quot;1&quot;, &quot;type&quot;:&quot;gra}de&quot;, &quot;level_number&quot;:&quot;0]&quot;, &quot;level&quot;:[{&quot;hierarchy&quot;:&quot;1&quot;, &quot;type&quot;:&quot;unit&quot;, &quot;level&quot;:[{&quot;hierarchy&quot;:&quot;1&quot;, &quot;type&quot;:&quot;chapter&quot;, &quot;level&quot;:[{&quot;hierarchy&quot;:&quot;1&quot;, &quot;type&quot;:&quot;lesson&quot;, &quot;title&quot;:&quot;Algebra - Use Pictures to Add To&quot;},{&quot;hierarchy&quot;:&quot;2&quot;, &quot;type&quot;:&quot;lesson&quot;, &quot;title&quot;:&quot;Hands On - Model Adding To&quot;},{&quot;hierarchy&quot;:&quot;3&quot;, &quot;type&quot;:&quot;lesson&quot;, &quot;title&quot;:&quot;Hands On - Model Putting Together&quot;},{&quot;hierarchy&quot;:&quot;4&quot;, &quot;type&quot;:&quot;lesson&quot;, &quot;title&quot;:&quot; Problem Solvin [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string LargeJSON {
            get {
                return ResourceManager.GetString("LargeJSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;name&quot;:&quot;An Object&quot;,&quot;description&quot;:&quot;A generic object&quot;,&quot;array&quot;:[{&quot;name&quot;:&quot;Array Object #1&quot;,&quot;description&quot;:&quot;The 1st array object&quot;},{&quot;name&quot;:&quot;Array Object #2&quot;,&quot;description&quot;:&quot;The 2nd array object&quot;}]}.
        /// </summary>
        internal static string RawJSON {
            get {
                return ResourceManager.GetString("RawJSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;school&quot;: {
        ///        &quot;classrooms&quot;: [
        ///            {
        ///                &quot;name&quot;: &quot;Room #1&quot;,
        ///                &quot;teachers&quot;: [
        ///                    {
        ///                        &quot;name&quot;: &quot;Pablo&quot;,
        ///                        &quot;age&quot;: 33
        ///                    },
        ///                    {
        ///                        &quot;name&quot;: &quot;John&quot;,
        ///                        &quot;age&quot;: 28
        ///                    }
        ///                ],
        ///                &quot;blackboard&quot;: {
        ///                    &quot;madeOf&quot;: &quot;wood&quot;,
        ///                    &quot;height&quot;: &quot;100&quot;,
        ///          [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string SchoolJson {
            get {
                return ResourceManager.GetString("SchoolJson", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &quot;arrayOfComplexObjects&quot;:[{&quot;name&quot;:&quot;#1&quot;,&quot;description&quot;:&quot;Complex Array Object #1&quot;},{&quot;name&quot;:&quot;#2&quot;,&quot;description&quot;:&quot;Complex Array Object #2&quot;},{&quot;name&quot;:&quot;#3&quot;,&quot;description&quot;:&quot;Complex Array Object #3&quot;}].
        /// </summary>
        internal static string SerialisedArrayOfComplexObjects {
            get {
                return ResourceManager.GetString("SerialisedArrayOfComplexObjects", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;complexObject&quot;:{&quot;name&quot;:&quot;Complex Object&quot;,&quot;description&quot;:&quot;A complex object&quot;,&quot;complexArrayObjects&quot;:[{&quot;name&quot;:&quot;Array Object #1&quot;,&quot;description&quot;:&quot;The 1st array object&quot;},{&quot;name&quot;:&quot;Array Object #2&quot;,&quot;description&quot;:&quot;The 2nd array object&quot;}],&quot;doubles&quot;:[1,2.5,10.8]}}.
        /// </summary>
        internal static string SerialisedComplexObject {
            get {
                return ResourceManager.GetString("SerialisedComplexObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;name&quot;:&quot;Nested Object&quot;,&quot;level1&quot;:{&quot;name&quot;:&quot;Level1&quot;,&quot;description&quot;:&quot;Level #1&quot;,&quot;count&quot;:1,&quot;level2&quot;:{&quot;name&quot;:&quot;Level2&quot;,&quot;description&quot;:&quot;Level #2&quot;,&quot;count&quot;:2,&quot;level3&quot;:{&quot;name&quot;:&quot;Level3&quot;,&quot;description&quot;:&quot;Level #3&quot;,&quot;count&quot;:3},&quot;strings&quot;:[&quot;First&quot;,&quot;Second&quot;,&quot;Third&quot;]}}}.
        /// </summary>
        internal static string SerialisedNestedObject {
            get {
                return ResourceManager.GetString("SerialisedNestedObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;objectWithARawJsonProperty&quot;:{&quot;raw&quot;:{&quot;name&quot;:&quot;An Object&quot;,&quot;description&quot;:&quot;A generic object&quot;,&quot;array&quot;:[{&quot;name&quot;:&quot;Array Object #1&quot;,&quot;description&quot;:&quot;The 1st array object&quot;},{&quot;name&quot;:&quot;Array Object #2&quot;,&quot;description&quot;:&quot;The 2nd array object&quot;}]}}}.
        /// </summary>
        internal static string SerialisedObjectWithARawJSONProperty {
            get {
                return ResourceManager.GetString("SerialisedObjectWithARawJSONProperty", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {&quot;reasonablyComplexObject&quot;:{&quot;name&quot;:&quot;Reasonably Complex Object&quot;,&quot;count&quot;:100,&quot;strings&quot;:[&quot;One&quot;,&quot;Two&quot;,&quot;Three&quot;],&quot;floats&quot;:[1,2,3],&quot;level2&quot;:{&quot;name&quot;:&quot;Level2&quot;,&quot;description&quot;:&quot;Level #2&quot;,&quot;count&quot;:2,&quot;level3&quot;:{&quot;name&quot;:&quot;Level3&quot;,&quot;description&quot;:&quot;Level #3&quot;,&quot;count&quot;:3},&quot;strings&quot;:[&quot;One&quot;,&quot;Two&quot;,&quot;Three&quot;]}}}.
        /// </summary>
        internal static string SerialisedReasonablyComplexObject {
            get {
                return ResourceManager.GetString("SerialisedReasonablyComplexObject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;name&quot;: &quot;Paul&quot;,
        ///    &quot;address&quot;: {
        ///        &quot;line1&quot;: &quot;1&quot;,
        ///        &quot;line2&quot;: &quot;Fake Road&quot;,
        ///        &quot;town&quot;: &quot;Some Town&quot;
        ///    }
        ///}.
        /// </summary>
        internal static string SimpleJSON {
            get {
                return ResourceManager.GetString("SimpleJSON", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {
        ///    &quot;simpleObject&quot;: {
        ///        &quot;name&quot;: &quot;Simple Object&quot;,
        ///        &quot;count&quot;: 1,
        ///        &quot;misc&quot;: [
        ///            1,
        ///            2,
        ///            3,
        ///            4,
        ///            5
        ///        ]
        ///    }
        ///}.
        /// </summary>
        internal static string VerySimpleJSON {
            get {
                return ResourceManager.GetString("VerySimpleJSON", resourceCulture);
            }
        }
    }
}

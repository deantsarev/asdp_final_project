﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ASDP.FinalProject {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ASDP.FinalProject.Resource", typeof(Resource).Assembly);
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
        ///   Looks up a localized string similar to Создано.
        /// </summary>
        internal static string Created {
            get {
                return ResourceManager.GetString("Created", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to На подписании.
        /// </summary>
        internal static string OnSign {
            get {
                return ResourceManager.GetString("OnSign", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подпись отклонена.
        /// </summary>
        internal static string Rejected {
            get {
                return ResourceManager.GetString("Rejected", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подписано директором.
        /// </summary>
        internal static string SignedByDirector {
            get {
                return ResourceManager.GetString("SignedByDirector", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Подписано тимлидом.
        /// </summary>
        internal static string SignedByTeamlid {
            get {
                return ResourceManager.GetString("SignedByTeamlid", resourceCulture);
            }
        }
    }
}

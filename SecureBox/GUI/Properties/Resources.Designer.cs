﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("GUI.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to Are you sure, you want to exit SecureBox GUI ?.
        /// </summary>
        internal static string CloseAppConfirm {
            get {
                return ResourceManager.GetString("CloseAppConfirm", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Start.exe.
        /// </summary>
        internal static string SandboxieCommandLineExecutable {
            get {
                return ResourceManager.GetString("SandboxieCommandLineExecutable", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandboxie.
        /// </summary>
        internal static string SandboxieName {
            get {
                return ResourceManager.GetString("SandboxieName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Sandboxie is not installed or &quot;SbieSvc&quot; is not running. Please install Sandboxie.
        /// </summary>
        internal static string SandboxieNotFound {
            get {
                return ResourceManager.GetString("SandboxieNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SbieSvc.
        /// </summary>
        internal static string SandboxieServiceName {
            get {
                return ResourceManager.GetString("SandboxieServiceName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to https://www.sandboxie.com/.
        /// </summary>
        internal static string SandboxieWebsite {
            get {
                return ResourceManager.GetString("SandboxieWebsite", resourceCulture);
            }
        }
    }
}

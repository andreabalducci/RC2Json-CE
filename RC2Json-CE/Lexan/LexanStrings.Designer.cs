﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RC2Json.Lexan {
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
    internal class LexanStrings {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal LexanStrings() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("RC2Json.Lexan.LexanStrings", typeof(LexanStrings).Assembly);
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
        ///   Looks up a localized string similar to Close() already executed.
        /// </summary>
        internal static string AlreadyCloseError {
            get {
                return ResourceManager.GetString("AlreadyCloseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid Tag value.
        /// </summary>
        internal static string BadTag {
            get {
                return ResourceManager.GetString("BadTag", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Token expected {0}; Token found {1}.
        /// </summary>
        internal static string BadTokenFound {
            get {
                return ResourceManager.GetString("BadTokenFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Bracket token {0} not found.
        /// </summary>
        internal static string BracketNotFound {
            get {
                return ResourceManager.GetString("BracketNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Unable to include file {0}.
        /// </summary>
        internal static string CannotInclude {
            get {
                return ResourceManager.GetString("CannotInclude", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The file does not exist.
        /// </summary>
        internal static string FileNotFound {
            get {
                return ResourceManager.GetString("FileNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid date/time format: {0}.
        /// </summary>
        internal static string InvalidDateTimeFormat {
            get {
                return ResourceManager.GetString("InvalidDateTimeFormat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Illegal define {0}. Only numerical values are allowed.
        /// </summary>
        internal static string InvalidDefine {
            get {
                return ResourceManager.GetString("InvalidDefine", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid file name..
        /// </summary>
        internal static string InvalidFileName {
            get {
                return ResourceManager.GetString("InvalidFileName", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Invalid preprocessor directive.
        /// </summary>
        internal static string InvalidPreprocessorDirective {
            get {
                return ResourceManager.GetString("InvalidPreprocessorDirective", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Include file error.
        /// </summary>
        internal static string InvalidPreprocessorFile {
            get {
                return ResourceManager.GetString("InvalidPreprocessorFile", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Call Close() before.
        /// </summary>
        internal static string NoCloseError {
            get {
                return ResourceManager.GetString("NoCloseError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Operator token {0} not found.
        /// </summary>
        internal static string OperatorNotFound {
            get {
                return ResourceManager.GetString("OperatorNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Expected Token: &apos;{0}&apos;; found token: &apos;{1}&apos;.
        /// </summary>
        internal static string TokenNotFound {
            get {
                return ResourceManager.GetString("TokenNotFound", resourceCulture);
            }
        }
    }
}

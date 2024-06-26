﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Community.PowerToys.Run.Plugin.Winget.Properties {
    using System;
    
    
    /// <summary>
    ///   Eine stark typisierte Ressourcenklasse zum Suchen von lokalisierten Zeichenfolgen usw.
    /// </summary>
    // Diese Klasse wurde von der StronglyTypedResourceBuilder automatisch generiert
    // -Klasse über ein Tool wie ResGen oder Visual Studio automatisch generiert.
    // Um einen Member hinzuzufügen oder zu entfernen, bearbeiten Sie die .ResX-Datei und führen dann ResGen
    // mit der /str-Option erneut aus, oder Sie erstellen Ihr VS-Projekt neu.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Gibt die zwischengespeicherte ResourceManager-Instanz zurück, die von dieser Klasse verwendet wird.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Community.PowerToys.Run.Plugin.Winget.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Überschreibt die CurrentUICulture-Eigenschaft des aktuellen Threads für alle
        ///   Ressourcenzuordnungen, die diese stark typisierte Ressourcenklasse verwenden.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die the default browser ähnelt.
        /// </summary>
        public static string plugin_browser {
            get {
                return ResourceManager.GetString("plugin_browser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Search a winget package ähnelt.
        /// </summary>
        public static string plugin_description {
            get {
                return ResourceManager.GetString("plugin_description", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Don&apos;t include in global results on queries that are URIs ähnelt.
        /// </summary>
        public static string plugin_global_if_uri {
            get {
                return ResourceManager.GetString("plugin_global_if_uri", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die In the default browser ähnelt.
        /// </summary>
        public static string plugin_in_browser {
            get {
                return ResourceManager.GetString("plugin_in_browser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die In {0} ähnelt.
        /// </summary>
        public static string plugin_in_browser_name {
            get {
                return ResourceManager.GetString("plugin_in_browser_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Winget ähnelt.
        /// </summary>
        public static string plugin_name {
            get {
                return ResourceManager.GetString("plugin_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Search the web in {0} ähnelt.
        /// </summary>
        public static string plugin_open {
            get {
                return ResourceManager.GetString("plugin_open", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Install ähnelt.
        /// </summary>
        public static string plugin_result_name {
            get {
                return ResourceManager.GetString("plugin_result_name", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Failed to open {0}. ähnelt.
        /// </summary>
        public static string plugin_search_failed {
            get {
                return ResourceManager.GetString("plugin_search_failed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die via winget CLI ähnelt.
        /// </summary>
        public static string plugin_via_winget_cli {
            get {
                return ResourceManager.GetString("plugin_via_winget_cli", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die update --all --source winget ähnelt.
        /// </summary>
        public static string plugin_winget_cmd_upgrade_all {
            get {
                return ResourceManager.GetString("plugin_winget_cmd_upgrade_all", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die winget  ähnelt.
        /// </summary>
        public static string plugin_winget_start_cmd {
            get {
                return ResourceManager.GetString("plugin_winget_start_cmd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Sucht eine lokalisierte Zeichenfolge, die Upgrade all winget packages ({0}) ähnelt.
        /// </summary>
        public static string plugin_winget_upgrade_all_text {
            get {
                return ResourceManager.GetString("plugin_winget_upgrade_all_text", resourceCulture);
            }
        }
    }
}

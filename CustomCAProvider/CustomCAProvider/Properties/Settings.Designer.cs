﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.AzureADSamples.CustomCAProvider.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.3.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("66bf7841-a32f-4ce2-923e-908c49ab1df3")]
        public string AzureADExtensionClientId {
            get {
                return ((string)(this["AzureADExtensionClientId"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>https://login.microsoftonline.com/common/federation/OAuth2ClaimsProvider</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AzureADAllowedRedirectUris {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AzureADAllowedRedirectUris"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("rcdemospolicies.azurewebsites.net")]
        public string ExtensionEndpointHostName {
            get {
                return ((string)(this["ExtensionEndpointHostName"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://rcdemospolicies.azurewebsites.net")]
        public string ExtensionClaimsIssuer {
            get {
                return ((string)(this["ExtensionClaimsIssuer"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>control_performed</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection SupportedExtensionClaims {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["SupportedExtensionClaims"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>urn:customcontrol:rcdemosnet</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AllowedExtensionClientIds {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AllowedExtensionClientIds"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("<?xml version=\"1.0\" encoding=\"utf-16\"?>\r\n<ArrayOfString xmlns:xsi=\"http://www.w3." +
            "org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">\r\n  <s" +
            "tring>db9bd5e1-b037-4066-88b6-a901dd8eaf38</string>\r\n</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection AllowedTenantIds {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["AllowedTenantIds"]));
            }
        }
    }
}

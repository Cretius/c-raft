﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.225
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Chraft.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("25565")]
        public int Port {
            get {
                return ((int)(this["Port"]));
            }
            set {
                this["Port"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0.0.0.0")]
        public string IPAddress {
            get {
                return ((string)(this["IPAddress"]));
            }
            set {
                this["IPAddress"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Welcome to C#raft, %u!")]
        public string MOTD {
            get {
                return ((string)(this["MOTD"]));
            }
            set {
                this["MOTD"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("8")]
        public byte SightRadius {
            get {
                return ((byte)(this["SightRadius"]));
            }
            set {
                this["SightRadius"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1419875491758983")]
        public string WorldSeed {
            get {
                return ((string)(this["WorldSeed"]));
            }
            set {
                this["WorldSeed"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SpawnX {
            get {
                return ((int)(this["SpawnX"]));
            }
            set {
                this["SpawnX"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("128")]
        public byte SpawnY {
            get {
                return ((byte)(this["SpawnY"]));
            }
            set {
                this["SpawnY"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("0")]
        public int SpawnZ {
            get {
                return ((int)(this["SpawnZ"]));
            }
            set {
                this["SpawnZ"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0:yyyy-MM-dd HH:mm:ss} [{1}] {2}")]
        public string LogFileFormat {
            get {
                return ((string)(this["LogFileFormat"]));
            }
            set {
                this["LogFileFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("{0:HH:mm:ss} [{1}] {2}")]
        public string LogConsoleFormat {
            get {
                return ((string)(this["LogConsoleFormat"]));
            }
            set {
                this["LogConsoleFormat"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("server.log")]
        public string LogFile {
            get {
                return ((string)(this["LogFile"]));
            }
            set {
                this["LogFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int LogFileLevel {
            get {
                return ((int)(this["LogFileLevel"]));
            }
            set {
                this["LogFileLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("-1")]
        public int LogConsoleLevel {
            get {
                return ((int)(this["LogConsoleLevel"]));
            }
            set {
                this["LogConsoleLevel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Plugins")]
        public string PluginFolder {
            get {
                return ((string)(this["PluginFolder"]));
            }
            set {
                this["PluginFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Worlds")]
        public string WorldsFolder {
            get {
                return ((string)(this["WorldsFolder"]));
            }
            set {
                this["WorldsFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Default")]
        public string DefaultWorldName {
            get {
                return ((string)(this["DefaultWorldName"]));
            }
            set {
                this["DefaultWorldName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Players")]
        public string PlayersFolder {
            get {
                return ((string)(this["PlayersFolder"]));
            }
            set {
                this["PlayersFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3000")]
        public int AnimalSpawnInterval {
            get {
                return ((int)(this["AnimalSpawnInterval"]));
            }
            set {
                this["AnimalSpawnInterval"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources/Items.csv")]
        public string ItemsFile {
            get {
                return ((string)(this["ItemsFile"]));
            }
            set {
                this["ItemsFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("64")]
        public sbyte DefaultStackSize {
            get {
                return ((sbyte)(this["DefaultStackSize"]));
            }
            set {
                this["DefaultStackSize"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Resources/Recipes.dat")]
        public string RecipesFile {
            get {
                return ((string)(this["RecipesFile"]));
            }
            set {
                this["RecipesFile"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool LoadFromSave {
            get {
                return ((bool)(this["LoadFromSave"]));
            }
            set {
                this["LoadFromSave"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool IrcEnabled {
            get {
                return ((bool)(this["IrcEnabled"]));
            }
            set {
                this["IrcEnabled"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("irc.esper.net")]
        public string IrcServer {
            get {
                return ((string)(this["IrcServer"]));
            }
            set {
                this["IrcServer"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("#C#raft")]
        public string IrcChannel {
            get {
                return ((string)(this["IrcChannel"]));
            }
            set {
                this["IrcChannel"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ChraftBot")]
        public string IrcNickname {
            get {
                return ((string)(this["IrcNickname"]));
            }
            set {
                this["IrcNickname"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6667")]
        public int IrcPort {
            get {
                return ((int)(this["IrcPort"]));
            }
            set {
                this["IrcPort"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUV_ -=+~!@#$%^&*()1234567890\\[]{}|;" +
            "\':\"\",./<>?áéíóúäëïöüÁÉÍÓÚÄËÏÖÜÆæ")]
        public string AllowedChatChars {
            get {
                return ((string)(this["AllowedChatChars"]));
            }
            set {
                this["AllowedChatChars"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("100")]
        public int MaxPlayers {
            get {
                return ((int)(this["MaxPlayers"]));
            }
            set {
                this["MaxPlayers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("C#raft")]
        public string ServerName {
            get {
                return ((string)(this["ServerName"]));
            }
            set {
                this["ServerName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1")]
        public int WeatherChangeFrequency {
            get {
                return ((int)(this["WeatherChangeFrequency"]));
            }
            set {
                this["WeatherChangeFrequency"] = value;
            }
        }
    }
}

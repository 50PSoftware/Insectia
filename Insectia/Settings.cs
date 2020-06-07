using System.Configuration;

namespace Insectia
{
    public class FirstRunSetting : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("true")]
        public bool FirstRun
        {
            get
            {
                return ((bool)this["FirstRun"]);
            }
            set
            {
                this["FirstRun"] = (bool)value;
            }
        }
    }

    public class Settings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool Database
        {
            get
            {
                return ((bool)this["Database"]);
            }
            set
            {
                this["Database"] = (bool)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string cestaKSouboru
        {
            get
            {
                return ((string)this["cestaKSouboru"]);
            }
            set
            {
                this["cestaKSouboru"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string přípona
        {
            get
            {
                return ((string)this["přípona"]);
            }
            set
            {
                this["přípona"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string dbname
        {
            get
            {
                return ((string)this["dbname"]);
            }
            set
            {
                this["dbname"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string server
        {
            get
            {
                return ((string)this["server"]);
            }
            set
            {
                this["server"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string username
        {
            get
            {
                return ((string)this["username"]);
            }
            set
            {
                this["username"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public byte[] password
        {
            get
            {
                return ((byte[])this["password"]);
            }
            set
            {
                this["password"] = (byte[])value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool useDatabase
        {
            get
            {
                return ((bool)this["useDatabase"]);
            }
            set
            {
                this["useDatabase"] = (bool)value;
            }
        }
    }
    public class ExportSettings : ApplicationSettingsBase
    {
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool Database
        {
            get
            {
                return ((bool)this["Database"]);
            }
            set
            {
                this["Database"] = (bool)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string cestaKSouboru
        {
            get
            {
                return ((string)this["cestaKSouboru"]);
            }
            set
            {
                this["cestaKSouboru"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string přípona
        {
            get
            {
                return ((string)this["přípona"]);
            }
            set
            {
                this["přípona"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string dbname
        {
            get
            {
                return ((string)this["dbname"]);
            }
            set
            {
                this["dbname"] = (string)value;
            }
        }

        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string server
        {
            get
            {
                return ((string)this["server"]);
            }
            set
            {
                this["server"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public string username
        {
            get
            {
                return ((string)this["username"]);
            }
            set
            {
                this["username"] = (string)value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue(null)]
        public byte[] password
        {
            get
            {
                return ((byte[])this["password"]);
            }
            set
            {
                this["password"] = (byte[])value;
            }
        }
        [UserScopedSetting()]
        [DefaultSettingValue("false")]
        public bool remember
        {
            get
            {
                return ((bool)this["remember"]);
            }
            set
            {
                this["remember"] = (bool)value;
            }
        }
    }
}

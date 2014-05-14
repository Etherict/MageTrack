using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageTrackLogic
{
    class EncryptionSettingsSection : ConfigurationSection
    {
        [ConfigurationProperty("workFactor", DefaultValue = 8, IsRequired = true)]
        [IntegerValidator(MinValue = 4, MaxValue = 32, ExcludeRange = false)]
        public int WorkForce
        {
            get
            {
                return (int)this["workFactor"];
            }
            set
            {
                this["workFactor"] = value;
            }
        }
    }
}

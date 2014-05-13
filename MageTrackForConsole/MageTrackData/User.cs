using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageTrackData
{
    public class User : IUser
    {
        public string UserName
        {
            get;
            set;
        }

        public bool IsNewUser
        {
            get;
            set;
        }

        public string HashedPassword
        {
            get;
            set;
        }

        public string PlainTextPassword
        {
            get;
            set;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MageTrackData
{
    public interface IUser
    {
        string UserName
        {
            get;
            set;
        }

        string PlainTextPassword
        {
            get;
            set;
        }

        string HashedPassword
        {
            get;
            set;
        }
        bool IsNewUser
        {
            get;
            set;
        }
    }
}

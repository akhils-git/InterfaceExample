using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class AudioManage : iPlayerManage
    {
        public string Play()
        {
            return "Audio Playing";
        }

        public string Stop()
        {
            return "Audio Stop";
        }
    }
}

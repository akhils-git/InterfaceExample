using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    public class VideoManage : iPlayerManage
    {
        public string Play()
        {
            return "Video Playing";
        }

        public string Stop()
        {
            return "Video Stop";
        }
    }
}

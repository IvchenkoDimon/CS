﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Car
{
    class Control
    {
        public Thread tControlPanelThread { get; set; }
        public Thread tEngineIdleThread { get; set; }
        public Thread tAccelerationThread { get; set; }
        public Thread tBreakingThread { get; set; }
        public Thread tFreeWeelingThread { get; set; }

    }
}

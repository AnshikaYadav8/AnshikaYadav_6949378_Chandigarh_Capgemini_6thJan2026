using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryRobotHazardAnalyzer
{
    internal class RobotSafetyException: Exception
    {
        public RobotSafetyException(string message) : base(message)
        {
        }
    }
}

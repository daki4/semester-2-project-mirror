using PrinterApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApplication.Storage;
public class MotorEventArgs : EventArgs
{
    public MotorReading Motor { get; }
    public MotorEventArgs(MotorReading motor)
    {
        Motor = motor;
    }
}

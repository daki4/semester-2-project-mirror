using PrinterApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApplication.Storage;
public class AccelerometerEventArgs
{
    public Accelerometer Accelerometer { get; }

    public AccelerometerEventArgs(Accelerometer accelerometer)
    {
        Accelerometer = accelerometer;
    }
}

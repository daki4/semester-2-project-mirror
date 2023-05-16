//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PrinterApplication.Storage;
//public class MotorStorage
//{
//    private static readonly List<Motor> _motor = new();
//    public static event EventHandler<MotorEventArgs>? OnMotorDataReceived;

//    public static void Add(Motor motor)
//    {
//        _motor.Add(motor);
//        OnMotorDataReceived?.Invoke(new object(), new(motor));
//    }
//    public IReadOnlyCollection<Motor> GetMotor(int id)
//    {
//        return _motor.Where(m => m.Id == id).ToList().AsReadOnly();
//    }
//}

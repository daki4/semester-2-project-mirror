using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrinterApplication.Models;
public class Door
{
    public bool IsOpen { get; }

    public Door(bool isOpen)
    {
        IsOpen = isOpen;
    }

    public override string ToString()
    {
        return $"IsOpen: {IsOpen}";
    }
}

﻿using PrinterApplication.Models;

namespace PrinterApplication.Storage;

public static class DoorStorage
{
    private static readonly List<Door> _door = new();
    public static event EventHandler<DoorStateChangedEventArgs>? OnDoorStateChanged;

    public static void Add(Door door)
    {
        _door.Add(door);
        if (_door.Count == 1)
        {
            OnDoorStateChanged?.Invoke(new object(), new(door.IsOpen));
        }
        else if (_door.SkipLast(1).Last().IsOpen != door.IsOpen)
        {
            OnDoorStateChanged?.Invoke(new object(), new(door.IsOpen));
        }
    }

    public static IReadOnlyCollection<Door> Door => _door;
}

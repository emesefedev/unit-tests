using UnityEngine;
using System.Collections.Generic;

public class Direction
{
    public readonly Vector3 Vector;

    private Direction(float x, float y, float z)
    {
        Vector = new Vector3(x, y, z);
    }

    public static implicit operator Vector3(Direction direction)
    {
        return direction.Vector;
    }

    public static readonly Direction None = new Direction(0, 0, 0);
    public static readonly Direction North = new Direction(0, 1, 0);
    public static readonly Direction South = new Direction(0, -1, 0);
    public static readonly Direction East = new Direction(1, 0, 0);
    public static readonly Direction West = new Direction(-1, 0, 0);
    public static readonly Direction NorthEast = new Direction(1, 1, 0);
    public static readonly Direction NorthWest = new Direction(-1, 1, 0);
    public static readonly Direction SouthEast = new Direction(1, -1, 0);
    public static readonly Direction SouthWest = new Direction(-1, -1, 0);

    private static readonly List<Direction> Directions = new List<Direction>
    {
        None,
        North,
        NorthEast,
        NorthWest,
        South,
        SouthEast,
        SouthWest,
        East,
        West
    };
}

using NUnit.Framework;
using UnityEngine;

public class DirectionEditModeTests
{
    [Test]
    public void North()
    {
        Assert.AreEqual(new Vector3(0, 1, 0), Direction.North.Vector);
    }
}
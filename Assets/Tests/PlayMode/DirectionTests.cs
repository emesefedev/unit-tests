using NUnit.Framework;
using UnityEngine;

public class DirectionTests
{
    [Test]
    public void North()
    {
        Assert.AreEqual(new Vector3(0, 1, 0), Direction.North.Vector);
    }
    
    [Test]
    public void South()
    {
        Assert.AreEqual(new Vector3(0, -1, 0), Direction.South.Vector);
    }
    
    [Test]
    public void East()
    {
        Assert.AreEqual(new Vector3(1, 0, 0), Direction.East.Vector);
    }
    
    [Test]
    public void West()
    {
        Assert.AreEqual(new Vector3(-1, 0, 0), Direction.West.Vector);
    }
    
    [Test]
    public void NorthEast()
    {
        Assert.AreEqual(new Vector3(1, 1, 0), Direction.NorthEast.Vector);
    }
    
    [Test]
    public void NorthWest()
    {
        Assert.AreEqual(new Vector3(-1, 1, 0), Direction.NorthWest.Vector);
    }
    
    [Test]
    public void SouthEast()
    {
        Assert.AreEqual(new Vector3(1, -1, 0), Direction.SouthEast.Vector);
    }
    
    [Test]
    public void SouthWest()
    {
        Assert.AreEqual(new Vector3(-1, -1, 0), Direction.SouthWest.Vector);
    }
}

using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class PlayerTests
{
    [UnityTest]
    public IEnumerator PlayerTestsWithEnumeratorPasses()
    {
        GameObject playerGO = new GameObject();
        Player player = playerGO.AddComponent<Player>();
        
        player.Move(Direction.North);
        
        yield return new WaitForSeconds(0.5f);
        
        Assert.AreEqual(new Vector3(0, 1, 0), playerGO.transform.position);
    }
}

using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InputTest
{
    [Test]
    public void InputTestSimplePasses()
    {
        SimpleMath simpleMath = new SimpleMath();
        Assert.AreEqual(expected:5, actual: simpleMath.Addition(2,3));
    }
}

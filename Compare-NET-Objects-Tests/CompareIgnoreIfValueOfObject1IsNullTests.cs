using System;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;

namespace KellermanSoftware.CompareNetObjectsTests;

[TestFixture]
public class CompareIgnoreIfValueOfObject1IsNullTests
{
    #region Class Variables
    private CompareLogic _compare;
    #endregion

    #region Setup/Teardown



    /// <summary>
    /// Code that is run before each test
    /// </summary>
    [SetUp]
    public void Initialize()
    {
        _compare = new CompareLogic();
    }

    /// <summary>
    /// Code that is run after each test
    /// </summary>
    [TearDown]
    public void Cleanup()
    {
        _compare = null;
    }
    #endregion

    #region Tests

    [Test]
    public void CompareIgnoreIfValueOfObject1IsNullTestsDifferent()
    {
        var o1 = new TesIgnoreIfExpectedIsNull {Val = null};
        var o2 = new TesIgnoreIfExpectedIsNull { Val = "" };


        Assert.IsFalse(_compare.Compare(o1, o2).AreEqual);
    }

    [Test]
    public void CompareIgnoreIfValueOfObject1IsNullTestsEqual()
    {
        _compare.Config.IgnoreIfValueOfExpectedIsNull = true;
        Assert.IsTrue(_compare.Compare(null, "x").AreEqual);
        _compare.Config.Reset();
    }
    #endregion
}


class TesIgnoreIfExpectedIsNull
{
    public String Val { get; set; }
}
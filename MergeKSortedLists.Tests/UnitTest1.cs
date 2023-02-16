namespace MergeKSortedLists.Tests;

[TestClass]
public class UnitTest1
{
    private readonly Class1 _test;

    public UnitTest1()
    {
        _test = new Class1();
    }

    [TestMethod]
    public void TestMethod1()
    {
        int sum = 0;

        ListNode[] lists =
        {
             new ListNode(1, new ListNode(4, new ListNode(5, null))),
             new ListNode(1, new ListNode(3, new ListNode(4, null))),
             new ListNode(2, new ListNode(6, null))
        };

        var answer = 26;

        var result = _test.MergeKLists(lists);

        while (result != null)
        {
            sum += result.val;
            result = result.next;
        }

        Assert.AreEqual(answer, sum);


    }

    [TestMethod]
    public void TestMethod2()
    {
        int sum = 0;

        ListNode[] lists =
        {
             new ListNode(0, null)
        };

        var answer = 0;

        var result = _test.MergeKLists(lists);

        while (result != null)
        {
            sum += result.val;
            result = result.next;
        }

        Assert.AreEqual(answer, sum);


    }
    [TestMethod]
    public void TestMethod3()
    {
        int sum = 0;

        ListNode[] lists =
        {
             new ListNode(4, new ListNode(4, new ListNode(5, null))),
             new ListNode(12, new ListNode(3, new ListNode(4, null))),
             new ListNode(2, new ListNode(62, null))
        };

        var answer = 96;

        var result = _test.MergeKLists(lists);

        while (result != null)
        {
            sum += result.val;
            result = result.next;
        }

        Assert.AreEqual(answer, sum);


    }
}
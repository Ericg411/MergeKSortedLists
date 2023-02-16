namespace MergeKSortedLists;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}
public class Class1
{
    public ListNode MergeKLists(ListNode[] lists)
    {
        ListNode result = new ListNode();
        List<int> merger = new List<int>();
        int valid = 0;

        for (int i = 0; i < lists.Length; i++)
        {
            ListNode currentNode = lists[i];
            if (currentNode != null)
            {
                valid++;
            }
            while (currentNode != null)
            {
                merger.Add(currentNode.val);
                currentNode = currentNode.next;
            }
        }

        foreach (int n in merger.OrderBy(x => -x))
        {
            if (result.val == 0 && result.next == null)
            {
                result = new ListNode(n, null);
            }
            else
            {
                result = new ListNode(n, result);
            }
        }

        if (valid > 0)
        {
            return result;
        }
        else
        {
            return null;
        }
    }

}


var node = CreateListNode(new ListNode(), new int[] { 1, 2, 3, 4, 5 });
MiddleNode(node);

ListNode MiddleNode(ListNode head)
{
    var nextOne = head.next;
    List<int> nums = new List<int>();
    nums.Add(head.val);

    while (nextOne != null)
    {
        nums.Add(nextOne.val);
        nextOne = nextOne.next;

    }

    var newLinked = new ListNode();
    var middle = nums.Count / 2;
    nums.RemoveRange(0, middle);
    var result = CreateListNode(newLinked, nums.ToArray());
    return result;
}



ListNode CreateListNode(ListNode node, int[] arr, int queue = 0)
{
    if (queue == arr.Length)
        return default;

    var num = arr[queue];
    node.val = arr[queue];
    node.next = new ListNode();
    node.next = CreateListNode(node.next, arr, ++queue);

    return node;
}


//Definition for singly-linked list.
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



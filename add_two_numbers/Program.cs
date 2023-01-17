
using System.Numerics;

AddTwoNumbers(createNode("342"), createNode("465"));

ListNode AddTwoNumbers(ListNode l1, ListNode l2)
{
    var num1Arr = extracNumberFromNode(l1).ToCharArray();
    var num2Arr = extracNumberFromNode(l2).ToCharArray();

    Array.Reverse(num1Arr);
    Array.Reverse(num2Arr);

    var num1 = BigInteger.Parse(new String(num1Arr));
    var num2 = BigInteger.Parse(new String(num2Arr));

    var sum = num1 + num2;

    var node = createNode(sum.ToString());

    return node;
}

string extracNumberFromNode(ListNode node, string num = "")
{
    string number = num;

    if (node == null)
        return "";

    number = node.val.ToString();
    number += extracNumberFromNode(node.next, number);

    return number;
}

ListNode createNode(string num, ListNode node = null)
{

    if (String.IsNullOrEmpty(num)) return null;

    if (node == null)
    {
        node = new ListNode();
        node.val = Int32.Parse(num[num.Length - 1].ToString());
    }

    node.next = createNode(num.Remove(num.Length - 1), node.next);

    return node;
}

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



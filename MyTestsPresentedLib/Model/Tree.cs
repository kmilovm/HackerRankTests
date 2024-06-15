namespace MyTestsPresentedLib.Model
{
    public class Tree
    {
        public int Value;
        public Tree? LeftTree;
        public Tree? RightTree;
    }
    
    public class ListNode(int val = 0, ListNode? next = null)
    {
      public int val = val;
      public ListNode? next = next;
    }
}

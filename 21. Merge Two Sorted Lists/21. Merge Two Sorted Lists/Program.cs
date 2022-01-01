using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Merge_Two_Sorted_Lists
{
    public class ListNode
    {
      public int val;
      public ListNode next;
        public int v1;
        public int v2;
        public int v3;
        private ListNode listNode;

        public ListNode(ListNode listNode)
        {
            this.listNode = listNode;
        }

        public ListNode(int val = 0, ListNode next = null)
      {
            this.val = val;
            this.next = next;
      }

        public ListNode(int v1, int v2, int v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }
    }
    class Program
    {
        /*You are given the heads of two sorted linked lists list1 and list2.
         Merge the two lists in a one sorted list. The list should be made by 
         splicing together the nodes of the first two lists.
         Return the head of the merged linked list.
         * 
         */
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode ( 1, 2, 4 );
            ListNode l2 = new ListNode(1, 3, 4);
            ListNode result = new ListNode(MergeTwoLists(l1, l2));
            Console.WriteLine(string.Join(", ", result));
            Console.ReadLine();

        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        { //corner case
            if (list1 == null)
            {
                return list2;
            }
            if (list2==null)
            {
                return list1;
            }

            // create a ListNode to store result
            ListNode dummy = new ListNode(-1);
            ListNode cur = dummy;

            while (list1 !=null && list2!=null)
            {
                if (list1.val < list2.val)
                {
                    cur.next = list1;
                    list1 = list1.next;

                }
                else
                {
                    cur.next = list2;
                    list2 = list2.next;
                }
                cur = cur.next;
            }

            cur.next = list1 != null ? list1 : list2;
            return dummy.next;
               




        }
    }
}

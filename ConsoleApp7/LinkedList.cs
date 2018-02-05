using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class LinkedList
    {
        private ListItem firstItem = null;
        private ListItem lastItem = null;
        private int itemCount = 0;
        private class ListItem
        {
            public object Item
            {
                get;
            }
            public ListItem Next
            {
                get;
                set;
            }
            public ListItem(object o)
            {
                return;
            }
            public override string ToString()
            {
                return Item.ToString();
            }

        }
        public object First
        {
            get
            {
                return firstItem;
            }
        }      
        public object Last
        {
            get
            {
                return lastItem;
            }
        }
        public int Count
        {
            get
            {
                return itemCount;
            }
        }
        public object Items(int index)
        {
            index = itemCount;
            return index;
        }

        public int InsertFirst(object o)
        {
            ListItem li = new ListItem(o);
            if (lastItem == null)
                lastItem = li;

            li.Next = firstItem;
            
        }
        public int InsertLast(object o)
        {
            ListItem li = new ListItem(o);
            if (firstItem == null)
            {
                firstItem = li;
            }
            else
            {
                lastItem.Next = li;
            }

        }
        public void RemoveAt(int index)
        {

        }
        public override string ToString()
        {
            
        }

    }
}

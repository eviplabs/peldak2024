using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public interface ILibrary
    {
        void AddItem(LibraryItem item);

        bool FindItem(string id);

        LibraryItem BorrowItem(string id, Member member);

        void ReturnItem(LibraryItem item, Member member);
    }

    public class NationalLibrary : ILibrary
    {
        private Dictionary<string, LibraryItem?> _items = new Dictionary<string, LibraryItem?>();

        public void AddItem(LibraryItem item)
        {
            if(_items.ContainsKey(item.GetID()))
            {
                throw new ArgumentException("Item already exists");
            }

            _items.Add(item.GetID(), item);
        }

        public bool FindItem(string id)
        {
            return _items.ContainsKey(id) && _items[id] != null;
        }

        public LibraryItem BorrowItem(string id, Member member)
        {
            if(!FindItem(id))
            {
                throw new ArgumentException("Item not found");
            }

            if(!member.CanBorrow())
            {
                throw new ArgumentException("Member cannot borrow");
            }

            return _items.Borrow(id, member);
        }

        public void ReturnItem(LibraryItem item, Member member)
        {
            if(!member.BorrowedItems.Contains(item))
            {
                throw new ArgumentException("Item not borrowed by member");
            }

            if(FindItem(item.GetID()))
            {
                throw new ArgumentException("Item already borrowed");
            }

            _items[item.GetID()] = item;
            member.BorrowedItems.Remove(item);
        }
    }

    public static class DictionaryExtensions
    {
        public static LibraryItem Borrow(this Dictionary<string, LibraryItem?> items, string id, Member member)
        {
            var item = items[id];
            items[id] = null;
            member.BorrowedItems.Add(item!);
            return item!;
        }
    }

}

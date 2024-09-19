using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Member
    {
        public string Name { get; set; }

        public List<LibraryItem> BorrowedItems { get; } = new List<LibraryItem>();

        public int BorrowedItemCount  => BorrowedItems.Count();

        public int BorrowedItemLimit { get; protected set; } = 1;

        public Member(string name)
        {
            Name = name;
        }

        public bool CanBorrow()
        {
            return BorrowedItemCount < BorrowedItemLimit;
        }
    }

    public class  PremiumMember: Member
    {
        public PremiumMember(string name):base(name)
        {
            BorrowedItemLimit = 3;
        }
    }
}


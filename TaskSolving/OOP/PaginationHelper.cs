using System;
using System.Collections.Generic;
using System.Text;

namespace TaskSolving.OOP
{
    public class PagnationHelper<T>
    {
        private IList<T> collection;
        private int itemsPerPage = 0;

        /// <summary>
        /// Constructor, takes in a list of items and the number of items that fit within a single page
        /// </summary>
        /// <param name="collection">A list of items</param>
        /// <param name="itemsPerPage">The number of items that fit within a single page</param>
        public PagnationHelper(IList<T> _collection, int _itemsPerPage)
        {
            this.itemsPerPage = _itemsPerPage;
            this.collection = _collection;
        }

        /// <summary>
        /// The number of items within the collection
        /// </summary>
        public int ItemCount => collection.Count;

        /// <summary>
        /// The number of pages
        /// </summary>
        public int PageCount
        {
            get
            {
                return (int)Math.Ceiling((double)ItemCount / itemsPerPage);
                    //(int)Math.Round((double)ItemCount / itemsPerPage, MidpointRounding.AwayFromZero);
            }
        }

        /// <summary>
        /// Returns the number of items in the page at the given page index 
        /// </summary>
        /// <param name="pageIndex">The zero-based page index to get the number of items for</param>
        /// <returns>The number of items on the specified page or -1 for pageIndex values that are out of range</returns>
        public int PageItemCount(int pageIndex)
        {
            return pageIndex >= 0 && pageIndex <= PageCount ? Math.Clamp(ItemCount - pageIndex * itemsPerPage, -1, itemsPerPage) : -1;
        }

        /// <summary>
        /// Returns the page index of the page containing the item at the given item index.
        /// </summary>
        /// <param name="itemIndex">The zero-based index of the item to get the pageIndex for</param>
        /// <returns>The zero-based page index of the page containing the item at the given item index or -1 if the item index is out of range</returns>
        public int PageIndex(int itemIndex)
        {
            return itemIndex < ItemCount && itemIndex >= 0 ? (int)Math.Ceiling((double)(itemIndex / itemsPerPage) % itemsPerPage) : -1;
        }
    }
}

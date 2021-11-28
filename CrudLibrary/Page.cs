using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrudLibrary
{
    internal class Page
    {
        public int PageNumber;
        public int countRows;
        static public int pageCount = 30;

        public Page(int temp_currentPageNumber, int temp_countRows)
        {
            PageNumber = temp_currentPageNumber;
            countRows = temp_countRows;
        }

        public List<dynamic> DisplayPage(IQueryable<dynamic> query)
        {
            return query.ToList().GetRange(PageNumber * pageCount, countRows);
        }
    }
}

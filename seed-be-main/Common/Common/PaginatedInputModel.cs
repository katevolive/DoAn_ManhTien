﻿using System.Collections.Generic;

namespace Common.Common
{
    /// <summary>
    /// This class contains properites used for paging, sorting, grouping, filtering and will be used as a parameter model
    ///
    /// SortOrder   - enum of sorting orders
    /// SortColumn  - Name of the column on which sorting has to be done,
    ///               as for now sorting can be performed only on one column at a time.
    ///FilterParams - Filtering can be done on multiple columns and for one column multiple values can be selected
    ///               key :- will be column name, Value :- will be array list of multiple values
    ///GroupingColumns - It will contain column names in a sequence on which grouping has been applied
    ///PageNumber   - Page Number to be displayed in UI, default to 1
    ///PageSize     - Number of items per page, default to 25
    /// </summary>
    public class PaginatedInputModel
    {
        public IEnumerable<SortingUtility.SortingParams> SortingParams { set; get; }
        public IEnumerable<FilterUtility.FilterParams> FilterParam { get; set; }
        public IEnumerable<string> GroupingColumns { get; set; } = null;
        private int pageNumber = 1;
        public int PageNumber { get { return pageNumber; } set { if (value > 1) pageNumber = value; } }

        private int pageSize = 25;
        public int PageSize { get { return pageSize; } set { if (value > 1) pageSize = value; } }
    }
}
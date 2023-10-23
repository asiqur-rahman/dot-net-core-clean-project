﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Core.Entities
{
    public class PaginatedDataViewModel<T>
    {
        public IEnumerable<T> Data { get; set; }
        public int TotalCount { get; set; }

        public PaginatedDataViewModel(IEnumerable<T> data, int totalCount)
        {
            Data = data;
            TotalCount = totalCount;
        }
    }
}

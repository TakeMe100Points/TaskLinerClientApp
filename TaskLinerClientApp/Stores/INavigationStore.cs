﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskLinerClientApp.Stores
{
    public interface INavigationStore
    {
        public ViewModelBase CurrentTabViewModel { get; set; }

        public event Action CurrentViewModelChanged;
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassiveViewDemo
{
    public interface IPrintDialogPresenterCallbacks
    {
        void OnSave();
        void OnMyTextChanged();
    }
}

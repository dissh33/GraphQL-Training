﻿using Database.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Interfaces
{
    public interface IPropertyRepository
    {
        IEnumerable<Property> GetAll();
    }
}

﻿using CleanArch.Domain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Interfaces
{
  public  interface ICourseRepository
    {
        IEnumerable<Course> GetCourses();
    }
}

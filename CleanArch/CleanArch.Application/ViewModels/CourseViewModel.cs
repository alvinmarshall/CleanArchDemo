﻿using System;
using System.Collections.Generic;
using System.Text;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}

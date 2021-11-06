﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityOrg.Models;
using UniversityOrg.Services;

namespace UniversityOrg.Services
{
    public class UniversityService
    {
        private StudentService _studentService;
        private TeacherService _teacherService;

        public UniversityService(StudentService studentService, TeacherService teacherService)
        {
            _teacherService = teacherService;
            _studentService = studentService;

            //TODO: Create university service
        }
    }
}
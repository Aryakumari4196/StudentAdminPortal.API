﻿using StudentAdminPortal.API.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentAdminPortal.API.Repository
{
  public  interface IStudentRepository
    {
       Task <List<Student>> GetStudentsAsync();
    }
}

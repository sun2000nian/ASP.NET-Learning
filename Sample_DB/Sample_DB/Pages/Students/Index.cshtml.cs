﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Sample_DB.Data;
using Sample_DB.Models;

namespace Sample_DB.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Sample_DB.Data.SchoolContext _context;

        public IndexModel(Sample_DB.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Student> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}

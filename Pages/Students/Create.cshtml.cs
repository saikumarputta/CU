using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CU.Models;

namespace CU.Pages.Students
{
    public class CreateModel : PageModel
    {
        private readonly CU.Models.SchoolContext _context;

        public CreateModel(CU.Models.SchoolContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Student Student { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var emptystudent = new Student();
            if (await TryUpdateModelAsync<Student>(emptystudent,"student", s => s.FirstName, s => s.LastName, s => s.EnrollmentDate))
            
            _context.Student.Add(Student);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
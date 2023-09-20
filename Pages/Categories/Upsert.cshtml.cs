using DataAccess.Data;
using DataAccess.Models;
using DataAccess;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBTD.Pages.Categories
{
    public class UpsertModel : PageModel
    {
        private readonly UnitOfWork _UnitOfWork;
        [BindProperty]  //synchonizes form fields with values in code behind
        public Category objCategory { get; set; }


        public UpsertModel(UnitOfWork UnitOfWork)  //dependency injection
        {
            _UnitOfWork = UnitOfWork;
        }

        public IActionResult OnGet(int? id)
        {
            objCategory = new Category();

            //edit mode
            if (id != 0)
            {
                objCategory = _UnitOfWork.Category.GetById(id);
            }

            if (objCategory == null)
            {
                return NotFound();
            }

            //create new mode
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //if this is a new category
            if (objCategory.CategoryId == 0)
            {
                _UnitOfWork.Category.Add(objCategory);
                TempData["success"] = "Category added Successfully";
            }
            //if category exists
            else
            {
                _UnitOfWork.Category.Update(objCategory);
                TempData["success"] = "Category updated Successfully";
            }
            _UnitOfWork.Commit();

            return RedirectToPage("./Index");
        }


    }
}

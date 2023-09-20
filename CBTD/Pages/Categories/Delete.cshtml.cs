using DataAccess.Models;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBTD.Pages.Categories
{
    public class DeleteModel : PageModel
    {
        private readonly UnitOfWork _UnitOfWork;
        [BindProperty]  //synchonizes form fields with values in code behind
        public Category objCategory { get; set; }


        public DeleteModel(UnitOfWork UnitOfWork)  //dependency injection
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
            _UnitOfWork.Category.Delete(objCategory);
            TempData["success"] = "Category deleted Successfully";
            _UnitOfWork.Commit();
            return RedirectToPage("./Index");
        }


    }
}

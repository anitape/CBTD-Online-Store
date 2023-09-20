using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBTD.Pages.Manufacturers
{
    public class DeleteModel : PageModel
    {
		private readonly UnitOfWork _UnitOfWork;
		[BindProperty]  //synchonizes form fields with values in code behind
		public Manufacturer objManufacturer { get; set; }


		public DeleteModel(UnitOfWork UnitOfWork)  //dependency injection
		{
			_UnitOfWork = UnitOfWork;
		}

		public IActionResult OnGet(int? id)
		{
			objManufacturer = new Manufacturer();

			//edit mode
			if (id != 0)
			{
				objManufacturer = _UnitOfWork.Manufacturer.GetById(id);
			}

			if (objManufacturer == null)
			{
				return NotFound();
			}

			//create new mode
			return Page();
		}

		public IActionResult OnPost()
		{
			_UnitOfWork.Manufacturer.Delete(objManufacturer);
			TempData["success"] = "Category deleted Successfully";
			_UnitOfWork.Commit();
			return RedirectToPage("./Index");
		}
	}
}

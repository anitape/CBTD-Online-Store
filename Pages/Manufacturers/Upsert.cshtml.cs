using DataAccess;
using DataAccess.Data;
using DataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CBTD.Pages.Manufacturers
{
    public class UpsertModel : PageModel
    {
		private readonly UnitOfWork _UnitOfWork;
		[BindProperty]  //synchonizes form fields with values in code behind
		public Manufacturer objManufacturer { get; set; }


		public UpsertModel(UnitOfWork UnitOfWork)  //dependency injection
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
			if (!ModelState.IsValid)
			{
				return Page();
			}

			//if this is a new category
			if (objManufacturer.ManufacturerId == 0)
			{
				_UnitOfWork.Manufacturer.Add(objManufacturer);
				TempData["success"] = "Category added Successfully";
			}
			//if category exists
			else
			{
				_UnitOfWork.Manufacturer.Update(objManufacturer);
				TempData["success"] = "Category updated Successfully";
			}
			_UnitOfWork.Commit();

			return RedirectToPage("./Index");
		}
	}
}

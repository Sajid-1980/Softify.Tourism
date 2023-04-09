using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Softify.Tourism.Project
{
    public interface IHasSelectList
    {
        Task<SelectList> GetSelectList(object selectedValue = null);

    }
}

﻿using Swastika.IO.Cms.Lib.Models;
using Swastika.Infrastructure.Data.ViewModels;
using Microsoft.EntityFrameworkCore.Storage;

namespace Swastika.IO.Cms.Lib.ViewModels
{
    public class CategoryModuleViewModel : ViewModelBase<SiocCmsContext, SiocCategoryModule, CategoryModuleViewModel>
    {
        public CategoryModuleViewModel()
        {
        }

        public CategoryModuleViewModel(SiocCategoryModule model, SiocCmsContext _context = null, IDbContextTransaction _transaction = null)
            : base(model, _context, _transaction)
        {
        }
        

        public int ModuleId { get; set; }
        public int CategoryId { get; set; }
        public bool IsActived { get; set; }
        public string Description { get; set; }


        #region overrides

        #region Async



        #endregion

        #region Sync


        #endregion

        #endregion

    }
}

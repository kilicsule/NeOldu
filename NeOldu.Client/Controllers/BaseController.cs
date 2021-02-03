using Microsoft.AspNetCore.Mvc;
using NeOldu.Data.Dal.Abstract;

namespace NeOldu.Client.Controllers
{
    public class BaseController : Controller
    {
        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork
        {
            get
            {
                if (_unitOfWork == null)
                    _unitOfWork = (IUnitOfWork)HttpContext.RequestServices.GetService(typeof(IUnitOfWork));
                return _unitOfWork;
            }
        }
    }
}

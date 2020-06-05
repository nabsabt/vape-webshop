using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using VapeWebshop.Models;
using VapeWebshop.ViewModel;

namespace VapeWebshop.Controllers
{
    public class DeviceController : ApiController
    {
        private ApplicationDbContext _context;
        public DeviceController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public DeviceViewModel Details()
        {
            DeviceViewModel viewModel = new DeviceViewModel();

            foreach(var item in _context.Devices)
            {
                viewModel.Name.Add(item.Name);
                viewModel.Output.Add(item.Output);
            }
            return viewModel;
            
        }
    }
}

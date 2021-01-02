using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eShopSolution.Application.Catalog.Products;
using Microsoft.AspNetCore.Mvc;

namespace eShopSolution.BackendApi.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IPublicProductService _pubProductService;
		public ProductController(IPublicProductService publicProductService)
		{
			this._pubProductService = publicProductService;
		}

		[HttpGet]
		public async Task<IActionResult> Get()
		{
			var product = await this._pubProductService.GetAll();
			return Ok(product);
		}
	}
}

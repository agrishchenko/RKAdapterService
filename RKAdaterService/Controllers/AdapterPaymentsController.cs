using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RKAdapterService.Models;

namespace RKAdapterService.Controllers
{
	[Route("api/Adapter")]
	[ApiController]
	public class AdapterPaymentsController : ControllerBase
	{
		protected AdapterPaymentsContext DBContext { get; private set; }

		public AdapterPaymentsController(AdapterPaymentsContext dbContext):base()
		{
			DBContext = dbContext;
		}

		[HttpGet]
		[Route("GetAllPayments")]
		public List<Payment> GetAllPayments()
		{			
			return DBContext.PaymentItems.ToList();			
		}

		[HttpPost]
		[Route("AddPayment")]
		public void AddPayment(Payment payment)
		{			
			if (DBContext.PaymentItems.Find(payment.ExternalId, payment.UserId) == null)
			{
				DBContext.PaymentItems.Add(payment);
				DBContext.SaveChanges();
			}			
		}

		[HttpPost]
		[Route("AddPaymentsListAsync")]
		async public Task AddPaymentsListAsync(List<Payment> lstPayments)
		{	
			foreach(var pay in lstPayments)
			{				
				if (await DBContext.PaymentItems.FindAsync(pay.ExternalId, pay.UserId) == null)
				{
					await DBContext.PaymentItems.AddAsync(pay);
				}
			}
			await DBContext.SaveChangesAsync();		
		}

		[HttpPost]
		[Route("AddPaymentsList")]
		public void AddPaymentsList(List<Payment> lstPayments)
		{			
			foreach (var pay in lstPayments)
			{
				if (DBContext.PaymentItems.Find(pay.ExternalId, pay.UserId) == null)
				{
					DBContext.PaymentItems.Add(pay);
				}
			}
			DBContext.SaveChanges();			
		}
	}
}

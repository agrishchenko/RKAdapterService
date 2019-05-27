using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RKAdapterService.Models
{
	public class Payment
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }
		[Required]
		public int ExternalId { get; set; }
		[Required]
		public string UserId { get; set; }
		[Required]
		public decimal Amount { get; set; }		
		public decimal Bonus { get; set; }
		public int Type { get; set; }

		public byte Processed { get; set; } = 0;
	}


}

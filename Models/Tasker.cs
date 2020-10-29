using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Pracownicy.Models
{
    public class Tasker
    {
		[Key]
		public int TaskId { get; set; }

		[Column(TypeName = "nvarchar(50)")]
		[Required(ErrorMessage = "To pole jest wymagane.")]
		[DisplayName("Nazwa")]
		public string Name { get; set; }

		[Column(TypeName = "varchar(2000)")]
		[DisplayName("Opis")]
		public string Description { get; set; }

		[Column(TypeName = "datetime")]
		[DisplayName("Data")]
		public DateTime Date { get; set; }

		[Column(TypeName = "bit")]
		[DisplayName("Wykonano")]
		public bool IsDone { get; set; }
	}
}

using System.ComponentModel.DataAnnotations;

namespace BeterVervoegen.Models
{
	public class LoginVm
	{
		[Required]
		[StringLength(10)]
		public string Username { get; set; }
		[Required]
		[StringLength(64)]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}

}
namespace Models
{
	public class User : BaseEntity
	{
		public User() : base()
		{
		}

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.User),
			Name = Resources.Models.Strings.UserKeys.Age)]

		[System.ComponentModel.DataAnnotations.Range
			(typeof(int), "25", "35",
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.RangeValidationErrorMessage)]
		public int Age { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.FullName)]

		[System.ComponentModel.DataAnnotations.Required
			(AllowEmptyStrings = false,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.RequiredValidationErrorMessage)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 50, MinimumLength = 3,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.StringLengthValidationErrorMessage)]
		public string FullName { get; set; }
		// **********

		// **********
		[System.ComponentModel.DataAnnotations.Display
			(ResourceType = typeof(Resources.Models.General),
			Name = Resources.Models.Strings.GeneralKeys.EmailAddress)]

		[System.ComponentModel.DataAnnotations.StringLength
			(maximumLength: 250, MinimumLength = 5,
			ErrorMessageResourceType = typeof(Resources.Messages),
			ErrorMessageResourceName = Resources.Strings.MessagesKeys.StringLengthValidationErrorMessage)]
		public string EmailAddress { get; set; }
		// **********
	}
}

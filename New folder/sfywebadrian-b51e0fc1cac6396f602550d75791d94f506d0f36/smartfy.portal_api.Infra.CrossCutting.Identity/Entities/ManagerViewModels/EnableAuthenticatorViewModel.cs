﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace smartfy.portal_api.Infra.CrossCutting.Identity.Entities.ManagerViewModels
{
    public class EnableAuthenticatorViewModel
    {
            [Required]
            [StringLength(10, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
            [DataType(DataType.Text)]
            [Display(Name = "Verification Code")]
            public string Code { get; set; }

            [ReadOnly(true)]
            public string SharedKey { get; set; }

            public string AuthenticatorUri { get; set; }
    }
}

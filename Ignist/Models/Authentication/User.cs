﻿using System;
using Newtonsoft.Json;

namespace Ignist.Models
{
    public class User
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty("UserName")]
        public string UserName { get; set; }

        [JsonProperty("LastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("passwordHash")]
        public string PasswordHash { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; } = "Normal"; // Default role


        [JsonProperty("PasswordResetCode")]
        public string PasswordResetCode { get; set; }

        [JsonProperty("PasswordResetCodeExpires")]
        public DateTime PasswordResetCodeExpires { get; set; }
    }
}


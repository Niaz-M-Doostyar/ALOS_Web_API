﻿using System;
using System.Collections.Generic;

namespace AlOS_API.Models.DbModels
{
    public partial class OauthAccessTokens
    {
        public string Id { get; set; }
        public ulong? UserId { get; set; }
        public ulong ClientId { get; set; }
        public string Name { get; set; }
        public string Scopes { get; set; }
        public bool Revoked { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? ExpiresAt { get; set; }
    }
}
﻿namespace TMS_API.Models.DTO
{
    public class EventPatchDTO
    {
        public long EventId { get; set; }
        public string EventName { get; set; } = string.Empty;
        public string? EventDescription { get; set; }
    }
}

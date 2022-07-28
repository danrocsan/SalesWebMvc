using System;

namespace SalesWebMvc.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }
        public int numeral { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
﻿using System;
using System.Security.Cryptography.X509Certificates;

namespace AiIntegrated.Models
{
	public class HomeIndexViewModel
	{
		public string Prompt { get; set; }
        public int ImageCount { get; set; }

        public List<string> ImageUrls { get; set; }

        public string ChatGPTResponse { get; set; }
      

        public HomeIndexViewModel() 
        {
            ImageUrls = new List<string>();
        
        }
    }
}

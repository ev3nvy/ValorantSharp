﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValorantSharp.Objects
{
	public class ValorantResult
	{
		public bool isSuccessful { get; set; }
		public string Error { get; set; }
		public object Data { get; set; }
	}
}

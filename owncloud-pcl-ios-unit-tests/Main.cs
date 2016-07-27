// -----------------------------------------
// --------- Made By Andrax ----------------
// andrax@andrax.nl  |  http://www.andrax.nl 
// github.com/andraxb
// Copyright (c) Andrax
// -----------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;

using Foundation;
using UIKit;

namespace owncloudpcliosunittests
{
	public class Application
	{
		// This is the main entry point of the application.
		static void Main (string[] args)
		{
			// if you want to use a different Application Delegate class from "UnitTestAppDelegate"
			// you can specify it here.
			UIApplication.Main (args, null, "UnitTestAppDelegate");
		}
	}
}

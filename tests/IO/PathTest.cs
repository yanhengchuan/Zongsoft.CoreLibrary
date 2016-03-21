﻿using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Zongsoft.IO
{
	[TestClass]
	public class PathTest
	{
		[TestMethod]
		public void PathParseTest()
		{
			var text = @"zfs.local:/data/images/1/year/month-day/[1]123.jpg";
			var path = Path.Parse(text);

			Assert.AreEqual("zfs.local", path.Scheme);
			Assert.AreEqual("/data/images/1/year/month-day/[1]123.jpg", path.FullPath);
			Assert.AreEqual("/data/images/1/year/month-day/", path.DirectoryName);
			Assert.AreEqual("[1]123.jpg", path.FileName);

			Assert.IsTrue(Zongsoft.IO.Path.TryParse("/images/avatar/large/steve.jpg", out path));
			Assert.IsNull(path.Scheme);
			Assert.IsTrue(path.IsFile);

			Assert.IsTrue(Zongsoft.IO.Path.TryParse("zs:", out path));
			Assert.AreEqual("zs", path.Scheme);
			Assert.IsTrue(path.IsDirectory);
			Assert.AreEqual("/", path.FullPath);
			Assert.AreEqual("zs:/", path.Url);
		}
	}
}

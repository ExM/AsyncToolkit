using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading;
using System.Diagnostics;
using System.Asynchrony;

namespace AsyncToolkit.Test
{
	[TestFixture]
	public class SleepTest
	{
		[Test]
		public void Sleep()
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			Stopwatch sw = new Stopwatch();
			sw.Start();
			bool? oTimedOut = null;
			string oText = null;

			Async.Sleep(1000, (timedOut, text) =>
				{
					sw.Stop();
					oTimedOut = timedOut;
					oText = text;
					wait.Set();
				}, "Hello world!");

			Assert.IsTrue(wait.WaitOne(2000), "2 sec elapsed");
			Assert.GreaterOrEqual(sw.ElapsedMilliseconds, 1000 - 2);
			Assert.AreEqual(true, oTimedOut);
			Assert.AreEqual("Hello world!", oText);
		}

		[Test]
		public void SleepBreak()
		{
			ManualResetEvent wait = new ManualResetEvent(false);
			Stopwatch sw = new Stopwatch();
			sw.Start();
			bool? oTimedOut = null;
			string oText = null;

			SleepSticker ss = Async.Sleep(1000, (timedOut, text) =>
			{
				sw.Stop();
				oTimedOut = timedOut;
				oText = text;
				wait.Set();
			}, "Hello world!");

			Thread.Sleep(300);
			ss.Abort();

			Assert.IsTrue(wait.WaitOne(2000), "2 sec elapsed");
			Assert.GreaterOrEqual(sw.ElapsedMilliseconds, 300 - 2);
			Assert.Less(sw.ElapsedMilliseconds, 1000 + 2);
			Assert.AreEqual(false, oTimedOut);
			Assert.AreEqual("Hello world!", oText);
		}
	}
}
